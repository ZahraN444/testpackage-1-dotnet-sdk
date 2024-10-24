// <copyright file="Port.cs" company="APIMatic">
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
    /// Port.
    /// </summary>
    public class Port
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Port"/> class.
        /// </summary>
        public Port()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Port"/> class.
        /// </summary>
        /// <param name="host">host.</param>
        /// <param name="container">container.</param>
        /// <param name="type">type.</param>
        public Port(
            double host,
            double container,
            string type)
        {
            this.Host = host;
            this.Container = container;
            this.Type = type;
        }

        /// <summary>
        /// Host Port
        /// </summary>
        [JsonProperty("host")]
        public double Host { get; set; }

        /// <summary>
        /// Gets or sets Container.
        /// </summary>
        [JsonProperty("container")]
        public double Container { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Port : ({string.Join(", ", toStringOutput)})";
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
            return obj is Port other &&                this.Host.Equals(other.Host) &&
                this.Container.Equals(other.Container) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Host = {this.Host}");
            toStringOutput.Add($"this.Container = {this.Container}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}