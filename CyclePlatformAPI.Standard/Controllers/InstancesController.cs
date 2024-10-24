// <copyright file="InstancesController.cs" company="APIMatic">
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
    /// InstancesController.
    /// </summary>
    public class InstancesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesController"/> class.
        /// </summary>
        internal InstancesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Manually delete Instances of a Container.
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container the instance(s) were created from..</param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public Models.V1ContainersInstancesResponse1 DeleteContainerInstances(
                string containerId)
            => CoreHelper.RunTask(DeleteContainerInstancesAsync(containerId));

        /// <summary>
        /// Manually delete Instances of a Container.
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container the instance(s) were created from..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesResponse1> DeleteContainerInstancesAsync(
                string containerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/containers/{containerId}/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}