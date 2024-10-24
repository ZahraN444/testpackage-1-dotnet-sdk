// <copyright file="Contents11.cs" company="APIMatic">
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
    /// Contents11.
    /// </summary>
    public class Contents11
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents11"/> class.
        /// </summary>
        public Contents11()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents11"/> class.
        /// </summary>
        /// <param name="instanceId">instance_id.</param>
        public Contents11(
            string instanceId)
        {
            this.InstanceId = instanceId;
        }

        /// <summary>
        /// The ID of the instance this Container Backup is being restored to.
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents11 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents11 other &&                ((this.InstanceId == null && other.InstanceId == null) || (this.InstanceId?.Equals(other.InstanceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstanceId = {(this.InstanceId == null ? "null" : this.InstanceId)}");
        }
    }
}