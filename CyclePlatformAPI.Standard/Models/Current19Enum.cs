// <copyright file="Current19Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Current19Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current19Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Uploading.
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Downloading.
        /// </summary>
        [EnumMember(Value = "downloading")]
        Downloading,

        /// <summary>
        /// Building.
        /// </summary>
        [EnumMember(Value = "building")]
        Building,

        /// <summary>
        /// Verifying.
        /// </summary>
        [EnumMember(Value = "verifying")]
        Verifying,

        /// <summary>
        /// Saving.
        /// </summary>
        [EnumMember(Value = "saving")]
        Saving,

        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Deleting.
        /// </summary>
        [EnumMember(Value = "deleting")]
        Deleting,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
}