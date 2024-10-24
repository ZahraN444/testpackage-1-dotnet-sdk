// <copyright file="Match.cs" company="APIMatic">
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
    /// Match.
    /// </summary>
    public class Match
    {
        private string path;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "path", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Match"/> class.
        /// </summary>
        public Match()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Match"/> class.
        /// </summary>
        /// <param name="domains">domains.</param>
        /// <param name="internalPort">internal_port.</param>
        /// <param name="path">path.</param>
        public Match(
            List<string> domains = null,
            List<int> internalPort = null,
            string path = null)
        {
            this.Domains = domains;
            this.InternalPort = internalPort;
            if (path != null)
            {
                this.Path = path;
            }

        }

        /// <summary>
        /// The specific domains to match against.
        /// </summary>
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Include)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The specific ports to match against.
        /// </summary>
        [JsonProperty("internal_port", NullValueHandling = NullValueHandling.Include)]
        public List<int> InternalPort { get; set; }

        /// <summary>
        /// Gets or sets Path.
        /// </summary>
        [JsonProperty("path")]
        public string Path
        {
            get
            {
                return this.path;
            }

            set
            {
                this.shouldSerialize["path"] = true;
                this.path = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Match : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPath()
        {
            this.shouldSerialize["path"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePath()
        {
            return this.shouldSerialize["path"];
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
            return obj is Match other &&                ((this.Domains == null && other.Domains == null) || (this.Domains?.Equals(other.Domains) == true)) &&
                ((this.InternalPort == null && other.InternalPort == null) || (this.InternalPort?.Equals(other.InternalPort) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Domains = {(this.Domains == null ? "null" : $"[{string.Join(", ", this.Domains)} ]")}");
            toStringOutput.Add($"this.InternalPort = {(this.InternalPort == null ? "null" : $"[{string.Join(", ", this.InternalPort)} ]")}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
        }
    }
}