// <copyright file="Build1.cs" company="APIMatic">
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
    /// Build1.
    /// </summary>
    public class Build1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Build1"/> class.
        /// </summary>
        public Build1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Build1"/> class.
        /// </summary>
        /// <param name="args">args.</param>
        public Build1(
            Dictionary<string, string> args = null)
        {
            this.Args = args;
        }

        /// <summary>
        /// Arguments to pass to the builder during a build of this image.
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Args { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Build1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Build1 other &&                ((this.Args == null && other.Args == null) || (this.Args?.Equals(other.Args) == true));
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