// <copyright file="NamespaceEnum.cs" company="APIMatic">
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
    /// NamespaceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NamespaceEnum
    {
        /// <summary>
        /// Ipc.
        /// </summary>
        [EnumMember(Value = "ipc")]
        Ipc,

        /// <summary>
        /// Pid.
        /// </summary>
        [EnumMember(Value = "pid")]
        Pid,

        /// <summary>
        /// Uts.
        /// </summary>
        [EnumMember(Value = "uts")]
        Uts,

        /// <summary>
        /// Network.
        /// </summary>
        [EnumMember(Value = "network")]
        Network,

        /// <summary>
        /// Mount.
        /// </summary>
        [EnumMember(Value = "mount")]
        Mount,

        /// <summary>
        /// User.
        /// </summary>
        [EnumMember(Value = "user")]
        User,

        /// <summary>
        /// Cgroup.
        /// </summary>
        [EnumMember(Value = "cgroup")]
        Cgroup
    }
}