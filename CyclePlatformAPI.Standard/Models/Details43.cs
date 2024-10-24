// <copyright file="Details43.cs" company="APIMatic">
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
    /// Details43.
    /// </summary>
    public class Details43
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details43"/> class.
        /// </summary>
        public Details43()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details43"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="cluster">cluster.</param>
        /// <param name="features">features.</param>
        /// <param name="about">about.</param>
        public Details43(
            string name,
            string cluster,
            Models.Features features,
            Details43About about = null)
        {
            this.Name = name;
            this.About = about;
            this.Cluster = cluster;
            this.Features = features;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets About.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Details43About About { get; set; }

        /// <summary>
        /// Gets or sets Cluster.
        /// </summary>
        [JsonProperty("cluster")]
        public string Cluster { get; set; }

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

            return $"Details43 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details43 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Cluster == null && other.Cluster == null) || (this.Cluster?.Equals(other.Cluster) == true)) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Cluster = {(this.Cluster == null ? "null" : this.Cluster)}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : this.Features.ToString())}");
        }
    }
}