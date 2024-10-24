// <copyright file="ContainersController.cs" company="APIMatic">
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
    /// ContainersController.
    /// </summary>
    public class ContainersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainersController"/> class.
        /// </summary>
        internal ContainersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersResponse response from the API call.</returns>
        public Models.V1ContainersResponse GetContainers(
                List<Models.Meta10Enum> meta = null,
                List<Models.Include5Enum> include = null,
                Models.Filter8 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetContainersAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersResponse response from the API call.</returns>
        public async Task<Models.V1ContainersResponse> GetContainersAsync(
                List<Models.Meta10Enum> meta = null,
                List<Models.Include5Enum> include = null,
                Models.Filter8 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers")
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
        /// Requires the `containers-deploy` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Container..</param>
        /// <returns>Returns the Models.V1ContainersResponse1 response from the API call.</returns>
        public Models.V1ContainersResponse1 CreateContainer(
                Models.V1ContainersRequest body = null)
            => CoreHelper.RunTask(CreateContainerAsync(body));

        /// <summary>
        /// Requires the `containers-deploy` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Container..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersResponse1 response from the API call.</returns>
        public async Task<Models.V1ContainersResponse1> CreateContainerAsync(
                Models.V1ContainersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/containers")
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
        /// Gets a Container.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1ContainersResponse2 response from the API call.</returns>
        public Models.V1ContainersResponse2 GetContainer(
                string containerId,
                List<Models.Meta10Enum> meta = null,
                List<Models.Include5Enum> include = null)
            => CoreHelper.RunTask(GetContainerAsync(containerId, meta, include));

        /// <summary>
        /// Gets a Container.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersResponse2 response from the API call.</returns>
        public async Task<Models.V1ContainersResponse2> GetContainerAsync(
                string containerId,
                List<Models.Meta10Enum> meta = null,
                List<Models.Include5Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the specified Container.
        /// Requires the `containers-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the Container..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Container..</param>
        /// <returns>Returns the Models.V1ContainersResponse3 response from the API call.</returns>
        public Models.V1ContainersResponse3 UpdateContainer(
                string containerId,
                Models.V1ContainersRequest1 body = null)
            => CoreHelper.RunTask(UpdateContainerAsync(containerId, body));

        /// <summary>
        /// Updates the specified Container.
        /// Requires the `containers-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the Container..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Container..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersResponse3 response from the API call.</returns>
        public async Task<Models.V1ContainersResponse3> UpdateContainerAsync(
                string containerId,
                Models.V1ContainersRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/containers/{containerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <returns>Returns the Models.V1ContainersResponse4 response from the API call.</returns>
        public Models.V1ContainersResponse4 DeleteContainer(
                string containerId)
            => CoreHelper.RunTask(DeleteContainerAsync(containerId));

        /// <summary>
        /// Requires the `containers-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersResponse4 response from the API call.</returns>
        public async Task<Models.V1ContainersResponse4> DeleteContainerAsync(
                string containerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/containers/{containerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <returns>Returns the Models.V1ContainersSummaryResponse response from the API call.</returns>
        public Models.V1ContainersSummaryResponse GetContainerSummary(
                string containerId)
            => CoreHelper.RunTask(GetContainerSummaryAsync(containerId));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersSummaryResponse response from the API call.</returns>
        public async Task<Models.V1ContainersSummaryResponse> GetContainerSummaryAsync(
                string containerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/summary")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given Container. .
        /// Requires the following capabilities based on the task: .
        /// `start`: `containers-manage`.
        /// `stop`: `containers-manage`.
        /// `reconfigure`: `containers-manage`.
        /// `volumes.reconfigure`: `containers-volumes-manage`.
        /// `reimage`: `containers-manage`.
        /// `scale`: `containers-manage`.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new container job..</param>
        /// <returns>Returns the Models.V1ContainersTasksResponse response from the API call.</returns>
        public Models.V1ContainersTasksResponse CreateContainerJob(
                string containerId,
                CreateContainerJobBody body = null)
            => CoreHelper.RunTask(CreateContainerJobAsync(containerId, body));

        /// <summary>
        /// Used to perform different actions on a given Container. .
        /// Requires the following capabilities based on the task: .
        /// `start`: `containers-manage`.
        /// `stop`: `containers-manage`.
        /// `reconfigure`: `containers-manage`.
        /// `volumes.reconfigure`: `containers-volumes-manage`.
        /// `reimage`: `containers-manage`.
        /// `scale`: `containers-manage`.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new container job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersTasksResponse response from the API call.</returns>
        public async Task<Models.V1ContainersTasksResponse> CreateContainerJobAsync(
                string containerId,
                CreateContainerJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/containers/{containerId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container this instance is created from..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse response from the API call.</returns>
        public Models.V1ContainersInstancesResponse GetInstances(
                string containerId,
                List<Models.Include7Enum> include = null,
                Models.Filter9 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetInstancesAsync(containerId, include, filter, sort, page));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container this instance is created from..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesResponse> GetInstancesAsync(
                string containerId,
                List<Models.Include7Enum> include = null,
                Models.Filter9 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Manually create Instances of a Container.
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the Container this Instance is created from..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public Models.V1ContainersInstancesResponse1 CreateInstances(
                string containerId,
                List<Models.V1ContainersInstancesRequest> body = null)
            => CoreHelper.RunTask(CreateInstancesAsync(containerId, body));

        /// <summary>
        /// Manually create Instances of a Container.
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the Container this Instance is created from..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesResponse1> CreateInstancesAsync(
                string containerId,
                List<Models.V1ContainersInstancesRequest> body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/containers/{containerId}/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse3 response from the API call.</returns>
        public Models.V1ContainersInstancesResponse3 GetInstance(
                string containerId,
                string instanceId,
                List<Models.Include7Enum> include = null)
            => CoreHelper.RunTask(GetInstanceAsync(containerId, instanceId, include));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse3 response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesResponse3> GetInstanceAsync(
                string containerId,
                string instanceId,
                List<Models.Include7Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public Models.V1ContainersInstancesResponse1 DeleteInstance(
                string containerId,
                string instanceId)
            => CoreHelper.RunTask(DeleteInstanceAsync(containerId, instanceId));

        /// <summary>
        /// Requires the `containers-update` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesResponse1 response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesResponse1> DeleteInstanceAsync(
                string containerId,
                string instanceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/containers/{containerId}/instances/{instanceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Generates credentials for connecting to an Instance via SSH. The generated endpoint/secret can be used to log in via SSH.
        /// into the Instance without exposing ports on the container or host.
        /// Requires the `containers-ssh` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <returns>Returns the Models.V1ContainersInstancesSshResponse response from the API call.</returns>
        public Models.V1ContainersInstancesSshResponse GenerateInstanceSSHCredentials(
                string containerId,
                string instanceId)
            => CoreHelper.RunTask(GenerateInstanceSSHCredentialsAsync(containerId, instanceId));

        /// <summary>
        /// Generates credentials for connecting to an Instance via SSH. The generated endpoint/secret can be used to log in via SSH.
        /// into the Instance without exposing ports on the container or host.
        /// Requires the `containers-ssh` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesSshResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesSshResponse> GenerateInstanceSSHCredentialsAsync(
                string containerId,
                string instanceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesSshResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}/ssh")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Instantly expires any SSH credentials generated for this Instance.
        /// Requires the `containers-ssh` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <returns>Returns the Models.ExpireSSHTokenResponse response from the API call.</returns>
        public Models.ExpireSSHTokenResponse ExpireInstanceSSHCredentials(
                string containerId,
                string instanceId)
            => CoreHelper.RunTask(ExpireInstanceSSHCredentialsAsync(containerId, instanceId));

        /// <summary>
        /// Instantly expires any SSH credentials generated for this Instance.
        /// Requires the `containers-ssh` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExpireSSHTokenResponse response from the API call.</returns>
        public async Task<Models.ExpireSSHTokenResponse> ExpireInstanceSSHCredentialsAsync(
                string containerId,
                string instanceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExpireSSHTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/containers/{containerId}/instances/{instanceId}/ssh")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given Container Instance. Can be used to migrate or undo a migration of a Container Instance.
        /// Requires the `containers-instance-migrate` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new container instance job..</param>
        /// <returns>Returns the Models.V1ContainersInstancesTasksResponse response from the API call.</returns>
        public Models.V1ContainersInstancesTasksResponse CreateInstanceJob(
                string containerId,
                string instanceId,
                CreateInstanceJobBody body = null)
            => CoreHelper.RunTask(CreateInstanceJobAsync(containerId, instanceId, body));

        /// <summary>
        /// Used to perform different actions on a given Container Instance. Can be used to migrate or undo a migration of a Container Instance.
        /// Requires the `containers-instance-migrate` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new container instance job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesTasksResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesTasksResponse> CreateInstanceJobAsync(
                string containerId,
                string instanceId,
                CreateInstanceJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/containers/{containerId}/instances/{instanceId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="instanceId">Required parameter: The ID for the Container Instance..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersInstancesVolumesResponse response from the API call.</returns>
        public Models.V1ContainersInstancesVolumesResponse GetInstanceVolumes(
                string containerId,
                string instanceId,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetInstanceVolumesAsync(containerId, instanceId, sort, page));

        /// <summary>
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="instanceId">Required parameter: The ID for the Container Instance..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesVolumesResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesVolumesResponse> GetInstanceVolumesAsync(
                string containerId,
                string instanceId,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesVolumesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}/volumes")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a point-in-time report of an Instance's resource usage (CPU, RAM, Network, Storage, etc).
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1ContainersInstancesTelemetryResourcesReportResponse response from the API call.</returns>
        public Models.V1ContainersInstancesTelemetryResourcesReportResponse GetInstanceTelemetryReport(
                string containerId,
                string instanceId,
                Models.Filter6 filter = null)
            => CoreHelper.RunTask(GetInstanceTelemetryReportAsync(containerId, instanceId, filter));

        /// <summary>
        /// Retrieves a point-in-time report of an Instance's resource usage (CPU, RAM, Network, Storage, etc).
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the container instance..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesTelemetryResourcesReportResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesTelemetryResourcesReportResponse> GetInstanceTelemetryReportAsync(
                string containerId,
                string instanceId,
                Models.Filter6 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesTelemetryResourcesReportResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}/telemetry/resources/report")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves an access token and URL to open a websocket to for streaming instance telemetry live.
        /// This connects directly to the compute layer on the server the instance is hosted on, and streams telemetry in real time.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the Container Instance..</param>
        /// <returns>Returns the Models.V1ContainersInstancesTelemetryResourcesStreamResponse response from the API call.</returns>
        public Models.V1ContainersInstancesTelemetryResourcesStreamResponse GetInstanceTelemetryStreamAuth(
                string containerId,
                string instanceId)
            => CoreHelper.RunTask(GetInstanceTelemetryStreamAuthAsync(containerId, instanceId));

        /// <summary>
        /// Retrieves an access token and URL to open a websocket to for streaming instance telemetry live.
        /// This connects directly to the compute layer on the server the instance is hosted on, and streams telemetry in real time.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="instanceId">Required parameter: The ID for the Container Instance..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesTelemetryResourcesStreamResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesTelemetryResourcesStreamResponse> GetInstanceTelemetryStreamAuthAsync(
                string containerId,
                string instanceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesTelemetryResourcesStreamResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}/telemetry/resources/stream")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all Servers that currently have an Instance of this Container deployed to them.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersServersResponse response from the API call.</returns>
        public Models.V1ContainersServersResponse GetContainerServers(
                string containerId,
                List<Models.Meta12Enum> meta = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetContainerServersAsync(containerId, meta, sort, page));

        /// <summary>
        /// Lists all Servers that currently have an Instance of this Container deployed to them.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersServersResponse response from the API call.</returns>
        public async Task<Models.V1ContainersServersResponse> GetContainerServersAsync(
                string containerId,
                List<Models.Meta12Enum> meta = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersServersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/servers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets a list of servers that are compatible with the specified Container and its restrictions (tags, etc).
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersServersUsableResponse response from the API call.</returns>
        public Models.V1ContainersServersUsableResponse GetCompatibleServers(
                string containerId,
                List<Models.Meta13Enum> meta = null,
                List<Models.Include9Enum> include = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetCompatibleServersAsync(containerId, meta, include, sort, page));

        /// <summary>
        /// Gets a list of servers that are compatible with the specified Container and its restrictions (tags, etc).
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersServersUsableResponse response from the API call.</returns>
        public async Task<Models.V1ContainersServersUsableResponse> GetCompatibleServersAsync(
                string containerId,
                List<Models.Meta13Enum> meta = null,
                List<Models.Include9Enum> include = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersServersUsableResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/servers/usable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of Images that are compatible with the specified Container.
        /// Used to quickly find Images that can be used for reimaging the Container.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersCompatibleImagesResponse response from the API call.</returns>
        public Models.V1ContainersCompatibleImagesResponse GetCompatibleImages(
                string containerId,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetCompatibleImagesAsync(containerId, sort, page));

        /// <summary>
        /// Returns a list of Images that are compatible with the specified Container.
        /// Used to quickly find Images that can be used for reimaging the Container.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersCompatibleImagesResponse response from the API call.</returns>
        public async Task<Models.V1ContainersCompatibleImagesResponse> GetCompatibleImagesAsync(
                string containerId,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersCompatibleImagesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/compatible-images")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ContainersBackupsResponse response from the API call.</returns>
        public Models.V1ContainersBackupsResponse GetContainerBackups(
                string containerId,
                List<Models.Include10Enum> include = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetContainerBackupsAsync(containerId, include, sort, page));

        /// <summary>
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested Container..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersBackupsResponse response from the API call.</returns>
        public async Task<Models.V1ContainersBackupsResponse> GetContainerBackupsAsync(
                string containerId,
                List<Models.Include10Enum> include = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersBackupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/backups")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the specified Container Backup.
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID for the container backup..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1ContainersBackupsResponse1 response from the API call.</returns>
        public Models.V1ContainersBackupsResponse1 GetContainerBackup(
                string containerId,
                string backupId,
                List<Models.Include10Enum> include = null)
            => CoreHelper.RunTask(GetContainerBackupAsync(containerId, backupId, include));

        /// <summary>
        /// Gets the specified Container Backup.
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID for the container backup..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersBackupsResponse1 response from the API call.</returns>
        public async Task<Models.V1ContainersBackupsResponse1> GetContainerBackupAsync(
                string containerId,
                string backupId,
                List<Models.Include10Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersBackupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/backups/{backupId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("backupId", backupId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-backups-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container..</param>
        /// <param name="backupId">Required parameter: The ID of the container backup..</param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public Models.TaskResponse DeleteContainerBackup(
                string containerId,
                string backupId)
            => CoreHelper.RunTask(DeleteContainerBackupAsync(containerId, backupId));

        /// <summary>
        /// Requires the `containers-backups-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the container..</param>
        /// <param name="backupId">Required parameter: The ID of the container backup..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public async Task<Models.TaskResponse> DeleteContainerBackupAsync(
                string containerId,
                string backupId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TaskResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/containers/{containerId}/backups/{backupId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("backupId", backupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Container Backup Job.
        /// Can be used to restore a Container Backup for a given Container Instance. .
        /// Requires the `containers-backups-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID of the backup..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1ContainersBackupsTasksResponse response from the API call.</returns>
        public Models.V1ContainersBackupsTasksResponse CreateContainerBackupJob(
                string containerId,
                string backupId,
                Models.V1ContainersBackupsTasksRequest body = null)
            => CoreHelper.RunTask(CreateContainerBackupJobAsync(containerId, backupId, body));

        /// <summary>
        /// Creates a Container Backup Job.
        /// Can be used to restore a Container Backup for a given Container Instance. .
        /// Requires the `containers-backups-manage` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID of the backup..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersBackupsTasksResponse response from the API call.</returns>
        public async Task<Models.V1ContainersBackupsTasksResponse> CreateContainerBackupJobAsync(
                string containerId,
                string backupId,
                Models.V1ContainersBackupsTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersBackupsTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/containers/{containerId}/backups/{backupId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("backupId", backupId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID for the container backup..</param>
        /// <returns>Returns the Models.V1ContainersBackupsLogsResponse response from the API call.</returns>
        public Models.V1ContainersBackupsLogsResponse GetContainerBackupLogs(
                string containerId,
                string backupId)
            => CoreHelper.RunTask(GetContainerBackupLogsAsync(containerId, backupId));

        /// <summary>
        /// Requires the `containers-backups-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the requested container..</param>
        /// <param name="backupId">Required parameter: The ID for the container backup..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersBackupsLogsResponse response from the API call.</returns>
        public async Task<Models.V1ContainersBackupsLogsResponse> GetContainerBackupLogsAsync(
                string containerId,
                string backupId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersBackupsLogsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/backups/{backupId}/logs")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("backupId", backupId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets a list of telemetry points describing the number and state of all Instances of this Container at a point in time.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the desired Container.</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1ContainersTelemetryInstancesResponse response from the API call.</returns>
        public Models.V1ContainersTelemetryInstancesResponse GetContainerInstancesTelemetry(
                string containerId,
                Models.Filter6 filter = null)
            => CoreHelper.RunTask(GetContainerInstancesTelemetryAsync(containerId, filter));

        /// <summary>
        /// Gets a list of telemetry points describing the number and state of all Instances of this Container at a point in time.
        /// Requires the `containers-view` capability.
        /// </summary>
        /// <param name="containerId">Required parameter: The ID of the desired Container.</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersTelemetryInstancesResponse response from the API call.</returns>
        public async Task<Models.V1ContainersTelemetryInstancesResponse> GetContainerInstancesTelemetryAsync(
                string containerId,
                Models.Filter6 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersTelemetryInstancesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/telemetry/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Returns the authorization information necessary to connect to a Container Instance's console.
        /// To connect via WebSocket, use the returned address, and append the returned token as a URL parameter: `<address>?token=<token>`.
        /// Requires the `containers-console` capability.
        /// ]]>
        /// </summary>
        /// <param name="containerId">Required parameter: The ID for the Container.</param>
        /// <param name="instanceId">Required parameter: The ID of the Instance..</param>
        /// <returns>Returns the Models.V1ContainersInstancesConsoleResponse response from the API call.</returns>
        public Models.V1ContainersInstancesConsoleResponse GetInstanceConsoleStreamAuth(
                string containerId,
                string instanceId)
            => CoreHelper.RunTask(GetInstanceConsoleStreamAuthAsync(containerId, instanceId));

        /// <summary>
        /// <![CDATA[
        /// Returns the authorization information necessary to connect to a Container Instance's console.
        /// To connect via WebSocket, use the returned address, and append the returned token as a URL parameter: `<address>?token=<token>`.
        /// Requires the `containers-console` capability.
        /// ]]>
        /// </summary>
        /// <param name="containerId">Required parameter: The ID for the Container.</param>
        /// <param name="instanceId">Required parameter: The ID of the Instance..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ContainersInstancesConsoleResponse response from the API call.</returns>
        public async Task<Models.V1ContainersInstancesConsoleResponse> GetInstanceConsoleStreamAuthAsync(
                string containerId,
                string instanceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ContainersInstancesConsoleResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/containers/{containerId}/instances/{instanceId}/console")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("containerId", containerId))
                      .Template(_template => _template.Setup("instanceId", instanceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}