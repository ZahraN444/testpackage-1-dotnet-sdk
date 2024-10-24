// <copyright file="Mode2Enum.cs" company="APIMatic">
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
    /// Mode2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Mode2Enum
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