// <copyright file="Contents7Update.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Contents7Update>),
        new Type[] {
            typeof(StackBuildDeploymentUpdatesCase)
        },
        false
    )]
    public abstract class Contents7Update
    {
        /// <summary>
        /// This is StackBuildDeploymentUpdates case.
        /// </summary>
        /// <returns>
        /// The Contents7Update instance, wrapping the provided StackBuildDeploymentUpdates value.
        /// </returns>
        public static Contents7Update FromStackBuildDeploymentUpdates(StackBuildDeploymentUpdates stackBuildDeploymentUpdates)
        {
            return new StackBuildDeploymentUpdatesCase().Set(stackBuildDeploymentUpdates);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackBuildDeploymentUpdates, T> stackBuildDeploymentUpdates);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildDeploymentUpdatesCase, StackBuildDeploymentUpdates>))]
        private sealed class StackBuildDeploymentUpdatesCase : Contents7Update, ICaseValue<StackBuildDeploymentUpdatesCase, StackBuildDeploymentUpdates>
        {
            public StackBuildDeploymentUpdates _value;

            public override T Match<T>(Func<StackBuildDeploymentUpdates, T> stackBuildDeploymentUpdates)
            {
                return stackBuildDeploymentUpdates(_value);
            }

            public StackBuildDeploymentUpdatesCase Set(StackBuildDeploymentUpdates value)
            {
                _value = value;
                return this;
            }

            public StackBuildDeploymentUpdates Get()
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