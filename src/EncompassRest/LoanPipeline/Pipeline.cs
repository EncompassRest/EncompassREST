﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    public sealed class Pipeline
    {
        private const string _apiPath = "encompass/v1/loanPipeline";

        public EncompassRestClient Client { get; }

        internal Pipeline(EncompassRestClient client)
        {
            Client = client;
        }

        public Task<CanonicalNames> GetCanonicalNamesAsync() => GetCanonicalNamesInternalAsync(response => response.Content.ReadAsAsync<CanonicalNames>());

        public Task<string> GetCanonicalNamesRawAsync() => GetCanonicalNamesInternalAsync(response => response.Content.ReadAsStringAsync());

        private async Task<T> GetCanonicalNamesInternalAsync<T>(Func<HttpResponseMessage, Task<T>> func)
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/fieldDefinitions").ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(GetCanonicalNamesAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }

        public Task<List<LoanPipelineData>> ViewPipelineAsync(ViewPipelineParameters parameters, int? limit = null)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit <= 0)
            {
                throw new ArgumentException("must be null or greater than 0", nameof(limit));
            }

            return ViewPipelineInternalAsync(JsonStreamContent.Create(parameters), limit, response => response.Content.ReadAsAsync<List<LoanPipelineData>>());
        }

        public Task<string> ViewPipelineRawAsync(string parameters, int? limit = null)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));
            if (limit <= 0)
            {
                throw new ArgumentException("must be null or greater than 0", nameof(limit));
            }

            return ViewPipelineInternalAsync(new JsonContent(parameters), limit, response => response.Content.ReadAsStringAsync());
        }

        private async Task<T> ViewPipelineInternalAsync<T>(HttpContent content, int? limit, Func<HttpResponseMessage, Task<T>> func)
        {
            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add(new QueryParameter("limit", limit.GetValueOrDefault().ToString()));
            }

            using (var response = await Client.HttpClient.PostAsync($"{_apiPath}{queryParameters}", content).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw await RestException.CreateAsync(nameof(ViewPipelineAsync), response).ConfigureAwait(false);
                }

                return await func(response).ConfigureAwait(false);
            }
        }
    }
}