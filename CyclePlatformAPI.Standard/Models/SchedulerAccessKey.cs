// <copyright file="SchedulerAccessKey.cs" company="APIMatic">
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
    /// SchedulerAccessKey.
    /// </summary>
    public class SchedulerAccessKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerAccessKey"/> class.
        /// </summary>
        public SchedulerAccessKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerAccessKey"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="secret">secret.</param>
        /// <param name="ips">ips.</param>
        public SchedulerAccessKey(
            string name,
            string secret,
            List<string> ips = null)
        {
            this.Name = name;
            this.Secret = secret;
            this.Ips = ips;
        }

        /// <summary>
        /// The name given to this access key
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The access key secret. This should be submitted with requests to a publicly accessible scheduler service.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Whitelisted IPs that are allowed to make requests to the scheduler service.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ips { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SchedulerAccessKey : ({string.Join(", ", toStringOutput)})";
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
            return obj is SchedulerAccessKey other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
        }
    }
}