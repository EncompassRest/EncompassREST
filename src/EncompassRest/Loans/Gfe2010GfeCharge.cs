using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010GfeCharge
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ChargeBelow10Indicator) + "," + nameof(Gfe2010GfeChargeIndex))]
    public sealed partial class Gfe2010GfeCharge : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _chargeBelow10Indicator;
        /// <summary>
        /// Gfe2010GfeCharge ChargeBelow10Indicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"true\",\"false\":\"false\"}")]
        public bool? ChargeBelow10Indicator { get => _chargeBelow10Indicator; set => SetField(ref _chargeBelow10Indicator, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// Gfe2010GfeCharge Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<int?> _gfe2010GfeChargeIndex;
        /// <summary>
        /// Gfe2010GfeCharge Gfe2010GfeChargeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\",\"12\":\"12\",\"13\":\"13\",\"14\":\"14\",\"15\":\"15\",\"16\":\"16\",\"17\":\"17\",\"18\":\"18\",\"19\":\"19\",\"20\":\"20\",\"21\":\"21\",\"22\":\"22\",\"23\":\"23\",\"24\":\"24\",\"25\":\"25\",\"26\":\"26\",\"27\":\"27\",\"28\":\"28\",\"29\":\"29\",\"30\":\"30\",\"31\":\"31\",\"32\":\"32\",\"33\":\"33\",\"34\":\"34\",\"35\":\"35\"}")]
        public int? Gfe2010GfeChargeIndex { get => _gfe2010GfeChargeIndex; set => SetField(ref _gfe2010GfeChargeIndex, value); }
        private DirtyValue<decimal?> _gfeCharge;
        /// <summary>
        /// Gfe2010GfeCharge GfeCharge
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? GfeCharge { get => _gfeCharge; set => SetField(ref _gfeCharge, value); }
        private DirtyValue<decimal?> _hudCharge;
        /// <summary>
        /// Gfe2010GfeCharge HudCharge
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudCharge { get => _hudCharge; set => SetField(ref _hudCharge, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010GfeCharge Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _line;
        /// <summary>
        /// Gfe2010GfeCharge Line
        /// </summary>
        public string Line { get => _line; set => SetField(ref _line, value); }
    }
}