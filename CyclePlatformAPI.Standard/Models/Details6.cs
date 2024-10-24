// <copyright file="Details6.cs" company="APIMatic">
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
    /// Details6.
    /// </summary>
    public class Details6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details6"/> class.
        /// </summary>
        public Details6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details6"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="url">url.</param>
        /// <param name="existing">existing.</param>
        /// <param name="username">username.</param>
        /// <param name="token">token.</param>
        /// <param name="password">password.</param>
        public Details6(
            string target,
            string url,
            Models.ExistingSource existing = null,
            string username = null,
            string token = null,
            string password = null)
        {
            this.Existing = existing;
            this.Target = target;
            this.Url = url;
            this.Username = username;
            this.Token = token;
            this.Password = password;
        }

        /// <summary>
        /// In a stack, specifies an image source ID from which Cycle will derive any values not specified in the stack file. This is useful for avoiding direct placement of credentials in a stack file, for example.
        /// </summary>
        [JsonProperty("existing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExistingSource Existing { get; set; }

        /// <summary>
        /// The image name on the registry.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }

        /// <summary>
        /// The url of the remote registry.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

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

        /// <summary>
        /// For authentication, a password.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details6 other &&                ((this.Existing == null && other.Existing == null) || (this.Existing?.Equals(other.Existing) == true)) &&
                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Existing = {(this.Existing == null ? "null" : this.Existing.ToString())}");
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}