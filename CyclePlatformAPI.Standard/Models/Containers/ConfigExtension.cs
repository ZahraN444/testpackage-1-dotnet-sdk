// <copyright file="ConfigExtension.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ConfigExtension>),
        new Type[] {
            typeof(TcpRouterConfigCase),
            typeof(HttpRouterConfigCase)
        },
        true
    )]
    public abstract class ConfigExtension
    {
        /// <summary>
        /// This is TcpRouterConfig case.
        /// </summary>
        /// <returns>
        /// The ConfigExtension instance, wrapping the provided TcpRouterConfig value.
        /// </returns>
        public static ConfigExtension FromTcpRouterConfig(TcpRouterConfig tcpRouterConfig)
        {
            return new TcpRouterConfigCase().Set(tcpRouterConfig);
        }

        /// <summary>
        /// This is HttpRouterConfig case.
        /// </summary>
        /// <returns>
        /// The ConfigExtension instance, wrapping the provided HttpRouterConfig value.
        /// </returns>
        public static ConfigExtension FromHttpRouterConfig(HttpRouterConfig httpRouterConfig)
        {
            return new HttpRouterConfigCase().Set(httpRouterConfig);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<TcpRouterConfig, T> tcpRouterConfig, Func<HttpRouterConfig, T> httpRouterConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<TcpRouterConfigCase, TcpRouterConfig>))]
        private sealed class TcpRouterConfigCase : ConfigExtension, ICaseValue<TcpRouterConfigCase, TcpRouterConfig>
        {
            public TcpRouterConfig _value;

            public override T Match<T>(Func<TcpRouterConfig, T> tcpRouterConfig, Func<HttpRouterConfig, T> httpRouterConfig)
            {
                return tcpRouterConfig(_value);
            }

            public TcpRouterConfigCase Set(TcpRouterConfig value)
            {
                _value = value;
                return this;
            }

            public TcpRouterConfig Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<HttpRouterConfigCase, HttpRouterConfig>))]
        private sealed class HttpRouterConfigCase : ConfigExtension, ICaseValue<HttpRouterConfigCase, HttpRouterConfig>
        {
            public HttpRouterConfig _value;

            public override T Match<T>(Func<TcpRouterConfig, T> tcpRouterConfig, Func<HttpRouterConfig, T> httpRouterConfig)
            {
                return httpRouterConfig(_value);
            }

            public HttpRouterConfigCase Set(HttpRouterConfig value)
            {
                _value = value;
                return this;
            }

            public HttpRouterConfig Get()
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