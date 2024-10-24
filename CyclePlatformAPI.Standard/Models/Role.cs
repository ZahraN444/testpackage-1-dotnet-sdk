// <copyright file="Role.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Role.
    /// </summary>
    public class Role
    {
        private string name;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="root">root.</param>
        /// <param name="rank">rank.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="creator">creator.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="name">name.</param>
        /// <param name="mDefault">default.</param>
        /// <param name="extra">extra.</param>
        public Role(
            string id,
            bool root,
            int rank,
            string identifier,
            Models.CreatorScope creator,
            Models.Capabilities1 capabilities,
            string hubId,
            Models.State1 state,
            Models.RoleEvents events,
            string name = null,
            RoleDefault mDefault = null,
            Dictionary<string, string> extra = null)
        {
            this.Id = id;
            if (name != null)
            {
                this.Name = name;
            }

            this.Root = root;
            this.MDefault = mDefault;
            this.Rank = rank;
            this.Identifier = identifier;
            this.Creator = creator;
            this.Capabilities = capabilities;
            this.Extra = extra;
            this.HubId = hubId;
            this.State = state;
            this.Events = events;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        /// The Role marked as root has full moderation control over all Roles.
        /// </summary>
        [JsonProperty("root")]
        [JsonRequired]
        public bool Root { get; set; }

        /// <summary>
        /// A reference to the original identifier of the default Role this Role was built from.  A value of null means it is a fully custom Role.
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public RoleDefault MDefault { get; set; }

        /// <summary>
        /// An integer between 0 and 10 that indicates the Role hierarchy. An account can only edit a Role that is less than their rank. The 'owner' Role is rank 10.
        /// </summary>
        [JsonProperty("rank")]
        [JsonRequired]
        public int Rank { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// The list of platform level capabilities assigned to this Role.
        /// </summary>
        [JsonProperty("capabilities")]
        [JsonRequired]
        public Models.Capabilities1 Capabilities { get; set; }

        /// <summary>
        /// Custom user-defined properties for storing extra information on the Role. Not utilized by Cycle.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.State1 State { get; set; }

        /// <summary>
        /// Timestamps for each event in the Role's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.RoleEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Role : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
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
            return obj is Role other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Root.Equals(other.Root) &&
                ((this.MDefault == null && other.MDefault == null) || (this.MDefault?.Equals(other.MDefault) == true)) &&
                this.Rank.Equals(other.Rank) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Root = {this.Root}");
            toStringOutput.Add($"MDefault = {(this.MDefault == null ? "null" : this.MDefault.ToString())}");
            toStringOutput.Add($"this.Rank = {this.Rank}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}