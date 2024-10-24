// <copyright file="ContainerImageSummary1Service.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ContainerImageSummary1Service>),
        new Type[] {
            typeof(ServiceContainerIdentifierCase)
        },
        false
    )]
    public abstract class ContainerImageSummary1Service
    {
        /// <summary>
        /// This is ServiceContainerIdentifier case.
        /// </summary>
        /// <returns>
        /// The ContainerImageSummary1Service instance, wrapping the provided ServiceContainerIdentifierEnum value.
        /// </returns>
        public static ContainerImageSummary1Service FromServiceContainerIdentifier(ServiceContainerIdentifierEnum serviceContainerIdentifier)
        {
            return new ServiceContainerIdentifierCase().Set(serviceContainerIdentifier);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<ServiceContainerIdentifierEnum, T> serviceContainerIdentifier);

        [JsonConverter(typeof(UnionTypeCaseConverter<ServiceContainerIdentifierCase, ServiceContainerIdentifierEnum>))]
        private sealed class ServiceContainerIdentifierCase : ContainerImageSummary1Service, ICaseValue<ServiceContainerIdentifierCase, ServiceContainerIdentifierEnum>
        {
            public ServiceContainerIdentifierEnum _value;

            public override T Match<T>(Func<ServiceContainerIdentifierEnum, T> serviceContainerIdentifier)
            {
                return serviceContainerIdentifier(_value);
            }

            public ServiceContainerIdentifierCase Set(ServiceContainerIdentifierEnum value)
            {
                _value = value;
                return this;
            }

            public ServiceContainerIdentifierEnum Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }
    }
}