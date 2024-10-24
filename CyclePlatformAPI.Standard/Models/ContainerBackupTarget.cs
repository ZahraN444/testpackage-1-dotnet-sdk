// <copyright file="ContainerBackupTarget.cs" company="APIMatic">
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
    /// ContainerBackupTarget.
    /// </summary>
    public class ContainerBackupTarget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerBackupTarget"/> class.
        /// </summary>
        public ContainerBackupTarget()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerBackupTarget"/> class.
        /// </summary>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="path">path.</param>
        /// <param name="fileId">file_id.</param>
        /// <param name="size">size.</param>
        public ContainerBackupTarget(
            string integrationId,
            string path,
            string fileId,
            int size)
        {
            this.IntegrationId = integrationId;
            this.Path = path;
            this.FileId = fileId;
            this.Size = size;
        }

        /// <summary>
        /// Either a resource ID (objectid - i.e. 651586fca6078e98982dbd90) or a resource Identifier (human-readable)
        /// </summary>
        [JsonProperty("integration_id")]
        public string IntegrationId { get; set; }

        /// <summary>
        /// The target for where to store the Container Backup on the destination service.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets FileId.
        /// </summary>
        [JsonProperty("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// The total size of the backup.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerBackupTarget : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerBackupTarget other &&                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.FileId == null && other.FileId == null) || (this.FileId?.Equals(other.FileId) == true)) &&
                this.Size.Equals(other.Size);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"this.FileId = {(this.FileId == null ? "null" : this.FileId)}");
            toStringOutput.Add($"this.Size = {this.Size}");
        }
    }
}