// <copyright file="ContainerImageSummary1.cs" company="APIMatic">
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
    /// ContainerImageSummary1.
    /// </summary>
    public class ContainerImageSummary1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerImageSummary1"/> class.
        /// </summary>
        public ContainerImageSummary1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerImageSummary1"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="service">service.</param>
        /// <param name="extension">extension.</param>
        public ContainerImageSummary1(
            ContainerImageSummary1Id id,
            ContainerImageSummary1Service service,
            Models.Extension extension = null)
        {
            this.Id = id;
            this.Extension = extension;
            this.Service = service;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public ContainerImageSummary1Id Id { get; set; }

        /// <summary>
        /// An image that is packaged with Cycle directly, such as the global load balancer.
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Include)]
        public Models.Extension Extension { get; set; }

        /// <summary>
        /// If a service container, the identifier specifying which service it is.
        /// </summary>
        [JsonProperty("service")]
        public ContainerImageSummary1Service Service { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerImageSummary1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerImageSummary1 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Extension == null && other.Extension == null) || (this.Extension?.Equals(other.Extension) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Extension = {(this.Extension == null ? "null" : this.Extension.ToString())}");
            toStringOutput.Add($"Service = {(this.Service == null ? "null" : this.Service.ToString())}");
        }
    }
}