﻿using Newtonsoft.Json;

namespace EncompassRest.Services.Verification
{
    public abstract class VerificationProduct : ServiceProduct
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public VerificationPreferences Preferences { get; set; }

        internal VerificationProduct(EntityReference entityRef, ServiceOptions options)
            : this(entityRef, options, ServiceType.Verification.GetValue())
        {
        }

        internal VerificationProduct(EntityReference entityRef, ServiceOptions options, string name)
            : base(entityRef, options, name)
        {
        }
    }
}