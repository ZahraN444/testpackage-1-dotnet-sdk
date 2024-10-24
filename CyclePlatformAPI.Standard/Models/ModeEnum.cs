// <copyright file="ModeEnum.cs" company="APIMatic">
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
    /// ModeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModeEnum
    {
        /// <summary>
        /// Tcp.
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp,

        /// <summary>
        /// Http.
        /// </summary>
        [EnumMember(Value = "http")]
        Http
    }
}