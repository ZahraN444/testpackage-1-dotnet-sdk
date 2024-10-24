// <copyright file="InstanceProvider.cs" company="APIMatic">
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
    /// InstanceProvider.
    /// </summary>
    public class InstanceProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceProvider"/> class.
        /// </summary>
        public InstanceProvider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceProvider"/> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="location">location.</param>
        public InstanceProvider(
            string vendor,
            string integrationId,
            string location)
        {
            this.Vendor = vendor;
            this.IntegrationId = integrationId;
            this.Location = location;
        }

        /// <summary>
        /// The vendor of the hub provider integration related to the server this instance runs on.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// An ID of the provider Hub integration that this instance's host node is related to.
        /// </summary>
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        /// <summary>
        /// The identifier of the location related to the server this instance runs on.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceProvider : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceProvider other &&                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : this.Vendor)}");
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location)}");
        }
    }
}