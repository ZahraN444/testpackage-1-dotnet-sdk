// <copyright file="Constraints.cs" company="APIMatic">
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
    /// Constraints.
    /// </summary>
    public class Constraints
    {
        private Models.Node node;
        private List<string> secrets;
        private List<string> containers;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "node", false },
            { "secrets", false },
            { "containers", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints"/> class.
        /// </summary>
        public Constraints()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints"/> class.
        /// </summary>
        /// <param name="node">node.</param>
        /// <param name="secrets">secrets.</param>
        /// <param name="containers">containers.</param>
        public Constraints(
            Models.Node node = null,
            List<string> secrets = null,
            List<string> containers = null)
        {
            if (node != null)
            {
                this.Node = node;
            }

            if (secrets != null)
            {
                this.Secrets = secrets;
            }

            if (containers != null)
            {
                this.Containers = containers;
            }

        }

        /// <summary>
        /// Gets or sets Node.
        /// </summary>
        [JsonProperty("node")]
        public Models.Node Node
        {
            get
            {
                return this.node;
            }

            set
            {
                this.shouldSerialize["node"] = true;
                this.node = value;
            }
        }

        /// <summary>
        /// Gets or sets Secrets.
        /// </summary>
        [JsonProperty("secrets")]
        public List<string> Secrets
        {
            get
            {
                return this.secrets;
            }

            set
            {
                this.shouldSerialize["secrets"] = true;
                this.secrets = value;
            }
        }

        /// <summary>
        /// Gets or sets Containers.
        /// </summary>
        [JsonProperty("containers")]
        public List<string> Containers
        {
            get
            {
                return this.containers;
            }

            set
            {
                this.shouldSerialize["containers"] = true;
                this.containers = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Constraints : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNode()
        {
            this.shouldSerialize["node"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSecrets()
        {
            this.shouldSerialize["secrets"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContainers()
        {
            this.shouldSerialize["containers"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNode()
        {
            return this.shouldSerialize["node"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSecrets()
        {
            return this.shouldSerialize["secrets"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContainers()
        {
            return this.shouldSerialize["containers"];
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
            return obj is Constraints other &&                ((this.Node == null && other.Node == null) || (this.Node?.Equals(other.Node) == true)) &&
                ((this.Secrets == null && other.Secrets == null) || (this.Secrets?.Equals(other.Secrets) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Node = {(this.Node == null ? "null" : this.Node.ToString())}");
            toStringOutput.Add($"this.Secrets = {(this.Secrets == null ? "null" : $"[{string.Join(", ", this.Secrets)} ]")}");
            toStringOutput.Add($"this.Containers = {(this.Containers == null ? "null" : $"[{string.Join(", ", this.Containers)} ]")}");
        }
    }
}