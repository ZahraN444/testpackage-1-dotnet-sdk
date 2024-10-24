// <copyright file="RepoSourceTypeAuth.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RepoSourceTypeAuth>),
        new Type[] {
            typeof(HTTPSourceCredentialsCase),
            typeof(SSHSourceCredentialsCase)
        },
        true
    )]
    public abstract class RepoSourceTypeAuth
    {
        /// <summary>
        /// This is HTTPSourceCredentials case.
        /// </summary>
        /// <returns>
        /// The RepoSourceTypeAuth instance, wrapping the provided HTTPSourceCredentials value.
        /// </returns>
        public static RepoSourceTypeAuth FromHTTPSourceCredentials(HTTPSourceCredentials hTTPSourceCredentials)
        {
            return new HTTPSourceCredentialsCase().Set(hTTPSourceCredentials);
        }

        /// <summary>
        /// This is SSHSourceCredentials case.
        /// </summary>
        /// <returns>
        /// The RepoSourceTypeAuth instance, wrapping the provided SSHSourceCredentials value.
        /// </returns>
        public static RepoSourceTypeAuth FromSSHSourceCredentials(SSHSourceCredentials sSHSourceCredentials)
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
        private sealed class HTTPSourceCredentialsCase : RepoSourceTypeAuth, ICaseValue<HTTPSourceCredentialsCase, HTTPSourceCredentials>
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
        private sealed class SSHSourceCredentialsCase : RepoSourceTypeAuth, ICaseValue<SSHSourceCredentialsCase, SSHSourceCredentials>
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