// <copyright file="IntegrationMeta.cs" company="APIMatic">
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
    /// IntegrationMeta.
    /// </summary>
    public class IntegrationMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationMeta"/> class.
        /// </summary>
        public IntegrationMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationMeta"/> class.
        /// </summary>
        /// <param name="definition">definition.</param>
        public IntegrationMeta(
            Models.IntegrationDefinition1 definition = null)
        {
            this.Definition = definition;
        }

        /// <summary>
        /// The full Integration definition associated with this Integration.
        /// </summary>
        [JsonProperty("definition", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntegrationDefinition1 Definition { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntegrationMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is IntegrationMeta other &&                ((this.Definition == null && other.Definition == null) || (this.Definition?.Equals(other.Definition) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Definition = {(this.Definition == null ? "null" : this.Definition.ToString())}");
        }
    }
}