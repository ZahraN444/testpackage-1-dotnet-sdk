// <copyright file="V1ImagesRequest.cs" company="APIMatic">
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
    /// V1ImagesRequest.
    /// </summary>
    public class V1ImagesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesRequest"/> class.
        /// </summary>
        public V1ImagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ImagesRequest"/> class.
        /// </summary>
        /// <param name="sourceId">source_id.</param>
        /// <param name="name">name.</param>
        /// <param name="build">build.</param>
        /// <param name="mOverride">override.</param>
        public V1ImagesRequest(
            string sourceId,
            string name = null,
            Models.Build4 build = null,
            Models.Override5 mOverride = null)
        {
            this.Name = name;
            this.SourceId = sourceId;
            this.Build = build;
            this.MOverride = mOverride;
        }

        /// <summary>
        /// A name for the Image.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The ID for the Image source to be used.
        /// </summary>
        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// A build object, holding information important to the Image build.
        /// </summary>
        [JsonProperty("build", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Build4 Build { get; set; }

        /// <summary>
        /// An override object to be used for a single Image create request.
        /// </summary>
        [JsonProperty("override", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Override5 MOverride { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ImagesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ImagesRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SourceId == null && other.SourceId == null) || (this.SourceId?.Equals(other.SourceId) == true)) &&
                ((this.Build == null && other.Build == null) || (this.Build?.Equals(other.Build) == true)) &&
                ((this.MOverride == null && other.MOverride == null) || (this.MOverride?.Equals(other.MOverride) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.SourceId = {(this.SourceId == null ? "null" : this.SourceId)}");
            toStringOutput.Add($"this.Build = {(this.Build == null ? "null" : this.Build.ToString())}");
            toStringOutput.Add($"this.MOverride = {(this.MOverride == null ? "null" : this.MOverride.ToString())}");
        }
    }
}