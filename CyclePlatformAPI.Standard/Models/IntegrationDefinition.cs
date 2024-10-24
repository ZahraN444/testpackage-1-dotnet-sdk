// <copyright file="IntegrationDefinition.cs" company="APIMatic">
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
    /// IntegrationDefinition.
    /// </summary>
    public class IntegrationDefinition
    {
        private List<string> features;
        private List<string> extends;
        private Models.ExtendedConfiguration extendedConfiguration;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "features", false },
            { "extends", false },
            { "extended_configuration", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDefinition"/> class.
        /// </summary>
        public IntegrationDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDefinition"/> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="name">name.</param>
        /// <param name="supportsVerification">supports_verification.</param>
        /// <param name="supportsMultiple">supports_multiple.</param>
        /// <param name="url">url.</param>
        /// <param name="mPublic">public.</param>
        /// <param name="usable">usable.</param>
        /// <param name="editable">editable.</param>
        /// <param name="features">features.</param>
        /// <param name="extends">extends.</param>
        /// <param name="extendedConfiguration">extended_configuration.</param>
        /// <param name="fields">fields.</param>
        public IntegrationDefinition(
            string vendor,
            string name,
            bool supportsVerification,
            bool supportsMultiple,
            string url,
            bool mPublic,
            bool usable,
            bool editable,
            List<string> features = null,
            List<string> extends = null,
            Models.ExtendedConfiguration extendedConfiguration = null,
            Models.Fields fields = null)
        {
            this.Vendor = vendor;
            this.Name = name;
            this.SupportsVerification = supportsVerification;
            this.SupportsMultiple = supportsMultiple;
            if (features != null)
            {
                this.Features = features;
            }

            if (extends != null)
            {
                this.Extends = extends;
            }

            if (extendedConfiguration != null)
            {
                this.ExtendedConfiguration = extendedConfiguration;
            }

            this.Fields = fields;
            this.Url = url;
            this.MPublic = mPublic;
            this.Usable = usable;
            this.Editable = editable;
        }

        /// <summary>
        /// Gets or sets Vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets SupportsVerification.
        /// </summary>
        [JsonProperty("supports_verification")]
        public bool SupportsVerification { get; set; }

        /// <summary>
        /// Gets or sets SupportsMultiple.
        /// </summary>
        [JsonProperty("supports_multiple")]
        public bool SupportsMultiple { get; set; }

        /// <summary>
        /// A list of additional features supported by this Integration.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features
        {
            get
            {
                return this.features;
            }

            set
            {
                this.shouldSerialize["features"] = true;
                this.features = value;
            }
        }

        /// <summary>
        /// A list of functionality that this integration extends. i.e. ["backups"]
        /// </summary>
        [JsonProperty("extends")]
        public List<string> Extends
        {
            get
            {
                return this.extends;
            }

            set
            {
                this.shouldSerialize["extends"] = true;
                this.extends = value;
            }
        }

        /// <summary>
        /// Additional configuration options that are available when using this Integration. These describe additional functionality that Cycle may utilize.
        /// </summary>
        [JsonProperty("extended_configuration")]
        public Models.ExtendedConfiguration ExtendedConfiguration
        {
            get
            {
                return this.extendedConfiguration;
            }

            set
            {
                this.shouldSerialize["extended_configuration"] = true;
                this.extendedConfiguration = value;
            }
        }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fields Fields { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets MPublic.
        /// </summary>
        [JsonProperty("public")]
        public bool MPublic { get; set; }

        /// <summary>
        /// Gets or sets Usable.
        /// </summary>
        [JsonProperty("usable")]
        public bool Usable { get; set; }

        /// <summary>
        /// If true, the Integration can be edited. Otherwise, to make a change it will need to be deleted and recreated.
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntegrationDefinition : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeatures()
        {
            this.shouldSerialize["features"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExtends()
        {
            this.shouldSerialize["extends"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExtendedConfiguration()
        {
            this.shouldSerialize["extended_configuration"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeatures()
        {
            return this.shouldSerialize["features"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExtends()
        {
            return this.shouldSerialize["extends"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExtendedConfiguration()
        {
            return this.shouldSerialize["extended_configuration"];
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
            return obj is IntegrationDefinition other &&                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.SupportsVerification.Equals(other.SupportsVerification) &&
                this.SupportsMultiple.Equals(other.SupportsMultiple) &&
                ((this.Features == null && other.Features == null) || (this.Features?.Equals(other.Features) == true)) &&
                ((this.Extends == null && other.Extends == null) || (this.Extends?.Equals(other.Extends) == true)) &&
                ((this.ExtendedConfiguration == null && other.ExtendedConfiguration == null) || (this.ExtendedConfiguration?.Equals(other.ExtendedConfiguration) == true)) &&
                ((this.Fields == null && other.Fields == null) || (this.Fields?.Equals(other.Fields) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.MPublic.Equals(other.MPublic) &&
                this.Usable.Equals(other.Usable) &&
                this.Editable.Equals(other.Editable);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : this.Vendor)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.SupportsVerification = {this.SupportsVerification}");
            toStringOutput.Add($"this.SupportsMultiple = {this.SupportsMultiple}");
            toStringOutput.Add($"this.Features = {(this.Features == null ? "null" : $"[{string.Join(", ", this.Features)} ]")}");
            toStringOutput.Add($"this.Extends = {(this.Extends == null ? "null" : $"[{string.Join(", ", this.Extends)} ]")}");
            toStringOutput.Add($"this.ExtendedConfiguration = {(this.ExtendedConfiguration == null ? "null" : this.ExtendedConfiguration.ToString())}");
            toStringOutput.Add($"this.Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.MPublic = {this.MPublic}");
            toStringOutput.Add($"this.Usable = {this.Usable}");
            toStringOutput.Add($"this.Editable = {this.Editable}");
        }
    }
}