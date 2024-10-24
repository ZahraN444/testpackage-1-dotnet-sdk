// <copyright file="HubBilling.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<HubBilling>),
        new Type[] {
            typeof(HubBillingProfileCase)
        },
        false
    )]
    public abstract class HubBilling
    {
        /// <summary>
        /// This is HubBillingProfile case.
        /// </summary>
        /// <returns>
        /// The HubBilling instance, wrapping the provided HubBillingProfile value.
        /// </returns>
        public static HubBilling FromHubBillingProfile(HubBillingProfile hubBillingProfile)
        {
            return new HubBillingProfileCase().Set(hubBillingProfile);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<HubBillingProfile, T> hubBillingProfile);

        [JsonConverter(typeof(UnionTypeCaseConverter<HubBillingProfileCase, HubBillingProfile>))]
        private sealed class HubBillingProfileCase : HubBilling, ICaseValue<HubBillingProfileCase, HubBillingProfile>
        {
            public HubBillingProfile _value;

            public override T Match<T>(Func<HubBillingProfile, T> hubBillingProfile)
            {
                return hubBillingProfile(_value);
            }

            public HubBillingProfileCase Set(HubBillingProfile value)
            {
                _value = value;
                return this;
            }

            public HubBillingProfile Get()
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