// <copyright file="Role2Enum.cs" company="APIMatic">
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
    /// Role2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role2Enum
    {
        /// <summary>
        /// Orchestrator.
        /// </summary>
        [EnumMember(Value = "orchestrator")]
        Orchestrator
    }
}