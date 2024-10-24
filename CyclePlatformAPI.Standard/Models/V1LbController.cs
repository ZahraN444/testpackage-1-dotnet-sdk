// <copyright file="V1LbController.cs" company="APIMatic">
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
    /// V1LbController.
    /// </summary>
    public class V1LbController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbController"/> class.
        /// </summary>
        public V1LbController()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbController"/> class.
        /// </summary>
        /// <param name="mDefault">default.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="transport">transport.</param>
        public V1LbController(
            bool mDefault,
            string identifier,
            Models.V1LbControllerTransport transport)
        {
            this.MDefault = mDefault;
            this.Identifier = identifier;
            this.Transport = transport;
        }

        /// <summary>
        /// Gets or sets MDefault.
        /// </summary>
        [JsonProperty("default")]
        public bool MDefault { get; set; }

        /// <summary>
        /// A human-readable identifier for this controller. It will default to the port, i.e. `port-443`, but can be renamed to anything, such as the service this controller represents.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Defines how traffic comes in to the load balancer, and how the load balancer handles it.
        /// </summary>
        [JsonProperty("transport")]
        public Models.V1LbControllerTransport Transport { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1LbController : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LbController other &&                this.MDefault.Equals(other.MDefault) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Transport == null && other.Transport == null) || (this.Transport?.Equals(other.Transport) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MDefault = {this.MDefault}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Transport = {(this.Transport == null ? "null" : this.Transport.ToString())}");
        }
    }
}