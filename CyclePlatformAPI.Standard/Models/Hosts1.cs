// <copyright file="Hosts1.cs" company="APIMatic">
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
    /// Hosts1.
    /// </summary>
    public class Hosts1
    {
        private List<string> ipv4;
        private List<string> ipv6;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ipv4", false },
            { "ipv6", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Hosts1"/> class.
        /// </summary>
        public Hosts1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hosts1"/> class.
        /// </summary>
        /// <param name="ipv4">ipv4.</param>
        /// <param name="ipv6">ipv6.</param>
        public Hosts1(
            List<string> ipv4 = null,
            List<string> ipv6 = null)
        {
            if (ipv4 != null)
            {
                this.Ipv4 = ipv4;
            }

            if (ipv6 != null)
            {
                this.Ipv6 = ipv6;
            }

        }

        /// <summary>
        /// Gets or sets Ipv4.
        /// </summary>
        [JsonProperty("ipv4")]
        public List<string> Ipv4
        {
            get
            {
                return this.ipv4;
            }

            set
            {
                this.shouldSerialize["ipv4"] = true;
                this.ipv4 = value;
            }
        }

        /// <summary>
        /// Gets or sets Ipv6.
        /// </summary>
        [JsonProperty("ipv6")]
        public List<string> Ipv6
        {
            get
            {
                return this.ipv6;
            }

            set
            {
                this.shouldSerialize["ipv6"] = true;
                this.ipv6 = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Hosts1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIpv4()
        {
            this.shouldSerialize["ipv4"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIpv6()
        {
            this.shouldSerialize["ipv6"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIpv4()
        {
            return this.shouldSerialize["ipv4"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIpv6()
        {
            return this.shouldSerialize["ipv6"];
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
            return obj is Hosts1 other &&                ((this.Ipv4 == null && other.Ipv4 == null) || (this.Ipv4?.Equals(other.Ipv4) == true)) &&
                ((this.Ipv6 == null && other.Ipv6 == null) || (this.Ipv6?.Equals(other.Ipv6) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ipv4 = {(this.Ipv4 == null ? "null" : $"[{string.Join(", ", this.Ipv4)} ]")}");
            toStringOutput.Add($"this.Ipv6 = {(this.Ipv6 == null ? "null" : $"[{string.Join(", ", this.Ipv6)} ]")}");
        }
    }
}