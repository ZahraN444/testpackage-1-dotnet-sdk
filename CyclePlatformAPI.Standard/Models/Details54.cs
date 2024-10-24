// <copyright file="Details54.cs" company="APIMatic">
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
    /// Details54.
    /// </summary>
    public class Details54
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details54"/> class.
        /// </summary>
        public Details54()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details54"/> class.
        /// </summary>
        /// <param name="build">build.</param>
        /// <param name="environment">environment.</param>
        /// <param name="update">update.</param>
        /// <param name="deployment">deployment.</param>
        public Details54(
            string build,
            string environment,
            Details54Update update = null,
            Details54Deployment deployment = null)
        {
            this.Build = build;
            this.Environment = environment;
            this.Update = update;
            this.Deployment = deployment;
        }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("build")]
        public string Build { get; set; }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Gets or sets Update.
        /// </summary>
        [JsonProperty("update", NullValueHandling = NullValueHandling.Ignore)]
        public Details54Update Update { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public Details54Deployment Deployment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details54 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details54 other &&                ((this.Build == null && other.Build == null) || (this.Build?.Equals(other.Build) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Update == null && other.Update == null) || (this.Update?.Equals(other.Update) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Build = {(this.Build == null ? "null" : this.Build)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"Update = {(this.Update == null ? "null" : this.Update.ToString())}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
        }
    }
}