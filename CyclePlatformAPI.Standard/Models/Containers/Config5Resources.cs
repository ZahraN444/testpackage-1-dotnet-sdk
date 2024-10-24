// <copyright file="Config5Resources.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Config5Resources>),
        new Type[] {
            typeof(StackContainerConfigResourcesCase)
        },
        false
    )]
    public abstract class Config5Resources
    {
        /// <summary>
        /// This is StackContainerConfigResources case.
        /// </summary>
        /// <returns>
        /// The Config5Resources instance, wrapping the provided StackContainerConfigResources value.
        /// </returns>
        public static Config5Resources FromStackContainerConfigResources(StackContainerConfigResources stackContainerConfigResources)
        {
            return new StackContainerConfigResourcesCase().Set(stackContainerConfigResources);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackContainerConfigResources, T> stackContainerConfigResources);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerConfigResourcesCase, StackContainerConfigResources>))]
        private sealed class StackContainerConfigResourcesCase : Config5Resources, ICaseValue<StackContainerConfigResourcesCase, StackContainerConfigResources>
        {
            public StackContainerConfigResources _value;

            public override T Match<T>(Func<StackContainerConfigResources, T> stackContainerConfigResources)
            {
                return stackContainerConfigResources(_value);
            }

            public StackContainerConfigResourcesCase Set(StackContainerConfigResources value)
            {
                _value = value;
                return this;
            }

            public StackContainerConfigResources Get()
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