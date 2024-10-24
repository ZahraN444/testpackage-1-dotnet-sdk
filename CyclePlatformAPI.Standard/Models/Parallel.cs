// <copyright file="Parallel.cs" company="APIMatic">
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
    /// Parallel.
    /// </summary>
    public class Parallel
    {
        private string subQueue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "sub_queue", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Parallel"/> class.
        /// </summary>
        public Parallel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parallel"/> class.
        /// </summary>
        /// <param name="tasks">tasks.</param>
        /// <param name="subQueue">sub_queue.</param>
        public Parallel(
            bool tasks,
            string subQueue = null)
        {
            if (subQueue != null)
            {
                this.SubQueue = subQueue;
            }

            this.Tasks = tasks;
        }

        /// <summary>
        /// Gets or sets SubQueue.
        /// </summary>
        [JsonProperty("sub_queue")]
        public string SubQueue
        {
            get
            {
                return this.subQueue;
            }

            set
            {
                this.shouldSerialize["sub_queue"] = true;
                this.subQueue = value;
            }
        }

        /// <summary>
        /// Gets or sets Tasks.
        /// </summary>
        [JsonProperty("tasks")]
        public bool Tasks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Parallel : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubQueue()
        {
            this.shouldSerialize["sub_queue"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubQueue()
        {
            return this.shouldSerialize["sub_queue"];
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
            return obj is Parallel other &&                ((this.SubQueue == null && other.SubQueue == null) || (this.SubQueue?.Equals(other.SubQueue) == true)) &&
                this.Tasks.Equals(other.Tasks);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubQueue = {(this.SubQueue == null ? "null" : this.SubQueue)}");
            toStringOutput.Add($"this.Tasks = {this.Tasks}");
        }
    }
}