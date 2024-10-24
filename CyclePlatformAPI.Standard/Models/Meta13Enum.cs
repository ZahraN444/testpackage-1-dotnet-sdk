// <copyright file="Meta13Enum.cs" company="APIMatic">
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
    /// Meta13Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Meta13Enum
    {
        /// <summary>
        /// Node.
        /// </summary>
        [EnumMember(Value = "node")]
        Node,

        /// <summary>
        /// InstancesCount.
        /// </summary>
        [EnumMember(Value = "instances_count")]
        InstancesCount
    }
}