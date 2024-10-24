// <copyright file="ImageSource.cs" company="APIMatic">
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
    /// ImageSource.
    /// </summary>
    public class ImageSource
    {
        private Models.Builder1 builder;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "builder", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSource"/> class.
        /// </summary>
        public ImageSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSource"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="type">type.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="name">name.</param>
        /// <param name="origin">origin.</param>
        /// <param name="creator">creator.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="about">about.</param>
        /// <param name="builder">builder.</param>
        /// <param name="meta">meta.</param>
        public ImageSource(
            string id,
            string identifier,
            Models.ImageSourceTypeEnum type,
            string hubId,
            string name,
            ImageOrigin origin,
            Models.CreatorScope creator,
            Models.ImageSourceState state,
            Models.ImageSourceEvents events,
            Models.ImageSourceAbout about = null,
            Models.Builder1 builder = null,
            Models.ImageSourceMeta meta = null)
        {
            this.Id = id;
            this.Identifier = identifier;
            this.Type = type;
            this.HubId = hubId;
            this.Name = name;
            this.About = about;
            this.Origin = origin;
            if (builder != null)
            {
                this.Builder = builder;
            }

            this.Creator = creator;
            this.State = state;
            this.Events = events;
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
        /// A human readable slugged identifier for this image source.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("identifier")]
        [JsonRequired]
        public string Identifier { get; set; }

        /// <summary>
        /// The type of images in this source.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.ImageSourceTypeEnum Type { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A name for the image source resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// Information about the image source resource.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImageSourceAbout About { get; set; }

        /// <summary>
        /// The origin of the given image source.
        /// </summary>
        [JsonProperty("origin")]
        [JsonRequired]
        public ImageOrigin Origin { get; set; }

        /// <summary>
        /// Configuration options regarding the builder used to create/import Images using this Image Source.
        /// </summary>
        [JsonProperty("builder")]
        public Models.Builder1 Builder
        {
            get
            {
                return this.builder;
            }

            set
            {
                this.shouldSerialize["builder"] = true;
                this.builder = value;
            }
        }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        [JsonRequired]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ImageSourceState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the image source's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ImageSourceEvents Events { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to this environment.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImageSourceMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ImageSource : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuilder()
        {
            this.shouldSerialize["builder"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuilder()
        {
            return this.shouldSerialize["builder"];
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
            return obj is ImageSource other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                this.Type.Equals(other.Type) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true)) &&
                ((this.Builder == null && other.Builder == null) || (this.Builder?.Equals(other.Builder) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
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
            toStringOutput.Add($"this.Type = {this.Type}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"this.Builder = {(this.Builder == null ? "null" : this.Builder.ToString())}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}