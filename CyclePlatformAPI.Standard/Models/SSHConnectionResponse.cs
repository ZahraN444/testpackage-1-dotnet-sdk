// <copyright file="SSHConnectionResponse.cs" company="APIMatic">
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
    /// SSHConnectionResponse.
    /// </summary>
    public class SSHConnectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSHConnectionResponse"/> class.
        /// </summary>
        public SSHConnectionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSHConnectionResponse"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="secret">secret.</param>
        /// <param name="address">address.</param>
        public SSHConnectionResponse(
            Models.SSHToken token,
            string secret,
            string address)
        {
            this.Token = token;
            this.Secret = secret;
            this.Address = address;
        }

        /// <summary>
        /// An Instance SSH token.
        /// </summary>
        [JsonProperty("token")]
        public Models.SSHToken Token { get; set; }

        /// <summary>
        /// The SSH connection response secret.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// The SSH connection response address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SSHConnectionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SSHConnectionResponse other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token.ToString())}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
        }
    }
}