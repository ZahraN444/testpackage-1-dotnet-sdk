// <copyright file="ActivitySession2.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ActivitySession2>),
        new Type[] {
            typeof(ActivitySessionCase)
        },
        false
    )]
    public abstract class ActivitySession2
    {
        /// <summary>
        /// This is ActivitySession case.
        /// </summary>
        /// <returns>
        /// The ActivitySession2 instance, wrapping the provided ActivitySession value.
        /// </returns>
        public static ActivitySession2 FromActivitySession(ActivitySession activitySession)
        {
            return new ActivitySessionCase().Set(activitySession);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ActivitySession, T> activitySession);

        [JsonConverter(typeof(UnionTypeCaseConverter<ActivitySessionCase, ActivitySession>))]
        private sealed class ActivitySessionCase : ActivitySession2, ICaseValue<ActivitySessionCase, ActivitySession>
        {
            public ActivitySession _value;

            public override T Match<T>(Func<ActivitySession, T> activitySession)
            {
                return activitySession(_value);
            }

            public ActivitySessionCase Set(ActivitySession value)
            {
                _value = value;
                return this;
            }

            public ActivitySession Get()
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