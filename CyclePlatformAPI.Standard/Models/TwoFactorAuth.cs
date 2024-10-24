// <copyright file="TwoFactorAuth.cs" company="APIMatic">
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
    /// TwoFactorAuth.
    /// </summary>
    public class TwoFactorAuth
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuth"/> class.
        /// </summary>
        public TwoFactorAuth()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuth"/> class.
        /// </summary>
        /// <param name="verified">verified.</param>
        public TwoFactorAuth(
            bool verified)
        {
            this.Verified = verified;
        }

        /// <summary>
        /// A boolean representing if the Account has verified with two-factor authentication.
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorAuth : ({string.Join(", ", toStringOutput)})";
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
            return obj is TwoFactorAuth other &&                this.Verified.Equals(other.Verified);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Verified = {this.Verified}");
        }
    }
}