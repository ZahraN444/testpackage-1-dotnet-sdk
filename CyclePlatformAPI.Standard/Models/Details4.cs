// <copyright file="Details4.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Details4.
    /// </summary>
    public class Details4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details4"/> class.
        /// </summary>
        public Details4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details4"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="existing">existing.</param>
        /// <param name="username">username.</param>
        /// <param name="token">token.</param>
        public Details4(
            string target,
            Details4Existing existing = null,
            string username = null,
            string token = null)
        {
            this.Existing = existing;
            this.Target = target;
            this.Username = username;
            this.Token = token;
        }

        /// <summary>
        /// Gets or sets Existing.
        /// </summary>
        [JsonProperty("existing", NullValueHandling = NullValueHandling.Ignore)]
        public Details4Existing Existing { get; set; }

        /// <summary>
        /// The DockerHub target string. ex - `mysql:5.7`
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }

        /// <summary>
        /// For authentication, a username.
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// For authentication, a token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details4 other &&                ((this.Existing == null && other.Existing == null) || (this.Existing?.Equals(other.Existing) == true)) &&
                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Existing = {(this.Existing == null ? "null" : this.Existing.ToString())}");
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
        }
    }
}