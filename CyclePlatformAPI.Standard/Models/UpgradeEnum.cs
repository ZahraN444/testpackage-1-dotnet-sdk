// <copyright file="UpgradeEnum.cs" company="APIMatic">
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
    /// UpgradeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpgradeEnum
    {
        /// <summary>
        /// Websocket.
        /// </summary>
        [EnumMember(Value = "websocket")]
        Websocket
    }
}