// <copyright file="HubMembershipPreferences.cs" company="APIMatic">
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
    /// HubMembershipPreferences.
    /// </summary>
    public class HubMembershipPreferences
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipPreferences"/> class.
        /// </summary>
        public HubMembershipPreferences()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipPreferences"/> class.
        /// </summary>
        /// <param name="portal">portal.</param>
        /// <param name="email">email.</param>
        public HubMembershipPreferences(
            Models.Portal portal,
            Models.Email1 email)
        {
            this.Portal = portal;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets Portal.
        /// </summary>
        [JsonProperty("portal")]
        public Models.Portal Portal { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public Models.Email1 Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubMembershipPreferences : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubMembershipPreferences other &&                ((this.Portal == null && other.Portal == null) || (this.Portal?.Equals(other.Portal) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Portal = {(this.Portal == null ? "null" : this.Portal.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email.ToString())}");
        }
    }
}