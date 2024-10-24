// <copyright file="Arg1.cs" company="APIMatic">
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
    /// Arg1.
    /// </summary>
    public class Arg1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arg1"/> class.
        /// </summary>
        public Arg1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Arg1"/> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="mValue">value.</param>
        /// <param name="op">op.</param>
        /// <param name="valueTwo">valueTwo.</param>
        public Arg1(
            int index,
            int mValue,
            string op,
            int? valueTwo = null)
        {
            this.Index = index;
            this.MValue = mValue;
            this.ValueTwo = valueTwo;
            this.Op = op;
        }

        /// <summary>
        /// Gets or sets Index.
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value")]
        public int MValue { get; set; }

        /// <summary>
        /// Gets or sets ValueTwo.
        /// </summary>
        [JsonProperty("valueTwo", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueTwo { get; set; }

        /// <summary>
        /// Gets or sets Op.
        /// </summary>
        [JsonProperty("op")]
        public string Op { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Arg1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Arg1 other &&                this.Index.Equals(other.Index) &&
                this.MValue.Equals(other.MValue) &&
                ((this.ValueTwo == null && other.ValueTwo == null) || (this.ValueTwo?.Equals(other.ValueTwo) == true)) &&
                ((this.Op == null && other.Op == null) || (this.Op?.Equals(other.Op) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Index = {this.Index}");
            toStringOutput.Add($"this.MValue = {this.MValue}");
            toStringOutput.Add($"this.ValueTwo = {(this.ValueTwo == null ? "null" : this.ValueTwo.ToString())}");
            toStringOutput.Add($"this.Op = {(this.Op == null ? "null" : this.Op)}");
        }
    }
}