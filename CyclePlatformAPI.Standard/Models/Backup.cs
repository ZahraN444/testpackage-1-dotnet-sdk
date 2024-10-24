// <copyright file="Backup.cs" company="APIMatic">
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
    /// Backup.
    /// </summary>
    public class Backup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backup"/> class.
        /// </summary>
        public Backup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backup"/> class.
        /// </summary>
        /// <param name="command">command.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="cronString">cron_string.</param>
        public Backup(
            string command,
            BackupTimeout timeout,
            string cronString = null)
        {
            this.Command = command;
            this.Timeout = timeout;
            this.CronString = cronString;
        }

        /// <summary>
        /// Gets or sets Command.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// How long the backup will attempt to run before timing out.
        /// </summary>
        [JsonProperty("timeout")]
        public BackupTimeout Timeout { get; set; }

        /// <summary>
        /// Gets or sets CronString.
        /// </summary>
        [JsonProperty("cron_string", NullValueHandling = NullValueHandling.Include)]
        public string CronString { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Backup : ({string.Join(", ", toStringOutput)})";
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
            return obj is Backup other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.Timeout == null && other.Timeout == null) || (this.Timeout?.Equals(other.Timeout) == true)) &&
                ((this.CronString == null && other.CronString == null) || (this.CronString?.Equals(other.CronString) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command)}");
            toStringOutput.Add($"Timeout = {(this.Timeout == null ? "null" : this.Timeout.ToString())}");
            toStringOutput.Add($"this.CronString = {(this.CronString == null ? "null" : this.CronString)}");
        }
    }
}