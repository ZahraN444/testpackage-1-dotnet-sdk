// <copyright file="ContainerImageSummary.cs" company="APIMatic">
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
    /// ContainerImageSummary.
    /// </summary>
    public class ContainerImageSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerImageSummary"/> class.
        /// </summary>
        public ContainerImageSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerImageSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="service">service.</param>
        public ContainerImageSummary(
            string id,
            Models.ServiceEnum? service = null)
        {
            this.Id = id;
            this.Service = service;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// If this image is a service container this will say either `discovery` | `loadbalancer` | `vpn`.
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Include)]
        public Models.ServiceEnum? Service { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerImageSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerImageSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service.ToString())}");
        }
    }
}