// <copyright file="Replace.cs" company="APIMatic">
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
    /// Replace.
    /// </summary>
    public class Replace
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Replace"/> class.
        /// </summary>
        public Replace()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Replace"/> class.
        /// </summary>
        /// <param name="match">match.</param>
        /// <param name="mValue">value.</param>
        public Replace(
            string match,
            string mValue)
        {
            this.Match = match;
            this.MValue = mValue;
        }

        /// <summary>
        /// String that will be replaced.
        /// </summary>
        [JsonProperty("match")]
        public string Match { get; set; }

        /// <summary>
        /// Replacement value.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Replace : ({string.Join(", ", toStringOutput)})";
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
            return obj is Replace other &&                ((this.Match == null && other.Match == null) || (this.Match?.Equals(other.Match) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Match = {(this.Match == null ? "null" : this.Match)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}