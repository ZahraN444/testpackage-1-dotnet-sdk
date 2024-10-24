// <copyright file="PublicEnum.cs" company="APIMatic">
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
    /// PublicEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublicEnum
    {
        /// <summary>
        /// Enable.
        /// </summary>
        [EnumMember(Value = "enable")]
        Enable,

        /// <summary>
        /// Disable.
        /// </summary>
        [EnumMember(Value = "disable")]
        Disable,

        /// <summary>
        /// Egressonly.
        /// </summary>
        [EnumMember(Value = "egress-only")]
        Egressonly
    }
}