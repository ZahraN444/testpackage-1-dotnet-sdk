// <copyright file="InstancePurgeTime.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InstancePurgeTime>),
        new Type[] {
            typeof(DateTimeCase)
        },
        false
    )]
    public abstract class InstancePurgeTime
    {
        /// <summary>
        /// This is DateTime case.
        /// </summary>
        /// <returns>
        /// The InstancePurgeTime instance, wrapping the provided DateTime value.
        /// </returns>
        public static InstancePurgeTime FromDateTime(DateTime dateTime)
        {
            return new DateTimeCase().Set(dateTime);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<DateTime, T> dateTime);

        [JsonConverter(typeof(UnionTypeCaseConverter<DateTimeCase, DateTime>), JTokenType.Date)]
        private sealed class DateTimeCase : InstancePurgeTime, ICaseValue<DateTimeCase, DateTime>, ICustomConverter
        {
            public DateTime _value;

            public override T Match<T>(Func<DateTime, T> dateTime)
            {
                return dateTime(_value);
            }

            public DateTimeCase Set(DateTime value)
            {
                _value = value;
                return this;
            }

            public DateTime Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }

            public JsonConverter GetJsonConverter()
            {
                return new CustomDateTimeConverter("");
            }
        }
    }
}