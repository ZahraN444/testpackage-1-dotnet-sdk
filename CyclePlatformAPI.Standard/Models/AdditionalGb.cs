// <copyright file="AdditionalGb.cs" company="APIMatic">
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
    /// AdditionalGb.
    /// </summary>
    public class AdditionalGb
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalGb"/> class.
        /// </summary>
        public AdditionalGb()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalGb"/> class.
        /// </summary>
        /// <param name="mills">mills.</param>
        /// <param name="term">term.</param>
        public AdditionalGb(
            double mills,
            Models.Term1Enum term)
        {
            this.Mills = mills;
            this.Term = term;
        }

        /// <summary>
        /// Gets or sets Mills.
        /// </summary>
        [JsonProperty("mills")]
        public double Mills { get; set; }

        /// <summary>
        /// Gets or sets Term.
        /// </summary>
        [JsonProperty("term")]
        public Models.Term1Enum Term { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalGb : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalGb other &&                this.Mills.Equals(other.Mills) &&
                this.Term.Equals(other.Term);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mills = {this.Mills}");
            toStringOutput.Add($"this.Term = {this.Term}");
        }
    }
}