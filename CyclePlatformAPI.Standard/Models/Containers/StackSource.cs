// <copyright file="StackSource.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<StackSource>),
        new Type[] {
            typeof(StackRepoSourceCase),
            typeof(StackRawSourceCase)
        },
        new string[] {
            "git-repo",
            "raw"
        },
        "type",
        true
    )]
    public abstract class StackSource
    {
        /// <summary>
        /// This is StackRepoSource case.
        /// </summary>
        /// <returns>
        /// The StackSource instance, wrapping the provided StackRepoSource value.
        /// </returns>
        public static StackSource FromStackRepoSource(StackRepoSource stackRepoSource)
        {
            return new StackRepoSourceCase().Set(stackRepoSource);
        }

        /// <summary>
        /// This is StackRawSource case.
        /// </summary>
        /// <returns>
        /// The StackSource instance, wrapping the provided StackRawSource value.
        /// </returns>
        public static StackSource FromStackRawSource(StackRawSource stackRawSource)
        {
            return new StackRawSourceCase().Set(stackRawSource);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackRepoSource, T> stackRepoSource, Func<StackRawSource, T> stackRawSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackRepoSourceCase, StackRepoSource>))]
        private sealed class StackRepoSourceCase : StackSource, ICaseValue<StackRepoSourceCase, StackRepoSource>
        {
            public StackRepoSource _value;

            public override T Match<T>(Func<StackRepoSource, T> stackRepoSource, Func<StackRawSource, T> stackRawSource)
            {
                return stackRepoSource(_value);
            }

            public StackRepoSourceCase Set(StackRepoSource value)
            {
                _value = value;
                return this;
            }

            public StackRepoSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackRawSourceCase, StackRawSource>))]
        private sealed class StackRawSourceCase : StackSource, ICaseValue<StackRawSourceCase, StackRawSource>
        {
            public StackRawSource _value;

            public override T Match<T>(Func<StackRepoSource, T> stackRepoSource, Func<StackRawSource, T> stackRawSource)
            {
                return stackRawSource(_value);
            }

            public StackRawSourceCase Set(StackRawSource value)
            {
                _value = value;
                return this;
            }

            public StackRawSource Get()
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