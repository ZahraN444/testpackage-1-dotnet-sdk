// <copyright file="IPPoolProvider.cs" company="APIMatic">
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
    /// IPPoolProvider.
    /// </summary>
    public class IPPoolProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPPoolProvider"/> class.
        /// </summary>
        public IPPoolProvider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPPoolProvider"/> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="location">location.</param>
        /// <param name="reservation">reservation.</param>
        /// <param name="server">server.</param>
        /// <param name="serverAssignment">server_assignment.</param>
        public IPPoolProvider(
            string vendor,
            string integrationId,
            string location,
            string reservation,
            string server,
            string serverAssignment)
        {
            this.Vendor = vendor;
            this.IntegrationId = integrationId;
            this.Location = location;
            this.Reservation = reservation;
            this.Server = server;
            this.ServerAssignment = serverAssignment;
        }

        /// <summary>
        /// A vendor for a provider.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// ID of the provider integration used to provision the IP.
        /// </summary>
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Information about the location of the provider this pool is associated with.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// A reservation identifier associated with the pool reservation.
        /// </summary>
        [JsonProperty("reservation")]
        public string Reservation { get; set; }

        /// <summary>
        /// A server identifier associated with the pool.
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

        /// <summary>
        /// An identifier linked to the server assingment of the IP pool.
        /// </summary>
        [JsonProperty("server_assignment")]
        public string ServerAssignment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IPPoolProvider : ({string.Join(", ", toStringOutput)})";
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
            return obj is IPPoolProvider other &&                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Reservation == null && other.Reservation == null) || (this.Reservation?.Equals(other.Reservation) == true)) &&
                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true)) &&
                ((this.ServerAssignment == null && other.ServerAssignment == null) || (this.ServerAssignment?.Equals(other.ServerAssignment) == true));
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
            toStringOutput.Add($"this.Reservation = {(this.Reservation == null ? "null" : this.Reservation)}");
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server)}");
            toStringOutput.Add($"this.ServerAssignment = {(this.ServerAssignment == null ? "null" : this.ServerAssignment)}");
        }
    }
}