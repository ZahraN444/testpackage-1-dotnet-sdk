// <copyright file="Deployments.cs" company="APIMatic">
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
    /// Deployments.
    /// </summary>
    public class Deployments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployments"/> class.
        /// </summary>
        public Deployments()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployments"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        public Deployments(
            Dictionary<string, string> tags)
        {
            this.Tags = tags;
        }

        /// <summary>
        /// A map of custom tags to deployment versions. Allows for defining a custom, persistent tag with a changing version number.
        /// For example, `dev -> v1.2.3-dev`. This is useful when dealing with DNS LINKED records, where you always want dev.example.com to point to the
        /// `dev` version of your app within an environment, where you can continuously deploy and update it without needing to change the record. It is
        /// even more useful when you have multiple LINKED records, and you update i.e. `prod`` tag to point to a new version, all records using the `prod` tag
        /// are switched at once.
        /// </summary>
        [JsonProperty("tags")]
        public Dictionary<string, string> Tags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Deployments : ({string.Join(", ", toStringOutput)})";
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
            return obj is Deployments other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Tags = {(this.Tags == null ? "null" : this.Tags.ToString())}");
        }
    }
}