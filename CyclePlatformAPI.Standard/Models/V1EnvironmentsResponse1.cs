// <copyright file="V1EnvironmentsResponse1.cs" company="APIMatic">
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
    /// V1EnvironmentsResponse1.
    /// </summary>
    public class V1EnvironmentsResponse1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsResponse1"/> class.
        /// </summary>
        public V1EnvironmentsResponse1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsResponse1"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1EnvironmentsResponse1(
            Models.Environment data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Environments are groups of containers with a private network built between them. For more information on environments, see the [main docs](https://docs.cycle.io/environments/overview/).
        /// </summary>
        [JsonProperty("data")]
        public Models.Environment Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsResponse1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsResponse1 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}