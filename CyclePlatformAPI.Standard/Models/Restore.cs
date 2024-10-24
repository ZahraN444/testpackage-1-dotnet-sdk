// <copyright file="Restore.cs" company="APIMatic">
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
    /// Restore.
    /// </summary>
    public class Restore
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Restore"/> class.
        /// </summary>
        public Restore()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Restore"/> class.
        /// </summary>
        /// <param name="command">command.</param>
        /// <param name="timeout">timeout.</param>
        public Restore(
            string command,
            RestoreTimeout timeout)
        {
            this.Command = command;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Gets or sets Command.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// The time in seconds for the restore to attempt to complete before timing out.
        /// </summary>
        [JsonProperty("timeout")]
        public RestoreTimeout Timeout { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Restore : ({string.Join(", ", toStringOutput)})";
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
            return obj is Restore other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.Timeout == null && other.Timeout == null) || (this.Timeout?.Equals(other.Timeout) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command)}");
            toStringOutput.Add($"Timeout = {(this.Timeout == null ? "null" : this.Timeout.ToString())}");
        }
    }
}