// <copyright file="OpEnum.cs" company="APIMatic">
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
    /// OpEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OpEnum
    {
        /// <summary>
        /// SCMPCMPNE.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_NE")]
        SCMPCMPNE,

        /// <summary>
        /// SCMPCMPLT.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_LT")]
        SCMPCMPLT,

        /// <summary>
        /// SCMPCMPLE.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_LE")]
        SCMPCMPLE,

        /// <summary>
        /// SCMPCMPEQ.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_EQ")]
        SCMPCMPEQ,

        /// <summary>
        /// SCMPCMPGE.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_GE")]
        SCMPCMPGE,

        /// <summary>
        /// SCMPCMPGT.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_GT")]
        SCMPCMPGT,

        /// <summary>
        /// SCMPCMPMASKEDEQ.
        /// </summary>
        [EnumMember(Value = "SCMP_CMP_MASKED_EQ")]
        SCMPCMPMASKEDEQ
    }
}