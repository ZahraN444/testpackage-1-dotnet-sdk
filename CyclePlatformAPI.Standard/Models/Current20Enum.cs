// <copyright file="Current20Enum.cs" company="APIMatic">
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
    /// Current20Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current20Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Starting.
        /// </summary>
        [EnumMember(Value = "starting")]
        Starting,

        /// <summary>
        /// Reimaging.
        /// </summary>
        [EnumMember(Value = "reimaging")]
        Reimaging,

        /// <summary>
        /// Migrating.
        /// </summary>
        [EnumMember(Value = "migrating")]
        Migrating,

        /// <summary>
        /// Running.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,

        /// <summary>
        /// Stopping.
        /// </summary>
        [EnumMember(Value = "stopping")]
        Stopping,

        /// <summary>
        /// Stopped.
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

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