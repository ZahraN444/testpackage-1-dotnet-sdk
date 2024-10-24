// <copyright file="DesiredComponentEnum.cs" company="APIMatic">
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
    /// DesiredComponentEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DesiredComponentEnum
    {
        /// <summary>
        /// Cluster.
        /// </summary>
        [EnumMember(Value = "cluster")]
        Cluster,

        /// <summary>
        /// Environment.
        /// </summary>
        [EnumMember(Value = "environment")]
        Environment,

        /// <summary>
        /// Imagesource.
        /// </summary>
        [EnumMember(Value = "image-source")]
        Imagesource,

        /// <summary>
        /// Stack.
        /// </summary>
        [EnumMember(Value = "stack")]
        Stack,

        /// <summary>
        /// Server.
        /// </summary>
        [EnumMember(Value = "server")]
        Server,

        /// <summary>
        /// Container.
        /// </summary>
        [EnumMember(Value = "container")]
        Container
    }
}