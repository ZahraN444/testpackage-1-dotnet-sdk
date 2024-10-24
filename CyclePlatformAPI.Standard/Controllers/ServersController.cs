// <copyright file="ServersController.cs" company="APIMatic">
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
    /// ServersController.
    /// </summary>
    public class ServersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServersController"/> class.
        /// </summary>
        internal ServersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID of the Server..</param>
        /// <param name="options">Optional parameter: The option field is a key-value object, where the key is the option, and the value is a boolean. For example, `?option[force]=true`.</param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse1 response from the API call.</returns>
        public Models.V1InfrastructureServersResponse1 DeleteServer(
                string serverId,
                Dictionary<string, string> options = null)
            => CoreHelper.RunTask(DeleteServerAsync(serverId, options));

        /// <summary>
        /// Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID of the Server..</param>
        /// <param name="options">Optional parameter: The option field is a key-value object, where the key is the option, and the value is a boolean. For example, `?option[force]=true`.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse1 response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersResponse1> DeleteServerAsync(
                string serverId,
                Dictionary<string, string> options = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/infrastructure/servers/{serverId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Query(_query => _query.Setup("options", options))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}