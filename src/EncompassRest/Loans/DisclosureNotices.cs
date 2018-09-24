using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureNotices
    /// </summary>
    public sealed partial class DisclosureNotices : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _antiCoercionStatementIndicator;
        private DirtyValue<string> _commitmentIssuedByAddress;
        private DirtyValue<string> _commitmentIssuedByCity;
        private DirtyValue<string> _commitmentIssuedByContactName;
        private DirtyValue<string> _commitmentIssuedByName;
        private DirtyValue<string> _commitmentIssuedByPhone;
        private DirtyValue<string> _commitmentIssuedByPostalCode;
        private DirtyValue<StringEnumValue<State>> _commitmentIssuedByState;
        private DirtyValue<StringEnumValue<YOrN>> _consumerHandbookOnAdjustableRateMortgages;
        private DirtyValue<string> _daysToReceiveWrittenRequest;
        private DirtyValue<int?> _daysToReturnToLender;
        private DirtyValue<string> _discloseNonPublicPersonalInformation;
        private DirtyValue<string> _ecoaAddress;
        private DirtyValue<string> _ecoaAddress2;
        private DirtyValue<string> _ecoaCity;
        private DirtyValue<string> _ecoaName;
        private DirtyValue<string> _ecoaPhone;
        private DirtyValue<string> _ecoaPostalCode;
        private DirtyValue<StringEnumValue<State>> _ecoaState;
        private DirtyValue<string> _fairLendingNoticeDescription1;
        private DirtyValue<string> _fairLendingNoticeDescription2;
        private DirtyValue<string> _fairLendingNoticeDescription3;
        private DirtyValue<string> _fairLendingNoticeDescription4;
        private DirtyValue<string> _fairLendingNoticeDescription5;
        private DirtyValue<string> _fairLendingNoticeDescription6;
        private DirtyValue<string> _fairLendingNoticeDescription7;
        private DirtyValue<string> _fairLendingNoticeDescription8;
        private DirtyValue<string> _femaCommunityName;
        private DirtyValue<bool?> _floodInsuranceNotificationIndicator;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _informationDisclosureAuthorizationIndicator;
        private DirtyValue<string> _licensedMortgageBrokerUnder;
        private DirtyValue<bool?> _locatedInNfipIndicator;
        private DirtyValue<string> _lossPayeeClause;
        private DirtyValue<string> _mapPanelNumber;
        private DirtyValue<string> _nFIPCommunityNumber;
        private DirtyValue<DateTime?> _nFIPMapEffectiveRevisedDate;
        private DirtyValue<string> _nFIPParticipationStatus;
        private DirtyValue<string> _nonFinancialCompaniesDescription1;
        private DirtyValue<string> _nonFinancialCompaniesDescription2;
        private DirtyValue<string> _nonFinancialCompaniesDescription3;
        private DirtyValue<string> _nonFinancialCompaniesDescription4;
        private DirtyValue<bool?> _notLocatedInNfipIndicator;
        private DirtyValue<bool?> _occupancyStatementIndicator;
        private DirtyValue<string> _optOut;
        private DirtyValue<string> _optOutPhone;
        private DirtyValue<bool?> _releaseBankingInformationIndicator;
        private DirtyValue<bool?> _releaseEmploymentInformationIndicator;
        private DirtyValue<bool?> _releaseInformationInConnectionWithCreditReportIndicator;
        private DirtyValue<bool?> _releaseMortgageInformationIndicator;
        private DirtyValue<bool?> _rightToFinancialPrivacyActIndicator;

        /// <summary>
        /// Disclosure Anti-Coerc Stmnt [NOTICES.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Anti-Coerc Stmnt", OptionsJson = "{\"true\":\"Anti-Coercion Statement\"}")]
        public bool? AntiCoercionStatementIndicator { get => _antiCoercionStatementIndicator; set => SetField(ref _antiCoercionStatementIndicator, value); }

        /// <summary>
        /// Disclosure Commit Issued By Addr [NOTICES.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Addr")]
        public string CommitmentIssuedByAddress { get => _commitmentIssuedByAddress; set => SetField(ref _commitmentIssuedByAddress, value); }

        /// <summary>
        /// Disclosure Commit Issued By City [NOTICES.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By City")]
        public string CommitmentIssuedByCity { get => _commitmentIssuedByCity; set => SetField(ref _commitmentIssuedByCity, value); }

        /// <summary>
        /// Disclosure Commit Issued By Contact Name [NOTICES.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Contact Name")]
        public string CommitmentIssuedByContactName { get => _commitmentIssuedByContactName; set => SetField(ref _commitmentIssuedByContactName, value); }

        /// <summary>
        /// Disclosure Commit Issued By Company [NOTICES.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Company")]
        public string CommitmentIssuedByName { get => _commitmentIssuedByName; set => SetField(ref _commitmentIssuedByName, value); }

        /// <summary>
        /// Disclosure Commit Issued By Phone [NOTICES.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Commit Issued By Phone")]
        public string CommitmentIssuedByPhone { get => _commitmentIssuedByPhone; set => SetField(ref _commitmentIssuedByPhone, value); }

        /// <summary>
        /// Disclosure Commit Issued By Zip [NOTICES.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Commit Issued By Zip")]
        public string CommitmentIssuedByPostalCode { get => _commitmentIssuedByPostalCode; set => SetField(ref _commitmentIssuedByPostalCode, value); }

        /// <summary>
        /// Disclosure Commit Issued By State [NOTICES.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By State")]
        public StringEnumValue<State> CommitmentIssuedByState { get => _commitmentIssuedByState; set => SetField(ref _commitmentIssuedByState, value); }

        /// <summary>
        /// Disclosure Consumer/ARM Handbook [NOTICES.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Consumer/ARM Handbook", OptionsJson = "{\"Y\":\"Consumer Handbook on Adjustable Rate Mortgages\",\"N\":\"\"}")]
        public StringEnumValue<YOrN> ConsumerHandbookOnAdjustableRateMortgages { get => _consumerHandbookOnAdjustableRateMortgages; set => SetField(ref _consumerHandbookOnAdjustableRateMortgages, value); }

        /// <summary>
        /// Disclosure Appraisal Notice Days [NOTICES.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Appraisal Notice Days")]
        public string DaysToReceiveWrittenRequest { get => _daysToReceiveWrittenRequest; set => SetField(ref _daysToReceiveWrittenRequest, value); }

        /// <summary>
        /// Disclosure Days to Return Lenders Copy [NOTICES.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Days to Return Lenders Copy")]
        public int? DaysToReturnToLender { get => _daysToReturnToLender; set => SetField(ref _daysToReturnToLender, value); }

        /// <summary>
        /// Disclosure Privacy Policy Options 1 [NOTICES.X38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Privacy Policy Options 1")]
        public string DiscloseNonPublicPersonalInformation { get => _discloseNonPublicPersonalInformation; set => SetField(ref _discloseNonPublicPersonalInformation, value); }

        /// <summary>
        /// Disclosure ECOA Addr [NOTICES.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Addr")]
        public string EcoaAddress { get => _ecoaAddress; set => SetField(ref _ecoaAddress, value); }

        /// <summary>
        /// Disclosure ECOA Addr 2 [NOTICES.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Addr 2")]
        public string EcoaAddress2 { get => _ecoaAddress2; set => SetField(ref _ecoaAddress2, value); }

        /// <summary>
        /// Disclosure ECOA City [NOTICES.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA City")]
        public string EcoaCity { get => _ecoaCity; set => SetField(ref _ecoaCity, value); }

        /// <summary>
        /// Disclosure ECOA Name [NOTICES.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Name")]
        public string EcoaName { get => _ecoaName; set => SetField(ref _ecoaName, value); }

        /// <summary>
        /// Disclosure ECOA Phone [NOTICES.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure ECOA Phone")]
        public string EcoaPhone { get => _ecoaPhone; set => SetField(ref _ecoaPhone, value); }

        /// <summary>
        /// Disclosure ECOA Zip [NOTICES.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure ECOA Zip")]
        public string EcoaPostalCode { get => _ecoaPostalCode; set => SetField(ref _ecoaPostalCode, value); }

        /// <summary>
        /// Disclosure ECOA State [NOTICES.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA State")]
        public StringEnumValue<State> EcoaState { get => _ecoaState; set => SetField(ref _ecoaState, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 1 [NOTICES.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 1")]
        public string FairLendingNoticeDescription1 { get => _fairLendingNoticeDescription1; set => SetField(ref _fairLendingNoticeDescription1, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 2 [NOTICES.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 2")]
        public string FairLendingNoticeDescription2 { get => _fairLendingNoticeDescription2; set => SetField(ref _fairLendingNoticeDescription2, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 3 [NOTICES.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 3")]
        public string FairLendingNoticeDescription3 { get => _fairLendingNoticeDescription3; set => SetField(ref _fairLendingNoticeDescription3, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 4 [NOTICES.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 4")]
        public string FairLendingNoticeDescription4 { get => _fairLendingNoticeDescription4; set => SetField(ref _fairLendingNoticeDescription4, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 5 [NOTICES.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 5")]
        public string FairLendingNoticeDescription5 { get => _fairLendingNoticeDescription5; set => SetField(ref _fairLendingNoticeDescription5, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 6 [NOTICES.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 6")]
        public string FairLendingNoticeDescription6 { get => _fairLendingNoticeDescription6; set => SetField(ref _fairLendingNoticeDescription6, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 7 [NOTICES.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 7")]
        public string FairLendingNoticeDescription7 { get => _fairLendingNoticeDescription7; set => SetField(ref _fairLendingNoticeDescription7, value); }

        /// <summary>
        /// Disclosure Fair Lending Contact 8 [NOTICES.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 8")]
        public string FairLendingNoticeDescription8 { get => _fairLendingNoticeDescription8; set => SetField(ref _fairLendingNoticeDescription8, value); }

        /// <summary>
        /// Disclosure Community Name for FEMA [NOTICES.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Community Name for FEMA")]
        public string FemaCommunityName { get => _femaCommunityName; set => SetField(ref _femaCommunityName, value); }

        /// <summary>
        /// Disclosure Flood Ins Notif [NOTICES.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Flood Ins Notif", OptionsJson = "{\"true\":\"Flood Insurance Notification\"}")]
        public bool? FloodInsuranceNotificationIndicator { get => _floodInsuranceNotificationIndicator; set => SetField(ref _floodInsuranceNotificationIndicator, value); }

        /// <summary>
        /// DisclosureNotices Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Disclosure Info Discl Auth [NOTICES.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Info Discl Auth", OptionsJson = "{\"true\":\"Information Disclosure Authorization\"}")]
        public bool? InformationDisclosureAuthorizationIndicator { get => _informationDisclosureAuthorizationIndicator; set => SetField(ref _informationDisclosureAuthorizationIndicator, value); }

        /// <summary>
        /// Disclosure Mtg Broker License Auth [NOTICES.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Mtg Broker License Auth")]
        public string LicensedMortgageBrokerUnder { get => _licensedMortgageBrokerUnder; set => SetField(ref _licensedMortgageBrokerUnder, value); }

        /// <summary>
        /// Property Community participates in NFIP [NOTICES.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Property Community participates in NFIP", OptionsJson = "{\"true\":\"Community in which the property is located participates in the National Flood Insurance program (NFIP). Federal law will not allow us to make the loan that you have applied for if you do not purchase flood insurance.\"}")]
        public bool? LocatedInNfipIndicator { get => _locatedInNfipIndicator; set => SetField(ref _locatedInNfipIndicator, value); }

        /// <summary>
        /// Disclosure Flood Ins Clause [NOTICES.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Flood Ins Clause")]
        public string LossPayeeClause { get => _lossPayeeClause; set => SetField(ref _lossPayeeClause, value); }

        /// <summary>
        /// Disclosure Map Panel Number [NOTICES.X97]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Map Panel Number")]
        public string MapPanelNumber { get => _mapPanelNumber; set => SetField(ref _mapPanelNumber, value); }

        /// <summary>
        /// Disclosure NFIP Community Number [NOTICES.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Community Number")]
        public string NFIPCommunityNumber { get => _nFIPCommunityNumber; set => SetField(ref _nFIPCommunityNumber, value); }

        /// <summary>
        /// Disclosure NFIP Map Panel Effective/Revised Date [NOTICES.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Map Panel Effective/Revised Date")]
        public DateTime? NFIPMapEffectiveRevisedDate { get => _nFIPMapEffectiveRevisedDate; set => SetField(ref _nFIPMapEffectiveRevisedDate, value); }

        /// <summary>
        /// Disclosure NFIP Participation Status Type [NOTICES.X100]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Participation Status Type")]
        public string NFIPParticipationStatus { get => _nFIPParticipationStatus; set => SetField(ref _nFIPParticipationStatus, value); }

        /// <summary>
        /// Disclosure Non-Finance Company 1 Desc [NOTICES.X40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 1 Desc")]
        public string NonFinancialCompaniesDescription1 { get => _nonFinancialCompaniesDescription1; set => SetField(ref _nonFinancialCompaniesDescription1, value); }

        /// <summary>
        /// Disclosure Non-Finance Company 2 Desc [NOTICES.X41]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 2 Desc")]
        public string NonFinancialCompaniesDescription2 { get => _nonFinancialCompaniesDescription2; set => SetField(ref _nonFinancialCompaniesDescription2, value); }

        /// <summary>
        /// Disclosure Non-Finance Company 3 Desc [NOTICES.X42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 3 Desc")]
        public string NonFinancialCompaniesDescription3 { get => _nonFinancialCompaniesDescription3; set => SetField(ref _nonFinancialCompaniesDescription3, value); }

        /// <summary>
        /// Disclosure Non-Finance Company 4 Desc [NOTICES.X43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 4 Desc")]
        public string NonFinancialCompaniesDescription4 { get => _nonFinancialCompaniesDescription4; set => SetField(ref _nonFinancialCompaniesDescription4, value); }

        /// <summary>
        /// Property Community does not participates in NFIP [NOTICES.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Property Community does not participates in NFIP", OptionsJson = "{\"true\":\"Flood insurance coverage is not available for the property securing the loan because the community in which the property is located does not participate in NFIP.\"}")]
        public bool? NotLocatedInNfipIndicator { get => _notLocatedInNfipIndicator; set => SetField(ref _notLocatedInNfipIndicator, value); }

        /// <summary>
        /// Disclosure Occupancy Stmnt [NOTICES.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Occupancy Stmnt", OptionsJson = "{\"true\":\"Occupancy Statement\"}")]
        public bool? OccupancyStatementIndicator { get => _occupancyStatementIndicator; set => SetField(ref _occupancyStatementIndicator, value); }

        /// <summary>
        /// Disclosure Privacy Policy Options 2 [NOTICES.X45]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Privacy Policy Options 2")]
        public string OptOut { get => _optOut; set => SetField(ref _optOut, value); }

        /// <summary>
        /// Disclosure Opt-Out Phone Number [NOTICES.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Disclosure Opt-Out Phone Number")]
        public string OptOutPhone { get => _optOutPhone; set => SetField(ref _optOutPhone, value); }

        /// <summary>
        /// Disclosure Auth Bank Acct Verif [NOTICES.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Bank Acct Verif", OptionsJson = "{\"true\":\"Banking (checking & savings) account of record\"}")]
        public bool? ReleaseBankingInformationIndicator { get => _releaseBankingInformationIndicator; set => SetField(ref _releaseBankingInformationIndicator, value); }

        /// <summary>
        /// Disclosure Auth Empl Hist Verif [NOTICES.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Empl Hist Verif", OptionsJson = "{\"true\":\"Employment History, dates, title(s), income, hours worked, etc.\"}")]
        public bool? ReleaseEmploymentInformationIndicator { get => _releaseEmploymentInformationIndicator; set => SetField(ref _releaseEmploymentInformationIndicator, value); }

        /// <summary>
        /// Disclosure Auth Any Info Necessary [NOTICES.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Any Info Necessary", OptionsJson = "{\"true\":\"Any information deemed necessary in connection with consumer credit report for real estate transaction\"}")]
        public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get => _releaseInformationInConnectionWithCreditReportIndicator; set => SetField(ref _releaseInformationInConnectionWithCreditReportIndicator, value); }

        /// <summary>
        /// Disclosure Auth Loan Rating Verif [NOTICES.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Loan Rating Verif", OptionsJson = "{\"true\":\"Mortgage loan rating, (opening date, high credit, payment amount, loan balance and payment)\"}")]
        public bool? ReleaseMortgageInformationIndicator { get => _releaseMortgageInformationIndicator; set => SetField(ref _releaseMortgageInformationIndicator, value); }

        /// <summary>
        /// Disclosure Right to Privacy Act [NOTICES.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Right to Privacy Act", OptionsJson = "{\"true\":\"Right to Financial Privacy Act\"}")]
        public bool? RightToFinancialPrivacyActIndicator { get => _rightToFinancialPrivacyActIndicator; set => SetField(ref _rightToFinancialPrivacyActIndicator, value); }
    }
}