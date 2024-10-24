// <copyright file="Details11.cs" company="APIMatic">
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
    /// Details11.
    /// </summary>
    public class Details11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details11"/> class.
        /// </summary>
        public Details11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details11"/> class.
        /// </summary>
        /// <param name="expires">expires.</param>
        /// <param name="token">token.</param>
        public Details11(
            DateTime expires,
            string token)
        {
            this.Expires = expires;
            this.Token = token;
        }

        /// <summary>
        /// The date-time at which the authorization token for uploading this image expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// The token that is required by the factory to accept an upload for this image.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details11 other &&                this.Expires.Equals(other.Expires) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Expires = {this.Expires}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
        }
    }
}