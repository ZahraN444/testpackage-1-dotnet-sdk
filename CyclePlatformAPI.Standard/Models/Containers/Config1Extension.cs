// <copyright file="Config1Extension.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Config1Extension>),
        new Type[] {
            typeof(TcpTransportConfigCase),
            typeof(HttpTransportConfigCase)
        },
        true
    )]
    public abstract class Config1Extension
    {
        /// <summary>
        /// This is TcpTransportConfig case.
        /// </summary>
        /// <returns>
        /// The Config1Extension instance, wrapping the provided TcpTransportConfig value.
        /// </returns>
        public static Config1Extension FromTcpTransportConfig(TcpTransportConfig tcpTransportConfig)
        {
            return new TcpTransportConfigCase().Set(tcpTransportConfig);
        }

        /// <summary>
        /// This is HttpTransportConfig case.
        /// </summary>
        /// <returns>
        /// The Config1Extension instance, wrapping the provided HttpTransportConfig value.
        /// </returns>
        public static Config1Extension FromHttpTransportConfig(HttpTransportConfig httpTransportConfig)
        {
            return new HttpTransportConfigCase().Set(httpTransportConfig);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<TcpTransportConfig, T> tcpTransportConfig, Func<HttpTransportConfig, T> httpTransportConfig);

        [JsonConverter(typeof(UnionTypeCaseConverter<TcpTransportConfigCase, TcpTransportConfig>))]
        private sealed class TcpTransportConfigCase : Config1Extension, ICaseValue<TcpTransportConfigCase, TcpTransportConfig>
        {
            public TcpTransportConfig _value;

            public override T Match<T>(Func<TcpTransportConfig, T> tcpTransportConfig, Func<HttpTransportConfig, T> httpTransportConfig)
            {
                return tcpTransportConfig(_value);
            }

            public TcpTransportConfigCase Set(TcpTransportConfig value)
            {
                _value = value;
                return this;
            }

            public TcpTransportConfig Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<HttpTransportConfigCase, HttpTransportConfig>))]
        private sealed class HttpTransportConfigCase : Config1Extension, ICaseValue<HttpTransportConfigCase, HttpTransportConfig>
        {
            public HttpTransportConfig _value;

            public override T Match<T>(Func<TcpTransportConfig, T> tcpTransportConfig, Func<HttpTransportConfig, T> httpTransportConfig)
            {
                return httpTransportConfig(_value);
            }

            public HttpTransportConfigCase Set(HttpTransportConfig value)
            {
                _value = value;
                return this;
            }

            public HttpTransportConfig Get()
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