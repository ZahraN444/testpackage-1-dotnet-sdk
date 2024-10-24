// <copyright file="Details47.cs" company="APIMatic">
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
    /// Details47.
    /// </summary>
    public class Details47
    {
        private string tag;
        private string version;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tag", false },
            { "version", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details47"/> class.
        /// </summary>
        public Details47()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details47"/> class.
        /// </summary>
        /// <param name="environment">environment.</param>
        /// <param name="tag">tag.</param>
        /// <param name="version">version.</param>
        public Details47(
            string environment,
            string tag = null,
            string version = null)
        {
            this.Environment = environment;
            if (tag != null)
            {
                this.Tag = tag;
            }

            if (version != null)
            {
                this.Version = version;
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
        [JsonProperty("environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Gets or sets Tag.
        /// </summary>
        [JsonProperty("tag")]
        public string Tag
        {
            get
            {
                return this.tag;
            }

            set
            {
                this.shouldSerialize["tag"] = true;
                this.tag = value;
            }
        }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get
            {
                return this.version;
            }

            set
            {
                this.shouldSerialize["version"] = true;
                this.version = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details47 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTag()
        {
            this.shouldSerialize["tag"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVersion()
        {
            this.shouldSerialize["version"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTag()
        {
            return this.shouldSerialize["tag"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVersion()
        {
            return this.shouldSerialize["version"];
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
            return obj is Details47 other &&                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.Tag = {(this.Tag == null ? "null" : this.Tag)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
        }
    }
}