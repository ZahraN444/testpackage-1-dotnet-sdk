// <copyright file="Include21Enum.cs" company="APIMatic">
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
    /// Include21Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include21Enum
    {
        /// <summary>
        /// Creators.
        /// </summary>
        [EnumMember(Value = "creators")]
        Creators,

        /// <summary>
        /// StackBuilds.
        /// </summary>
        [EnumMember(Value = "stack_builds")]
        StackBuilds,

        /// <summary>
        /// Stacks.
        /// </summary>
        [EnumMember(Value = "stacks")]
        Stacks,

        /// <summary>
        /// Sources.
        /// </summary>
        [EnumMember(Value = "sources")]
        Sources,

        /// <summary>
        /// Integrations.
        /// </summary>
        [EnumMember(Value = "integrations")]
        Integrations
    }
}