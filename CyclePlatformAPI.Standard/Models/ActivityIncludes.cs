// <copyright file="ActivityIncludes.cs" company="APIMatic">
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
    /// ActivityIncludes.
    /// </summary>
    public class ActivityIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityIncludes"/> class.
        /// </summary>
        public ActivityIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityIncludes"/> class.
        /// </summary>
        /// <param name="users">users.</param>
        /// <param name="components">components.</param>
        public ActivityIncludes(
            Models.CreatorInclude users = null,
            Dictionary<string, ComponentsIncludes> components = null)
        {
            this.Users = users;
            this.Components = components;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Users { get; set; }

        /// <summary>
        /// A resource thats assocaited with activity.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ComponentsIncludes> Components { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivityIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityIncludes other &&                ((this.Users == null && other.Users == null) || (this.Users?.Equals(other.Users) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Users = {(this.Users == null ? "null" : this.Users.ToString())}");
            toStringOutput.Add($"Components = {(this.Components == null ? "null" : this.Components.ToString())}");
        }
    }
}