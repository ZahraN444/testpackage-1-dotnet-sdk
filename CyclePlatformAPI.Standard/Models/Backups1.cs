// <copyright file="Backups1.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Backups1.
    /// </summary>
    public class Backups1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backups1"/> class.
        /// </summary>
        public Backups1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backups1"/> class.
        /// </summary>
        /// <param name="backup">backup.</param>
        /// <param name="retention">retention.</param>
        /// <param name="integrationId">integration_id.</param>
        /// <param name="restore">restore.</param>
        public Backups1(
            Models.Backup1 backup,
            Backups1Retention retention,
            string integrationId = null,
            Models.Restore1 restore = null)
        {
            this.IntegrationId = integrationId;
            this.Backup = backup;
            this.Restore = restore;
            this.Retention = retention;
        }

        /// <summary>
        /// Either a resource ID (objectid - i.e. 651586fca6078e98982dbd90) or a resource Identifier (human-readable)
        /// </summary>
        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Configuration settings for each backup.
        /// </summary>
        [JsonProperty("backup")]
        public Models.Backup1 Backup { get; set; }

        /// <summary>
        /// Configuration settings for restoring from a backup.
        /// </summary>
        [JsonProperty("restore", NullValueHandling = NullValueHandling.Include)]
        public Models.Restore1 Restore { get; set; }

        /// <summary>
        /// How long the platform will keep backups. Default is 1 year.
        /// </summary>
        [JsonProperty("retention")]
        public Backups1Retention Retention { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Backups1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Backups1 other &&                ((this.IntegrationId == null && other.IntegrationId == null) || (this.IntegrationId?.Equals(other.IntegrationId) == true)) &&
                ((this.Backup == null && other.Backup == null) || (this.Backup?.Equals(other.Backup) == true)) &&
                ((this.Restore == null && other.Restore == null) || (this.Restore?.Equals(other.Restore) == true)) &&
                ((this.Retention == null && other.Retention == null) || (this.Retention?.Equals(other.Retention) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IntegrationId = {(this.IntegrationId == null ? "null" : this.IntegrationId)}");
            toStringOutput.Add($"this.Backup = {(this.Backup == null ? "null" : this.Backup.ToString())}");
            toStringOutput.Add($"this.Restore = {(this.Restore == null ? "null" : this.Restore.ToString())}");
            toStringOutput.Add($"Retention = {(this.Retention == null ? "null" : this.Retention.ToString())}");
        }
    }
}