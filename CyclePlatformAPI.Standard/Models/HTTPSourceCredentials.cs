// <copyright file="HTTPSourceCredentials.cs" company="APIMatic">
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
    /// HTTPSourceCredentials.
    /// </summary>
    public class HTTPSourceCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPSourceCredentials"/> class.
        /// </summary>
        public HTTPSourceCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPSourceCredentials"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="credentials">credentials.</param>
        public HTTPSourceCredentials(
            string type,
            Models.Credentials credentials)
        {
            this.Type = type;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Authentication credentails for the Dockerfile image source type when authenticating over HTTP.
        /// </summary>
        [JsonProperty("credentials")]
        [JsonRequired]
        public Models.Credentials Credentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HTTPSourceCredentials : ({string.Join(", ", toStringOutput)})";
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
            return obj is HTTPSourceCredentials other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
        }
    }
}