// <copyright file="Caching.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Caching.
    /// </summary>
    public class Caching
    {
        private List<Models.File> files;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "files", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Caching"/> class.
        /// </summary>
        public Caching()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Caching"/> class.
        /// </summary>
        /// <param name="files">files.</param>
        public Caching(
            List<Models.File> files = null)
        {
            if (files != null)
            {
                this.Files = files;
            }

        }

        /// <summary>
        /// Gets or sets Files.
        /// </summary>
        [JsonProperty("files")]
        public List<Models.File> Files
        {
            get
            {
                return this.files;
            }

            set
            {
                this.shouldSerialize["files"] = true;
                this.files = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Caching : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFiles()
        {
            this.shouldSerialize["files"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFiles()
        {
            return this.shouldSerialize["files"];
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
            return obj is Caching other &&                ((this.Files == null && other.Files == null) || (this.Files?.Equals(other.Files) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Files = {(this.Files == null ? "null" : $"[{string.Join(", ", this.Files)} ]")}");
        }
    }
}