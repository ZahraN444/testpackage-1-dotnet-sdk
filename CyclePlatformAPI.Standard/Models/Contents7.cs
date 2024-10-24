// <copyright file="Contents7.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Contents7.
    /// </summary>
    public class Contents7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents7"/> class.
        /// </summary>
        public Contents7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents7"/> class.
        /// </summary>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="deployment">deployment.</param>
        /// <param name="update">update.</param>
        public Contents7(
            string environmentId,
            Contents7Deployment deployment = null,
            Contents7Update update = null)
        {
            this.EnvironmentId = environmentId;
            this.Deployment = deployment;
            this.Update = update;
        }

        /// <summary>
        /// The ID for the environment this stack build will be deployed to.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public Contents7Deployment Deployment { get; set; }

        /// <summary>
        /// Gets or sets Update.
        /// </summary>
        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Contents7Update Update { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents7 other &&                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true)) &&
                ((this.Update == null && other.Update == null) || (this.Update?.Equals(other.Update) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
            toStringOutput.Add($"Update = {(this.Update == null ? "null" : this.Update.ToString())}");
        }
    }
}