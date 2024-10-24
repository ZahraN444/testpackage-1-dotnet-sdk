// <copyright file="V1ContainersRequest.cs" company="APIMatic">
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
    /// V1ContainersRequest.
    /// </summary>
    public class V1ContainersRequest
    {
        private object annotations;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "annotations", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersRequest"/> class.
        /// </summary>
        public V1ContainersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="imageId">image_id.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="config">config.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="mLock">lock.</param>
        /// <param name="deployment">deployment.</param>
        /// <param name="volumes">volumes.</param>
        /// <param name="annotations">annotations.</param>
        public V1ContainersRequest(
            string name,
            string environmentId,
            string imageId,
            bool stateful,
            Models.ContainerConfig config,
            V1ContainersRequestIdentifier identifier = null,
            bool? mLock = null,
            V1ContainersRequestDeployment deployment = null,
            List<Models.ContainerVolume> volumes = null,
            object annotations = null)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.EnvironmentId = environmentId;
            this.ImageId = imageId;
            this.Stateful = stateful;
            this.Config = config;
            this.MLock = mLock;
            this.Deployment = deployment;
            this.Volumes = volumes;
            if (annotations != null)
            {
                this.Annotations = annotations;
            }

        }

        /// <summary>
        /// A user defined name for the Container.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public V1ContainersRequestIdentifier Identifier { get; set; }

        /// <summary>
        /// An identifier for the Environment this Container will be deployed to.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// An identifier for the Image used to create this Container.
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// A boolean where true represents this Container is stateful.
        /// </summary>
        [JsonProperty("stateful")]
        public bool Stateful { get; set; }

        /// <summary>
        /// A container configuration.
        /// </summary>
        [JsonProperty("config")]
        public Models.ContainerConfig Config { get; set; }

        /// <summary>
        /// When set to true, prevents this Container from being deleted.
        /// </summary>
        [JsonProperty("lock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MLock { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public V1ContainersRequestDeployment Deployment { get; set; }

        /// <summary>
        /// Gets or sets Volumes.
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ContainerVolume> Volumes { get; set; }

        /// <summary>
        /// Custom meta data. Not utilized by Cycle.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ContainersRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ContainersRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.ImageId == null && other.ImageId == null) || (this.ImageId?.Equals(other.ImageId) == true)) &&
                this.Stateful.Equals(other.Stateful) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.MLock == null && other.MLock == null) || (this.MLock?.Equals(other.MLock) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true)) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Identifier = {(this.Identifier == null ? "null" : this.Identifier.ToString())}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.ImageId = {(this.ImageId == null ? "null" : this.ImageId)}");
            toStringOutput.Add($"this.Stateful = {this.Stateful}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.MLock = {(this.MLock == null ? "null" : this.MLock.ToString())}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
            toStringOutput.Add($"this.Volumes = {(this.Volumes == null ? "null" : $"[{string.Join(", ", this.Volumes)} ]")}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
        }
    }
}