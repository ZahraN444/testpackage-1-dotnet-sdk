// <copyright file="Contents14.cs" company="APIMatic">
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
    /// Contents14.
    /// </summary>
    public class Contents14
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents14"/> class.
        /// </summary>
        public Contents14()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents14"/> class.
        /// </summary>
        /// <param name="variables">variables.</param>
        public Contents14(
            Dictionary<string, string> variables = null)
        {
            this.Variables = variables;
        }

        /// <summary>
        /// A map of variables to pass into the Pipeline when it runs.
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents14 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents14 other &&                ((this.Variables == null && other.Variables == null) || (this.Variables?.Equals(other.Variables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Variables = {(this.Variables == null ? "null" : this.Variables.ToString())}");
        }
    }
}