// <copyright file="RepoAuth.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RepoAuth>),
        new Type[] {
            typeof(HTTPSourceCredentialsCase),
            typeof(SSHSourceCredentialsCase)
        },
        true
    )]
    public abstract class RepoAuth
    {
        /// <summary>
        /// This is HTTPSourceCredentials case.
        /// </summary>
        /// <returns>
        /// The RepoAuth instance, wrapping the provided HTTPSourceCredentials value.
        /// </returns>
        public static RepoAuth FromHTTPSourceCredentials(HTTPSourceCredentials hTTPSourceCredentials)
        {
            return new HTTPSourceCredentialsCase().Set(hTTPSourceCredentials);
        }

        /// <summary>
        /// This is SSHSourceCredentials case.
        /// </summary>
        /// <returns>
        /// The RepoAuth instance, wrapping the provided SSHSourceCredentials value.
        /// </returns>
        public static RepoAuth FromSSHSourceCredentials(SSHSourceCredentials sSHSourceCredentials)
        {
            return new SSHSourceCredentialsCase().Set(sSHSourceCredentials);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<HTTPSourceCredentials, T> hTTPSourceCredentials, Func<SSHSourceCredentials, T> sSHSourceCredentials);

        [JsonConverter(typeof(UnionTypeCaseConverter<HTTPSourceCredentialsCase, HTTPSourceCredentials>))]
        private sealed class HTTPSourceCredentialsCase : RepoAuth, ICaseValue<HTTPSourceCredentialsCase, HTTPSourceCredentials>
        {
            public HTTPSourceCredentials _value;

            public override T Match<T>(Func<HTTPSourceCredentials, T> hTTPSourceCredentials, Func<SSHSourceCredentials, T> sSHSourceCredentials)
            {
                return hTTPSourceCredentials(_value);
            }

            public HTTPSourceCredentialsCase Set(HTTPSourceCredentials value)
            {
                _value = value;
                return this;
            }

            public HTTPSourceCredentials Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SSHSourceCredentialsCase, SSHSourceCredentials>))]
        private sealed class SSHSourceCredentialsCase : RepoAuth, ICaseValue<SSHSourceCredentialsCase, SSHSourceCredentials>
        {
            public SSHSourceCredentials _value;

            public override T Match<T>(Func<HTTPSourceCredentials, T> hTTPSourceCredentials, Func<SSHSourceCredentials, T> sSHSourceCredentials)
            {
                return sSHSourceCredentials(_value);
            }

            public SSHSourceCredentialsCase Set(SSHSourceCredentials value)
            {
                _value = value;
                return this;
            }

            public SSHSourceCredentials Get()
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