// <copyright file="Features2Certificate.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<Features2Certificate>),
        new Type[] {
            typeof(TLSCertificateSummaryCase)
        },
        false
    )]
    public abstract class Features2Certificate
    {
        /// <summary>
        /// This is TLSCertificateSummary case.
        /// </summary>
        /// <returns>
        /// The Features2Certificate instance, wrapping the provided TLSCertificateSummary value.
        /// </returns>
        public static Features2Certificate FromTLSCertificateSummary(TLSCertificateSummary tLSCertificateSummary)
        {
            return new TLSCertificateSummaryCase().Set(tLSCertificateSummary);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<TLSCertificateSummary, T> tLSCertificateSummary);

        [JsonConverter(typeof(UnionTypeCaseConverter<TLSCertificateSummaryCase, TLSCertificateSummary>))]
        private sealed class TLSCertificateSummaryCase : Features2Certificate, ICaseValue<TLSCertificateSummaryCase, TLSCertificateSummary>
        {
            public TLSCertificateSummary _value;

            public override T Match<T>(Func<TLSCertificateSummary, T> tLSCertificateSummary)
            {
                return tLSCertificateSummary(_value);
            }

            public TLSCertificateSummaryCase Set(TLSCertificateSummary value)
            {
                _value = value;
                return this;
            }

            public TLSCertificateSummary Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}