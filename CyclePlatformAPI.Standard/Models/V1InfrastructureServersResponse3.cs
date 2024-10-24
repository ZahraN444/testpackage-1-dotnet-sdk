// <copyright file="V1InfrastructureServersResponse3.cs" company="APIMatic">
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
    /// V1InfrastructureServersResponse3.
    /// </summary>
    public class V1InfrastructureServersResponse3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersResponse3"/> class.
        /// </summary>
        public V1InfrastructureServersResponse3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1InfrastructureServersResponse3"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public V1InfrastructureServersResponse3(
            Models.Server data)
        {
            this.Data = data;
        }

        /// <summary>
        /// The server resource, referring to servers that have been deployed to a Cycle hub.
        /// </summary>
        [JsonProperty("data")]
        public Models.Server Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1InfrastructureServersResponse3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1InfrastructureServersResponse3 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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