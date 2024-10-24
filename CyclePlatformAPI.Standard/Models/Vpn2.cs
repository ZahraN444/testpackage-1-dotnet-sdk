// <copyright file="Vpn2.cs" company="APIMatic">
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
    /// Vpn2.
    /// </summary>
    public class Vpn2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vpn2"/> class.
        /// </summary>
        public Vpn2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vpn2"/> class.
        /// </summary>
        /// <param name="auth">auth.</param>
        /// <param name="allowInternet">allow_internet.</param>
        public Vpn2(
            Models.Auth1 auth,
            bool allowInternet)
        {
            this.Auth = auth;
            this.AllowInternet = allowInternet;
        }

        /// <summary>
        /// Gets or sets Auth.
        /// </summary>
        [JsonProperty("auth")]
        public Models.Auth1 Auth { get; set; }

        /// <summary>
        /// Gets or sets AllowInternet.
        /// </summary>
        [JsonProperty("allow_internet")]
        public bool AllowInternet { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Vpn2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Vpn2 other &&                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true)) &&
                this.AllowInternet.Equals(other.AllowInternet);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
            toStringOutput.Add($"this.AllowInternet = {this.AllowInternet}");
        }
    }
}