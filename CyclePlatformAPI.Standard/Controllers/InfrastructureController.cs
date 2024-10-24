// <copyright file="InfrastructureController.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace CyclePlatformAPI.Standard.Controllers
{
    /// <summary>
    /// InfrastructureController.
    /// </summary>
    public class InfrastructureController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureController"/> class.
        /// </summary>
        internal InfrastructureController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `infrastructure-servers-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1InfrastructureSummaryResponse response from the API call.</returns>
        public Models.V1InfrastructureSummaryResponse GetInfrastructureSummary(
                Models.Filter20 filter = null)
            => CoreHelper.RunTask(GetInfrastructureSummaryAsync(filter));

        /// <summary>
        /// Requires the `infrastructure-servers-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureSummaryResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureSummaryResponse> GetInfrastructureSummaryAsync(
                Models.Filter20 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/summary")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getProviderServers EndPoint.
        /// </summary>
        /// <param name="providerVendor">Required parameter: The vendor for the given provider. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use a Provider Integration ID..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1InfrastructureProvidersServersResponse response from the API call.</returns>
        public Models.V1InfrastructureProvidersServersResponse GetProviderServers(
                string providerVendor,
                List<string> sort = null,
                Models.Page page = null,
                Models.Filter21 filter = null)
            => CoreHelper.RunTask(GetProviderServersAsync(providerVendor, sort, page, filter));

        /// <summary>
        /// getProviderServers EndPoint.
        /// </summary>
        /// <param name="providerVendor">Required parameter: The vendor for the given provider. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use a Provider Integration ID..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureProvidersServersResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureProvidersServersResponse> GetProviderServersAsync(
                string providerVendor,
                List<string> sort = null,
                Models.Page page = null,
                Models.Filter21 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureProvidersServersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/providers/{providerVendor}/servers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("providerVendor", providerVendor))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getProviderLocations EndPoint.
        /// </summary>
        /// <param name="providerVendor">Required parameter: The vendor for the given Provider Integration. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use the Integration ID..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1InfrastructureProvidersLocationsResponse response from the API call.</returns>
        public Models.V1InfrastructureProvidersLocationsResponse GetProviderLocations(
                string providerVendor,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetProviderLocationsAsync(providerVendor, sort, page));

        /// <summary>
        /// getProviderLocations EndPoint.
        /// </summary>
        /// <param name="providerVendor">Required parameter: The vendor for the given Provider Integration. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use the Integration ID..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureProvidersLocationsResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureProvidersLocationsResponse> GetProviderLocationsAsync(
                string providerVendor,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureProvidersLocationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/providers/{providerVendor}/locations")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("providerVendor", providerVendor))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `autoscale-groups-manage` capability.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse response from the API call.</returns>
        public Models.V1InfrastructureAutoScaleGroupsResponse GetAutoScaleGroups(
                Models.Page page = null,
                List<Models.Include25Enum> include = null,
                Models.Filter22 filter = null)
            => CoreHelper.RunTask(GetAutoScaleGroupsAsync(page, include, filter));

        /// <summary>
        /// Requires the `autoscale-groups-manage` capability.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureAutoScaleGroupsResponse> GetAutoScaleGroupsAsync(
                Models.Page page = null,
                List<Models.Include25Enum> include = null,
                Models.Filter22 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureAutoScaleGroupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/auto-scale/groups")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the 'autoscale-groups-manage'.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an Auto-Scale Group.</param>
        /// <returns>Returns the Models.CreateAutoScaleGroupResponse response from the API call.</returns>
        public Models.CreateAutoScaleGroupResponse CreateAutoScaleGroup(
                Models.V1InfrastructureAutoScaleGroupsRequest body = null)
            => CoreHelper.RunTask(CreateAutoScaleGroupAsync(body));

        /// <summary>
        /// Requires the 'autoscale-groups-manage'.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an Auto-Scale Group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateAutoScaleGroupResponse response from the API call.</returns>
        public async Task<Models.CreateAutoScaleGroupResponse> CreateAutoScaleGroupAsync(
                Models.V1InfrastructureAutoScaleGroupsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateAutoScaleGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/infrastructure/auto-scale/groups")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `autoscale-groups-view` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given Auto-Scale Group..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse1 response from the API call.</returns>
        public Models.V1InfrastructureAutoScaleGroupsResponse1 GetAutoScaleGroup(
                string groupId,
                List<Models.Include25Enum> include = null)
            => CoreHelper.RunTask(GetAutoScaleGroupAsync(groupId, include));

        /// <summary>
        /// Requires the `autoscale-groups-view` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given Auto-Scale Group..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse1 response from the API call.</returns>
        public async Task<Models.V1InfrastructureAutoScaleGroupsResponse1> GetAutoScaleGroupAsync(
                string groupId,
                List<Models.Include25Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureAutoScaleGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/auto-scale/groups/{groupId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("groupId", groupId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `autoscale-groups-manage` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given Auto-Scale Group..</param>
        /// <param name="body">Optional parameter: Parameters for creating an Auto-Scale Group.</param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse2 response from the API call.</returns>
        public Models.V1InfrastructureAutoScaleGroupsResponse2 UpdateAutoScaleGroup(
                string groupId,
                Models.V1InfrastructureAutoScaleGroupsRequest body = null)
            => CoreHelper.RunTask(UpdateAutoScaleGroupAsync(groupId, body));

        /// <summary>
        /// Requires the `autoscale-groups-manage` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given Auto-Scale Group..</param>
        /// <param name="body">Optional parameter: Parameters for creating an Auto-Scale Group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse2 response from the API call.</returns>
        public async Task<Models.V1InfrastructureAutoScaleGroupsResponse2> UpdateAutoScaleGroupAsync(
                string groupId,
                Models.V1InfrastructureAutoScaleGroupsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureAutoScaleGroupsResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/infrastructure/auto-scale/groups/{groupId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("groupId", groupId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `autoscale-group-manage` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given autoscale group..</param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse3 response from the API call.</returns>
        public Models.V1InfrastructureAutoScaleGroupsResponse3 DeleteAutoScaleGroup(
                string groupId)
            => CoreHelper.RunTask(DeleteAutoScaleGroupAsync(groupId));

        /// <summary>
        /// Requires the `autoscale-group-manage` capability.
        /// </summary>
        /// <param name="groupId">Required parameter: The ID for the given autoscale group..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureAutoScaleGroupsResponse3 response from the API call.</returns>
        public async Task<Models.V1InfrastructureAutoScaleGroupsResponse3> DeleteAutoScaleGroupAsync(
                string groupId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureAutoScaleGroupsResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/infrastructure/auto-scale/groups/{groupId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("groupId", groupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse response from the API call.</returns>
        public Models.V1InfrastructureServersResponse GetServers(
                List<Models.Meta13Enum> meta = null,
                List<Models.Include25Enum> include = null,
                Models.Filter23 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetServersAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersResponse> GetServersAsync(
                List<Models.Meta13Enum> meta = null,
                List<Models.Include25Enum> include = null,
                Models.Filter23 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-provision` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Server..</param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse1 response from the API call.</returns>
        public Models.V1InfrastructureServersResponse1 CreateServer(
                Models.V1InfrastructureServersRequest body = null)
            => CoreHelper.RunTask(CreateServerAsync(body));

        /// <summary>
        /// Requires the `servers-provision` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Server..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse1 response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersResponse1> CreateServerAsync(
                Models.V1InfrastructureServersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/infrastructure/servers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse2 response from the API call.</returns>
        public Models.V1InfrastructureServersResponse2 GetServer(
                string serverId,
                List<Models.Include25Enum> include = null,
                List<Models.Meta13Enum> meta = null)
            => CoreHelper.RunTask(GetServerAsync(serverId, include, meta));

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse2 response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersResponse2> GetServerAsync(
                string serverId,
                List<Models.Include25Enum> include = null,
                List<Models.Meta13Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/{serverId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Server..</param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse3 response from the API call.</returns>
        public Models.V1InfrastructureServersResponse3 UpdateServer(
                string serverId,
                Models.V1InfrastructureServersRequest1 body = null)
            => CoreHelper.RunTask(UpdateServerAsync(serverId, body));

        /// <summary>
        /// Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Server..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersResponse3 response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersResponse3> UpdateServerAsync(
                string serverId,
                Models.V1InfrastructureServersRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/infrastructure/servers/{serverId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This call requires the filter query parameter to be used.
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1InfrastructureServersTelemetryResponse response from the API call.</returns>
        public Models.V1InfrastructureServersTelemetryResponse GetServerTelemetry(
                string serverId,
                Models.Filter24 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetServerTelemetryAsync(serverId, filter, sort, page));

        /// <summary>
        /// This call requires the filter query parameter to be used.
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersTelemetryResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersTelemetryResponse> GetServerTelemetryAsync(
                string serverId,
                Models.Filter24 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersTelemetryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/{serverId}/telemetry")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given server..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.GetServerInstancesReturn response from the API call.</returns>
        public Models.GetServerInstancesReturn GetServerInstances(
                string serverId,
                Models.Page page = null,
                List<Models.Include29Enum> include = null)
            => CoreHelper.RunTask(GetServerInstancesAsync(serverId, page, include));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given server..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetServerInstancesReturn response from the API call.</returns>
        public async Task<Models.GetServerInstancesReturn> GetServerInstancesAsync(
                string serverId,
                Models.Page page = null,
                List<Models.Include29Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetServerInstancesReturn>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/{serverId}/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given Server. Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="body">Optional parameter: Parameters for creating the new Server Job..</param>
        /// <returns>Returns the Models.V1InfrastructureServersTasksResponse response from the API call.</returns>
        public Models.V1InfrastructureServersTasksResponse CreateServerJob(
                string serverId,
                CreateServerJobBody body = null)
            => CoreHelper.RunTask(CreateServerJobAsync(serverId, body));

        /// <summary>
        /// Used to perform different actions on a given Server. Requires the `servers-manage` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given Server..</param>
        /// <param name="body">Optional parameter: Parameters for creating the new Server Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersTasksResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersTasksResponse> CreateServerJobAsync(
                string serverId,
                CreateServerJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/infrastructure/servers/{serverId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("serverId", serverId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.ServerTags response from the API call.</returns>
        public Models.ServerTags GetServerTags(
                Models.Filter25 filter = null)
            => CoreHelper.RunTask(GetServerTagsAsync(filter));

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerTags response from the API call.</returns>
        public async Task<Models.ServerTags> GetServerTagsAsync(
                Models.Filter25 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServerTags>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/tags")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <returns>Returns the Models.ServerClustersReturn response from the API call.</returns>
        public Models.ServerClustersReturn GetClusters()
            => CoreHelper.RunTask(GetClustersAsync());

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ServerClustersReturn response from the API call.</returns>
        public async Task<Models.ServerClustersReturn> GetClustersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ServerClustersReturn>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/clusters")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given server..</param>
        /// <returns>Returns the Models.V1InfrastructureServersUsageResponse response from the API call.</returns>
        public Models.V1InfrastructureServersUsageResponse GetServerUsage(
                string serverId)
            => CoreHelper.RunTask(GetServerUsageAsync(serverId));

        /// <summary>
        /// Requires the `servers-view` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID for the given server..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersUsageResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersUsageResponse> GetServerUsageAsync(
                string serverId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersUsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/{serverId}/usage")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the authorization information required to connect to a Server console websocket.
        /// Requires the `servers-console` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID of the server to connect to..</param>
        /// <returns>Returns the Models.V1InfrastructureServersConsoleResponse response from the API call.</returns>
        public Models.V1InfrastructureServersConsoleResponse GetServerConsole(
                string serverId)
            => CoreHelper.RunTask(GetServerConsoleAsync(serverId));

        /// <summary>
        /// Gets the authorization information required to connect to a Server console websocket.
        /// Requires the `servers-console` capability.
        /// </summary>
        /// <param name="serverId">Required parameter: The ID of the server to connect to..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureServersConsoleResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureServersConsoleResponse> GetServerConsoleAsync(
                string serverId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureServersConsoleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/servers/{serverId}/console")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serverId", serverId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse response from the API call.</returns>
        public Models.V1InfrastructureIpsPoolsResponse GetInfrastructureIPPools(
                List<Models.Include30Enum> include = null,
                Models.Filter26 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetInfrastructureIPPoolsAsync(include, filter, sort, page));

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureIpsPoolsResponse> GetInfrastructureIPPoolsAsync(
                List<Models.Include30Enum> include = null,
                Models.Filter26 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureIpsPoolsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/ips/pools")
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
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID for the given pool..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse1 response from the API call.</returns>
        public Models.V1InfrastructureIpsPoolsResponse1 GetIPPool(
                string poolId,
                List<Models.Include30Enum> include = null)
            => CoreHelper.RunTask(GetIPPoolAsync(poolId, include));

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID for the given pool..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse1 response from the API call.</returns>
        public async Task<Models.V1InfrastructureIpsPoolsResponse1> GetIPPoolAsync(
                string poolId,
                List<Models.Include30Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureIpsPoolsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/ips/pools/{poolId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("poolId", poolId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID for the given IP Pool..</param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse2 response from the API call.</returns>
        public Models.V1InfrastructureIpsPoolsResponse2 DeleteIPPool(
                string poolId)
            => CoreHelper.RunTask(DeleteIPPoolAsync(poolId));

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID for the given IP Pool..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsResponse2 response from the API call.</returns>
        public async Task<Models.V1InfrastructureIpsPoolsResponse2> DeleteIPPoolAsync(
                string poolId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureIpsPoolsResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/infrastructure/ips/pools/{poolId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("poolId", poolId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID of the IP Pool to fetch the IPs of..</param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsIpsResponse response from the API call.</returns>
        public Models.V1InfrastructureIpsPoolsIpsResponse GetPoolIPs(
                string poolId)
            => CoreHelper.RunTask(GetPoolIPsAsync(poolId));

        /// <summary>
        /// Requires the `infrastructure-ips-manage` capability.
        /// </summary>
        /// <param name="poolId">Required parameter: The ID of the IP Pool to fetch the IPs of..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureIpsPoolsIpsResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureIpsPoolsIpsResponse> GetPoolIPsAsync(
                string poolId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureIpsPoolsIpsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/ips/pools/{poolId}/ips")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("poolId", poolId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the available deployment strategies that can be used to orchestrate containers.
        /// </summary>
        /// <returns>Returns the Models.V1InfrastructureDeploymentStrategiesResponse response from the API call.</returns>
        public Models.V1InfrastructureDeploymentStrategiesResponse GetDeploymentStrategies()
            => CoreHelper.RunTask(GetDeploymentStrategiesAsync());

        /// <summary>
        /// Gets the available deployment strategies that can be used to orchestrate containers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1InfrastructureDeploymentStrategiesResponse response from the API call.</returns>
        public async Task<Models.V1InfrastructureDeploymentStrategiesResponse> GetDeploymentStrategiesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1InfrastructureDeploymentStrategiesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/infrastructure/deployment-strategies")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}