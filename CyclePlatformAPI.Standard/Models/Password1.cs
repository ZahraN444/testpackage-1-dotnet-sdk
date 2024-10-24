// <copyright file="Password1.cs" company="APIMatic">
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
    /// Password1.
    /// </summary>
    public class Password1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Password1"/> class.
        /// </summary>
        public Password1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Password1"/> class.
        /// </summary>
        /// <param name="algorithm">algorithm.</param>
        /// <param name="data">data.</param>
        public Password1(
            Models.Algorithm1Enum algorithm,
            string data)
        {
            this.Algorithm = algorithm;
            this.Data = data;
        }

        /// <summary>
        /// The hashing algorithm used to has the password.
        /// </summary>
        [JsonProperty("algorithm")]
        public Models.Algorithm1Enum Algorithm { get; set; }

        /// <summary>
        /// The raw or hashed password.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Password1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Password1 other &&                this.Algorithm.Equals(other.Algorithm) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Algorithm = {this.Algorithm}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data)}");
        }
    }
}