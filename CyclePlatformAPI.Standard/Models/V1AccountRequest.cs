// <copyright file="V1AccountRequest.cs" company="APIMatic">
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
    /// V1AccountRequest.
    /// </summary>
    public class V1AccountRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountRequest"/> class.
        /// </summary>
        public V1AccountRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="allowSupportLogin">allow_support_login.</param>
        public V1AccountRequest(
            Models.Name1 name = null,
            bool? allowSupportLogin = null)
        {
            this.Name = name;
            this.AllowSupportLogin = allowSupportLogin;
        }

        /// <summary>
        /// The new name on the Account.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Name1 Name { get; set; }

        /// <summary>
        /// If true, Cycle employees will have the ability, upon consent, to access the account for support purposes. This access will be logged.
        /// </summary>
        [JsonProperty("allow_support_login", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSupportLogin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1AccountRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1AccountRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.AllowSupportLogin == null && other.AllowSupportLogin == null) || (this.AllowSupportLogin?.Equals(other.AllowSupportLogin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.AllowSupportLogin = {(this.AllowSupportLogin == null ? "null" : this.AllowSupportLogin.ToString())}");
        }
    }
}