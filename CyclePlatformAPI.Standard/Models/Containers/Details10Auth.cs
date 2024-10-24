// <copyright file="Details10Auth.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Details10Auth>),
        new Type[] {
            typeof(Case0)
        },
        false
    )]
    public abstract class Details10Auth
    {
        /// <summary>
        /// This is RegistryAuth case.
        /// </summary>
        /// <returns>
        /// The Details10Auth instance, wrapping the provided RegistryAuth value.
        /// </returns>
        public static Details10Auth FromRegistryAuth(RegistryAuth registryAuth)
        {
            return new Case0().Set(registryAuth);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RegistryAuth, T> registryAuth);

        [JsonConverter(typeof(UnionTypeCaseConverter<Case0, RegistryAuth>))]
        private sealed class Case0 : Details10Auth, ICaseValue<Case0, RegistryAuth>
        {
            public RegistryAuth _value;

            public override T Match<T>(Func<RegistryAuth, T> registryAuth)
            {
                return registryAuth(_value);
            }

            public Case0 Set(RegistryAuth value)
            {
                _value = value;
                return this;
            }

            public RegistryAuth Get()
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