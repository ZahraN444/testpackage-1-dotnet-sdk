// <copyright file="Hub.cs" company="APIMatic">
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
    /// Hub.
    /// </summary>
    public class Hub
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hub"/> class.
        /// </summary>
        public Hub()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hub"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="name">name.</param>
        /// <param name="creator">creator.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="webhooks">webhooks.</param>
        /// <param name="billing">billing.</param>
        /// <param name="meta">meta.</param>
        public Hub(
            string id,
            string identifier,
            string name,
            Models.CreatorScope creator,
            Models.HubEvents events,
            Models.HubState state,
            Models.HubWebhooks webhooks,
            HubBilling billing,
            Models.HubsMeta meta = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Name = name;
            this.Creator = creator;
            this.Events = events;
            this.State = state;
            this.Webhooks = webhooks;
            this.Billing = billing;
            this.Meta = meta;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// A human readable slugged identifier for this hub.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// A name for the hub.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the hub's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.HubEvents Events { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.HubState State { get; set; }

        /// <summary>
        /// Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs.
        /// </summary>
        [JsonProperty("webhooks")]
        [JsonRequired]
        public Models.HubWebhooks Webhooks { get; set; }

        /// <summary>
        /// Gets or sets Billing.
        /// </summary>
        [JsonProperty("billing")]
        [JsonRequired]
        public HubBilling Billing { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a hub.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HubsMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Hub : ({string.Join(", ", toStringOutput)})";
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
            return obj is Hub other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Webhooks == null && other.Webhooks == null) || (this.Webhooks?.Equals(other.Webhooks) == true)) &&
                ((this.Billing == null && other.Billing == null) || (this.Billing?.Equals(other.Billing) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Webhooks = {(this.Webhooks == null ? "null" : this.Webhooks.ToString())}");
            toStringOutput.Add($"Billing = {(this.Billing == null ? "null" : this.Billing.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}