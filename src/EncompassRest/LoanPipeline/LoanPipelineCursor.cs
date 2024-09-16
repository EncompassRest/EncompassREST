using System.Collections.Generic;

namespace EncompassRest.LoanPipeline
{
    /// <summary>
    /// Loan pipeline cursor.
    /// </summary>
    public interface ILoanPipelineCursor : ICursor<LoanPipelineData>
    {
    }

    /// <summary>
    /// Loan pipeline cursor.
    /// </summary>
    public sealed class LoanPipelineCursor : Cursor<LoanPipelineData>, ILoanPipelineCursor
    {
        internal LoanPipelineCursor(EncompassRestClient client, string? cursorId, int count,
            IEnumerable<string>? fields, bool? includeArchivedLoans)
            : base(client.Pipeline, client, cursorId, count, fields, includeArchivedLoans: includeArchivedLoans)
        {
        }
    }
}