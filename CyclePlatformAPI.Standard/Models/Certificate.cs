// <copyright file="Certificate.cs" company="APIMatic">
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
    /// Certificate.
    /// </summary>
    public class Certificate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate"/> class.
        /// </summary>
        public Certificate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="domains">domains.</param>
        /// <param name="events">events.</param>
        /// <param name="bundle">bundle.</param>
        /// <param name="privateKey">private_key.</param>
        public Certificate(
            string id,
            string hubId,
            List<string> domains,
            Models.CertificateEvents events,
            string bundle,
            string privateKey)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Domains = domains;
            this.Events = events;
            this.Bundle = bundle;
            this.PrivateKey = privateKey;
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
        /// A list of domains associated with the certificate.
        /// </summary>
        [JsonProperty("domains")]
        public List<string> Domains { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the certificate's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.CertificateEvents Events { get; set; }

        /// <summary>
        /// The certificate bundle
        /// </summary>
        [JsonProperty("bundle")]
        public string Bundle { get; set; }

        /// <summary>
        /// The private key for the certificate
        /// </summary>
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Certificate : ({string.Join(", ", toStringOutput)})";
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
            return obj is Certificate other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Domains == null && other.Domains == null) || (this.Domains?.Equals(other.Domains) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Bundle == null && other.Bundle == null) || (this.Bundle?.Equals(other.Bundle) == true)) &&
                ((this.PrivateKey == null && other.PrivateKey == null) || (this.PrivateKey?.Equals(other.PrivateKey) == true));
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
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Bundle = {(this.Bundle == null ? "null" : this.Bundle)}");
            toStringOutput.Add($"this.PrivateKey = {(this.PrivateKey == null ? "null" : this.PrivateKey)}");
        }
    }
}