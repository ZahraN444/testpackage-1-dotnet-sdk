// <copyright file="Backups.cs" company="APIMatic">
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
    /// Backups.
    /// </summary>
    public class Backups
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backups"/> class.
        /// </summary>
        public Backups()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backups"/> class.
        /// </summary>
        /// <param name="destination">destination.</param>
        /// <param name="backup">backup.</param>
        /// <param name="retention">retention.</param>
        /// <param name="restore">restore.</param>
        public Backups(
            string destination,
            Models.Backup backup,
            BackupsRetention retention,
            Models.Restore restore = null)
        {
            this.Destination = destination;
            this.Backup = backup;
            this.Restore = restore;
            this.Retention = retention;
        }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets Backup.
        /// </summary>
        [JsonProperty("backup")]
        public Models.Backup Backup { get; set; }

        /// <summary>
        /// Gets or sets Restore.
        /// </summary>
        [JsonProperty("restore", NullValueHandling = NullValueHandling.Include)]
        public Models.Restore Restore { get; set; }

        /// <summary>
        /// How long the platform will keep backups. Default is 1 year.
        /// </summary>
        [JsonProperty("retention")]
        public BackupsRetention Retention { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Backups : ({string.Join(", ", toStringOutput)})";
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
            return obj is Backups other &&                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
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
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination)}");
            toStringOutput.Add($"this.Backup = {(this.Backup == null ? "null" : this.Backup.ToString())}");
            toStringOutput.Add($"this.Restore = {(this.Restore == null ? "null" : this.Restore.ToString())}");
            toStringOutput.Add($"Retention = {(this.Retention == null ? "null" : this.Retention.ToString())}");
        }
    }
}