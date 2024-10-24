// <copyright file="Certificate2.cs" company="APIMatic">
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
    /// Certificate2.
    /// </summary>
    public class Certificate2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate2"/> class.
        /// </summary>
        public Certificate2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Certificate2"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="generated">generated.</param>
        /// <param name="wildcardChild">wildcard_child.</param>
        public Certificate2(
            string id = null,
            DateTime? generated = null,
            bool? wildcardChild = null)
        {
            this.Id = id;
            this.Generated = generated;
            this.WildcardChild = wildcardChild;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Generated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("generated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Generated { get; set; }

        /// <summary>
        /// A value where true represents that the certificate is using a shared wildcard cert.
        /// </summary>
        [JsonProperty("wildcard_child", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WildcardChild { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Certificate2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Certificate2 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Generated == null && other.Generated == null) || (this.Generated?.Equals(other.Generated) == true)) &&
                ((this.WildcardChild == null && other.WildcardChild == null) || (this.WildcardChild?.Equals(other.WildcardChild) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Generated = {(this.Generated == null ? "null" : this.Generated.ToString())}");
            toStringOutput.Add($"this.WildcardChild = {(this.WildcardChild == null ? "null" : this.WildcardChild.ToString())}");
        }
    }
}