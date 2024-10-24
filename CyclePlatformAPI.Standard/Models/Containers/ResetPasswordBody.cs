// <copyright file="ResetPasswordBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ResetPasswordBody>),
        new Type[] {
            typeof(V1AccountResetPasswordRequestCase),
            typeof(V1AccountResetPasswordRequest1Case)
        },
        true
    )]
    public abstract class ResetPasswordBody
    {
        /// <summary>
        /// This is V1 Account Reset Password Request case.
        /// </summary>
        /// <returns>
        /// The ResetPasswordBody instance, wrapping the provided V1AccountResetPasswordRequest value.
        /// </returns>
        public static ResetPasswordBody FromV1AccountResetPasswordRequest(V1AccountResetPasswordRequest v1AccountResetPasswordRequest)
        {
            return new V1AccountResetPasswordRequestCase().Set(v1AccountResetPasswordRequest);
        }

        /// <summary>
        /// This is V1 Account Reset Password Request1 case.
        /// </summary>
        /// <returns>
        /// The ResetPasswordBody instance, wrapping the provided V1AccountResetPasswordRequest1 value.
        /// </returns>
        public static ResetPasswordBody FromV1AccountResetPasswordRequest1(V1AccountResetPasswordRequest1 v1AccountResetPasswordRequest1)
        {
            return new V1AccountResetPasswordRequest1Case().Set(v1AccountResetPasswordRequest1);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<V1AccountResetPasswordRequest, T> v1AccountResetPasswordRequest, Func<V1AccountResetPasswordRequest1, T> v1AccountResetPasswordRequest1);

        [JsonConverter(typeof(UnionTypeCaseConverter<V1AccountResetPasswordRequestCase, V1AccountResetPasswordRequest>))]
        private sealed class V1AccountResetPasswordRequestCase : ResetPasswordBody, ICaseValue<V1AccountResetPasswordRequestCase, V1AccountResetPasswordRequest>
        {
            public V1AccountResetPasswordRequest _value;

            public override T Match<T>(Func<V1AccountResetPasswordRequest, T> v1AccountResetPasswordRequest, Func<V1AccountResetPasswordRequest1, T> v1AccountResetPasswordRequest1)
            {
                return v1AccountResetPasswordRequest(_value);
            }

            public V1AccountResetPasswordRequestCase Set(V1AccountResetPasswordRequest value)
            {
                _value = value;
                return this;
            }

            public V1AccountResetPasswordRequest Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<V1AccountResetPasswordRequest1Case, V1AccountResetPasswordRequest1>))]
        private sealed class V1AccountResetPasswordRequest1Case : ResetPasswordBody, ICaseValue<V1AccountResetPasswordRequest1Case, V1AccountResetPasswordRequest1>
        {
            public V1AccountResetPasswordRequest1 _value;

            public override T Match<T>(Func<V1AccountResetPasswordRequest, T> v1AccountResetPasswordRequest, Func<V1AccountResetPasswordRequest1, T> v1AccountResetPasswordRequest1)
            {
                return v1AccountResetPasswordRequest1(_value);
            }

            public V1AccountResetPasswordRequest1Case Set(V1AccountResetPasswordRequest1 value)
            {
                _value = value;
                return this;
            }

            public V1AccountResetPasswordRequest1 Get()
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