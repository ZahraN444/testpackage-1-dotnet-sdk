// <copyright file="StatusEnum.cs" company="APIMatic">
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
    /// StatusEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Enum400.
        /// </summary>
        Enum400 = 400,

        /// <summary>
        /// Enum401.
        /// </summary>
        Enum401 = 401,

        /// <summary>
        /// Enum403.
        /// </summary>
        Enum403 = 403,

        /// <summary>
        /// Enum404.
        /// </summary>
        Enum404 = 404,

        /// <summary>
        /// Enum409.
        /// </summary>
        Enum409 = 409,

        /// <summary>
        /// Enum415.
        /// </summary>
        Enum415 = 415,

        /// <summary>
        /// Enum422.
        /// </summary>
        Enum422 = 422,

        /// <summary>
        /// Enum500.
        /// </summary>
        Enum500 = 500
    }
}