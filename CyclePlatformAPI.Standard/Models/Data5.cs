// <copyright file="Data5.cs" company="APIMatic">
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
    /// Data5.
    /// </summary>
    public class Data5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data5"/> class.
        /// </summary>
        public Data5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data5"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="address">address.</param>
        public Data5(
            string token,
            string address)
        {
            this.Token = token;
            this.Address = address;
        }

        /// <summary>
        /// The authentication token passed into the address as a URL parameter (?token).
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// The URL address to open a websocket to for streaming instance telemetry data.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data5 other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
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