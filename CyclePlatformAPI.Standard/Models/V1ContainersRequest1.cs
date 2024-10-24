// <copyright file="V1ContainersRequest1.cs" company="APIMatic">
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
    /// V1ContainersRequest1.
    /// </summary>
    public class V1ContainersRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersRequest1"/> class.
        /// </summary>
        public V1ContainersRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainersRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="deprecate">deprecate.</param>
        /// <param name="mLock">lock.</param>
        /// <param name="annotation">annotation.</param>
        public V1ContainersRequest1(
            string name = null,
            string identifier = null,
            bool? deprecate = null,
            bool? mLock = null,
            Dictionary<string, string> annotation = null)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Deprecate = deprecate;
            this.MLock = mLock;
            this.Annotation = annotation;
        }

        /// <summary>
        /// The name for the Container.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The name for the identifier.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Sets whether Container should be deprecated.
        /// </summary>
        [JsonProperty("deprecate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deprecate { get; set; }

        /// <summary>
        /// When set to true, prevents this Container from being deleted.
        /// </summary>
        [JsonProperty("lock", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MLock { get; set; }

        /// <summary>
        /// User meta data for the Container.
        /// </summary>
        [JsonProperty("annotation", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1ContainersRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1ContainersRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Deprecate == null && other.Deprecate == null) || (this.Deprecate?.Equals(other.Deprecate) == true)) &&
                ((this.MLock == null && other.MLock == null) || (this.MLock?.Equals(other.MLock) == true)) &&
                ((this.Annotation == null && other.Annotation == null) || (this.Annotation?.Equals(other.Annotation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Deprecate = {(this.Deprecate == null ? "null" : this.Deprecate.ToString())}");
            toStringOutput.Add($"this.MLock = {(this.MLock == null ? "null" : this.MLock.ToString())}");
            toStringOutput.Add($"Annotation = {(this.Annotation == null ? "null" : this.Annotation.ToString())}");
        }
    }
}