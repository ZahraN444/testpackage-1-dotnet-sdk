// <copyright file="SchedulerEnvironmentServiceConfig.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<SchedulerEnvironmentServiceConfig>),
        new Type[] {
            typeof(SchedulerConfigCase)
        },
        false
    )]
    public abstract class SchedulerEnvironmentServiceConfig
    {
        /// <summary>
        /// This is SchedulerConfig case.
        /// </summary>
        /// <returns>
        /// The SchedulerEnvironmentServiceConfig instance, wrapping the provided SchedulerConfig value.
        /// </returns>
        public static SchedulerEnvironmentServiceConfig FromSchedulerConfig(SchedulerConfig schedulerConfig)
        {
            return new SchedulerConfigCase().Set(schedulerConfig);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SchedulerConfig, T> schedulerConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<SchedulerConfigCase, SchedulerConfig>))]
        private sealed class SchedulerConfigCase : SchedulerEnvironmentServiceConfig, ICaseValue<SchedulerConfigCase, SchedulerConfig>
        {
            public SchedulerConfig _value;

            public override T Match<T>(Func<SchedulerConfig, T> schedulerConfig)
            {
                return schedulerConfig(_value);
            }

            public SchedulerConfigCase Set(SchedulerConfig value)
            {
                _value = value;
                return this;
            }

            public SchedulerConfig Get()
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