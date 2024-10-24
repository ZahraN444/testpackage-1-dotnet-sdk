// <copyright file="ScopedVariableScope.cs" company="APIMatic">
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
    /// ScopedVariableScope.
    /// </summary>
    public class ScopedVariableScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariableScope"/> class.
        /// </summary>
        public ScopedVariableScope()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariableScope"/> class.
        /// </summary>
        /// <param name="containers">containers.</param>
        public ScopedVariableScope(
            Models.Containers1 containers)
        {
            this.Containers = containers;
        }

        /// <summary>
        /// Information about the assignment of the scoped variable to different containers in the environment.
        /// </summary>
        [JsonProperty("containers")]
        public Models.Containers1 Containers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScopedVariableScope : ({string.Join(", ", toStringOutput)})";
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
            return obj is ScopedVariableScope other &&                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
        }
    }
}