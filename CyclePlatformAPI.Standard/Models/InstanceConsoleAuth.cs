// <copyright file="InstanceConsoleAuth.cs" company="APIMatic">
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
    /// InstanceConsoleAuth.
    /// </summary>
    public class InstanceConsoleAuth
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceConsoleAuth"/> class.
        /// </summary>
        public InstanceConsoleAuth()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceConsoleAuth"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="address">address.</param>
        public InstanceConsoleAuth(
            string token,
            string address)
        {
            this.Token = token;
            this.Address = address;
        }

        /// <summary>
        /// A token used for connecting to the Instance console.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The protocol and url for connecting to the Instance console.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceConsoleAuth : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceConsoleAuth other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
        }
    }
}