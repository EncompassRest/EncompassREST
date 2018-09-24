using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Property
    /// </summary>
    public sealed partial class Property : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _assessorsParcelIdentifier;
        private DirtyValue<string> _blockIdentifier;
        private DirtyValue<bool?> _borrowerHomesteadIndicator;
        private DirtyValue<StringEnumValue<BuildingStatusType>> _buildingStatusType;
        private DirtyValue<string> _city;
        private DirtyValue<bool?> _condotelIndicator;
        private DirtyValue<decimal?> _constructionImprovementCostsAmount;
        private DirtyValue<string> _county;
        private DirtyValue<int?> _financedNumberOfUnits;
        private DirtyValue<string> _floodCertificationIdentifier;
        private DirtyValue<decimal?> _freCashOutAmount;
        private DirtyValue<StringEnumValue<RefinancePurpose>> _gseRefinancePurposeType;
        private DirtyValue<StringEnumValue<GseTitleMannerHeldDescription>> _gseTitleMannerHeldDescription;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isConstructionPhaseDisclosedSeparately;
        private DirtyValue<decimal?> _landEstimatedValueAmount;
        private DirtyValue<string> _legalDescriptionText1;
        private DirtyValue<string> _legalDescriptionText2;
        private DirtyValue<bool?> _linkedIsConstructionPhaseDisclosedSeparately;
        private DirtyValue<StringEnumValue<LienType>> _linkedLienPriorityType;
        private DirtyValue<string> _linkedLoanPurposeType;
        private DirtyValue<StringEnumValue<LoanType>> _linkedMortgageType;
        private DirtyValue<StringEnumValue<LoanPurposeType>> _loanPurposeType;
        private DirtyValue<decimal?> _lotAcres;
        private DirtyValue<string> _lotIdentifier;
        private DirtyValue<string> _nameRecordingJurisdiction;
        private DirtyValue<bool?> _nonwarrantableProjectIndicator;
        private DirtyValue<decimal?> _numberOfStories;
        private DirtyValue<string> _otherLoanPurposeDescription;
        private DirtyValue<string> _postalCode;
        private DirtyValue<string> _priorLoanRecordationBookNumber;
        private DirtyValue<decimal?> _priorLoanRecordationCurrentPrincipalAmount;
        private DirtyValue<DateTime?> _priorLoanRecordationDated;
        private DirtyValue<string> _priorLoanRecordationOriginalLoanNumber;
        private DirtyValue<decimal?> _priorLoanRecordationOriginalPrincipalAmount;
        private DirtyValue<string> _priorLoanRecordationPageNumber;
        private DirtyValue<bool?> _prodIsSpInUnderservedArea;
        private DirtyValue<string> _propertyAcquiredYear;
        private DirtyValue<decimal?> _propertyExistingLienAmount;
        private DirtyValue<DateTime?> _propertyLeaseholdExpirationDate;
        private DirtyValue<decimal?> _propertyOriginalCostAmount;
        private DirtyValue<StringEnumValue<PropertyRightsType>> _propertyRightsType;
        private DirtyValue<string> _propertyUsageType;
        private DirtyValue<decimal?> _refinanceImprovementCostsAmount;
        private DirtyValue<StringEnumValue<RefinanceImprovementsType>> _refinanceImprovementsType;
        private DirtyValue<string> _refinancePropertyAcquiredYear;
        private DirtyValue<decimal?> _refinancePropertyExistingLienAmount;
        private DirtyValue<decimal?> _refinancePropertyOriginalCostAmount;
        private DirtyValue<string> _refinanceProposedImprovementsDescription;
        private DirtyValue<bool?> _ruralAreaIndicator;
        private DirtyValue<string> _sectionIdentifier;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<string> _streetAddress;
        private DirtyValue<string> _streetAddress2;
        private DirtyValue<string> _structureBuiltYear;
        private DirtyValue<bool?> _texasContinuousMoneyLoanIndicator;
        private DirtyValue<decimal?> _totalConstructionValueAmount;
        private DirtyValue<string> _typeRecordingJurisdiction;
        private DirtyValue<string> _unincorporatedAreaName;

        /// <summary>
        /// Property Info Parcel # [1894]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Parcel #")]
        public string AssessorsParcelIdentifier { get => _assessorsParcelIdentifier; set => SetField(ref _assessorsParcelIdentifier, value); }

        /// <summary>
        /// Property Info Block Identifier [2974]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Block Identifier")]
        public string BlockIdentifier { get => _blockIdentifier; set => SetField(ref _blockIdentifier, value); }

        /// <summary>
        /// Subject Property is Borrower's Homestead [3198]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property is Borrower's Homestead")]
        public bool? BorrowerHomesteadIndicator { get => _borrowerHomesteadIndicator; set => SetField(ref _borrowerHomesteadIndicator, value); }

        /// <summary>
        /// Subject Property Building Status [601]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Building Status")]
        public StringEnumValue<BuildingStatusType> BuildingStatusType { get => _buildingStatusType; set => SetField(ref _buildingStatusType, value); }

        /// <summary>
        /// Subject Property City [12]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property City")]
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// Property Info Is Condotel [3315]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Condotel")]
        public bool? CondotelIndicator { get => _condotelIndicator; set => SetField(ref _condotelIndicator, value); }

        /// <summary>
        /// Loan Info Constr Loan Improvement Cost [23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Improvement Cost")]
        public decimal? ConstructionImprovementCostsAmount { get => _constructionImprovementCostsAmount; set => SetField(ref _constructionImprovementCostsAmount, value); }

        /// <summary>
        /// Subject Property County [13]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property County")]
        public string County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// Subject Property # Units [16]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property # Units")]
        public int? FinancedNumberOfUnits { get => _financedNumberOfUnits; set => SetField(ref _financedNumberOfUnits, value); }

        /// <summary>
        /// Property Info Flood Certification Identifier [2977]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Flood Certification Identifier")]
        public string FloodCertificationIdentifier { get => _floodCertificationIdentifier; set => SetField(ref _floodCertificationIdentifier, value); }

        /// <summary>
        /// Freddie Mac Lender Cash Out Amt [CASASRN.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Mac Lender Cash Out Amt")]
        public decimal? FreCashOutAmount { get => _freCashOutAmount; set => SetField(ref _freCashOutAmount, value); }

        /// <summary>
        /// Loan Info Refi Purpose [299]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Purpose")]
        public StringEnumValue<RefinancePurpose> GseRefinancePurposeType { get => _gseRefinancePurposeType; set => SetField(ref _gseRefinancePurposeType, value); }

        /// <summary>
        /// Subject Property Manner Held [33]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Manner Held")]
        public StringEnumValue<GseTitleMannerHeldDescription> GseTitleMannerHeldDescription { get => _gseTitleMannerHeldDescription; set => SetField(ref _gseTitleMannerHeldDescription, value); }

        /// <summary>
        /// Property Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately [4084]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Construction Phase Disclosed Separately")]
        public bool? IsConstructionPhaseDisclosedSeparately { get => _isConstructionPhaseDisclosedSeparately; set => SetField(ref _isConstructionPhaseDisclosedSeparately, value); }

        /// <summary>
        /// Loan Info Constr Loan Lot Value [22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Lot Value")]
        public decimal? LandEstimatedValueAmount { get => _landEstimatedValueAmount; set => SetField(ref _landEstimatedValueAmount, value); }

        /// <summary>
        /// Subject Property Legal Desc1 [17]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Desc1")]
        public string LegalDescriptionText1 { get => _legalDescriptionText1; set => SetField(ref _legalDescriptionText1, value); }

        /// <summary>
        /// Subject Property Legal Descr 2 [1824]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 2")]
        public string LegalDescriptionText2 { get => _legalDescriptionText2; set => SetField(ref _legalDescriptionText2, value); }

        /// <summary>
        /// Trans Details Construction Phase Disclosed Separately - Copied from Linekd Loan [LINK_4084]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Construction Phase Disclosed Separately - Copied from Linekd Loan")]
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get => _linkedIsConstructionPhaseDisclosedSeparately; set => SetField(ref _linkedIsConstructionPhaseDisclosedSeparately, value); }

        /// <summary>
        /// Trans Details Lien Position - Copied from Linekd Loan [LINK_420]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lien Position - Copied from Linekd Loan")]
        public StringEnumValue<LienType> LinkedLienPriorityType { get => _linkedLienPriorityType; set => SetField(ref _linkedLienPriorityType, value); }

        /// <summary>
        /// Trans Details Loan Purpose - Copied from Linked Loan [LINK_19]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose - Copied from Linked Loan")]
        public string LinkedLoanPurposeType { get => _linkedLoanPurposeType; set => SetField(ref _linkedLoanPurposeType, value); }

        /// <summary>
        /// Trans Details Loan Type - Copied from Linekd Loan [LINK_1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type - Copied from Linekd Loan")]
        public StringEnumValue<LoanType> LinkedMortgageType { get => _linkedMortgageType; set => SetField(ref _linkedMortgageType, value); }

        /// <summary>
        /// Trans Details Loan Purpose [19]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose")]
        public StringEnumValue<LoanPurposeType> LoanPurposeType { get => _loanPurposeType; set => SetField(ref _loanPurposeType, value); }

        /// <summary>
        /// Property Info # of Lot Acres [3543]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info # of Lot Acres")]
        public decimal? LotAcres { get => _lotAcres; set => SetField(ref _lotAcres, value); }

        /// <summary>
        /// Property Info Lot Identifier [2973]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Lot Identifier")]
        public string LotIdentifier { get => _lotIdentifier; set => SetField(ref _lotIdentifier, value); }

        /// <summary>
        /// Property Info Name of Recording Jurisdiction [3559]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Name of Recording Jurisdiction")]
        public string NameRecordingJurisdiction { get => _nameRecordingJurisdiction; set => SetField(ref _nameRecordingJurisdiction, value); }

        /// <summary>
        /// Property Info Is Non-Warrantable Project [3316]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Non-Warrantable Project")]
        public bool? NonwarrantableProjectIndicator { get => _nonwarrantableProjectIndicator; set => SetField(ref _nonwarrantableProjectIndicator, value); }

        /// <summary>
        /// Property Info Number of Stories [3245]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_1, Description = "Property Info Number of Stories")]
        public decimal? NumberOfStories { get => _numberOfStories; set => SetField(ref _numberOfStories, value); }

        /// <summary>
        /// Trans Details Loan Purpose other [9]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose other")]
        public string OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => SetField(ref _otherLoanPurposeDescription, value); }

        /// <summary>
        /// Subject Property Zip [15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Subject Property Zip")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded [3553]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info The Book Number of the County Records in Which The Prior Mortgage is Recorded")]
        public string PriorLoanRecordationBookNumber { get => _priorLoanRecordationBookNumber; set => SetField(ref _priorLoanRecordationBookNumber, value); }

        /// <summary>
        /// Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage [3556]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info The Outstanding Unpaid Principal Balance of The Prior Mortgage")]
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get => _priorLoanRecordationCurrentPrincipalAmount; set => SetField(ref _priorLoanRecordationCurrentPrincipalAmount, value); }

        /// <summary>
        /// The date of the prior mortgage as recorded [4241]
        /// </summary>
        [LoanFieldProperty(Description = "The date of the prior mortgage as recorded")]
        public DateTime? PriorLoanRecordationDated { get => _priorLoanRecordationDated; set => SetField(ref _priorLoanRecordationDated, value); }

        /// <summary>
        /// The original loan number of the prior mortgage [4240]
        /// </summary>
        [LoanFieldProperty(Description = "The original loan number of the prior mortgage")]
        public string PriorLoanRecordationOriginalLoanNumber { get => _priorLoanRecordationOriginalLoanNumber; set => SetField(ref _priorLoanRecordationOriginalLoanNumber, value); }

        /// <summary>
        /// Property Info The Original Principal Amount of The Prior Mortgage as Recorded [3555]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Property Info The Original Principal Amount of The Prior Mortgage as Recorded")]
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get => _priorLoanRecordationOriginalPrincipalAmount; set => SetField(ref _priorLoanRecordationOriginalPrincipalAmount, value); }

        /// <summary>
        /// Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded [3554]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info The Page Number of The County Records in Which The Prior Mortgage is Recorded")]
        public string PriorLoanRecordationPageNumber { get => _priorLoanRecordationPageNumber; set => SetField(ref _priorLoanRecordationPageNumber, value); }

        /// <summary>
        /// ATR\QM Management Tool - Basic Info - Subject Property is in an Underserved Area [3850]
        /// </summary>
        [LoanFieldProperty(Description = "ATR\\QM Management Tool - Basic Info - Subject Property is in an Underserved Area")]
        public bool? ProdIsSpInUnderservedArea { get => _prodIsSpInUnderservedArea; set => SetField(ref _prodIsSpInUnderservedArea, value); }

        /// <summary>
        /// Loan Info Constr Loan Yr Acquired [20]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Constr Loan Yr Acquired")]
        public string PropertyAcquiredYear { get => _propertyAcquiredYear; set => SetField(ref _propertyAcquiredYear, value); }

        /// <summary>
        /// Loan Info Constr Loan Existing Lien [10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Existing Lien")]
        public decimal? PropertyExistingLienAmount { get => _propertyExistingLienAmount; set => SetField(ref _propertyExistingLienAmount, value); }

        /// <summary>
        /// Subject Property Leasehold Expir Date [1034]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Leasehold Expir Date")]
        public DateTime? PropertyLeaseholdExpirationDate { get => _propertyLeaseholdExpirationDate; set => SetField(ref _propertyLeaseholdExpirationDate, value); }

        /// <summary>
        /// Loan Info Constr Loan Original Cost [21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Original Cost")]
        public decimal? PropertyOriginalCostAmount { get => _propertyOriginalCostAmount; set => SetField(ref _propertyOriginalCostAmount, value); }

        /// <summary>
        /// Subject Property Estate Held [1066]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Estate Held")]
        public StringEnumValue<PropertyRightsType> PropertyRightsType { get => _propertyRightsType; set => SetField(ref _propertyRightsType, value); }

        /// <summary>
        /// Subject Property Use Type [190]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Use Type")]
        public string PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

        /// <summary>
        /// Loan Info Refi Improvement Cost [29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Improvement Cost")]
        public decimal? RefinanceImprovementCostsAmount { get => _refinanceImprovementCostsAmount; set => SetField(ref _refinanceImprovementCostsAmount, value); }

        /// <summary>
        /// Loan Info Refi Improve made/to be made [30]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Improve made/to be made")]
        public StringEnumValue<RefinanceImprovementsType> RefinanceImprovementsType { get => _refinanceImprovementsType; set => SetField(ref _refinanceImprovementsType, value); }

        /// <summary>
        /// Loan Info Refi Yr Acquired [24]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Yr Acquired")]
        public string RefinancePropertyAcquiredYear { get => _refinancePropertyAcquiredYear; set => SetField(ref _refinancePropertyAcquiredYear, value); }

        /// <summary>
        /// Loan Info Refi Existing Lien [26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Existing Lien")]
        public decimal? RefinancePropertyExistingLienAmount { get => _refinancePropertyExistingLienAmount; set => SetField(ref _refinancePropertyExistingLienAmount, value); }

        /// <summary>
        /// Loan Info Refi Original Cost [25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Refi Original Cost")]
        public decimal? RefinancePropertyOriginalCostAmount { get => _refinancePropertyOriginalCostAmount; set => SetField(ref _refinancePropertyOriginalCostAmount, value); }

        /// <summary>
        /// Loan Info Refi Improvement Descr [205]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Refi Improvement Descr")]
        public string RefinanceProposedImprovementsDescription { get => _refinanceProposedImprovementsDescription; set => SetField(ref _refinanceProposedImprovementsDescription, value); }

        /// <summary>
        /// Property Info Is Rural Area [3314]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Is Rural Area")]
        public bool? RuralAreaIndicator { get => _ruralAreaIndicator; set => SetField(ref _ruralAreaIndicator, value); }

        /// <summary>
        /// Property Info Section Identifier [2975]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Section Identifier")]
        public string SectionIdentifier { get => _sectionIdentifier; set => SetField(ref _sectionIdentifier, value); }

        /// <summary>
        /// Subject Property State [14]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Subject Property Street [11]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street")]
        public string StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Subject Property Street 2 [3893]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street 2")]
        public string StreetAddress2 { get => _streetAddress2; set => SetField(ref _streetAddress2, value); }

        /// <summary>
        /// Subject Property Yr Built [18]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Yr Built")]
        public string StructureBuiltYear { get => _structureBuiltYear; set => SetField(ref _structureBuiltYear, value); }

        /// <summary>
        /// Continuous Money Loan (Texas Only) [3199]
        /// </summary>
        [LoanFieldProperty(Description = "Continuous Money Loan (Texas Only)")]
        public bool? TexasContinuousMoneyLoanIndicator { get => _texasContinuousMoneyLoanIndicator; set => SetField(ref _texasContinuousMoneyLoanIndicator, value); }

        /// <summary>
        /// Loan Info Constr Loan Total [1074]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Loan Info Constr Loan Total")]
        public decimal? TotalConstructionValueAmount { get => _totalConstructionValueAmount; set => SetField(ref _totalConstructionValueAmount, value); }

        /// <summary>
        /// Property Info Type of Recording Jurisdiction [3558]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Type of Recording Jurisdiction")]
        public string TypeRecordingJurisdiction { get => _typeRecordingJurisdiction; set => SetField(ref _typeRecordingJurisdiction, value); }

        /// <summary>
        /// Property Info Unincorporated Area Name [3258]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Unincorporated Area Name")]
        public string UnincorporatedAreaName { get => _unincorporatedAreaName; set => SetField(ref _unincorporatedAreaName, value); }
    }
}