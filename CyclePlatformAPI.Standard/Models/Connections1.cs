// <copyright file="Connections1.cs" company="APIMatic">
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
    /// Connections1.
    /// </summary>
    public class Connections1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connections1"/> class.
        /// </summary>
        public Connections1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connections1"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="unavailable">unavailable.</param>
        /// <param name="errors">errors.</param>
        /// <param name="bytesTransmitted">bytes_transmitted.</param>
        /// <param name="bytesReceived">bytes_received.</param>
        public Connections1(
            int success,
            int unavailable,
            Dictionary<string, int> errors = null,
            int? bytesTransmitted = null,
            int? bytesReceived = null)
        {
            this.Success = success;
            this.Unavailable = unavailable;
            this.Errors = errors;
            this.BytesTransmitted = bytesTransmitted;
            this.BytesReceived = bytesReceived;
        }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        /// Gets or sets Unavailable.
        /// </summary>
        [JsonProperty("unavailable")]
        public int Unavailable { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int> Errors { get; set; }

        /// <summary>
        /// Gets or sets BytesTransmitted.
        /// </summary>
        [JsonProperty("bytes_transmitted", NullValueHandling = NullValueHandling.Ignore)]
        public int? BytesTransmitted { get; set; }

        /// <summary>
        /// Gets or sets BytesReceived.
        /// </summary>
        [JsonProperty("bytes_received", NullValueHandling = NullValueHandling.Ignore)]
        public int? BytesReceived { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Connections1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Connections1 other &&                this.Success.Equals(other.Success) &&
                this.Unavailable.Equals(other.Unavailable) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true)) &&
                ((this.BytesTransmitted == null && other.BytesTransmitted == null) || (this.BytesTransmitted?.Equals(other.BytesTransmitted) == true)) &&
                ((this.BytesReceived == null && other.BytesReceived == null) || (this.BytesReceived?.Equals(other.BytesReceived) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.Unavailable = {this.Unavailable}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : this.Errors.ToString())}");
            toStringOutput.Add($"this.BytesTransmitted = {(this.BytesTransmitted == null ? "null" : this.BytesTransmitted.ToString())}");
            toStringOutput.Add($"this.BytesReceived = {(this.BytesReceived == null ? "null" : this.BytesReceived.ToString())}");
        }
    }
}