// <copyright file="ImageSource2.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ImageSource2>),
        new Type[] {
            typeof(DirectImageSourceCase),
            typeof(StackImageSourceCase),
            typeof(BucketImageSourceCase)
        },
        true
    )]
    public abstract class ImageSource2
    {
        /// <summary>
        /// This is DirectImageSource case.
        /// </summary>
        /// <returns>
        /// The ImageSource2 instance, wrapping the provided DirectImageSource value.
        /// </returns>
        public static ImageSource2 FromDirectImageSource(DirectImageSource directImageSource)
        {
            return new DirectImageSourceCase().Set(directImageSource);
        }

        /// <summary>
        /// This is StackImageSource case.
        /// </summary>
        /// <returns>
        /// The ImageSource2 instance, wrapping the provided StackImageSource value.
        /// </returns>
        public static ImageSource2 FromStackImageSource(StackImageSource stackImageSource)
        {
            return new StackImageSourceCase().Set(stackImageSource);
        }

        /// <summary>
        /// This is BucketImageSource case.
        /// </summary>
        /// <returns>
        /// The ImageSource2 instance, wrapping the provided BucketImageSource value.
        /// </returns>
        public static ImageSource2 FromBucketImageSource(BucketImageSource bucketImageSource)
        {
            return new BucketImageSourceCase().Set(bucketImageSource);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<DirectImageSource, T> directImageSource,
            Func<StackImageSource, T> stackImageSource,
            Func<BucketImageSource, T> bucketImageSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<DirectImageSourceCase, DirectImageSource>))]
        private sealed class DirectImageSourceCase : ImageSource2, ICaseValue<DirectImageSourceCase, DirectImageSource>
        {
            public DirectImageSource _value;

            public override T Match<T>(
                Func<DirectImageSource, T> directImageSource,
                Func<StackImageSource, T> stackImageSource,
                Func<BucketImageSource, T> bucketImageSource)
            {
                return directImageSource(_value);
            }

            public DirectImageSourceCase Set(DirectImageSource value)
            {
                _value = value;
                return this;
            }

            public DirectImageSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackImageSourceCase, StackImageSource>))]
        private sealed class StackImageSourceCase : ImageSource2, ICaseValue<StackImageSourceCase, StackImageSource>
        {
            public StackImageSource _value;

            public override T Match<T>(
                Func<DirectImageSource, T> directImageSource,
                Func<StackImageSource, T> stackImageSource,
                Func<BucketImageSource, T> bucketImageSource)
            {
                return stackImageSource(_value);
            }

            public StackImageSourceCase Set(StackImageSource value)
            {
                _value = value;
                return this;
            }

            public StackImageSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BucketImageSourceCase, BucketImageSource>))]
        private sealed class BucketImageSourceCase : ImageSource2, ICaseValue<BucketImageSourceCase, BucketImageSource>
        {
            public BucketImageSource _value;

            public override T Match<T>(
                Func<DirectImageSource, T> directImageSource,
                Func<StackImageSource, T> stackImageSource,
                Func<BucketImageSource, T> bucketImageSource)
            {
                return bucketImageSource(_value);
            }

            public BucketImageSourceCase Set(BucketImageSource value)
            {
                _value = value;
                return this;
            }

            public BucketImageSource Get()
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