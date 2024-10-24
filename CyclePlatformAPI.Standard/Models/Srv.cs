// <copyright file="Srv.cs" company="APIMatic">
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
    /// Srv.
    /// </summary>
    public class Srv
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Srv"/> class.
        /// </summary>
        public Srv()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Srv"/> class.
        /// </summary>
        /// <param name="weight">weight.</param>
        /// <param name="priority">priority.</param>
        /// <param name="port">port.</param>
        /// <param name="domain">domain.</param>
        public Srv(
            int weight,
            int priority,
            int port,
            string domain)
        {
            this.Weight = weight;
            this.Priority = priority;
            this.Port = port;
            this.Domain = domain;
        }

        /// <summary>
        /// Teh weight configured for this record - breaks ties for priority.
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// The priority for the record.
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The port number for the service.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// The domain for the record.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Srv : ({string.Join(", ", toStringOutput)})";
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
            return obj is Srv other &&                this.Weight.Equals(other.Weight) &&
                this.Priority.Equals(other.Priority) &&
                this.Port.Equals(other.Port) &&
                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Weight = {this.Weight}");
            toStringOutput.Add($"this.Priority = {this.Priority}");
            toStringOutput.Add($"this.Port = {this.Port}");
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
        }
    }
}