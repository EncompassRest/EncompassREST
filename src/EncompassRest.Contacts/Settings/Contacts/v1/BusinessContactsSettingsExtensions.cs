﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Contacts.v1
{
    public static class BusinessContactsSettingsExtensions
    {
        public static IBusinessContactsSettingsV1? V1 { get; set; }

        private static IBusinessContactsSettingsV1 GetV1(IBusinessContactsSettings businessContactSettings)
        {
            var v1 = V1;
            if (businessContactSettings is BusinessContactsSettings s)
            {
                v1 = (IBusinessContactsSettingsV1)s.ExtensionData.GetOrAdd("v1", k => new BusinessContactsSettingsV1(s.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(businessContactSettings, nameof(businessContactSettings));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Returns a list of canonical field names for contact fields.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactFieldDefinition>> GetCanonicalNamesAsync(this IBusinessContactsSettings businessContactsSettings, CancellationToken cancellationToken = default) => GetV1(businessContactsSettings).GetCanonicalNamesAsync(cancellationToken);

        /// <summary>
        /// Returns a list of canonical field names for contact fields as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCanonicalNamesRawAsync(this IBusinessContactsSettings businessContactsSettings, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(businessContactsSettings).GetCanonicalNamesRawAsync(queryString, cancellationToken);
    }
}