// <copyright file="ContainerIntegrations.cs" company="APIMatic">
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
    /// ContainerIntegrations.
    /// </summary>
    public class ContainerIntegrations
    {
        private Dictionary<string, Models.SharedFileSystems> sharedFileSystems;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "shared_file_systems", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIntegrations"/> class.
        /// </summary>
        public ContainerIntegrations()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerIntegrations"/> class.
        /// </summary>
        /// <param name="webhooks">webhooks.</param>
        /// <param name="files">files.</param>
        /// <param name="letsEncrypt">lets_encrypt.</param>
        /// <param name="backups">backups.</param>
        /// <param name="sharedFileSystems">shared_file_systems.</param>
        public ContainerIntegrations(
            Models.Webhooks1 webhooks = null,
            List<Models.File4> files = null,
            Models.LetsEncrypt1 letsEncrypt = null,
            Models.Backups1 backups = null,
            Dictionary<string, Models.SharedFileSystems> sharedFileSystems = null)
        {
            this.Webhooks = webhooks;
            this.Files = files;
            this.LetsEncrypt = letsEncrypt;
            this.Backups = backups;
            if (sharedFileSystems != null)
            {
                this.SharedFileSystems = sharedFileSystems;
            }

        }

        /// <summary>
        /// Webhooks that can be set for specific event reporting and advanced container configurations.
        /// </summary>
        [JsonProperty("webhooks", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Webhooks1 Webhooks { get; set; }

        /// <summary>
        /// Inject remotely hosted files into container instances at runtime.
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.File4> Files { get; set; }

        /// <summary>
        /// Configuration settings to embed a TLS certificate in the container.
        /// </summary>
        [JsonProperty("lets_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LetsEncrypt1 LetsEncrypt { get; set; }

        /// <summary>
        /// Automated backups configuration for the given container.
        /// </summary>
        [JsonProperty("backups", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Backups1 Backups { get; set; }

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

            return $"ContainerIntegrations : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerIntegrations other &&                ((this.Webhooks == null && other.Webhooks == null) || (this.Webhooks?.Equals(other.Webhooks) == true)) &&
                ((this.Files == null && other.Files == null) || (this.Files?.Equals(other.Files) == true)) &&
                ((this.LetsEncrypt == null && other.LetsEncrypt == null) || (this.LetsEncrypt?.Equals(other.LetsEncrypt) == true)) &&
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
            toStringOutput.Add($"this.Files = {(this.Files == null ? "null" : $"[{string.Join(", ", this.Files)} ]")}");
            toStringOutput.Add($"this.LetsEncrypt = {(this.LetsEncrypt == null ? "null" : this.LetsEncrypt.ToString())}");
            toStringOutput.Add($"this.Backups = {(this.Backups == null ? "null" : this.Backups.ToString())}");
            toStringOutput.Add($"SharedFileSystems = {(this.SharedFileSystems == null ? "null" : this.SharedFileSystems.ToString())}");
        }
    }
}