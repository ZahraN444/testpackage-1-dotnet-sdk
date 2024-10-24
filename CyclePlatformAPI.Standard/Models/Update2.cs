// <copyright file="Update2.cs" company="APIMatic">
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
    /// Update2.
    /// </summary>
    public class Update2
    {
        private Models.ScopedVariables scopedVariables;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "scoped_variables", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Update2"/> class.
        /// </summary>
        public Update2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update2"/> class.
        /// </summary>
        /// <param name="containers">containers.</param>
        /// <param name="scopedVariables">scoped_variables.</param>
        public Update2(
            Dictionary<string, Models.StackDeployContainersObject> containers = null,
            Models.ScopedVariables scopedVariables = null)
        {
            this.Containers = containers;
            if (scopedVariables != null)
            {
                this.ScopedVariables = scopedVariables;
            }

        }

        /// <summary>
        /// A map of the container names to update within the environment.
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.StackDeployContainersObject> Containers { get; set; }

        /// <summary>
        /// An object that describes configuration options for scoped variables on stack build.
        /// </summary>
        [JsonProperty("scoped_variables")]
        public Models.ScopedVariables ScopedVariables
        {
            get
            {
                return this.scopedVariables;
            }

            set
            {
                this.shouldSerialize["scoped_variables"] = true;
                this.scopedVariables = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Update2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetScopedVariables()
        {
            this.shouldSerialize["scoped_variables"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScopedVariables()
        {
            return this.shouldSerialize["scoped_variables"];
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
            return obj is Update2 other &&                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.ScopedVariables == null && other.ScopedVariables == null) || (this.ScopedVariables?.Equals(other.ScopedVariables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"this.ScopedVariables = {(this.ScopedVariables == null ? "null" : this.ScopedVariables.ToString())}");
        }
    }
}