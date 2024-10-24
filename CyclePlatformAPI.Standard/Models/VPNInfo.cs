// <copyright file="VPNInfo.cs" company="APIMatic">
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
    /// VPNInfo.
    /// </summary>
    public class VPNInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPNInfo"/> class.
        /// </summary>
        public VPNInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPNInfo"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="service">service.</param>
        public VPNInfo(
            string url,
            VPNInfoService service)
        {
            this.Url = url;
            this.Service = service;
        }

        /// <summary>
        /// A url associated with the VPN service.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Service.
        /// </summary>
        [JsonProperty("service")]
        public VPNInfoService Service { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VPNInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is VPNInfo other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"Service = {(this.Service == null ? "null" : this.Service.ToString())}");
        }
    }
}