// <copyright file="ProvisionOptions.cs" company="APIMatic">
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
    /// ProvisionOptions.
    /// </summary>
    public class ProvisionOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionOptions"/> class.
        /// </summary>
        public ProvisionOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionOptions"/> class.
        /// </summary>
        /// <param name="attachesdStorageSize">attachesd_storage_size.</param>
        /// <param name="reservationId">reservation_id.</param>
        public ProvisionOptions(
            double? attachesdStorageSize = null,
            string reservationId = null)
        {
            this.AttachesdStorageSize = attachesdStorageSize;
            this.ReservationId = reservationId;
        }

        /// <summary>
        /// Gets or sets AttachesdStorageSize.
        /// </summary>
        [JsonProperty("attachesd_storage_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttachesdStorageSize { get; set; }

        /// <summary>
        /// Gets or sets ReservationId.
        /// </summary>
        [JsonProperty("reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReservationId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProvisionOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProvisionOptions other &&                ((this.AttachesdStorageSize == null && other.AttachesdStorageSize == null) || (this.AttachesdStorageSize?.Equals(other.AttachesdStorageSize) == true)) &&
                ((this.ReservationId == null && other.ReservationId == null) || (this.ReservationId?.Equals(other.ReservationId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AttachesdStorageSize = {(this.AttachesdStorageSize == null ? "null" : this.AttachesdStorageSize.ToString())}");
            toStringOutput.Add($"this.ReservationId = {(this.ReservationId == null ? "null" : this.ReservationId)}");
        }
    }
}