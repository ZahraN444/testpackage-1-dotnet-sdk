// <copyright file="Details13.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Details13.
    /// </summary>
    public class Details13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details13"/> class.
        /// </summary>
        public Details13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details13"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="headers">headers.</param>
        /// <param name="authTokenUrl">auth_token_url.</param>
        public Details13(
            string url,
            object headers,
            string authTokenUrl = null)
        {
            this.Url = url;
            this.Headers = headers;
            this.AuthTokenUrl = authTokenUrl;
        }

        /// <summary>
        /// The URL to call to produce the value.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Additional headers that can be attached to the URL request. Useful for adding metadata to third-party services.
        /// </summary>
        [JsonProperty("headers")]
        public object Headers { get; set; }

        /// <summary>
        /// A URL that can be provided to authenticate with a third party secret service. Cycle will make a request to this URL before fetching the secret URL, and use the response as the value of an Authorization header when requesting the secret.
        /// </summary>
        [JsonProperty("auth_token_url", NullValueHandling = NullValueHandling.Include)]
        public string AuthTokenUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details13 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Details13 other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.AuthTokenUrl == null && other.AuthTokenUrl == null) || (this.AuthTokenUrl?.Equals(other.AuthTokenUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"this.AuthTokenUrl = {(this.AuthTokenUrl == null ? "null" : this.AuthTokenUrl)}");
        }
    }
}