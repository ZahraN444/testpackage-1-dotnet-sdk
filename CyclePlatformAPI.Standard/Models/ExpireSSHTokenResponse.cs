// <copyright file="ExpireSSHTokenResponse.cs" company="APIMatic">
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
    /// ExpireSSHTokenResponse.
    /// </summary>
    public class ExpireSSHTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpireSSHTokenResponse"/> class.
        /// </summary>
        public ExpireSSHTokenResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpireSSHTokenResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ExpireSSHTokenResponse(
            Models.Data4 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// The number of tokens expired.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data4 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExpireSSHTokenResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExpireSSHTokenResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}