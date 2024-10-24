// <copyright file="Stateful2.cs" company="APIMatic">
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
    /// Stateful2.
    /// </summary>
    public class Stateful2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful2"/> class.
        /// </summary>
        public Stateful2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful2"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="baseHostname">base_hostname.</param>
        public Stateful2(
            string id,
            string baseHostname)
        {
            this.Id = id;
            this.BaseHostname = baseHostname;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The base hostname for the given instance.
        /// </summary>
        [JsonProperty("base_hostname")]
        public string BaseHostname { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stateful2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stateful2 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.BaseHostname == null && other.BaseHostname == null) || (this.BaseHostname?.Equals(other.BaseHostname) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.BaseHostname = {(this.BaseHostname == null ? "null" : this.BaseHostname)}");
        }
    }
}