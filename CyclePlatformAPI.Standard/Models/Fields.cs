// <copyright file="Fields.cs" company="APIMatic">
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
    /// Fields.
    /// </summary>
    public class Fields
    {
        private Dictionary<string, Models.Extra1> extra;
        private Dictionary<string, Models.Auth3> auth;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "extra", false },
            { "auth", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Fields"/> class.
        /// </summary>
        public Fields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fields"/> class.
        /// </summary>
        /// <param name="extra">extra.</param>
        /// <param name="auth">auth.</param>
        public Fields(
            Dictionary<string, Models.Extra1> extra = null,
            Dictionary<string, Models.Auth3> auth = null)
        {
            if (extra != null)
            {
                this.Extra = extra;
            }

            if (auth != null)
            {
                this.Auth = auth;
            }

        }

        /// <summary>
        /// Gets or sets Extra.
        /// </summary>
        [JsonProperty("extra")]
        public Dictionary<string, Models.Extra1> Extra
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

        /// <summary>
        /// Gets or sets Auth.
        /// </summary>
        [JsonProperty("auth")]
        public Dictionary<string, Models.Auth3> Auth
        {
            get
            {
                return this.auth;
            }

            set
            {
                this.shouldSerialize["auth"] = true;
                this.auth = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Fields : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExtra()
        {
            this.shouldSerialize["extra"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAuth()
        {
            this.shouldSerialize["auth"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExtra()
        {
            return this.shouldSerialize["extra"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuth()
        {
            return this.shouldSerialize["auth"];
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
            return obj is Fields other &&                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true)) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
            toStringOutput.Add($"Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
        }
    }
}