// <copyright file="StackRawSourceDetails.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackRawSourceDetails>),
        new Type[] {
            typeof(StackSpecCase)
        },
        false
    )]
    public abstract class StackRawSourceDetails
    {
        /// <summary>
        /// This is StackSpec case.
        /// </summary>
        /// <returns>
        /// The StackRawSourceDetails instance, wrapping the provided StackSpec value.
        /// </returns>
        public static StackRawSourceDetails FromStackSpec(StackSpec stackSpec)
        {
            return new StackSpecCase().Set(stackSpec);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackSpec, T> stackSpec);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackSpecCase, StackSpec>))]
        private sealed class StackSpecCase : StackRawSourceDetails, ICaseValue<StackSpecCase, StackSpec>
        {
            public StackSpec _value;

            public override T Match<T>(Func<StackSpec, T> stackSpec)
            {
                return stackSpec(_value);
            }

            public StackSpecCase Set(StackSpec value)
            {
                _value = value;
                return this;
            }

            public StackSpec Get()
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