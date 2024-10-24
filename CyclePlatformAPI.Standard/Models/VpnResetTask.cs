// <copyright file="VpnResetTask.cs" company="APIMatic">
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
    /// VpnResetTask.
    /// </summary>
    public class VpnResetTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnResetTask"/> class.
        /// </summary>
        public VpnResetTask()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VpnResetTask"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        public VpnResetTask(
            string action)
        {
            this.Action = action;
        }

        /// <summary>
        /// The name of the action to perform.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("action")]
        [JsonRequired]
        public string Action { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VpnResetTask : ({string.Join(", ", toStringOutput)})";
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
            return obj is VpnResetTask other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
        }
    }
}