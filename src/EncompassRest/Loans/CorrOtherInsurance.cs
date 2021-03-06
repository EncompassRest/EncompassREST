using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CorrOtherInsurance
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class CorrOtherInsurance : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _addlCoverageAmount;
        private DirtyValue<string?>? _city;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _companyName;
        private DirtyValue<string?>? _contactName;
        private DirtyValue<decimal?>? _coverageAmount;
        private DirtyValue<DateTime?>? _effectiveDate;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<bool?>? _escrowedFlag;
        private DirtyValue<DateTime?>? _expirationDate;
        private DirtyValue<string?>? _fax;
        private DirtyValue<bool?>? _guaranteedReplacementCostFlag;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _includedInMasterPolicyFlag;
        private DirtyValue<bool?>? _insuranceEstimatorFlag;
        private DirtyValue<decimal?>? _maxDeductibleAmount;
        private DirtyValue<decimal?>? _maxDeductiblePerc;
        private DirtyValue<string?>? _phone;
        private DirtyValue<string?>? _policyNumber;
        private DirtyValue<StringEnumValue<PolicyType>>? _policyType;
        private DirtyValue<string?>? _policyTypeOtherDesc;
        private DirtyValue<decimal?>? _premiumAmount;
        private DirtyValue<DateTime?>? _premiumDueDate;
        private DirtyValue<decimal?>? _propertyValueUsed;
        private DirtyValue<decimal?>? _replacementValue;
        private DirtyValue<StringEnumValue<State>>? _state;
        private DirtyValue<string?>? _streetAddress;
        private DirtyValue<string?>? _zipCode;

        /// <summary>
        /// Correspondent - Other Insurance - Additional Coverage Amount [CORROINN16]
        /// </summary>
        public decimal? AddlCoverageAmount { get => _addlCoverageAmount; set => SetField(ref _addlCoverageAmount, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company City [CORROINN04]
        /// </summary>
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Comments [CORROINN26]
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Name [CORROINN02]
        /// </summary>
        public string? CompanyName { get => _companyName; set => SetField(ref _companyName, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Contact Name [CORROINN07]
        /// </summary>
        public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Coverage Amount [CORROINN25]
        /// </summary>
        public decimal? CoverageAmount { get => _coverageAmount; set => SetField(ref _coverageAmount, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Insurance Effective Date [CORROINN23]
        /// </summary>
        public DateTime? EffectiveDate { get => _effectiveDate; set => SetField(ref _effectiveDate, value); }

        /// <summary>
        /// CorrOtherInsurance EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Insurance Escrowed? [CORROINN15]
        /// </summary>
        public bool? EscrowedFlag { get => _escrowedFlag; set => SetField(ref _escrowedFlag, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Insurance Expiration Date [CORROINN24]
        /// </summary>
        public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Fax Number [CORROINN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Guaranteed Replacement Cost? [CORROINN18]
        /// </summary>
        public bool? GuaranteedReplacementCostFlag { get => _guaranteedReplacementCostFlag; set => SetField(ref _guaranteedReplacementCostFlag, value); }

        /// <summary>
        /// CorrOtherInsurance Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Included in Master Policy? [CORROINN01]
        /// </summary>
        public bool? IncludedInMasterPolicyFlag { get => _includedInMasterPolicyFlag; set => SetField(ref _includedInMasterPolicyFlag, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Insurance Estimator? [CORROINN19]
        /// </summary>
        public bool? InsuranceEstimatorFlag { get => _insuranceEstimatorFlag; set => SetField(ref _insuranceEstimatorFlag, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Maximum Deductible Amount [CORROINN21]
        /// </summary>
        public decimal? MaxDeductibleAmount { get => _maxDeductibleAmount; set => SetField(ref _maxDeductibleAmount, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Maximum Deductible Percentage [CORROINN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxDeductiblePerc { get => _maxDeductiblePerc; set => SetField(ref _maxDeductiblePerc, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Phone Number [CORROINN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Policy # [CORROINN22]
        /// </summary>
        public string? PolicyNumber { get => _policyNumber; set => SetField(ref _policyNumber, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Policy Type [CORROINN10]
        /// </summary>
        public StringEnumValue<PolicyType> PolicyType { get => _policyType; set => SetField(ref _policyType, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Policy Type Other Description [CORROINN11]
        /// </summary>
        public string? PolicyTypeOtherDesc { get => _policyTypeOtherDesc; set => SetField(ref _policyTypeOtherDesc, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Premium Amount [CORROINN12]
        /// </summary>
        public decimal? PremiumAmount { get => _premiumAmount; set => SetField(ref _premiumAmount, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Premium Due Date [CORROINN13]
        /// </summary>
        public DateTime? PremiumDueDate { get => _premiumDueDate; set => SetField(ref _premiumDueDate, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Property Value Used for Insurance [CORROINN17]
        /// </summary>
        public decimal? PropertyValueUsed { get => _propertyValueUsed; set => SetField(ref _propertyValueUsed, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Replacement Value [CORROINN14]
        /// </summary>
        public decimal? ReplacementValue { get => _replacementValue; set => SetField(ref _replacementValue, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company State [CORROINN05]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Street Address [CORROINN03]
        /// </summary>
        public string? StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Correspondent - Other Insurance - Company Zip Code [CORROINN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? ZipCode { get => _zipCode; set => SetField(ref _zipCode, value); }
    }
}