// <copyright file="Containers1.cs" company="APIMatic">
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
    /// Containers1.
    /// </summary>
    public class Containers1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Containers1"/> class.
        /// </summary>
        public Containers1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Containers1"/> class.
        /// </summary>
        /// <param name="mGlobal">global.</param>
        /// <param name="ids">ids.</param>
        /// <param name="identifiers">identifiers.</param>
        public Containers1(
            bool mGlobal,
            List<string> ids,
            List<string> identifiers)
        {
            this.MGlobal = mGlobal;
            this.Ids = ids;
            this.Identifiers = identifiers;
        }

        /// <summary>
        /// A boolean where true represents the scoped variables is globally assigned to all current and future containers in the environment.
        /// </summary>
        [JsonProperty("global")]
        public bool MGlobal { get; set; }

        /// <summary>
        /// An array of container IDs, where each container identified will have access to the scoped variable.
        /// </summary>
        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// An array of container identifiers, where each container identfied will have access to the scoped variable.
        /// </summary>
        [JsonProperty("identifiers")]
        public List<string> Identifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Containers1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Containers1 other &&                this.MGlobal.Equals(other.MGlobal) &&
                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true)) &&
                ((this.Identifiers == null && other.Identifiers == null) || (this.Identifiers?.Equals(other.Identifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MGlobal = {this.MGlobal}");
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
            toStringOutput.Add($"this.Identifiers = {(this.Identifiers == null ? "null" : $"[{string.Join(", ", this.Identifiers)} ]")}");
        }
    }
}