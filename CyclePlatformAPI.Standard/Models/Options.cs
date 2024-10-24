// <copyright file="Options.cs" company="APIMatic">
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
    /// Options.
    /// </summary>
    public class Options
    {
        private bool? useBaseHostname;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "use_base_hostname", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Options"/> class.
        /// </summary>
        public Options()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Options"/> class.
        /// </summary>
        /// <param name="useBaseHostname">use_base_hostname.</param>
        public Options(
            bool? useBaseHostname = null)
        {
            if (useBaseHostname != null)
            {
                this.UseBaseHostname = useBaseHostname;
            }

        }

        /// <summary>
        /// Gets or sets UseBaseHostname.
        /// </summary>
        [JsonProperty("use_base_hostname")]
        public bool? UseBaseHostname
        {
            get
            {
                return this.useBaseHostname;
            }

            set
            {
                this.shouldSerialize["use_base_hostname"] = true;
                this.useBaseHostname = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Options : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUseBaseHostname()
        {
            this.shouldSerialize["use_base_hostname"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUseBaseHostname()
        {
            return this.shouldSerialize["use_base_hostname"];
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
            return obj is Options other &&                ((this.UseBaseHostname == null && other.UseBaseHostname == null) || (this.UseBaseHostname?.Equals(other.UseBaseHostname) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UseBaseHostname = {(this.UseBaseHostname == null ? "null" : this.UseBaseHostname.ToString())}");
        }
    }
}