// <copyright file="V1EnvironmentsScopedVariablesRequest1Source.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<V1EnvironmentsScopedVariablesRequest1Source>),
        new Type[] {
            typeof(RawScopedVariableSourceCase),
            typeof(URLScopedVariableSourceCase)
        },
        true
    )]
    public abstract class V1EnvironmentsScopedVariablesRequest1Source
    {
        /// <summary>
        /// This is RawScopedVariableSource case.
        /// </summary>
        /// <returns>
        /// The V1EnvironmentsScopedVariablesRequest1Source instance, wrapping the provided RawScopedVariableSource value.
        /// </returns>
        public static V1EnvironmentsScopedVariablesRequest1Source FromRawScopedVariableSource(RawScopedVariableSource rawScopedVariableSource)
        {
            return new RawScopedVariableSourceCase().Set(rawScopedVariableSource);
        }

        /// <summary>
        /// This is URLScopedVariableSource case.
        /// </summary>
        /// <returns>
        /// The V1EnvironmentsScopedVariablesRequest1Source instance, wrapping the provided URLScopedVariableSource value.
        /// </returns>
        public static V1EnvironmentsScopedVariablesRequest1Source FromURLScopedVariableSource(URLScopedVariableSource uRLScopedVariableSource)
        {
            return new URLScopedVariableSourceCase().Set(uRLScopedVariableSource);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RawScopedVariableSource, T> rawScopedVariableSource, Func<URLScopedVariableSource, T> uRLScopedVariableSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<RawScopedVariableSourceCase, RawScopedVariableSource>))]
        private sealed class RawScopedVariableSourceCase : V1EnvironmentsScopedVariablesRequest1Source, ICaseValue<RawScopedVariableSourceCase, RawScopedVariableSource>
        {
            public RawScopedVariableSource _value;

            public override T Match<T>(Func<RawScopedVariableSource, T> rawScopedVariableSource, Func<URLScopedVariableSource, T> uRLScopedVariableSource)
            {
                return rawScopedVariableSource(_value);
            }

            public RawScopedVariableSourceCase Set(RawScopedVariableSource value)
            {
                _value = value;
                return this;
            }

            public RawScopedVariableSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<URLScopedVariableSourceCase, URLScopedVariableSource>))]
        private sealed class URLScopedVariableSourceCase : V1EnvironmentsScopedVariablesRequest1Source, ICaseValue<URLScopedVariableSourceCase, URLScopedVariableSource>
        {
            public URLScopedVariableSource _value;

            public override T Match<T>(Func<RawScopedVariableSource, T> rawScopedVariableSource, Func<URLScopedVariableSource, T> uRLScopedVariableSource)
            {
                return uRLScopedVariableSource(_value);
            }

            public URLScopedVariableSourceCase Set(URLScopedVariableSource value)
            {
                _value = value;
                return this;
            }

            public URLScopedVariableSource Get()
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