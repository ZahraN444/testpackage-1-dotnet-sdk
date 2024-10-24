// <copyright file="Git.cs" company="APIMatic">
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
    /// Git.
    /// </summary>
    public class Git
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Git"/> class.
        /// </summary>
        public Git()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Git"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="mValue">value.</param>
        public Git(
            Models.Type7Enum type,
            string mValue)
        {
            this.Type = type;
            this.MValue = mValue;
        }

        /// <summary>
        /// The type of information the user is passing.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type7Enum Type { get; set; }

        /// <summary>
        /// The actual value to be passed.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Git : ({string.Join(", ", toStringOutput)})";
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
            return obj is Git other &&                this.Type.Equals(other.Type) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}