// <copyright file="Details43About.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Details43About>),
        new Type[] {
            typeof(EnvironmentAboutCase)
        },
        false
    )]
    public abstract class Details43About
    {
        /// <summary>
        /// This is EnvironmentAbout case.
        /// </summary>
        /// <returns>
        /// The Details43About instance, wrapping the provided EnvironmentAbout value.
        /// </returns>
        public static Details43About FromEnvironmentAbout(EnvironmentAbout environmentAbout)
        {
            return new EnvironmentAboutCase().Set(environmentAbout);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<EnvironmentAbout, T> environmentAbout);

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentAboutCase, EnvironmentAbout>))]
        private sealed class EnvironmentAboutCase : Details43About, ICaseValue<EnvironmentAboutCase, EnvironmentAbout>
        {
            public EnvironmentAbout _value;

            public override T Match<T>(Func<EnvironmentAbout, T> environmentAbout)
            {
                return environmentAbout(_value);
            }

            public EnvironmentAboutCase Set(EnvironmentAbout value)
            {
                _value = value;
                return this;
            }

            public EnvironmentAbout Get()
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