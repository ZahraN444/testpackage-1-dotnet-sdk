// <copyright file="LoadBalancerLatestTelemetryController.cs" company="APIMatic">
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
    /// LoadBalancerLatestTelemetryController.
    /// </summary>
    public class LoadBalancerLatestTelemetryController
    {
        private List<Models.LoadBalancerLatestTelemetryInstance> instances;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "instances", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestTelemetryController"/> class.
        /// </summary>
        public LoadBalancerLatestTelemetryController()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestTelemetryController"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="controller">controller.</param>
        /// <param name="instances">instances.</param>
        public LoadBalancerLatestTelemetryController(
            DateTime time,
            string controller,
            List<Models.LoadBalancerLatestTelemetryInstance> instances = null)
        {
            this.Time = time;
            this.Controller = controller;
            if (instances != null)
            {
                this.Instances = instances;
            }

        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("controller")]
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets Instances.
        /// </summary>
        [JsonProperty("instances")]
        public List<Models.LoadBalancerLatestTelemetryInstance> Instances
        {
            get
            {
                return this.instances;
            }

            set
            {
                this.shouldSerialize["instances"] = true;
                this.instances = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerLatestTelemetryController : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInstances()
        {
            this.shouldSerialize["instances"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstances()
        {
            return this.shouldSerialize["instances"];
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
            return obj is LoadBalancerLatestTelemetryController other &&                this.Time.Equals(other.Time) &&
                ((this.Controller == null && other.Controller == null) || (this.Controller?.Equals(other.Controller) == true)) &&
                ((this.Instances == null && other.Instances == null) || (this.Instances?.Equals(other.Instances) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Controller = {(this.Controller == null ? "null" : this.Controller)}");
            toStringOutput.Add($"this.Instances = {(this.Instances == null ? "null" : $"[{string.Join(", ", this.Instances)} ]")}");
        }
    }
}