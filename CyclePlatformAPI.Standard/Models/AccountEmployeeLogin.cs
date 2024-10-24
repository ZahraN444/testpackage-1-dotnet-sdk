// <copyright file="AccountEmployeeLogin.cs" company="APIMatic">
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
    /// AccountEmployeeLogin.
    /// </summary>
    public class AccountEmployeeLogin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEmployeeLogin"/> class.
        /// </summary>
        public AccountEmployeeLogin()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEmployeeLogin"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="account">account.</param>
        /// <param name="time">time.</param>
        /// <param name="type">type.</param>
        /// <param name="success">success.</param>
        /// <param name="employee">employee.</param>
        public AccountEmployeeLogin(
            string id,
            Models.AccountLoginInfo account,
            DateTime time,
            Models.Type1Enum type,
            bool success,
            Models.Employee employee = null)
        {
            this.Id = id;
            this.Account = account;
            this.Time = time;
            this.Type = type;
            this.Success = success;
            this.Employee = employee;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Details of an Account login.
        /// </summary>
        [JsonProperty("account")]
        [JsonRequired]
        public Models.AccountLoginInfo Account { get; set; }

        /// <summary>
        /// A timestamp of the time the login occurred.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        [JsonRequired]
        public DateTime Time { get; set; }

        /// <summary>
        /// The type of login mechanism used.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type1Enum Type { get; set; }

        /// <summary>
        /// A boolean where true reflects that the login was successful.
        /// </summary>
        [JsonProperty("success")]
        [JsonRequired]
        public bool Success { get; set; }

        /// <summary>
        /// If this was an employee login, contains information about who accessed the Account.
        /// </summary>
        [JsonProperty("employee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Employee Employee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountEmployeeLogin : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountEmployeeLogin other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Account == null && other.Account == null) || (this.Account?.Equals(other.Account) == true)) &&
                this.Time.Equals(other.Time) &&
                this.Type.Equals(other.Type) &&
                this.Success.Equals(other.Success) &&
                ((this.Employee == null && other.Employee == null) || (this.Employee?.Equals(other.Employee) == true));
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
            toStringOutput.Add($"this.Employee = {(this.Employee == null ? "null" : this.Employee.ToString())}");
        }
    }
}