// <copyright file="V1Account2faRecoverRequest.cs" company="APIMatic">
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
    /// V1Account2faRecoverRequest.
    /// </summary>
    public class V1Account2faRecoverRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Account2faRecoverRequest"/> class.
        /// </summary>
        public V1Account2faRecoverRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1Account2faRecoverRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="recoveryCodes">recovery_codes.</param>
        /// <param name="token">token.</param>
        public V1Account2faRecoverRequest(
            string email,
            string password,
            List<string> recoveryCodes,
            string token = null)
        {
            this.Email = email;
            this.Password = password;
            this.RecoveryCodes = recoveryCodes;
            this.Token = token;
        }

        /// <summary>
        /// The user's email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets RecoveryCodes.
        /// </summary>
        [JsonProperty("recovery_codes")]
        public List<string> RecoveryCodes { get; set; }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1Account2faRecoverRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1Account2faRecoverRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.RecoveryCodes == null && other.RecoveryCodes == null) || (this.RecoveryCodes?.Equals(other.RecoveryCodes) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
            toStringOutput.Add($"this.RecoveryCodes = {(this.RecoveryCodes == null ? "null" : $"[{string.Join(", ", this.RecoveryCodes)} ]")}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
        }
    }
}