// <copyright file="V1HubsCurrentIntegrationsRequestAuth.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<V1HubsCurrentIntegrationsRequestAuth>),
        new Type[] {
            typeof(IntegrationAuthCase)
        },
        false
    )]
    public abstract class V1HubsCurrentIntegrationsRequestAuth
    {
        /// <summary>
        /// This is IntegrationAuth case.
        /// </summary>
        /// <returns>
        /// The V1HubsCurrentIntegrationsRequestAuth instance, wrapping the provided IntegrationAuth value.
        /// </returns>
        public static V1HubsCurrentIntegrationsRequestAuth FromIntegrationAuth(IntegrationAuth integrationAuth)
        {
            return new IntegrationAuthCase().Set(integrationAuth);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<IntegrationAuth, T> integrationAuth);

        [JsonConverter(typeof(UnionTypeCaseConverter<IntegrationAuthCase, IntegrationAuth>))]
        private sealed class IntegrationAuthCase : V1HubsCurrentIntegrationsRequestAuth, ICaseValue<IntegrationAuthCase, IntegrationAuth>
        {
            public IntegrationAuth _value;

            public override T Match<T>(Func<IntegrationAuth, T> integrationAuth)
            {
                return integrationAuth(_value);
            }

            public IntegrationAuthCase Set(IntegrationAuth value)
            {
                _value = value;
                return this;
            }

            public IntegrationAuth Get()
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