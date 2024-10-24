// <copyright file="Constraints1.cs" company="APIMatic">
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
    /// Constraints1.
    /// </summary>
    public class Constraints1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints1"/> class.
        /// </summary>
        public Constraints1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints1"/> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="secrets">secrets.</param>
        public Constraints1(
            Models.Node1 node = null,
            List<string> secrets = null)
        {
            this.Node = node;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Constraint settings related to which nodes an instance can be deployed to.
        /// </summary>
        [JsonProperty("node", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Node1 Node { get; set; }

        /// <summary>
        /// Gets or sets Secrets.
        /// </summary>
        [JsonProperty("secrets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Secrets { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Constraints1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Constraints1 other &&                ((this.Node == null && other.Node == null) || (this.Node?.Equals(other.Node) == true)) &&
                ((this.Secrets == null && other.Secrets == null) || (this.Secrets?.Equals(other.Secrets) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Node = {(this.Node == null ? "null" : this.Node.ToString())}");
            toStringOutput.Add($"this.Secrets = {(this.Secrets == null ? "null" : $"[{string.Join(", ", this.Secrets)} ]")}");
        }
    }
}