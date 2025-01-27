// <copyright file="Build2.cs" company="APIMatic">
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
    /// Build2.
    /// </summary>
    public class Build2
    {
        private Dictionary<string, string> args;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "args", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Build2"/> class.
        /// </summary>
        public Build2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Build2"/> class.
        /// </summary>
        /// <param name="args">args.</param>
        public Build2(
            Dictionary<string, string> args = null)
        {
            if (args != null)
            {
                this.Args = args;
            }

        }

        /// <summary>
        /// Build args passed into the container image build process during pipeline run.
        /// </summary>
        [JsonProperty("args")]
        public Dictionary<string, string> Args
        {
            get
            {
                return this.args;
            }

            set
            {
                this.shouldSerialize["args"] = true;
                this.args = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Build2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArgs()
        {
            this.shouldSerialize["args"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArgs()
        {
            return this.shouldSerialize["args"];
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
            return obj is Build2 other &&                ((this.Args == null && other.Args == null) || (this.Args?.Equals(other.Args) == true));
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