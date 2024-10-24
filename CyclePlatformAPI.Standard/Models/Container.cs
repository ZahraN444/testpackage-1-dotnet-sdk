// <copyright file="Container.cs" company="APIMatic">
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
    /// Container.
    /// </summary>
    public class Container
    {
        private object annotations;
        private Models.Role2Enum? role;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "annotations", false },
            { "role", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Container"/> class.
        /// </summary>
        public Container()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Container"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="name">name.</param>
        /// <param name="creator">creator.</param>
        /// <param name="environment">environment.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="image">image.</param>
        /// <param name="config">config.</param>
        /// <param name="instances">instances.</param>
        /// <param name="stateful">stateful.</param>
        /// <param name="deprecate">deprecate.</param>
        /// <param name="mLock">lock.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="stack">stack.</param>
        /// <param name="deployment">deployment.</param>
        /// <param name="volumes">volumes.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="role">role.</param>
        /// <param name="meta">meta.</param>
        public Container(
            string id,
            string identifier,
            string name,
            Models.CreatorScope creator,
            Models.ContainerEnvironmentSummary environment,
            string hubId,
            Models.ContainerImageSummary1 image,
            Models.ContainerConfig config,
            int instances,
            bool stateful,
            bool deprecate,
            bool mLock,
            Models.ContainerState state,
            Models.ContainerEvents events,
            ContainerStack stack = null,
            ContainerDeployment deployment = null,
            List<Models.VolumeSummary> volumes = null,
            object annotations = null,
            Models.Role2Enum? role = null,
            Models.ContainersMeta meta = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Creator = creator;
            this.Environment = environment;
            this.HubId = hubId;
            this.Image = image;
            this.Stack = stack;
            this.Config = config;
            this.Deployment = deployment;
            this.Instances = instances;
            this.Volumes = volumes;
            if (annotations != null)
            {
                this.Annotations = annotations;
            }

            if (role != null)
            {
                this.Role = role;
            }

            this.Stateful = stateful;
            this.Deprecate = deprecate;
            this.MLock = mLock;
            this.State = state;
            this.Events = events;
            this.Meta = meta;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// A human readable slugged identifier for this container. Usually used as a key in a stack file.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// A user defined name for the container resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// A summary of supplemental environment and network information specific to a container.
        /// </summary>
        [JsonProperty("environment")]
        [JsonRequired]
        public Models.ContainerEnvironmentSummary Environment { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A summary of the image this container was created from.
        /// </summary>
        [JsonProperty("image")]
        [JsonRequired]
        public Models.ContainerImageSummary1 Image { get; set; }

        /// <summary>
        /// Gets or sets Stack.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerStack Stack { get; set; }

        /// <summary>
        /// A container configuration.
        /// </summary>
        [JsonProperty("config")]
        [JsonRequired]
        public Models.ContainerConfig Config { get; set; }

        /// <summary>
        /// Gets or sets Deployment.
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerDeployment Deployment { get; set; }

        /// <summary>
        /// The number of instances for a given container.
        /// </summary>
        [JsonProperty("instances")]
        [JsonRequired]
        public int Instances { get; set; }

        /// <summary>
        /// Gets or sets Volumes.
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.VolumeSummary> Volumes { get; set; }

        /// <summary>
        /// Custom meta data for a given container
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
        /// The role of a given container if it has one.
        /// </summary>
        [JsonProperty("role")]
        public Models.Role2Enum? Role
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
        /// A boolean where true signifies the container is stateful.
        /// </summary>
        [JsonProperty("stateful")]
        [JsonRequired]
        public bool Stateful { get; set; }

        /// <summary>
        /// A boolean where true signifies the container is marked as deprecated.
        /// </summary>
        [JsonProperty("deprecate")]
        [JsonRequired]
        public bool Deprecate { get; set; }

        /// <summary>
        /// When set to true, prevents this container from being deleted.
        /// </summary>
        [JsonProperty("lock")]
        [JsonRequired]
        public bool MLock { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ContainerState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the container's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ContainerEvents Events { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a container.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContainersMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Container : ({string.Join(", ", toStringOutput)})";
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
            return obj is Container other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true)) &&
                this.Instances.Equals(other.Instances) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                this.Stateful.Equals(other.Stateful) &&
                this.Deprecate.Equals(other.Deprecate) &&
                this.MLock.Equals(other.MLock) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image.ToString())}");
            toStringOutput.Add($"Stack = {(this.Stack == null ? "null" : this.Stack.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
            toStringOutput.Add($"this.Instances = {this.Instances}");
            toStringOutput.Add($"this.Volumes = {(this.Volumes == null ? "null" : $"[{string.Join(", ", this.Volumes)} ]")}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role.ToString())}");
            toStringOutput.Add($"this.Stateful = {this.Stateful}");
            toStringOutput.Add($"this.Deprecate = {this.Deprecate}");
            toStringOutput.Add($"this.MLock = {this.MLock}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}