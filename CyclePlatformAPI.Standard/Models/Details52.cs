// <copyright file="Details52.cs" company="APIMatic">
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
    /// Details52.
    /// </summary>
    public class Details52
    {
        private Models.StackBuildInstructions instructions;
        private Models.About4 about;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "instructions", false },
            { "about", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details52"/> class.
        /// </summary>
        public Details52()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details52"/> class.
        /// </summary>
        /// <param name="stack">stack.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="about">about.</param>
        public Details52(
            string stack,
            Models.StackBuildInstructions instructions = null,
            Models.About4 about = null)
        {
            this.Stack = stack;
            if (instructions != null)
            {
                this.Instructions = instructions;
            }

            if (about != null)
            {
                this.About = about;
            }

        }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("stack")]
        public string Stack { get; set; }

        /// <summary>
        /// Additional instructions used when generating this stack build.
        /// </summary>
        [JsonProperty("instructions")]
        public Models.StackBuildInstructions Instructions
        {
            get
            {
                return this.instructions;
            }

            set
            {
                this.shouldSerialize["instructions"] = true;
                this.instructions = value;
            }
        }

        /// <summary>
        /// Information about the stack build.
        /// </summary>
        [JsonProperty("about")]
        public Models.About4 About
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details52 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInstructions()
        {
            this.shouldSerialize["instructions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAbout()
        {
            this.shouldSerialize["about"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstructions()
        {
            return this.shouldSerialize["instructions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAbout()
        {
            return this.shouldSerialize["about"];
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
            return obj is Details52 other &&                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true)) &&
                ((this.Instructions == null && other.Instructions == null) || (this.Instructions?.Equals(other.Instructions) == true)) &&
                ((this.About == null && other.About == null) || (this.About?.Equals(other.About) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Stack = {(this.Stack == null ? "null" : this.Stack)}");
            toStringOutput.Add($"this.Instructions = {(this.Instructions == null ? "null" : this.Instructions.ToString())}");
            toStringOutput.Add($"this.About = {(this.About == null ? "null" : this.About.ToString())}");
        }
    }
}