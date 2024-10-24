// <copyright file="ClientAuthEnum.cs" company="APIMatic">
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
    /// ClientAuthEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientAuthEnum
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Request.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,

        /// <summary>
        /// Require.
        /// </summary>
        [EnumMember(Value = "require")]
        Require,

        /// <summary>
        /// Requireverify.
        /// </summary>
        [EnumMember(Value = "require-verify")]
        Requireverify
    }
}