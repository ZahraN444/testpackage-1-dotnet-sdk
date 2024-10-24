// <copyright file="Command1.cs" company="APIMatic">
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
    /// Command1.
    /// </summary>
    public class Command1
    {
        private string path;
        private string args;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "path", false },
            { "args", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Command1"/> class.
        /// </summary>
        public Command1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Command1"/> class.
        /// </summary>
        /// <param name="path">path.</param>
        /// <param name="args">args.</param>
        public Command1(
            string path = null,
            string args = null)
        {
            if (path != null)
            {
                this.Path = path;
            }

            if (args != null)
            {
                this.Args = args;
            }

        }

        /// <summary>
        /// System path for the command.
        /// </summary>
        [JsonProperty("path")]
        public string Path
        {
            get
            {
                return this.path;
            }

            set
            {
                this.shouldSerialize["path"] = true;
                this.path = value;
            }
        }

        /// <summary>
        /// Arguments to pass to the command.
        /// </summary>
        [JsonProperty("args")]
        public string Args
        {
            get
            {
                return this.args;
            }

            set
            {
                this.shouldSerialize["args"] = true;
                this.args = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Command1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPath()
        {
            this.shouldSerialize["path"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArgs()
        {
            this.shouldSerialize["args"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePath()
        {
            return this.shouldSerialize["path"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArgs()
        {
            return this.shouldSerialize["args"];
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
            return obj is Command1 other &&                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true)) &&
                ((this.Args == null && other.Args == null) || (this.Args?.Equals(other.Args) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
            toStringOutput.Add($"this.Args = {(this.Args == null ? "null" : this.Args)}");
        }
    }
}