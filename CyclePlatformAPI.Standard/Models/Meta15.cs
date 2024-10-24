// <copyright file="Meta15.cs" company="APIMatic">
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
    /// Meta15.
    /// </summary>
    public class Meta15
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta15"/> class.
        /// </summary>
        public Meta15()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta15"/> class.
        /// </summary>
        /// <param name="captions">captions.</param>
        public Meta15(
            Dictionary<string, string> captions)
        {
            this.Captions = captions;
        }

        /// <summary>
        /// Human-readable captions keyed by the platform level capability it describes.
        /// </summary>
        [JsonProperty("captions")]
        public Dictionary<string, string> Captions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Meta15 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Meta15 other &&                ((this.Captions == null && other.Captions == null) || (this.Captions?.Equals(other.Captions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Captions = {(this.Captions == null ? "null" : this.Captions.ToString())}");
        }
    }
}