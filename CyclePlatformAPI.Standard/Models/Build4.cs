// <copyright file="Build4.cs" company="APIMatic">
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
    /// Build4.
    /// </summary>
    public class Build4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Build4"/> class.
        /// </summary>
        public Build4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Build4"/> class.
        /// </summary>
        /// <param name="args">args.</param>
        public Build4(
            Dictionary<string, string> args = null)
        {
            this.Args = args;
        }

        /// <summary>
        /// An object holding key value build time arguments needed for the Image during build time.
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Args { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Build4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Build4 other &&                ((this.Args == null && other.Args == null) || (this.Args?.Equals(other.Args) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Args = {(this.Args == null ? "null" : this.Args.ToString())}");
        }
    }
}