// <copyright file="Host.cs" company="APIMatic">
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
    /// Host.
    /// </summary>
    public class Host
    {
        private bool? exposeProc;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expose_proc", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Host"/> class.
        /// </summary>
        public Host()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Host"/> class.
        /// </summary>
        /// <param name="exposeProc">expose_proc.</param>
        public Host(
            bool? exposeProc = null)
        {
            if (exposeProc != null)
            {
                this.ExposeProc = exposeProc;
            }

        }

        /// <summary>
        /// Gets or sets ExposeProc.
        /// </summary>
        [JsonProperty("expose_proc")]
        public bool? ExposeProc
        {
            get
            {
                return this.exposeProc;
            }

            set
            {
                this.shouldSerialize["expose_proc"] = true;
                this.exposeProc = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Host : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExposeProc()
        {
            this.shouldSerialize["expose_proc"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExposeProc()
        {
            return this.shouldSerialize["expose_proc"];
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
            return obj is Host other &&                ((this.ExposeProc == null && other.ExposeProc == null) || (this.ExposeProc?.Equals(other.ExposeProc) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExposeProc = {(this.ExposeProc == null ? "null" : this.ExposeProc.ToString())}");
        }
    }
}