// <copyright file="StackSpecTestContainerImage.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackSpecTestContainerImage>),
        new Type[] {
            typeof(StackSpecContainerImageCase)
        },
        false
    )]
    public abstract class StackSpecTestContainerImage
    {
        /// <summary>
        /// This is StackSpecContainerImage case.
        /// </summary>
        /// <returns>
        /// The StackSpecTestContainerImage instance, wrapping the provided StackSpecContainerImage value.
        /// </returns>
        public static StackSpecTestContainerImage FromStackSpecContainerImage(StackSpecContainerImage stackSpecContainerImage)
        {
            return new StackSpecContainerImageCase().Set(stackSpecContainerImage);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackSpecContainerImage, T> stackSpecContainerImage);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackSpecContainerImageCase, StackSpecContainerImage>))]
        private sealed class StackSpecContainerImageCase : StackSpecTestContainerImage, ICaseValue<StackSpecContainerImageCase, StackSpecContainerImage>
        {
            public StackSpecContainerImage _value;

            public override T Match<T>(Func<StackSpecContainerImage, T> stackSpecContainerImage)
            {
                return stackSpecContainerImage(_value);
            }

            public StackSpecContainerImageCase Set(StackSpecContainerImage value)
            {
                _value = value;
                return this;
            }

            public StackSpecContainerImage Get()
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