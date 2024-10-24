// <copyright file="Node1.cs" company="APIMatic">
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
    /// Node1.
    /// </summary>
    public class Node1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node1"/> class.
        /// </summary>
        public Node1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node1"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        public Node1(
            Models.Tags1 tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// Lists of server tags that formally declair servers that match the criteria for deployment.
        /// </summary>
        [JsonProperty("tags")]
        public Models.Tags1 Tags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Node1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Node1 other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags.ToString())}");
        }
    }
}