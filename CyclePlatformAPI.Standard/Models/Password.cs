// <copyright file="Password.cs" company="APIMatic">
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
    /// Password.
    /// </summary>
    public class Password
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Password"/> class.
        /// </summary>
        public Password()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Password"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="algorithm">algorithm.</param>
        public Password(
            string data,
            Models.AlgorithmEnum? algorithm = null)
        {
            this.Algorithm = algorithm;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Algorithm.
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AlgorithmEnum? Algorithm { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Password : ({string.Join(", ", toStringOutput)})";
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
            return obj is Password other &&                ((this.Algorithm == null && other.Algorithm == null) || (this.Algorithm?.Equals(other.Algorithm) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Algorithm = {(this.Algorithm == null ? "null" : this.Algorithm.ToString())}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data)}");
        }
    }
}