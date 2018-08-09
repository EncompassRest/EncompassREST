using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UCDDetail
    /// </summary>
    public sealed partial class UCDDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<UCDPayoffType>> _feeAccountType;
        /// <summary>
        /// UCDDetail FeeAccountType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Open30DayChargeAccount\":\"Open 30 Day Charge Account\"}")]
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => _feeAccountType = value; }
        private DirtyValue<decimal?> _feeAmount;
        /// <summary>
        /// UCDDetail FeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeeAmount { get => _feeAmount; set => _feeAmount = value; }
        private DirtyValue<DateTime?> _feeDateFrom;
        /// <summary>
        /// UCDDetail FeeDateFrom
        /// </summary>
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => _feeDateFrom = value; }
        private DirtyValue<DateTime?> _feeDateTo;
        /// <summary>
        /// UCDDetail FeeDateTo
        /// </summary>
        public DateTime? FeeDateTo { get => _feeDateTo; set => _feeDateTo = value; }
        private DirtyValue<string> _feeDesc;
        /// <summary>
        /// UCDDetail FeeDesc
        /// </summary>
        public string FeeDesc { get => _feeDesc; set => _feeDesc = value; }
        private DirtyValue<int?> _feeIndex;
        /// <summary>
        /// UCDDetail FeeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\",\"12\":\"12\",\"13\":\"13\",\"14\":\"14\",\"15\":\"15\",\"16\":\"16\",\"17\":\"17\",\"18\":\"18\",\"19\":\"19\",\"20\":\"20\",\"21\":\"21\",\"0\":\"0\"}")]
        public int? FeeIndex { get => _feeIndex; set => _feeIndex = value; }
        private DirtyValue<string> _feePaidTo;
        /// <summary>
        /// UCDDetail FeePaidTo
        /// </summary>
        public string FeePaidTo { get => _feePaidTo; set => _feePaidTo = value; }
        private DirtyValue<bool?> _feePOC;
        /// <summary>
        /// UCDDetail FeePOC
        /// </summary>
        public bool? FeePOC { get => _feePOC; set => _feePOC = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// UCDDetail Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// UCDDetail LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\",\"17\":\"17\",\"3\":\"3\",\"16\":\"16\",\"13\":\"13\",\"19\":\"19\",\"12\":\"12\",\"14\":\"14\",\"15\":\"15\",\"18\":\"18\"}")]
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<StringEnumValue<Section>> _section;
        /// <summary>
        /// UCDDetail Section
        /// </summary>
        public StringEnumValue<Section> Section { get => _section; set => _section = value; }
    }
}