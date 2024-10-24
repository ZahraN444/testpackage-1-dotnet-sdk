// <copyright file="ImageSourceTypeEnum.cs" company="APIMatic">
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
    /// ImageSourceTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ImageSourceTypeEnum
    {
        /// <summary>
        /// Stackbuild.
        /// </summary>
        [EnumMember(Value = "stack-build")]
        Stackbuild,

        /// <summary>
        /// Direct.
        /// </summary>
        [EnumMember(Value = "direct")]
        Direct,

        /// <summary>
        /// Bucket.
        /// </summary>
        [EnumMember(Value = "bucket")]
        Bucket
    }
}