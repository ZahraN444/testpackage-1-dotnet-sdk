// <copyright file="Account.cs" company="APIMatic">
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
    /// Account.
    /// </summary>
    public class Account
    {
        private Models.TwoFactorAuth twoFactorAuth;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "two_factor_auth", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="twoFactorAuth">two_factor_auth.</param>
        /// <param name="allowSupportLogin">allow_support_login.</param>
        public Account(
            string id,
            Models.Name name,
            Models.Email email,
            Models.AccountState state,
            Models.AccountEvents events,
            Models.TwoFactorAuth twoFactorAuth = null,
            bool? allowSupportLogin = null)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            if (twoFactorAuth != null)
            {
                this.TwoFactorAuth = twoFactorAuth;
            }

            this.AllowSupportLogin = allowSupportLogin;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The first and last name associated with the Account.
        /// </summary>
        [JsonProperty("name")]
        public Models.Name Name { get; set; }

        /// <summary>
        /// Information about the email address associated with the Account.
        /// </summary>
        [JsonProperty("email")]
        public Models.Email Email { get; set; }

        /// <summary>
        /// Two factor auth verification information.
        /// </summary>
        [JsonProperty("two_factor_auth")]
        public Models.TwoFactorAuth TwoFactorAuth
        {
            get
            {
                return this.twoFactorAuth;
            }

            set
            {
                this.shouldSerialize["two_factor_auth"] = true;
                this.twoFactorAuth = value;
            }
        }

        /// <summary>
        /// Indicates whether or not Cycle employees have authorization to log in to this Account in a support capacity.
        /// </summary>
        [JsonProperty("allow_support_login", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSupportLogin { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.AccountState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the Account's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.AccountEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Account : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTwoFactorAuth()
        {
            this.shouldSerialize["two_factor_auth"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTwoFactorAuth()
        {
            return this.shouldSerialize["two_factor_auth"];
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
            return obj is Account other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.TwoFactorAuth == null && other.TwoFactorAuth == null) || (this.TwoFactorAuth?.Equals(other.TwoFactorAuth) == true)) &&
                ((this.AllowSupportLogin == null && other.AllowSupportLogin == null) || (this.AllowSupportLogin?.Equals(other.AllowSupportLogin) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email.ToString())}");
            toStringOutput.Add($"this.TwoFactorAuth = {(this.TwoFactorAuth == null ? "null" : this.TwoFactorAuth.ToString())}");
            toStringOutput.Add($"this.AllowSupportLogin = {(this.AllowSupportLogin == null ? "null" : this.AllowSupportLogin.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}