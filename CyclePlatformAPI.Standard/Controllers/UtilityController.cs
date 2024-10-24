// <copyright file="UtilityController.cs" company="APIMatic">
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
    /// UtilityController.
    /// </summary>
    public class UtilityController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityController"/> class.
        /// </summary>
        internal UtilityController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Given a (base64'd) resource identifier string (i.e. `cluster:production/env:abc`), returns the ID of the matching resource.
        /// If more than one resource matches the identifier, or no resource matches the identifier, this endpoint will return an error. .
        /// Given identifiers are NOT unique, you may need to be more specific to target the exact identifier.
        /// </summary>
        /// <param name="identifier">Required parameter: A base64 encoded resource identifier string..</param>
        /// <param name="desiredComponent">Required parameter: The type of resource to lookup from the identifier string..</param>
        /// <returns>Returns the Models.V1UtilsResourceLookupResponse response from the API call.</returns>
        public Models.V1UtilsResourceLookupResponse LookupIdentifier(
                string identifier,
                Models.DesiredComponentEnum desiredComponent)
            => CoreHelper.RunTask(LookupIdentifierAsync(identifier, desiredComponent));

        /// <summary>
        /// Given a (base64'd) resource identifier string (i.e. `cluster:production/env:abc`), returns the ID of the matching resource.
        /// If more than one resource matches the identifier, or no resource matches the identifier, this endpoint will return an error. .
        /// Given identifiers are NOT unique, you may need to be more specific to target the exact identifier.
        /// </summary>
        /// <param name="identifier">Required parameter: A base64 encoded resource identifier string..</param>
        /// <param name="desiredComponent">Required parameter: The type of resource to lookup from the identifier string..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1UtilsResourceLookupResponse response from the API call.</returns>
        public async Task<Models.V1UtilsResourceLookupResponse> LookupIdentifierAsync(
                string identifier,
                Models.DesiredComponentEnum desiredComponent,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1UtilsResourceLookupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/utils/resource/lookup")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("identifier", identifier))
                      .Query(_query => _query.Setup("desired-component", ApiHelper.JsonSerialize(desiredComponent).Trim('\"')))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}