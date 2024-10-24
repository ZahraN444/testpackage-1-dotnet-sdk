// <copyright file="ReconfigureContainer.cs" company="APIMatic">
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
    /// ReconfigureContainer.
    /// </summary>
    public class ReconfigureContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureContainer"/> class.
        /// </summary>
        public ReconfigureContainer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReconfigureContainer"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="contents">contents.</param>
        public ReconfigureContainer(
            string action,
            Models.ContainerConfig contents)
        {
            this.Action = action;
            this.Contents = contents;
        }

        /// <summary>
        /// The action to take.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("action")]
        [JsonRequired]
        public string Action { get; set; }

        /// <summary>
        /// A container configuration.
        /// </summary>
        [JsonProperty("contents")]
        [JsonRequired]
        public Models.ContainerConfig Contents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReconfigureContainer : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReconfigureContainer other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
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