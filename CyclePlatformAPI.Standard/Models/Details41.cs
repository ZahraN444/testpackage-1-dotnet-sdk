// <copyright file="Details41.cs" company="APIMatic">
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
    /// Details41.
    /// </summary>
    public class Details41
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details41"/> class.
        /// </summary>
        public Details41()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details41"/> class.
        /// </summary>
        /// <param name="container">container.</param>
        /// <param name="image">image.</param>
        /// <param name="options">options.</param>
        public Details41(
            string container,
            string image,
            Models.Options13 options = null)
        {
            this.Container = container;
            this.Image = image;
            this.Options = options;
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
        [JsonProperty("container")]
        public string Container { get; set; }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Options13 Options { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details41 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details41 other &&                ((this.Container == null && other.Container == null) || (this.Container?.Equals(other.Container) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Container = {(this.Container == null ? "null" : this.Container)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
        }
    }
}