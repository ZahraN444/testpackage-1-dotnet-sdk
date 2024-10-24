// <copyright file="V1AccountResetPasswordRequest.cs" company="APIMatic">
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
    /// V1AccountResetPasswordRequest.
    /// </summary>
    public class V1AccountResetPasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountResetPasswordRequest"/> class.
        /// </summary>
        public V1AccountResetPasswordRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountResetPasswordRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        public V1AccountResetPasswordRequest(
            Models.Email2 email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        [JsonRequired]
        public Models.Email2 Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1AccountResetPasswordRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1AccountResetPasswordRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email.ToString())}");
        }
    }
}