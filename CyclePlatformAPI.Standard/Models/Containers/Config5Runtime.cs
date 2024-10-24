// <copyright file="Config5Runtime.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Config5Runtime>),
        new Type[] {
            typeof(StackContainerConfigRuntimeCase)
        },
        false
    )]
    public abstract class Config5Runtime
    {
        /// <summary>
        /// This is StackContainerConfigRuntime case.
        /// </summary>
        /// <returns>
        /// The Config5Runtime instance, wrapping the provided StackContainerConfigRuntime value.
        /// </returns>
        public static Config5Runtime FromStackContainerConfigRuntime(StackContainerConfigRuntime stackContainerConfigRuntime)
        {
            return new StackContainerConfigRuntimeCase().Set(stackContainerConfigRuntime);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackContainerConfigRuntime, T> stackContainerConfigRuntime);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerConfigRuntimeCase, StackContainerConfigRuntime>))]
        private sealed class StackContainerConfigRuntimeCase : Config5Runtime, ICaseValue<StackContainerConfigRuntimeCase, StackContainerConfigRuntime>
        {
            public StackContainerConfigRuntime _value;

            public override T Match<T>(Func<StackContainerConfigRuntime, T> stackContainerConfigRuntime)
            {
                return stackContainerConfigRuntime(_value);
            }

            public StackContainerConfigRuntimeCase Set(StackContainerConfigRuntime value)
            {
                _value = value;
                return this;
            }

            public StackContainerConfigRuntime Get()
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