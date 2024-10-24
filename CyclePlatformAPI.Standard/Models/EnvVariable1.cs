// <copyright file="EnvVariable1.cs" company="APIMatic">
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
    /// EnvVariable1.
    /// </summary>
    public class EnvVariable1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVariable1"/> class.
        /// </summary>
        public EnvVariable1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvVariable1"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public EnvVariable1(
            string key)
        {
            this.Key = key;
        }

        /// <summary>
        /// The name of the environment variable set on the target container.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvVariable1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvVariable1 other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
        }
    }
}