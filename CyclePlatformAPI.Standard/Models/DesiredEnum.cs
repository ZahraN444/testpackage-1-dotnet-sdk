// <copyright file="DesiredEnum.cs" company="APIMatic">
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
    /// DesiredEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DesiredEnum
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
        /// Running.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,

        /// <summary>
        /// Function.
        /// </summary>
        [EnumMember(Value = "function")]
        Function,

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