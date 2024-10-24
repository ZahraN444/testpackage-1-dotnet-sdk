// <copyright file="V1PipelinesRequest1.cs" company="APIMatic">
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
    /// V1PipelinesRequest1.
    /// </summary>
    public class V1PipelinesRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PipelinesRequest1"/> class.
        /// </summary>
        public V1PipelinesRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1PipelinesRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mDynamic">dynamic.</param>
        /// <param name="stages">stages.</param>
        /// <param name="disable">disable.</param>
        public V1PipelinesRequest1(
            string name = null,
            bool? mDynamic = null,
            List<Models.PipelineStage> stages = null,
            bool? disable = null)
        {
            this.Name = name;
            this.MDynamic = mDynamic;
            this.Stages = stages;
            this.Disable = disable;
        }

        /// <summary>
        /// A name for the Pipeline.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Setting to true enables variable and other advanced logic support on this Pipeline. This is a one-way toggle. Once set to true, it cannot be set back to false.
        /// </summary>
        [JsonProperty("dynamic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MDynamic { get; set; }

        /// <summary>
        /// An array of stages.
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PipelineStage> Stages { get; set; }

        /// <summary>
        /// A boolean where true signifies the Pipeline is disabled.
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1PipelinesRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1PipelinesRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MDynamic == null && other.MDynamic == null) || (this.MDynamic?.Equals(other.MDynamic) == true)) &&
                ((this.Stages == null && other.Stages == null) || (this.Stages?.Equals(other.Stages) == true)) &&
                ((this.Disable == null && other.Disable == null) || (this.Disable?.Equals(other.Disable) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MDynamic = {(this.MDynamic == null ? "null" : this.MDynamic.ToString())}");
            toStringOutput.Add($"this.Stages = {(this.Stages == null ? "null" : $"[{string.Join(", ", this.Stages)} ]")}");
            toStringOutput.Add($"this.Disable = {(this.Disable == null ? "null" : this.Disable.ToString())}");
        }
    }
}