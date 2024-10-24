// <copyright file="StacksController.cs" company="APIMatic">
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
    /// StacksController.
    /// </summary>
    public class StacksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StacksController"/> class.
        /// </summary>
        internal StacksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `stacks-view` permission.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1StacksResponse response from the API call.</returns>
        public Models.V1StacksResponse GetStacks(
                List<Models.Meta30Enum> meta = null,
                List<Models.Include12Enum> include = null,
                Models.Filter28 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetStacksAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `stacks-view` permission.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksResponse response from the API call.</returns>
        public async Task<Models.V1StacksResponse> GetStacksAsync(
                List<Models.Meta30Enum> meta = null,
                List<Models.Include12Enum> include = null,
                Models.Filter28 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/stacks")
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
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack..</param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public Models.V1StacksResponse1 CreateStack(
                Models.V1StacksRequest body = null)
            => CoreHelper.RunTask(CreateStackAsync(body));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public async Task<Models.V1StacksResponse1> CreateStackAsync(
                Models.V1StacksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/stacks")
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
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public Models.V1StacksResponse1 GetStack(
                string stackId)
            => CoreHelper.RunTask(GetStackAsync(stackId));

        /// <summary>
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public async Task<Models.V1StacksResponse1> GetStackAsync(
                string stackId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/stacks/{stackId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("stackId", stackId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for updating a Stack..</param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public Models.V1StacksResponse1 UpdateStack(
                string stackId,
                Models.V1StacksRequest1 body = null)
            => CoreHelper.RunTask(UpdateStackAsync(stackId, body));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for updating a Stack..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksResponse1 response from the API call.</returns>
        public async Task<Models.V1StacksResponse1> UpdateStackAsync(
                string stackId,
                Models.V1StacksRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/stacks/{stackId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <returns>Returns the Models.V1StacksResponse4 response from the API call.</returns>
        public Models.V1StacksResponse4 DeleteStack(
                string stackId)
            => CoreHelper.RunTask(DeleteStackAsync(stackId));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksResponse4 response from the API call.</returns>
        public async Task<Models.V1StacksResponse4> DeleteStackAsync(
                string stackId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/stacks/{stackId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("stackId", stackId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Job..</param>
        /// <returns>Returns the Models.V1StacksTasksResponse response from the API call.</returns>
        public Models.V1StacksTasksResponse CreateStackJob(
                string stackId,
                Models.PruneStackBuilds body = null)
            => CoreHelper.RunTask(CreateStackJobAsync(stackId, body));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksTasksResponse response from the API call.</returns>
        public async Task<Models.V1StacksTasksResponse> CreateStackJobAsync(
                string stackId,
                Models.PruneStackBuilds body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/stacks/{stackId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Look up a Stack Build using only the Build ID, instead of requiring a Stack ID as well.
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public Models.V1StacksBuildsResponse LookupStackBuild(
                string buildId)
            => CoreHelper.RunTask(LookupStackBuildAsync(buildId));

        /// <summary>
        /// Look up a Stack Build using only the Build ID, instead of requiring a Stack ID as well.
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public async Task<Models.V1StacksBuildsResponse> LookupStackBuildAsync(
                string buildId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/stacks/builds/{buildId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("buildId", buildId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1StacksBuildsResponse1 response from the API call.</returns>
        public Models.V1StacksBuildsResponse1 GetStackBuilds(
                string stackId,
                List<Models.Meta24Enum> meta = null,
                Models.Filter29 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetStackBuildsAsync(stackId, meta, filter, sort, page));

        /// <summary>
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsResponse1 response from the API call.</returns>
        public async Task<Models.V1StacksBuildsResponse1> GetStackBuildsAsync(
                string stackId,
                List<Models.Meta24Enum> meta = null,
                Models.Filter29 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/stacks/{stackId}/builds")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Build..</param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public Models.V1StacksBuildsResponse CreateStackBuild(
                string stackId,
                Models.V1StacksBuildsRequest body = null)
            => CoreHelper.RunTask(CreateStackBuildAsync(stackId, body));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack.</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Build..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public async Task<Models.V1StacksBuildsResponse> CreateStackBuildAsync(
                string stackId,
                Models.V1StacksBuildsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/stacks/{stackId}/builds")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public Models.V1StacksBuildsResponse GetStackBuild(
                string stackId,
                string buildId)
            => CoreHelper.RunTask(GetStackBuildAsync(stackId, buildId));

        /// <summary>
        /// Requires the `stacks-view` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsResponse response from the API call.</returns>
        public async Task<Models.V1StacksBuildsResponse> GetStackBuildAsync(
                string stackId,
                string buildId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/stacks/{stackId}/builds/{buildId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Template(_template => _template.Setup("buildId", buildId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <returns>Returns the Models.V1StacksBuildsResponse4 response from the API call.</returns>
        public Models.V1StacksBuildsResponse4 DeleteStackBuild(
                string stackId,
                string buildId)
            => CoreHelper.RunTask(DeleteStackBuildAsync(stackId, buildId));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsResponse4 response from the API call.</returns>
        public async Task<Models.V1StacksBuildsResponse4> DeleteStackBuildAsync(
                string stackId,
                string buildId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/stacks/{stackId}/builds/{buildId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Template(_template => _template.Setup("buildId", buildId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Build Job..</param>
        /// <returns>Returns the Models.V1StacksBuildsTasksResponse response from the API call.</returns>
        public Models.V1StacksBuildsTasksResponse CreateStackBuildJob(
                string stackId,
                string buildId,
                CreateStackBuildJobBody body = null)
            => CoreHelper.RunTask(CreateStackBuildJobAsync(stackId, buildId, body));

        /// <summary>
        /// Requires the `stacks-manage` capability.
        /// </summary>
        /// <param name="stackId">Required parameter: The ID of the Stack..</param>
        /// <param name="buildId">Required parameter: The ID of the Build..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Stack Build Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1StacksBuildsTasksResponse response from the API call.</returns>
        public async Task<Models.V1StacksBuildsTasksResponse> CreateStackBuildJobAsync(
                string stackId,
                string buildId,
                CreateStackBuildJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1StacksBuildsTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/stacks/{stackId}/builds/{buildId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("stackId", stackId))
                      .Template(_template => _template.Setup("buildId", buildId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}