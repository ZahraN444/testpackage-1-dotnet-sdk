// <copyright file="ProviderLocationGeographic.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ProviderLocationGeographic>),
        new Type[] {
            typeof(ProviderLocationGeographyCase)
        },
        false
    )]
    public abstract class ProviderLocationGeographic
    {
        /// <summary>
        /// This is ProviderLocationGeography case.
        /// </summary>
        /// <returns>
        /// The ProviderLocationGeographic instance, wrapping the provided ProviderLocationGeography value.
        /// </returns>
        public static ProviderLocationGeographic FromProviderLocationGeography(ProviderLocationGeography providerLocationGeography)
        {
            return new ProviderLocationGeographyCase().Set(providerLocationGeography);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ProviderLocationGeography, T> providerLocationGeography);

        [JsonConverter(typeof(UnionTypeCaseConverter<ProviderLocationGeographyCase, ProviderLocationGeography>))]
        private sealed class ProviderLocationGeographyCase : ProviderLocationGeographic, ICaseValue<ProviderLocationGeographyCase, ProviderLocationGeography>
        {
            public ProviderLocationGeography _value;

            public override T Match<T>(Func<ProviderLocationGeography, T> providerLocationGeography)
            {
                return providerLocationGeography(_value);
            }

            public ProviderLocationGeographyCase Set(ProviderLocationGeography value)
            {
                _value = value;
                return this;
            }

            public ProviderLocationGeography Get()
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