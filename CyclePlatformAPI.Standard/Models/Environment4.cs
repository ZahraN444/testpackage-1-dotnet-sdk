// <copyright file="Environment4.cs" company="APIMatic">
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
    /// Environment4.
    /// </summary>
    public class Environment4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Environment4"/> class.
        /// </summary>
        public Environment4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment4"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="manage">manage.</param>
        public Environment4(
            string id,
            bool manage)
        {
            this.Id = id;
            this.Manage = manage;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A boolean where true represents this environment can be managed by the membership (i.e. its not just read-only).
        /// </summary>
        [JsonProperty("manage")]
        public bool Manage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Environment4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Environment4 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Manage.Equals(other.Manage);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Manage = {this.Manage}");
        }
    }
}