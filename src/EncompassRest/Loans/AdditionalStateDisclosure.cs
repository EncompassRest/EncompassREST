using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AdditionalStateDisclosure
    /// </summary>
    public sealed partial class AdditionalStateDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<DisclosureName>> _disclosureName;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureName
        /// </summary>
        public StringEnumValue<DisclosureName> DisclosureName { get => _disclosureName; set => _disclosureName = value; }
        private DirtyValue<string> _disclosureValue;
        /// <summary>
        /// AdditionalStateDisclosure DisclosureValue
        /// </summary>
        public string DisclosureValue { get => _disclosureValue; set => _disclosureValue = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// AdditionalStateDisclosure Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<State>> _stateCode;
        /// <summary>
        /// AdditionalStateDisclosure StateCode
        /// </summary>
        public StringEnumValue<State> StateCode { get => _stateCode; set => _stateCode = value; }
    }
}