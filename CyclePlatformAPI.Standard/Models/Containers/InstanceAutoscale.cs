// <copyright file="InstanceAutoscale.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<InstanceAutoscale>),
        new Type[] {
            typeof(InstanceAutoScaleCase)
        },
        false
    )]
    public abstract class InstanceAutoscale
    {
        /// <summary>
        /// This is InstanceAutoScale case.
        /// </summary>
        /// <returns>
        /// The InstanceAutoscale instance, wrapping the provided InstanceAutoScale value.
        /// </returns>
        public static InstanceAutoscale FromInstanceAutoScale(InstanceAutoScale instanceAutoScale)
        {
            return new InstanceAutoScaleCase().Set(instanceAutoScale);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<InstanceAutoScale, T> instanceAutoScale);

        [JsonConverter(typeof(UnionTypeCaseConverter<InstanceAutoScaleCase, InstanceAutoScale>))]
        private sealed class InstanceAutoScaleCase : InstanceAutoscale, ICaseValue<InstanceAutoScaleCase, InstanceAutoScale>
        {
            public InstanceAutoScale _value;

            public override T Match<T>(Func<InstanceAutoScale, T> instanceAutoScale)
            {
                return instanceAutoScale(_value);
            }

            public InstanceAutoScaleCase Set(InstanceAutoScale value)
            {
                _value = value;
                return this;
            }

            public InstanceAutoScale Get()
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