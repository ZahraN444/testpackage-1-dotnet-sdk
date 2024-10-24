// <copyright file="UserScope.cs" company="APIMatic">
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
    /// UserScope.
    /// </summary>
    public class UserScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserScope"/> class.
        /// </summary>
        public UserScope()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserScope"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">id.</param>
        public UserScope(
            Models.Type4Enum type,
            string id)
        {
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// The type of user that created the resource.
        /// </summary>
        [JsonProperty("type")]
        public Models.Type4Enum Type { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserScope : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserScope other &&                this.Type.Equals(other.Type) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
        }
    }
}