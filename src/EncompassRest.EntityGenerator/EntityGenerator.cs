﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Elli.Api.Loans.Model;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;
using EncompassRest.Tests;
using EnumsNET;
using EnumsNET.NonGeneric;
using Newtonsoft.Json;

namespace EncompassRest
{
    public static class EntityGenerator
    {
        static EntityGenerator()
        {
            var sharedEnumTypes = new[]
            {
                typeof(YOrN),
                typeof(YNOrNA),
                typeof(YesOrNo),
                typeof(YesNoOrNA),
                typeof(TrueOrFalse),
                typeof(AcceptOrReject),
                typeof(IncreasedOrDecreased),
                typeof(UtilitiesDescription),
                typeof(TermType),
                typeof(SignedByTyp),
                typeof(TotalClosingCostRemark),
                typeof(PartyType),
                typeof(AUS),
                typeof(AUSRecommendation),
                typeof(BankruptcyForeclosureStatus),
                typeof(LicenseAuthType),
                typeof(BorContingentLiabilitiesLiabilityDescription),
                typeof(BorrowerType),
                typeof(ClosingCostFundsType),
                typeof(FundsTypeDescription),
                typeof(ClosingCostSourceType),
                typeof(SourceTypeDescription),
                typeof(DocsLoanProgramType),
                typeof(ServicingType),
                typeof(CorrespondentOptionDesc),
                typeof(CreditChargeType),
                typeof(DenialReason),
                typeof(DisclosureMethod),
                typeof(DownPaymentSourceType),
                typeof(YNOrOther),
                typeof(Hud1EsPayToFeeType),
                typeof(RefundableType),
                typeof(RecSamePtyTypeDesc),
                typeof(FeddieBorrowerAlienStatus),
                typeof(FreddieDownPaymentType),
                typeof(FullPrepaymentPenaltyOptionType),
                typeof(ATRQMStatus),
                typeof(ImpoundType),
                typeof(ClosingCostImpoundType),
                typeof(ImpoundWaived),
                typeof(IncludeOriginationPointsCreditType),
                typeof(InformationTypesWeCollect),
                typeof(ProjectType),
                typeof(MonthOrYear),
                typeof(CanGoOrGoes),
                typeof(OrgTyp),
                typeof(IsOrIsNot),
                typeof(LimitSharing),
                typeof(ScsrsClaus),
                typeof(CanIncreaseOrIncreases),
                typeof(LoanAmountType),
                typeof(LoanDocumentationType),
                typeof(LoanPurposeType),
                typeof(LoanType),
                typeof(RefinancePurpose),
                typeof(PropertyType),
                typeof(LienType),
                typeof(DoesOrDoesNot),
                typeof(DoesOrDoesNot2),
                typeof(OpenBankruptcy),
                typeof(InterestRateImpactedStatus),
                typeof(StateDisclosureFeePaidBy),
                typeof(Owner),
                typeof(PaidBy),
                typeof(PaidType),
                typeof(PenaltyTerm),
                typeof(OccupancyIntent),
                typeof(PrepaymentPenaltyBasedOn),
                typeof(PropertyUsageType),
                typeof(PTB),
                typeof(DaysInYear),
                typeof(TypeOfPurchaser),
                typeof(RiskClassification),
                typeof(RoundingMethod),
                typeof(SignatureType),
                typeof(FinalSignatureType),
                typeof(SofDBorrowerAddressType),
                typeof(TimesToCollect),
                typeof(TrstSamePtyTypDesc),
                typeof(ProfitManagementItemType),
                typeof(UCDPayoffType),
                typeof(UlddBorrowerType),
                typeof(VestingTrusteeOfType),
                typeof(WholePocPaidByType),
                typeof(AmortizationType),
                typeof(ApplicationTakenMethodType),
                typeof(OtherPropertyType),
                typeof(RiskAssessmentType),
                typeof(ActionTaken),
                typeof(IndexMargin),
                typeof(PropertyFormType),
                typeof(Conversion),
                typeof(HmdaLoanPurpose),
                typeof(PaidToOrBy),
                typeof(BorrowerOrCoBorrower),
                typeof(State),
                typeof(NonVolAdjustmentType),
                typeof(HudLoanDataResidencyType)
            };
            s_sharedEnums = new Dictionary<string, HashSet<string>>();
            foreach (var sharedEnumType in sharedEnumTypes)
            {
                s_sharedEnums.Add(sharedEnumType.Name, new HashSet<string>(NonGenericEnums.GetMembers(sharedEnumType).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))));
            }
        }

        private static readonly Dictionary<string, HashSet<string>> s_sharedEnums;

        private static readonly HashSet<string> s_enumPropertyNamesToUseNotExactSharedEnum = new HashSet<string>
        {
            "AUS2",
            "AUS3",
            "AUS4",
            "AUS5",
            "AUSRecommendation2",
            "AUSRecommendation3",
            "AUSRecommendation4",
            "AUSRecommendation5",
            "DenialReason2",
            "DenialReason3",
            "DenialReason4"
        };

        private static readonly HashSet<string> s_enumPropertyNamesToUseEntityTypeInName = new HashSet<string>
        {
            "PurposeOfLoan",
            "LoanType",
            "PropertyType",
            "FeeType",
            "RiskClass",
            "LoanPurpose",
            "BorrowerType",
            "MortgageOriginator",
            "AppraisalType"
        };

        private static readonly Dictionary<string, string> s_explicitStringEnumValues = new Dictionary<string, string> { { "LoanAssociate.LoanAssociateType", nameof(LoanAssociateType) }, { "AdditionalStateDisclosure.StateCode", nameof(State) } };

        private static readonly HashSet<string> s_stringDictionaryProperties = new HashSet<string> { "Loan.VirtualFields", "DocumentOrderLog.DocumentFields", "ElliUCDDetail.CDFields", "ElliUCDDetail.LEFields" };

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Contact.Contact", "Loan.CurrentApplication", "Borrower.Application" };

        private static readonly HashSet<string> s_propertiesWithInternalFields = new HashSet<string> { "CustomField.DateValue", "CustomField.NumericValue", "CustomField.StringValue", "FieldLockData.ModelPath" };

        private static readonly Dictionary<string, EntitySchema> s_explicitSchemas = new Dictionary<string, EntitySchema>
        {
            { "ElliUCDDetail", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "CDFields", new PropertySchema { Type = PropertySchemaType.String } }, { "LEFields", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "DocumentAudit", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "ReportKey", new PropertySchema { Type = PropertySchemaType.String } }, { "TimeStamp", new PropertySchema { Type = PropertySchemaType.DateTime } }, { "Alerts", new PropertySchema { Type = PropertySchemaType.List, ElementType = "DocumentAuditAlert" } } } } },
            { "DocumentAuditAlert", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Source", new PropertySchema { Type = PropertySchemaType.String } }, { "Type", new PropertySchema { Type = PropertySchemaType.String } }, { "Text", new PropertySchema { Type = PropertySchemaType.String } }, { "Fields", new PropertySchema { Type = PropertySchemaType.List, ElementType = "string" } } } } },
            { "EmailDocument", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "DocId", new PropertySchema { Type = PropertySchemaType.String } }, { "DocTitle", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "OrderedDocument", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "Title", new PropertySchema { Type = PropertySchemaType.String } }, { "Type", new PropertySchema { Type = PropertySchemaType.String } }, { "Category", new PropertySchema { Type = PropertySchemaType.String } }, { "SignatureType", new PropertySchema { Type = PropertySchemaType.String } }, { "PairId", new PropertySchema { Type = PropertySchemaType.String } }, { "DataKey", new PropertySchema { Type = PropertySchemaType.String } }, { "Size", new PropertySchema { Type = PropertySchemaType.Int } }, { "TemplateId", new PropertySchema { Type = PropertySchemaType.String } }, { "DocumentServiceId", new PropertySchema { Type = PropertySchemaType.String } }, { "OverflowDataKey", new PropertySchema { Type = PropertySchemaType.String } }, { "Overflows", new PropertySchema { Type = PropertySchemaType.List, ElementType = "OrderedDocumentOverflow" } } } } },
            { "OrderedDocumentOverflow", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "CoordinateBottom", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateTop", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateLeft", new PropertySchema { Type = PropertySchemaType.String } }, { "CoordinateRight", new PropertySchema { Type = PropertySchemaType.String } }, { "OriginalText", new PropertySchema { Type = PropertySchemaType.String } }, { "PageNumber", new PropertySchema { Type = PropertySchemaType.Int } }, { "TemplateFieldName", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "AlertChangeCircumstance", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "AlertTriggerFieldID", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceDate", new PropertySchema { Type = PropertySchemaType.Date } }, { "RevisedDueDate", new PropertySchema { Type = PropertySchemaType.Date } }, { "ChangedCircumstanceDescription", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceComments", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceReason", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceReasonOther", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceCategory", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceAlertFeeDescription", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceAlertInitialAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "ChangedCircumstanceAlertBaseline", new PropertySchema { Type = PropertySchemaType.String } }, { "ChangedCircumstanceAlertDisclosedAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "ChangedCircumstanceAlertItemizationAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "ChangedCircumstanceAlertVarianceAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "AltId", new PropertySchema { Type = PropertySchemaType.String } } } } }
        };

        private static readonly Dictionary<string, Dictionary<string, PropertySchema>> s_explicitPropertySchemas = new Dictionary<string, Dictionary<string, PropertySchema>>
        {
            { "NonVol", new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "NonVolIndex", new PropertySchema { Type = PropertySchemaType.Int } }, { "NonVolId", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "CrmLog", new Dictionary<string, PropertySchema> { { "Alerts", new PropertySchema { Type = PropertySchemaType.List, ElementType = LoanEntity.LogAlert } }, { "CommentList", new PropertySchema { Type = PropertySchemaType.List, ElementType = LoanEntity.LogComment } }, { "Comments", new PropertySchema { Type = PropertySchemaType.String } }, { "DateUtc", new PropertySchema { Type = PropertySchemaType.DateTime } }, { "FileAttachmentsMigrated", new PropertySchema { Type = PropertySchemaType.Bool } }, { "Guid", new PropertySchema { Type = PropertySchemaType.String } }, { "IsSystemSpecificIndicator", new PropertySchema { Type = PropertySchemaType.Bool } }, { "LogRecordIndex", new PropertySchema { Type = PropertySchemaType.Int } } } },
            { "DocumentOrderLog", new Dictionary<string, PropertySchema> { { "OrderedDocuments", new PropertySchema { Type = PropertySchemaType.List, ElementType = "OrderedDocument" } } } },
            { "FundingFee", new Dictionary<string, PropertySchema> { { "Amount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PtcAmount", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocBorrower2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocSeller2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocBroker2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocOther2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacBroker2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacLender2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PacOther2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, { "PocLender2015", new PropertySchema { Type = PropertySchemaType.Decimal } }, } },
            { "HtmlEmailLog", new Dictionary<string, PropertySchema> { { "DocList", new PropertySchema { Type = PropertySchemaType.List, ElementType = "EmailDocument" } } } },
            { "ClosingDisclosure4", new Dictionary<string, PropertySchema> { { "EscrowedPropertyCostsBasis", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "ClosingEntity", new Dictionary<string, PropertySchema> { { "NBORecordID", new PropertySchema { Type = PropertySchemaType.String } }, { "TrusteeIndex", new PropertySchema { Type = PropertySchemaType.Int } } } },
            { "RateLock", new Dictionary<string, PropertySchema> { { "RequestProgramNotes", new PropertySchema { Type = PropertySchemaType.String } }, { "BorrLenderPaid", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "NonBorrowingOwner", new Dictionary<string, PropertySchema> { { "Id", new PropertySchema { Type = PropertySchemaType.String } }, { "ESignConsentNBOCStatus", new PropertySchema { Type = PropertySchemaType.String } }, { "ESignConsentNBOCDateAccepted", new PropertySchema { Type = PropertySchemaType.Date } }, { "ESignConsentNBOCIPAddress", new PropertySchema { Type = PropertySchemaType.String } }, { "ESignConsentNBOCSource", new PropertySchema { Type = PropertySchemaType.String } }, { "ESignConsentNBOCDateSent", new PropertySchema { Type = PropertySchemaType.Date } }, { "BorrowerVestingRecordID", new PropertySchema { Type = PropertySchemaType.String } }, { "EntityDeleted", new PropertySchema { Type = PropertySchemaType.Bool } }, { "NBOID", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "TPO", new Dictionary<string, PropertySchema> { { "LEIssuedBy", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "Usda", new Dictionary<string, PropertySchema> { { "RefinanceType", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "Loan", new Dictionary<string, PropertySchema> { { "AlertChangeCircumstances", new PropertySchema { Type = PropertySchemaType.List, ElementType = "AlertChangeCircumstance" } }, { "AlertChangeCircumstanceApplyLECD", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "DisclosureTracking2015Log", new Dictionary<string, PropertySchema> { { "CureAppliedToLenderCredit", new PropertySchema { Type = PropertySchemaType.String } }, { "CureAppliedToPrincipalReduction", new PropertySchema { Type = PropertySchemaType.String } } } },
            { "LoanAssociate", new Dictionary<string, PropertySchema> { { "EnableWriteAccess", new PropertySchema { Type = PropertySchemaType.String, AllowedValues = new List<FieldOption> { new FieldOption("Y", "Yes"), new FieldOption("N", "No") } } } } }
        };

        private static readonly Dictionary<string, HashSet<string>> s_enumOptionsToIgnore = new Dictionary<string, HashSet<string>>
        {
            { "LoanDocumentationType", new HashSet<string> { "NoIncomeon1003" } }
        };

        private static readonly HashSet<string> s_ignoredEntities = new HashSet<string> { "NonBorrowingOwnerContract" };

        private static readonly string s_encompassSDKFolder = Path.Combine(Directory.EnumerateDirectories("C:\\SmartClientCache\\Apps\\UAC\\Ellie Mae\\").First(), "Encompass360");

        public static Task Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            return RunAsync(args);
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args) => Assembly.LoadFrom(Path.Combine(s_encompassSDKFolder, $"{args.Name.Substring(0, args.Name.IndexOf(","))}.dll"));

        public static async Task RunAsync(string[] args)
        {
            try
            {
                Dictionary<string, EntitySchema> entityTypes;
                using (var client = await TestBaseClass.GetTestClientAsync().ConfigureAwait(false))
                {
                    entityTypes = (await client.Schema.GetLoanSchemaAsync(true).ConfigureAwait(false)).EntityTypes;
                }
                foreach (var pair in s_explicitSchemas)
                {
                    var entityName = pair.Key;
                    if (entityTypes.ContainsKey(entityName))
                    {
                        Console.WriteLine($"Can now retrieve schema for {entityName}");
                    }
                    else
                    {
                        entityTypes.Add(entityName, pair.Value);
                    }
                }

                foreach (var pair in s_explicitPropertySchemas)
                {
                    var entityName = pair.Key;
                    var properties = entityTypes[entityName].Properties;
                    foreach (var p in pair.Value)
                    {
                        var propertyName = p.Key;
                        if (properties.ContainsKey(propertyName))
                        {
                            Console.WriteLine($"Can now retrieve schema property {entityName}.{propertyName}");
                        }
                        else
                        {
                            properties.Add(propertyName, p.Value);
                        }
                    }
                }

                var destinationPath = "Loans";
                var @namespace = "EncompassRest.Loans";
                Directory.CreateDirectory(destinationPath);

                var loanEntitySchema = entityTypes["Loan"];
                var fields = new Dictionary<string, LoanFieldDescriptors.StandardFieldInfo>(StringComparer.OrdinalIgnoreCase);
                var fieldPatterns = new Dictionary<string, LoanFieldDescriptors.StandardFieldInfo>(StringComparer.OrdinalIgnoreCase)
                {
                    { "CX.{0}", new LoanFieldDescriptors.StandardFieldInfo { FieldId = "CX.{0}", ModelPath = "Loan.CustomFields[(FieldName == 'CX.{0}')].StringValue" } },
                    { "CUST{0:00}FV", new LoanFieldDescriptors.StandardFieldInfo { FieldId = "CUST{0:00}FV", ModelPath = "Loan.CustomFields[(FieldName == 'CUST{0:00}FV')].StringValue" } }
                };

                var otherEnums = new Dictionary<string, Dictionary<string, string>>();

                PopulateFieldMappings(destinationPath, @namespace, "Loan", "Loan", typeof(LoanContract), loanEntitySchema, null, entityTypes, fields, fieldPatterns, otherEnums);

                entityTypes.Remove("Loan");

                foreach (var pair in entityTypes)
                {
                    var entityName = pair.Key;
                    if (!s_ignoredEntities.Contains(entityName))
                    {
                        Console.WriteLine($"{entityName} is not connected to the Loan schema");
                        GenerateClassFileFromSchema(destinationPath, @namespace, entityName, null, pair.Value, otherEnums, null, false);
                    }
                }

                var orderedFields = fields.Values.OrderBy(p => p.ModelPath.Substring(0, p.ModelPath.LastIndexOfAny(new[] { '.', '[' }))).ThenBy(p => p.ModelPath).ToList();

                var orderedFieldPatterns = fieldPatterns.Values.OrderBy(p => p.ModelPath.Substring(0, p.ModelPath.LastIndexOf('.'))).ThenBy(p => p.ModelPath).ToList();

                using (var fs = new FileStream("LoanFields.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedFields);
                    }
                }

                using (var fs = new FileStream("LoanFieldPatterns.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedFieldPatterns);
                    }
                }

                var virtualFields = new List<LoanFieldDescriptors.VirtualFieldInfo>();
                var virtualFieldPatterns = new List<LoanFieldDescriptors.VirtualFieldInfo>();
                foreach (var virtualField in EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.VirtualFields.Cast<EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptor>())
                {
                    var virtualFieldInfo = new LoanFieldDescriptors.VirtualFieldInfo { Format = (LoanFieldFormat)virtualField.Format };
                    if (virtualField.Options.Count > 0)
                    {
                        virtualFieldInfo.Options = new List<FieldOption>();
                        foreach (var option in virtualField.Options.Cast<EllieMae.Encompass.BusinessObjects.Loans.FieldOption>())
                        {
                            virtualFieldInfo.Options.Add(new FieldOption(option.Value, option.Text));
                        }
                    }
                    if (virtualField.MultiInstance)
                    {
                        virtualFieldInfo.FieldId = $"{virtualField.FieldID}.{{0}}";
                        var instanceField = virtualField.GetInstanceDescriptor(virtualField.InstanceSpecifierType == EllieMae.Encompass.BusinessObjects.Loans.MultiInstanceSpecifierType.Index ? (object)1 : "1");
                        var instanceFieldId = instanceField.FieldID;
                        var instanceFieldId2 = string.Format(virtualFieldInfo.FieldId, 1);
                        if (instanceFieldId != instanceFieldId2)
                        {
                            Console.WriteLine($"{instanceFieldId} != {instanceFieldId2}");
                        }
                        var description = instanceField.Description;
                        description = description.Replace(" - 1", " - {0}");
                        virtualFieldInfo.Description = description;
                        virtualFieldPatterns.Add(virtualFieldInfo);
                    }
                    else
                    {
                        virtualFieldInfo.FieldId = virtualField.FieldID;
                        virtualFieldInfo.Description = virtualField.Description;
                        virtualFields.Add(virtualFieldInfo);
                    }
                }

                var orderedVirtualFields = virtualFields.OrderBy(v => v.FieldId).ToList();
                var orderedVirtualFieldPatterns = virtualFieldPatterns.OrderBy(v => v.FieldId).ToList();

                using (var fs = new FileStream("VirtualFields.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedVirtualFields);
                    }
                }

                using (var fs = new FileStream("VirtualFieldPatterns.json", FileMode.Create))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, orderedVirtualFieldPatterns);
                    }
                }

                using (var fs = new FileStream("LoanFields.zip", FileMode.Create))
                {
                    using (var zip = new ZipArchive(fs, ZipArchiveMode.Create))
                    {
                        var serializer = JsonSerializer.Create();

                        var loanFieldsEntry = zip.CreateEntry("LoanFields.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(loanFieldsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedFields);
                        }

                        var loanFieldPatternsEntry = zip.CreateEntry("LoanFieldPatterns.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(loanFieldPatternsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedFieldPatterns);
                        }

                        var virtualFieldsEntry = zip.CreateEntry("VirtualFields.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(virtualFieldsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedVirtualFields);
                        }

                        var virtualFieldPatternsEntry = zip.CreateEntry("VirtualFieldPatterns.json", CompressionLevel.Optimal);
                        using (var sw = new StreamWriter(virtualFieldPatternsEntry.Open()))
                        {
                            serializer.Serialize(sw, orderedVirtualFieldPatterns);
                        }
                    }
                }

                var otherEnumsAsHashSet = otherEnums.ToDictionary(p => p.Key, p => new HashSet<string>(p.Value.Keys));

                foreach (var enumPair in s_sharedEnums.Concat(otherEnumsAsHashSet))
                {
                    foreach (var innerEnumPair in otherEnumsAsHashSet)
                    {
                        if (enumPair.Key != innerEnumPair.Key && innerEnumPair.Value.IsSubsetOf(enumPair.Value))
                        {
                            if (innerEnumPair.Value.SetEquals(enumPair.Value))
                            {
                                Console.WriteLine($"{enumPair.Key} and {innerEnumPair.Key} are equal");
                            }
                            else
                            {
                                var diff = enumPair.Value.Except(innerEnumPair.Value).ToList();
                                if (diff.Count <= 2)
                                {
                                    Console.WriteLine($"{enumPair.Key} contains all members of {innerEnumPair.Key} but adds {string.Join(", ", diff)}");
                                }
                            }
                        }
                    }
                }
                var enumsPath = $"{destinationPath}\\Enums";
                Directory.CreateDirectory(enumsPath);
                foreach (var pair in s_sharedEnums.ToDictionary(p => p.Key, p => p.Value.ToDictionary(s => s, s => (string)null)).Concat(otherEnums))
                {
                    GenerateEnumFileFromOptions(enumsPath, $"{@namespace}.Enums", pair.Key, pair.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Write("Press Enter to End.");
            Console.ReadLine();
        }

        private static void PopulateFieldMappings(string destinationPath, string @namespace, string entityName, string currentPath, Type ellieType, EntitySchema entitySchema, EntitySchema previousEntitySchema, Dictionary<string, EntitySchema> entityTypes, Dictionary<string, LoanFieldDescriptors.StandardFieldInfo> fields, Dictionary<string, LoanFieldDescriptors.StandardFieldInfo> fieldPatterns, Dictionary<string, Dictionary<string, string>> otherEnums)
        {
            var requiredProperties = new HashSet<string>();
            var serializeWholeList = false;

            foreach (var pair in entitySchema.Properties)
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                var description = propertySchema.Description;
                var ellieProperty = ellieType?.GetProperty(propertyName);
                var elliePropertyType = ellieProperty?.PropertyType;
                var fieldId = propertySchema.FieldId;
                if (!string.IsNullOrEmpty(fieldId))
                {
                    if (string.IsNullOrEmpty(description))
                    {
                        try
                        {
                            description = EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.StandardFields[fieldId].Description;
                        }
                        catch
                        {
                        }
                    }
                    fields.Add(fieldId, new LoanFieldDescriptors.StandardFieldInfo { FieldId = fieldId, ModelPath = $"{currentPath}.{propertyName}", Description = description });
                }
                else if (propertySchema.Type == PropertySchemaType.Entity && entityTypes.TryGetValue(propertySchema.EntityType, out var nestedEntitySchema))
                {
                    entityTypes.Remove(propertySchema.EntityType);
                    if (ellieType == typeof(LoanContract) && propertyName == "CurrentApplication")
                    {
                        elliePropertyType = typeof(LoanContractApplications);
                    }
                    else if (ellieType != null && elliePropertyType == null)
                    {
                        Console.WriteLine($"Did not get ellie type for {currentPath}.{propertyName} of type {propertySchema.EntityType.Value}");
                    }
                    PopulateFieldMappings(destinationPath, @namespace, propertySchema.EntityType, $"{currentPath}.{propertyName}", elliePropertyType, nestedEntitySchema, entitySchema, entityTypes, fields, fieldPatterns, otherEnums);
                }
                else if ((propertySchema.Type == PropertySchemaType.List || propertySchema.Type == PropertySchemaType.Set) && entityTypes.TryGetValue(propertySchema.ElementType, out var elementEntitySchema))
                {
                    entityTypes.Remove(propertySchema.ElementType);
                    if (ellieProperty != null)
                    {
                        elliePropertyType = elliePropertyType.GetInterface("IEnumerable`1").GenericTypeArguments[0];
                    }
                    else if (ellieType != null)
                    {
                        Console.WriteLine($"Did not get ellie type for {currentPath}.{propertyName} of type {propertySchema.ElementType.Value}");
                    }
                    PopulateFieldMappings(destinationPath, @namespace, propertySchema.ElementType, $"{currentPath}.{propertyName}", elliePropertyType, elementEntitySchema, entitySchema, entityTypes, fields, fieldPatterns, otherEnums);
                }
                else
                {
                    if (propertySchema.FieldInstances != null)
                    {
                        foreach (var fieldInstancePair in propertySchema.FieldInstances)
                        {
                            fieldId = fieldInstancePair.Key;
                            try
                            {
                                description = EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.StandardFields[fieldId].Description;
                            }
                            catch
                            {
                            }
                            string modelPath = null;
                            if (fieldInstancePair.Value.Count != 1)
                            {
                                Console.WriteLine($"There must be just one field instance value for {fieldId}");
                            }
                            var fieldInstancePath = fieldInstancePair.Value[0];
                            if (fieldInstancePath == "Borrower" || fieldInstancePath == "Coborrower")
                            {
                                modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath}.{propertyName}";
                            }
                            else
                            {
                                var firstUnderscore = fieldInstancePath.IndexOf('_');
                                var secondUnderscore = fieldInstancePath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldInstancePath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                Instance instance = null;
                                if (listPropertySchema.Instances?.TryGetValue(fieldInstancePath, out instance) == true)
                                {
                                    switch (instance)
                                    {
                                        case IntListInstance intListInstance:
                                            if (intListInstance.Count != 1)
                                            {
                                                Console.WriteLine($"There must be just one int list instance value for {fieldInstancePath}");
                                            }
                                            serializeWholeList = true;
                                            modelPath = $"{currentPath}[{intListInstance[0]}].{propertyName}";
                                            break;
                                        case StringListInstance stringListInstance:
                                            foreach (var (s, i) in stringListInstance.Select((s, i) => (s, i)))
                                            {
                                                var keyPropertyName = listPropertySchema.KeyProperties[i];
                                                requiredProperties.Add(keyPropertyName);
                                                var property = entitySchema.Properties[keyPropertyName];
                                                var allowedValues = property.AllowedValues;
                                                if (allowedValues == null)
                                                {
                                                    allowedValues = new List<FieldOption>();
                                                    property.AllowedValues = allowedValues;
                                                }
                                                var option = new FieldOption(s);
                                                if (!allowedValues.Contains(option))
                                                {
                                                    allowedValues.Add(option);
                                                }
                                            }

                                            modelPath = $"{currentPath}[({string.Join(" && ", stringListInstance.Select((s, i) => (s, i)).Where(t => !string.IsNullOrEmpty(t.s)).Select(t => $"{listPropertySchema.KeyProperties[t.i]} == '{t.s}'"))})].{propertyName}";
                                            break;
                                        case StringDictionaryInstance stringDictionaryInstance:
                                            foreach (var p in stringDictionaryInstance)
                                            {
                                                var keyPropertyName = p.Key;
                                                requiredProperties.Add(keyPropertyName);
                                                var property = entitySchema.Properties[keyPropertyName];
                                                var allowedValues = property.AllowedValues;
                                                if (allowedValues == null)
                                                {
                                                    allowedValues = new List<FieldOption>();
                                                    property.AllowedValues = allowedValues;
                                                }
                                                var option = new FieldOption(p.Value);
                                                if (!allowedValues.Contains(option))
                                                {
                                                    allowedValues.Add(option);
                                                }
                                            }

                                            modelPath = $"{currentPath}[({string.Join(" && ", stringDictionaryInstance.Select(p => $"{p.Key} == '{p.Value}'"))})].{propertyName}";
                                            break;
                                        default:
                                            Console.WriteLine($"Bad instance type for {fieldInstancePath}");
                                            break;
                                    }
                                }
                                else
                                {
                                    serializeWholeList = true;
                                    var colonIndex = fieldInstancePath.LastIndexOf(':');
                                    var index = 0;
                                    InstancePattern instancePattern = null;
                                    if (colonIndex < 0 || !int.TryParse(fieldInstancePath.Substring(colonIndex + 1), NumberStyles.None, null, out index) || listPropertySchema.InstancePatterns?.TryGetValue(fieldInstancePath.Substring(0, colonIndex), out instancePattern) != true)
                                    {
                                        Console.WriteLine($"[{fieldId}]: {fieldInstancePath}");
                                    }

                                    if (instancePattern.Match != null)
                                    {
                                        foreach (var p in instancePattern.Match)
                                        {
                                            var keyPropertyName = p.Key;
                                            requiredProperties.Add(keyPropertyName);
                                            var property = entitySchema.Properties[keyPropertyName];
                                            var allowedValues = property.AllowedValues;
                                            if (allowedValues == null)
                                            {
                                                allowedValues = new List<FieldOption>();
                                                property.AllowedValues = allowedValues;
                                            }
                                            var option = new FieldOption(p.Value);
                                            if (!allowedValues.Contains(option))
                                            {
                                                allowedValues.Add(option);
                                            }
                                        }
                                    }

                                    modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{index}].{propertyName}";
                                }
                            }
                            fields.Add(fieldId, new LoanFieldDescriptors.StandardFieldInfo { FieldId = fieldId, Description = description, ModelPath = modelPath });
                        }
                    }
                    if (propertySchema.FieldPatterns != null)
                    {
                        foreach (var fieldPatternPair in propertySchema.FieldPatterns)
                        {
                            var fieldPattern = fieldPatternPair.Key;
                            if (!fieldPattern.StartsWith("DDNN") && !fieldPattern.StartsWith("CUSTNN"))
                            {
                                serializeWholeList = true;
                                if (fieldPatternPair.Value.Count != 1)
                                {
                                    Console.WriteLine($"There must be just one field pattern value for {fieldPattern}");
                                }
                                var fieldPatternPath = fieldPatternPair.Value[0];

                                var firstUnderscore = fieldPatternPath.IndexOf('_');
                                var secondUnderscore = fieldPatternPath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldPatternPath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                var instancePattern = listPropertySchema.InstancePatterns[fieldPatternPath];

                                if (instancePattern.Match != null)
                                {
                                    foreach (var p in instancePattern.Match)
                                    {
                                        var keyPropertyName = p.Key;
                                        requiredProperties.Add(keyPropertyName);
                                        var property = entitySchema.Properties[keyPropertyName];
                                        var allowedValues = property.AllowedValues;
                                        if (allowedValues == null)
                                        {
                                            allowedValues = new List<FieldOption>();
                                            property.AllowedValues = allowedValues;
                                        }
                                        var option = new FieldOption(p.Value);
                                        if (!allowedValues.Contains(option))
                                        {
                                            allowedValues.Add(option);
                                        }
                                    }
                                }

                                fieldId = fieldPattern.StartsWith("NBOCNB") ? fieldPattern.Replace("NBOCNB", "NBOC{0:00}") : fieldPattern.Replace("NN", "{0:00}");

                                try
                                {
                                    description = EllieMae.Encompass.BusinessObjects.Loans.FieldDescriptors.StandardFields[string.Format(fieldId, 1)].Description;
                                    description = description.Replace(" #11", " #{0}").Replace(" #1", " #{0}");
                                }
                                catch
                                {
                                }

                                var modelPath = $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{{0}}].{propertyName}";

                                fieldPatterns.Add(fieldId, new LoanFieldDescriptors.StandardFieldInfo { FieldId = fieldId, Description = description, ModelPath = modelPath });
                            }
                        }
                    }
                }
            }

            GenerateClassFileFromSchema(destinationPath, @namespace, entityName, ellieType, entitySchema, otherEnums, requiredProperties, serializeWholeList);
        }

        private static void GenerateClassFileFromSchema(string destinationPath, string @namespace, string entityName, Type ellieType, EntitySchema entitySchema, Dictionary<string, Dictionary<string, string>> otherEnums, HashSet<string> requiredProperties, bool serializeWholeList)
        {
            var sb = new StringBuilder();

            var entityArguments = string.Empty;
            if (requiredProperties?.Count > 0)
            {
                entityArguments = $"PropertiesToAlwaysSerialize = nameof({string.Join(") + \",\" + nameof(", requiredProperties.OrderBy(p => p))})";
            }
            if (serializeWholeList)
            {
                entityArguments += $"{(entityArguments.Length > 0 ? ", " : string.Empty)}SerializeWholeListWhenDirty = true";
            }

            sb.Append(
$@"using System;
using System.Collections.Generic;
using {@namespace}.Enums;
using EncompassRest.Schema;

namespace {@namespace}
{{
    /// <summary>
    /// {entityName}
    /// </summary>
    {(entityArguments.Length > 0 ? $@"[Entity({entityArguments})]
    " : string.Empty)}public sealed partial class {entityName} : DirtyExtensibleObject, IIdentifiable
    {{
");

            if (ellieType != null)
            {
                foreach (var property in ellieType.GetProperties())
                {
                    if (!entitySchema.Properties.Any(p => string.Equals(p.Key.Replace("_", string.Empty), property.Name.Replace("_", string.Empty), StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine($"EncompassRest missing {ellieType.Name}.{property.Name} on {entityName}");
                    }
                }
            }

            var fields = new StringBuilder();
            var properties = new StringBuilder();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key.Replace("_", string.Empty);
                var entityPropertyName = $"{entityName}.{propertyName}";
                if (ellieType != null)
                {
                    var ellieProperty = ellieType.GetProperties().FirstOrDefault(p => string.Equals(propertyName, p.Name.Replace("_", string.Empty), StringComparison.OrdinalIgnoreCase));
                    var elliePropertyType = ellieProperty?.PropertyType;
                    if (ellieProperty == null)
                    {
                        Console.WriteLine($"Ellie missing {entityName}.{propertyName}");
                    }
                }
                if (!s_propertiesToNotGenerate.Contains(entityPropertyName))
                {
                    var propertySchema = pair.Value;
                    var attributeProperties = new List<string>();
                    if (!string.IsNullOrEmpty(propertySchema.Format))
                    {
                        if (propertySchema.Format.EnumValue != LoanFieldFormat.STATE)
                        {
                            attributeProperties.Add($"Format = LoanFieldFormat.{propertySchema.Format.EnumValue?.GetName()}");
                        }
                    }
                    else
                    {
                        switch (propertySchema.Type.EnumValue)
                        {
                            case PropertySchemaType.DateTime:
                                attributeProperties.Add($"Format = LoanFieldFormat.DATETIME");
                                break;
                        }
                    }
                    if (propertySchema.ReadOnly == true)
                    {
                        attributeProperties.Add($"ReadOnly = true");
                    }
                    var propertyType = GetPropertyOrElementType(entityName, propertyName, propertySchema, out var isEntity, out var isList);
                    if (s_explicitStringEnumValues.TryGetValue(entityPropertyName, out var enumName))
                    {
                        propertyType = $"StringEnumValue<{enumName}>";
                    }
                    else if (propertySchema.AllowedValues?.Count > 0)
                    {
                        if (propertyType == "string")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).Distinct().ToDictionary(o => o.Value, o => o.Text);
                            if (s_enumOptionsToIgnore.TryGetValue(propertyName, out var ignoredOptions))
                            {
                                foreach (var ignoredOption in ignoredOptions)
                                {
                                    optionValues.Remove(ignoredOption);
                                }
                            }
                            foreach (var enumPair in s_sharedEnums)
                            {
                                var setEquals = enumPair.Value.SetEquals(optionValues.Keys);
                                if (setEquals || (s_enumPropertyNamesToUseNotExactSharedEnum.Contains(propertyName) && enumPair.Value.IsSupersetOf(optionValues.Keys)))
                                {
                                    if (!setEquals)
                                    {
                                        var missingOptions = enumPair.Value.Except(optionValues.Keys);
                                        attributeProperties.Add($@"MissingOptionsJson = ""{JsonConvert.SerializeObject(missingOptions).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    enumName = enumPair.Key;
                                    var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.Enums.{enumName}");
                                    foreach (var member in NonGenericEnums.GetMembers(existingEnumType))
                                    {
                                        var existingText = member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        if (optionValues.TryGetValue(value, out var text) && string.Equals(existingText, text, StringComparison.Ordinal))
                                        {
                                            optionValues.Remove(value);
                                        }
                                    }
                                    if (optionValues.Count > 0)
                                    {
                                        attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    break;
                                }
                            }
                            if (enumName == null)
                            {
                                enumName = GetEnumName(entityName, propertyName);
                                if (otherEnums.TryGetValue(enumName, out var enumValues))
                                {
                                    Console.WriteLine($"{entityName} Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", enumValues.Keys)}`");
                                }
                                else if (s_sharedEnums.TryGetValue(enumName, out var sharedEnumValues))
                                {
                                    Console.WriteLine($"{entityName} Shared Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", sharedEnumValues)}`");
                                }
                                else
                                {
                                    otherEnums.Add(enumName, optionValues);
                                }
                            }
                            propertyType = $"StringEnumValue<{enumName}>";
                        }
                        else if (propertyType == "bool?")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Text) && ((string.Equals(o.Value, "true", StringComparison.Ordinal) && !string.Equals(o.Text, "Yes", StringComparison.Ordinal)) || (string.Equals(o.Value, "false", StringComparison.Ordinal) && !string.Equals(o.Text, "No", StringComparison.Ordinal)))).ToDictionary(o => o.Value, o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                        else
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).ToDictionary(o => o.Value, o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                    }
                    var elementType = propertyType;
                    var isStringDictionary = s_stringDictionaryProperties.Contains(entityPropertyName);
                    if (isStringDictionary)
                    {
                        propertyType = "DirtyDictionary<string, string>";
                    }
                    else if (isList)
                    {
                        propertyType = $"DirtyList<{elementType}>";
                    }
                    var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    var isNullable = propertySchema.Nullable == true;
                    fields.AppendLine($"        {(s_propertiesWithInternalFields.Contains(entityPropertyName) ? "internal" : "private")} {((isEntity && !isNullable) || isList || isStringDictionary ? propertyType : $"DirtyValue<{propertyType}>")} {fieldName};");
                    properties.AppendLine($@"        /// <summary>
        /// {(string.IsNullOrEmpty(propertySchema.Description) ? $"{entityName} {propertyName}" : propertySchema.Description.Replace("&", "&amp;"))}{(string.IsNullOrEmpty(propertySchema.FieldId) ? (propertySchema.FieldInstances?.Count == 1 ? $" [{propertySchema.FieldInstances.First().Key}]" : (propertySchema.FieldPatterns?.Count == 1 ? $" [{propertySchema.FieldPatterns.First().Key}]" : string.Empty)) : $" [{propertySchema.FieldId}]")}{(isNullable ? " (Nullable)" : string.Empty)}
        /// </summary>");
                    var isField = !string.IsNullOrEmpty(propertySchema.FieldId) || propertySchema.FieldInstances?.Count > 0 || propertySchema.FieldPatterns?.Count > 0;
                    if (isField && attributeProperties.Count > 0)
                    {
                        properties.AppendLine($"        [LoanFieldProperty({string.Join(", ", attributeProperties)})]");
                    }
                    properties.AppendLine($"        public {(isStringDictionary ? $"IDictionary<string, string>" : (isList ? $"IList<{elementType}>" : propertyType))} {propertyName} {{ get => {((isEntity && !isNullable) || isList || isStringDictionary ? $"GetField(ref {fieldName})" : fieldName)}; set => SetField(ref {fieldName}, value); }}").AppendLine();
                }
            }

            sb.AppendLine(fields.ToString());

            properties.Length -= Environment.NewLine.Length;

            sb.Append(properties.ToString());

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityName + ".cs")))
            {
                sw.Write(sb.ToString());
            }
        }

        private static void GenerateEnumFileFromOptions(string destinationPath, string @namespace, string enumName, Dictionary<string, string> options)
        {
            var sb = new StringBuilder();
            sb.AppendLine(
$@"using System.ComponentModel;
using System.Runtime.Serialization;

namespace {@namespace}
{{
    /// <summary>
    /// {enumName}
    /// </summary>
    public enum {enumName}
    {{");

            var enumMemberNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.{enumName}");
            var existingEnumValues = new HashSet<int>();
            var first = true;
            if (existingEnumType != null)
            {
                foreach (var member in NonGenericEnums.GetMembers(existingEnumType))
                {
                    if (!first)
                    {
                        sb.AppendLine(",");
                    }
                    var name = member.Name;
                    var value = member.AsString(EnumFormat.EnumMemberValue);
                    var text = member.AsString(EnumFormat.Description);
                    if (options.TryGetValue(value ?? name, out var optionText) && optionText != null)
                    {
                        text = optionText;
                    }
                    sb.AppendLine($@"        /// <summary>
        /// {(text ?? value ?? name).Replace("&", "&amp;")}
        /// </summary>");

                    if (!string.IsNullOrEmpty(text) && !string.Equals(text, value ?? name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    if (value != null && !string.Equals(value, name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    enumMemberNames.Add(name);
                    options.Remove(value ?? name);
                    var intValue = member.ToInt32();
                    existingEnumValues.Add(intValue);
                    sb.Append($"        {name} = {intValue}");
                    first = false;
                }
            }
            var i = 0;
            foreach (var pair in options)
            {
                while (existingEnumValues.Contains(i))
                {
                    ++i;
                }
                if (!first)
                {
                    sb.AppendLine(",");
                }
                var value = pair.Key;
                var text = pair.Value;
                var option = value;
                if (string.IsNullOrEmpty(option))
                {
                    option = text;
                }
                var nameBuilder = new StringBuilder(option.Length);
                var startWord = true;
                for (var j = 0; j < option.Length; ++j)
                {
                    var c = option[j];
                    if (j == 0 && char.IsDigit(c))
                    {
                        nameBuilder.Append('n');
                    }
                    if (!char.IsLetterOrDigit(c))
                    {
                        if (!startWord && c != '\'')
                        {
                            startWord = true;
                        }
                    }
                    else
                    {
                        if (startWord)
                        {
                            c = char.ToUpper(c);
                            startWord = false;
                        }
                        nameBuilder.Append(c);
                    }
                }
                var name = nameBuilder.ToString();
                if (name.Length > 0 && enumMemberNames.Add(name))
                {
                    sb.AppendLine($@"        /// <summary>
        /// {(text ?? value).Replace("&", "&amp;")}
        /// </summary>");
                    if (!string.IsNullOrEmpty(text) && !string.Equals(value, text, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    if (!string.Equals(value, name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    sb.Append($"        {name} = {i}");
                    first = false;
                    ++i;
                }
                else if (i > 0)
                {
                    sb.Length -= 1 + Environment.NewLine.Length;
                }
            }
            sb.AppendLine();

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, enumName + ".cs")))
            {
                sw.Write(sb.ToString());
            }
        }

        private static string GetPropertyOrElementType(string entityType, string propertyName, PropertySchema propertySchema, out bool isEntity, out bool isList)
        {
            isEntity = false;
            isList = false;
            if (propertySchema.Format.EnumValue == LoanFieldFormat.STATE)
            {
                return "StringEnumValue<State>";
            }

            var propertyType = propertySchema.Type;
            switch (propertyType.EnumValue)
            {
                case PropertySchemaType.String:
                case PropertySchemaType.Uuid:
                    return "string";
                case PropertySchemaType.NADecimal:
                    return "NA<decimal>";
                case PropertySchemaType.Decimal:
                case PropertySchemaType.Bool:
                case PropertySchemaType.Int:
                    return $"{propertyType}?";
                case PropertySchemaType.Date:
                case PropertySchemaType.DateTime:
                    return "DateTime?";
                case PropertySchemaType.Set:
                case PropertySchemaType.List:
                    isList = true;
                    return propertySchema.ElementType;
                case PropertySchemaType.Entity:
                    isEntity = true;
                    var propertyEntityType = propertySchema.EntityType.Value;
                    return propertyEntityType == "EntityRefContract" ? "EntityReference" : propertyEntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }

        private static string GetEnumName(string entityType, string propertyName) => s_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName) ? $"{entityType}{propertyName}" : propertyName;
    }
}