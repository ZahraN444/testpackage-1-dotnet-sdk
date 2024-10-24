// <copyright file="Advanced.cs" company="APIMatic">
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
    /// Advanced.
    /// </summary>
    public class Advanced
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Advanced"/> class.
        /// </summary>
        public Advanced()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Advanced"/> class.
        /// </summary>
        /// <param name="provisionOptions">provision_options.</param>
        /// <param name="zone">zone.</param>
        public Advanced(
            Models.ProvisionOptions1 provisionOptions = null,
            string zone = null)
        {
            this.ProvisionOptions = provisionOptions;
            this.Zone = zone;
        }

        /// <summary>
        /// Gets or sets ProvisionOptions.
        /// </summary>
        [JsonProperty("provision_options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProvisionOptions1 ProvisionOptions { get; set; }

        /// <summary>
        /// Gets or sets Zone.
        /// </summary>
        [JsonProperty("zone", NullValueHandling = NullValueHandling.Ignore)]
        public string Zone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Advanced : ({string.Join(", ", toStringOutput)})";
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
            return obj is Advanced other &&                ((this.ProvisionOptions == null && other.ProvisionOptions == null) || (this.ProvisionOptions?.Equals(other.ProvisionOptions) == true)) &&
                ((this.Zone == null && other.Zone == null) || (this.Zone?.Equals(other.Zone) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProvisionOptions = {(this.ProvisionOptions == null ? "null" : this.ProvisionOptions.ToString())}");
            toStringOutput.Add($"this.Zone = {(this.Zone == null ? "null" : this.Zone)}");
        }
    }
}