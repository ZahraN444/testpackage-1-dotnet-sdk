// <copyright file="V1ContainersRequestDeployment.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<V1ContainersRequestDeployment>),
        new Type[] {
            typeof(DeploymentCase)
        },
        false
    )]
    public abstract class V1ContainersRequestDeployment
    {
        /// <summary>
        /// This is Deployment case.
        /// </summary>
        /// <returns>
        /// The V1ContainersRequestDeployment instance, wrapping the provided Deployment value.
        /// </returns>
        public static V1ContainersRequestDeployment FromDeployment(Deployment deployment)
        {
            return new DeploymentCase().Set(deployment);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<Deployment, T> deployment);

        [JsonConverter(typeof(UnionTypeCaseConverter<DeploymentCase, Deployment>))]
        private sealed class DeploymentCase : V1ContainersRequestDeployment, ICaseValue<DeploymentCase, Deployment>
        {
            public Deployment _value;

            public override T Match<T>(Func<Deployment, T> deployment)
            {
                return deployment(_value);
            }

            public DeploymentCase Set(Deployment value)
            {
                _value = value;
                return this;
            }

            public Deployment Get()
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