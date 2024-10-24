// <copyright file="Type8Enum.cs" company="APIMatic">
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
    /// Type8Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type8Enum
    {
        /// <summary>
        /// Stackbuild.
        /// </summary>
        [EnumMember(Value = "stack-build")]
        Stackbuild
    }
}