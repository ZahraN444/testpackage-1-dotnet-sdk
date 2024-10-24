// <copyright file="Meta8Enum.cs" company="APIMatic">
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
    /// Meta8Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Meta8Enum
    {
        /// <summary>
        /// Containers.
        /// </summary>
        [EnumMember(Value = "containers")]
        Containers,

        /// <summary>
        /// ContainersCount.
        /// </summary>
        [EnumMember(Value = "containers_count")]
        ContainersCount,

        /// <summary>
        /// InstancesCount.
        /// </summary>
        [EnumMember(Value = "instances_count")]
        InstancesCount
    }
}