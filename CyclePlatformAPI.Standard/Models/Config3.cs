// <copyright file="Config3.cs" company="APIMatic">
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
    /// Config3.
    /// </summary>
    public class Config3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config3"/> class.
        /// </summary>
        public Config3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config3"/> class.
        /// </summary>
        /// <param name="allowInternet">allow_internet.</param>
        /// <param name="auth">auth.</param>
        public Config3(
            bool allowInternet,
            Models.Auth auth)
        {
            this.AllowInternet = allowInternet;
            this.Auth = auth;
        }

        /// <summary>
        /// If true, routes all traffic through the VPN, even non-Cycle traffic.
        /// </summary>
        [JsonProperty("allow_internet")]
        public bool AllowInternet { get; set; }

        /// <summary>
        /// Auth configuration for the VPN.
        /// </summary>
        [JsonProperty("auth")]
        public Models.Auth Auth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config3 other &&                this.AllowInternet.Equals(other.AllowInternet) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllowInternet = {this.AllowInternet}");
            toStringOutput.Add($"this.Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
        }
    }
}