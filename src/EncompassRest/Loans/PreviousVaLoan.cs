using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PreviousVaLoan
    /// </summary>
    public sealed partial class PreviousVaLoan : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dateOfLoan;
        /// <summary>
        /// PreviousVaLoan DateOfLoan
        /// </summary>
        public DateTime? DateOfLoan { get => _dateOfLoan; set => _dateOfLoan = value; }
        private DirtyValue<DateTime?> _dateSold;
        /// <summary>
        /// PreviousVaLoan DateSold
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? DateSold { get => _dateSold; set => _dateSold = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PreviousVaLoan Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<PreviousVaLoanLoanType>> _loanType;
        /// <summary>
        /// PreviousVaLoan LoanType
        /// </summary>
        public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<int?> _previousVaLoanIndex;
        /// <summary>
        /// PreviousVaLoan PreviousVaLoanIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\"}")]
        public int? PreviousVaLoanIndex { get => _previousVaLoanIndex; set => _previousVaLoanIndex = value; }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// PreviousVaLoan PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => _propertyAddress = value; }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// PreviousVaLoan PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => _propertyCity = value; }
        private DirtyValue<bool?> _propertyOwned;
        /// <summary>
        /// PreviousVaLoan PropertyOwned
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"true\":\"Property Owned\"}")]
        public bool? PropertyOwned { get => _propertyOwned; set => _propertyOwned = value; }
        private DirtyValue<string> _propertyPostalCode;
        /// <summary>
        /// PreviousVaLoan PropertyPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PropertyPostalCode { get => _propertyPostalCode; set => _propertyPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _propertyState;
        /// <summary>
        /// PreviousVaLoan PropertyState
        /// </summary>
        public StringEnumValue<State> PropertyState { get => _propertyState; set => _propertyState = value; }
        private DirtyValue<string> _vALoanNumber;
        /// <summary>
        /// PreviousVaLoan VALoanNumber
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VALoanNumber { get => _vALoanNumber; set => _vALoanNumber = value; }
        internal override bool DirtyInternal
        {
            get => _dateOfLoan.Dirty
                || _dateSold.Dirty
                || _id.Dirty
                || _loanType.Dirty
                || _previousVaLoanIndex.Dirty
                || _propertyAddress.Dirty
                || _propertyCity.Dirty
                || _propertyOwned.Dirty
                || _propertyPostalCode.Dirty
                || _propertyState.Dirty
                || _vALoanNumber.Dirty;
            set
            {
                _dateOfLoan.Dirty = value;
                _dateSold.Dirty = value;
                _id.Dirty = value;
                _loanType.Dirty = value;
                _previousVaLoanIndex.Dirty = value;
                _propertyAddress.Dirty = value;
                _propertyCity.Dirty = value;
                _propertyOwned.Dirty = value;
                _propertyPostalCode.Dirty = value;
                _propertyState.Dirty = value;
                _vALoanNumber.Dirty = value;
            }
        }
    }
}