// <copyright file="Config6.cs" company="APIMatic">
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
    /// Config6.
    /// </summary>
    public class Config6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config6"/> class.
        /// </summary>
        public Config6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config6"/> class.
        /// </summary>
        /// <param name="allowInternet">allow_internet.</param>
        /// <param name="auth">auth.</param>
        public Config6(
            bool? allowInternet = null,
            Models.Auth auth = null)
        {
            this.AllowInternet = allowInternet;
            this.Auth = auth;
        }

        /// <summary>
        /// If true, routes all traffic through the VPN, even non-Cycle traffic.
        /// </summary>
        [JsonProperty("allow_internet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowInternet { get; set; }

        /// <summary>
        /// Auth configuration for the VPN.
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Auth Auth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config6 other &&                ((this.AllowInternet == null && other.AllowInternet == null) || (this.AllowInternet?.Equals(other.AllowInternet) == true)) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllowInternet = {(this.AllowInternet == null ? "null" : this.AllowInternet.ToString())}");
            toStringOutput.Add($"this.Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
        }
    }
}