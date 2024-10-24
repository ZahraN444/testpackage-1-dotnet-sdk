// <copyright file="Events1.cs" company="APIMatic">
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
    /// Events1.
    /// </summary>
    public class Events1
    {
        private string deploy;
        private string start;
        private string stop;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "deploy", false },
            { "start", false },
            { "stop", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Events1"/> class.
        /// </summary>
        public Events1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Events1"/> class.
        /// </summary>
        /// <param name="deploy">deploy.</param>
        /// <param name="start">start.</param>
        /// <param name="stop">stop.</param>
        public Events1(
            string deploy = null,
            string start = null,
            string stop = null)
        {
            if (deploy != null)
            {
                this.Deploy = deploy;
            }

            if (start != null)
            {
                this.Start = start;
            }

            if (stop != null)
            {
                this.Stop = stop;
            }

        }

        /// <summary>
        /// Gets or sets Deploy.
        /// </summary>
        [JsonProperty("deploy")]
        public string Deploy
        {
            get
            {
                return this.deploy;
            }

            set
            {
                this.shouldSerialize["deploy"] = true;
                this.deploy = value;
            }
        }

        /// <summary>
        /// Gets or sets Start.
        /// </summary>
        [JsonProperty("start")]
        public string Start
        {
            get
            {
                return this.start;
            }

            set
            {
                this.shouldSerialize["start"] = true;
                this.start = value;
            }
        }

        /// <summary>
        /// Gets or sets Stop.
        /// </summary>
        [JsonProperty("stop")]
        public string Stop
        {
            get
            {
                return this.stop;
            }

            set
            {
                this.shouldSerialize["stop"] = true;
                this.stop = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Events1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeploy()
        {
            this.shouldSerialize["deploy"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStart()
        {
            this.shouldSerialize["start"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStop()
        {
            this.shouldSerialize["stop"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeploy()
        {
            return this.shouldSerialize["deploy"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStart()
        {
            return this.shouldSerialize["start"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStop()
        {
            return this.shouldSerialize["stop"];
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
            return obj is Events1 other &&                ((this.Deploy == null && other.Deploy == null) || (this.Deploy?.Equals(other.Deploy) == true)) &&
                ((this.Start == null && other.Start == null) || (this.Start?.Equals(other.Start) == true)) &&
                ((this.Stop == null && other.Stop == null) || (this.Stop?.Equals(other.Stop) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deploy = {(this.Deploy == null ? "null" : this.Deploy)}");
            toStringOutput.Add($"this.Start = {(this.Start == null ? "null" : this.Start)}");
            toStringOutput.Add($"this.Stop = {(this.Stop == null ? "null" : this.Stop)}");
        }
    }
}