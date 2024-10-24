// <copyright file="CreateAutoScaleGroupResponse.cs" company="APIMatic">
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
    /// CreateAutoScaleGroupResponse.
    /// </summary>
    public class CreateAutoScaleGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutoScaleGroupResponse"/> class.
        /// </summary>
        public CreateAutoScaleGroupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAutoScaleGroupResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public CreateAutoScaleGroupResponse(
            Models.AutoScaleGroup data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.AutoScaleGroup Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateAutoScaleGroupResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateAutoScaleGroupResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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