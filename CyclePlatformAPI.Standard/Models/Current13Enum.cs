// <copyright file="Current13Enum.cs" company="APIMatic">
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
    /// Current13Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current13Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Importing.
        /// </summary>
        [EnumMember(Value = "importing")]
        Importing,

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
        /// Deploying.
        /// </summary>
        [EnumMember(Value = "deploying")]
        Deploying,

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