// <copyright file="MethodEnum.cs" company="APIMatic">
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
    /// MethodEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodEnum
    {
        /// <summary>
        /// Fifo.
        /// </summary>
        [EnumMember(Value = "fifo")]
        Fifo,

        /// <summary>
        /// Lifo.
        /// </summary>
        [EnumMember(Value = "lifo")]
        Lifo
    }
}