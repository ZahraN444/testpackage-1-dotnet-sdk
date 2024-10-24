// <copyright file="Event1Enum.cs" company="APIMatic">
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
    /// Event1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Event1Enum
    {
        /// <summary>
        /// Suggestion.
        /// </summary>
        [EnumMember(Value = "suggestion")]
        Suggestion,

        /// <summary>
        /// Notice.
        /// </summary>
        [EnumMember(Value = "notice")]
        Notice,

        /// <summary>
        /// Prevention.
        /// </summary>
        [EnumMember(Value = "prevention")]
        Prevention,

        /// <summary>
        /// Detection.
        /// </summary>
        [EnumMember(Value = "detection")]
        Detection,

        /// <summary>
        /// Reaction.
        /// </summary>
        [EnumMember(Value = "reaction")]
        Reaction
    }
}