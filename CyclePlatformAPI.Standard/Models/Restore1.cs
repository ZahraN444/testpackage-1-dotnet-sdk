// <copyright file="Restore1.cs" company="APIMatic">
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
    /// Restore1.
    /// </summary>
    public class Restore1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Restore1"/> class.
        /// </summary>
        public Restore1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Restore1"/> class.
        /// </summary>
        /// <param name="command">command.</param>
        /// <param name="timeout">timeout.</param>
        public Restore1(
            string command,
            string timeout = null)
        {
            this.Command = command;
            this.Timeout = timeout;
        }

        /// <summary>
        /// The command to run for restoring from a backup.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }

        /// <summary>
        /// The time in seconds for the restore to attempt to complete before timing out.
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Restore1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Restore1 other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.Timeout == null && other.Timeout == null) || (this.Timeout?.Equals(other.Timeout) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command)}");
            toStringOutput.Add($"this.Timeout = {(this.Timeout == null ? "null" : this.Timeout)}");
        }
    }
}