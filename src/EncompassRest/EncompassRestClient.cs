﻿using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.LoanBatch;
using EncompassRest.LoanPipeline;
using EncompassRest.Token;
using EncompassRest.Utilities;
using EncompassRest.Contacts;
using EncompassRest.CustomDataObjects;
using System.ComponentModel;

namespace EncompassRest
{
    public sealed class EncompassRestClient : IDisposable
    {
#if NET45
        static EncompassRestClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }
#endif

        public static async Task<EncompassRestClient> CreateAsync(ClientParameters parameters, Func<TokenCreator, Task<string>> tokenInitializer, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var client = new EncompassRestClient(parameters, tokenInitializer);
            var accessToken = await tokenInitializer(new TokenCreator(client, cancellationToken)).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await client.CommonCache.TryInitializeAsync(client, parameters, cancellationToken).ConfigureAwait(false);
            return client;
        }

        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(ClientParameters parameters, string instanceId, string userId, string password, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var client = new EncompassRestClient(parameters);
            var accessToken = await client.AccessToken.GetTokenFromUserCredentialsAsync(instanceId, userId, password, nameof(CreateFromUserCredentialsAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await client.CommonCache.TryInitializeAsync(client, parameters, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Task<EncompassRestClient> CreateFromUserCredentialsAsync(string apiClientId, string apiClientSecret, string instanceId, string userId, string password, CancellationToken cancellationToken = default) =>
            CreateFromUserCredentialsAsync(new ClientParameters(apiClientId, apiClientSecret), instanceId, userId, password, cancellationToken);

        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(ClientParameters parameters, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            var client = new EncompassRestClient(parameters);
            var accessToken = await client.AccessToken.GetTokenFromAuthorizationCodeAsync(redirectUri, authorizationCode, nameof(CreateFromAuthorizationCodeAsync), cancellationToken).ConfigureAwait(false);
            client.AccessToken.Token = accessToken;
            await client.CommonCache.TryInitializeAsync(client, parameters, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string apiClientId, string apiClientSecret, string redirectUri, string authorizationCode, CancellationToken cancellationToken = default) =>
            CreateFromAuthorizationCodeAsync(new ClientParameters(apiClientId, apiClientSecret), redirectUri, authorizationCode, cancellationToken);

        public static async Task<EncompassRestClient> CreateFromAccessTokenAsync(ClientParameters parameters, string accessToken, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            var client = new EncompassRestClient(parameters);
            client.AccessToken.Token = accessToken;
            await client.CommonCache.TryInitializeAsync(client, parameters, cancellationToken).ConfigureAwait(false);
            return client;
        }

        [Obsolete("Use CreateFromAccessTokenAsync instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static EncompassRestClient CreateFromAccessToken(ClientParameters parameters, string accessToken)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));

            var client = new EncompassRestClient(parameters);
            client.AccessToken.Token = accessToken;
            return client;
        }

        [Obsolete("Use the ClientParameters overload instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static EncompassRestClient CreateFromAccessToken(string apiClientId, string apiClientSecret, string accessToken) => CreateFromAccessToken(new ClientParameters(apiClientId, apiClientSecret), accessToken);
        
        private readonly Func<TokenCreator, Task<string>> _tokenInitializer;
        private int _timeoutRetryCount;

        private HttpClient _httpClient;
        private Loans.Loans _loans;
        private Schema.Schema _schema;
        private Webhook.Webhook _webhook;
        private Pipeline _pipeline;
        private BatchUpdate _batchUpdate;
        private BorrowerContacts _borrowerContacts;
        private BusinessContacts _businessContacts;
        private BorrowerContactSelector _borrowerContactSelector;
        private BusinessContactSelector _businessContactSelector;
        private ContactGroups _contactGroups;
        private ResourceLocks.ResourceLocks _resourceLocks;
        private GlobalCustomDataObjects _globalCustomDataObjects;
        private Users.Users _users;
        private LoanFolders.LoanFolders _loanFolders;
        private Settings.Settings _settings;
        private Services.Services _services;
        private Company.Company _company;
        private BaseApiClient _baseApiClient;

        #region Properties
        public AccessToken AccessToken { get; }

        public TokenExpirationHandling TokenExpirationHandling => _tokenInitializer != null ? TokenExpirationHandling.RetrieveNewToken : TokenExpirationHandling.Default;

        public TimeSpan Timeout { get; }

        public int TimeoutRetryCount
        {
            get => _timeoutRetryCount;
            set
            {
                Preconditions.GreaterThanOrEquals(value, nameof(TimeoutRetryCount), 0);
                Preconditions.LessThanOrEquals(value, nameof(TimeoutRetryCount), 3);

                _timeoutRetryCount = value;
            }
        }

        public event EventHandler<TimeoutRetryEventArgs> TimeoutRetry;

        public Loans.Loans Loans
        {
            get
            {
                var loans = _loans;
                return loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans.Loans(this)), null) ?? loans;
            }
        }

        public Schema.Schema Schema
        {
            get
            {
                var schema = _schema;
                return schema ?? Interlocked.CompareExchange(ref _schema, (schema = new Schema.Schema(this)), null) ?? schema;
            }
        }

        public Webhook.Webhook Webhook
        {
            get
            {
                var webhook = _webhook;
                return webhook ?? Interlocked.CompareExchange(ref _webhook, (webhook = new Webhook.Webhook(this)), null) ?? webhook;
            }
        }

        public Pipeline Pipeline
        {
            get
            {
                var pipeline = _pipeline;
                return pipeline ?? Interlocked.CompareExchange(ref _pipeline, (pipeline = new Pipeline(this)), null) ?? pipeline;
            }
        }

        public BatchUpdate BatchUpdate
        {
            get
            {
                var batchUpdate = _batchUpdate;
                return batchUpdate ?? Interlocked.CompareExchange(ref _batchUpdate, (batchUpdate = new BatchUpdate(this)), null) ?? batchUpdate;
            }
        }

        public BorrowerContacts BorrowerContacts
        {
            get
            {
                var borrowerContacts = _borrowerContacts;
                return borrowerContacts ?? Interlocked.CompareExchange(ref _borrowerContacts, (borrowerContacts = new BorrowerContacts(this)), null) ?? borrowerContacts;
            }
        }

        public BusinessContacts BusinessContacts
        {
            get
            {
                var businessContacts = _businessContacts;
                return businessContacts ?? Interlocked.CompareExchange(ref _businessContacts, (businessContacts = new BusinessContacts(this)), null) ?? businessContacts;
            }
        }

        public BorrowerContactSelector BorrowerContactSelector
        {
            get
            {
                var borrowerContactSelector = _borrowerContactSelector;
                return borrowerContactSelector ?? Interlocked.CompareExchange(ref _borrowerContactSelector, (borrowerContactSelector = new BorrowerContactSelector(this)), null) ?? borrowerContactSelector;
            }
        }

        public BusinessContactSelector BusinessContactSelector
        {
            get
            {
                var businessContactSelector = _businessContactSelector;
                return businessContactSelector ?? Interlocked.CompareExchange(ref _businessContactSelector, (businessContactSelector = new BusinessContactSelector(this)), null) ?? businessContactSelector;
            }
        }

        public ContactGroups ContactGroups
        {
            get
            {
                var contactGroups = _contactGroups;
                return contactGroups ?? Interlocked.CompareExchange(ref _contactGroups, (contactGroups = new ContactGroups(this)), null) ?? contactGroups;
            }
        }

        internal ResourceLocks.ResourceLocks ResourceLocks
        {
            get
            {
                var resourceLocks = _resourceLocks;
                return resourceLocks ?? Interlocked.CompareExchange(ref _resourceLocks, (resourceLocks = new ResourceLocks.ResourceLocks(this)), null) ?? resourceLocks;
            }
        }

        [Obsolete("Use EncompassRestClient.Company.GlobalCustomDataObjects instead.")]
        public GlobalCustomDataObjects GlobalCustomDataObjects
        {
            get
            {
                var globalCustomDataObjects = _globalCustomDataObjects;
                return globalCustomDataObjects ?? Interlocked.CompareExchange(ref _globalCustomDataObjects, (globalCustomDataObjects = new GlobalCustomDataObjects(this)), null) ?? globalCustomDataObjects;
            }
        }

        [Obsolete("Use EncompassRestClient.Company.Users.GetUserApis(userId).CustomDataObjects instead.")]
        public Users.Users Users
        {
            get
            {
                var users = _users;
                return users ?? Interlocked.CompareExchange(ref _users, (users = new Users.Users(this)), null) ?? users;
            }
        }

        public LoanFolders.LoanFolders LoanFolders
        {
            get
            {
                var loanFolders = _loanFolders;
                return loanFolders ?? Interlocked.CompareExchange(ref _loanFolders, (loanFolders = new LoanFolders.LoanFolders(this)), null) ?? loanFolders;
            }
        }

        public Settings.Settings Settings
        {
            get
            {
                var settings = _settings;
                return settings ?? Interlocked.CompareExchange(ref _settings, (settings = new Settings.Settings(this)), null) ?? settings;
            }
        }

        public Services.Services Services
        {
            get
            {
                var services = _services;
                return services ?? Interlocked.CompareExchange(ref _services, (services = new Services.Services(this)), null) ?? services;
            }
        }

        /// <summary>
        /// Company Apis
        /// </summary>
        public Company.Company Company
        {
            get
            {
                var company = _company;
                return company ?? Interlocked.CompareExchange(ref _company, (company = new Company.Company(this)), null) ?? company;
            }
        }

        public CommonCache CommonCache { get; }

        internal HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    httpClient = new HttpClient(new RetryHandler(this, _tokenInitializer != null))
                    {
                        Timeout = Timeout
                    };
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AccessToken.Type, AccessToken.Token);
                    httpClient = Interlocked.CompareExchange(ref _httpClient, httpClient, null) ?? httpClient;
                }
                return httpClient;
            }
        }

        public BaseApiClient BaseApiClient
        {
            get
            {
                var baseApiClient = _baseApiClient;
                return baseApiClient ?? Interlocked.CompareExchange(ref _baseApiClient, (baseApiClient = new BaseApiClient(this)), null) ?? baseApiClient;
            }
        }
        #endregion

        public event EventHandler<ApiResponseEventArgs> ApiResponse;

        internal EncompassRestClient(ClientParameters parameters, Func<TokenCreator, Task<string>> tokenInitializer = null)
        {
            Timeout = parameters.Timeout > TimeSpan.Zero ? parameters.Timeout : TimeSpan.FromSeconds(100);
            _timeoutRetryCount = parameters.TimeoutRetryCount;
            AccessToken = new AccessToken(parameters.ApiClientId, parameters.ApiClientSecret, this);
            _tokenInitializer = tokenInitializer;
            ApiResponse = parameters.ApiResponse;
            CommonCache = parameters.CommonCache ?? (parameters.CommonCache = new CommonCache());
        }

        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
        }

        internal sealed class RetryHandler : DelegatingHandler
        {
            private readonly EncompassRestClient _client;
            private readonly bool _retryOnUnauthorized;
            private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1);

            public RetryHandler(EncompassRestClient client, bool retryOnUnauthorized)
                : base(new HttpClientHandler())
            {
                _client = client;
                _retryOnUnauthorized = retryOnUnauthorized;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.Unauthorized:
                            if (_retryOnUnauthorized)
                            {
                                await _semaphoreSlim.WaitAsync(cancellationToken).ConfigureAwait(false);
                                try
                                {
                                    if (string.Equals(request.Headers.Authorization.Parameter, _client.AccessToken.Token, StringComparison.Ordinal))
                                    {
                                        _client.AccessToken.Token = await _client._tokenInitializer(new TokenCreator(_client, cancellationToken)).ConfigureAwait(false);
                                        _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_client.AccessToken.Type, _client.AccessToken.Token);
                                    }
                                }
                                finally
                                {
                                    _semaphoreSlim.Release();
                                }
                                request.Headers.Authorization = _client.HttpClient.DefaultRequestHeaders.Authorization;
                                response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                            }
                            break;
                        case HttpStatusCode.GatewayTimeout:
                            var retryCount = 0;
                            while (response.StatusCode == HttpStatusCode.GatewayTimeout && retryCount < _client.TimeoutRetryCount)
                            {
                                ++retryCount;
                                _client.TimeoutRetry?.Invoke(_client, new TimeoutRetryEventArgs(request, response, retryCount));
                                response = await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                            }
                            break;
                    }
                }
                return response;
            }

            private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                _client.ApiResponse?.Invoke(_client, new ApiResponseEventArgs(response));
                return response;
            }
        }
    }
}