// <copyright file="TwoFactorAuthRecovery.cs" company="APIMatic">
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
    /// TwoFactorAuthRecovery.
    /// </summary>
    public class TwoFactorAuthRecovery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthRecovery"/> class.
        /// </summary>
        public TwoFactorAuthRecovery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFactorAuthRecovery"/> class.
        /// </summary>
        /// <param name="recoveryCodes">recovery_codes.</param>
        /// <param name="totpPasscode">totp_passcode.</param>
        public TwoFactorAuthRecovery(
            List<string> recoveryCodes,
            string totpPasscode)
        {
            this.RecoveryCodes = recoveryCodes;
            this.TotpPasscode = totpPasscode;
        }

        /// <summary>
        /// Gets or sets RecoveryCodes.
        /// </summary>
        [JsonProperty("recovery_codes")]
        public List<string> RecoveryCodes { get; set; }

        /// <summary>
        /// Gets or sets TotpPasscode.
        /// </summary>
        [JsonProperty("totp_passcode")]
        public string TotpPasscode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TwoFactorAuthRecovery : ({string.Join(", ", toStringOutput)})";
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
            return obj is TwoFactorAuthRecovery other &&                ((this.RecoveryCodes == null && other.RecoveryCodes == null) || (this.RecoveryCodes?.Equals(other.RecoveryCodes) == true)) &&
                ((this.TotpPasscode == null && other.TotpPasscode == null) || (this.TotpPasscode?.Equals(other.TotpPasscode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RecoveryCodes = {(this.RecoveryCodes == null ? "null" : $"[{string.Join(", ", this.RecoveryCodes)} ]")}");
            toStringOutput.Add($"this.TotpPasscode = {(this.TotpPasscode == null ? "null" : this.TotpPasscode)}");
        }
    }
}