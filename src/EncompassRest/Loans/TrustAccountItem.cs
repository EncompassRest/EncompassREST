using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TrustAccountItem
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class TrustAccountItem : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _date;
        private DirtyValue<string> _description;
        private DirtyValue<string> _id;
        private DirtyValue<string> _notes;
        private DirtyValue<decimal?> _paymentAmount;
        private DirtyValue<string> _paymentCheckNo;
        private DirtyValue<decimal?> _receiptAmount;
        private DirtyValue<string> _receiptCheckNo;
        private DirtyValue<int?> _trustAccountItemIndex;

        /// <summary>
        /// Trust Acct Trans Descr Date [TANNDT]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Date")]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// Trust Acct Trans Descr [TANNDS]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr")]
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// TrustAccountItem Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Trust Acct Trans Descr Notes [TANNNO]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Notes")]
        public string Notes { get => _notes; set => SetField(ref _notes, value); }

        /// <summary>
        /// Trust Acct Trans Descr Pymt Amt [TANNPA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Pymt Amt")]
        public decimal? PaymentAmount { get => _paymentAmount; set => SetField(ref _paymentAmount, value); }

        /// <summary>
        /// Trust Acct Trans Descr Pymt Check [TANNPC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Pymt Check")]
        public string PaymentCheckNo { get => _paymentCheckNo; set => SetField(ref _paymentCheckNo, value); }

        /// <summary>
        /// Trust Acct Trans Descr Receipt Amt [TANNRA]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Trans Descr Receipt Amt")]
        public decimal? ReceiptAmount { get => _receiptAmount; set => SetField(ref _receiptAmount, value); }

        /// <summary>
        /// Trust Acct Trans Descr Receipt Check [TANNRC]
        /// </summary>
        [LoanFieldProperty(Description = "Trust Acct Trans Descr Receipt Check")]
        public string ReceiptCheckNo { get => _receiptCheckNo; set => SetField(ref _receiptCheckNo, value); }

        /// <summary>
        /// TrustAccountItem TrustAccountItemIndex
        /// </summary>
        public int? TrustAccountItemIndex { get => _trustAccountItemIndex; set => SetField(ref _trustAccountItemIndex, value); }
    }
}