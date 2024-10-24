// <copyright file="V1InfrastructureServersRequest1.cs" company="APIMatic">
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
    /// V1InfrastructureServersRequest1.
    /// </summary>
    public class V1InfrastructureServersRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersRequest1"/> class.
        /// </summary>
        public V1InfrastructureServersRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersRequest1"/> class.
        /// </summary>
        /// <param name="constraints">constraints.</param>
        public V1InfrastructureServersRequest1(
            Models.Constraints2 constraints)
        {
            this.Constraints = constraints;
        }

        /// <summary>
        /// Server constriants.
        /// </summary>
        [JsonProperty("constraints")]
        public Models.Constraints2 Constraints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureServersRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureServersRequest1 other &&                ((this.Constraints == null && other.Constraints == null) || (this.Constraints?.Equals(other.Constraints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Constraints = {(this.Constraints == null ? "null" : this.Constraints.ToString())}");
        }
    }
}