// <copyright file="Details37.cs" company="APIMatic">
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
    /// Details37.
    /// </summary>
    public class Details37
    {
        private string identifier;
        private object annotations;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "identifier", false },
            { "annotations", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details37"/> class.
        /// </summary>
        public Details37()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details37"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="environment">environment.</param>
        /// <param name="image">image.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="config">config.</param>
        /// <param name="volumes">volumes.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="deployment">deployment.</param>
        public Details37(
            string name,
            string environment,
            string image,
            bool stateful,
            Models.ContainerConfig config,
            List<Models.ContainerVolume> volumes,
            string identifier = null,
            object annotations = null,
            Details37Deployment deployment = null)
        {
            this.Name = name;
            if (identifier != null)
            {
                this.Identifier = identifier;
            }

            this.Environment = environment;
            this.Image = image;
            this.Stateful = stateful;
            if (annotations != null)
            {
                this.Annotations = annotations;
            }

            this.Config = config;
            this.Volumes = volumes;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                this.shouldSerialize["identifier"] = true;
                this.identifier = value;
            }
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
        [JsonProperty("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets Stateful.
        /// </summary>
        [JsonProperty("stateful")]
        public bool Stateful { get; set; }

        /// <summary>
        /// Additional information about a container
        /// </summary>
        [JsonProperty("annotations")]
        public object Annotations
        {
            get
            {
                return this.annotations;
            }

            set
            {
                this.shouldSerialize["annotations"] = true;
                this.annotations = value;
            }
        }

        /// <summary>
        /// A container configuration.
        /// </summary>
        [JsonProperty("config")]
        public Models.ContainerConfig Config { get; set; }

        /// <summary>
        /// Gets or sets Volumes.
        /// </summary>
        [JsonProperty("volumes")]
        public List<Models.ContainerVolume> Volumes { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public Details37Deployment Deployment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details37 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIdentifier()
        {
            this.shouldSerialize["identifier"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnotations()
        {
            this.shouldSerialize["annotations"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIdentifier()
        {
            return this.shouldSerialize["identifier"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnotations()
        {
            return this.shouldSerialize["annotations"];
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
            return obj is Details37 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                this.Stateful.Equals(other.Stateful) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.Stateful = {this.Stateful}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.Volumes = {(this.Volumes == null ? "null" : $"[{string.Join(", ", this.Volumes)} ]")}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
        }
    }
}