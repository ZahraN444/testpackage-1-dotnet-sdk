// <copyright file="ScopedVariables.cs" company="APIMatic">
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
    /// ScopedVariables.
    /// </summary>
    public class ScopedVariables
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariables"/> class.
        /// </summary>
        public ScopedVariables()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariables"/> class.
        /// </summary>
        /// <param name="addNew">add_new.</param>
        /// <param name="replaceExisting">replace_existing.</param>
        public ScopedVariables(
            bool addNew,
            bool replaceExisting)
        {
            this.AddNew = addNew;
            this.ReplaceExisting = replaceExisting;
        }

        /// <summary>
        /// Add new scoped variables defined in the stack.
        /// </summary>
        [JsonProperty("add_new")]
        public bool AddNew { get; set; }

        /// <summary>
        /// Replace all scoped variables with those defined in the stack.
        /// </summary>
        [JsonProperty("replace_existing")]
        public bool ReplaceExisting { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScopedVariables : ({string.Join(", ", toStringOutput)})";
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
            return obj is ScopedVariables other &&                this.AddNew.Equals(other.AddNew) &&
                this.ReplaceExisting.Equals(other.ReplaceExisting);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddNew = {this.AddNew}");
            toStringOutput.Add($"this.ReplaceExisting = {this.ReplaceExisting}");
        }
    }
}