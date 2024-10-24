// <copyright file="Evacuate.cs" company="APIMatic">
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
    /// Evacuate.
    /// </summary>
    public class Evacuate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Evacuate"/> class.
        /// </summary>
        public Evacuate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Evacuate"/> class.
        /// </summary>
        /// <param name="started">started.</param>
        public Evacuate(
            DateTime started)
        {
            this.Started = started;
        }

        /// <summary>
        /// The time when this server began evacuating instances.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Evacuate : ({string.Join(", ", toStringOutput)})";
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
            return obj is Evacuate other &&                this.Started.Equals(other.Started);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Started = {this.Started}");
        }
    }
}