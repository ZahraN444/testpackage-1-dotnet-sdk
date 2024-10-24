// <copyright file="V1EnvironmentsRequest1.cs" company="APIMatic">
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
    /// V1EnvironmentsRequest1.
    /// </summary>
    public class V1EnvironmentsRequest1
    {
        private string name;
        private string identifier;
        private string version;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "identifier", false },
            { "version", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsRequest1"/> class.
        /// </summary>
        public V1EnvironmentsRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="version">version.</param>
        /// <param name="about">about.</param>
        public V1EnvironmentsRequest1(
            string name = null,
            string identifier = null,
            string version = null,
            Models.EnvironmentAbout about = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            if (identifier != null)
            {
                this.Identifier = identifier;
            }

            if (version != null)
            {
                this.Version = version;
            }

            this.About = about;
        }

        /// <summary>
        /// Gets or sets Name.
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
        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                this.shouldSerialize["identifier"] = true;
                this.identifier = value;
            }
        }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get
            {
                return this.version;
            }

            set
            {
                this.shouldSerialize["version"] = true;
                this.version = value;
            }
        }

        /// <summary>
        /// Contains details regarding the environment.
        /// </summary>
        [JsonProperty("about", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnvironmentAbout About { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsRequest1 : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetIdentifier()
        {
            this.shouldSerialize["identifier"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVersion()
        {
            this.shouldSerialize["version"] = false;
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
        public bool ShouldSerializeIdentifier()
        {
            return this.shouldSerialize["identifier"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVersion()
        {
            return this.shouldSerialize["version"];
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
            return obj is V1EnvironmentsRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
        }
    }
}