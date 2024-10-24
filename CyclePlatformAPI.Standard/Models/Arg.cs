// <copyright file="Arg.cs" company="APIMatic">
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
    /// Arg.
    /// </summary>
    public class Arg
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Arg"/> class.
        /// </summary>
        public Arg()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Arg"/> class.
        /// </summary>
        /// <param name="index">index.</param>
        /// <param name="mValue">value.</param>
        /// <param name="op">op.</param>
        /// <param name="valuetwo">valuetwo.</param>
        public Arg(
            int index,
            int mValue,
            Models.OpEnum op,
            int? valuetwo = null)
        {
            this.Index = index;
            this.MValue = mValue;
            this.Valuetwo = valuetwo;
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
        /// Gets or sets Valuetwo.
        /// </summary>
        [JsonProperty("valuetwo", NullValueHandling = NullValueHandling.Ignore)]
        public int? Valuetwo { get; set; }

        /// <summary>
        /// Gets or sets Op.
        /// </summary>
        [JsonProperty("op")]
        public Models.OpEnum Op { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Arg : ({string.Join(", ", toStringOutput)})";
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
            return obj is Arg other &&                this.Index.Equals(other.Index) &&
                this.MValue.Equals(other.MValue) &&
                ((this.Valuetwo == null && other.Valuetwo == null) || (this.Valuetwo?.Equals(other.Valuetwo) == true)) &&
                this.Op.Equals(other.Op);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Index = {this.Index}");
            toStringOutput.Add($"this.MValue = {this.MValue}");
            toStringOutput.Add($"this.Valuetwo = {(this.Valuetwo == null ? "null" : this.Valuetwo.ToString())}");
            toStringOutput.Add($"this.Op = {this.Op}");
        }
    }
}