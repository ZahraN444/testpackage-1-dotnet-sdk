// <copyright file="Config4.cs" company="APIMatic">
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
    /// Config4.
    /// </summary>
    public class Config4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config4"/> class.
        /// </summary>
        public Config4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config4"/> class.
        /// </summary>
        /// <param name="mPublic">public.</param>
        /// <param name="accessKeys">access_keys.</param>
        public Config4(
            bool? mPublic = null,
            List<Models.SchedulerAccessKey> accessKeys = null)
        {
            this.MPublic = mPublic;
            this.AccessKeys = accessKeys;
        }

        /// <summary>
        /// If true, the scheduler service API will be exposed publicly via the load balancer. This is useful for allowing external services spin up function containers using custom logic.
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MPublic { get; set; }

        /// <summary>
        /// Gets or sets AccessKeys.
        /// </summary>
        [JsonProperty("access_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SchedulerAccessKey> AccessKeys { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config4 other &&                ((this.MPublic == null && other.MPublic == null) || (this.MPublic?.Equals(other.MPublic) == true)) &&
                ((this.AccessKeys == null && other.AccessKeys == null) || (this.AccessKeys?.Equals(other.AccessKeys) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MPublic = {(this.MPublic == null ? "null" : this.MPublic.ToString())}");
            toStringOutput.Add($"this.AccessKeys = {(this.AccessKeys == null ? "null" : $"[{string.Join(", ", this.AccessKeys)} ]")}");
        }
    }
}