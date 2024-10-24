// <copyright file="V1EnvironmentsServicesDiscoveryTasksRequest.cs" company="APIMatic">
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
    /// V1EnvironmentsServicesDiscoveryTasksRequest.
    /// </summary>
    public class V1EnvironmentsServicesDiscoveryTasksRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesDiscoveryTasksRequest"/> class.
        /// </summary>
        public V1EnvironmentsServicesDiscoveryTasksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsServicesDiscoveryTasksRequest"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="contents">contents.</param>
        public V1EnvironmentsServicesDiscoveryTasksRequest(
            string action,
            Models.Contents9 contents)
        {
            this.Action = action;
            this.Contents = contents;
        }

        /// <summary>
        /// The name of the action to perform.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets Contents.
        /// </summary>
        [JsonProperty("contents")]
        public Models.Contents9 Contents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsServicesDiscoveryTasksRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsServicesDiscoveryTasksRequest other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Contents == null && other.Contents == null) || (this.Contents?.Equals(other.Contents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
            toStringOutput.Add($"this.Contents = {(this.Contents == null ? "null" : this.Contents.ToString())}");
        }
    }
}