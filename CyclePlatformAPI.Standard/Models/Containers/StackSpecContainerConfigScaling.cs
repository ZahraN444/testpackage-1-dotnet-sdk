// <copyright file="StackSpecContainerConfigScaling.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackSpecContainerConfigScaling>),
        new Type[] {
            typeof(StackContainerConfigScalingYmlCase)
        },
        false
    )]
    public abstract class StackSpecContainerConfigScaling
    {
        /// <summary>
        /// This is StackContainerConfigScaling.yml case.
        /// </summary>
        /// <returns>
        /// The StackSpecContainerConfigScaling instance, wrapping the provided StackContainerConfigScalingYml value.
        /// </returns>
        public static StackSpecContainerConfigScaling FromStackContainerConfigScalingYml(StackContainerConfigScalingYml stackContainerConfigScalingYml)
        {
            return new StackContainerConfigScalingYmlCase().Set(stackContainerConfigScalingYml);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackContainerConfigScalingYml, T> stackContainerConfigScalingYml);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerConfigScalingYmlCase, StackContainerConfigScalingYml>))]
        private sealed class StackContainerConfigScalingYmlCase : StackSpecContainerConfigScaling, ICaseValue<StackContainerConfigScalingYmlCase, StackContainerConfigScalingYml>
        {
            public StackContainerConfigScalingYml _value;

            public override T Match<T>(Func<StackContainerConfigScalingYml, T> stackContainerConfigScalingYml)
            {
                return stackContainerConfigScalingYml(_value);
            }

            public StackContainerConfigScalingYmlCase Set(StackContainerConfigScalingYml value)
            {
                _value = value;
                return this;
            }

            public StackContainerConfigScalingYml Get()
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