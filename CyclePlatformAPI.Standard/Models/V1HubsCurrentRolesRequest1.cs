// <copyright file="V1HubsCurrentRolesRequest1.cs" company="APIMatic">
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
    /// V1HubsCurrentRolesRequest1.
    /// </summary>
    public class V1HubsCurrentRolesRequest1
    {
        private string name;
        private Models.Capabilities1 capabilities;
        private Dictionary<string, string> extra;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "capabilities", false },
            { "extra", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRolesRequest1"/> class.
        /// </summary>
        public V1HubsCurrentRolesRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRolesRequest1"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="rank">rank.</param>
        /// <param name="name">name.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="extra">extra.</param>
        public V1HubsCurrentRolesRequest1(
            string identifier,
            int rank,
            string name = null,
            Models.Capabilities1 capabilities = null,
            Dictionary<string, string> extra = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            this.Identifier = identifier;
            if (capabilities != null)
            {
                this.Capabilities = capabilities;
            }

            this.Rank = rank;
            if (extra != null)
            {
                this.Extra = extra;
            }

        }

        /// <summary>
        /// A name given to the Role.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// The list of platform level capabilities assigned to this Role.
        /// </summary>
        [JsonProperty("capabilities")]
        public Models.Capabilities1 Capabilities
        {
            get
            {
                return this.capabilities;
            }

            set
            {
                this.shouldSerialize["capabilities"] = true;
                this.capabilities = value;
            }
        }

        /// <summary>
        /// Gets or sets Rank.
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// Custom user-defined properties for storing extra information on the Role. Not utilized by Cycle.
        /// </summary>
        [JsonProperty("extra")]
        public Dictionary<string, string> Extra
        {
            get
            {
                return this.extra;
            }

            set
            {
                this.shouldSerialize["extra"] = true;
                this.extra = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentRolesRequest1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCapabilities()
        {
            this.shouldSerialize["capabilities"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExtra()
        {
            this.shouldSerialize["extra"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCapabilities()
        {
            return this.shouldSerialize["capabilities"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExtra()
        {
            return this.shouldSerialize["extra"];
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
            return obj is V1HubsCurrentRolesRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                this.Rank.Equals(other.Rank) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"this.Rank = {this.Rank}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}