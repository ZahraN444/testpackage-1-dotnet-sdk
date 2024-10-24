// <copyright file="Match1.cs" company="APIMatic">
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
    /// Match1.
    /// </summary>
    public class Match1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Match1"/> class.
        /// </summary>
        public Match1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Match1"/> class.
        /// </summary>
        /// <param name="container">container.</param>
        /// <param name="tag">tag.</param>
        public Match1(
            string container,
            Match1Tag tag = null)
        {
            this.Container = container;
            this.Tag = tag;
        }

        /// <summary>
        /// The identifier of the container in the environment this record should point to.
        /// </summary>
        [JsonProperty("container")]
        public string Container { get; set; }

        /// <summary>
        /// The deployment tag that this record should point to. The tags are set on the root of an environment and map to a deployment version.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Match1Tag Tag { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Match1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Match1 other &&                ((this.Container == null && other.Container == null) || (this.Container?.Equals(other.Container) == true)) &&
                ((this.Tag == null && other.Tag == null) || (this.Tag?.Equals(other.Tag) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Container = {(this.Container == null ? "null" : this.Container)}");
            toStringOutput.Add($"Tag = {(this.Tag == null ? "null" : this.Tag.ToString())}");
        }
    }
}