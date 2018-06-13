﻿using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Filters
{
    /// <summary>
    /// Does not currently work with string fields
    /// </summary>
    public sealed class EmptyFieldFilter : FieldFilter
    {
        [JsonProperty("Value")]
        private object value => System.DateTime.MinValue;

        public EmptyFieldFilter(CanonicalLoanField canonicalLoanField)
            : this(canonicalLoanField.Validate(nameof(canonicalLoanField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(CanonicalContactField canonicalContactField)
            : this(canonicalContactField.Validate(nameof(canonicalContactField)).GetCanonicalName())
        {
        }

        public EmptyFieldFilter(string canonicalName)
            : base(canonicalName)
        {
        }

        private EmptyFieldFilter(EmptyFieldFilter emptyFieldFilter)
            : base(emptyFieldFilter)
        {
        }

        public new EmptyFieldFilter Clone() => new EmptyFieldFilter(this);

        protected override FieldFilter CloneFieldFilter() => Clone();

        protected override string GetMatchType() => "isEmpty";
    }
}