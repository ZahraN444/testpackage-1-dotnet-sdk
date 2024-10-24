// <copyright file="SDNController.cs" company="APIMatic">
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
    /// SDNController.
    /// </summary>
    public class SDNController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDNController"/> class.
        /// </summary>
        internal SDNController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `sdn-networks-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.ListNetworksResponse response from the API call.</returns>
        public Models.ListNetworksResponse GetNetworks(
                List<Models.Include34Enum> include = null,
                Models.Filter30 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetNetworksAsync(include, filter, sort, page));

        /// <summary>
        /// Requires the `sdn-networks-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListNetworksResponse response from the API call.</returns>
        public async Task<Models.ListNetworksResponse> GetNetworksAsync(
                List<Models.Include34Enum> include = null,
                Models.Filter30 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListNetworksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/sdn/networks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Network..</param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public Models.V1SdnNetworksResponse CreateNetwork(
                List<Models.Include34Enum> include = null,
                Models.V1SdnNetworksRequest body = null)
            => CoreHelper.RunTask(CreateNetworkAsync(include, body));

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Network..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public async Task<Models.V1SdnNetworksResponse> CreateNetworkAsync(
                List<Models.Include34Enum> include = null,
                Models.V1SdnNetworksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SdnNetworksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/sdn/networks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `sdn-networks-view` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public Models.V1SdnNetworksResponse GetNetwork(
                string networkId,
                List<Models.Include34Enum> include = null)
            => CoreHelper.RunTask(GetNetworkAsync(networkId, include));

        /// <summary>
        /// Requires the `sdn-networks-view` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public async Task<Models.V1SdnNetworksResponse> GetNetworkAsync(
                string networkId,
                List<Models.Include34Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SdnNetworksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/sdn/networks/{networkId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("networkId", networkId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Network..</param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public Models.V1SdnNetworksResponse UpdateNetwork(
                string networkId,
                List<Models.Include34Enum> include = null,
                Models.V1SdnNetworksRequest1 body = null)
            => CoreHelper.RunTask(UpdateNetworkAsync(networkId, include, body));

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Network..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SdnNetworksResponse response from the API call.</returns>
        public async Task<Models.V1SdnNetworksResponse> UpdateNetworkAsync(
                string networkId,
                List<Models.Include34Enum> include = null,
                Models.V1SdnNetworksRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SdnNetworksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/sdn/networks/{networkId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("networkId", networkId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <returns>Returns the Models.V1SdnNetworksResponse3 response from the API call.</returns>
        public Models.V1SdnNetworksResponse3 DeleteNetwork(
                string networkId)
            => CoreHelper.RunTask(DeleteNetworkAsync(networkId));

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SdnNetworksResponse3 response from the API call.</returns>
        public async Task<Models.V1SdnNetworksResponse3> DeleteNetworkAsync(
                string networkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SdnNetworksResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/sdn/networks/{networkId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("networkId", networkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Network Job..</param>
        /// <returns>Returns the Models.V1SdnNetworksTasksResponse response from the API call.</returns>
        public Models.V1SdnNetworksTasksResponse CreateNetworkJob(
                string networkId,
                Models.ReconfigureSDNNetwork body = null)
            => CoreHelper.RunTask(CreateNetworkJobAsync(networkId, body));

        /// <summary>
        /// Requires the `sdn-networks-manage` capability.
        /// </summary>
        /// <param name="networkId">Required parameter: The ID of the Network..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Network Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1SdnNetworksTasksResponse response from the API call.</returns>
        public async Task<Models.V1SdnNetworksTasksResponse> CreateNetworkJobAsync(
                string networkId,
                Models.ReconfigureSDNNetwork body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1SdnNetworksTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/sdn/networks/{networkId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("networkId", networkId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}