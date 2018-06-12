﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed class LoanFieldDescriptors : ApiObject
    {
        private static readonly ModelPathContext s_modelPathContext = new ModelPathContext(new[]
        {
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010Fees", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010Fee.Gfe2010FeeIndex), "0" }, { nameof(Gfe2010Fee.Gfe2010FeeType), "Undefined" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010.Gfe2010WholePocs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010WholePoc.Gfe2010WholePocIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.ClosingCost.Gfe2010Page.Gfe2010FwbcFwscs", new ModelPathSettings(new Dictionary<string, string> { { nameof(Gfe2010FwbcFwsc.Gfe2010FwbcFwscIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.Gfe.GfeFees", new ModelPathSettings(new Dictionary<string, string> { { nameof(GfeFee.GfeFeeIndex), "0" } })),
            new KeyValuePair<string, ModelPathSettings>("Loan.MilestoneTemplateLogs", new ModelPathSettings(0))
        }, 1, name => JsonHelper.CamelCaseNamingStrategy.GetPropertyName(name.Replace("_", string.Empty), false));

        internal static readonly ConcurrentDictionary<string, FieldDescriptor> s_standardFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

        internal static readonly ConcurrentDictionary<string, FieldDescriptor> s_virtualFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

        public static ReadOnlyDictionary<string, FieldDescriptor> StandardFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(s_standardFields);

        public static ReadOnlyDictionary<string, FieldDescriptor> VirtualFields { get; } = new ReadOnlyDictionary<string, FieldDescriptor>(s_virtualFields);

        public static LoanFieldMappings FieldMappings { get; } = new LoanFieldMappings();

        public static LoanFieldPatternMappings FieldPatternMappings { get; } = new LoanFieldPatternMappings();

        internal static ModelPath CreateModelPath(string modelPath)
        {
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            try
            {
                var path = new ModelPath(s_modelPathContext, modelPath);
                if (string.Equals(path.RootObjectName, "Loan", StringComparison.OrdinalIgnoreCase))
                {
                    return path;
                }
            }
            catch
            {
            }
            return null;
        }

        internal static FieldDescriptor GetFieldDescriptor(string fieldId, IDictionary<string, FieldDescriptor> customFields)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            if (!FieldMappings._dictionary.TryGetValue(fieldId, out var descriptor) && customFields?.TryGetValue(fieldId, out descriptor) != true && !FieldPatternMappings.TryGetDescriptorForFieldId(fieldId, out descriptor))
            {
                throw new ArgumentException($"Could not find field '{fieldId}'");
            }
            return descriptor;
        }

        static LoanFieldDescriptors()
        {
            // Use embedded resource file for built-in field mappings to save assembly space
            using (var stream = typeof(LoanFields).GetTypeInfo().Assembly.GetManifestResourceStream("EncompassRest.LoanFields.zip"))
            {
                using (var zip = new ZipArchive(stream))
                {
                    using (var jsonStream = zip.GetEntry("LoanFields.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                                JsonHelper.DefaultPublicSerializer.Populate(jr, dictionary);
                                
                                foreach (var pair in dictionary)
                                {
                                    FieldMappings.TryAdd(pair.Key, pair.Value);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("VirtualFields.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var virtualFields = JsonHelper.DefaultPublicSerializer.Deserialize<List<VirtualFieldInfo>>(jr);

                                foreach (var virtualField in virtualFields)
                                {
                                    var fieldDescriptor = new NonStandardFieldDescriptor(virtualField.FieldId, CreateModelPath($"Loan.VirtualFields['{virtualField.FieldId}']"), LoanFieldType.Virtual, virtualField.Description, virtualField.Format, virtualField.Options, true);
                                    FieldMappings.AddVirtualField(fieldDescriptor);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("LoanFieldPatterns.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                                JsonHelper.DefaultPublicSerializer.Populate(jr, dictionary);

                                foreach (var pair in dictionary)
                                {
                                    FieldPatternMappings.TryAdd(pair.Key, pair.Value);
                                }
                            }
                        }
                    }

                    using (var jsonStream = zip.GetEntry("VirtualFieldPatterns.json").Open())
                    {
                        using (var sr = new StreamReader(jsonStream))
                        {
                            using (var jr = new JsonTextReader(sr))
                            {
                                var virtualFieldPatterns = JsonHelper.DefaultPublicSerializer.Deserialize<List<VirtualFieldInfo>>(jr);

                                foreach (var virtualFieldPattern in virtualFieldPatterns)
                                {
                                    var fieldDescriptor = new NonStandardFieldDescriptor(virtualFieldPattern.FieldId, CreateModelPath($"Loan.VirtualFields['{virtualFieldPattern.FieldId}']"), LoanFieldType.Virtual, virtualFieldPattern.Description, virtualFieldPattern.Format, virtualFieldPattern.Options, true, true);
                                    FieldPatternMappings.AddVirtualField(virtualFieldPattern.FieldId, fieldDescriptor);
                                }
                            }
                        }
                    }
                }
            }
        }

        public FieldDescriptor this[string fieldId] => GetFieldDescriptor(fieldId, _customFields);

        private readonly ConcurrentDictionary<string, FieldDescriptor> _customFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

        public ReadOnlyDictionary<string, FieldDescriptor> CustomFields { get; }

        internal LoanFieldDescriptors(EncompassRestClient client)
            : base(client, null)
        {
            CustomFields = new ReadOnlyDictionary<string, FieldDescriptor>(_customFields);
        }

        public async Task RefreshCustomFieldsAsync(CancellationToken cancellationToken = default)
        {
            var customFields = new Dictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

            var allCustomFields = await Client.Settings.Loan.CustomFields.GetCustomFieldsAsync(cancellationToken).ConfigureAwait(false);

            foreach (var customField in allCustomFields)
            {
                customFields[customField.Id] = new NonStandardFieldDescriptor(customField.Id, CreateModelPath($"Loan.CustomFields[(FieldName == '{customField.Id}')].StringValue"), LoanFieldType.Custom, customField.Description, customField.Format, customField.Options?.Select(o => new FieldOption(o)).ToList(), false);
            }

            foreach (var pair in _customFields)
            {
                if (customFields.TryGetValue(pair.Key, out var descriptor))
                {
                    _customFields[pair.Key] = descriptor;
                    customFields.Remove(pair.Key);
                }
                else
                {
                    _customFields.TryRemove(pair.Key, out _);
                }
            }

            foreach (var pair in customFields)
            {
                _customFields[pair.Key] = pair.Value;
            }
        }

        private sealed class VirtualFieldInfo
        {
            public string FieldId { get; set; }

            public LoanFieldFormat Format { get; set; }

            public string Description { get; set; }

            public List<FieldOption> Options { get; set; }
        }
    }
}