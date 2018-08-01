using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FhaVaLoan
    /// </summary>
    public sealed partial class FhaVaLoan : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AddendumType>> _addendumType;
        /// <summary>
        /// HUD Addendum Type [1711]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Addendum Type")]
        public StringEnumValue<AddendumType> AddendumType { get => _addendumType; set => _addendumType = value; }
        private DirtyValue<bool?> _additionalCondition1;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 1 [3185]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 1")]
        public bool? AdditionalCondition1 { get => _additionalCondition1; set => _additionalCondition1 = value; }
        private DirtyValue<bool?> _additionalCondition2;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 2 [3186]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 2")]
        public bool? AdditionalCondition2 { get => _additionalCondition2; set => _additionalCondition2 = value; }
        private DirtyValue<bool?> _additionalCondition3;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 3 [3187]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 3")]
        public bool? AdditionalCondition3 { get => _additionalCondition3; set => _additionalCondition3 = value; }
        private DirtyValue<bool?> _additionalCondition4;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 4 [3188]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 4")]
        public bool? AdditionalCondition4 { get => _additionalCondition4; set => _additionalCondition4 = value; }
        private DirtyValue<bool?> _additionalCondition5;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 5 [3189]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 5")]
        public bool? AdditionalCondition5 { get => _additionalCondition5; set => _additionalCondition5 = value; }
        private DirtyValue<bool?> _additionalCondition6;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 6 [3190]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 6")]
        public bool? AdditionalCondition6 { get => _additionalCondition6; set => _additionalCondition6 = value; }
        private DirtyValue<bool?> _additionalCondition7;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 [3191]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 7")]
        public bool? AdditionalCondition7 { get => _additionalCondition7; set => _additionalCondition7 = value; }
        private DirtyValue<bool?> _additionalCondition8;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 8 [3193]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 8")]
        public bool? AdditionalCondition8 { get => _additionalCondition8; set => _additionalCondition8 = value; }
        private DirtyValue<bool?> _additionalCondition9;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 9 [3195]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 9")]
        public bool? AdditionalCondition9 { get => _additionalCondition9; set => _additionalCondition9 = value; }
        private DirtyValue<string> _addressValidatedBy;
        /// <summary>
        /// FHA Management Address Validated By [3061]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validated By")]
        public string AddressValidatedBy { get => _addressValidatedBy; set => _addressValidatedBy = value; }
        private DirtyValue<string> _addressValidationMessage;
        /// <summary>
        /// FHA Management Address Validation Message [3063]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validation Message")]
        public string AddressValidationMessage { get => _addressValidationMessage; set => _addressValidationMessage = value; }
        private DirtyValue<bool?> _allConditionsSatisfied;
        /// <summary>
        /// HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator [4092]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator")]
        public bool? AllConditionsSatisfied { get => _allConditionsSatisfied; set => _allConditionsSatisfied = value; }
        private DirtyValue<DateTime?> _appraisalLoggedDate;
        /// <summary>
        /// FHA Management Appraisal Logged Date [3076]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Appraisal Logged Date")]
        public DateTime? AppraisalLoggedDate { get => _appraisalLoggedDate; set => _appraisalLoggedDate = value; }
        private DirtyValue<string> _appraisalLookupBy;
        /// <summary>
        /// FHA Management Appraisal Lookup By [3077]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Appraisal Lookup By")]
        public string AppraisalLookupBy { get => _appraisalLookupBy; set => _appraisalLookupBy = value; }
        private DirtyValue<StringEnumValue<BeenInformed>> _beenInformed;
        /// <summary>
        /// Borr Cert Property Value [1639]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Property Value")]
        public StringEnumValue<BeenInformed> BeenInformed { get => _beenInformed; set => _beenInformed = value; }
        private DirtyValue<string> _borrowerCertificationAddress;
        /// <summary>
        /// Borr Other Ownd RE Addr [461]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Other Ownd RE Addr")]
        public string BorrowerCertificationAddress { get => _borrowerCertificationAddress; set => _borrowerCertificationAddress = value; }
        private DirtyValue<string> _borrowerCertificationCity;
        /// <summary>
        /// Borr Cert Other RE City [1738]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE City")]
        public string BorrowerCertificationCity { get => _borrowerCertificationCity; set => _borrowerCertificationCity = value; }
        private DirtyValue<string> _borrowerCertificationPostalCode;
        /// <summary>
        /// Borr Cert Other RE Zip [1740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Borr Cert Other RE Zip")]
        public string BorrowerCertificationPostalCode { get => _borrowerCertificationPostalCode; set => _borrowerCertificationPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _borrowerCertificationState;
        /// <summary>
        /// Borr Cert Other RE State [1739]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE State")]
        public StringEnumValue<State> BorrowerCertificationState { get => _borrowerCertificationState; set => _borrowerCertificationState = value; }
        private DirtyValue<string> _cAIVRSObtainedBy;
        /// <summary>
        /// FHA Management CAIVRS Obtained By [3068]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management CAIVRS Obtained By")]
        public string CAIVRSObtainedBy { get => _cAIVRSObtainedBy; set => _cAIVRSObtainedBy = value; }
        private DirtyValue<string> _caseBinderShippedBy;
        /// <summary>
        /// FHA Management Case Binder Shipped By [3091]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Case Binder Shipped By")]
        public string CaseBinderShippedBy { get => _caseBinderShippedBy; set => _caseBinderShippedBy = value; }
        private DirtyValue<DateTime?> _caseBinderShippedDate;
        /// <summary>
        /// FHA Management Case Binder Shipped Date [3090]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Case Binder Shipped Date")]
        public DateTime? CaseBinderShippedDate { get => _caseBinderShippedDate; set => _caseBinderShippedDate = value; }
        private DirtyValue<DateTime?> _closingDate;
        /// <summary>
        /// Trans Details Closed Date [748]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Closed Date")]
        public DateTime? ClosingDate { get => _closingDate; set => _closingDate = value; }
        private DirtyValue<string> _condoPudID;
        /// <summary>
        /// FHA Management CondoPud ID [3075]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management CondoPud ID")]
        public string CondoPudID { get => _condoPudID; set => _condoPudID = value; }
        private DirtyValue<string> _condoPudLookupBy;
        /// <summary>
        /// FHA Management Condo Pud Lookup By [3074]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Condo Pud Lookup By")]
        public string CondoPudLookupBy { get => _condoPudLookupBy; set => _condoPudLookupBy = value; }
        private DirtyValue<DateTime?> _condoPudLookupDate;
        /// <summary>
        /// FHA Management Condo Pud Lookup Date [3073]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Condo Pud Lookup Date")]
        public DateTime? CondoPudLookupDate { get => _condoPudLookupDate; set => _condoPudLookupDate = value; }
        private DirtyValue<decimal?> _conventionalClosingCost;
        /// <summary>
        /// Informed Consumer Choice Conventional Closing Cost [FICC.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Closing Cost")]
        public decimal? ConventionalClosingCost { get => _conventionalClosingCost; set => _conventionalClosingCost = value; }
        private DirtyValue<decimal?> _conventionalDownPayment;
        /// <summary>
        /// Informed Consumer Choice Conventional Down Payment [FICC.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Down Payment")]
        public decimal? ConventionalDownPayment { get => _conventionalDownPayment; set => _conventionalDownPayment = value; }
        private DirtyValue<decimal?> _conventionalInterestRate;
        /// <summary>
        /// Informed Consumer Choice Conventional Interest Rate [FICC.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Interest Rate")]
        public decimal? ConventionalInterestRate { get => _conventionalInterestRate; set => _conventionalInterestRate = value; }
        private DirtyValue<int?> _conventionalLoanTerm;
        /// <summary>
        /// Informed Consumer Choice Conventional Loan Term [FICC.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice Conventional Loan Term")]
        public int? ConventionalLoanTerm { get => _conventionalLoanTerm; set => _conventionalLoanTerm = value; }
        private DirtyValue<decimal?> _conventionalLTV;
        /// <summary>
        /// Informed Consumer Choice Conventional LTV [FICC.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional LTV")]
        public decimal? ConventionalLTV { get => _conventionalLTV; set => _conventionalLTV = value; }
        private DirtyValue<int?> _conventionalMaxYearsMI;
        /// <summary>
        /// Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments [FICC.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments")]
        public int? ConventionalMaxYearsMI { get => _conventionalMaxYearsMI; set => _conventionalMaxYearsMI = value; }
        private DirtyValue<decimal?> _conventionalMMI;
        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Mortgage Income [FICC.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Monthly Mortgage Income")]
        public decimal? ConventionalMMI { get => _conventionalMMI; set => _conventionalMMI = value; }
        private DirtyValue<decimal?> _conventionalMonthlyPayment;
        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Payment [FICC.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Monthly Payment")]
        public decimal? ConventionalMonthlyPayment { get => _conventionalMonthlyPayment; set => _conventionalMonthlyPayment = value; }
        private DirtyValue<decimal?> _conventionalMortgageAmount;
        /// <summary>
        /// Informed Consumer Choice Conventional Mortgage Amount [FICC.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Mortgage Amount")]
        public decimal? ConventionalMortgageAmount { get => _conventionalMortgageAmount; set => _conventionalMortgageAmount = value; }
        private DirtyValue<decimal?> _conventionalSalesPrice;
        /// <summary>
        /// Informed Consumer Choice Conventional Sales Price [FICC.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional Sales Price")]
        public decimal? ConventionalSalesPrice { get => _conventionalSalesPrice; set => _conventionalSalesPrice = value; }
        private DirtyValue<decimal?> _conventionalUMIP;
        /// <summary>
        /// Informed Consumer Choice Conventional UMIP [FICC.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice Conventional UMIP")]
        public decimal? ConventionalUMIP { get => _conventionalUMIP; set => _conventionalUMIP = value; }
        private DirtyValue<DateTime?> _dateApprovalExpires;
        /// <summary>
        /// HUD 1003 Addendum Date Approval Expires [3177]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Date Approval Expires")]
        public DateTime? DateApprovalExpires { get => _dateApprovalExpires; set => _dateApprovalExpires = value; }
        private DirtyValue<DateTime?> _dateMortgageApproved;
        /// <summary>
        /// HUD 1003 Addendum Date Mtg Approved [3176]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Date Mtg Approved")]
        public DateTime? DateMortgageApproved { get => _dateMortgageApproved; set => _dateMortgageApproved = value; }
        private DirtyValue<string> _detailForOther;
        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 Detail [3192]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Addl Condition Check 7 Detail")]
        public string DetailForOther { get => _detailForOther; set => _detailForOther = value; }
        private DirtyValue<decimal?> _discountPoints;
        /// <summary>
        /// FHA MCAW Discounts [1046]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Discounts")]
        public decimal? DiscountPoints { get => _discountPoints; set => _discountPoints = value; }
        private DirtyValue<string> _dulyAgentAddress;
        /// <summary>
        /// HUD Duly Auth Agent Addr 1 [1795]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Addr 1")]
        public string DulyAgentAddress { get => _dulyAgentAddress; set => _dulyAgentAddress = value; }
        private DirtyValue<string> _dulyAgentCity;
        /// <summary>
        /// HUD Lender Cert Author Agent Addr 2 [684]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lender Cert Author Agent Addr 2")]
        public string DulyAgentCity { get => _dulyAgentCity; set => _dulyAgentCity = value; }
        private DirtyValue<string> _dulyAgentFunction1;
        /// <summary>
        /// HUD Duly Auth Agent Function 1 [1796]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Function 1")]
        public string DulyAgentFunction1 { get => _dulyAgentFunction1; set => _dulyAgentFunction1 = value; }
        private DirtyValue<string> _dulyAgentFunction2;
        /// <summary>
        /// HUD Duly Auth Agent Function 2 [1798]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Function 2")]
        public string DulyAgentFunction2 { get => _dulyAgentFunction2; set => _dulyAgentFunction2 = value; }
        private DirtyValue<string> _dulyAgentName;
        /// <summary>
        /// HUD Duly Auth Agent Name [322]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Name")]
        public string DulyAgentName { get => _dulyAgentName; set => _dulyAgentName = value; }
        private DirtyValue<string> _dulyAgentState;
        /// <summary>
        /// HUD Duly Auth Agent Addr 3 [1797]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Duly Auth Agent Addr 3")]
        public string DulyAgentState { get => _dulyAgentState; set => _dulyAgentState = value; }
        private DirtyValue<bool?> _dwellingCoveredBy;
        /// <summary>
        /// Borr Cert Dwelling To Be Covered By Yes/No [1016]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Dwelling To Be Covered By Yes/No")]
        public bool? DwellingCoveredBy { get => _dwellingCoveredBy; set => _dwellingCoveredBy = value; }
        private EnergyEfficientMortgage _eem;
        /// <summary>
        /// FhaVaLoan Eem
        /// </summary>
        public EnergyEfficientMortgage Eem { get => _eem ?? (_eem = new EnergyEfficientMortgage()); set => _eem = value; }
        private DirtyValue<StringEnumValue<EligibilityAssessment>> _eligibilityAssessment;
        /// <summary>
        /// FHA Management Eligibility Assessment [3631]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Eligibility Assessment")]
        public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => _eligibilityAssessment; set => _eligibilityAssessment = value; }
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        /// <summary>
        /// FHA MCAW Energy Eff Improvements Amt [1721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Energy Eff Improvements Amt")]
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => _energyEfficientMortgageAmount = value; }
        private DirtyList<EnergyEfficientMortgageItem> _energyEfficientMortgageItems;
        /// <summary>
        /// FhaVaLoan EnergyEfficientMortgageItems
        /// </summary>
        public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => _energyEfficientMortgageItems ?? (_energyEfficientMortgageItems = new DirtyList<EnergyEfficientMortgageItem>()); set => _energyEfficientMortgageItems = new DirtyList<EnergyEfficientMortgageItem>(value); }
        private DirtyValue<bool?> _everHadVAHomeLoan;
        /// <summary>
        /// Borr Cert Prior VA Home Loan [1398]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Prior VA Home Loan")]
        public bool? EverHadVAHomeLoan { get => _everHadVAHomeLoan; set => _everHadVAHomeLoan = value; }
        private DirtyValue<decimal?> _excessContributionAmount;
        /// <summary>
        /// Excess Seller Contribution [3053]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Excess Seller Contribution")]
        public decimal? ExcessContributionAmount { get => _excessContributionAmount; set => _excessContributionAmount = value; }
        private DirtyValue<decimal?> _existingDebtAmount;
        /// <summary>
        /// Existing Debt for Refi Loan [3052]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Existing Debt for Refi Loan")]
        public decimal? ExistingDebtAmount { get => _existingDebtAmount; set => _existingDebtAmount = value; }
        private DirtyValue<string> _fHACaseOrderedBy;
        /// <summary>
        /// FHA Management FHA Case Ordered By [3059]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management FHA Case Ordered By")]
        public string FHACaseOrderedBy { get => _fHACaseOrderedBy; set => _fHACaseOrderedBy = value; }
        private DirtyValue<decimal?> _fHAClosingCost;
        /// <summary>
        /// Informed Consumer Choice FHA Closing Cost [FICC.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Closing Cost")]
        public decimal? FHAClosingCost { get => _fHAClosingCost; set => _fHAClosingCost = value; }
        private DirtyValue<decimal?> _fHADownPayment;
        /// <summary>
        /// Informed Consumer Choice FHA Down Payment [FICC.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Down Payment")]
        public decimal? FHADownPayment { get => _fHADownPayment; set => _fHADownPayment = value; }
        private DirtyValue<decimal?> _fHAInterestRate;
        /// <summary>
        /// Informed Consumer Choice FHA Interest Rate [FICC.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Interest Rate")]
        public decimal? FHAInterestRate { get => _fHAInterestRate; set => _fHAInterestRate = value; }
        private DirtyValue<int?> _fHALoanTerm;
        /// <summary>
        /// Informed Consumer Choice FHA Loan Term [FICC.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice FHA Loan Term")]
        public int? FHALoanTerm { get => _fHALoanTerm; set => _fHALoanTerm = value; }
        private DirtyValue<decimal?> _fHALTV;
        /// <summary>
        /// Informed Consumer Choice FHA LTV [FICC.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA LTV")]
        public decimal? FHALTV { get => _fHALTV; set => _fHALTV = value; }
        private DirtyValue<StringEnumValue<FHAManagementCounselType>> _fHAManagementCounselType;
        /// <summary>
        /// FHA Management Counsel Type [3062]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Counsel Type")]
        public StringEnumValue<FHAManagementCounselType> FHAManagementCounselType { get => _fHAManagementCounselType; set => _fHAManagementCounselType = value; }
        private DirtyValue<decimal?> _fHAMaxLoanAmount;
        /// <summary>
        /// FHA MCAW Max Loan Amt [1720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Max Loan Amt")]
        public decimal? FHAMaxLoanAmount { get => _fHAMaxLoanAmount; set => _fHAMaxLoanAmount = value; }
        private DirtyValue<decimal?> _fHAMMI;
        /// <summary>
        /// Informed Consumer Choice FHA Monthly Mortgage Income [FICC.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Monthly Mortgage Income")]
        public decimal? FHAMMI { get => _fHAMMI; set => _fHAMMI = value; }
        private DirtyValue<decimal?> _fHAMonthlyPayment;
        /// <summary>
        /// Informed Consumer Choice FHA Monthly Payment [FICC.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Monthly Payment")]
        public decimal? FHAMonthlyPayment { get => _fHAMonthlyPayment; set => _fHAMonthlyPayment = value; }
        private DirtyValue<decimal?> _fHAMortgageAmount;
        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount [FICC.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Mortgage Amount")]
        public decimal? FHAMortgageAmount { get => _fHAMortgageAmount; set => _fHAMortgageAmount = value; }
        private DirtyValue<decimal?> _fHAMortgageAmountUMIP;
        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount with UMIP [FICC.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Mortgage Amount with UMIP")]
        public decimal? FHAMortgageAmountUMIP { get => _fHAMortgageAmountUMIP; set => _fHAMortgageAmountUMIP = value; }
        private DirtyValue<decimal?> _fHASalesPrice;
        /// <summary>
        /// Informed Consumer Choice FHA Sales Price [FICC.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA Sales Price")]
        public decimal? FHASalesPrice { get => _fHASalesPrice; set => _fHASalesPrice = value; }
        private DirtyValue<decimal?> _fHAUMIP;
        /// <summary>
        /// Informed Consumer Choice FHA UMIP [FICC.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Informed Consumer Choice FHA UMIP")]
        public decimal? FHAUMIP { get => _fHAUMIP; set => _fHAUMIP = value; }
        private DirtyValue<int?> _fHAYearsMonthlyInsurance;
        /// <summary>
        /// Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments [FICC.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments")]
        public int? FHAYearsMonthlyInsurance { get => _fHAYearsMonthlyInsurance; set => _fHAYearsMonthlyInsurance = value; }
        private DirtyValue<bool?> _foreclosedProperty;
        /// <summary>
        /// FHA Process Mgmt Foreclosed Property [3093]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Process Mgmt Foreclosed Property")]
        public bool? ForeclosedProperty { get => _foreclosedProperty; set => _foreclosedProperty = value; }
        private DirtyValue<StringEnumValue<FreddieMacCounselType>> _freddieMacCounselType;
        /// <summary>
        /// Freddie Mac Counsel Type [2847]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Counsel Type")]
        public StringEnumValue<FreddieMacCounselType> FreddieMacCounselType { get => _freddieMacCounselType; set => _freddieMacCounselType = value; }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        /// <summary>
        /// FHA Funding Fee Paid in Cash [1160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA Funding Fee Paid in Cash")]
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => _fundingFeePaidInCash = value; }
        private DirtyValue<decimal?> _giftFundsAmount;
        /// <summary>
        /// Trans Details Total Gift Funds Amt [220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Total Gift Funds Amt")]
        public decimal? GiftFundsAmount { get => _giftFundsAmount; set => _giftFundsAmount = value; }
        private DirtyValue<bool?> _haveReceivedLeadPaintPoisoningInfo;
        /// <summary>
        /// HUD Rec Lead Paint Poisoning Info [1400]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Rec Lead Paint Poisoning Info")]
        public bool? HaveReceivedLeadPaintPoisoningInfo { get => _haveReceivedLeadPaintPoisoningInfo; set => _haveReceivedLeadPaintPoisoningInfo = value; }
        private DirtyValue<StringEnumValue<HUD1003AddendumApproved>> _hUD1003AddendumApproved;
        /// <summary>
        /// HUD 1003 Addendum Approved or Modified [3175]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Approved or Modified")]
        public StringEnumValue<HUD1003AddendumApproved> HUD1003AddendumApproved { get => _hUD1003AddendumApproved; set => _hUD1003AddendumApproved = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FhaVaLoan Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _lastRefiDate;
        /// <summary>
        /// FHA Management Last Refi Date [3057]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Last Refi Date")]
        public DateTime? LastRefiDate { get => _lastRefiDate; set => _lastRefiDate = value; }
        private DirtyValue<DateTime?> _lDPGSASearchDate;
        /// <summary>
        /// FHA Management LDP/GSA Search Date [3069]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management LDP/GSA Search Date")]
        public DateTime? LDPGSASearchDate { get => _lDPGSASearchDate; set => _lDPGSASearchDate = value; }
        private DirtyValue<string> _lDPGSASearchedBy;
        /// <summary>
        /// FHA Management LDP/GSA Searched By [3070]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management LDP/GSA Searched By")]
        public string LDPGSASearchedBy { get => _lDPGSASearchedBy; set => _lDPGSASearchedBy = value; }
        private DirtyValue<string> _lenderAddress;
        /// <summary>
        /// HUD 1003 Addendum Lender Addr [3633]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Addr")]
        public string LenderAddress { get => _lenderAddress; set => _lenderAddress = value; }
        private DirtyValue<string> _lenderCity;
        /// <summary>
        /// HUD 1003 Addendum Lender City [3634]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender City")]
        public string LenderCity { get => _lenderCity; set => _lenderCity = value; }
        private DirtyValue<string> _lenderName;
        /// <summary>
        /// HUD 1003 Addendum Lender Co Name [3632]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Co Name")]
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<string> _lenderNMLS;
        /// <summary>
        /// HUD 1003 Addendum Lender Info NMLS [3637]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender Info NMLS")]
        public string LenderNMLS { get => _lenderNMLS; set => _lenderNMLS = value; }
        private DirtyValue<string> _lenderPostalCode;
        /// <summary>
        /// HUD 1003 Addendum Lender Zip [3636]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HUD 1003 Addendum Lender Zip")]
        public string LenderPostalCode { get => _lenderPostalCode; set => _lenderPostalCode = value; }
        private DirtyValue<string> _lenderRepresentativeName;
        /// <summary>
        /// HUD Lenders Rep Name [1754]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lenders Rep Name")]
        public string LenderRepresentativeName { get => _lenderRepresentativeName; set => _lenderRepresentativeName = value; }
        private DirtyValue<string> _lenderRepresentativePhone;
        /// <summary>
        /// HUD Lenders Rep Phone [1756]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HUD Lenders Rep Phone")]
        public string LenderRepresentativePhone { get => _lenderRepresentativePhone; set => _lenderRepresentativePhone = value; }
        private DirtyValue<string> _lenderRepresentativeTitle;
        /// <summary>
        /// HUD Lenders Rep Title [1755]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Lenders Rep Title")]
        public string LenderRepresentativeTitle { get => _lenderRepresentativeTitle; set => _lenderRepresentativeTitle = value; }
        private DirtyValue<StringEnumValue<State>> _lenderState;
        /// <summary>
        /// HUD 1003 Addendum Lender State [3635]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Lender State")]
        public StringEnumValue<State> LenderState { get => _lenderState; set => _lenderState = value; }
        private DirtyValue<string> _lenderTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3638]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info Tax ID")]
        public string LenderTaxID { get => _lenderTaxID; set => _lenderTaxID = value; }
        private DirtyValue<string> _loanScoreID;
        /// <summary>
        /// FHA Management Loan Score ID [3630]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Loan Score ID")]
        public string LoanScoreID { get => _loanScoreID; set => _loanScoreID = value; }
        private DirtyValue<string> _mIAppliedBy;
        /// <summary>
        /// FHA Management MI Applied By [3087]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Applied By")]
        public string MIAppliedBy { get => _mIAppliedBy; set => _mIAppliedBy = value; }
        private DirtyValue<DateTime?> _mIAppliedDate;
        /// <summary>
        /// FHA Management MI Applied Date [3086]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Applied Date")]
        public DateTime? MIAppliedDate { get => _mIAppliedDate; set => _mIAppliedDate = value; }
        private DirtyValue<DateTime?> _mICRetrivedDate;
        /// <summary>
        /// FHA Management MIC Retrived Date [3089]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIC Retrived Date")]
        public DateTime? MICRetrivedDate { get => _mICRetrivedDate; set => _mICRetrivedDate = value; }
        private DirtyValue<decimal?> _minimumDownPayment;
        /// <summary>
        /// FHA MCAW Min Down Pymt [1117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Min Down Pymt")]
        public decimal? MinimumDownPayment { get => _minimumDownPayment; set => _minimumDownPayment = value; }
        private DirtyValue<DateTime?> _mIP1stDueDate;
        /// <summary>
        /// FHA Management MIP 1st Due Date [3083]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP 1st Due Date")]
        public DateTime? MIP1stDueDate { get => _mIP1stDueDate; set => _mIP1stDueDate = value; }
        private DirtyValue<DateTime?> _mIP1stToInvestor;
        /// <summary>
        /// FHA Management MIP 1st To Investor [3085]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP 1st To Investor")]
        public DateTime? MIP1stToInvestor { get => _mIP1stToInvestor; set => _mIP1stToInvestor = value; }
        private DirtyValue<DateTime?> _mIPRemittedDate;
        /// <summary>
        /// FHA Management MIP Periodic Remitted Date [3084]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MIP Periodic Remitted Date")]
        public DateTime? MIPRemittedDate { get => _mIPRemittedDate; set => _mIPRemittedDate = value; }
        private DirtyValue<DateTime?> _mIRejectedDate;
        /// <summary>
        /// FHA Management MI Rejected Date [3088]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management MI Rejected Date")]
        public DateTime? MIRejectedDate { get => _mIRejectedDate; set => _mIRejectedDate = value; }
        private DirtyValue<decimal?> _modifiedInterestRate;
        /// <summary>
        /// HUD 1003 Addendum Mod Interest Rate [3179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HUD 1003 Addendum Mod Interest Rate")]
        public decimal? ModifiedInterestRate { get => _modifiedInterestRate; set => _modifiedInterestRate = value; }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        /// <summary>
        /// HUD 1003 Addendum Mod Loan Amount [3178]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Loan Amount")]
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => _modifiedLoanAmount = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        /// <summary>
        /// HUD 1003 Addendum Mod Mthly Pymt [3182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Mthly Pymt")]
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => _modifiedMonthlyPayment = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Amt Mthly Premium [3184]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Amt Mthly Premium")]
        public decimal? ModifiedMonthlyPremium { get => _modifiedMonthlyPremium; set => _modifiedMonthlyPremium = value; }
        private DirtyValue<int?> _modifiedProposedMaturityMonth;
        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Mth [3181]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Proposed Maturity Mth")]
        public int? ModifiedProposedMaturityMonth { get => _modifiedProposedMaturityMonth; set => _modifiedProposedMaturityMonth = value; }
        private DirtyValue<int?> _modifiedProposedMaturityYear;
        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Yr [3180]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Proposed Maturity Yr")]
        public int? ModifiedProposedMaturityYear { get => _modifiedProposedMaturityYear; set => _modifiedProposedMaturityYear = value; }
        private DirtyValue<int?> _modifiedTermAnnualPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Term Annual Premium [3196]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mod Term Annual Premium")]
        public int? ModifiedTermAnnualPremium { get => _modifiedTermAnnualPremium; set => _modifiedTermAnnualPremium = value; }
        private DirtyValue<decimal?> _modifiedUpfrontPremium;
        /// <summary>
        /// HUD 1003 Addendum Mod Amt Up Front Premium [3183]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD 1003 Addendum Mod Amt Up Front Premium")]
        public decimal? ModifiedUpfrontPremium { get => _modifiedUpfrontPremium; set => _modifiedUpfrontPremium = value; }
        private DirtyValue<string> _mortgageeRepresentative;
        /// <summary>
        /// HUD 1003 Addendum Mortgagee Representative [3194]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Mortgagee Representative")]
        public string MortgageeRepresentative { get => _mortgageeRepresentative; set => _mortgageeRepresentative = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot>> _mortgageFinancialInterest;
        /// <summary>
        /// HUD Mtg Financial Interest Does/Does Not [153]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Mtg Financial Interest Does/Does Not")]
        public StringEnumValue<DoesOrDoesNot> MortgageFinancialInterest { get => _mortgageFinancialInterest; set => _mortgageFinancialInterest = value; }
        private DirtyValue<decimal?> _nonRealtyAndOtherItems;
        /// <summary>
        /// FHA MCAW Non-Realty/Other Items [1137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Non-Realty/Other Items")]
        public decimal? NonRealtyAndOtherItems { get => _nonRealtyAndOtherItems; set => _nonRealtyAndOtherItems = value; }
        private DirtyValue<DateTime?> _obtainCAIVRSDate;
        /// <summary>
        /// FHA Management Obtain CAIVRS Date [3067]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Obtain CAIVRS Date")]
        public DateTime? ObtainCAIVRSDate { get => _obtainCAIVRSDate; set => _obtainCAIVRSDate = value; }
        private DirtyValue<StringEnumValue<Occupancy>> _occupancy;
        /// <summary>
        /// Borr Cert Occupancy [1065]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Occupancy")]
        public StringEnumValue<Occupancy> Occupancy { get => _occupancy; set => _occupancy = value; }
        private DirtyValue<string> _oldAgencyCaseIdentifier;
        /// <summary>
        /// FHA Management Old Agency Case Identifier [3066]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Old Agency Case Identifier")]
        public string OldAgencyCaseIdentifier { get => _oldAgencyCaseIdentifier; set => _oldAgencyCaseIdentifier = value; }
        private DirtyValue<decimal?> _originalMortgageAmount;
        /// <summary>
        /// HUD Original Mtg Amt [744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Original Mtg Amt")]
        public decimal? OriginalMortgageAmount { get => _originalMortgageAmount; set => _originalMortgageAmount = value; }
        private DirtyValue<decimal?> _otherLiabilitiesMonthlyPayment;
        /// <summary>
        /// Liabilities Other Mo Pymt [1648]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Other Mo Pymt")]
        public decimal? OtherLiabilitiesMonthlyPayment { get => _otherLiabilitiesMonthlyPayment; set => _otherLiabilitiesMonthlyPayment = value; }
        private DirtyValue<decimal?> _otherLiabilitiesUnpaidBalance;
        /// <summary>
        /// Liabilities Other Unpaid Bal [1649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Liabilities Other Unpaid Bal")]
        public decimal? OtherLiabilitiesUnpaidBalance { get => _otherLiabilitiesUnpaidBalance; set => _otherLiabilitiesUnpaidBalance = value; }
        private DirtyValue<decimal?> _otherMonthlyShelterExpense;
        /// <summary>
        /// VA Mo Shelter Exp Est Other [1348]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Mo Shelter Exp Est Other")]
        public decimal? OtherMonthlyShelterExpense { get => _otherMonthlyShelterExpense; set => _otherMonthlyShelterExpense = value; }
        private DirtyValue<string> _otherTitleDescription;
        /// <summary>
        /// VA Title Other Descr [1064]
        /// </summary>
        [LoanFieldProperty(Description = "VA Title Other Descr")]
        public string OtherTitleDescription { get => _otherTitleDescription; set => _otherTitleDescription = value; }
        private DirtyValue<bool?> _ownMoreThanFourDwellings;
        /// <summary>
        /// Borr Cert Own More than 4 [1017]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Own More than 4")]
        public bool? OwnMoreThanFourDwellings { get => _ownMoreThanFourDwellings; set => _ownMoreThanFourDwellings = value; }
        private DirtyValue<bool?> _ownOrSoldOtherRealEstate;
        /// <summary>
        /// Borr Cert Own/Sold Other than RE [900]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Own/Sold Other than RE")]
        public bool? OwnOrSoldOtherRealEstate { get => _ownOrSoldOtherRealEstate; set => _ownOrSoldOtherRealEstate = value; }
        private DirtyValue<decimal?> _paidAmount;
        /// <summary>
        /// FHA MCAW Paid Amt [201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Paid Amt")]
        public decimal? PaidAmount { get => _paidAmount; set => _paidAmount = value; }
        private DirtyValue<int?> _premiumMonths;
        /// <summary>
        /// HUD Premium # Mos [409]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Premium # Mos")]
        public int? PremiumMonths { get => _premiumMonths; set => _premiumMonths = value; }
        private DirtyValue<decimal?> _prepaidExpenses;
        /// <summary>
        /// FHA MCAW Prepaid Expenses [61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Prepaid Expenses")]
        public decimal? PrepaidExpenses { get => _prepaidExpenses; set => _prepaidExpenses = value; }
        private DirtyValue<DateTime?> _previousPurchaseDate;
        /// <summary>
        /// FHA Management Previous Purchase Date [3058]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Previous Purchase Date")]
        public DateTime? PreviousPurchaseDate { get => _previousPurchaseDate; set => _previousPurchaseDate = value; }
        private DirtyValue<DateTime?> _priorEndorsementDate;
        /// <summary>
        /// FHA Management Refi Authorization Prior Endorsement Date [3432]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization Prior Endorsement Date")]
        public DateTime? PriorEndorsementDate { get => _priorEndorsementDate; set => _priorEndorsementDate = value; }
        private DirtyValue<int?> _proposedMaturityMonths;
        /// <summary>
        /// HUD Maturity Mos [1392]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD Maturity Mos")]
        public int? ProposedMaturityMonths { get => _proposedMaturityMonths; set => _proposedMaturityMonths = value; }
        private DirtyValue<int?> _proposedMaturityYears;
        /// <summary>
        /// Trans Details Loan Term [1347]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Loan Term")]
        public int? ProposedMaturityYears { get => _proposedMaturityYears; set => _proposedMaturityYears = value; }
        private DirtyValue<StringEnumValue<FhaVaLoanPurposeOfLoan>> _purposeOfLoan;
        /// <summary>
        /// Trans Details Loan Purpose VA [28]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose VA")]
        public StringEnumValue<FhaVaLoanPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => _purposeOfLoan = value; }
        private DirtyValue<string> _refiAuthorizationBy;
        /// <summary>
        /// FHA Management Refi Authorization By [3065]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization By")]
        public string RefiAuthorizationBy { get => _refiAuthorizationBy; set => _refiAuthorizationBy = value; }
        private DirtyValue<DateTime?> _refiAuthorizationDate;
        /// <summary>
        /// FHA Management Refi Authorization Date [3064]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Refi Authorization Date")]
        public DateTime? RefiAuthorizationDate { get => _refiAuthorizationDate; set => _refiAuthorizationDate = value; }
        private DirtyValue<decimal?> _salesPrice;
        /// <summary>
        /// Borr Cert Other RE Sales Price [687]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Cert Other RE Sales Price")]
        public decimal? SalesPrice { get => _salesPrice; set => _salesPrice = value; }
        private DirtyValue<decimal?> _secondMortgageAmount;
        /// <summary>
        /// FHA MCAW 2nd Mtg Amt [1140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW 2nd Mtg Amt")]
        public decimal? SecondMortgageAmount { get => _secondMortgageAmount; set => _secondMortgageAmount = value; }
        private DirtyValue<decimal?> _sellerPaidClosingCost;
        /// <summary>
        /// Fees Total FHA Closing Costs Seller [1131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total FHA Closing Costs Seller")]
        public decimal? SellerPaidClosingCost { get => _sellerPaidClosingCost; set => _sellerPaidClosingCost = value; }
        private DirtyValue<DateTime?> _servingTransferedDate;
        /// <summary>
        /// FHA Management Serving Transfered Date [3092]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Serving Transfered Date")]
        public DateTime? ServingTransferedDate { get => _servingTransferedDate; set => _servingTransferedDate = value; }
        private DirtyValue<decimal?> _specialAssessments;
        /// <summary>
        /// VA Mo Shelter Exp Est Special Asmts [1346]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Mo Shelter Exp Est Special Asmts")]
        public decimal? SpecialAssessments { get => _specialAssessments; set => _specialAssessments = value; }
        private DirtyValue<string> _sponsorAgentAddress;
        /// <summary>
        /// File Contacts Sponsor/Agent Street [1113]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent Street")]
        public string SponsorAgentAddress { get => _sponsorAgentAddress; set => _sponsorAgentAddress = value; }
        private DirtyValue<string> _sponsorAgentCity;
        /// <summary>
        /// File Contacts Sponsor/Agent City [1114]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent City")]
        public string SponsorAgentCity { get => _sponsorAgentCity; set => _sponsorAgentCity = value; }
        private DirtyValue<string> _sponsorAgentName;
        /// <summary>
        /// File Contacts Sponsor/Agent Name [1111]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent Name")]
        public string SponsorAgentName { get => _sponsorAgentName; set => _sponsorAgentName = value; }
        private DirtyValue<string> _sponsorAgentNMLS;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info NMLS [3640]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info NMLS")]
        public string SponsorAgentNMLS { get => _sponsorAgentNMLS; set => _sponsorAgentNMLS = value; }
        private DirtyValue<string> _sponsorAgentPostalCode;
        /// <summary>
        /// File Contacts Sponsor/Agent Zip [1744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "File Contacts Sponsor/Agent Zip")]
        public string SponsorAgentPostalCode { get => _sponsorAgentPostalCode; set => _sponsorAgentPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _sponsorAgentState;
        /// <summary>
        /// File Contacts Sponsor/Agent State [1743]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Sponsor/Agent State")]
        public StringEnumValue<State> SponsorAgentState { get => _sponsorAgentState; set => _sponsorAgentState = value; }
        private DirtyValue<string> _sponsorAgentTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3641]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsor Agent Info Tax ID")]
        public string SponsorAgentTaxID { get => _sponsorAgentTaxID; set => _sponsorAgentTaxID = value; }
        private DirtyValue<string> _sponsoredOriginationsName;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Name [3656]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations Name")]
        public string SponsoredOriginationsName { get => _sponsoredOriginationsName; set => _sponsoredOriginationsName = value; }
        private DirtyValue<string> _sponsoredOriginationsNMLS;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations NMLS ID [3657]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations NMLS ID")]
        public string SponsoredOriginationsNMLS { get => _sponsoredOriginationsNMLS; set => _sponsoredOriginationsNMLS = value; }
        private DirtyValue<string> _sponsoredOriginationsTaxID;
        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Tax ID [3658]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Sponsored Originations Tax ID")]
        public string SponsoredOriginationsTaxID { get => _sponsoredOriginationsTaxID; set => _sponsoredOriginationsTaxID = value; }
        private DirtyValue<string> _sponsorID;
        /// <summary>
        /// FHA Sponsor ID [1060]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Sponsor ID")]
        public string SponsorID { get => _sponsorID; set => _sponsorID = value; }
        private DirtyValue<StringEnumValue<TitleVestedIn>> _titleVestedIn;
        /// <summary>
        /// VA Title Vested In [1497]
        /// </summary>
        [LoanFieldProperty(Description = "VA Title Vested In")]
        public StringEnumValue<TitleVestedIn> TitleVestedIn { get => _titleVestedIn; set => _titleVestedIn = value; }
        private DirtyValue<bool?> _toBeSold;
        /// <summary>
        /// Borr Cert Other RE To Be Sold [933]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Other RE To Be Sold")]
        public bool? ToBeSold { get => _toBeSold; set => _toBeSold = value; }
        private DirtyValue<decimal?> _totalClosingCost;
        /// <summary>
        /// FHA MCAW Total Closing Cost [386]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Total Closing Cost")]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => _totalClosingCost = value; }
        private DirtyValue<string> _totalScorecardBy;
        /// <summary>
        /// FHA Management Total Scorecard By [3072]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Total Scorecard By")]
        public string TotalScorecardBy { get => _totalScorecardBy; set => _totalScorecardBy = value; }
        private DirtyValue<DateTime?> _totalScorecardDate;
        /// <summary>
        /// FHA Management Total Scorecard Date [3071]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Total Scorecard Date")]
        public DateTime? TotalScorecardDate { get => _totalScorecardDate; set => _totalScorecardDate = value; }
        private DirtyValue<DateTime?> _uFMIPRemittanceDueDate;
        /// <summary>
        /// FHA Management UFMIP Remittance Due Date [3078]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remittance Due Date")]
        public DateTime? UFMIPRemittanceDueDate { get => _uFMIPRemittanceDueDate; set => _uFMIPRemittanceDueDate = value; }
        private DirtyValue<decimal?> _uFMIPRemittedAmount;
        /// <summary>
        /// FHA Management UFMIP Remitted Amount [3081]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA Management UFMIP Remitted Amount")]
        public decimal? UFMIPRemittedAmount { get => _uFMIPRemittedAmount; set => _uFMIPRemittedAmount = value; }
        private DirtyValue<string> _uFMIPRemittedBy;
        /// <summary>
        /// FHA Management UFMIP Remitted By [3080]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remitted By")]
        public string UFMIPRemittedBy { get => _uFMIPRemittedBy; set => _uFMIPRemittedBy = value; }
        private DirtyValue<DateTime?> _uFMIPRemittedDate;
        /// <summary>
        /// FHA Management UFMIP Remitted Date [3079]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Remitted Date")]
        public DateTime? UFMIPRemittedDate { get => _uFMIPRemittedDate; set => _uFMIPRemittedDate = value; }
        private DirtyValue<string> _uFMIPVerificationCode;
        /// <summary>
        /// FHA Management UFMIP Verification Code [3082]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management UFMIP Verification Code")]
        public string UFMIPVerificationCode { get => _uFMIPVerificationCode; set => _uFMIPVerificationCode = value; }
        private DirtyValue<bool?> _useDefaultLenderInfo;
        /// <summary>
        /// HUD 1003 Addendum Use Default Lender [3639]
        /// </summary>
        [LoanFieldProperty(Description = "HUD 1003 Addendum Use Default Lender")]
        public bool? UseDefaultLenderInfo { get => _useDefaultLenderInfo; set => _useDefaultLenderInfo = value; }
        private DirtyValue<bool?> _utilityIncluded;
        /// <summary>
        /// Expenses Borr Mo Housing Exp Utiliy Incl [1087]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Borr Mo Housing Exp Utiliy Incl")]
        public bool? UtilityIncluded { get => _utilityIncluded; set => _utilityIncluded = value; }
        private DirtyValue<DateTime?> _validateAddressDate;
        /// <summary>
        /// FHA Management Address Validation Date [3060]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Management Address Validation Date")]
        public DateTime? ValidateAddressDate { get => _validateAddressDate; set => _validateAddressDate = value; }
        private DirtyValue<StringEnumValue<Valuation>> _valuation;
        /// <summary>
        /// Borr Cert Aware/Unaware of Valuation [1399]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Cert Aware/Unaware of Valuation")]
        public StringEnumValue<Valuation> Valuation { get => _valuation; set => _valuation = value; }
        internal override bool DirtyInternal
        {
            get => _addendumType.Dirty
                || _additionalCondition1.Dirty
                || _additionalCondition2.Dirty
                || _additionalCondition3.Dirty
                || _additionalCondition4.Dirty
                || _additionalCondition5.Dirty
                || _additionalCondition6.Dirty
                || _additionalCondition7.Dirty
                || _additionalCondition8.Dirty
                || _additionalCondition9.Dirty
                || _addressValidatedBy.Dirty
                || _addressValidationMessage.Dirty
                || _allConditionsSatisfied.Dirty
                || _appraisalLoggedDate.Dirty
                || _appraisalLookupBy.Dirty
                || _beenInformed.Dirty
                || _borrowerCertificationAddress.Dirty
                || _borrowerCertificationCity.Dirty
                || _borrowerCertificationPostalCode.Dirty
                || _borrowerCertificationState.Dirty
                || _cAIVRSObtainedBy.Dirty
                || _caseBinderShippedBy.Dirty
                || _caseBinderShippedDate.Dirty
                || _closingDate.Dirty
                || _condoPudID.Dirty
                || _condoPudLookupBy.Dirty
                || _condoPudLookupDate.Dirty
                || _conventionalClosingCost.Dirty
                || _conventionalDownPayment.Dirty
                || _conventionalInterestRate.Dirty
                || _conventionalLoanTerm.Dirty
                || _conventionalLTV.Dirty
                || _conventionalMaxYearsMI.Dirty
                || _conventionalMMI.Dirty
                || _conventionalMonthlyPayment.Dirty
                || _conventionalMortgageAmount.Dirty
                || _conventionalSalesPrice.Dirty
                || _conventionalUMIP.Dirty
                || _dateApprovalExpires.Dirty
                || _dateMortgageApproved.Dirty
                || _detailForOther.Dirty
                || _discountPoints.Dirty
                || _dulyAgentAddress.Dirty
                || _dulyAgentCity.Dirty
                || _dulyAgentFunction1.Dirty
                || _dulyAgentFunction2.Dirty
                || _dulyAgentName.Dirty
                || _dulyAgentState.Dirty
                || _dwellingCoveredBy.Dirty
                || _eligibilityAssessment.Dirty
                || _energyEfficientMortgageAmount.Dirty
                || _everHadVAHomeLoan.Dirty
                || _excessContributionAmount.Dirty
                || _existingDebtAmount.Dirty
                || _fHACaseOrderedBy.Dirty
                || _fHAClosingCost.Dirty
                || _fHADownPayment.Dirty
                || _fHAInterestRate.Dirty
                || _fHALoanTerm.Dirty
                || _fHALTV.Dirty
                || _fHAManagementCounselType.Dirty
                || _fHAMaxLoanAmount.Dirty
                || _fHAMMI.Dirty
                || _fHAMonthlyPayment.Dirty
                || _fHAMortgageAmount.Dirty
                || _fHAMortgageAmountUMIP.Dirty
                || _fHASalesPrice.Dirty
                || _fHAUMIP.Dirty
                || _fHAYearsMonthlyInsurance.Dirty
                || _foreclosedProperty.Dirty
                || _freddieMacCounselType.Dirty
                || _fundingFeePaidInCash.Dirty
                || _giftFundsAmount.Dirty
                || _haveReceivedLeadPaintPoisoningInfo.Dirty
                || _hUD1003AddendumApproved.Dirty
                || _id.Dirty
                || _lastRefiDate.Dirty
                || _lDPGSASearchDate.Dirty
                || _lDPGSASearchedBy.Dirty
                || _lenderAddress.Dirty
                || _lenderCity.Dirty
                || _lenderName.Dirty
                || _lenderNMLS.Dirty
                || _lenderPostalCode.Dirty
                || _lenderRepresentativeName.Dirty
                || _lenderRepresentativePhone.Dirty
                || _lenderRepresentativeTitle.Dirty
                || _lenderState.Dirty
                || _lenderTaxID.Dirty
                || _loanScoreID.Dirty
                || _mIAppliedBy.Dirty
                || _mIAppliedDate.Dirty
                || _mICRetrivedDate.Dirty
                || _minimumDownPayment.Dirty
                || _mIP1stDueDate.Dirty
                || _mIP1stToInvestor.Dirty
                || _mIPRemittedDate.Dirty
                || _mIRejectedDate.Dirty
                || _modifiedInterestRate.Dirty
                || _modifiedLoanAmount.Dirty
                || _modifiedMonthlyPayment.Dirty
                || _modifiedMonthlyPremium.Dirty
                || _modifiedProposedMaturityMonth.Dirty
                || _modifiedProposedMaturityYear.Dirty
                || _modifiedTermAnnualPremium.Dirty
                || _modifiedUpfrontPremium.Dirty
                || _mortgageeRepresentative.Dirty
                || _mortgageFinancialInterest.Dirty
                || _nonRealtyAndOtherItems.Dirty
                || _obtainCAIVRSDate.Dirty
                || _occupancy.Dirty
                || _oldAgencyCaseIdentifier.Dirty
                || _originalMortgageAmount.Dirty
                || _otherLiabilitiesMonthlyPayment.Dirty
                || _otherLiabilitiesUnpaidBalance.Dirty
                || _otherMonthlyShelterExpense.Dirty
                || _otherTitleDescription.Dirty
                || _ownMoreThanFourDwellings.Dirty
                || _ownOrSoldOtherRealEstate.Dirty
                || _paidAmount.Dirty
                || _premiumMonths.Dirty
                || _prepaidExpenses.Dirty
                || _previousPurchaseDate.Dirty
                || _priorEndorsementDate.Dirty
                || _proposedMaturityMonths.Dirty
                || _proposedMaturityYears.Dirty
                || _purposeOfLoan.Dirty
                || _refiAuthorizationBy.Dirty
                || _refiAuthorizationDate.Dirty
                || _salesPrice.Dirty
                || _secondMortgageAmount.Dirty
                || _sellerPaidClosingCost.Dirty
                || _servingTransferedDate.Dirty
                || _specialAssessments.Dirty
                || _sponsorAgentAddress.Dirty
                || _sponsorAgentCity.Dirty
                || _sponsorAgentName.Dirty
                || _sponsorAgentNMLS.Dirty
                || _sponsorAgentPostalCode.Dirty
                || _sponsorAgentState.Dirty
                || _sponsorAgentTaxID.Dirty
                || _sponsoredOriginationsName.Dirty
                || _sponsoredOriginationsNMLS.Dirty
                || _sponsoredOriginationsTaxID.Dirty
                || _sponsorID.Dirty
                || _titleVestedIn.Dirty
                || _toBeSold.Dirty
                || _totalClosingCost.Dirty
                || _totalScorecardBy.Dirty
                || _totalScorecardDate.Dirty
                || _uFMIPRemittanceDueDate.Dirty
                || _uFMIPRemittedAmount.Dirty
                || _uFMIPRemittedBy.Dirty
                || _uFMIPRemittedDate.Dirty
                || _uFMIPVerificationCode.Dirty
                || _useDefaultLenderInfo.Dirty
                || _utilityIncluded.Dirty
                || _validateAddressDate.Dirty
                || _valuation.Dirty
                || _eem?.Dirty == true
                || _energyEfficientMortgageItems?.Dirty == true;
            set
            {
                _addendumType.Dirty = value;
                _additionalCondition1.Dirty = value;
                _additionalCondition2.Dirty = value;
                _additionalCondition3.Dirty = value;
                _additionalCondition4.Dirty = value;
                _additionalCondition5.Dirty = value;
                _additionalCondition6.Dirty = value;
                _additionalCondition7.Dirty = value;
                _additionalCondition8.Dirty = value;
                _additionalCondition9.Dirty = value;
                _addressValidatedBy.Dirty = value;
                _addressValidationMessage.Dirty = value;
                _allConditionsSatisfied.Dirty = value;
                _appraisalLoggedDate.Dirty = value;
                _appraisalLookupBy.Dirty = value;
                _beenInformed.Dirty = value;
                _borrowerCertificationAddress.Dirty = value;
                _borrowerCertificationCity.Dirty = value;
                _borrowerCertificationPostalCode.Dirty = value;
                _borrowerCertificationState.Dirty = value;
                _cAIVRSObtainedBy.Dirty = value;
                _caseBinderShippedBy.Dirty = value;
                _caseBinderShippedDate.Dirty = value;
                _closingDate.Dirty = value;
                _condoPudID.Dirty = value;
                _condoPudLookupBy.Dirty = value;
                _condoPudLookupDate.Dirty = value;
                _conventionalClosingCost.Dirty = value;
                _conventionalDownPayment.Dirty = value;
                _conventionalInterestRate.Dirty = value;
                _conventionalLoanTerm.Dirty = value;
                _conventionalLTV.Dirty = value;
                _conventionalMaxYearsMI.Dirty = value;
                _conventionalMMI.Dirty = value;
                _conventionalMonthlyPayment.Dirty = value;
                _conventionalMortgageAmount.Dirty = value;
                _conventionalSalesPrice.Dirty = value;
                _conventionalUMIP.Dirty = value;
                _dateApprovalExpires.Dirty = value;
                _dateMortgageApproved.Dirty = value;
                _detailForOther.Dirty = value;
                _discountPoints.Dirty = value;
                _dulyAgentAddress.Dirty = value;
                _dulyAgentCity.Dirty = value;
                _dulyAgentFunction1.Dirty = value;
                _dulyAgentFunction2.Dirty = value;
                _dulyAgentName.Dirty = value;
                _dulyAgentState.Dirty = value;
                _dwellingCoveredBy.Dirty = value;
                _eligibilityAssessment.Dirty = value;
                _energyEfficientMortgageAmount.Dirty = value;
                _everHadVAHomeLoan.Dirty = value;
                _excessContributionAmount.Dirty = value;
                _existingDebtAmount.Dirty = value;
                _fHACaseOrderedBy.Dirty = value;
                _fHAClosingCost.Dirty = value;
                _fHADownPayment.Dirty = value;
                _fHAInterestRate.Dirty = value;
                _fHALoanTerm.Dirty = value;
                _fHALTV.Dirty = value;
                _fHAManagementCounselType.Dirty = value;
                _fHAMaxLoanAmount.Dirty = value;
                _fHAMMI.Dirty = value;
                _fHAMonthlyPayment.Dirty = value;
                _fHAMortgageAmount.Dirty = value;
                _fHAMortgageAmountUMIP.Dirty = value;
                _fHASalesPrice.Dirty = value;
                _fHAUMIP.Dirty = value;
                _fHAYearsMonthlyInsurance.Dirty = value;
                _foreclosedProperty.Dirty = value;
                _freddieMacCounselType.Dirty = value;
                _fundingFeePaidInCash.Dirty = value;
                _giftFundsAmount.Dirty = value;
                _haveReceivedLeadPaintPoisoningInfo.Dirty = value;
                _hUD1003AddendumApproved.Dirty = value;
                _id.Dirty = value;
                _lastRefiDate.Dirty = value;
                _lDPGSASearchDate.Dirty = value;
                _lDPGSASearchedBy.Dirty = value;
                _lenderAddress.Dirty = value;
                _lenderCity.Dirty = value;
                _lenderName.Dirty = value;
                _lenderNMLS.Dirty = value;
                _lenderPostalCode.Dirty = value;
                _lenderRepresentativeName.Dirty = value;
                _lenderRepresentativePhone.Dirty = value;
                _lenderRepresentativeTitle.Dirty = value;
                _lenderState.Dirty = value;
                _lenderTaxID.Dirty = value;
                _loanScoreID.Dirty = value;
                _mIAppliedBy.Dirty = value;
                _mIAppliedDate.Dirty = value;
                _mICRetrivedDate.Dirty = value;
                _minimumDownPayment.Dirty = value;
                _mIP1stDueDate.Dirty = value;
                _mIP1stToInvestor.Dirty = value;
                _mIPRemittedDate.Dirty = value;
                _mIRejectedDate.Dirty = value;
                _modifiedInterestRate.Dirty = value;
                _modifiedLoanAmount.Dirty = value;
                _modifiedMonthlyPayment.Dirty = value;
                _modifiedMonthlyPremium.Dirty = value;
                _modifiedProposedMaturityMonth.Dirty = value;
                _modifiedProposedMaturityYear.Dirty = value;
                _modifiedTermAnnualPremium.Dirty = value;
                _modifiedUpfrontPremium.Dirty = value;
                _mortgageeRepresentative.Dirty = value;
                _mortgageFinancialInterest.Dirty = value;
                _nonRealtyAndOtherItems.Dirty = value;
                _obtainCAIVRSDate.Dirty = value;
                _occupancy.Dirty = value;
                _oldAgencyCaseIdentifier.Dirty = value;
                _originalMortgageAmount.Dirty = value;
                _otherLiabilitiesMonthlyPayment.Dirty = value;
                _otherLiabilitiesUnpaidBalance.Dirty = value;
                _otherMonthlyShelterExpense.Dirty = value;
                _otherTitleDescription.Dirty = value;
                _ownMoreThanFourDwellings.Dirty = value;
                _ownOrSoldOtherRealEstate.Dirty = value;
                _paidAmount.Dirty = value;
                _premiumMonths.Dirty = value;
                _prepaidExpenses.Dirty = value;
                _previousPurchaseDate.Dirty = value;
                _priorEndorsementDate.Dirty = value;
                _proposedMaturityMonths.Dirty = value;
                _proposedMaturityYears.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _refiAuthorizationBy.Dirty = value;
                _refiAuthorizationDate.Dirty = value;
                _salesPrice.Dirty = value;
                _secondMortgageAmount.Dirty = value;
                _sellerPaidClosingCost.Dirty = value;
                _servingTransferedDate.Dirty = value;
                _specialAssessments.Dirty = value;
                _sponsorAgentAddress.Dirty = value;
                _sponsorAgentCity.Dirty = value;
                _sponsorAgentName.Dirty = value;
                _sponsorAgentNMLS.Dirty = value;
                _sponsorAgentPostalCode.Dirty = value;
                _sponsorAgentState.Dirty = value;
                _sponsorAgentTaxID.Dirty = value;
                _sponsoredOriginationsName.Dirty = value;
                _sponsoredOriginationsNMLS.Dirty = value;
                _sponsoredOriginationsTaxID.Dirty = value;
                _sponsorID.Dirty = value;
                _titleVestedIn.Dirty = value;
                _toBeSold.Dirty = value;
                _totalClosingCost.Dirty = value;
                _totalScorecardBy.Dirty = value;
                _totalScorecardDate.Dirty = value;
                _uFMIPRemittanceDueDate.Dirty = value;
                _uFMIPRemittedAmount.Dirty = value;
                _uFMIPRemittedBy.Dirty = value;
                _uFMIPRemittedDate.Dirty = value;
                _uFMIPVerificationCode.Dirty = value;
                _useDefaultLenderInfo.Dirty = value;
                _utilityIncluded.Dirty = value;
                _validateAddressDate.Dirty = value;
                _valuation.Dirty = value;
                if (_eem != null) _eem.Dirty = value;
                if (_energyEfficientMortgageItems != null) _energyEfficientMortgageItems.Dirty = value;
            }
        }
    }
}