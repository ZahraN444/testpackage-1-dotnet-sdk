// <copyright file="EnvironmentServicesScheduler.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<EnvironmentServicesScheduler>),
        new Type[] {
            typeof(SchedulerEnvironmentServiceCase)
        },
        false
    )]
    public abstract class EnvironmentServicesScheduler
    {
        /// <summary>
        /// This is SchedulerEnvironmentService case.
        /// </summary>
        /// <returns>
        /// The EnvironmentServicesScheduler instance, wrapping the provided SchedulerEnvironmentService value.
        /// </returns>
        public static EnvironmentServicesScheduler FromSchedulerEnvironmentService(SchedulerEnvironmentService schedulerEnvironmentService)
        {
            return new SchedulerEnvironmentServiceCase().Set(schedulerEnvironmentService);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SchedulerEnvironmentService, T> schedulerEnvironmentService);

        [JsonConverter(typeof(UnionTypeCaseConverter<SchedulerEnvironmentServiceCase, SchedulerEnvironmentService>))]
        private sealed class SchedulerEnvironmentServiceCase : EnvironmentServicesScheduler, ICaseValue<SchedulerEnvironmentServiceCase, SchedulerEnvironmentService>
        {
            public SchedulerEnvironmentService _value;

            public override T Match<T>(Func<SchedulerEnvironmentService, T> schedulerEnvironmentService)
            {
                return schedulerEnvironmentService(_value);
            }

            public SchedulerEnvironmentServiceCase Set(SchedulerEnvironmentService value)
            {
                _value = value;
                return this;
            }

            public SchedulerEnvironmentService Get()
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