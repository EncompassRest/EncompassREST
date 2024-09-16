using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// The Loan Pipeline Apis.
    /// </summary>
    public interface IPipeline : IApiObject
    {
        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ILoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="ignoreInvalidFields">Ignores the invalid fields specified in the request body if set to <c>true</c>, else will return an error with list of invalid fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ILoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of descriptive field definitions for all canonical field names represented in the Encompass Pipeline. Canonical field names are used to view the Pipeline and perform batch loan updates.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<PipelineCanonicalNames> GetCanonicalNamesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of descriptive field definitions for all canonical field names represented in the Encompass Pipeline as raw json. Canonical field names are used to view the Pipeline and perform batch loan updates.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetCanonicalNamesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves loan IDs (GUIDs) and specified fields from loans on the Pipeline.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves loan IDs (GUIDs) and specified fields from loans on the Pipeline.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="ignoreInvalidFields">Ignores the invalid fields specified in the request body if set to <c>true</c>, else will return an error with list of invalid fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves loan IDs (GUIDs) and specified fields from loans on the Pipeline.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="limit">The maximum number of items to return. If not specified, the default limit is set to 1000. The maximum limit is 25k.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves loan IDs (GUIDs) and specified fields from loans on the Pipeline.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="limit">The maximum number of items to return. If not specified, the default limit is set to 1000. The maximum limit is 25k.</param>
        /// <param name="ignoreInvalidFields">Ignores the invalid fields specified in the request body if set to <c>true</c>, else will return an error with list of invalid fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves loan IDs (GUIDs) and specified fields from loans on the Pipeline as raw json.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ViewPipelineRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Pipeline Apis.
    /// </summary>
    public sealed class Pipeline : ApiObject, IPipeline
    {
        internal Pipeline(EncompassRestClient client)
            : base(client, "encompass/v1/loanPipeline")
        {
        }

        /// <inheritdoc/>
        public Task<PipelineCanonicalNames> GetCanonicalNamesAsync(CancellationToken cancellationToken = default) => GetAsync<PipelineCanonicalNames>("fieldDefinitions", null, nameof(GetCanonicalNamesAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetCanonicalNamesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("fieldDefinitions", queryString, nameof(GetCanonicalNamesRawAsync), null, cancellationToken);

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken = default) => CreateCursorAsync(parameters, null, cancellationToken);

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="ignoreInvalidFields">Ignores the invalid fields specified in the request body if set to <c>true</c>, else will return an error with list of invalid fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanPipelineCursor> CreateCursorAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));

            var queryParameters = new QueryParameters(
                new QueryParameter("limit", "1"),
                new QueryParameter("cursorType", "randomAccess"));

            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            return PostAsync(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(CreateCursorAsync), null, cancellationToken, async response =>
            {
                var headers = response.Headers;
                const string countHeaderName = "x-total-count";
                if (!headers.TryGetValues(countHeaderName, out var counts))
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {countHeaderName} header", response).ConfigureAwait(false);
                }
                var countString = counts.First();
                if (!int.TryParse(countString, out var count) || count < 0)
                {
                    throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} invalid {countHeaderName} header value", response).ConfigureAwait(false);
                }
                string? cursorId = null;
                if (count > 0)
                {
                    const string cursorIdHeaderName = "x-cursor";
                    if (!headers.TryGetValues(cursorIdHeaderName, out var cursorIds))
                    {
                        throw await EncompassRestException.CreateAsync($"{nameof(CreateCursorAsync)} missing {cursorIdHeaderName} header", response).ConfigureAwait(false);
                    }
                    cursorId = cursorIds.First();
                }
                return new LoanPipelineCursor(Client, cursorId, count, parameters.Fields, parameters.IncludeArchivedLoans);
            });
        }

        Task<ILoanPipelineCursor> IPipeline.CreateCursorAsync(PipelineParameters parameters, CancellationToken cancellationToken) => ((IPipeline)this).CreateCursorAsync(parameters, null, cancellationToken);

        async Task<ILoanPipelineCursor> IPipeline.CreateCursorAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken) => await CreateCursorAsync(parameters, ignoreInvalidFields, cancellationToken).ConfigureAwait(false);

        /// <inheritdoc/>
        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, null, null, cancellationToken);

        /// <inheritdoc/>
        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, limit, null, cancellationToken);

        /// <inheritdoc/>
        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => ViewPipelineAsync(parameters, null, ignoreInvalidFields, cancellationToken);

        /// <inheritdoc/>
        public Task<List<LoanPipelineData>> ViewPipelineAsync(PipelineParameters parameters, int? limit, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(parameters, nameof(parameters));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters();
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.GetValueOrDefault().ToString());
            }
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            return PostAsync<List<LoanPipelineData>>(null, queryParameters.ToString(), JsonStreamContent.Create(parameters), nameof(ViewPipelineAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> ViewPipelineRawAsync(string parameters, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(parameters, nameof(parameters));

            return PostRawAsync(null, queryString, new JsonStringContent(parameters), nameof(ViewPipelineRawAsync), null, cancellationToken);
        }
    }
}