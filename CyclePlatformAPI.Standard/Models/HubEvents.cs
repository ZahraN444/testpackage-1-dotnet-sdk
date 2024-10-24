// <copyright file="HubEvents.cs" company="APIMatic">
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
    /// HubEvents.
    /// </summary>
    public class HubEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubEvents"/> class.
        /// </summary>
        public HubEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="converted">converted.</param>
        /// <param name="firstOrder">first_order.</param>
        /// <param name="firstProvider">first_provider.</param>
        /// <param name="firstServer">first_server.</param>
        /// <param name="firstEnvironment">first_environment.</param>
        /// <param name="firstImage">first_image.</param>
        /// <param name="firstContainer">first_container.</param>
        public HubEvents(
            DateTime created,
            DateTime updated,
            DateTime deleted,
            DateTime? converted = null,
            DateTime? firstOrder = null,
            DateTime? firstProvider = null,
            DateTime? firstServer = null,
            DateTime? firstEnvironment = null,
            DateTime? firstImage = null,
            DateTime? firstContainer = null)
        {
            this.Created = created;
            this.Updated = updated;
            this.Deleted = deleted;
            this.Converted = converted;
            this.FirstOrder = firstOrder;
            this.FirstProvider = firstProvider;
            this.FirstServer = firstServer;
            this.FirstEnvironment = firstEnvironment;
            this.FirstImage = firstImage;
            this.FirstContainer = firstContainer;
        }

        /// <summary>
        /// The timestamp of when the hub was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the hub was updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The timestamp of when the hub was deleted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted")]
        public DateTime Deleted { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first converted.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("converted", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Converted { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first provider added.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_order", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstOrder { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first provider added.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_provider", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstProvider { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first_server deployed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_server", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstServer { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first environment deployed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_environment", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstEnvironment { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first image deployed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_image", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstImage { get; set; }

        /// <summary>
        /// The timestamp of when the hub had the first container deployed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("first_container", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstContainer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubEvents other &&                this.Created.Equals(other.Created) &&
                this.Updated.Equals(other.Updated) &&
                this.Deleted.Equals(other.Deleted) &&
                ((this.Converted == null && other.Converted == null) || (this.Converted?.Equals(other.Converted) == true)) &&
                ((this.FirstOrder == null && other.FirstOrder == null) || (this.FirstOrder?.Equals(other.FirstOrder) == true)) &&
                ((this.FirstProvider == null && other.FirstProvider == null) || (this.FirstProvider?.Equals(other.FirstProvider) == true)) &&
                ((this.FirstServer == null && other.FirstServer == null) || (this.FirstServer?.Equals(other.FirstServer) == true)) &&
                ((this.FirstEnvironment == null && other.FirstEnvironment == null) || (this.FirstEnvironment?.Equals(other.FirstEnvironment) == true)) &&
                ((this.FirstImage == null && other.FirstImage == null) || (this.FirstImage?.Equals(other.FirstImage) == true)) &&
                ((this.FirstContainer == null && other.FirstContainer == null) || (this.FirstContainer?.Equals(other.FirstContainer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Updated = {this.Updated}");
            toStringOutput.Add($"this.Deleted = {this.Deleted}");
            toStringOutput.Add($"this.Converted = {(this.Converted == null ? "null" : this.Converted.ToString())}");
            toStringOutput.Add($"this.FirstOrder = {(this.FirstOrder == null ? "null" : this.FirstOrder.ToString())}");
            toStringOutput.Add($"this.FirstProvider = {(this.FirstProvider == null ? "null" : this.FirstProvider.ToString())}");
            toStringOutput.Add($"this.FirstServer = {(this.FirstServer == null ? "null" : this.FirstServer.ToString())}");
            toStringOutput.Add($"this.FirstEnvironment = {(this.FirstEnvironment == null ? "null" : this.FirstEnvironment.ToString())}");
            toStringOutput.Add($"this.FirstImage = {(this.FirstImage == null ? "null" : this.FirstImage.ToString())}");
            toStringOutput.Add($"this.FirstContainer = {(this.FirstContainer == null ? "null" : this.FirstContainer.ToString())}");
        }
    }
}