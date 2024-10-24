// <copyright file="ProvisionOptions1.cs" company="APIMatic">
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
    /// ProvisionOptions1.
    /// </summary>
    public class ProvisionOptions1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionOptions1"/> class.
        /// </summary>
        public ProvisionOptions1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionOptions1"/> class.
        /// </summary>
        /// <param name="attachedStorageSize">attached_storage_size.</param>
        /// <param name="reservationId">reservation_id.</param>
        public ProvisionOptions1(
            double? attachedStorageSize = null,
            string reservationId = null)
        {
            this.AttachedStorageSize = attachedStorageSize;
            this.ReservationId = reservationId;
        }

        /// <summary>
        /// Gets or sets AttachedStorageSize.
        /// </summary>
        [JsonProperty("attached_storage_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? AttachedStorageSize { get; set; }

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

            return $"ProvisionOptions1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProvisionOptions1 other &&                ((this.AttachedStorageSize == null && other.AttachedStorageSize == null) || (this.AttachedStorageSize?.Equals(other.AttachedStorageSize) == true)) &&
                ((this.ReservationId == null && other.ReservationId == null) || (this.ReservationId?.Equals(other.ReservationId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AttachedStorageSize = {(this.AttachedStorageSize == null ? "null" : this.AttachedStorageSize.ToString())}");
            toStringOutput.Add($"this.ReservationId = {(this.ReservationId == null ? "null" : this.ReservationId)}");
        }
    }
}