// <copyright file="HubsController.cs" company="APIMatic">
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
    /// HubsController.
    /// </summary>
    public class HubsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubsController"/> class.
        /// </summary>
        internal HubsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists all associated Hubs.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.ListHubsResponse response from the API call.</returns>
        public Models.ListHubsResponse GetHubs(
                Models.Page page = null,
                Models.Filter15 filter = null)
            => CoreHelper.RunTask(GetHubsAsync(page, filter));

        /// <summary>
        /// Lists all associated Hubs.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListHubsResponse response from the API call.</returns>
        public async Task<Models.ListHubsResponse> GetHubsAsync(
                Models.Page page = null,
                Models.Filter15 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListHubsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a Hub.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Hub..</param>
        /// <returns>Returns the Models.V1HubsResponse response from the API call.</returns>
        public Models.V1HubsResponse CreateHub(
                Models.V1HubsRequest body = null)
            => CoreHelper.RunTask(CreateHubAsync(body));

        /// <summary>
        /// Create a Hub.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Hub..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsResponse response from the API call.</returns>
        public async Task<Models.V1HubsResponse> CreateHubAsync(
                Models.V1HubsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1HubsCurrentResponse response from the API call.</returns>
        public Models.V1HubsCurrentResponse GetHub(
                List<Models.Meta14Enum> meta = null)
            => CoreHelper.RunTask(GetHubAsync(meta));

        /// <summary>
        /// Requires the `hubs-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentResponse> GetHubAsync(
                List<Models.Meta14Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the specified hub, setting the values of the parameters passed.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for updating a hub..</param>
        /// <returns>Returns the Models.HubUpdateResponse response from the API call.</returns>
        public Models.HubUpdateResponse UpdateHub(
                Models.V1HubsCurrentRequest body = null)
            => CoreHelper.RunTask(UpdateHubAsync(body));

        /// <summary>
        /// Updates the specified hub, setting the values of the parameters passed.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for updating a hub..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.HubUpdateResponse response from the API call.</returns>
        public async Task<Models.HubUpdateResponse> UpdateHubAsync(
                Models.V1HubsCurrentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.HubUpdateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/hubs/current")
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
        /// Requires the `hubs-delete` capability. This can only be aquired by being the hub owner.
        /// </summary>
        /// <returns>Returns the Models.V1HubsCurrentResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentResponse1 DeleteHub()
            => CoreHelper.RunTask(DeleteHubAsync());

        /// <summary>
        /// Requires the `hubs-delete` capability. This can only be aquired by being the hub owner.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentResponse1> DeleteHubAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getHubCapabilities EndPoint.
        /// </summary>
        /// <returns>Returns the Models.V1HubsCapabilitiesResponse response from the API call.</returns>
        public Models.V1HubsCapabilitiesResponse GetHubCapabilities()
            => CoreHelper.RunTask(GetHubCapabilitiesAsync());

        /// <summary>
        /// getHubCapabilities EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCapabilitiesResponse response from the API call.</returns>
        public async Task<Models.V1HubsCapabilitiesResponse> GetHubCapabilitiesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCapabilitiesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/capabilities"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1HubsCurrentUsageResponse response from the API call.</returns>
        public Models.V1HubsCurrentUsageResponse GetHubUsage(
                object filter = null)
            => CoreHelper.RunTask(GetHubUsageAsync(filter));

        /// <summary>
        /// Requires the `hubs-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentUsageResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentUsageResponse> GetHubUsageAsync(
                object filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentUsageResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/usage")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getHubActivity EndPoint.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1HubsCurrentActivityResponse response from the API call.</returns>
        public Models.V1HubsCurrentActivityResponse GetHubActivity(
                List<Models.Include15Enum> include = null,
                Models.Filter16 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetHubActivityAsync(include, filter, sort, page));

        /// <summary>
        /// getHubActivity EndPoint.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentActivityResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentActivityResponse> GetHubActivityAsync(
                List<Models.Include15Enum> include = null,
                Models.Filter16 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentActivityResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/activity")
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
        /// Requires the `hub-invites-manage` capability.
        /// </summary>
        /// <param name="inviteId">Required parameter: The ID of the Hub Invite..</param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse response from the API call.</returns>
        public Models.V1HubsCurrentInvitesResponse DeleteHubInvite(
                string inviteId)
            => CoreHelper.RunTask(DeleteHubInviteAsync(inviteId));

        /// <summary>
        /// Requires the `hub-invites-manage` capability.
        /// </summary>
        /// <param name="inviteId">Required parameter: The ID of the Hub Invite..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentInvitesResponse> DeleteHubInviteAsync(
                string inviteId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentInvitesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current/invites/{inviteId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("inviteId", inviteId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-invites-manage` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentInvitesResponse1 GetHubInvites(
                List<Models.Meta1Enum> meta = null,
                List<Models.Include16Enum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetHubInvitesAsync(meta, include, sort, filter, page));

        /// <summary>
        /// Requires the `hubs-invites-manage` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentInvitesResponse1> GetHubInvitesAsync(
                List<Models.Meta1Enum> meta = null,
                List<Models.Include16Enum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentInvitesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/invites")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-invites-send` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Hub invite..</param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse response from the API call.</returns>
        public Models.V1HubsCurrentInvitesResponse CreateHubInvite(
                Models.V1HubsCurrentInvitesRequest body = null)
            => CoreHelper.RunTask(CreateHubInviteAsync(body));

        /// <summary>
        /// Requires the `hubs-invites-send` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a Hub invite..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentInvitesResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentInvitesResponse> CreateHubInviteAsync(
                Models.V1HubsCurrentInvitesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentInvitesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs/current/invites")
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
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse response from the API call.</returns>
        public Models.V1HubsCurrentMembersResponse GetHubMembers(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetHubMembersAsync(meta, include, sort, filter, page));

        /// <summary>
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembersResponse> GetHubMembersAsync(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/members")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the Hub Membership for the requesting Account.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1HubsCurrentMembershipResponse response from the API call.</returns>
        public Models.V1HubsCurrentMembershipResponse GetHubMembership(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetHubMembershipAsync(meta, include, sort, filter, page));

        /// <summary>
        /// Gets the Hub Membership for the requesting Account.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembershipResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembershipResponse> GetHubMembershipAsync(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembershipResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/membership")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID for the given Hub member..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentMembersResponse1 GetHubMember(
                string memberId,
                List<Models.IncludeEnum> include = null)
            => CoreHelper.RunTask(GetHubMemberAsync(memberId, include));

        /// <summary>
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID for the given Hub member..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembersResponse1> GetHubMemberAsync(
                string memberId,
                List<Models.IncludeEnum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/members/{memberId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("memberId", memberId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-members-manage` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID for the given member..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Hub membership..</param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse2 response from the API call.</returns>
        public Models.V1HubsCurrentMembersResponse2 UpdateHubMember(
                string memberId,
                Models.V1HubsCurrentMembersRequest body = null)
            => CoreHelper.RunTask(UpdateHubMemberAsync(memberId, body));

        /// <summary>
        /// Requires the `hubs-members-manage` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID for the given member..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Hub membership..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse2 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembersResponse2> UpdateHubMemberAsync(
                string memberId,
                Models.V1HubsCurrentMembersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/hubs/current/members/{memberId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("memberId", memberId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-members-manage` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID of the given Hub Member..</param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse3 response from the API call.</returns>
        public Models.V1HubsCurrentMembersResponse3 DeleteHubMember(
                string memberId)
            => CoreHelper.RunTask(DeleteHubMemberAsync(memberId));

        /// <summary>
        /// Requires the `hubs-members-manage` capability.
        /// </summary>
        /// <param name="memberId">Required parameter: The ID of the given Hub Member..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembersResponse3 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembersResponse3> DeleteHubMemberAsync(
                string memberId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembersResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current/members/{memberId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("memberId", memberId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the member's Account..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1HubsCurrentMembersAccountResponse response from the API call.</returns>
        public Models.V1HubsCurrentMembersAccountResponse GetHubMemberAccount(
                string accountId,
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null)
            => CoreHelper.RunTask(GetHubMemberAccountAsync(accountId, meta, include));

        /// <summary>
        /// Requires the `hubs-members-view` capability.
        /// </summary>
        /// <param name="accountId">Required parameter: The ID of the member's Account..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentMembersAccountResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentMembersAccountResponse> GetHubMemberAccountAsync(
                string accountId,
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentMembersAccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/members/account/{accountId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountId", accountId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.ListApiKeysResponse response from the API call.</returns>
        public Models.ListApiKeysResponse GetApiKeys(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetApiKeysAsync(sort, filter, page));

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListApiKeysResponse response from the API call.</returns>
        public async Task<Models.ListApiKeysResponse> GetApiKeysAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListApiKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/api-keys")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an API Key..</param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public Models.V1HubsCurrentApiKeysResponse CreateApiKey(
                Models.V1HubsCurrentApiKeysRequest body = null)
            => CoreHelper.RunTask(CreateApiKeyAsync(body));

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an API Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentApiKeysResponse> CreateApiKeyAsync(
                Models.V1HubsCurrentApiKeysRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentApiKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs/current/api-keys")
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
        /// Requries the `api-keys-manage` capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentApiKeysResponse1 GetAPIKey(
                string apikeyId)
            => CoreHelper.RunTask(GetAPIKeyAsync(apikeyId));

        /// <summary>
        /// Requries the `api-keys-manage` capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentApiKeysResponse1> GetAPIKeyAsync(
                string apikeyId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentApiKeysResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/api-keys/{apikeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("apikeyId", apikeyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <param name="body">Optional parameter: Parameters for updating an API Key..</param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public Models.V1HubsCurrentApiKeysResponse UpdateAPIKey(
                string apikeyId,
                Models.V1HubsCurrentApiKeysRequest1 body = null)
            => CoreHelper.RunTask(UpdateAPIKeyAsync(apikeyId, body));

        /// <summary>
        /// Requires the `api-keys-manage` capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <param name="body">Optional parameter: Parameters for updating an API Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentApiKeysResponse> UpdateAPIKeyAsync(
                string apikeyId,
                Models.V1HubsCurrentApiKeysRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentApiKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/hubs/current/api-keys/{apikeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("apikeyId", apikeyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the 'api-keys-manage' capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public Models.V1HubsCurrentApiKeysResponse DeleteAPIKey(
                string apikeyId)
            => CoreHelper.RunTask(DeleteAPIKeyAsync(apikeyId));

        /// <summary>
        /// Requires the 'api-keys-manage' capability.
        /// </summary>
        /// <param name="apikeyId">Required parameter: The ID of the API Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentApiKeysResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentApiKeysResponse> DeleteAPIKeyAsync(
                string apikeyId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentApiKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current/api-keys/{apikeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("apikeyId", apikeyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the Roles that have been created for this Hub.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse response from the API call.</returns>
        public Models.V1HubsCurrentRolesResponse GetRoles(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetRolesAsync(sort, filter, page));

        /// <summary>
        /// Lists the Roles that have been created for this Hub.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentRolesResponse> GetRolesAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentRolesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/roles")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a custom Role for a Hub.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Hub Role..</param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentRolesResponse1 CreateRole(
                Models.V1HubsCurrentRolesRequest body = null)
            => CoreHelper.RunTask(CreateRoleAsync(body));

        /// <summary>
        /// Creates a custom Role for a Hub.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Hub Role..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentRolesResponse1> CreateRoleAsync(
                Models.V1HubsCurrentRolesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentRolesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs/current/roles")
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
        /// Retrieves the specified Role.
        /// Requries the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <returns>Returns the Models.GetRoleResponse response from the API call.</returns>
        public Models.GetRoleResponse GetRole(
                string roleId)
            => CoreHelper.RunTask(GetRoleAsync(roleId));

        /// <summary>
        /// Retrieves the specified Role.
        /// Requries the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetRoleResponse response from the API call.</returns>
        public async Task<Models.GetRoleResponse> GetRoleAsync(
                string roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetRoleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/roles/{roleId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("roleId", roleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates various properties of a specific Role.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse1 response from the API call.</returns>
        public Models.V1HubsCurrentRolesResponse1 UpdateRole(
                string roleId,
                Models.V1HubsCurrentRolesRequest1 body = null)
            => CoreHelper.RunTask(UpdateRoleAsync(roleId, body));

        /// <summary>
        /// Updates various properties of a specific Role.
        /// Requires the `hubs-roles-manage` capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse1 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentRolesResponse1> UpdateRoleAsync(
                string roleId,
                Models.V1HubsCurrentRolesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentRolesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/hubs/current/roles/{roleId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("roleId", roleId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Marks a Role as 'deleted'. .
        /// Requires the 'hubs-roles-manage' capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse3 response from the API call.</returns>
        public Models.V1HubsCurrentRolesResponse3 DeleteRole(
                string roleId)
            => CoreHelper.RunTask(DeleteRoleAsync(roleId));

        /// <summary>
        /// Marks a Role as 'deleted'. .
        /// Requires the 'hubs-roles-manage' capability.
        /// </summary>
        /// <param name="roleId">Required parameter: The ID of the Role..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentRolesResponse3 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentRolesResponse3> DeleteRoleAsync(
                string roleId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentRolesResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current/roles/{roleId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("roleId", roleId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves details of a single Integration associated with the current hub.
        /// Requires the `hubs-integrations-view` capability.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to retrieve..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsResponse GetIntegration(
                string integrationId,
                List<Models.Meta20Enum> meta = null)
            => CoreHelper.RunTask(GetIntegrationAsync(integrationId, meta));

        /// <summary>
        /// Retrieves details of a single Integration associated with the current hub.
        /// Requires the `hubs-integrations-view` capability.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to retrieve..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsResponse> GetIntegrationAsync(
                string integrationId,
                List<Models.Meta20Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/integrations/{integrationId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("integrationId", integrationId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the specified Integration within the current hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsResponse UpdateIntegration(
                string integrationId,
                Models.V1HubsCurrentIntegrationsRequest body,
                List<Models.Meta20Enum> meta = null)
            => CoreHelper.RunTask(UpdateIntegrationAsync(integrationId, body, meta));

        /// <summary>
        /// Updates the specified Integration within the current hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsResponse> UpdateIntegrationAsync(
                string integrationId,
                Models.V1HubsCurrentIntegrationsRequest body,
                List<Models.Meta20Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/hubs/current/integrations/{integrationId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("integrationId", integrationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes the specified Integration from the current hub, marking it as deleted and returning the updated Integration.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to delete..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse2 response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsResponse2 DeleteIntegration(
                string integrationId)
            => CoreHelper.RunTask(DeleteIntegrationAsync(integrationId));

        /// <summary>
        /// Deletes the specified Integration from the current hub, marking it as deleted and returning the updated Integration.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Integration to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse2 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsResponse2> DeleteIntegrationAsync(
                string integrationId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/hubs/current/integrations/{integrationId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("integrationId", integrationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all integrations associated with the current Hub, with optional filtering.
        /// Requires the `hubs-integrations-view` capability.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. Supports filtering by state and a text search..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse3 response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsResponse3 GetIntegrations(
                Models.Page page = null,
                List<Models.Meta20Enum> meta = null,
                Models.Filter17 filter = null)
            => CoreHelper.RunTask(GetIntegrationsAsync(page, meta, filter));

        /// <summary>
        /// Lists all integrations associated with the current Hub, with optional filtering.
        /// Requires the `hubs-integrations-view` capability.
        /// </summary>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. Supports filtering by state and a text search..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse3 response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsResponse3> GetIntegrationsAsync(
                Models.Page page = null,
                List<Models.Meta20Enum> meta = null,
                Models.Filter17 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/integrations")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create an Integration resource within a hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.
        /// </summary>
        /// <param name="body">Required parameter: Parameters for creating an Integration..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsResponse CreateIntegration(
                Models.V1HubsCurrentIntegrationsRequest1 body,
                List<Models.Meta20Enum> meta = null)
            => CoreHelper.RunTask(CreateIntegrationAsync(body, meta));

        /// <summary>
        /// Create an Integration resource within a hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.
        /// </summary>
        /// <param name="body">Required parameter: Parameters for creating an Integration..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsResponse> CreateIntegrationAsync(
                Models.V1HubsCurrentIntegrationsRequest1 body,
                List<Models.Meta20Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs/current/integrations")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a map of available integrations categorized by their type.
        /// </summary>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsAvailableResponse response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsAvailableResponse GetAvailableIntegrations()
            => CoreHelper.RunTask(GetAvailableIntegrationsAsync());

        /// <summary>
        /// Returns a map of available integrations categorized by their type.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsAvailableResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsAvailableResponse> GetAvailableIntegrationsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsAvailableResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/integrations/available")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new Job targeted at the provided Hub Integration. .
        /// ## Required Permissions.
        ///   - Requires a valid hub membership to the target hub.
        ///   - Requires the `hubs-integrations-manage` capability.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Hub Integration..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Hub Integration Job..</param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsTasksResponse response from the API call.</returns>
        public Models.V1HubsCurrentIntegrationsTasksResponse CreateIntegrationJob(
                string integrationId,
                Models.V1HubsCurrentIntegrationsTasksRequest body = null)
            => CoreHelper.RunTask(CreateIntegrationJobAsync(integrationId, body));

        /// <summary>
        /// Creates a new Job targeted at the provided Hub Integration. .
        /// ## Required Permissions.
        ///   - Requires a valid hub membership to the target hub.
        ///   - Requires the `hubs-integrations-manage` capability.
        /// </summary>
        /// <param name="integrationId">Required parameter: The ID of the Hub Integration..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Hub Integration Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentIntegrationsTasksResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentIntegrationsTasksResponse> CreateIntegrationJobAsync(
                string integrationId,
                Models.V1HubsCurrentIntegrationsTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentIntegrationsTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/hubs/current/integrations/{integrationId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("integrationId", integrationId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Initializes authorization for the Hub notification pipeline. The Hub notification pipeline is a one-way streaming websocket that.
        /// sends real-time 'notifications' as things are happening on the Hub. These notifications tell some basic information about an event,.
        /// and it is up to the user to fetch additional details, if deemed necessary.
        /// Requesting this endpoint without a `?token=<token>` URL parameter will result in receiving a short lived token in the response body. That .
        /// token can then be applied to the URL parameter to the same endpoint to upgrade the connection to a WebSocket.
        /// Requires the `apionly-notifications-listen` capability.
        /// ]]>
        /// </summary>
        /// <returns>Returns the Models.V1HubsCurrentNotificationsResponse response from the API call.</returns>
        public Models.V1HubsCurrentNotificationsResponse GetHubNotificationSocketAuth()
            => CoreHelper.RunTask(GetHubNotificationSocketAuthAsync());

        /// <summary>
        /// <![CDATA[
        /// Initializes authorization for the Hub notification pipeline. The Hub notification pipeline is a one-way streaming websocket that.
        /// sends real-time 'notifications' as things are happening on the Hub. These notifications tell some basic information about an event,.
        /// and it is up to the user to fetch additional details, if deemed necessary.
        /// Requesting this endpoint without a `?token=<token>` URL parameter will result in receiving a short lived token in the response body. That .
        /// token can then be applied to the URL parameter to the same endpoint to upgrade the connection to a WebSocket.
        /// Requires the `apionly-notifications-listen` capability.
        /// ]]>
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1HubsCurrentNotificationsResponse response from the API call.</returns>
        public async Task<Models.V1HubsCurrentNotificationsResponse> GetHubNotificationSocketAuthAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1HubsCurrentNotificationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/hubs/current/notifications")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}