// <copyright file="ServerSharedFileSystems.cs" company="APIMatic">
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
    /// ServerSharedFileSystems.
    /// </summary>
    public class ServerSharedFileSystems
    {
        private Dictionary<string, Models.Mounts> mounts;
        private object directories;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "mounts", false },
            { "directories", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSharedFileSystems"/> class.
        /// </summary>
        public ServerSharedFileSystems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerSharedFileSystems"/> class.
        /// </summary>
        /// <param name="mounts">mounts.</param>
        /// <param name="directories">directories.</param>
        public ServerSharedFileSystems(
            Dictionary<string, Models.Mounts> mounts = null,
            object directories = null)
        {
            if (mounts != null)
            {
                this.Mounts = mounts;
            }

            if (directories != null)
            {
                this.Directories = directories;
            }

        }

        /// <summary>
        /// Gets or sets Mounts.
        /// </summary>
        [JsonProperty("mounts")]
        public Dictionary<string, Models.Mounts> Mounts
        {
            get
            {
                return this.mounts;
            }

            set
            {
                this.shouldSerialize["mounts"] = true;
                this.mounts = value;
            }
        }

        /// <summary>
        /// An object describing directory identifiers with value {}.
        /// </summary>
        [JsonProperty("directories")]
        public object Directories
        {
            get
            {
                return this.directories;
            }

            set
            {
                this.shouldSerialize["directories"] = true;
                this.directories = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerSharedFileSystems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMounts()
        {
            this.shouldSerialize["mounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDirectories()
        {
            this.shouldSerialize["directories"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMounts()
        {
            return this.shouldSerialize["mounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDirectories()
        {
            return this.shouldSerialize["directories"];
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
            return obj is ServerSharedFileSystems other &&                ((this.Mounts == null && other.Mounts == null) || (this.Mounts?.Equals(other.Mounts) == true)) &&
                ((this.Directories == null && other.Directories == null) || (this.Directories?.Equals(other.Directories) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mounts = {(this.Mounts == null ? "null" : this.Mounts.ToString())}");
            toStringOutput.Add($"Directories = {(this.Directories == null ? "null" : this.Directories.ToString())}");
        }
    }
}