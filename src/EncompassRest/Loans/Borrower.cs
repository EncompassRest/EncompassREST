using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Borrower : IClean
    {
        private Value<string> _acountChekAssetId;
        public string AcountChekAssetId { get { return _acountChekAssetId; } set { _acountChekAssetId = value; } }
        private Value<int?> _ageAtApplicationYearsCount;
        public int? AgeAtApplicationYearsCount { get { return _ageAtApplicationYearsCount; } set { _ageAtApplicationYearsCount = value; } }
        private Value<string> _aliasName;
        public string AliasName { get { return _aliasName; } set { _aliasName = value; } }
        private Value<bool?> _alimonyChildSupportObligationIndicator;
        public bool? AlimonyChildSupportObligationIndicator { get { return _alimonyChildSupportObligationIndicator; } set { _alimonyChildSupportObligationIndicator = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _applicantType;
        public string ApplicantType { get { return _applicantType; } set { _applicantType = value; } }
        public Application Application { get; set; }
        private Value<string> _applicationTakenMethodType;
        public string ApplicationTakenMethodType { get { return _applicationTakenMethodType; } set { _applicationTakenMethodType = value; } }
        private Value<bool?> _authorizedCreditReportIndicator;
        public bool? AuthorizedCreditReportIndicator { get { return _authorizedCreditReportIndicator; } set { _authorizedCreditReportIndicator = value; } }
        private Value<bool?> _authorizedToSignIndicator;
        public bool? AuthorizedToSignIndicator { get { return _authorizedToSignIndicator; } set { _authorizedToSignIndicator = value; } }
        private Value<string> _bankAccountNumber;
        public string BankAccountNumber { get { return _bankAccountNumber; } set { _bankAccountNumber = value; } }
        private Value<string> _bankAccountType;
        public string BankAccountType { get { return _bankAccountType; } set { _bankAccountType = value; } }
        private Value<string> _bankContactAddress;
        public string BankContactAddress { get { return _bankContactAddress; } set { _bankContactAddress = value; } }
        private Value<string> _bankContactCity;
        public string BankContactCity { get { return _bankContactCity; } set { _bankContactCity = value; } }
        private Value<string> _bankContactName;
        public string BankContactName { get { return _bankContactName; } set { _bankContactName = value; } }
        private Value<string> _bankContactPostalCode;
        public string BankContactPostalCode { get { return _bankContactPostalCode; } set { _bankContactPostalCode = value; } }
        private Value<string> _bankContactState;
        public string BankContactState { get { return _bankContactState; } set { _bankContactState = value; } }
        private Value<bool?> _bankruptcyIndicator;
        public bool? BankruptcyIndicator { get { return _bankruptcyIndicator; } set { _bankruptcyIndicator = value; } }
        private Value<string> _bankruptcyStatus;
        public string BankruptcyStatus { get { return _bankruptcyStatus; } set { _bankruptcyStatus = value; } }
        private Value<decimal?> _baseMonthlyIncomeAmount;
        public decimal? BaseMonthlyIncomeAmount { get { return _baseMonthlyIncomeAmount; } set { _baseMonthlyIncomeAmount = value; } }
        private Value<DateTime?> _birthDate;
        public DateTime? BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        private Value<bool?> _borrowedDownPaymentIndicator;
        public bool? BorrowedDownPaymentIndicator { get { return _borrowedDownPaymentIndicator; } set { _borrowedDownPaymentIndicator = value; } }
        private Value<DateTime?> _borrowerConsentRequestDate;
        public DateTime? BorrowerConsentRequestDate { get { return _borrowerConsentRequestDate; } set { _borrowerConsentRequestDate = value; } }
        private Value<int?> _borrowerIndex;
        public int? BorrowerIndex { get { return _borrowerIndex; } set { _borrowerIndex = value; } }
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        private Value<string> _borrowerTypeInSummary;
        public string BorrowerTypeInSummary { get { return _borrowerTypeInSummary; } set { _borrowerTypeInSummary = value; } }
        private Value<string> _caivrsIdentifier;
        public string CaivrsIdentifier { get { return _caivrsIdentifier; } set { _caivrsIdentifier = value; } }
        private Value<string> _citizenshipResidencyType;
        public string CitizenshipResidencyType { get { return _citizenshipResidencyType; } set { _citizenshipResidencyType = value; } }
        private Value<bool?> _coMakerEndorserOfNoteIndicator;
        public bool? CoMakerEndorserOfNoteIndicator { get { return _coMakerEndorserOfNoteIndicator; } set { _coMakerEndorserOfNoteIndicator = value; } }
        private Value<string> _commentOfCreditReport;
        public string CommentOfCreditReport { get { return _commentOfCreditReport; } set { _commentOfCreditReport = value; } }
        private Value<bool?> _confirmedCRDIL;
        public bool? ConfirmedCRDIL { get { return _confirmedCRDIL; } set { _confirmedCRDIL = value; } }
        private Value<bool?> _confirmedCRFCEC;
        public bool? ConfirmedCRFCEC { get { return _confirmedCRFCEC; } set { _confirmedCRFCEC = value; } }
        private Value<bool?> _confirmedCRFCIncorrect;
        public bool? ConfirmedCRFCIncorrect { get { return _confirmedCRFCIncorrect; } set { _confirmedCRFCIncorrect = value; } }
        private Value<bool?> _confirmedCRPFS;
        public bool? ConfirmedCRPFS { get { return _confirmedCRPFS; } set { _confirmedCRPFS = value; } }
        private Value<bool?> _confirmedOther;
        public bool? ConfirmedOther { get { return _confirmedOther; } set { _confirmedOther = value; } }
        private Value<string> _confirmedOtherDescription;
        public string ConfirmedOtherDescription { get { return _confirmedOtherDescription; } set { _confirmedOtherDescription = value; } }
        private Value<bool?> _creditCounseling;
        public bool? CreditCounseling { get { return _creditCounseling; } set { _creditCounseling = value; } }
        private Value<DateTime?> _creditReceivedDate;
        public DateTime? CreditReceivedDate { get { return _creditReceivedDate; } set { _creditReceivedDate = value; } }
        private Value<string> _creditReportAuthorizationMethod;
        public string CreditReportAuthorizationMethod { get { return _creditReportAuthorizationMethod; } set { _creditReportAuthorizationMethod = value; } }
        private Value<bool?> _creditScoreIndicator;
        public bool? CreditScoreIndicator { get { return _creditScoreIndicator; } set { _creditScoreIndicator = value; } }
        private Value<DateTime?> _dateAuthorizedCreditReport;
        public DateTime? DateAuthorizedCreditReport { get { return _dateAuthorizedCreditReport; } set { _dateAuthorizedCreditReport = value; } }
        private Value<DateTime?> _dateOfBankruptcy;
        public DateTime? DateOfBankruptcy { get { return _dateOfBankruptcy; } set { _dateOfBankruptcy = value; } }
        private Value<DateTime?> _dateOfForeclosure;
        public DateTime? DateOfForeclosure { get { return _dateOfForeclosure; } set { _dateOfForeclosure = value; } }
        private Value<bool?> _declarationsJIndicator;
        public bool? DeclarationsJIndicator { get { return _declarationsJIndicator; } set { _declarationsJIndicator = value; } }
        private Value<bool?> _declarationsKIndicator;
        public bool? DeclarationsKIndicator { get { return _declarationsKIndicator; } set { _declarationsKIndicator = value; } }
        private Value<int?> _dependentCount;
        public int? DependentCount { get { return _dependentCount; } set { _dependentCount = value; } }
        private Value<string> _dependentsAgesDescription;
        public string DependentsAgesDescription { get { return _dependentsAgesDescription; } set { _dependentsAgesDescription = value; } }
        private Value<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get { return _disabledIndicator; } set { _disabledIndicator = value; } }
        private Value<string> _emailAddressText;
        public string EmailAddressText { get { return _emailAddressText; } set { _emailAddressText = value; } }
        private Value<int?> _equifax120Days;
        public int? Equifax120Days { get { return _equifax120Days; } set { _equifax120Days = value; } }
        private Value<int?> _equifax150Days;
        public int? Equifax150Days { get { return _equifax150Days; } set { _equifax150Days = value; } }
        private Value<int?> _equifax30Days;
        public int? Equifax30Days { get { return _equifax30Days; } set { _equifax30Days = value; } }
        private Value<int?> _equifax60Days;
        public int? Equifax60Days { get { return _equifax60Days; } set { _equifax60Days = value; } }
        private Value<int?> _equifax90Days;
        public int? Equifax90Days { get { return _equifax90Days; } set { _equifax90Days = value; } }
        private Value<bool?> _equifaxCreditScoreForDisclosure;
        public bool? EquifaxCreditScoreForDisclosure { get { return _equifaxCreditScoreForDisclosure; } set { _equifaxCreditScoreForDisclosure = value; } }
        private Value<int?> _equifaxCreditScoreRanksPercent;
        public int? EquifaxCreditScoreRanksPercent { get { return _equifaxCreditScoreRanksPercent; } set { _equifaxCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _equifaxDatePulled;
        public DateTime? EquifaxDatePulled { get { return _equifaxDatePulled; } set { _equifaxDatePulled = value; } }
        private Value<string> _equifaxFactorCode1;
        public string EquifaxFactorCode1 { get { return _equifaxFactorCode1; } set { _equifaxFactorCode1 = value; } }
        private Value<string> _equifaxFactorCode2;
        public string EquifaxFactorCode2 { get { return _equifaxFactorCode2; } set { _equifaxFactorCode2 = value; } }
        private Value<string> _equifaxFactorCode3;
        public string EquifaxFactorCode3 { get { return _equifaxFactorCode3; } set { _equifaxFactorCode3 = value; } }
        private Value<string> _equifaxFactorCode4;
        public string EquifaxFactorCode4 { get { return _equifaxFactorCode4; } set { _equifaxFactorCode4 = value; } }
        private Value<string> _equifaxFactorCode5;
        public string EquifaxFactorCode5 { get { return _equifaxFactorCode5; } set { _equifaxFactorCode5 = value; } }
        private Value<string> _equifaxKeyFactor1;
        public string EquifaxKeyFactor1 { get { return _equifaxKeyFactor1; } set { _equifaxKeyFactor1 = value; } }
        private Value<string> _equifaxKeyFactor2;
        public string EquifaxKeyFactor2 { get { return _equifaxKeyFactor2; } set { _equifaxKeyFactor2 = value; } }
        private Value<string> _equifaxKeyFactor3;
        public string EquifaxKeyFactor3 { get { return _equifaxKeyFactor3; } set { _equifaxKeyFactor3 = value; } }
        private Value<string> _equifaxKeyFactor4;
        public string EquifaxKeyFactor4 { get { return _equifaxKeyFactor4; } set { _equifaxKeyFactor4 = value; } }
        private Value<string> _equifaxKeyFactor5;
        public string EquifaxKeyFactor5 { get { return _equifaxKeyFactor5; } set { _equifaxKeyFactor5 = value; } }
        private Value<bool?> _equifaxMaterialTermsCreditByScore;
        public bool? EquifaxMaterialTermsCreditByScore { get { return _equifaxMaterialTermsCreditByScore; } set { _equifaxMaterialTermsCreditByScore = value; } }
        private Value<string> _equifaxScore;
        public string EquifaxScore { get { return _equifaxScore; } set { _equifaxScore = value; } }
        private Value<int?> _experian120Days;
        public int? Experian120Days { get { return _experian120Days; } set { _experian120Days = value; } }
        private Value<int?> _experian150Days;
        public int? Experian150Days { get { return _experian150Days; } set { _experian150Days = value; } }
        private Value<int?> _experian30Days;
        public int? Experian30Days { get { return _experian30Days; } set { _experian30Days = value; } }
        private Value<int?> _experian60Days;
        public int? Experian60Days { get { return _experian60Days; } set { _experian60Days = value; } }
        private Value<int?> _experian90Days;
        public int? Experian90Days { get { return _experian90Days; } set { _experian90Days = value; } }
        private Value<string> _experianCreditScore;
        public string ExperianCreditScore { get { return _experianCreditScore; } set { _experianCreditScore = value; } }
        private Value<bool?> _experianCreditScoreForDisclosure;
        public bool? ExperianCreditScoreForDisclosure { get { return _experianCreditScoreForDisclosure; } set { _experianCreditScoreForDisclosure = value; } }
        private Value<int?> _experianCreditScoreRanksPercent;
        public int? ExperianCreditScoreRanksPercent { get { return _experianCreditScoreRanksPercent; } set { _experianCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _experianDatePulled;
        public DateTime? ExperianDatePulled { get { return _experianDatePulled; } set { _experianDatePulled = value; } }
        private Value<string> _experianFactorCode1;
        public string ExperianFactorCode1 { get { return _experianFactorCode1; } set { _experianFactorCode1 = value; } }
        private Value<string> _experianFactorCode2;
        public string ExperianFactorCode2 { get { return _experianFactorCode2; } set { _experianFactorCode2 = value; } }
        private Value<string> _experianFactorCode3;
        public string ExperianFactorCode3 { get { return _experianFactorCode3; } set { _experianFactorCode3 = value; } }
        private Value<string> _experianFactorCode4;
        public string ExperianFactorCode4 { get { return _experianFactorCode4; } set { _experianFactorCode4 = value; } }
        private Value<string> _experianFactorCode5;
        public string ExperianFactorCode5 { get { return _experianFactorCode5; } set { _experianFactorCode5 = value; } }
        private Value<string> _experianKeyFactor1;
        public string ExperianKeyFactor1 { get { return _experianKeyFactor1; } set { _experianKeyFactor1 = value; } }
        private Value<string> _experianKeyFactor2;
        public string ExperianKeyFactor2 { get { return _experianKeyFactor2; } set { _experianKeyFactor2 = value; } }
        private Value<string> _experianKeyFactor3;
        public string ExperianKeyFactor3 { get { return _experianKeyFactor3; } set { _experianKeyFactor3 = value; } }
        private Value<string> _experianKeyFactor4;
        public string ExperianKeyFactor4 { get { return _experianKeyFactor4; } set { _experianKeyFactor4 = value; } }
        private Value<string> _experianKeyFactor5;
        public string ExperianKeyFactor5 { get { return _experianKeyFactor5; } set { _experianKeyFactor5 = value; } }
        private Value<bool?> _experianMaterialTermsCreditByScore;
        public bool? ExperianMaterialTermsCreditByScore { get { return _experianMaterialTermsCreditByScore; } set { _experianMaterialTermsCreditByScore = value; } }
        private Value<string> _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private Value<string> _firstNameWithMiddleName;
        public string FirstNameWithMiddleName { get { return _firstNameWithMiddleName; } set { _firstNameWithMiddleName = value; } }
        private Value<bool?> _firstTimeHomeBuyer;
        public bool? FirstTimeHomeBuyer { get { return _firstTimeHomeBuyer; } set { _firstTimeHomeBuyer = value; } }
        private Value<DateTime?> _foreclosureSatisfied;
        public DateTime? ForeclosureSatisfied { get { return _foreclosureSatisfied; } set { _foreclosureSatisfied = value; } }
        private Value<string> _foreclosureStatus;
        public string ForeclosureStatus { get { return _foreclosureStatus; } set { _foreclosureStatus = value; } }
        private Value<string> _freddieMacPerson1;
        public string FreddieMacPerson1 { get { return _freddieMacPerson1; } set { _freddieMacPerson1 = value; } }
        private Value<string> _freddieMacPerson2;
        public string FreddieMacPerson2 { get { return _freddieMacPerson2; } set { _freddieMacPerson2 = value; } }
        private Value<string> _fullName;
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        private Value<string> _fullNameWithSuffix;
        public string FullNameWithSuffix { get { return _fullNameWithSuffix; } set { _fullNameWithSuffix = value; } }
        private Value<decimal?> _highestCreditLimit;
        public decimal? HighestCreditLimit { get { return _highestCreditLimit; } set { _highestCreditLimit = value; } }
        private Value<string> _hmda2003OtherRaceNationalOriginDescription;
        public string Hmda2003OtherRaceNationalOriginDescription { get { return _hmda2003OtherRaceNationalOriginDescription; } set { _hmda2003OtherRaceNationalOriginDescription = value; } }
        private Value<string> _hmda2003RaceNationalOriginType;
        public string Hmda2003RaceNationalOriginType { get { return _hmda2003RaceNationalOriginType; } set { _hmda2003RaceNationalOriginType = value; } }
        private Value<bool?> _hmdaAfricanAmericanIndicator;
        public bool? HmdaAfricanAmericanIndicator { get { return _hmdaAfricanAmericanIndicator; } set { _hmdaAfricanAmericanIndicator = value; } }
        private Value<string> _hmdaAge;
        public string HmdaAge { get { return _hmdaAge; } set { _hmdaAge = value; } }
        private Value<bool?> _hmdaAmericanIndianIndicator;
        public bool? HmdaAmericanIndianIndicator { get { return _hmdaAmericanIndianIndicator; } set { _hmdaAmericanIndianIndicator = value; } }
        private Value<string> _hmdaAmericanIndianTribe;
        public string HmdaAmericanIndianTribe { get { return _hmdaAmericanIndianTribe; } set { _hmdaAmericanIndianTribe = value; } }
        private Value<bool?> _hmdaAsianIndianIndicator;
        public bool? HmdaAsianIndianIndicator { get { return _hmdaAsianIndianIndicator; } set { _hmdaAsianIndianIndicator = value; } }
        private Value<bool?> _hmdaAsianIndicator;
        public bool? HmdaAsianIndicator { get { return _hmdaAsianIndicator; } set { _hmdaAsianIndicator = value; } }
        private Value<bool?> _hmdaAsianOtherRaceIndicator;
        public bool? HmdaAsianOtherRaceIndicator { get { return _hmdaAsianOtherRaceIndicator; } set { _hmdaAsianOtherRaceIndicator = value; } }
        private Value<bool?> _hmdaChineseIndicator;
        public bool? HmdaChineseIndicator { get { return _hmdaChineseIndicator; } set { _hmdaChineseIndicator = value; } }
        private Value<string> _hmdaCreditScoreForDecisionMaking;
        public string HmdaCreditScoreForDecisionMaking { get { return _hmdaCreditScoreForDecisionMaking; } set { _hmdaCreditScoreForDecisionMaking = value; } }
        private Value<string> _hmdaCreditScoringModel;
        public string HmdaCreditScoringModel { get { return _hmdaCreditScoringModel; } set { _hmdaCreditScoringModel = value; } }
        private Value<bool?> _hmdaCubanIndicator;
        public bool? HmdaCubanIndicator { get { return _hmdaCubanIndicator; } set { _hmdaCubanIndicator = value; } }
        private Value<string> _hmdaEthnicityType;
        public string HmdaEthnicityType { get { return _hmdaEthnicityType; } set { _hmdaEthnicityType = value; } }
        private Value<bool?> _hmdaFilipinoIndicator;
        public bool? HmdaFilipinoIndicator { get { return _hmdaFilipinoIndicator; } set { _hmdaFilipinoIndicator = value; } }
        private Value<string> _hmdaGenderType;
        public string HmdaGenderType { get { return _hmdaGenderType; } set { _hmdaGenderType = value; } }
        private Value<bool?> _hmdaGuamanianOrChamorroIndicator;
        public bool? HmdaGuamanianOrChamorroIndicator { get { return _hmdaGuamanianOrChamorroIndicator; } set { _hmdaGuamanianOrChamorroIndicator = value; } }
        private Value<bool?> _hmdaHispanicLatinoOtherOriginIndicator;
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get { return _hmdaHispanicLatinoOtherOriginIndicator; } set { _hmdaHispanicLatinoOtherOriginIndicator = value; } }
        private Value<bool?> _hmdaJapaneseIndicator;
        public bool? HmdaJapaneseIndicator { get { return _hmdaJapaneseIndicator; } set { _hmdaJapaneseIndicator = value; } }
        private Value<bool?> _hmdaKoreanIndicator;
        public bool? HmdaKoreanIndicator { get { return _hmdaKoreanIndicator; } set { _hmdaKoreanIndicator = value; } }
        private Value<bool?> _hmdaMexicanIndicator;
        public bool? HmdaMexicanIndicator { get { return _hmdaMexicanIndicator; } set { _hmdaMexicanIndicator = value; } }
        private Value<bool?> _hmdaNativeHawaiianIndicator;
        public bool? HmdaNativeHawaiianIndicator { get { return _hmdaNativeHawaiianIndicator; } set { _hmdaNativeHawaiianIndicator = value; } }
        private Value<bool?> _hmdaNoCoApplicantIndicator;
        public bool? HmdaNoCoApplicantIndicator { get { return _hmdaNoCoApplicantIndicator; } set { _hmdaNoCoApplicantIndicator = value; } }
        private Value<bool?> _hmdaNotApplicableIndicator;
        public bool? HmdaNotApplicableIndicator { get { return _hmdaNotApplicableIndicator; } set { _hmdaNotApplicableIndicator = value; } }
        private Value<bool?> _hmdaNotProvidedIndicator;
        public bool? HmdaNotProvidedIndicator { get { return _hmdaNotProvidedIndicator; } set { _hmdaNotProvidedIndicator = value; } }
        private Value<string> _hmdaOtherAsianRace;
        public string HmdaOtherAsianRace { get { return _hmdaOtherAsianRace; } set { _hmdaOtherAsianRace = value; } }
        private Value<string> _hmdaOtherHispanicLatinoOrigin;
        public string HmdaOtherHispanicLatinoOrigin { get { return _hmdaOtherHispanicLatinoOrigin; } set { _hmdaOtherHispanicLatinoOrigin = value; } }
        private Value<string> _hmdaOtherPacificIslanderRace;
        public string HmdaOtherPacificIslanderRace { get { return _hmdaOtherPacificIslanderRace; } set { _hmdaOtherPacificIslanderRace = value; } }
        private Value<string> _hmdaOtherScoringModel;
        public string HmdaOtherScoringModel { get { return _hmdaOtherScoringModel; } set { _hmdaOtherScoringModel = value; } }
        private Value<bool?> _hmdaPacificIslanderIndicator;
        public bool? HmdaPacificIslanderIndicator { get { return _hmdaPacificIslanderIndicator; } set { _hmdaPacificIslanderIndicator = value; } }
        private Value<bool?> _hmdaPacificIslanderOtherIndicator;
        public bool? HmdaPacificIslanderOtherIndicator { get { return _hmdaPacificIslanderOtherIndicator; } set { _hmdaPacificIslanderOtherIndicator = value; } }
        private Value<bool?> _hmdaPuertoRicanIndicator;
        public bool? HmdaPuertoRicanIndicator { get { return _hmdaPuertoRicanIndicator; } set { _hmdaPuertoRicanIndicator = value; } }
        private Value<bool?> _hmdaRefusalIndicator;
        public bool? HmdaRefusalIndicator { get { return _hmdaRefusalIndicator; } set { _hmdaRefusalIndicator = value; } }
        private Value<bool?> _hmdaSamoanIndicator;
        public bool? HmdaSamoanIndicator { get { return _hmdaSamoanIndicator; } set { _hmdaSamoanIndicator = value; } }
        private Value<bool?> _hmdaVietnameseIndicator;
        public bool? HmdaVietnameseIndicator { get { return _hmdaVietnameseIndicator; } set { _hmdaVietnameseIndicator = value; } }
        private Value<bool?> _hmdaWhiteIndicator;
        public bool? HmdaWhiteIndicator { get { return _hmdaWhiteIndicator; } set { _hmdaWhiteIndicator = value; } }
        private Value<bool?> _homeownerPastThreeYearsIndicator;
        public bool? HomeownerPastThreeYearsIndicator { get { return _homeownerPastThreeYearsIndicator; } set { _homeownerPastThreeYearsIndicator = value; } }
        private Value<string> _homePhoneNumber;
        public string HomePhoneNumber { get { return _homePhoneNumber; } set { _homePhoneNumber = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _intentToOccupyIndicator;
        public bool? IntentToOccupyIndicator { get { return _intentToOccupyIndicator; } set { _intentToOccupyIndicator = value; } }
        private Value<string> _intuitReportId;
        public string IntuitReportId { get { return _intuitReportId; } set { _intuitReportId = value; } }
        private Value<bool?> _isBorrower;
        public bool? IsBorrower { get { return _isBorrower; } set { _isBorrower = value; } }
        private Value<string> _isEthnicityBasedOnVisual;
        public string IsEthnicityBasedOnVisual { get { return _isEthnicityBasedOnVisual; } set { _isEthnicityBasedOnVisual = value; } }
        private Value<string> _isRaceBasedOnVisual;
        public string IsRaceBasedOnVisual { get { return _isRaceBasedOnVisual; } set { _isRaceBasedOnVisual = value; } }
        private Value<string> _isSexBasedOnVisual;
        public string IsSexBasedOnVisual { get { return _isSexBasedOnVisual; } set { _isSexBasedOnVisual = value; } }
        private Value<string> _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private Value<string> _lastNameWithSuffix;
        public string LastNameWithSuffix { get { return _lastNameWithSuffix; } set { _lastNameWithSuffix = value; } }
        private Value<bool?> _loanForeclosureOrJudgementIndicator;
        public bool? LoanForeclosureOrJudgementIndicator { get { return _loanForeclosureOrJudgementIndicator; } set { _loanForeclosureOrJudgementIndicator = value; } }
        private Value<string> _lpdGsa;
        public string LpdGsa { get { return _lpdGsa; } set { _lpdGsa = value; } }
        private Value<bool?> _mailingAddressSameAsPresentIndicator;
        public bool? MailingAddressSameAsPresentIndicator { get { return _mailingAddressSameAsPresentIndicator; } set { _mailingAddressSameAsPresentIndicator = value; } }
        private Value<string> _maritalStatusType;
        public string MaritalStatusType { get { return _maritalStatusType; } set { _maritalStatusType = value; } }
        private Value<int?> _middleCreditScore;
        public int? MiddleCreditScore { get { return _middleCreditScore; } set { _middleCreditScore = value; } }
        private Value<string> _middleFicoScore;
        public string MiddleFicoScore { get { return _middleFicoScore; } set { _middleFicoScore = value; } }
        private Value<string> _middleName;
        public string MiddleName { get { return _middleName; } set { _middleName = value; } }
        private Value<string> _minFicoScore;
        public string MinFicoScore { get { return _minFicoScore; } set { _minFicoScore = value; } }
        private Value<string> _mobilePhone;
        public string MobilePhone { get { return _mobilePhone; } set { _mobilePhone = value; } }
        private Value<bool?> _mortgageOnCredit;
        public bool? MortgageOnCredit { get { return _mortgageOnCredit; } set { _mortgageOnCredit = value; } }
        private Value<string> _nameToObtainLoanFromRHS;
        public string NameToObtainLoanFromRHS { get { return _nameToObtainLoanFromRHS; } set { _nameToObtainLoanFromRHS = value; } }
        private Value<string> _nearestRelativeAddress;
        public string NearestRelativeAddress { get { return _nearestRelativeAddress; } set { _nearestRelativeAddress = value; } }
        private Value<string> _nearestRelativeCity;
        public string NearestRelativeCity { get { return _nearestRelativeCity; } set { _nearestRelativeCity = value; } }
        private Value<string> _nearestRelativeName;
        public string NearestRelativeName { get { return _nearestRelativeName; } set { _nearestRelativeName = value; } }
        private Value<string> _nearestRelativePhone;
        public string NearestRelativePhone { get { return _nearestRelativePhone; } set { _nearestRelativePhone = value; } }
        private Value<string> _nearestRelativePostalCode;
        public string NearestRelativePostalCode { get { return _nearestRelativePostalCode; } set { _nearestRelativePostalCode = value; } }
        private Value<string> _nearestRelativeRelationship;
        public string NearestRelativeRelationship { get { return _nearestRelativeRelationship; } set { _nearestRelativeRelationship = value; } }
        private Value<string> _nearestRelativeState;
        public string NearestRelativeState { get { return _nearestRelativeState; } set { _nearestRelativeState = value; } }
        private Value<bool?> _no3rdPartyEmailIndicator;
        public bool? No3rdPartyEmailIndicator { get { return _no3rdPartyEmailIndicator; } set { _no3rdPartyEmailIndicator = value; } }
        private Value<bool?> _noCoApplicantIndicator;
        public bool? NoCoApplicantIndicator { get { return _noCoApplicantIndicator; } set { _noCoApplicantIndicator = value; } }
        private Value<int?> _numberofTradelines;
        public int? NumberofTradelines { get { return _numberofTradelines; } set { _numberofTradelines = value; } }
        private Value<bool?> _obtainLoanFromRHSIndicator;
        public bool? ObtainLoanFromRHSIndicator { get { return _obtainLoanFromRHSIndicator; } set { _obtainLoanFromRHSIndicator = value; } }
        private Value<string> _openBankruptcy2;
        public string OpenBankruptcy2 { get { return _openBankruptcy2; } set { _openBankruptcy2 = value; } }
        private Value<decimal?> _otherMonthlyIncomeAmount;
        public decimal? OtherMonthlyIncomeAmount { get { return _otherMonthlyIncomeAmount; } set { _otherMonthlyIncomeAmount = value; } }
        private Value<decimal?> _otherSumAmount;
        public decimal? OtherSumAmount { get { return _otherSumAmount; } set { _otherSumAmount = value; } }
        private Value<bool?> _outstandingJudgementsIndicator;
        public bool? OutstandingJudgementsIndicator { get { return _outstandingJudgementsIndicator; } set { _outstandingJudgementsIndicator = value; } }
        private Value<bool?> _partyToLawsuitIndicator;
        public bool? PartyToLawsuitIndicator { get { return _partyToLawsuitIndicator; } set { _partyToLawsuitIndicator = value; } }
        private Value<int?> _pass120Days;
        public int? Pass120Days { get { return _pass120Days; } set { _pass120Days = value; } }
        private Value<int?> _pass150Days;
        public int? Pass150Days { get { return _pass150Days; } set { _pass150Days = value; } }
        private Value<int?> _pass30Days;
        public int? Pass30Days { get { return _pass30Days; } set { _pass30Days = value; } }
        private Value<int?> _pass60Days;
        public int? Pass60Days { get { return _pass60Days; } set { _pass60Days = value; } }
        private Value<int?> _pass90Days;
        public int? Pass90Days { get { return _pass90Days; } set { _pass90Days = value; } }
        private Value<string> _personFaxNumber;
        public string PersonFaxNumber { get { return _personFaxNumber; } set { _personFaxNumber = value; } }
        private Value<decimal?> _personHoursPerWeek;
        public decimal? PersonHoursPerWeek { get { return _personHoursPerWeek; } set { _personHoursPerWeek = value; } }
        private Value<decimal?> _personIncomeAmount;
        public decimal? PersonIncomeAmount { get { return _personIncomeAmount; } set { _personIncomeAmount = value; } }
        private Value<string> _personIncomeFrequencyType;
        public string PersonIncomeFrequencyType { get { return _personIncomeFrequencyType; } set { _personIncomeFrequencyType = value; } }
        private Value<decimal?> _personMonthlyIncome;
        public decimal? PersonMonthlyIncome { get { return _personMonthlyIncome; } set { _personMonthlyIncome = value; } }
        private Value<string> _poaOccupancyIntent;
        public string PoaOccupancyIntent { get { return _poaOccupancyIntent; } set { _poaOccupancyIntent = value; } }
        private Value<string> _poaSignatureText;
        public string PoaSignatureText { get { return _poaSignatureText; } set { _poaSignatureText = value; } }
        private Value<decimal?> _positiveCashFlow;
        public decimal? PositiveCashFlow { get { return _positiveCashFlow; } set { _positiveCashFlow = value; } }
        private Value<string> _powerOfAttorneyName;
        public string PowerOfAttorneyName { get { return _powerOfAttorneyName; } set { _powerOfAttorneyName = value; } }
        private Value<string> _powerOfAttorneyTitleDescription;
        public string PowerOfAttorneyTitleDescription { get { return _powerOfAttorneyTitleDescription; } set { _powerOfAttorneyTitleDescription = value; } }
        private Value<bool?> _presentlyDelinquentIndicator;
        public bool? PresentlyDelinquentIndicator { get { return _presentlyDelinquentIndicator; } set { _presentlyDelinquentIndicator = value; } }
        private Value<DateTime?> _priorBankruptcy2;
        public DateTime? PriorBankruptcy2 { get { return _priorBankruptcy2; } set { _priorBankruptcy2 = value; } }
        private Value<bool?> _priorForeclosure;
        public bool? PriorForeclosure { get { return _priorForeclosure; } set { _priorForeclosure = value; } }
        private Value<string> _priorPropertyTitleType;
        public string PriorPropertyTitleType { get { return _priorPropertyTitleType; } set { _priorPropertyTitleType = value; } }
        private Value<string> _priorPropertyUsageType;
        public string PriorPropertyUsageType { get { return _priorPropertyUsageType; } set { _priorPropertyUsageType = value; } }
        private Value<bool?> _propertyForeclosedPastSevenYearsIndicator;
        public bool? PropertyForeclosedPastSevenYearsIndicator { get { return _propertyForeclosedPastSevenYearsIndicator; } set { _propertyForeclosedPastSevenYearsIndicator = value; } }
        private Value<string> _relationshipDescription;
        public string RelationshipDescription { get { return _relationshipDescription; } set { _relationshipDescription = value; } }
        private Value<bool?> _relationshipWithRDEmployeeIndicator;
        public bool? RelationshipWithRDEmployeeIndicator { get { return _relationshipWithRDEmployeeIndicator; } set { _relationshipWithRDEmployeeIndicator = value; } }
        private Value<int?> _schoolingTermYears;
        public int? SchoolingTermYears { get { return _schoolingTermYears; } set { _schoolingTermYears = value; } }
        private Value<bool?> _sSA89BackgroundCheckIndicator;
        public bool? SSA89BackgroundCheckIndicator { get { return _sSA89BackgroundCheckIndicator; } set { _sSA89BackgroundCheckIndicator = value; } }
        private Value<bool?> _sSA89BankingServiceIndicator;
        public bool? SSA89BankingServiceIndicator { get { return _sSA89BankingServiceIndicator; } set { _sSA89BankingServiceIndicator = value; } }
        private Value<bool?> _sSA89CreditCheckIndicator;
        public bool? SSA89CreditCheckIndicator { get { return _sSA89CreditCheckIndicator; } set { _sSA89CreditCheckIndicator = value; } }
        private Value<bool?> _sSA89LicenseRequirementIndicator;
        public bool? SSA89LicenseRequirementIndicator { get { return _sSA89LicenseRequirementIndicator; } set { _sSA89LicenseRequirementIndicator = value; } }
        private Value<bool?> _sSA89MortgageServiceIndicator;
        public bool? SSA89MortgageServiceIndicator { get { return _sSA89MortgageServiceIndicator; } set { _sSA89MortgageServiceIndicator = value; } }
        private Value<bool?> _sSA89OtherIndicator;
        public bool? SSA89OtherIndicator { get { return _sSA89OtherIndicator; } set { _sSA89OtherIndicator = value; } }
        private Value<decimal?> _subtotalLiquidAssetsMinusGiftAmount;
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get { return _subtotalLiquidAssetsMinusGiftAmount; } set { _subtotalLiquidAssetsMinusGiftAmount = value; } }
        private Value<string> _suffixToName;
        public string SuffixToName { get { return _suffixToName; } set { _suffixToName = value; } }
        private Value<string> _tax4506LastInvestor;
        public string Tax4506LastInvestor { get { return _tax4506LastInvestor; } set { _tax4506LastInvestor = value; } }
        private Value<string> _tax4506LastOrderNumber;
        public string Tax4506LastOrderNumber { get { return _tax4506LastOrderNumber; } set { _tax4506LastOrderNumber = value; } }
        private Value<int?> _tax4506LastOrderYear1;
        public int? Tax4506LastOrderYear1 { get { return _tax4506LastOrderYear1; } set { _tax4506LastOrderYear1 = value; } }
        private Value<int?> _tax4506LastOrderYear2;
        public int? Tax4506LastOrderYear2 { get { return _tax4506LastOrderYear2; } set { _tax4506LastOrderYear2 = value; } }
        private Value<int?> _tax4506LastOrderYear3;
        public int? Tax4506LastOrderYear3 { get { return _tax4506LastOrderYear3; } set { _tax4506LastOrderYear3 = value; } }
        private Value<int?> _tax4506LastOrderYear4;
        public int? Tax4506LastOrderYear4 { get { return _tax4506LastOrderYear4; } set { _tax4506LastOrderYear4 = value; } }
        private Value<string> _tax4506LastProductsOrdered;
        public string Tax4506LastProductsOrdered { get { return _tax4506LastProductsOrdered; } set { _tax4506LastProductsOrdered = value; } }
        private Value<string> _tax4506LastStatus;
        public string Tax4506LastStatus { get { return _tax4506LastStatus; } set { _tax4506LastStatus = value; } }
        private Value<string> _tax4506LastTranscriptType;
        public string Tax4506LastTranscriptType { get { return _tax4506LastTranscriptType; } set { _tax4506LastTranscriptType = value; } }
        private Value<string> _tax4506LastUserIDWhoOrdered;
        public string Tax4506LastUserIDWhoOrdered { get { return _tax4506LastUserIDWhoOrdered; } set { _tax4506LastUserIDWhoOrdered = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome1;
        public decimal? Tax4506TotalYearlyIncome1 { get { return _tax4506TotalYearlyIncome1; } set { _tax4506TotalYearlyIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome2;
        public decimal? Tax4506TotalYearlyIncome2 { get { return _tax4506TotalYearlyIncome2; } set { _tax4506TotalYearlyIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome3;
        public decimal? Tax4506TotalYearlyIncome3 { get { return _tax4506TotalYearlyIncome3; } set { _tax4506TotalYearlyIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome4;
        public decimal? Tax4506TotalYearlyIncome4 { get { return _tax4506TotalYearlyIncome4; } set { _tax4506TotalYearlyIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome1;
        public decimal? Tax4506TotalYearlyJointIncome1 { get { return _tax4506TotalYearlyJointIncome1; } set { _tax4506TotalYearlyJointIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome2;
        public decimal? Tax4506TotalYearlyJointIncome2 { get { return _tax4506TotalYearlyJointIncome2; } set { _tax4506TotalYearlyJointIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome3;
        public decimal? Tax4506TotalYearlyJointIncome3 { get { return _tax4506TotalYearlyJointIncome3; } set { _tax4506TotalYearlyJointIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome4;
        public decimal? Tax4506TotalYearlyJointIncome4 { get { return _tax4506TotalYearlyJointIncome4; } set { _tax4506TotalYearlyJointIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome1;
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get { return _tax4506TotalYearlyVarianceIncome1; } set { _tax4506TotalYearlyVarianceIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome2;
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get { return _tax4506TotalYearlyVarianceIncome2; } set { _tax4506TotalYearlyVarianceIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome3;
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get { return _tax4506TotalYearlyVarianceIncome3; } set { _tax4506TotalYearlyVarianceIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome4;
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get { return _tax4506TotalYearlyVarianceIncome4; } set { _tax4506TotalYearlyVarianceIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome1;
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get { return _tax4506TotalYearlyVarianceJointIncome1; } set { _tax4506TotalYearlyVarianceJointIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome2;
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get { return _tax4506TotalYearlyVarianceJointIncome2; } set { _tax4506TotalYearlyVarianceJointIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome3;
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get { return _tax4506TotalYearlyVarianceJointIncome3; } set { _tax4506TotalYearlyVarianceJointIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome4;
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get { return _tax4506TotalYearlyVarianceJointIncome4; } set { _tax4506TotalYearlyVarianceJointIncome4 = value; } }
        private Value<string> _taxIdentificationIdentifier;
        public string TaxIdentificationIdentifier { get { return _taxIdentificationIdentifier; } set { _taxIdentificationIdentifier = value; } }
        private Value<decimal?> _totalLiabilitiesBalanceAmount;
        public decimal? TotalLiabilitiesBalanceAmount { get { return _totalLiabilitiesBalanceAmount; } set { _totalLiabilitiesBalanceAmount = value; } }
        private Value<decimal?> _totalMonthlyIncomeAmount;
        public decimal? TotalMonthlyIncomeAmount { get { return _totalMonthlyIncomeAmount; } set { _totalMonthlyIncomeAmount = value; } }
        private Value<decimal?> _totalMonthlyIncomeMinusNetRentalAmount;
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get { return _totalMonthlyIncomeMinusNetRentalAmount; } set { _totalMonthlyIncomeMinusNetRentalAmount = value; } }
        private Value<decimal?> _totalPresentHousingExpenseAmount;
        public decimal? TotalPresentHousingExpenseAmount { get { return _totalPresentHousingExpenseAmount; } set { _totalPresentHousingExpenseAmount = value; } }
        private Value<string> _transactionPurposeDescription;
        public string TransactionPurposeDescription { get { return _transactionPurposeDescription; } set { _transactionPurposeDescription = value; } }
        private Value<int?> _transUnion120Days;
        public int? TransUnion120Days { get { return _transUnion120Days; } set { _transUnion120Days = value; } }
        private Value<int?> _transUnion150Days;
        public int? TransUnion150Days { get { return _transUnion150Days; } set { _transUnion150Days = value; } }
        private Value<int?> _transUnion30Days;
        public int? TransUnion30Days { get { return _transUnion30Days; } set { _transUnion30Days = value; } }
        private Value<int?> _transUnion60Days;
        public int? TransUnion60Days { get { return _transUnion60Days; } set { _transUnion60Days = value; } }
        private Value<int?> _transUnion90Days;
        public int? TransUnion90Days { get { return _transUnion90Days; } set { _transUnion90Days = value; } }
        private Value<bool?> _transUnionCreditScoreForDisclosure;
        public bool? TransUnionCreditScoreForDisclosure { get { return _transUnionCreditScoreForDisclosure; } set { _transUnionCreditScoreForDisclosure = value; } }
        private Value<int?> _transUnionCreditScoreRanksPercent;
        public int? TransUnionCreditScoreRanksPercent { get { return _transUnionCreditScoreRanksPercent; } set { _transUnionCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _transUnionDatePulled;
        public DateTime? TransUnionDatePulled { get { return _transUnionDatePulled; } set { _transUnionDatePulled = value; } }
        private Value<string> _transUnionFactorCode1;
        public string TransUnionFactorCode1 { get { return _transUnionFactorCode1; } set { _transUnionFactorCode1 = value; } }
        private Value<string> _transUnionFactorCode2;
        public string TransUnionFactorCode2 { get { return _transUnionFactorCode2; } set { _transUnionFactorCode2 = value; } }
        private Value<string> _transUnionFactorCode3;
        public string TransUnionFactorCode3 { get { return _transUnionFactorCode3; } set { _transUnionFactorCode3 = value; } }
        private Value<string> _transUnionFactorCode4;
        public string TransUnionFactorCode4 { get { return _transUnionFactorCode4; } set { _transUnionFactorCode4 = value; } }
        private Value<string> _transUnionFactorCode5;
        public string TransUnionFactorCode5 { get { return _transUnionFactorCode5; } set { _transUnionFactorCode5 = value; } }
        private Value<string> _transUnionKeyFactor1;
        public string TransUnionKeyFactor1 { get { return _transUnionKeyFactor1; } set { _transUnionKeyFactor1 = value; } }
        private Value<string> _transUnionKeyFactor2;
        public string TransUnionKeyFactor2 { get { return _transUnionKeyFactor2; } set { _transUnionKeyFactor2 = value; } }
        private Value<string> _transUnionKeyFactor3;
        public string TransUnionKeyFactor3 { get { return _transUnionKeyFactor3; } set { _transUnionKeyFactor3 = value; } }
        private Value<string> _transUnionKeyFactor4;
        public string TransUnionKeyFactor4 { get { return _transUnionKeyFactor4; } set { _transUnionKeyFactor4 = value; } }
        private Value<string> _transUnionKeyFactor5;
        public string TransUnionKeyFactor5 { get { return _transUnionKeyFactor5; } set { _transUnionKeyFactor5 = value; } }
        private Value<bool?> _transUnionMaterialTermsCreditByScore;
        public bool? TransUnionMaterialTermsCreditByScore { get { return _transUnionMaterialTermsCreditByScore; } set { _transUnionMaterialTermsCreditByScore = value; } }
        private Value<string> _transUnionScore;
        public string TransUnionScore { get { return _transUnionScore; } set { _transUnionScore = value; } }
        private Value<decimal?> _userDefinedIncome;
        public decimal? UserDefinedIncome { get { return _userDefinedIncome; } set { _userDefinedIncome = value; } }
        private Value<decimal?> _vaFederalTaxAmount;
        public decimal? VaFederalTaxAmount { get { return _vaFederalTaxAmount; } set { _vaFederalTaxAmount = value; } }
        private Value<int?> _validDaysForConsentCount;
        public int? ValidDaysForConsentCount { get { return _validDaysForConsentCount; } set { _validDaysForConsentCount = value; } }
        private Value<decimal?> _vaNetTakeHomePayAmount;
        public decimal? VaNetTakeHomePayAmount { get { return _vaNetTakeHomePayAmount; } set { _vaNetTakeHomePayAmount = value; } }
        private Value<decimal?> _vaOtherAmount;
        public decimal? VaOtherAmount { get { return _vaOtherAmount; } set { _vaOtherAmount = value; } }
        private Value<decimal?> _vaOtherNetIncomeAmount;
        public decimal? VaOtherNetIncomeAmount { get { return _vaOtherNetIncomeAmount; } set { _vaOtherNetIncomeAmount = value; } }
        private Value<decimal?> _vaRetirementAmount;
        public decimal? VaRetirementAmount { get { return _vaRetirementAmount; } set { _vaRetirementAmount = value; } }
        private Value<decimal?> _vaStateTaxAmount;
        public decimal? VaStateTaxAmount { get { return _vaStateTaxAmount; } set { _vaStateTaxAmount = value; } }
        private Value<decimal?> _vaTotalIncomeDeductionsAmount;
        public decimal? VaTotalIncomeDeductionsAmount { get { return _vaTotalIncomeDeductionsAmount; } set { _vaTotalIncomeDeductionsAmount = value; } }
        private Value<decimal?> _vaTotalNetIncomeAmount;
        public decimal? VaTotalNetIncomeAmount { get { return _vaTotalNetIncomeAmount; } set { _vaTotalNetIncomeAmount = value; } }
        private Value<string> _vendor1;
        public string Vendor1 { get { return _vendor1; } set { _vendor1 = value; } }
        private Value<string> _vendor10;
        public string Vendor10 { get { return _vendor10; } set { _vendor10 = value; } }
        private Value<string> _vendor11;
        public string Vendor11 { get { return _vendor11; } set { _vendor11 = value; } }
        private Value<string> _vendor12;
        public string Vendor12 { get { return _vendor12; } set { _vendor12 = value; } }
        private Value<string> _vendor2;
        public string Vendor2 { get { return _vendor2; } set { _vendor2 = value; } }
        private Value<string> _vendor3;
        public string Vendor3 { get { return _vendor3; } set { _vendor3 = value; } }
        private Value<string> _vendor4;
        public string Vendor4 { get { return _vendor4; } set { _vendor4 = value; } }
        private Value<string> _vendor5;
        public string Vendor5 { get { return _vendor5; } set { _vendor5 = value; } }
        private Value<string> _vendor6;
        public string Vendor6 { get { return _vendor6; } set { _vendor6 = value; } }
        private Value<string> _vendor7;
        public string Vendor7 { get { return _vendor7; } set { _vendor7 = value; } }
        private Value<string> _vendor8;
        public string Vendor8 { get { return _vendor8; } set { _vendor8 = value; } }
        private Value<string> _vendor9;
        public string Vendor9 { get { return _vendor9; } set { _vendor9 = value; } }
        private Value<string> _vestingTrusteeOfType;
        public string VestingTrusteeOfType { get { return _vestingTrusteeOfType; } set { _vestingTrusteeOfType = value; } }
        private Value<bool?> _veteranIndicator;
        public bool? VeteranIndicator { get { return _veteranIndicator; } set { _veteranIndicator = value; } }
        private Value<string> _workEmailAddress;
        public string WorkEmailAddress { get { return _workEmailAddress; } set { _workEmailAddress = value; } }
        private Value<int?> _yearsofCreditOnFile;
        public int? YearsofCreditOnFile { get { return _yearsofCreditOnFile; } set { _yearsofCreditOnFile = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acountChekAssetId.Clean
                    && _ageAtApplicationYearsCount.Clean
                    && _aliasName.Clean
                    && _alimonyChildSupportObligationIndicator.Clean
                    && _altId.Clean
                    && _applicantType.Clean
                    && _applicationTakenMethodType.Clean
                    && _authorizedCreditReportIndicator.Clean
                    && _authorizedToSignIndicator.Clean
                    && _bankAccountNumber.Clean
                    && _bankAccountType.Clean
                    && _bankContactAddress.Clean
                    && _bankContactCity.Clean
                    && _bankContactName.Clean
                    && _bankContactPostalCode.Clean
                    && _bankContactState.Clean
                    && _bankruptcyIndicator.Clean
                    && _bankruptcyStatus.Clean
                    && _baseMonthlyIncomeAmount.Clean
                    && _birthDate.Clean
                    && _borrowedDownPaymentIndicator.Clean
                    && _borrowerConsentRequestDate.Clean
                    && _borrowerIndex.Clean
                    && _borrowerType.Clean
                    && _borrowerTypeInSummary.Clean
                    && _caivrsIdentifier.Clean
                    && _citizenshipResidencyType.Clean
                    && _coMakerEndorserOfNoteIndicator.Clean
                    && _commentOfCreditReport.Clean
                    && _confirmedCRDIL.Clean
                    && _confirmedCRFCEC.Clean
                    && _confirmedCRFCIncorrect.Clean
                    && _confirmedCRPFS.Clean
                    && _confirmedOther.Clean
                    && _confirmedOtherDescription.Clean
                    && _creditCounseling.Clean
                    && _creditReceivedDate.Clean
                    && _creditReportAuthorizationMethod.Clean
                    && _creditScoreIndicator.Clean
                    && _dateAuthorizedCreditReport.Clean
                    && _dateOfBankruptcy.Clean
                    && _dateOfForeclosure.Clean
                    && _declarationsJIndicator.Clean
                    && _declarationsKIndicator.Clean
                    && _dependentCount.Clean
                    && _dependentsAgesDescription.Clean
                    && _disabledIndicator.Clean
                    && _emailAddressText.Clean
                    && _equifax120Days.Clean
                    && _equifax150Days.Clean
                    && _equifax30Days.Clean
                    && _equifax60Days.Clean
                    && _equifax90Days.Clean
                    && _equifaxCreditScoreForDisclosure.Clean
                    && _equifaxCreditScoreRanksPercent.Clean
                    && _equifaxDatePulled.Clean
                    && _equifaxFactorCode1.Clean
                    && _equifaxFactorCode2.Clean
                    && _equifaxFactorCode3.Clean
                    && _equifaxFactorCode4.Clean
                    && _equifaxFactorCode5.Clean
                    && _equifaxKeyFactor1.Clean
                    && _equifaxKeyFactor2.Clean
                    && _equifaxKeyFactor3.Clean
                    && _equifaxKeyFactor4.Clean
                    && _equifaxKeyFactor5.Clean
                    && _equifaxMaterialTermsCreditByScore.Clean
                    && _equifaxScore.Clean
                    && _experian120Days.Clean
                    && _experian150Days.Clean
                    && _experian30Days.Clean
                    && _experian60Days.Clean
                    && _experian90Days.Clean
                    && _experianCreditScore.Clean
                    && _experianCreditScoreForDisclosure.Clean
                    && _experianCreditScoreRanksPercent.Clean
                    && _experianDatePulled.Clean
                    && _experianFactorCode1.Clean
                    && _experianFactorCode2.Clean
                    && _experianFactorCode3.Clean
                    && _experianFactorCode4.Clean
                    && _experianFactorCode5.Clean
                    && _experianKeyFactor1.Clean
                    && _experianKeyFactor2.Clean
                    && _experianKeyFactor3.Clean
                    && _experianKeyFactor4.Clean
                    && _experianKeyFactor5.Clean
                    && _experianMaterialTermsCreditByScore.Clean
                    && _firstName.Clean
                    && _firstNameWithMiddleName.Clean
                    && _firstTimeHomeBuyer.Clean
                    && _foreclosureSatisfied.Clean
                    && _foreclosureStatus.Clean
                    && _freddieMacPerson1.Clean
                    && _freddieMacPerson2.Clean
                    && _fullName.Clean
                    && _fullNameWithSuffix.Clean
                    && _highestCreditLimit.Clean
                    && _hmda2003OtherRaceNationalOriginDescription.Clean
                    && _hmda2003RaceNationalOriginType.Clean
                    && _hmdaAfricanAmericanIndicator.Clean
                    && _hmdaAge.Clean
                    && _hmdaAmericanIndianIndicator.Clean
                    && _hmdaAmericanIndianTribe.Clean
                    && _hmdaAsianIndianIndicator.Clean
                    && _hmdaAsianIndicator.Clean
                    && _hmdaAsianOtherRaceIndicator.Clean
                    && _hmdaChineseIndicator.Clean
                    && _hmdaCreditScoreForDecisionMaking.Clean
                    && _hmdaCreditScoringModel.Clean
                    && _hmdaCubanIndicator.Clean
                    && _hmdaEthnicityType.Clean
                    && _hmdaFilipinoIndicator.Clean
                    && _hmdaGenderType.Clean
                    && _hmdaGuamanianOrChamorroIndicator.Clean
                    && _hmdaHispanicLatinoOtherOriginIndicator.Clean
                    && _hmdaJapaneseIndicator.Clean
                    && _hmdaKoreanIndicator.Clean
                    && _hmdaMexicanIndicator.Clean
                    && _hmdaNativeHawaiianIndicator.Clean
                    && _hmdaNoCoApplicantIndicator.Clean
                    && _hmdaNotApplicableIndicator.Clean
                    && _hmdaNotProvidedIndicator.Clean
                    && _hmdaOtherAsianRace.Clean
                    && _hmdaOtherHispanicLatinoOrigin.Clean
                    && _hmdaOtherPacificIslanderRace.Clean
                    && _hmdaOtherScoringModel.Clean
                    && _hmdaPacificIslanderIndicator.Clean
                    && _hmdaPacificIslanderOtherIndicator.Clean
                    && _hmdaPuertoRicanIndicator.Clean
                    && _hmdaRefusalIndicator.Clean
                    && _hmdaSamoanIndicator.Clean
                    && _hmdaVietnameseIndicator.Clean
                    && _hmdaWhiteIndicator.Clean
                    && _homeownerPastThreeYearsIndicator.Clean
                    && _homePhoneNumber.Clean
                    && _id.Clean
                    && _intentToOccupyIndicator.Clean
                    && _intuitReportId.Clean
                    && _isBorrower.Clean
                    && _isEthnicityBasedOnVisual.Clean
                    && _isRaceBasedOnVisual.Clean
                    && _isSexBasedOnVisual.Clean
                    && _lastName.Clean
                    && _lastNameWithSuffix.Clean
                    && _loanForeclosureOrJudgementIndicator.Clean
                    && _lpdGsa.Clean
                    && _mailingAddressSameAsPresentIndicator.Clean
                    && _maritalStatusType.Clean
                    && _middleCreditScore.Clean
                    && _middleFicoScore.Clean
                    && _middleName.Clean
                    && _minFicoScore.Clean
                    && _mobilePhone.Clean
                    && _mortgageOnCredit.Clean
                    && _nameToObtainLoanFromRHS.Clean
                    && _nearestRelativeAddress.Clean
                    && _nearestRelativeCity.Clean
                    && _nearestRelativeName.Clean
                    && _nearestRelativePhone.Clean
                    && _nearestRelativePostalCode.Clean
                    && _nearestRelativeRelationship.Clean
                    && _nearestRelativeState.Clean
                    && _no3rdPartyEmailIndicator.Clean
                    && _noCoApplicantIndicator.Clean
                    && _numberofTradelines.Clean
                    && _obtainLoanFromRHSIndicator.Clean
                    && _openBankruptcy2.Clean
                    && _otherMonthlyIncomeAmount.Clean
                    && _otherSumAmount.Clean
                    && _outstandingJudgementsIndicator.Clean
                    && _partyToLawsuitIndicator.Clean
                    && _pass120Days.Clean
                    && _pass150Days.Clean
                    && _pass30Days.Clean
                    && _pass60Days.Clean
                    && _pass90Days.Clean
                    && _personFaxNumber.Clean
                    && _personHoursPerWeek.Clean
                    && _personIncomeAmount.Clean
                    && _personIncomeFrequencyType.Clean
                    && _personMonthlyIncome.Clean
                    && _poaOccupancyIntent.Clean
                    && _poaSignatureText.Clean
                    && _positiveCashFlow.Clean
                    && _powerOfAttorneyName.Clean
                    && _powerOfAttorneyTitleDescription.Clean
                    && _presentlyDelinquentIndicator.Clean
                    && _priorBankruptcy2.Clean
                    && _priorForeclosure.Clean
                    && _priorPropertyTitleType.Clean
                    && _priorPropertyUsageType.Clean
                    && _propertyForeclosedPastSevenYearsIndicator.Clean
                    && _relationshipDescription.Clean
                    && _relationshipWithRDEmployeeIndicator.Clean
                    && _schoolingTermYears.Clean
                    && _sSA89BackgroundCheckIndicator.Clean
                    && _sSA89BankingServiceIndicator.Clean
                    && _sSA89CreditCheckIndicator.Clean
                    && _sSA89LicenseRequirementIndicator.Clean
                    && _sSA89MortgageServiceIndicator.Clean
                    && _sSA89OtherIndicator.Clean
                    && _subtotalLiquidAssetsMinusGiftAmount.Clean
                    && _suffixToName.Clean
                    && _tax4506LastInvestor.Clean
                    && _tax4506LastOrderNumber.Clean
                    && _tax4506LastOrderYear1.Clean
                    && _tax4506LastOrderYear2.Clean
                    && _tax4506LastOrderYear3.Clean
                    && _tax4506LastOrderYear4.Clean
                    && _tax4506LastProductsOrdered.Clean
                    && _tax4506LastStatus.Clean
                    && _tax4506LastTranscriptType.Clean
                    && _tax4506LastUserIDWhoOrdered.Clean
                    && _tax4506TotalYearlyIncome1.Clean
                    && _tax4506TotalYearlyIncome2.Clean
                    && _tax4506TotalYearlyIncome3.Clean
                    && _tax4506TotalYearlyIncome4.Clean
                    && _tax4506TotalYearlyJointIncome1.Clean
                    && _tax4506TotalYearlyJointIncome2.Clean
                    && _tax4506TotalYearlyJointIncome3.Clean
                    && _tax4506TotalYearlyJointIncome4.Clean
                    && _tax4506TotalYearlyVarianceIncome1.Clean
                    && _tax4506TotalYearlyVarianceIncome2.Clean
                    && _tax4506TotalYearlyVarianceIncome3.Clean
                    && _tax4506TotalYearlyVarianceIncome4.Clean
                    && _tax4506TotalYearlyVarianceJointIncome1.Clean
                    && _tax4506TotalYearlyVarianceJointIncome2.Clean
                    && _tax4506TotalYearlyVarianceJointIncome3.Clean
                    && _tax4506TotalYearlyVarianceJointIncome4.Clean
                    && _taxIdentificationIdentifier.Clean
                    && _totalLiabilitiesBalanceAmount.Clean
                    && _totalMonthlyIncomeAmount.Clean
                    && _totalMonthlyIncomeMinusNetRentalAmount.Clean
                    && _totalPresentHousingExpenseAmount.Clean
                    && _transactionPurposeDescription.Clean
                    && _transUnion120Days.Clean
                    && _transUnion150Days.Clean
                    && _transUnion30Days.Clean
                    && _transUnion60Days.Clean
                    && _transUnion90Days.Clean
                    && _transUnionCreditScoreForDisclosure.Clean
                    && _transUnionCreditScoreRanksPercent.Clean
                    && _transUnionDatePulled.Clean
                    && _transUnionFactorCode1.Clean
                    && _transUnionFactorCode2.Clean
                    && _transUnionFactorCode3.Clean
                    && _transUnionFactorCode4.Clean
                    && _transUnionFactorCode5.Clean
                    && _transUnionKeyFactor1.Clean
                    && _transUnionKeyFactor2.Clean
                    && _transUnionKeyFactor3.Clean
                    && _transUnionKeyFactor4.Clean
                    && _transUnionKeyFactor5.Clean
                    && _transUnionMaterialTermsCreditByScore.Clean
                    && _transUnionScore.Clean
                    && _userDefinedIncome.Clean
                    && _vaFederalTaxAmount.Clean
                    && _validDaysForConsentCount.Clean
                    && _vaNetTakeHomePayAmount.Clean
                    && _vaOtherAmount.Clean
                    && _vaOtherNetIncomeAmount.Clean
                    && _vaRetirementAmount.Clean
                    && _vaStateTaxAmount.Clean
                    && _vaTotalIncomeDeductionsAmount.Clean
                    && _vaTotalNetIncomeAmount.Clean
                    && _vendor1.Clean
                    && _vendor10.Clean
                    && _vendor11.Clean
                    && _vendor12.Clean
                    && _vendor2.Clean
                    && _vendor3.Clean
                    && _vendor4.Clean
                    && _vendor5.Clean
                    && _vendor6.Clean
                    && _vendor7.Clean
                    && _vendor8.Clean
                    && _vendor9.Clean
                    && _vestingTrusteeOfType.Clean
                    && _veteranIndicator.Clean
                    && _workEmailAddress.Clean
                    && _yearsofCreditOnFile.Clean
                    && Application.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _acountChekAssetId; v0.Clean = value; _acountChekAssetId = v0;
                var v1 = _ageAtApplicationYearsCount; v1.Clean = value; _ageAtApplicationYearsCount = v1;
                var v2 = _aliasName; v2.Clean = value; _aliasName = v2;
                var v3 = _alimonyChildSupportObligationIndicator; v3.Clean = value; _alimonyChildSupportObligationIndicator = v3;
                var v4 = _altId; v4.Clean = value; _altId = v4;
                var v5 = _applicantType; v5.Clean = value; _applicantType = v5;
                var v6 = _applicationTakenMethodType; v6.Clean = value; _applicationTakenMethodType = v6;
                var v7 = _authorizedCreditReportIndicator; v7.Clean = value; _authorizedCreditReportIndicator = v7;
                var v8 = _authorizedToSignIndicator; v8.Clean = value; _authorizedToSignIndicator = v8;
                var v9 = _bankAccountNumber; v9.Clean = value; _bankAccountNumber = v9;
                var v10 = _bankAccountType; v10.Clean = value; _bankAccountType = v10;
                var v11 = _bankContactAddress; v11.Clean = value; _bankContactAddress = v11;
                var v12 = _bankContactCity; v12.Clean = value; _bankContactCity = v12;
                var v13 = _bankContactName; v13.Clean = value; _bankContactName = v13;
                var v14 = _bankContactPostalCode; v14.Clean = value; _bankContactPostalCode = v14;
                var v15 = _bankContactState; v15.Clean = value; _bankContactState = v15;
                var v16 = _bankruptcyIndicator; v16.Clean = value; _bankruptcyIndicator = v16;
                var v17 = _bankruptcyStatus; v17.Clean = value; _bankruptcyStatus = v17;
                var v18 = _baseMonthlyIncomeAmount; v18.Clean = value; _baseMonthlyIncomeAmount = v18;
                var v19 = _birthDate; v19.Clean = value; _birthDate = v19;
                var v20 = _borrowedDownPaymentIndicator; v20.Clean = value; _borrowedDownPaymentIndicator = v20;
                var v21 = _borrowerConsentRequestDate; v21.Clean = value; _borrowerConsentRequestDate = v21;
                var v22 = _borrowerIndex; v22.Clean = value; _borrowerIndex = v22;
                var v23 = _borrowerType; v23.Clean = value; _borrowerType = v23;
                var v24 = _borrowerTypeInSummary; v24.Clean = value; _borrowerTypeInSummary = v24;
                var v25 = _caivrsIdentifier; v25.Clean = value; _caivrsIdentifier = v25;
                var v26 = _citizenshipResidencyType; v26.Clean = value; _citizenshipResidencyType = v26;
                var v27 = _coMakerEndorserOfNoteIndicator; v27.Clean = value; _coMakerEndorserOfNoteIndicator = v27;
                var v28 = _commentOfCreditReport; v28.Clean = value; _commentOfCreditReport = v28;
                var v29 = _confirmedCRDIL; v29.Clean = value; _confirmedCRDIL = v29;
                var v30 = _confirmedCRFCEC; v30.Clean = value; _confirmedCRFCEC = v30;
                var v31 = _confirmedCRFCIncorrect; v31.Clean = value; _confirmedCRFCIncorrect = v31;
                var v32 = _confirmedCRPFS; v32.Clean = value; _confirmedCRPFS = v32;
                var v33 = _confirmedOther; v33.Clean = value; _confirmedOther = v33;
                var v34 = _confirmedOtherDescription; v34.Clean = value; _confirmedOtherDescription = v34;
                var v35 = _creditCounseling; v35.Clean = value; _creditCounseling = v35;
                var v36 = _creditReceivedDate; v36.Clean = value; _creditReceivedDate = v36;
                var v37 = _creditReportAuthorizationMethod; v37.Clean = value; _creditReportAuthorizationMethod = v37;
                var v38 = _creditScoreIndicator; v38.Clean = value; _creditScoreIndicator = v38;
                var v39 = _dateAuthorizedCreditReport; v39.Clean = value; _dateAuthorizedCreditReport = v39;
                var v40 = _dateOfBankruptcy; v40.Clean = value; _dateOfBankruptcy = v40;
                var v41 = _dateOfForeclosure; v41.Clean = value; _dateOfForeclosure = v41;
                var v42 = _declarationsJIndicator; v42.Clean = value; _declarationsJIndicator = v42;
                var v43 = _declarationsKIndicator; v43.Clean = value; _declarationsKIndicator = v43;
                var v44 = _dependentCount; v44.Clean = value; _dependentCount = v44;
                var v45 = _dependentsAgesDescription; v45.Clean = value; _dependentsAgesDescription = v45;
                var v46 = _disabledIndicator; v46.Clean = value; _disabledIndicator = v46;
                var v47 = _emailAddressText; v47.Clean = value; _emailAddressText = v47;
                var v48 = _equifax120Days; v48.Clean = value; _equifax120Days = v48;
                var v49 = _equifax150Days; v49.Clean = value; _equifax150Days = v49;
                var v50 = _equifax30Days; v50.Clean = value; _equifax30Days = v50;
                var v51 = _equifax60Days; v51.Clean = value; _equifax60Days = v51;
                var v52 = _equifax90Days; v52.Clean = value; _equifax90Days = v52;
                var v53 = _equifaxCreditScoreForDisclosure; v53.Clean = value; _equifaxCreditScoreForDisclosure = v53;
                var v54 = _equifaxCreditScoreRanksPercent; v54.Clean = value; _equifaxCreditScoreRanksPercent = v54;
                var v55 = _equifaxDatePulled; v55.Clean = value; _equifaxDatePulled = v55;
                var v56 = _equifaxFactorCode1; v56.Clean = value; _equifaxFactorCode1 = v56;
                var v57 = _equifaxFactorCode2; v57.Clean = value; _equifaxFactorCode2 = v57;
                var v58 = _equifaxFactorCode3; v58.Clean = value; _equifaxFactorCode3 = v58;
                var v59 = _equifaxFactorCode4; v59.Clean = value; _equifaxFactorCode4 = v59;
                var v60 = _equifaxFactorCode5; v60.Clean = value; _equifaxFactorCode5 = v60;
                var v61 = _equifaxKeyFactor1; v61.Clean = value; _equifaxKeyFactor1 = v61;
                var v62 = _equifaxKeyFactor2; v62.Clean = value; _equifaxKeyFactor2 = v62;
                var v63 = _equifaxKeyFactor3; v63.Clean = value; _equifaxKeyFactor3 = v63;
                var v64 = _equifaxKeyFactor4; v64.Clean = value; _equifaxKeyFactor4 = v64;
                var v65 = _equifaxKeyFactor5; v65.Clean = value; _equifaxKeyFactor5 = v65;
                var v66 = _equifaxMaterialTermsCreditByScore; v66.Clean = value; _equifaxMaterialTermsCreditByScore = v66;
                var v67 = _equifaxScore; v67.Clean = value; _equifaxScore = v67;
                var v68 = _experian120Days; v68.Clean = value; _experian120Days = v68;
                var v69 = _experian150Days; v69.Clean = value; _experian150Days = v69;
                var v70 = _experian30Days; v70.Clean = value; _experian30Days = v70;
                var v71 = _experian60Days; v71.Clean = value; _experian60Days = v71;
                var v72 = _experian90Days; v72.Clean = value; _experian90Days = v72;
                var v73 = _experianCreditScore; v73.Clean = value; _experianCreditScore = v73;
                var v74 = _experianCreditScoreForDisclosure; v74.Clean = value; _experianCreditScoreForDisclosure = v74;
                var v75 = _experianCreditScoreRanksPercent; v75.Clean = value; _experianCreditScoreRanksPercent = v75;
                var v76 = _experianDatePulled; v76.Clean = value; _experianDatePulled = v76;
                var v77 = _experianFactorCode1; v77.Clean = value; _experianFactorCode1 = v77;
                var v78 = _experianFactorCode2; v78.Clean = value; _experianFactorCode2 = v78;
                var v79 = _experianFactorCode3; v79.Clean = value; _experianFactorCode3 = v79;
                var v80 = _experianFactorCode4; v80.Clean = value; _experianFactorCode4 = v80;
                var v81 = _experianFactorCode5; v81.Clean = value; _experianFactorCode5 = v81;
                var v82 = _experianKeyFactor1; v82.Clean = value; _experianKeyFactor1 = v82;
                var v83 = _experianKeyFactor2; v83.Clean = value; _experianKeyFactor2 = v83;
                var v84 = _experianKeyFactor3; v84.Clean = value; _experianKeyFactor3 = v84;
                var v85 = _experianKeyFactor4; v85.Clean = value; _experianKeyFactor4 = v85;
                var v86 = _experianKeyFactor5; v86.Clean = value; _experianKeyFactor5 = v86;
                var v87 = _experianMaterialTermsCreditByScore; v87.Clean = value; _experianMaterialTermsCreditByScore = v87;
                var v88 = _firstName; v88.Clean = value; _firstName = v88;
                var v89 = _firstNameWithMiddleName; v89.Clean = value; _firstNameWithMiddleName = v89;
                var v90 = _firstTimeHomeBuyer; v90.Clean = value; _firstTimeHomeBuyer = v90;
                var v91 = _foreclosureSatisfied; v91.Clean = value; _foreclosureSatisfied = v91;
                var v92 = _foreclosureStatus; v92.Clean = value; _foreclosureStatus = v92;
                var v93 = _freddieMacPerson1; v93.Clean = value; _freddieMacPerson1 = v93;
                var v94 = _freddieMacPerson2; v94.Clean = value; _freddieMacPerson2 = v94;
                var v95 = _fullName; v95.Clean = value; _fullName = v95;
                var v96 = _fullNameWithSuffix; v96.Clean = value; _fullNameWithSuffix = v96;
                var v97 = _highestCreditLimit; v97.Clean = value; _highestCreditLimit = v97;
                var v98 = _hmda2003OtherRaceNationalOriginDescription; v98.Clean = value; _hmda2003OtherRaceNationalOriginDescription = v98;
                var v99 = _hmda2003RaceNationalOriginType; v99.Clean = value; _hmda2003RaceNationalOriginType = v99;
                var v100 = _hmdaAfricanAmericanIndicator; v100.Clean = value; _hmdaAfricanAmericanIndicator = v100;
                var v101 = _hmdaAge; v101.Clean = value; _hmdaAge = v101;
                var v102 = _hmdaAmericanIndianIndicator; v102.Clean = value; _hmdaAmericanIndianIndicator = v102;
                var v103 = _hmdaAmericanIndianTribe; v103.Clean = value; _hmdaAmericanIndianTribe = v103;
                var v104 = _hmdaAsianIndianIndicator; v104.Clean = value; _hmdaAsianIndianIndicator = v104;
                var v105 = _hmdaAsianIndicator; v105.Clean = value; _hmdaAsianIndicator = v105;
                var v106 = _hmdaAsianOtherRaceIndicator; v106.Clean = value; _hmdaAsianOtherRaceIndicator = v106;
                var v107 = _hmdaChineseIndicator; v107.Clean = value; _hmdaChineseIndicator = v107;
                var v108 = _hmdaCreditScoreForDecisionMaking; v108.Clean = value; _hmdaCreditScoreForDecisionMaking = v108;
                var v109 = _hmdaCreditScoringModel; v109.Clean = value; _hmdaCreditScoringModel = v109;
                var v110 = _hmdaCubanIndicator; v110.Clean = value; _hmdaCubanIndicator = v110;
                var v111 = _hmdaEthnicityType; v111.Clean = value; _hmdaEthnicityType = v111;
                var v112 = _hmdaFilipinoIndicator; v112.Clean = value; _hmdaFilipinoIndicator = v112;
                var v113 = _hmdaGenderType; v113.Clean = value; _hmdaGenderType = v113;
                var v114 = _hmdaGuamanianOrChamorroIndicator; v114.Clean = value; _hmdaGuamanianOrChamorroIndicator = v114;
                var v115 = _hmdaHispanicLatinoOtherOriginIndicator; v115.Clean = value; _hmdaHispanicLatinoOtherOriginIndicator = v115;
                var v116 = _hmdaJapaneseIndicator; v116.Clean = value; _hmdaJapaneseIndicator = v116;
                var v117 = _hmdaKoreanIndicator; v117.Clean = value; _hmdaKoreanIndicator = v117;
                var v118 = _hmdaMexicanIndicator; v118.Clean = value; _hmdaMexicanIndicator = v118;
                var v119 = _hmdaNativeHawaiianIndicator; v119.Clean = value; _hmdaNativeHawaiianIndicator = v119;
                var v120 = _hmdaNoCoApplicantIndicator; v120.Clean = value; _hmdaNoCoApplicantIndicator = v120;
                var v121 = _hmdaNotApplicableIndicator; v121.Clean = value; _hmdaNotApplicableIndicator = v121;
                var v122 = _hmdaNotProvidedIndicator; v122.Clean = value; _hmdaNotProvidedIndicator = v122;
                var v123 = _hmdaOtherAsianRace; v123.Clean = value; _hmdaOtherAsianRace = v123;
                var v124 = _hmdaOtherHispanicLatinoOrigin; v124.Clean = value; _hmdaOtherHispanicLatinoOrigin = v124;
                var v125 = _hmdaOtherPacificIslanderRace; v125.Clean = value; _hmdaOtherPacificIslanderRace = v125;
                var v126 = _hmdaOtherScoringModel; v126.Clean = value; _hmdaOtherScoringModel = v126;
                var v127 = _hmdaPacificIslanderIndicator; v127.Clean = value; _hmdaPacificIslanderIndicator = v127;
                var v128 = _hmdaPacificIslanderOtherIndicator; v128.Clean = value; _hmdaPacificIslanderOtherIndicator = v128;
                var v129 = _hmdaPuertoRicanIndicator; v129.Clean = value; _hmdaPuertoRicanIndicator = v129;
                var v130 = _hmdaRefusalIndicator; v130.Clean = value; _hmdaRefusalIndicator = v130;
                var v131 = _hmdaSamoanIndicator; v131.Clean = value; _hmdaSamoanIndicator = v131;
                var v132 = _hmdaVietnameseIndicator; v132.Clean = value; _hmdaVietnameseIndicator = v132;
                var v133 = _hmdaWhiteIndicator; v133.Clean = value; _hmdaWhiteIndicator = v133;
                var v134 = _homeownerPastThreeYearsIndicator; v134.Clean = value; _homeownerPastThreeYearsIndicator = v134;
                var v135 = _homePhoneNumber; v135.Clean = value; _homePhoneNumber = v135;
                var v136 = _id; v136.Clean = value; _id = v136;
                var v137 = _intentToOccupyIndicator; v137.Clean = value; _intentToOccupyIndicator = v137;
                var v138 = _intuitReportId; v138.Clean = value; _intuitReportId = v138;
                var v139 = _isBorrower; v139.Clean = value; _isBorrower = v139;
                var v140 = _isEthnicityBasedOnVisual; v140.Clean = value; _isEthnicityBasedOnVisual = v140;
                var v141 = _isRaceBasedOnVisual; v141.Clean = value; _isRaceBasedOnVisual = v141;
                var v142 = _isSexBasedOnVisual; v142.Clean = value; _isSexBasedOnVisual = v142;
                var v143 = _lastName; v143.Clean = value; _lastName = v143;
                var v144 = _lastNameWithSuffix; v144.Clean = value; _lastNameWithSuffix = v144;
                var v145 = _loanForeclosureOrJudgementIndicator; v145.Clean = value; _loanForeclosureOrJudgementIndicator = v145;
                var v146 = _lpdGsa; v146.Clean = value; _lpdGsa = v146;
                var v147 = _mailingAddressSameAsPresentIndicator; v147.Clean = value; _mailingAddressSameAsPresentIndicator = v147;
                var v148 = _maritalStatusType; v148.Clean = value; _maritalStatusType = v148;
                var v149 = _middleCreditScore; v149.Clean = value; _middleCreditScore = v149;
                var v150 = _middleFicoScore; v150.Clean = value; _middleFicoScore = v150;
                var v151 = _middleName; v151.Clean = value; _middleName = v151;
                var v152 = _minFicoScore; v152.Clean = value; _minFicoScore = v152;
                var v153 = _mobilePhone; v153.Clean = value; _mobilePhone = v153;
                var v154 = _mortgageOnCredit; v154.Clean = value; _mortgageOnCredit = v154;
                var v155 = _nameToObtainLoanFromRHS; v155.Clean = value; _nameToObtainLoanFromRHS = v155;
                var v156 = _nearestRelativeAddress; v156.Clean = value; _nearestRelativeAddress = v156;
                var v157 = _nearestRelativeCity; v157.Clean = value; _nearestRelativeCity = v157;
                var v158 = _nearestRelativeName; v158.Clean = value; _nearestRelativeName = v158;
                var v159 = _nearestRelativePhone; v159.Clean = value; _nearestRelativePhone = v159;
                var v160 = _nearestRelativePostalCode; v160.Clean = value; _nearestRelativePostalCode = v160;
                var v161 = _nearestRelativeRelationship; v161.Clean = value; _nearestRelativeRelationship = v161;
                var v162 = _nearestRelativeState; v162.Clean = value; _nearestRelativeState = v162;
                var v163 = _no3rdPartyEmailIndicator; v163.Clean = value; _no3rdPartyEmailIndicator = v163;
                var v164 = _noCoApplicantIndicator; v164.Clean = value; _noCoApplicantIndicator = v164;
                var v165 = _numberofTradelines; v165.Clean = value; _numberofTradelines = v165;
                var v166 = _obtainLoanFromRHSIndicator; v166.Clean = value; _obtainLoanFromRHSIndicator = v166;
                var v167 = _openBankruptcy2; v167.Clean = value; _openBankruptcy2 = v167;
                var v168 = _otherMonthlyIncomeAmount; v168.Clean = value; _otherMonthlyIncomeAmount = v168;
                var v169 = _otherSumAmount; v169.Clean = value; _otherSumAmount = v169;
                var v170 = _outstandingJudgementsIndicator; v170.Clean = value; _outstandingJudgementsIndicator = v170;
                var v171 = _partyToLawsuitIndicator; v171.Clean = value; _partyToLawsuitIndicator = v171;
                var v172 = _pass120Days; v172.Clean = value; _pass120Days = v172;
                var v173 = _pass150Days; v173.Clean = value; _pass150Days = v173;
                var v174 = _pass30Days; v174.Clean = value; _pass30Days = v174;
                var v175 = _pass60Days; v175.Clean = value; _pass60Days = v175;
                var v176 = _pass90Days; v176.Clean = value; _pass90Days = v176;
                var v177 = _personFaxNumber; v177.Clean = value; _personFaxNumber = v177;
                var v178 = _personHoursPerWeek; v178.Clean = value; _personHoursPerWeek = v178;
                var v179 = _personIncomeAmount; v179.Clean = value; _personIncomeAmount = v179;
                var v180 = _personIncomeFrequencyType; v180.Clean = value; _personIncomeFrequencyType = v180;
                var v181 = _personMonthlyIncome; v181.Clean = value; _personMonthlyIncome = v181;
                var v182 = _poaOccupancyIntent; v182.Clean = value; _poaOccupancyIntent = v182;
                var v183 = _poaSignatureText; v183.Clean = value; _poaSignatureText = v183;
                var v184 = _positiveCashFlow; v184.Clean = value; _positiveCashFlow = v184;
                var v185 = _powerOfAttorneyName; v185.Clean = value; _powerOfAttorneyName = v185;
                var v186 = _powerOfAttorneyTitleDescription; v186.Clean = value; _powerOfAttorneyTitleDescription = v186;
                var v187 = _presentlyDelinquentIndicator; v187.Clean = value; _presentlyDelinquentIndicator = v187;
                var v188 = _priorBankruptcy2; v188.Clean = value; _priorBankruptcy2 = v188;
                var v189 = _priorForeclosure; v189.Clean = value; _priorForeclosure = v189;
                var v190 = _priorPropertyTitleType; v190.Clean = value; _priorPropertyTitleType = v190;
                var v191 = _priorPropertyUsageType; v191.Clean = value; _priorPropertyUsageType = v191;
                var v192 = _propertyForeclosedPastSevenYearsIndicator; v192.Clean = value; _propertyForeclosedPastSevenYearsIndicator = v192;
                var v193 = _relationshipDescription; v193.Clean = value; _relationshipDescription = v193;
                var v194 = _relationshipWithRDEmployeeIndicator; v194.Clean = value; _relationshipWithRDEmployeeIndicator = v194;
                var v195 = _schoolingTermYears; v195.Clean = value; _schoolingTermYears = v195;
                var v196 = _sSA89BackgroundCheckIndicator; v196.Clean = value; _sSA89BackgroundCheckIndicator = v196;
                var v197 = _sSA89BankingServiceIndicator; v197.Clean = value; _sSA89BankingServiceIndicator = v197;
                var v198 = _sSA89CreditCheckIndicator; v198.Clean = value; _sSA89CreditCheckIndicator = v198;
                var v199 = _sSA89LicenseRequirementIndicator; v199.Clean = value; _sSA89LicenseRequirementIndicator = v199;
                var v200 = _sSA89MortgageServiceIndicator; v200.Clean = value; _sSA89MortgageServiceIndicator = v200;
                var v201 = _sSA89OtherIndicator; v201.Clean = value; _sSA89OtherIndicator = v201;
                var v202 = _subtotalLiquidAssetsMinusGiftAmount; v202.Clean = value; _subtotalLiquidAssetsMinusGiftAmount = v202;
                var v203 = _suffixToName; v203.Clean = value; _suffixToName = v203;
                var v204 = _tax4506LastInvestor; v204.Clean = value; _tax4506LastInvestor = v204;
                var v205 = _tax4506LastOrderNumber; v205.Clean = value; _tax4506LastOrderNumber = v205;
                var v206 = _tax4506LastOrderYear1; v206.Clean = value; _tax4506LastOrderYear1 = v206;
                var v207 = _tax4506LastOrderYear2; v207.Clean = value; _tax4506LastOrderYear2 = v207;
                var v208 = _tax4506LastOrderYear3; v208.Clean = value; _tax4506LastOrderYear3 = v208;
                var v209 = _tax4506LastOrderYear4; v209.Clean = value; _tax4506LastOrderYear4 = v209;
                var v210 = _tax4506LastProductsOrdered; v210.Clean = value; _tax4506LastProductsOrdered = v210;
                var v211 = _tax4506LastStatus; v211.Clean = value; _tax4506LastStatus = v211;
                var v212 = _tax4506LastTranscriptType; v212.Clean = value; _tax4506LastTranscriptType = v212;
                var v213 = _tax4506LastUserIDWhoOrdered; v213.Clean = value; _tax4506LastUserIDWhoOrdered = v213;
                var v214 = _tax4506TotalYearlyIncome1; v214.Clean = value; _tax4506TotalYearlyIncome1 = v214;
                var v215 = _tax4506TotalYearlyIncome2; v215.Clean = value; _tax4506TotalYearlyIncome2 = v215;
                var v216 = _tax4506TotalYearlyIncome3; v216.Clean = value; _tax4506TotalYearlyIncome3 = v216;
                var v217 = _tax4506TotalYearlyIncome4; v217.Clean = value; _tax4506TotalYearlyIncome4 = v217;
                var v218 = _tax4506TotalYearlyJointIncome1; v218.Clean = value; _tax4506TotalYearlyJointIncome1 = v218;
                var v219 = _tax4506TotalYearlyJointIncome2; v219.Clean = value; _tax4506TotalYearlyJointIncome2 = v219;
                var v220 = _tax4506TotalYearlyJointIncome3; v220.Clean = value; _tax4506TotalYearlyJointIncome3 = v220;
                var v221 = _tax4506TotalYearlyJointIncome4; v221.Clean = value; _tax4506TotalYearlyJointIncome4 = v221;
                var v222 = _tax4506TotalYearlyVarianceIncome1; v222.Clean = value; _tax4506TotalYearlyVarianceIncome1 = v222;
                var v223 = _tax4506TotalYearlyVarianceIncome2; v223.Clean = value; _tax4506TotalYearlyVarianceIncome2 = v223;
                var v224 = _tax4506TotalYearlyVarianceIncome3; v224.Clean = value; _tax4506TotalYearlyVarianceIncome3 = v224;
                var v225 = _tax4506TotalYearlyVarianceIncome4; v225.Clean = value; _tax4506TotalYearlyVarianceIncome4 = v225;
                var v226 = _tax4506TotalYearlyVarianceJointIncome1; v226.Clean = value; _tax4506TotalYearlyVarianceJointIncome1 = v226;
                var v227 = _tax4506TotalYearlyVarianceJointIncome2; v227.Clean = value; _tax4506TotalYearlyVarianceJointIncome2 = v227;
                var v228 = _tax4506TotalYearlyVarianceJointIncome3; v228.Clean = value; _tax4506TotalYearlyVarianceJointIncome3 = v228;
                var v229 = _tax4506TotalYearlyVarianceJointIncome4; v229.Clean = value; _tax4506TotalYearlyVarianceJointIncome4 = v229;
                var v230 = _taxIdentificationIdentifier; v230.Clean = value; _taxIdentificationIdentifier = v230;
                var v231 = _totalLiabilitiesBalanceAmount; v231.Clean = value; _totalLiabilitiesBalanceAmount = v231;
                var v232 = _totalMonthlyIncomeAmount; v232.Clean = value; _totalMonthlyIncomeAmount = v232;
                var v233 = _totalMonthlyIncomeMinusNetRentalAmount; v233.Clean = value; _totalMonthlyIncomeMinusNetRentalAmount = v233;
                var v234 = _totalPresentHousingExpenseAmount; v234.Clean = value; _totalPresentHousingExpenseAmount = v234;
                var v235 = _transactionPurposeDescription; v235.Clean = value; _transactionPurposeDescription = v235;
                var v236 = _transUnion120Days; v236.Clean = value; _transUnion120Days = v236;
                var v237 = _transUnion150Days; v237.Clean = value; _transUnion150Days = v237;
                var v238 = _transUnion30Days; v238.Clean = value; _transUnion30Days = v238;
                var v239 = _transUnion60Days; v239.Clean = value; _transUnion60Days = v239;
                var v240 = _transUnion90Days; v240.Clean = value; _transUnion90Days = v240;
                var v241 = _transUnionCreditScoreForDisclosure; v241.Clean = value; _transUnionCreditScoreForDisclosure = v241;
                var v242 = _transUnionCreditScoreRanksPercent; v242.Clean = value; _transUnionCreditScoreRanksPercent = v242;
                var v243 = _transUnionDatePulled; v243.Clean = value; _transUnionDatePulled = v243;
                var v244 = _transUnionFactorCode1; v244.Clean = value; _transUnionFactorCode1 = v244;
                var v245 = _transUnionFactorCode2; v245.Clean = value; _transUnionFactorCode2 = v245;
                var v246 = _transUnionFactorCode3; v246.Clean = value; _transUnionFactorCode3 = v246;
                var v247 = _transUnionFactorCode4; v247.Clean = value; _transUnionFactorCode4 = v247;
                var v248 = _transUnionFactorCode5; v248.Clean = value; _transUnionFactorCode5 = v248;
                var v249 = _transUnionKeyFactor1; v249.Clean = value; _transUnionKeyFactor1 = v249;
                var v250 = _transUnionKeyFactor2; v250.Clean = value; _transUnionKeyFactor2 = v250;
                var v251 = _transUnionKeyFactor3; v251.Clean = value; _transUnionKeyFactor3 = v251;
                var v252 = _transUnionKeyFactor4; v252.Clean = value; _transUnionKeyFactor4 = v252;
                var v253 = _transUnionKeyFactor5; v253.Clean = value; _transUnionKeyFactor5 = v253;
                var v254 = _transUnionMaterialTermsCreditByScore; v254.Clean = value; _transUnionMaterialTermsCreditByScore = v254;
                var v255 = _transUnionScore; v255.Clean = value; _transUnionScore = v255;
                var v256 = _userDefinedIncome; v256.Clean = value; _userDefinedIncome = v256;
                var v257 = _vaFederalTaxAmount; v257.Clean = value; _vaFederalTaxAmount = v257;
                var v258 = _validDaysForConsentCount; v258.Clean = value; _validDaysForConsentCount = v258;
                var v259 = _vaNetTakeHomePayAmount; v259.Clean = value; _vaNetTakeHomePayAmount = v259;
                var v260 = _vaOtherAmount; v260.Clean = value; _vaOtherAmount = v260;
                var v261 = _vaOtherNetIncomeAmount; v261.Clean = value; _vaOtherNetIncomeAmount = v261;
                var v262 = _vaRetirementAmount; v262.Clean = value; _vaRetirementAmount = v262;
                var v263 = _vaStateTaxAmount; v263.Clean = value; _vaStateTaxAmount = v263;
                var v264 = _vaTotalIncomeDeductionsAmount; v264.Clean = value; _vaTotalIncomeDeductionsAmount = v264;
                var v265 = _vaTotalNetIncomeAmount; v265.Clean = value; _vaTotalNetIncomeAmount = v265;
                var v266 = _vendor1; v266.Clean = value; _vendor1 = v266;
                var v267 = _vendor10; v267.Clean = value; _vendor10 = v267;
                var v268 = _vendor11; v268.Clean = value; _vendor11 = v268;
                var v269 = _vendor12; v269.Clean = value; _vendor12 = v269;
                var v270 = _vendor2; v270.Clean = value; _vendor2 = v270;
                var v271 = _vendor3; v271.Clean = value; _vendor3 = v271;
                var v272 = _vendor4; v272.Clean = value; _vendor4 = v272;
                var v273 = _vendor5; v273.Clean = value; _vendor5 = v273;
                var v274 = _vendor6; v274.Clean = value; _vendor6 = v274;
                var v275 = _vendor7; v275.Clean = value; _vendor7 = v275;
                var v276 = _vendor8; v276.Clean = value; _vendor8 = v276;
                var v277 = _vendor9; v277.Clean = value; _vendor9 = v277;
                var v278 = _vestingTrusteeOfType; v278.Clean = value; _vestingTrusteeOfType = v278;
                var v279 = _veteranIndicator; v279.Clean = value; _veteranIndicator = v279;
                var v280 = _workEmailAddress; v280.Clean = value; _workEmailAddress = v280;
                var v281 = _yearsofCreditOnFile; v281.Clean = value; _yearsofCreditOnFile = v281;
                if (Application != null) Application.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Borrower()
        {
            Clean = true;
        }
    }
}