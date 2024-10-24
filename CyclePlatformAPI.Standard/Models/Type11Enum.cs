// <copyright file="Type11Enum.cs" company="APIMatic">
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
    /// Type11Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type11Enum
    {
        /// <summary>
        /// Restore.
        /// </summary>
        [EnumMember(Value = "restore")]
        Restore,

        /// <summary>
        /// Backup.
        /// </summary>
        [EnumMember(Value = "backup")]
        Backup
    }
}