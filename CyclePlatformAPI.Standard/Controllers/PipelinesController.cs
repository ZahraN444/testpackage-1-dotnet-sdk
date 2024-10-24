// <copyright file="PipelinesController.cs" company="APIMatic">
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
    /// PipelinesController.
    /// </summary>
    public class PipelinesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesController"/> class.
        /// </summary>
        internal PipelinesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1PipelinesResponse response from the API call.</returns>
        public Models.V1PipelinesResponse GetPipelines(
                List<Models.Include38Enum> include = null,
                Models.Filter31 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetPipelinesAsync(include, filter, sort, page));

        /// <summary>
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesResponse response from the API call.</returns>
        public async Task<Models.V1PipelinesResponse> GetPipelinesAsync(
                List<Models.Include38Enum> include = null,
                Models.Filter31 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/pipelines")
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
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline..</param>
        /// <returns>Returns the Models.V1PipelinesResponse1 response from the API call.</returns>
        public Models.V1PipelinesResponse1 CreatePipeline(
                Models.V1PipelinesRequest body = null)
            => CoreHelper.RunTask(CreatePipelineAsync(body));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesResponse1 response from the API call.</returns>
        public async Task<Models.V1PipelinesResponse1> CreatePipelineAsync(
                Models.V1PipelinesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/pipelines")
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
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1PipelinesResponse2 response from the API call.</returns>
        public Models.V1PipelinesResponse2 GetPipeline(
                string pipelineId,
                List<Models.Include38Enum> include = null)
            => CoreHelper.RunTask(GetPipelineAsync(pipelineId, include));

        /// <summary>
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesResponse2 response from the API call.</returns>
        public async Task<Models.V1PipelinesResponse2> GetPipelineAsync(
                string pipelineId,
                List<Models.Include38Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/pipelines/{pipelineId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Pipeline..</param>
        /// <returns>Returns the Models.V1PipelinesResponse1 response from the API call.</returns>
        public Models.V1PipelinesResponse1 UpdatePipeline(
                string pipelineId,
                Models.V1PipelinesRequest1 body = null)
            => CoreHelper.RunTask(UpdatePipelineAsync(pipelineId, body));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for updating a Pipeline..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesResponse1 response from the API call.</returns>
        public async Task<Models.V1PipelinesResponse1> UpdatePipelineAsync(
                string pipelineId,
                Models.V1PipelinesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/pipelines/{pipelineId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <returns>Returns the Models.V1PipelinesResponse4 response from the API call.</returns>
        public Models.V1PipelinesResponse4 DeletePipeline(
                string pipelineId)
            => CoreHelper.RunTask(DeletePipelineAsync(pipelineId));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesResponse4 response from the API call.</returns>
        public async Task<Models.V1PipelinesResponse4> DeletePipelineAsync(
                string pipelineId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/pipelines/{pipelineId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List information about times this Pipeline has run.
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the pipeline..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1PipelinesRunsResponse response from the API call.</returns>
        public Models.V1PipelinesRunsResponse GetPipelineRuns(
                string pipelineId,
                List<string> sort = null,
                List<Models.Include12Enum> include = null)
            => CoreHelper.RunTask(GetPipelineRunsAsync(pipelineId, sort, include));

        /// <summary>
        /// List information about times this Pipeline has run.
        /// Requires the `pipelines-view` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the pipeline..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesRunsResponse response from the API call.</returns>
        public async Task<Models.V1PipelinesRunsResponse> GetPipelineRunsAsync(
                string pipelineId,
                List<string> sort = null,
                List<Models.Include12Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesRunsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/pipelines/{pipelineId}/runs")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline job..</param>
        /// <returns>Returns the Models.V1PipelinesTasksResponse response from the API call.</returns>
        public Models.V1PipelinesTasksResponse CreatePipelineJob(
                string pipelineId,
                Models.V1PipelinesTasksRequest body = null)
            => CoreHelper.RunTask(CreatePipelineJobAsync(pipelineId, body));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesTasksResponse response from the API call.</returns>
        public async Task<Models.V1PipelinesTasksResponse> CreatePipelineJobAsync(
                string pipelineId,
                Models.V1PipelinesTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/pipelines/{pipelineId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse response from the API call.</returns>
        public Models.V1PipelinesKeysResponse GetPipelineTriggerKeys(
                string pipelineId,
                Models.Filter32 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetPipelineTriggerKeysAsync(pipelineId, filter, sort, page));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse response from the API call.</returns>
        public async Task<Models.V1PipelinesKeysResponse> GetPipelineTriggerKeysAsync(
                string pipelineId,
                Models.Filter32 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/pipelines/{pipelineId}/keys")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline Trigger Key..</param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse1 response from the API call.</returns>
        public Models.V1PipelinesKeysResponse1 CreatePipelineTriggerKey(
                string pipelineId,
                Models.V1PipelinesKeysRequest body = null)
            => CoreHelper.RunTask(CreatePipelineTriggerKeyAsync(pipelineId, body));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Pipeline Trigger Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse1 response from the API call.</returns>
        public async Task<Models.V1PipelinesKeysResponse1> CreatePipelineTriggerKeyAsync(
                string pipelineId,
                Models.V1PipelinesKeysRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesKeysResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/pipelines/{pipelineId}/keys")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse2 response from the API call.</returns>
        public Models.V1PipelinesKeysResponse2 GetPipelineTriggerKey(
                string pipelineId,
                string triggerKeyId)
            => CoreHelper.RunTask(GetPipelineTriggerKeyAsync(pipelineId, triggerKeyId));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse2 response from the API call.</returns>
        public async Task<Models.V1PipelinesKeysResponse2> GetPipelineTriggerKeyAsync(
                string pipelineId,
                string triggerKeyId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesKeysResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/pipelines/{pipelineId}/keys/{triggerKeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Template(_template => _template.Setup("triggerKeyId", triggerKeyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse3 response from the API call.</returns>
        public Models.V1PipelinesKeysResponse3 UpdatePipelineTriggerKey(
                string pipelineId,
                string triggerKeyId,
                Models.V1PipelinesKeysRequest1 body = null)
            => CoreHelper.RunTask(UpdatePipelineTriggerKeyAsync(pipelineId, triggerKeyId, body));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse3 response from the API call.</returns>
        public async Task<Models.V1PipelinesKeysResponse3> UpdatePipelineTriggerKeyAsync(
                string pipelineId,
                string triggerKeyId,
                Models.V1PipelinesKeysRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesKeysResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/pipelines/{pipelineId}/keys/{triggerKeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Template(_template => _template.Setup("triggerKeyId", triggerKeyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse3 response from the API call.</returns>
        public Models.V1PipelinesKeysResponse3 DeletePipelineTriggerKey(
                string pipelineId,
                string triggerKeyId)
            => CoreHelper.RunTask(DeletePipelineTriggerKeyAsync(pipelineId, triggerKeyId));

        /// <summary>
        /// Requires the `pipelines-manage` capability.
        /// </summary>
        /// <param name="pipelineId">Required parameter: The ID of the Pipeline..</param>
        /// <param name="triggerKeyId">Required parameter: The ID of the Trigger Key..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1PipelinesKeysResponse3 response from the API call.</returns>
        public async Task<Models.V1PipelinesKeysResponse3> DeletePipelineTriggerKeyAsync(
                string pipelineId,
                string triggerKeyId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1PipelinesKeysResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/pipelines/{pipelineId}/keys/{triggerKeyId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("pipelineId", pipelineId))
                      .Template(_template => _template.Setup("triggerKeyId", triggerKeyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}