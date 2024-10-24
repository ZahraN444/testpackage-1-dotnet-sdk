// <copyright file="RecordIncludes.cs" company="APIMatic">
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
    /// RecordIncludes.
    /// </summary>
    public class RecordIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordIncludes"/> class.
        /// </summary>
        public RecordIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="containers">containers.</param>
        /// <param name="containersIdentifiers">containers:identifiers.</param>
        public RecordIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Container> containers = null,
            object containersIdentifiers = null)
        {
            this.Creators = creators;
            this.Containers = containers;
            this.ContainersIdentifiers = containersIdentifiers;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// A resource thats associated with a contianer.
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Container> Containers { get; set; }

        /// <summary>
        /// A map of identifiers to an array of resource IDs that are associated with it. All IDs point to the same type of resource.
        /// </summary>
        [JsonProperty("containers:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public object ContainersIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecordIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is RecordIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.ContainersIdentifiers == null && other.ContainersIdentifiers == null) || (this.ContainersIdentifiers?.Equals(other.ContainersIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"ContainersIdentifiers = {(this.ContainersIdentifiers == null ? "null" : this.ContainersIdentifiers.ToString())}");
        }
    }
}