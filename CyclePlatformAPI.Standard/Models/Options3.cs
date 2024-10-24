// <copyright file="Options3.cs" company="APIMatic">
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
    /// Options3.
    /// </summary>
    public class Options3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options3"/> class.
        /// </summary>
        public Options3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options3"/> class.
        /// </summary>
        /// <param name="skip">skip.</param>
        public Options3(
            bool? skip = null)
        {
            this.Skip = skip;
        }

        /// <summary>
        /// Gets or sets Skip.
        /// </summary>
        [JsonProperty("skip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Skip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Options3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Options3 other &&                ((this.Skip == null && other.Skip == null) || (this.Skip?.Equals(other.Skip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Skip = {(this.Skip == null ? "null" : this.Skip.ToString())}");
        }
    }
}