// <copyright file="SearchController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Exceptions;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace CyclePlatformAPI.Standard.Controllers
{
    /// <summary>
    /// SearchController.
    /// </summary>
    public class SearchController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchController"/> class.
        /// </summary>
        internal SearchController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Gets a pre-built search index, containing IDs and basic information for many commonly used resources on the Hub.
        /// Can be used to build a 'quick search' functionality for referencing the most frequently used resources.
        /// Requires the `view` capability for each returned segment, i.e. to retrieve Containers, you must have `containers-view`.
        /// </summary>
        /// <returns>Returns the Models.V1SearchIndexResponse response from the API call.</returns>
        public Models.V1SearchIndexResponse GetSearchIndex()
            => CoreHelper.RunTask(GetSearchIndexAsync());

        /// <summary>
        /// Gets a pre-built search index, containing IDs and basic information for many commonly used resources on the Hub.
        /// Can be used to build a 'quick search' functionality for referencing the most frequently used resources.
        /// Requires the `view` capability for each returned segment, i.e. to retrieve Containers, you must have `containers-view`.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SearchIndexResponse response from the API call.</returns>
        public async Task<Models.V1SearchIndexResponse> GetSearchIndexAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SearchIndexResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/search/index")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}