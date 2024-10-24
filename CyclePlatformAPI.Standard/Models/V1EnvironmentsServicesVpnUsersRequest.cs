// <copyright file="V1EnvironmentsServicesVpnUsersRequest.cs" company="APIMatic">
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
    /// V1EnvironmentsServicesVpnUsersRequest.
    /// </summary>
    public class V1EnvironmentsServicesVpnUsersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesVpnUsersRequest"/> class.
        /// </summary>
        public V1EnvironmentsServicesVpnUsersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesVpnUsersRequest"/> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        public V1EnvironmentsServicesVpnUsersRequest(
            string username,
            string password)
        {
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsServicesVpnUsersRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsServicesVpnUsersRequest other &&                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}