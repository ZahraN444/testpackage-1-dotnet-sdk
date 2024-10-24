// <copyright file="StackSpecScopedVariableSource.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackSpecScopedVariableSource>),
        new Type[] {
            typeof(StackSpecScopedVaribaleUrlSourceCase),
            typeof(StackSpecScopedVariableRawSourceCase)
        },
        true
    )]
    public abstract class StackSpecScopedVariableSource
    {
        /// <summary>
        /// This is StackSpecScopedVaribaleUrlSource case.
        /// </summary>
        /// <returns>
        /// The StackSpecScopedVariableSource instance, wrapping the provided StackSpecScopedVaribaleUrlSource value.
        /// </returns>
        public static StackSpecScopedVariableSource FromStackSpecScopedVaribaleUrlSource(StackSpecScopedVaribaleUrlSource stackSpecScopedVaribaleUrlSource)
        {
            return new StackSpecScopedVaribaleUrlSourceCase().Set(stackSpecScopedVaribaleUrlSource);
        }

        /// <summary>
        /// This is StackSpecScopedVariableRawSource case.
        /// </summary>
        /// <returns>
        /// The StackSpecScopedVariableSource instance, wrapping the provided StackSpecScopedVariableRawSource value.
        /// </returns>
        public static StackSpecScopedVariableSource FromStackSpecScopedVariableRawSource(StackSpecScopedVariableRawSource stackSpecScopedVariableRawSource)
        {
            return new StackSpecScopedVariableRawSourceCase().Set(stackSpecScopedVariableRawSource);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<StackSpecScopedVaribaleUrlSource, T> stackSpecScopedVaribaleUrlSource, Func<StackSpecScopedVariableRawSource, T> stackSpecScopedVariableRawSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackSpecScopedVaribaleUrlSourceCase, StackSpecScopedVaribaleUrlSource>))]
        private sealed class StackSpecScopedVaribaleUrlSourceCase : StackSpecScopedVariableSource, ICaseValue<StackSpecScopedVaribaleUrlSourceCase, StackSpecScopedVaribaleUrlSource>
        {
            public StackSpecScopedVaribaleUrlSource _value;

            public override T Match<T>(Func<StackSpecScopedVaribaleUrlSource, T> stackSpecScopedVaribaleUrlSource, Func<StackSpecScopedVariableRawSource, T> stackSpecScopedVariableRawSource)
            {
                return stackSpecScopedVaribaleUrlSource(_value);
            }

            public StackSpecScopedVaribaleUrlSourceCase Set(StackSpecScopedVaribaleUrlSource value)
            {
                _value = value;
                return this;
            }

            public StackSpecScopedVaribaleUrlSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackSpecScopedVariableRawSourceCase, StackSpecScopedVariableRawSource>))]
        private sealed class StackSpecScopedVariableRawSourceCase : StackSpecScopedVariableSource, ICaseValue<StackSpecScopedVariableRawSourceCase, StackSpecScopedVariableRawSource>
        {
            public StackSpecScopedVariableRawSource _value;

            public override T Match<T>(Func<StackSpecScopedVaribaleUrlSource, T> stackSpecScopedVaribaleUrlSource, Func<StackSpecScopedVariableRawSource, T> stackSpecScopedVariableRawSource)
            {
                return stackSpecScopedVariableRawSource(_value);
            }

            public StackSpecScopedVariableRawSourceCase Set(StackSpecScopedVariableRawSource value)
            {
                _value = value;
                return this;
            }

            public StackSpecScopedVariableRawSource Get()
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