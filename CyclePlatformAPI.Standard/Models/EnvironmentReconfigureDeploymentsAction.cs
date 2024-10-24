// <copyright file="EnvironmentReconfigureDeploymentsAction.cs" company="APIMatic">
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
    /// EnvironmentReconfigureDeploymentsAction.
    /// </summary>
    public class EnvironmentReconfigureDeploymentsAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentReconfigureDeploymentsAction"/> class.
        /// </summary>
        public EnvironmentReconfigureDeploymentsAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentReconfigureDeploymentsAction"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="contents">contents.</param>
        public EnvironmentReconfigureDeploymentsAction(
            string action,
            Models.Contents contents)
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
        /// Gets or sets Contents.
        /// </summary>
        [JsonProperty("contents")]
        [JsonRequired]
        public Models.Contents Contents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentReconfigureDeploymentsAction : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentReconfigureDeploymentsAction other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
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