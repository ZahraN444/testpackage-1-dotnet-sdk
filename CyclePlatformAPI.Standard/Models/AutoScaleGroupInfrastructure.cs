// <copyright file="AutoScaleGroupInfrastructure.cs" company="APIMatic">
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
    /// AutoScaleGroupInfrastructure.
    /// </summary>
    public class AutoScaleGroupInfrastructure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupInfrastructure"/> class.
        /// </summary>
        public AutoScaleGroupInfrastructure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupInfrastructure"/> class.
        /// </summary>
        /// <param name="models">models.</param>
        public AutoScaleGroupInfrastructure(
            List<Models.Model> models)
        {
            this.Models = models;
        }

        /// <summary>
        /// Gets or sets Models.
        /// </summary>
        [JsonProperty("models")]
        public List<Models.Model> Models { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoScaleGroupInfrastructure : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroupInfrastructure other &&                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Models = {(this.Models == null ? "null" : $"[{string.Join(", ", this.Models)} ]")}");
        }
    }
}