// <copyright file="Events2.cs" company="APIMatic">
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
    /// Events2.
    /// </summary>
    public class Events2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Events2"/> class.
        /// </summary>
        public Events2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Events2"/> class.
        /// </summary>
        /// <param name="deploy">deploy.</param>
        /// <param name="start">start.</param>
        /// <param name="stop">stop.</param>
        public Events2(
            string deploy = null,
            string start = null,
            string stop = null)
        {
            this.Deploy = deploy;
            this.Start = start;
            this.Stop = stop;
        }

        /// <summary>
        /// A webhook to hit when a container deploy event happens.
        /// </summary>
        [JsonProperty("deploy", NullValueHandling = NullValueHandling.Ignore)]
        public string Deploy { get; set; }

        /// <summary>
        /// A webhook to hit when a container start event happens.
        /// </summary>
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// A webhook to hit when a container stop event happens.
        /// </summary>
        [JsonProperty("stop", NullValueHandling = NullValueHandling.Ignore)]
        public string Stop { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Events2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Events2 other &&                ((this.Deploy == null && other.Deploy == null) || (this.Deploy?.Equals(other.Deploy) == true)) &&
                ((this.Start == null && other.Start == null) || (this.Start?.Equals(other.Start) == true)) &&
                ((this.Stop == null && other.Stop == null) || (this.Stop?.Equals(other.Stop) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deploy = {(this.Deploy == null ? "null" : this.Deploy)}");
            toStringOutput.Add($"this.Start = {(this.Start == null ? "null" : this.Start)}");
            toStringOutput.Add($"this.Stop = {(this.Stop == null ? "null" : this.Stop)}");
        }
    }
}