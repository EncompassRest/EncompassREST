using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Filters;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// The pipeline parameters used to specify the loans and fields to include.
    /// </summary>
    public sealed class PipelineParameters : SerializableObject
    {
        /// <summary>
        /// Pipeline filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter? Filter { get; }

        /// <summary>
        /// Guids of loans to include.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string>? LoanGuids { get; }

        /// <summary>
        /// Canonical field names to include.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string>? Fields { get; }

        /// <summary>
        /// Specifies how the results should be ordered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldSort>? SortOrder { get; }

        /// <summary>
        /// Include Archived Loans
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeArchivedLoans { get; }

        /// <summary>
        /// Pipeline parameters constructor.
        /// </summary>
        /// <param name="filter">Pipeline filter.</param>
        /// <param name="fields">Canonical field names to include.</param>
        /// <param name="sortOrder">Specifies how the results should be ordered.</param>
        /// <param name="includeArchivedLoans"></param>
        public PipelineParameters(Filter filter, IEnumerable<string>? fields = null, IEnumerable<FieldSort>? sortOrder = null, bool? includeArchivedLoans = null)
        {
            Preconditions.NotNull(filter, nameof(filter));

            Filter = filter;
            Fields = fields != null ? new ReadOnlyCollection<string>(fields.ToList()) : null;
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
            IncludeArchivedLoans = includeArchivedLoans;
        }

        /// <summary>
        /// Pipeline parameters constructor.
        /// </summary>
        /// <param name="loanGuids">Guids of loans to include.</param>
        /// <param name="fields">Canonical field names to include.</param>
        /// <param name="sortOrder">Specifies how the results should be ordered.</param>
        /// <param name="includeArchivedLoans"></param>
        public PipelineParameters(IEnumerable<string> loanGuids, IEnumerable<string>? fields = null, IEnumerable<FieldSort>? sortOrder = null, bool? includeArchivedLoans = null)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            Fields = fields != null ? new ReadOnlyCollection<string>(fields.ToList()) : null;
            SortOrder = sortOrder != null ? new ReadOnlyCollection<FieldSort>(sortOrder.ToList()) : null;
            IncludeArchivedLoans = includeArchivedLoans;
        }
    }
}