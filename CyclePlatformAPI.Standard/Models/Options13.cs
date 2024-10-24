// <copyright file="Options13.cs" company="APIMatic">
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
    /// Options13.
    /// </summary>
    public class Options13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options13"/> class.
        /// </summary>
        public Options13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options13"/> class.
        /// </summary>
        /// <param name="allowIncompatible">allow_incompatible.</param>
        public Options13(
            bool allowIncompatible)
        {
            this.AllowIncompatible = allowIncompatible;
        }

        /// <summary>
        /// Gets or sets AllowIncompatible.
        /// </summary>
        [JsonProperty("allow_incompatible")]
        public bool AllowIncompatible { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Options13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Options13 other &&                this.AllowIncompatible.Equals(other.AllowIncompatible);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllowIncompatible = {this.AllowIncompatible}");
        }
    }
}