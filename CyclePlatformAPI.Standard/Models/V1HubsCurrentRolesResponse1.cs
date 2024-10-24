// <copyright file="V1HubsCurrentRolesResponse1.cs" company="APIMatic">
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
    /// V1HubsCurrentRolesResponse1.
    /// </summary>
    public class V1HubsCurrentRolesResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRolesResponse1"/> class.
        /// </summary>
        public V1HubsCurrentRolesResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRolesResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1HubsCurrentRolesResponse1(
            Models.Role data)
        {
            this.Data = data;
        }

        /// <summary>
        /// A Role is a custom combination of platform-level capabilities, allowing for fully customizable role-based access controls across the platform.
        /// </summary>
        [JsonProperty("data")]
        public Models.Role Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentRolesResponse1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1HubsCurrentRolesResponse1 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}