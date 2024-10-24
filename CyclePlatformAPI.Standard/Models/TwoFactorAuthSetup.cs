// <copyright file="TwoFactorAuthSetup.cs" company="APIMatic">
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
    /// TwoFactorAuthSetup.
    /// </summary>
    public class TwoFactorAuthSetup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthSetup"/> class.
        /// </summary>
        public TwoFactorAuthSetup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthSetup"/> class.
        /// </summary>
        /// <param name="qr">qr.</param>
        /// <param name="secret">secret.</param>
        public TwoFactorAuthSetup(
            string qr,
            string secret)
        {
            this.Qr = qr;
            this.Secret = secret;
        }

        /// <summary>
        /// Gets or sets Qr.
        /// </summary>
        [JsonProperty("qr")]
        public string Qr { get; set; }

        /// <summary>
        /// Gets or sets Secret.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorAuthSetup : ({string.Join(", ", toStringOutput)})";
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
            return obj is TwoFactorAuthSetup other &&                ((this.Qr == null && other.Qr == null) || (this.Qr?.Equals(other.Qr) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Qr = {(this.Qr == null ? "null" : this.Qr)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
        }
    }
}