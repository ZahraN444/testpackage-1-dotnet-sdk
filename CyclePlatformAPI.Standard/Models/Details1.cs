// <copyright file="Details1.cs" company="APIMatic">
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
    /// Details1.
    /// </summary>
    public class Details1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details1"/> class.
        /// </summary>
        public Details1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details1"/> class.
        /// </summary>
        /// <param name="connections">connections.</param>
        public Details1(
            object connections)
        {
            this.Connections = connections;
        }

        /// <summary>
        /// Gets or sets Connections.
        /// </summary>
        [JsonProperty("connections")]
        public object Connections { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details1 other &&                ((this.Connections == null && other.Connections == null) || (this.Connections?.Equals(other.Connections) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Connections = {(this.Connections == null ? "null" : this.Connections.ToString())}");
        }
    }
}