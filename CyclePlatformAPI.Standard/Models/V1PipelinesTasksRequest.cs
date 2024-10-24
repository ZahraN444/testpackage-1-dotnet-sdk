// <copyright file="V1PipelinesTasksRequest.cs" company="APIMatic">
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
    /// V1PipelinesTasksRequest.
    /// </summary>
    public class V1PipelinesTasksRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PipelinesTasksRequest"/> class.
        /// </summary>
        public V1PipelinesTasksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PipelinesTasksRequest"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="contents">contents.</param>
        public V1PipelinesTasksRequest(
            string action,
            Models.Contents14 contents = null)
        {
            this.Action = action;
            this.Contents = contents;
        }

        /// <summary>
        /// The requested action to perform.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets Contents.
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Contents14 Contents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1PipelinesTasksRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1PipelinesTasksRequest other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
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