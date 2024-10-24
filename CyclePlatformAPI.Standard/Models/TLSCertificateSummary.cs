// <copyright file="TLSCertificateSummary.cs" company="APIMatic">
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
    /// TLSCertificateSummary.
    /// </summary>
    public class TLSCertificateSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TLSCertificateSummary"/> class.
        /// </summary>
        public TLSCertificateSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TLSCertificateSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="generated">generated.</param>
        /// <param name="wildcardChild">wildcard_child.</param>
        public TLSCertificateSummary(
            string id,
            DateTime generated,
            bool wildcardChild)
        {
            this.Id = id;
            this.Generated = generated;
            this.WildcardChild = wildcardChild;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Generated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generated")]
        [JsonRequired]
        public DateTime Generated { get; set; }

        /// <summary>
        /// A value where true represents that the certificate is using a shared wildcard cert.
        /// </summary>
        [JsonProperty("wildcard_child")]
        [JsonRequired]
        public bool WildcardChild { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TLSCertificateSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is TLSCertificateSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Generated.Equals(other.Generated) &&
                this.WildcardChild.Equals(other.WildcardChild);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Generated = {this.Generated}");
            toStringOutput.Add($"this.WildcardChild = {this.WildcardChild}");
        }
    }
}