// <copyright file="V1Account2faSetupRequest.cs" company="APIMatic">
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
    /// V1Account2faSetupRequest.
    /// </summary>
    public class V1Account2faSetupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Account2faSetupRequest"/> class.
        /// </summary>
        public V1Account2faSetupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1Account2faSetupRequest"/> class.
        /// </summary>
        /// <param name="token">token.</param>
        public V1Account2faSetupRequest(
            string token)
        {
            this.Token = token;
        }

        /// <summary>
        /// The token used to authenticate the two-factor setup.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1Account2faSetupRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1Account2faSetupRequest other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
        }
    }
}