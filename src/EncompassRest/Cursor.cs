using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Cursor for retrieving items.
    /// </summary>
    public interface ICursor : IApiObject
    {
        /// <summary>
        /// The cursor items count.
        /// </summary>
        int Count { get; }
        /// <summary>
        /// The cursor id.
        /// </summary>
        string? CursorId { get; }
        /// <summary>
        /// The cursor's available fields.
        /// </summary>
        IEnumerable<string> Fields { get; }

        /// <summary>
        /// Gets the items as raw json starting at the zero-based <paramref name="start"/> index with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetItemsRawAsync(int start, int? limit, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the items as raw json starting at the zero-based <paramref name="start"/> index with the specified <paramref name="fields"/> with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="fields">The fields to include in the items.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetItemsRawAsync(int start, int? limit, IEnumerable<string>? fields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the items as raw json starting at the zero-based <paramref name="start"/> index with the specified <paramref name="fields"/> with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="fields">The fields to include in the items.</param>
        /// <returns></returns>
        Task<string> GetItemsRawAsync(int start, int? limit, params string[]? fields);
    }

    /// <summary>
    /// Cursor for retrieving items.
    /// </summary>
    /// <typeparam name="TItem">Cursor's item type.</typeparam>
    public interface ICursor<TItem> : ICursor
    {
        /// <summary>
        /// Gets an item from the cursor at the zero-based <paramref name="index"/>.
        /// </summary>
        /// <param name="index">Zero-based index.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TItem> GetItemAsync(int index, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets an item from the cursor at the zero-based <paramref name="index"/> with the specified <paramref name="fields"/>.
        /// </summary>
        /// <param name="index">Zero-based index.</param>
        /// <param name="fields">The fields to include in the item.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TItem> GetItemAsync(int index, IEnumerable<string>? fields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets an item from the cursor at the zero-based <paramref name="index"/> with the specified <paramref name="fields"/>.
        /// </summary>
        /// <param name="index">Zero-based index.</param>
        /// <param name="fields">The fields to include in the item.</param>
        /// <returns></returns>
        Task<TItem> GetItemAsync(int index, params string[]? fields);
        /// <summary>
        /// Gets the items starting at the zero-based <paramref name="start"/> index with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<TItem>> GetItemsAsync(int start, int? limit, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the items starting at the zero-based <paramref name="start"/> index with the specified <paramref name="fields"/> with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="fields">The fields to include in the items.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<TItem>> GetItemsAsync(int start, int? limit, IEnumerable<string>? fields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the items starting at the zero-based <paramref name="start"/> index with the specified <paramref name="fields"/> with an optional <paramref name="limit"/> of items to return.
        /// </summary>
        /// <param name="start">Zero-based starting index.</param>
        /// <param name="limit">The maximum number of items to return.</param>
        /// <param name="fields">The fields to include in the items.</param>
        /// <returns></returns>
        Task<List<TItem>> GetItemsAsync(int start, int? limit, params string[]? fields);
    }

    /// <summary>
    /// Cursor for retrieving items.
    /// </summary>
    /// <typeparam name="TItem">Cursor's item type.</typeparam>
    public abstract class Cursor<TItem> : ICursor<TItem>
    {
        private readonly ApiObject _apiObject;

        /// <summary>
        /// The <see cref="EncompassRestClient"/> associated with the cursor.
        /// </summary>
        public EncompassRestClient Client { get; }

        IEncompassRestClient IApiObject.Client => Client;

        /// <inheritdoc/>
        public string? CursorId { get; }

        /// <inheritdoc/>
        public int Count { get; }

        /// <inheritdoc/>
        public IEnumerable<string> Fields { get; }

        /// <summary>
        /// Include Archived Loans
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeArchivedLoans { get; }
        
        internal Cursor(ApiObject apiObject, EncompassRestClient client, string? cursorId, int count, IEnumerable<string>? fields, bool? includeArchivedLoans = null)
        {
            _apiObject = apiObject;
            Client = client;
            CursorId = cursorId;
            Count = count;
            Fields = fields ?? Array<string>.Empty;
            IncludeArchivedLoans = includeArchivedLoans;
        }

        /// <inheritdoc/>
        public Task<TItem> GetItemAsync(int index, CancellationToken cancellationToken = default) => GetItemAsync(index, null, cancellationToken);

        /// <inheritdoc/>
        public Task<TItem> GetItemAsync(int index, params string[]? fields) => GetItemAsync(index, fields, CancellationToken.None);

        /// <inheritdoc/>
        public async Task<TItem> GetItemAsync(int index, IEnumerable<string>? fields, CancellationToken cancellationToken = default)
        {
            Preconditions.GreaterThanOrEquals(index, nameof(index), 0);
            Preconditions.LessThan(index, nameof(index), Count, nameof(Count));

            var data = await GetItemsAsync(index, 1, fields, cancellationToken).ConfigureAwait(false);
            return data[0];
        }

        /// <inheritdoc/>
        public Task<List<TItem>> GetItemsAsync(int start, int? limit, CancellationToken cancellationToken = default) => GetItemsAsync(start, limit, null, cancellationToken);

        /// <inheritdoc/>
        public Task<List<TItem>> GetItemsAsync(int start, int? limit, params string[]? fields) => GetItemsAsync(start, limit, fields, CancellationToken.None);

        /// <inheritdoc/>
        public Task<List<TItem>> GetItemsAsync(int start, int? limit, IEnumerable<string>? fields, CancellationToken cancellationToken = default)
        {
            Preconditions.GreaterThanOrEquals(start, nameof(start), 0);
            Preconditions.LessThan(start, nameof(start), Count, nameof(Count));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters(
                new QueryParameter("cursor", CursorId),
                new QueryParameter("start", start.ToString()));
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }
            var content = JsonStreamContent.Create(new { Fields = fields ?? Fields, IncludeArchivedLoans });

            return _apiObject.PostAsync<List<TItem>>(null, queryParameters.ToString(), content, nameof(GetItemsAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetItemsRawAsync(int start, int? limit, CancellationToken cancellationToken = default) => GetItemsRawAsync(start, limit, null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetItemsRawAsync(int start, int? limit, params string[]? fields) => GetItemsRawAsync(start, limit, fields, CancellationToken.None);

        /// <inheritdoc/>
        public Task<string> GetItemsRawAsync(int start, int? limit, IEnumerable<string>? fields, CancellationToken cancellationToken = default)
        {
            Preconditions.GreaterThanOrEquals(start, nameof(start), 0);
            Preconditions.LessThan(start, nameof(start), Count, nameof(Count));
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
            }

            var queryParameters = new QueryParameters(
                new QueryParameter("cursor", CursorId),
                new QueryParameter("start", start.ToString()));
            if (limit.HasValue)
            {
                queryParameters.Add("limit", limit.ToString());
            }
            var content = JsonStreamContent.Create(new { Fields = fields ?? Fields, IncludeArchivedLoans });

            return _apiObject.PostRawAsync(null, queryParameters.ToString(), content, nameof(GetItemsRawAsync), null, cancellationToken);
        }
    }
}