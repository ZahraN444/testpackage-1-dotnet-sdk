// <copyright file="Interfaces.cs" company="APIMatic">
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
    /// Interfaces.
    /// </summary>
    public class Interfaces
    {
        private List<string> addrs;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "addrs", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Interfaces"/> class.
        /// </summary>
        public Interfaces()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interfaces"/> class.
        /// </summary>
        /// <param name="mInterface">interface.</param>
        /// <param name="flags">flags.</param>
        /// <param name="mtu">mtu.</param>
        /// <param name="macAddr">mac_addr.</param>
        /// <param name="addrs">addrs.</param>
        public Interfaces(
            string mInterface = null,
            string flags = null,
            int? mtu = null,
            string macAddr = null,
            List<string> addrs = null)
        {
            this.MInterface = mInterface;
            this.Flags = flags;
            this.Mtu = mtu;
            this.MacAddr = macAddr;
            if (addrs != null)
            {
                this.Addrs = addrs;
            }

        }

        /// <summary>
        /// The interface name.
        /// </summary>
        [JsonProperty("interface", NullValueHandling = NullValueHandling.Ignore)]
        public string MInterface { get; set; }

        /// <summary>
        /// Flags for the given interface.
        /// </summary>
        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public string Flags { get; set; }

        /// <summary>
        /// The maximum transmission unit for the interface.
        /// </summary>
        [JsonProperty("mtu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mtu { get; set; }

        /// <summary>
        /// The mac address for the interface.
        /// </summary>
        [JsonProperty("mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddr { get; set; }

        /// <summary>
        /// An array of IP addresses associated with the interface.
        /// </summary>
        [JsonProperty("addrs")]
        public List<string> Addrs
        {
            get
            {
                return this.addrs;
            }

            set
            {
                this.shouldSerialize["addrs"] = true;
                this.addrs = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Interfaces : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAddrs()
        {
            this.shouldSerialize["addrs"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAddrs()
        {
            return this.shouldSerialize["addrs"];
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
            return obj is Interfaces other &&                ((this.MInterface == null && other.MInterface == null) || (this.MInterface?.Equals(other.MInterface) == true)) &&
                ((this.Flags == null && other.Flags == null) || (this.Flags?.Equals(other.Flags) == true)) &&
                ((this.Mtu == null && other.Mtu == null) || (this.Mtu?.Equals(other.Mtu) == true)) &&
                ((this.MacAddr == null && other.MacAddr == null) || (this.MacAddr?.Equals(other.MacAddr) == true)) &&
                ((this.Addrs == null && other.Addrs == null) || (this.Addrs?.Equals(other.Addrs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MInterface = {(this.MInterface == null ? "null" : this.MInterface)}");
            toStringOutput.Add($"this.Flags = {(this.Flags == null ? "null" : this.Flags)}");
            toStringOutput.Add($"this.Mtu = {(this.Mtu == null ? "null" : this.Mtu.ToString())}");
            toStringOutput.Add($"this.MacAddr = {(this.MacAddr == null ? "null" : this.MacAddr)}");
            toStringOutput.Add($"this.Addrs = {(this.Addrs == null ? "null" : $"[{string.Join(", ", this.Addrs)} ]")}");
        }
    }
}