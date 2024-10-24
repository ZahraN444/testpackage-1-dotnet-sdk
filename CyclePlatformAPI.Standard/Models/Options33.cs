// <copyright file="Options33.cs" company="APIMatic">
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
    /// Options33.
    /// </summary>
    public class Options33
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options33"/> class.
        /// </summary>
        public Options33()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options33"/> class.
        /// </summary>
        /// <param name="skip">skip.</param>
        public Options33(
            bool? skip = null)
        {
            this.Skip = skip;
        }

        /// <summary>
        /// A boolean where true indicates the given stage should be skipped when the pipeline is run.
        /// </summary>
        [JsonProperty("skip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Skip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Options33 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Options33 other &&                ((this.Skip == null && other.Skip == null) || (this.Skip?.Equals(other.Skip) == true));
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