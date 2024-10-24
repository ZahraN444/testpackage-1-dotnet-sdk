// <copyright file="Config8.cs" company="APIMatic">
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
    /// Config8.
    /// </summary>
    public class Config8
    {
        private Dictionary<string, Models.Hosts> hosts;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "hosts", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Config8"/> class.
        /// </summary>
        public Config8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config8"/> class.
        /// </summary>
        /// <param name="hosts">hosts.</param>
        public Config8(
            Dictionary<string, Models.Hosts> hosts = null)
        {
            if (hosts != null)
            {
                this.Hosts = hosts;
            }

        }

        /// <summary>
        /// A mapping of hostnames to IP addresses for custom internal resolutions. Acts as a custom /etc/resolv.conf file that works environment wide.
        /// </summary>
        [JsonProperty("hosts")]
        public Dictionary<string, Models.Hosts> Hosts
        {
            get
            {
                return this.hosts;
            }

            set
            {
                this.shouldSerialize["hosts"] = true;
                this.hosts = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config8 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHosts()
        {
            this.shouldSerialize["hosts"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHosts()
        {
            return this.shouldSerialize["hosts"];
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
            return obj is Config8 other &&                ((this.Hosts == null && other.Hosts == null) || (this.Hosts?.Equals(other.Hosts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Hosts = {(this.Hosts == null ? "null" : this.Hosts.ToString())}");
        }
    }
}