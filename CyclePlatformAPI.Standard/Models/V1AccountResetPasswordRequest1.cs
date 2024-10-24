// <copyright file="V1AccountResetPasswordRequest1.cs" company="APIMatic">
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
    /// V1AccountResetPasswordRequest1.
    /// </summary>
    public class V1AccountResetPasswordRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountResetPasswordRequest1"/> class.
        /// </summary>
        public V1AccountResetPasswordRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountResetPasswordRequest1"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        /// <param name="password">password.</param>
        public V1AccountResetPasswordRequest1(
            string token,
            string password)
        {
            this.Token = token;
            this.Password = password;
        }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("token")]
        [JsonRequired]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1AccountResetPasswordRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1AccountResetPasswordRequest1 other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
        }
    }
}