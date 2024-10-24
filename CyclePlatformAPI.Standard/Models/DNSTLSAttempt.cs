// <copyright file="DNSTLSAttempt.cs" company="APIMatic">
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
    /// DNSTLSAttempt.
    /// </summary>
    public class DNSTLSAttempt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSTLSAttempt"/> class.
        /// </summary>
        public DNSTLSAttempt()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSTLSAttempt"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="domains">domains.</param>
        /// <param name="time">time.</param>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        public DNSTLSAttempt(
            string id,
            string hubId,
            List<string> domains,
            DateTime time,
            bool success,
            string error = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Domains = domains;
            this.Time = time;
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// A list of domains associated with the attempt.
        /// </summary>
        [JsonProperty("domains")]
        public List<string> Domains { get; set; }

        /// <summary>
        /// A timestamp for when the attempt took place.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A boolean where true means the attept was successful at creating the TLS certificate.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// If success is false this property will be populated with an error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DNSTLSAttempt : ({string.Join(", ", toStringOutput)})";
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
            return obj is DNSTLSAttempt other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Domains == null && other.Domains == null) || (this.Domains?.Equals(other.Domains) == true)) &&
                this.Time.Equals(other.Time) &&
                this.Success.Equals(other.Success) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Domains = {(this.Domains == null ? "null" : $"[{string.Join(", ", this.Domains)} ]")}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error)}");
        }
    }
}