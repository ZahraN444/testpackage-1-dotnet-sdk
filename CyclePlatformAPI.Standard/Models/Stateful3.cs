// <copyright file="Stateful3.cs" company="APIMatic">
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
    /// Stateful3.
    /// </summary>
    public class Stateful3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful3"/> class.
        /// </summary>
        public Stateful3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful3"/> class.
        /// </summary>
        /// <param name="copyVolumes">copy_volumes.</param>
        public Stateful3(
            bool copyVolumes)
        {
            this.CopyVolumes = copyVolumes;
        }

        /// <summary>
        /// A boolean where true represents the desire to copy the contents of the volume for a given stateful instance with the migration.
        /// </summary>
        [JsonProperty("copy_volumes")]
        public bool CopyVolumes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stateful3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stateful3 other &&                this.CopyVolumes.Equals(other.CopyVolumes);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CopyVolumes = {this.CopyVolumes}");
        }
    }
}