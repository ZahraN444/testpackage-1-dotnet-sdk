// <copyright file="Backend1.cs" company="APIMatic">
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
    /// Backend1.
    /// </summary>
    public class Backend1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backend1"/> class.
        /// </summary>
        public Backend1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backend1"/> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="size">size.</param>
        /// <param name="fileName">file_name.</param>
        /// <param name="fileId">file_id.</param>
        public Backend1(
            string provider,
            int size,
            string fileName,
            string fileId)
        {
            this.Provider = provider;
            this.Size = size;
            this.FileName = fileName;
            this.FileId = fileId;
        }

        /// <summary>
        /// The provider where this image is hosted.
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The size of the image in bytes.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// A file name for the image, used by the platform.
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// A file id for the image, used by the platform.
        /// </summary>
        [JsonProperty("file_id")]
        public string FileId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Backend1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Backend1 other &&                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                this.Size.Equals(other.Size) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FileId == null && other.FileId == null) || (this.FileId?.Equals(other.FileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider)}");
            toStringOutput.Add($"this.Size = {this.Size}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.FileId = {(this.FileId == null ? "null" : this.FileId)}");
        }
    }
}