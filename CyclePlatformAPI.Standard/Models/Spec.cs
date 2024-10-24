// <copyright file="Spec.cs" company="APIMatic">
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
    /// Spec.
    /// </summary>
    public class Spec
    {
        private Models.About about;
        private List<Models.StackSpecTestContainer> tests;
        private List<Models.StackSpecScopedVariable> scopedVariables;
        private Models.StackSpecServices services;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "about", false },
            { "tests", false },
            { "scoped_variables", false },
            { "services", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec"/> class.
        /// </summary>
        public Spec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec"/> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="about">about.</param>
        /// <param name="tests">tests.</param>
        /// <param name="scopedVariables">scoped_variables.</param>
        /// <param name="containers">containers.</param>
        /// <param name="services">services.</param>
        /// <param name="annotations">annotations.</param>
        public Spec(
            string version = null,
            Models.About about = null,
            List<Models.StackSpecTestContainer> tests = null,
            List<Models.StackSpecScopedVariable> scopedVariables = null,
            Dictionary<string, Models.StackContainer> containers = null,
            Models.StackSpecServices services = null,
            object annotations = null)
        {
            this.Version = version;
            if (about != null)
            {
                this.About = about;
            }

            if (tests != null)
            {
                this.Tests = tests;
            }

            if (scopedVariables != null)
            {
                this.ScopedVariables = scopedVariables;
            }

            this.Containers = containers;
            if (services != null)
            {
                this.Services = services;
            }

            this.Annotations = annotations;
        }

        /// <summary>
        /// A string defining the version of the stack spec.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Information about the stack.
        /// </summary>
        [JsonProperty("about")]
        public Models.About About
        {
            get
            {
                return this.about;
            }

            set
            {
                this.shouldSerialize["about"] = true;
                this.about = value;
            }
        }

        /// <summary>
        /// Gets or sets Tests.
        /// </summary>
        [JsonProperty("tests")]
        public List<Models.StackSpecTestContainer> Tests
        {
            get
            {
                return this.tests;
            }

            set
            {
                this.shouldSerialize["tests"] = true;
                this.tests = value;
            }
        }

        /// <summary>
        /// Gets or sets ScopedVariables.
        /// </summary>
        [JsonProperty("scoped_variables")]
        public List<Models.StackSpecScopedVariable> ScopedVariables
        {
            get
            {
                return this.scopedVariables;
            }

            set
            {
                this.shouldSerialize["scoped_variables"] = true;
                this.scopedVariables = value;
            }
        }

        /// <summary>
        /// Records defining the containers within the stack.
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.StackContainer> Containers { get; set; }

        /// <summary>
        /// Gets or sets Services.
        /// </summary>
        [JsonProperty("services")]
        public Models.StackSpecServices Services
        {
            get
            {
                return this.services;
            }

            set
            {
                this.shouldSerialize["services"] = true;
                this.services = value;
            }
        }

        /// <summary>
        /// Additional meta info about the stack.
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public object Annotations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Spec : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAbout()
        {
            this.shouldSerialize["about"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTests()
        {
            this.shouldSerialize["tests"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetScopedVariables()
        {
            this.shouldSerialize["scoped_variables"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetServices()
        {
            this.shouldSerialize["services"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAbout()
        {
            return this.shouldSerialize["about"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTests()
        {
            return this.shouldSerialize["tests"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScopedVariables()
        {
            return this.shouldSerialize["scoped_variables"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeServices()
        {
            return this.shouldSerialize["services"];
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
            return obj is Spec other &&                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true)) &&
                ((this.Tests == null && other.Tests == null) || (this.Tests?.Equals(other.Tests) == true)) &&
                ((this.ScopedVariables == null && other.ScopedVariables == null) || (this.ScopedVariables?.Equals(other.ScopedVariables) == true)) &&
                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
            toStringOutput.Add($"this.Tests = {(this.Tests == null ? "null" : $"[{string.Join(", ", this.Tests)} ]")}");
            toStringOutput.Add($"this.ScopedVariables = {(this.ScopedVariables == null ? "null" : $"[{string.Join(", ", this.ScopedVariables)} ]")}");
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"this.Services = {(this.Services == null ? "null" : this.Services.ToString())}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
        }
    }
}