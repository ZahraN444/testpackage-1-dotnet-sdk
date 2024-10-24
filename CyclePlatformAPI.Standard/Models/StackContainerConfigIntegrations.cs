// <copyright file="StackContainerConfigIntegrations.cs" company="APIMatic">
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
    /// StackContainerConfigIntegrations.
    /// </summary>
    public class StackContainerConfigIntegrations
    {
        private Models.Webhooks webhooks;
        private Models.LetsEncrypt letsEncrypt;
        private List<Models.File2> files;
        private Models.Backups backups;
        private Dictionary<string, Models.SharedFileSystems> sharedFileSystems;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "webhooks", false },
            { "lets_encrypt", false },
            { "files", false },
            { "backups", false },
            { "shared_file_systems", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigIntegrations"/> class.
        /// </summary>
        public StackContainerConfigIntegrations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigIntegrations"/> class.
        /// </summary>
        /// <param name="webhooks">webhooks.</param>
        /// <param name="letsEncrypt">lets_encrypt.</param>
        /// <param name="files">files.</param>
        /// <param name="backups">backups.</param>
        /// <param name="sharedFileSystems">shared_file_systems.</param>
        public StackContainerConfigIntegrations(
            Models.Webhooks webhooks = null,
            Models.LetsEncrypt letsEncrypt = null,
            List<Models.File2> files = null,
            Models.Backups backups = null,
            Dictionary<string, Models.SharedFileSystems> sharedFileSystems = null)
        {
            if (webhooks != null)
            {
                this.Webhooks = webhooks;
            }

            if (letsEncrypt != null)
            {
                this.LetsEncrypt = letsEncrypt;
            }

            if (files != null)
            {
                this.Files = files;
            }

            if (backups != null)
            {
                this.Backups = backups;
            }

            if (sharedFileSystems != null)
            {
                this.SharedFileSystems = sharedFileSystems;
            }

        }

        /// <summary>
        /// Gets or sets Webhooks.
        /// </summary>
        [JsonProperty("webhooks")]
        public Models.Webhooks Webhooks
        {
            get
            {
                return this.webhooks;
            }

            set
            {
                this.shouldSerialize["webhooks"] = true;
                this.webhooks = value;
            }
        }

        /// <summary>
        /// Gets or sets LetsEncrypt.
        /// </summary>
        [JsonProperty("lets_encrypt")]
        public Models.LetsEncrypt LetsEncrypt
        {
            get
            {
                return this.letsEncrypt;
            }

            set
            {
                this.shouldSerialize["lets_encrypt"] = true;
                this.letsEncrypt = value;
            }
        }

        /// <summary>
        /// Gets or sets Files.
        /// </summary>
        [JsonProperty("files")]
        public List<Models.File2> Files
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

        /// <summary>
        /// Gets or sets Backups.
        /// </summary>
        [JsonProperty("backups")]
        public Models.Backups Backups
        {
            get
            {
                return this.backups;
            }

            set
            {
                this.shouldSerialize["backups"] = true;
                this.backups = value;
            }
        }

        /// <summary>
        /// Gets or sets SharedFileSystems.
        /// </summary>
        [JsonProperty("shared_file_systems")]
        public Dictionary<string, Models.SharedFileSystems> SharedFileSystems
        {
            get
            {
                return this.sharedFileSystems;
            }

            set
            {
                this.shouldSerialize["shared_file_systems"] = true;
                this.sharedFileSystems = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainerConfigIntegrations : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWebhooks()
        {
            this.shouldSerialize["webhooks"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLetsEncrypt()
        {
            this.shouldSerialize["lets_encrypt"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFiles()
        {
            this.shouldSerialize["files"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBackups()
        {
            this.shouldSerialize["backups"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSharedFileSystems()
        {
            this.shouldSerialize["shared_file_systems"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWebhooks()
        {
            return this.shouldSerialize["webhooks"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLetsEncrypt()
        {
            return this.shouldSerialize["lets_encrypt"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFiles()
        {
            return this.shouldSerialize["files"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBackups()
        {
            return this.shouldSerialize["backups"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSharedFileSystems()
        {
            return this.shouldSerialize["shared_file_systems"];
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
            return obj is StackContainerConfigIntegrations other &&                ((this.Webhooks == null && other.Webhooks == null) || (this.Webhooks?.Equals(other.Webhooks) == true)) &&
                ((this.LetsEncrypt == null && other.LetsEncrypt == null) || (this.LetsEncrypt?.Equals(other.LetsEncrypt) == true)) &&
                ((this.Files == null && other.Files == null) || (this.Files?.Equals(other.Files) == true)) &&
                ((this.Backups == null && other.Backups == null) || (this.Backups?.Equals(other.Backups) == true)) &&
                ((this.SharedFileSystems == null && other.SharedFileSystems == null) || (this.SharedFileSystems?.Equals(other.SharedFileSystems) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhooks = {(this.Webhooks == null ? "null" : this.Webhooks.ToString())}");
            toStringOutput.Add($"this.LetsEncrypt = {(this.LetsEncrypt == null ? "null" : this.LetsEncrypt.ToString())}");
            toStringOutput.Add($"this.Files = {(this.Files == null ? "null" : $"[{string.Join(", ", this.Files)} ]")}");
            toStringOutput.Add($"this.Backups = {(this.Backups == null ? "null" : this.Backups.ToString())}");
            toStringOutput.Add($"SharedFileSystems = {(this.SharedFileSystems == null ? "null" : this.SharedFileSystems.ToString())}");
        }
    }
}