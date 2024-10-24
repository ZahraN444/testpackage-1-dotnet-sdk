// <copyright file="IntegrationMeta2.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<IntegrationMeta2>),
        new Type[] {
            typeof(IntegrationMetaCase)
        },
        false
    )]
    public abstract class IntegrationMeta2
    {
        /// <summary>
        /// This is IntegrationMeta case.
        /// </summary>
        /// <returns>
        /// The IntegrationMeta2 instance, wrapping the provided IntegrationMeta value.
        /// </returns>
        public static IntegrationMeta2 FromIntegrationMeta(IntegrationMeta integrationMeta)
        {
            return new IntegrationMetaCase().Set(integrationMeta);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<IntegrationMeta, T> integrationMeta);

        [JsonConverter(typeof(UnionTypeCaseConverter<IntegrationMetaCase, IntegrationMeta>))]
        private sealed class IntegrationMetaCase : IntegrationMeta2, ICaseValue<IntegrationMetaCase, IntegrationMeta>
        {
            public IntegrationMeta _value;

            public override T Match<T>(Func<IntegrationMeta, T> integrationMeta)
            {
                return integrationMeta(_value);
            }

            public IntegrationMetaCase Set(IntegrationMeta value)
            {
                _value = value;
                return this;
            }

            public IntegrationMeta Get()
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