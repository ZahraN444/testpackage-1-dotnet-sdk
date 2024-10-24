// <copyright file="Ingress.cs" company="APIMatic">
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
    /// Ingress.
    /// </summary>
    public class Ingress
    {
        private Models.Tls1 tls;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tls", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Ingress"/> class.
        /// </summary>
        public Ingress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ingress"/> class.
        /// </summary>
        /// <param name="port">port.</param>
        /// <param name="tls">tls.</param>
        public Ingress(
            int port,
            Models.Tls1 tls = null)
        {
            this.Port = port;
            if (tls != null)
            {
                this.Tls = tls;
            }

        }

        /// <summary>
        /// The port inbound trafic is accepted on.
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets Tls.
        /// </summary>
        [JsonProperty("tls")]
        public Models.Tls1 Tls
        {
            get
            {
                return this.tls;
            }

            set
            {
                this.shouldSerialize["tls"] = true;
                this.tls = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ingress : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTls()
        {
            this.shouldSerialize["tls"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTls()
        {
            return this.shouldSerialize["tls"];
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
            return obj is Ingress other &&                this.Port.Equals(other.Port) &&
                ((this.Tls == null && other.Tls == null) || (this.Tls?.Equals(other.Tls) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Port = {this.Port}");
            toStringOutput.Add($"this.Tls = {(this.Tls == null ? "null" : this.Tls.ToString())}");
        }
    }
}