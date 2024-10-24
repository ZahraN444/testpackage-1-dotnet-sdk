// <copyright file="AccountEmail.cs" company="APIMatic">
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
    /// AccountEmail.
    /// </summary>
    public class AccountEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEmail"/> class.
        /// </summary>
        public AccountEmail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountEmail"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="verified">verified.</param>
        /// <param name="added">added.</param>
        public AccountEmail(
            string address,
            bool verified,
            DateTime added)
        {
            this.Address = address;
            this.Verified = verified;
            this.Added = added;
        }

        /// <summary>
        /// The email address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// A boolean representing if the email has been verified
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or sets Added.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("added")]
        public DateTime Added { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountEmail : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountEmail other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                this.Verified.Equals(other.Verified) &&
                this.Added.Equals(other.Added);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Verified = {this.Verified}");
            toStringOutput.Add($"this.Added = {this.Added}");
        }
    }
}