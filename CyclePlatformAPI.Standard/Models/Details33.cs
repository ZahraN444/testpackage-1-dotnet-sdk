// <copyright file="Details33.cs" company="APIMatic">
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
    /// Details33.
    /// </summary>
    public class Details33
    {
        private string name;
        private Models.Override3 mOverride;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "override", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details33"/> class.
        /// </summary>
        public Details33()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details33"/> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="name">name.</param>
        /// <param name="build">build.</param>
        /// <param name="mOverride">override.</param>
        public Details33(
            string source,
            string name = null,
            Models.Build2 build = null,
            Models.Override3 mOverride = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            this.Source = source;
            this.Build = build;
            if (mOverride != null)
            {
                this.MOverride = mOverride;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Optional build-time options for when this image is built on pipeline run.
        /// </summary>
        [JsonProperty("build", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Build2 Build { get; set; }

        /// <summary>
        /// An override object to be used for a single image create request.
        /// </summary>
        [JsonProperty("override")]
        public Models.Override3 MOverride
        {
            get
            {
                return this.mOverride;
            }

            set
            {
                this.shouldSerialize["override"] = true;
                this.mOverride = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details33 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOverride()
        {
            this.shouldSerialize["override"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOverride()
        {
            return this.shouldSerialize["override"];
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
            return obj is Details33 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
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
            toStringOutput.Add($"this.Source = {(this.Source == null ? "null" : this.Source)}");
            toStringOutput.Add($"this.Build = {(this.Build == null ? "null" : this.Build.ToString())}");
            toStringOutput.Add($"this.MOverride = {(this.MOverride == null ? "null" : this.MOverride.ToString())}");
        }
    }
}