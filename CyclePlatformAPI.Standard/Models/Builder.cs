// <copyright file="Builder.cs" company="APIMatic">
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
    /// Builder.
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Builder"/> class.
        /// </summary>
        public Builder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Builder"/> class.
        /// </summary>
        /// <param name="integrationId">integration_id.</param>
        public Builder(
            string integrationId)
        {
            this.IntegrationId = integrationId;
        }

        /// <summary>
        /// Either a resource ID (objectid - i.e. 651586fca6078e98982dbd90) or a resource Identifier (human-readable)
        /// </summary>
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Builder : ({string.Join(", ", toStringOutput)})";
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
            return obj is Builder other &&                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
        }
    }
}