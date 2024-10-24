// <copyright file="Image.cs" company="APIMatic">
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
    /// Image.
    /// </summary>
    public class Image
    {
        private Models.Build1 build;
        private Models.Builder2 builder;
        private Models.Factory factory;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "build", false },
            { "builder", false },
            { "factory", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        public Image()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="backend">backend.</param>
        /// <param name="requires">requires.</param>
        /// <param name="config">config.</param>
        /// <param name="state">state.</param>
        /// <param name="events">events.</param>
        /// <param name="about">about.</param>
        /// <param name="build">build.</param>
        /// <param name="builder">builder.</param>
        /// <param name="source">source.</param>
        /// <param name="creator">creator.</param>
        /// <param name="factory">factory.</param>
        /// <param name="meta">meta.</param>
        public Image(
            string id,
            string hubId,
            string name,
            int size,
            Models.Backend1 backend,
            Models.Requires requires,
            Models.Config7 config,
            Models.ImageState state,
            Models.ImageEvents events,
            Models.About2 about = null,
            Models.Build1 build = null,
            Models.Builder2 builder = null,
            ImageSource2 source = null,
            Models.CreatorScope creator = null,
            Models.Factory factory = null,
            Models.ImageMeta meta = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Name = name;
            this.Size = size;
            this.About = about;
            this.Backend = backend;
            this.Requires = requires;
            if (build != null)
            {
                this.Build = build;
            }

            if (builder != null)
            {
                this.Builder = builder;
            }

            this.Config = config;
            this.Source = source;
            this.Creator = creator;
            if (factory != null)
            {
                this.Factory = factory;
            }

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
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A user defined name for the image.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// The image size in bytes.
        /// </summary>
        [JsonProperty("size")]
        [JsonRequired]
        public int Size { get; set; }

        /// <summary>
        /// An object that holds information about the image.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.About2 About { get; set; }

        /// <summary>
        /// Describes where the image is hosted.
        /// </summary>
        [JsonProperty("backend")]
        [JsonRequired]
        public Models.Backend1 Backend { get; set; }

        /// <summary>
        /// Any restrictions or requirements needed to run this image as a container.
        /// </summary>
        [JsonProperty("requires")]
        [JsonRequired]
        public Models.Requires Requires { get; set; }

        /// <summary>
        /// Any additional build details for this image
        /// </summary>
        [JsonProperty("build")]
        public Models.Build1 Build
        {
            get
            {
                return this.build;
            }

            set
            {
                this.shouldSerialize["build"] = true;
                this.build = value;
            }
        }

        /// <summary>
        /// Configuration options regarding the builder used to create/import this Image.
        /// </summary>
        [JsonProperty("builder")]
        public Models.Builder2 Builder
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
        /// Configuration settings for the image.
        /// </summary>
        [JsonProperty("config")]
        [JsonRequired]
        public Models.Config7 Config { get; set; }

        /// <summary>
        /// Gets or sets Source.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public ImageSource2 Source { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Information about the Factory service that built/imported the Image into Cycle.
        /// </summary>
        [JsonProperty("factory")]
        public Models.Factory Factory
        {
            get
            {
                return this.factory;
            }

            set
            {
                this.shouldSerialize["factory"] = true;
                this.factory = value;
            }
        }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.ImageState State { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the image's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.ImageEvents Events { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to the image.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImageMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Image : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuild()
        {
            this.shouldSerialize["build"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBuilder()
        {
            this.shouldSerialize["builder"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFactory()
        {
            this.shouldSerialize["factory"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuild()
        {
            return this.shouldSerialize["build"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBuilder()
        {
            return this.shouldSerialize["builder"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFactory()
        {
            return this.shouldSerialize["factory"];
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
            return obj is Image other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Size.Equals(other.Size) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Backend == null && other.Backend == null) || (this.Backend?.Equals(other.Backend) == true)) &&
                ((this.Requires == null && other.Requires == null) || (this.Requires?.Equals(other.Requires) == true)) &&
                ((this.Build == null && other.Build == null) || (this.Build?.Equals(other.Build) == true)) &&
                ((this.Builder == null && other.Builder == null) || (this.Builder?.Equals(other.Builder) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Factory == null && other.Factory == null) || (this.Factory?.Equals(other.Factory) == true)) &&
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
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Size = {this.Size}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Backend = {(this.Backend == null ? "null" : this.Backend.ToString())}");
            toStringOutput.Add($"this.Requires = {(this.Requires == null ? "null" : this.Requires.ToString())}");
            toStringOutput.Add($"this.Build = {(this.Build == null ? "null" : this.Build.ToString())}");
            toStringOutput.Add($"this.Builder = {(this.Builder == null ? "null" : this.Builder.ToString())}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.Factory = {(this.Factory == null ? "null" : this.Factory.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}