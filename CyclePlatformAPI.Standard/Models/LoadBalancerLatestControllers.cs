// <copyright file="LoadBalancerLatestControllers.cs" company="APIMatic">
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
    /// LoadBalancerLatestControllers.
    /// </summary>
    public class LoadBalancerLatestControllers
    {
        private List<Models.LoadBalancerLatestTelemetryController> controllers;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "controllers", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestControllers"/> class.
        /// </summary>
        public LoadBalancerLatestControllers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerLatestControllers"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="controllers">controllers.</param>
        public LoadBalancerLatestControllers(
            DateTime created,
            List<Models.LoadBalancerLatestTelemetryController> controllers = null)
        {
            this.Created = created;
            if (controllers != null)
            {
                this.Controllers = controllers;
            }

        }

        /// <summary>
        /// Gets or sets Created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets Controllers.
        /// </summary>
        [JsonProperty("controllers")]
        public List<Models.LoadBalancerLatestTelemetryController> Controllers
        {
            get
            {
                return this.controllers;
            }

            set
            {
                this.shouldSerialize["controllers"] = true;
                this.controllers = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerLatestControllers : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetControllers()
        {
            this.shouldSerialize["controllers"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeControllers()
        {
            return this.shouldSerialize["controllers"];
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
            return obj is LoadBalancerLatestControllers other &&                this.Created.Equals(other.Created) &&
                ((this.Controllers == null && other.Controllers == null) || (this.Controllers?.Equals(other.Controllers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Controllers = {(this.Controllers == null ? "null" : $"[{string.Join(", ", this.Controllers)} ]")}");
        }
    }
}