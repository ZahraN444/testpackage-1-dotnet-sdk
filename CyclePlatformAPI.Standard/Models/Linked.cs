// <copyright file="Linked.cs" company="APIMatic">
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
    /// Linked.
    /// </summary>
    public class Linked
    {
        private Models.Deployment1 deployment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deployment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Linked"/> class.
        /// </summary>
        public Linked()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Linked"/> class.
        /// </summary>
        /// <param name="features">features.</param>
        /// <param name="containerId">container_id.</param>
        /// <param name="deployment">deployment.</param>
        public Linked(
            Models.Features1 features,
            LinkedContainerId containerId = null,
            Models.Deployment1 deployment = null)
        {
            this.Features = features;
            this.ContainerId = containerId;
            if (deployment != null)
            {
                this.Deployment = deployment;
            }

        }

        /// <summary>
        /// Features associated with this record.
        /// </summary>
        [JsonProperty("features")]
        public Models.Features1 Features { get; set; }

        /// <summary>
        /// The ID of the container this record is related to.
        /// </summary>
        [JsonProperty("container_id", NullValueHandling = NullValueHandling.Ignore)]
        public LinkedContainerId ContainerId { get; set; }

        /// <summary>
        /// Information about the deployment this record points to.
        /// </summary>
        [JsonProperty("deployment")]
        public Models.Deployment1 Deployment
        {
            get
            {
                return this.deployment;
            }

            set
            {
                this.shouldSerialize["deployment"] = true;
                this.deployment = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Linked : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeployment()
        {
            this.shouldSerialize["deployment"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeployment()
        {
            return this.shouldSerialize["deployment"];
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
            return obj is Linked other &&                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.ContainerId == null && other.ContainerId == null) || (this.ContainerId?.Equals(other.ContainerId) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
            toStringOutput.Add($"ContainerId = {(this.ContainerId == null ? "null" : this.ContainerId.ToString())}");
            toStringOutput.Add($"this.Deployment = {(this.Deployment == null ? "null" : this.Deployment.ToString())}");
        }
    }
}