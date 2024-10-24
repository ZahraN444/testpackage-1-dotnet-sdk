// <copyright file="StackContainer.cs" company="APIMatic">
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
    /// StackContainer.
    /// </summary>
    public class StackContainer
    {
        private object annotations;
        private Models.Role1Enum? role;
        private string pod;
        private List<Models.StackSpecContainerVolume> volumes;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "annotations", false },
            { "role", false },
            { "pod", false },
            { "volumes", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainer"/> class.
        /// </summary>
        public StackContainer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainer"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="image">image.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="config">config.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="role">role.</param>
        /// <param name="pod">pod.</param>
        /// <param name="volumes">volumes.</param>
        /// <param name="deprecate">deprecate.</param>
        /// <param name="mLock">lock.</param>
        public StackContainer(
            string name,
            Models.StackSpecContainerImage image,
            bool stateful,
            Models.StackSpecContainerConfig config,
            object annotations = null,
            Models.Role1Enum? role = null,
            string pod = null,
            List<Models.StackSpecContainerVolume> volumes = null,
            bool? deprecate = null,
            bool? mLock = null)
        {
            this.Name = name;
            this.Image = image;
            if (annotations != null)
            {
                this.Annotations = annotations;
            }

            this.Stateful = stateful;
            this.Config = config;
            if (role != null)
            {
                this.Role = role;
            }

            if (pod != null)
            {
                this.Pod = pod;
            }

            if (volumes != null)
            {
                this.Volumes = volumes;
            }

            this.Deprecate = deprecate;
            this.MLock = mLock;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Image.
        /// </summary>
        [JsonProperty("image")]
        public Models.StackSpecContainerImage Image { get; set; }

        /// <summary>
        /// Additional meta info about the container.
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
        /// Gets or sets Stateful.
        /// </summary>
        [JsonProperty("stateful")]
        public bool Stateful { get; set; }

        /// <summary>
        /// Gets or sets Config.
        /// </summary>
        [JsonProperty("config")]
        public Models.StackSpecContainerConfig Config { get; set; }

        /// <summary>
        /// Gets or sets Role.
        /// </summary>
        [JsonProperty("role")]
        public Models.Role1Enum? Role
        {
            get
            {
                return this.role;
            }

            set
            {
                this.shouldSerialize["role"] = true;
                this.role = value;
            }
        }

        /// <summary>
        /// Gets or sets Pod.
        /// </summary>
        [JsonProperty("pod")]
        public string Pod
        {
            get
            {
                return this.pod;
            }

            set
            {
                this.shouldSerialize["pod"] = true;
                this.pod = value;
            }
        }

        /// <summary>
        /// Gets or sets Volumes.
        /// </summary>
        [JsonProperty("volumes")]
        public List<Models.StackSpecContainerVolume> Volumes
        {
            get
            {
                return this.volumes;
            }

            set
            {
                this.shouldSerialize["volumes"] = true;
                this.volumes = value;
            }
        }

        /// <summary>
        /// Gets or sets Deprecate.
        /// </summary>
        [JsonProperty("deprecate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deprecate { get; set; }

        /// <summary>
        /// Gets or sets MLock.
        /// </summary>
        [JsonProperty("lock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MLock { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainer : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAnnotations()
        {
            this.shouldSerialize["annotations"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRole()
        {
            this.shouldSerialize["role"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPod()
        {
            this.shouldSerialize["pod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVolumes()
        {
            this.shouldSerialize["volumes"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAnnotations()
        {
            return this.shouldSerialize["annotations"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRole()
        {
            return this.shouldSerialize["role"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePod()
        {
            return this.shouldSerialize["pod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVolumes()
        {
            return this.shouldSerialize["volumes"];
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
            return obj is StackContainer other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                this.Stateful.Equals(other.Stateful) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.Pod == null && other.Pod == null) || (this.Pod?.Equals(other.Pod) == true)) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true)) &&
                ((this.Deprecate == null && other.Deprecate == null) || (this.Deprecate?.Equals(other.Deprecate) == true)) &&
                ((this.MLock == null && other.MLock == null) || (this.MLock?.Equals(other.MLock) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"this.Stateful = {this.Stateful}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"this.Pod = {(this.Pod == null ? "null" : this.Pod)}");
            toStringOutput.Add($"this.Volumes = {(this.Volumes == null ? "null" : $"[{string.Join(", ", this.Volumes)} ]")}");
            toStringOutput.Add($"this.Deprecate = {(this.Deprecate == null ? "null" : this.Deprecate.ToString())}");
            toStringOutput.Add($"this.MLock = {(this.MLock == null ? "null" : this.MLock.ToString())}");
        }
    }
}