// <copyright file="TaskResponse.cs" company="APIMatic">
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
    /// TaskResponse.
    /// </summary>
    public class TaskResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse"/> class.
        /// </summary>
        public TaskResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        public TaskResponse(
            Models.JobDescriptor data)
        {
            this.Data = data;
        }

        /// <summary>
        /// A Job Descriptor is returned on success by API calls that create jobs. It contains the action that was requested, as well as the ID of the job created as a result.
        /// </summary>
        [JsonProperty("data")]
        public Models.JobDescriptor Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaskResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaskResponse other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
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