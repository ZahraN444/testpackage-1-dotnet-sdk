// <copyright file="ScopedVariableAccess.cs" company="APIMatic">
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
    /// ScopedVariableAccess.
    /// </summary>
    public class ScopedVariableAccess
    {
        private Models.EnvVariable1 envVariable;
        private Models.InternalApi internalApi;
        private Models.File1 file;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "env_variable", false },
            { "internal_api", false },
            { "file", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariableAccess"/> class.
        /// </summary>
        public ScopedVariableAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedVariableAccess"/> class.
        /// </summary>
        /// <param name="envVariable">env_variable.</param>
        /// <param name="internalApi">internal_api.</param>
        /// <param name="file">file.</param>
        public ScopedVariableAccess(
            Models.EnvVariable1 envVariable = null,
            Models.InternalApi internalApi = null,
            Models.File1 file = null)
        {
            if (envVariable != null)
            {
                this.EnvVariable = envVariable;
            }

            if (internalApi != null)
            {
                this.InternalApi = internalApi;
            }

            if (file != null)
            {
                this.File = file;
            }

        }

        /// <summary>
        /// When set to true, this scoped variable is set as an environment variable inside the container.
        /// </summary>
        [JsonProperty("env_variable")]
        public Models.EnvVariable1 EnvVariable
        {
            get
            {
                return this.envVariable;
            }

            set
            {
                this.shouldSerialize["env_variable"] = true;
                this.envVariable = value;
            }
        }

        /// <summary>
        /// If set, this scoped variable will be available over the internal API. Contains settings for accessing this variable over the internal API.
        /// </summary>
        [JsonProperty("internal_api")]
        public Models.InternalApi InternalApi
        {
            get
            {
                return this.internalApi;
            }

            set
            {
                this.shouldSerialize["internal_api"] = true;
                this.internalApi = value;
            }
        }

        /// <summary>
        /// File is an object that describes a path to mount the file to inside the container.
        /// </summary>
        [JsonProperty("file")]
        public Models.File1 File
        {
            get
            {
                return this.file;
            }

            set
            {
                this.shouldSerialize["file"] = true;
                this.file = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScopedVariableAccess : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEnvVariable()
        {
            this.shouldSerialize["env_variable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInternalApi()
        {
            this.shouldSerialize["internal_api"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFile()
        {
            this.shouldSerialize["file"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEnvVariable()
        {
            return this.shouldSerialize["env_variable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInternalApi()
        {
            return this.shouldSerialize["internal_api"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFile()
        {
            return this.shouldSerialize["file"];
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
            return obj is ScopedVariableAccess other &&                ((this.EnvVariable == null && other.EnvVariable == null) || (this.EnvVariable?.Equals(other.EnvVariable) == true)) &&
                ((this.InternalApi == null && other.InternalApi == null) || (this.InternalApi?.Equals(other.InternalApi) == true)) &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnvVariable = {(this.EnvVariable == null ? "null" : this.EnvVariable.ToString())}");
            toStringOutput.Add($"this.InternalApi = {(this.InternalApi == null ? "null" : this.InternalApi.ToString())}");
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File.ToString())}");
        }
    }
}