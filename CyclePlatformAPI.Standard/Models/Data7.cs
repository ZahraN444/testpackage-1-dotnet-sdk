// <copyright file="Data7.cs" company="APIMatic">
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
    /// Data7.
    /// </summary>
    public class Data7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data7"/> class.
        /// </summary>
        public Data7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data7"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="token">token.</param>
        public Data7(
            string address,
            string token)
        {
            this.Address = address;
            this.Token = token;
        }

        /// <summary>
        /// The websocket target URL.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The authentication token for the console socket. It should be appended as the URL parameter "token" to the address.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data7 other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
        }
    }
}