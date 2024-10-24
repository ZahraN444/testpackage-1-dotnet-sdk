// <copyright file="ErrorEnvelopeException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Models;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Exceptions
{
    /// <summary>
    /// ErrorEnvelopeException.
    /// </summary>
    public class ErrorEnvelopeException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEnvelopeException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ErrorEnvelopeException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The Cycle API uses standard HTTP response codes to indicate the success or failure of an API request. Codes in the `2xx` range indicate success. Codes in the `4xx` range indicate a request that failed due to input, and codes in the `5xx` range indicate an error on Cycle's part (rare).
        /// There are two types of error response objects. Errors with authentication are formatted to follow the OAuth spec, while all other errors follow the same convention. If you're using one of our API Libraries, they will standardize OAuth errors to fit the general convention.
        /// </summary>
        [JsonProperty("error")]
        public Models.Error Error { get; set; }
    }
}