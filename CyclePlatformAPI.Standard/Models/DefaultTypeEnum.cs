// <copyright file="DefaultTypeEnum.cs" company="APIMatic">
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
    /// DefaultTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultTypeEnum
    {
        /// <summary>
        /// Haproxy.
        /// </summary>
        [EnumMember(Value = "haproxy")]
        Haproxy,

        /// <summary>
        /// V1.
        /// </summary>
        [EnumMember(Value = "v1")]
        V1
    }
}