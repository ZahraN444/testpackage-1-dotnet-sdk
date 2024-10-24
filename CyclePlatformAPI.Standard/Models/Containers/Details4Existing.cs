// <copyright file="Details4Existing.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Details4Existing>),
        new Type[] {
            typeof(ExistingSourceCase)
        },
        false
    )]
    public abstract class Details4Existing
    {
        /// <summary>
        /// This is ExistingSource case.
        /// </summary>
        /// <returns>
        /// The Details4Existing instance, wrapping the provided ExistingSource value.
        /// </returns>
        public static Details4Existing FromExistingSource(ExistingSource existingSource)
        {
            return new ExistingSourceCase().Set(existingSource);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ExistingSource, T> existingSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<ExistingSourceCase, ExistingSource>))]
        private sealed class ExistingSourceCase : Details4Existing, ICaseValue<ExistingSourceCase, ExistingSource>
        {
            public ExistingSource _value;

            public override T Match<T>(Func<ExistingSource, T> existingSource)
            {
                return existingSource(_value);
            }

            public ExistingSourceCase Set(ExistingSource value)
            {
                _value = value;
                return this;
            }

            public ExistingSource Get()
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