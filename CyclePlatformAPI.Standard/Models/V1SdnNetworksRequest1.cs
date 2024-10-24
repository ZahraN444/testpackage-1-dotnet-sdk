// <copyright file="V1SdnNetworksRequest1.cs" company="APIMatic">
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
    /// V1SdnNetworksRequest1.
    /// </summary>
    public class V1SdnNetworksRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1SdnNetworksRequest1"/> class.
        /// </summary>
        public V1SdnNetworksRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1SdnNetworksRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        public V1SdnNetworksRequest1(
            string name = null)
        {
            this.Name = name;
        }

        /// <summary>
        /// The name of the Network.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1SdnNetworksRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1SdnNetworksRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}