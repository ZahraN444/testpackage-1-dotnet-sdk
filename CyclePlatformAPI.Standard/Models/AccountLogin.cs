// <copyright file="AccountLogin.cs" company="APIMatic">
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
    /// AccountLogin.
    /// </summary>
    public class AccountLogin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLogin"/> class.
        /// </summary>
        public AccountLogin()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLogin"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="account">account.</param>
        /// <param name="time">time.</param>
        /// <param name="type">type.</param>
        /// <param name="success">success.</param>
        public AccountLogin(
            string id,
            Models.AccountLoginInfo account,
            DateTime time,
            Models.Type1Enum type,
            bool success)
        {
            this.Id = id;
            this.Account = account;
            this.Time = time;
            this.Type = type;
            this.Success = success;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Details of an Account login.
        /// </summary>
        [JsonProperty("account")]
        public Models.AccountLoginInfo Account { get; set; }

        /// <summary>
        /// A timestamp of the time the login occurred.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// The type of login mechanism used.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type1Enum Type { get; set; }

        /// <summary>
        /// A boolean where true reflects that the login was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLogin : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLogin other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true)) &&
                this.Time.Equals(other.Time) &&
                this.Type.Equals(other.Type) &&
                this.Success.Equals(other.Success);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Account = {(this.Account == null ? "null" : this.Account.ToString())}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Success = {this.Success}");
        }
    }
}