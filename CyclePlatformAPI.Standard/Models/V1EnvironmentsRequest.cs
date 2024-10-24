// <copyright file="V1EnvironmentsRequest.cs" company="APIMatic">
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
    /// V1EnvironmentsRequest.
    /// </summary>
    public class V1EnvironmentsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsRequest"/> class.
        /// </summary>
        public V1EnvironmentsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="about">about.</param>
        /// <param name="features">features.</param>
        /// <param name="identifier">identifier.</param>
        public V1EnvironmentsRequest(
            string name,
            string cluster,
            Models.About5 about,
            Models.Features features,
            string identifier = null)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Cluster = cluster;
            this.About = about;
            this.Features = features;
        }

        /// <summary>
        /// A user defined name for the Environment.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// The cluster this Environment is associated with.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

        /// <summary>
        /// Contains details regarding the Environment.
        /// </summary>
        [JsonProperty("about")]
        public Models.About5 About { get; set; }

        /// <summary>
        /// An object representing specialized features configured for this environment.
        /// </summary>
        [JsonProperty("features")]
        public Models.Features Features { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
        }
    }
}