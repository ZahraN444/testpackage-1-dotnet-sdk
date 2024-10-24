// <copyright file="EnvironmentsController.cs" company="APIMatic">
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
    /// EnvironmentsController.
    /// </summary>
    public class EnvironmentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsController"/> class.
        /// </summary>
        internal EnvironmentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1EnvironmentsResponse response from the API call.</returns>
        public Models.V1EnvironmentsResponse GetEnvironments(
                List<Models.Meta8Enum> meta = null,
                List<Models.Include2Enum> include = null,
                Models.Filter3 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetEnvironmentsAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsResponse> GetEnvironmentsAsync(
                List<Models.Meta8Enum> meta = null,
                List<Models.Include2Enum> include = null,
                Models.Filter3 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments")
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
        /// Requires the `environments-create` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1EnvironmentsResponse1 response from the API call.</returns>
        public Models.V1EnvironmentsResponse1 CreateEnvironment(
                Models.V1EnvironmentsRequest body = null)
            => CoreHelper.RunTask(CreateEnvironmentAsync(body));

        /// <summary>
        /// Requires the `environments-create` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsResponse1 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsResponse1> CreateEnvironmentAsync(
                Models.V1EnvironmentsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments")
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
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested environment..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1EnvironmentsResponse2 response from the API call.</returns>
        public Models.V1EnvironmentsResponse2 GetEnvironment(
                string environmentId,
                List<Models.Meta8Enum> meta = null,
                List<Models.Include2Enum> include = null)
            => CoreHelper.RunTask(GetEnvironmentAsync(environmentId, meta, include));

        /// <summary>
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested environment..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsResponse2 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsResponse2> GetEnvironmentAsync(
                string environmentId,
                List<Models.Meta8Enum> meta = null,
                List<Models.Include2Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the specificed Environment.
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for updating an Environment..</param>
        /// <returns>Returns the Models.V1EnvironmentsResponse1 response from the API call.</returns>
        public Models.V1EnvironmentsResponse1 UpdateEnvironment(
                string environmentId,
                Models.V1EnvironmentsRequest1 body = null)
            => CoreHelper.RunTask(UpdateEnvironmentAsync(environmentId, body));

        /// <summary>
        /// Updates the specificed Environment.
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for updating an Environment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsResponse1 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsResponse1> UpdateEnvironmentAsync(
                string environmentId,
                Models.V1EnvironmentsRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/environments/{environmentId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <returns>Returns the Models.V1EnvironmentsResponse4 response from the API call.</returns>
        public Models.V1EnvironmentsResponse4 DeleteEnvironment(
                string environmentId)
            => CoreHelper.RunTask(DeleteEnvironmentAsync(environmentId));

        /// <summary>
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsResponse4 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsResponse4> DeleteEnvironmentAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/environments/{environmentId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a job for an Environment, such as 'start' or 'stop'. .
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Environment job..</param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public Models.TaskResponse CreateEnvironmentJob(
                string environmentId,
                CreateEnvironmentJobBody body = null)
            => CoreHelper.RunTask(CreateEnvironmentJobAsync(environmentId, body));

        /// <summary>
        /// Create a job for an Environment, such as 'start' or 'stop'. .
        /// Requires the `environments-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Environment job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public async Task<Models.TaskResponse> CreateEnvironmentJobAsync(
                string environmentId,
                CreateEnvironmentJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TaskResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the summary of an Environment. Contains useful and relevant data/statistics that would otherwise be several separate API calls.  .
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested environment..</param>
        /// <returns>Returns the Models.V1EnvironmentsSummaryResponse response from the API call.</returns>
        public Models.V1EnvironmentsSummaryResponse GetEnvironmentSummary(
                string environmentId)
            => CoreHelper.RunTask(GetEnvironmentSummaryAsync(environmentId));

        /// <summary>
        /// Gets the summary of an Environment. Contains useful and relevant data/statistics that would otherwise be several separate API calls.  .
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested environment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsSummaryResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsSummaryResponse> GetEnvironmentSummaryAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/summary")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets a list of all deployments in the specified Environment.
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the Environment to get the list of deployments for..</param>
        /// <returns>Returns the Models.V1EnvironmentsDeploymentsResponse response from the API call.</returns>
        public Models.V1EnvironmentsDeploymentsResponse GetEnvironmentDeployments(
                string environmentId)
            => CoreHelper.RunTask(GetEnvironmentDeploymentsAsync(environmentId));

        /// <summary>
        /// Gets a list of all deployments in the specified Environment.
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the Environment to get the list of deployments for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsDeploymentsResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsDeploymentsResponse> GetEnvironmentDeploymentsAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsDeploymentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/deployments")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesLbResponse GetLoadBalancerService(
                string environmentId)
            => CoreHelper.RunTask(GetLoadBalancerServiceAsync(environmentId));

        /// <summary>
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesLbResponse> GetLoadBalancerServiceAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesLbResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/lb")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a task that will update the load balancer's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this load balancer resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a load balancer..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTasksResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesLbTasksResponse CreateLoadBalancerServiceJob(
                string environmentId,
                Models.V1EnvironmentsServicesLbTasksRequest body = null)
            => CoreHelper.RunTask(CreateLoadBalancerServiceJobAsync(environmentId, body));

        /// <summary>
        /// Creates a task that will update the load balancer's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this load balancer resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a load balancer..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTasksResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesLbTasksResponse> CreateLoadBalancerServiceJobAsync(
                string environmentId,
                Models.V1EnvironmentsServicesLbTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesLbTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/services/lb/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetches a telemetry report for Cycle's native load balancer for the specified range.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryReportResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesLbTelemetryReportResponse GetLoadBalancerTelemetryReport(
                string environmentId,
                Models.Filter4 filter = null)
            => CoreHelper.RunTask(GetLoadBalancerTelemetryReportAsync(environmentId, filter));

        /// <summary>
        /// Fetches a telemetry report for Cycle's native load balancer for the specified range.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryReportResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesLbTelemetryReportResponse> GetLoadBalancerTelemetryReportAsync(
                string environmentId,
                Models.Filter4 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesLbTelemetryReportResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/lb/telemetry/report")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Fetches the latest telemetry report for Cycle's native load balancer. Provides detailed information on a per-instance basis.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <param name="filter">Required parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. ### Required Filter On this endpoint, you MUST pass filter[controller]..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryLatestResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesLbTelemetryLatestResponse GetLoadBalancerLatestTelemetryReport(
                string environmentId,
                Models.Filter5 filter)
            => CoreHelper.RunTask(GetLoadBalancerLatestTelemetryReportAsync(environmentId, filter));

        /// <summary>
        /// Fetches the latest telemetry report for Cycle's native load balancer. Provides detailed information on a per-instance basis.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the load balancer resides..</param>
        /// <param name="filter">Required parameter: ## Filter Field The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. ### Required Filter On this endpoint, you MUST pass filter[controller]..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryLatestResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesLbTelemetryLatestResponse> GetLoadBalancerLatestTelemetryReportAsync(
                string environmentId,
                Models.Filter5 filter,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesLbTelemetryLatestResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/lb/telemetry/latest")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the controller information for the specified load balancer. Returns a similar struct to the 'latest' load balancer telemetry call, but does NOT return snapshots, just the controller information.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment of the desired load balancer..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse GetLoadBalancerTelemetryLatestControllers(
                string environmentId,
                List<Models.Include4Enum> include = null)
            => CoreHelper.RunTask(GetLoadBalancerTelemetryLatestControllersAsync(environmentId, include));

        /// <summary>
        /// Gets the controller information for the specified load balancer. Returns a similar struct to the 'latest' load balancer telemetry call, but does NOT return snapshots, just the controller information.
        /// ## Permissions.
        /// Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment of the desired load balancer..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse> GetLoadBalancerTelemetryLatestControllersAsync(
                string environmentId,
                List<Models.Include4Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/lb/telemetry/latest-controllers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a task that will update the discovery service's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this discovery service resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a discovery service..</param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public Models.TaskResponse CreateDiscoveryServiceJob(
                string environmentId,
                Models.V1EnvironmentsServicesDiscoveryTasksRequest body = null)
            => CoreHelper.RunTask(CreateDiscoveryServiceJobAsync(environmentId, body));

        /// <summary>
        /// Creates a task that will update the discovery service's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this discovery service resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a discovery service..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public async Task<Models.TaskResponse> CreateDiscoveryServiceJobAsync(
                string environmentId,
                Models.V1EnvironmentsServicesDiscoveryTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TaskResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/services/discovery/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a task that will update the scheduler service's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this scheduler service resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a scheduler service..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesSchedulerTasksResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesSchedulerTasksResponse CreateSchedulerServiceJob(
                string environmentId,
                Models.V1EnvironmentsServicesSchedulerTasksRequest body = null)
            => CoreHelper.RunTask(CreateSchedulerServiceJobAsync(environmentId, body));

        /// <summary>
        /// Creates a task that will update the scheduler service's configuration.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the environment where this scheduler service resides..</param>
        /// <param name="body">Optional parameter: Parameters for reconfiguring a scheduler service..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesSchedulerTasksResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesSchedulerTasksResponse> CreateSchedulerServiceJobAsync(
                string environmentId,
                Models.V1EnvironmentsServicesSchedulerTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesSchedulerTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/services/scheduler/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-vpn` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN resides..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesVpnResponse GetVPNService(
                string environmentId)
            => CoreHelper.RunTask(GetVPNServiceAsync(environmentId));

        /// <summary>
        /// Requires the `environments-vpn` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN resides..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesVpnResponse> GetVPNServiceAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesVpnResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/vpn")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-vpn` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN resides..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.VPNInfoEnvironmentService response from the API call.</returns>
        public Models.VPNInfoEnvironmentService GetVPNLogins(
                string environmentId,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetVPNLoginsAsync(environmentId, sort, page));

        /// <summary>
        /// Requires the `environments-vpn` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN resides..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VPNInfoEnvironmentService response from the API call.</returns>
        public async Task<Models.VPNInfoEnvironmentService> GetVPNLoginsAsync(
                string environmentId,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VPNInfoEnvironmentService>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/vpn/logins")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service resides..</param>
        /// <returns>Returns the Models.GetVPNUsersReturn response from the API call.</returns>
        public Models.GetVPNUsersReturn GetVPNUsers(
                string environmentId)
            => CoreHelper.RunTask(GetVPNUsersAsync(environmentId));

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service resides..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetVPNUsersReturn response from the API call.</returns>
        public async Task<Models.GetVPNUsersReturn> GetVPNUsersAsync(
                string environmentId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetVPNUsersReturn>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/services/vpn/users")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service resides..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new VPN user..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnUsersResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesVpnUsersResponse CreateVPNUser(
                string environmentId,
                Models.V1EnvironmentsServicesVpnUsersRequest body = null)
            => CoreHelper.RunTask(CreateVPNUserAsync(environmentId, body));

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service resides..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new VPN user..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnUsersResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesVpnUsersResponse> CreateVPNUserAsync(
                string environmentId,
                Models.V1EnvironmentsServicesVpnUsersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesVpnUsersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/services/vpn/users")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service the given user belongs to resides..</param>
        /// <param name="userId">Required parameter: The userId of the user to be deleted..</param>
        /// <returns>Returns the Models.VPNUserDeleteReturn response from the API call.</returns>
        public Models.VPNUserDeleteReturn DeleteVPNUser(
                string environmentId,
                string userId)
            => CoreHelper.RunTask(DeleteVPNUserAsync(environmentId, userId));

        /// <summary>
        /// Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The environmentId where the VPN service the given user belongs to resides..</param>
        /// <param name="userId">Required parameter: The userId of the user to be deleted..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VPNUserDeleteReturn response from the API call.</returns>
        public async Task<Models.VPNUserDeleteReturn> DeleteVPNUserAsync(
                string environmentId,
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VPNUserDeleteReturn>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/environments/{environmentId}/services/vpn/users/{userId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to reconfigure or reset the Environment VPN. Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the Environment the VPN service resides in..</param>
        /// <param name="body">Optional parameter: The task contents used to build the Environment VPN Job..</param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnTasksResponse response from the API call.</returns>
        public Models.V1EnvironmentsServicesVpnTasksResponse CreateVPNServiceJob(
                string environmentId,
                CreateVPNServiceJobBody body = null)
            => CoreHelper.RunTask(CreateVPNServiceJobAsync(environmentId, body));

        /// <summary>
        /// Used to reconfigure or reset the Environment VPN. Requires the `environments-vpn-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the Environment the VPN service resides in..</param>
        /// <param name="body">Optional parameter: The task contents used to build the Environment VPN Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsServicesVpnTasksResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsServicesVpnTasksResponse> CreateVPNServiceJobAsync(
                string environmentId,
                CreateVPNServiceJobBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsServicesVpnTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/services/vpn/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get telemetry points on the number of instances and their states over a range of time.
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the desired Environment.</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1EnvironmentsTelemetryInstancesResponse response from the API call.</returns>
        public Models.V1EnvironmentsTelemetryInstancesResponse GetEnvironmentInstancesTelemetry(
                string environmentId,
                Models.Filter6 filter = null)
            => CoreHelper.RunTask(GetEnvironmentInstancesTelemetryAsync(environmentId, filter));

        /// <summary>
        /// Get telemetry points on the number of instances and their states over a range of time.
        /// Requires the `environments-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the desired Environment.</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsTelemetryInstancesResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsTelemetryInstancesResponse> GetEnvironmentInstancesTelemetryAsync(
                string environmentId,
                Models.Filter6 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsTelemetryInstancesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/telemetry/instances")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `scoped-variables-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse response from the API call.</returns>
        public Models.V1EnvironmentsScopedVariablesResponse GetScopedVariables(
                string environmentId,
                Models.Filter7 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetScopedVariablesAsync(environmentId, filter, sort, page));

        /// <summary>
        /// Requires the `scoped-variables-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse response from the API call.</returns>
        public async Task<Models.V1EnvironmentsScopedVariablesResponse> GetScopedVariablesAsync(
                string environmentId,
                Models.Filter7 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsScopedVariablesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/scoped-variables")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for creating a Scoped Variable..</param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public Models.V1EnvironmentsScopedVariablesResponse1 CreateScopedVariable(
                string environmentId,
                Models.V1EnvironmentsScopedVariablesRequest body = null)
            => CoreHelper.RunTask(CreateScopedVariableAsync(environmentId, body));

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="body">Optional parameter: Parameters for creating a Scoped Variable..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsScopedVariablesResponse1> CreateScopedVariableAsync(
                string environmentId,
                Models.V1EnvironmentsScopedVariablesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsScopedVariablesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/environments/{environmentId}/scoped-variables")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `scoped-variables-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public Models.V1EnvironmentsScopedVariablesResponse1 GetScopedVariable(
                string environmentId,
                string scopedVariableId)
            => CoreHelper.RunTask(GetScopedVariableAsync(environmentId, scopedVariableId));

        /// <summary>
        /// Requires the `scoped-variables-view` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsScopedVariablesResponse1> GetScopedVariableAsync(
                string environmentId,
                string scopedVariableId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsScopedVariablesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/environments/{environmentId}/scoped-variables/{scopedVariableId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Template(_template => _template.Setup("scopedVariableId", scopedVariableId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested endpointnvironment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Scoped Variable..</param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public Models.V1EnvironmentsScopedVariablesResponse1 UpdateScopedVariable(
                string environmentId,
                string scopedVariableId,
                Models.V1EnvironmentsScopedVariablesRequest1 body = null)
            => CoreHelper.RunTask(UpdateScopedVariableAsync(environmentId, scopedVariableId, body));

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested endpointnvironment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Scoped Variable..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse1 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsScopedVariablesResponse1> UpdateScopedVariableAsync(
                string environmentId,
                string scopedVariableId,
                Models.V1EnvironmentsScopedVariablesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsScopedVariablesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/environments/{environmentId}/scoped-variables/{scopedVariableId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Template(_template => _template.Setup("scopedVariableId", scopedVariableId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse4 response from the API call.</returns>
        public Models.V1EnvironmentsScopedVariablesResponse4 DeleteScopedVariable(
                string environmentId,
                string scopedVariableId)
            => CoreHelper.RunTask(DeleteScopedVariableAsync(environmentId, scopedVariableId));

        /// <summary>
        /// Requires the `scoped-variables-manage` capability.
        /// </summary>
        /// <param name="environmentId">Required parameter: The ID of the requested Environment..</param>
        /// <param name="scopedVariableId">Required parameter: The ID of the requested Scoped Variable..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1EnvironmentsScopedVariablesResponse4 response from the API call.</returns>
        public async Task<Models.V1EnvironmentsScopedVariablesResponse4> DeleteScopedVariableAsync(
                string environmentId,
                string scopedVariableId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1EnvironmentsScopedVariablesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/environments/{environmentId}/scoped-variables/{scopedVariableId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("environmentId", environmentId))
                      .Template(_template => _template.Setup("scopedVariableId", scopedVariableId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}