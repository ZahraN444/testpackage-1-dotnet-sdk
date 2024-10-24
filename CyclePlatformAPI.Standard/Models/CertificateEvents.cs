// <copyright file="CertificateEvents.cs" company="APIMatic">
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
    /// CertificateEvents.
    /// </summary>
    public class CertificateEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateEvents"/> class.
        /// </summary>
        public CertificateEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="generated">generated.</param>
        public CertificateEvents(
            DateTime? created = null,
            DateTime? updated = null,
            DateTime? deleted = null,
            DateTime? generated = null)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.Generated = generated;
        }

        /// <summary>
        /// [unused]
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// [unused]
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// [unused]
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Deleted { get; set; }

        /// <summary>
        /// When the certificate was generated; useful for calculating expiration (+90 days)
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Generated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CertificateEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is CertificateEvents other &&                ((this.Created == null && other.Created == null) || (this.Created?.Equals(other.Created) == true)) &&
                ((this.Updated == null && other.Updated == null) || (this.Updated?.Equals(other.Updated) == true)) &&
                ((this.Deleted == null && other.Deleted == null) || (this.Deleted?.Equals(other.Deleted) == true)) &&
                ((this.Generated == null && other.Generated == null) || (this.Generated?.Equals(other.Generated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {(this.Created == null ? "null" : this.Created.ToString())}");
            toStringOutput.Add($"this.Updated = {(this.Updated == null ? "null" : this.Updated.ToString())}");
            toStringOutput.Add($"this.Deleted = {(this.Deleted == null ? "null" : this.Deleted.ToString())}");
            toStringOutput.Add($"this.Generated = {(this.Generated == null ? "null" : this.Generated.ToString())}");
        }
    }
}