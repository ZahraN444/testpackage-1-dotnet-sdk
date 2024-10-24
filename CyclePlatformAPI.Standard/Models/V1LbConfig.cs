// <copyright file="V1LbConfig.cs" company="APIMatic">
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
    /// V1LbConfig.
    /// </summary>
    public class V1LbConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbConfig"/> class.
        /// </summary>
        public V1LbConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1LbConfig"/> class.
        /// </summary>
        /// <param name="controllers">controllers.</param>
        /// <param name="controllerTemplate">controller_template.</param>
        public V1LbConfig(
            List<Models.V1LbController> controllers,
            Models.V1LbController controllerTemplate = null)
        {
            this.Controllers = controllers;
            this.ControllerTemplate = controllerTemplate;
        }

        /// <summary>
        /// A configuration for a specific port.
        /// </summary>
        [JsonProperty("controllers")]
        [JsonRequired]
        public List<Models.V1LbController> Controllers { get; set; }

        /// <summary>
        /// Gets or sets ControllerTemplate.
        /// </summary>
        [JsonProperty("controller_template", NullValueHandling = NullValueHandling.Ignore)]
        public Models.V1LbController ControllerTemplate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1LbConfig : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1LbConfig other &&                ((this.Controllers == null && other.Controllers == null) || (this.Controllers?.Equals(other.Controllers) == true)) &&
                ((this.ControllerTemplate == null && other.ControllerTemplate == null) || (this.ControllerTemplate?.Equals(other.ControllerTemplate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Controllers = {(this.Controllers == null ? "null" : $"[{string.Join(", ", this.Controllers)} ]")}");
            toStringOutput.Add($"this.ControllerTemplate = {(this.ControllerTemplate == null ? "null" : this.ControllerTemplate.ToString())}");
        }
    }
}