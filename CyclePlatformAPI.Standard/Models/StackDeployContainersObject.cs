// <copyright file="StackDeployContainersObject.cs" company="APIMatic">
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
    /// StackDeployContainersObject.
    /// </summary>
    public class StackDeployContainersObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackDeployContainersObject"/> class.
        /// </summary>
        public StackDeployContainersObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackDeployContainersObject"/> class.
        /// </summary>
        /// <param name="reimage">reimage.</param>
        /// <param name="reconfigure">reconfigure.</param>
        public StackDeployContainersObject(
            bool reimage,
            bool reconfigure)
        {
            this.Reimage = reimage;
            this.Reconfigure = reconfigure;
        }

        /// <summary>
        /// A boolean where true represents the container is to be reimaged.
        /// </summary>
        [JsonProperty("reimage")]
        public bool Reimage { get; set; }

        /// <summary>
        /// A boolean where true represents the container is to be reconfigured.
        /// </summary>
        [JsonProperty("reconfigure")]
        public bool Reconfigure { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackDeployContainersObject : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackDeployContainersObject other &&                this.Reimage.Equals(other.Reimage) &&
                this.Reconfigure.Equals(other.Reconfigure);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reimage = {this.Reimage}");
            toStringOutput.Add($"this.Reconfigure = {this.Reconfigure}");
        }
    }
}