// <copyright file="Migration.cs" company="APIMatic">
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
    /// Migration.
    /// </summary>
    public class Migration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Migration"/> class.
        /// </summary>
        public Migration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Migration"/> class.
        /// </summary>
        /// <param name="to">to.</param>
        /// <param name="from">from.</param>
        /// <param name="started">started.</param>
        /// <param name="completed">completed.</param>
        /// <param name="key">key.</param>
        /// <param name="copyVolumes">copy_volumes.</param>
        public Migration(
            MigrationTo to = null,
            MigrationFrom from = null,
            DateTime? started = null,
            DateTime? completed = null,
            string key = null,
            bool? copyVolumes = null)
        {
            this.To = to;
            this.From = from;
            this.Started = started;
            this.Completed = completed;
            this.Key = key;
            this.CopyVolumes = copyVolumes;
        }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationTo To { get; set; }

        /// <summary>
        /// Gets or sets From.
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationFrom From { get; set; }

        /// <summary>
        /// A timestamp of when the migration was started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Started { get; set; }

        /// <summary>
        /// A timestamp of when the migration was completed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Completed { get; set; }

        /// <summary>
        /// A key used by the platform to verify the migration.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// A boolean where true represents the volumes for the instance should be copied to the new server as well.
        /// </summary>
        [JsonProperty("copy_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CopyVolumes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Migration : ({string.Join(", ", toStringOutput)})";
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
            return obj is Migration other &&                ((this.To == null && other.To == null) || (this.To?.Equals(other.To) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true)) &&
                ((this.Started == null && other.Started == null) || (this.Started?.Equals(other.Started) == true)) &&
                ((this.Completed == null && other.Completed == null) || (this.Completed?.Equals(other.Completed) == true)) &&
                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.CopyVolumes == null && other.CopyVolumes == null) || (this.CopyVolumes?.Equals(other.CopyVolumes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"To = {(this.To == null ? "null" : this.To.ToString())}");
            toStringOutput.Add($"From = {(this.From == null ? "null" : this.From.ToString())}");
            toStringOutput.Add($"this.Started = {(this.Started == null ? "null" : this.Started.ToString())}");
            toStringOutput.Add($"this.Completed = {(this.Completed == null ? "null" : this.Completed.ToString())}");
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
            toStringOutput.Add($"this.CopyVolumes = {(this.CopyVolumes == null ? "null" : this.CopyVolumes.ToString())}");
        }
    }
}