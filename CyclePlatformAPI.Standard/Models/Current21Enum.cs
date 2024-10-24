// <copyright file="Current21Enum.cs" company="APIMatic">
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
    /// Current21Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current21Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Provisioning.
        /// </summary>
        [EnumMember(Value = "provisioning")]
        Provisioning,

        /// <summary>
        /// Configuring.
        /// </summary>
        [EnumMember(Value = "configuring")]
        Configuring,

        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Deleting.
        /// </summary>
        [EnumMember(Value = "deleting")]
        Deleting,

        /// <summary>
        /// Deleted.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
}