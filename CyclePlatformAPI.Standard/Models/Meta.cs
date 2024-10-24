// <copyright file="Meta.cs" company="APIMatic">
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
    /// Meta.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        public Meta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        /// <param name="definition">definition.</param>
        public Meta(
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

            return $"Meta : ({string.Join(", ", toStringOutput)})";
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
            return obj is Meta other &&                ((this.Definition == null && other.Definition == null) || (this.Definition?.Equals(other.Definition) == true));
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