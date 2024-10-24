// <copyright file="Data3Stats.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Data3Stats>),
        new Type[] {
            typeof(ResourceCountSummaryCase)
        },
        false
    )]
    public abstract class Data3Stats
    {
        /// <summary>
        /// This is ResourceCountSummary case.
        /// </summary>
        /// <returns>
        /// The Data3Stats instance, wrapping the provided ResourceCountSummary value.
        /// </returns>
        public static Data3Stats FromResourceCountSummary(ResourceCountSummary resourceCountSummary)
        {
            return new ResourceCountSummaryCase().Set(resourceCountSummary);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ResourceCountSummary, T> resourceCountSummary);

        [JsonConverter(typeof(UnionTypeCaseConverter<ResourceCountSummaryCase, ResourceCountSummary>))]
        private sealed class ResourceCountSummaryCase : Data3Stats, ICaseValue<ResourceCountSummaryCase, ResourceCountSummary>
        {
            public ResourceCountSummary _value;

            public override T Match<T>(Func<ResourceCountSummary, T> resourceCountSummary)
            {
                return resourceCountSummary(_value);
            }

            public ResourceCountSummaryCase Set(ResourceCountSummary value)
            {
                _value = value;
                return this;
            }

            public ResourceCountSummary Get()
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