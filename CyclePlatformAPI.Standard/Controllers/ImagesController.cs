// <copyright file="ImagesController.cs" company="APIMatic">
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
    /// ImagesController.
    /// </summary>
    public class ImagesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesController"/> class.
        /// </summary>
        internal ImagesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ImagesResponse response from the API call.</returns>
        public Models.V1ImagesResponse GetImages(
                List<Models.Meta24Enum> meta = null,
                List<Models.Include21Enum> include = null,
                Models.Filter18 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetImagesAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesResponse response from the API call.</returns>
        public async Task<Models.V1ImagesResponse> GetImagesAsync(
                List<Models.Meta24Enum> meta = null,
                List<Models.Include21Enum> include = null,
                Models.Filter18 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/images")
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
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Image..</param>
        /// <returns>Returns the Models.V1ImagesResponse1 response from the API call.</returns>
        public Models.V1ImagesResponse1 CreateImage(
                Models.V1ImagesRequest body = null)
            => CoreHelper.RunTask(CreateImageAsync(body));

        /// <summary>
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Image..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesResponse1 response from the API call.</returns>
        public async Task<Models.V1ImagesResponse1> CreateImageAsync(
                Models.V1ImagesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/images")
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
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ImagesResponse2 response from the API call.</returns>
        public Models.V1ImagesResponse2 GetImage(
                string imageId,
                List<Models.Meta24Enum> meta = null,
                List<Models.Include21Enum> include = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetImageAsync(imageId, meta, include, sort, page));

        /// <summary>
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesResponse2 response from the API call.</returns>
        public async Task<Models.V1ImagesResponse2> GetImageAsync(
                string imageId,
                List<Models.Meta24Enum> meta = null,
                List<Models.Include21Enum> include = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/images/{imageId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("imageId", imageId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new image..</param>
        /// <returns>Returns the Models.V1ImagesResponse1 response from the API call.</returns>
        public Models.V1ImagesResponse1 UpdateImage(
                string imageId,
                Models.V1ImagesRequest1 body = null)
            => CoreHelper.RunTask(UpdateImageAsync(imageId, body));

        /// <summary>
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new image..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesResponse1 response from the API call.</returns>
        public async Task<Models.V1ImagesResponse1> UpdateImageAsync(
                string imageId,
                Models.V1ImagesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/images/{imageId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("imageId", imageId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <returns>Returns the Models.V1ImagesResponse4 response from the API call.</returns>
        public Models.V1ImagesResponse4 DeleteImage(
                string imageId)
            => CoreHelper.RunTask(DeleteImageAsync(imageId));

        /// <summary>
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the image..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesResponse4 response from the API call.</returns>
        public async Task<Models.V1ImagesResponse4> DeleteImageAsync(
                string imageId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/images/{imageId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("imageId", imageId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the Image..</param>
        /// <returns>Returns the Models.V1ImagesBuildLogResponse response from the API call.</returns>
        public Models.V1ImagesBuildLogResponse GetImageBuildLog(
                string imageId)
            => CoreHelper.RunTask(GetImageBuildLogAsync(imageId));

        /// <summary>
        /// Requires the `images-view` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the Image..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesBuildLogResponse response from the API call.</returns>
        public async Task<Models.V1ImagesBuildLogResponse> GetImageBuildLogAsync(
                string imageId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesBuildLogResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/images/{imageId}/build-log")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("imageId", imageId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given image. .
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Images Job..</param>
        /// <returns>Returns the Models.V1ImagesTasksResponse response from the API call.</returns>
        public Models.V1ImagesTasksResponse CreateImagesJob(
                Models.V1ImagesTasksRequest body = null)
            => CoreHelper.RunTask(CreateImagesJobAsync(body));

        /// <summary>
        /// Used to perform different actions on a given image. .
        /// Requires the `images-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new Images Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesTasksResponse response from the API call.</returns>
        public async Task<Models.V1ImagesTasksResponse> CreateImagesJobAsync(
                Models.V1ImagesTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/images/tasks")
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
        /// Used to perform different actions on a given Image. .
        /// Requires the `images-import` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the requested Image..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Image job..</param>
        /// <returns>Returns the Models.V1ImagesTasksResponse response from the API call.</returns>
        public Models.V1ImagesTasksResponse CreateImageJob(
                string imageId,
                Models.V1ImagesTasksRequest1 body = null)
            => CoreHelper.RunTask(CreateImageJobAsync(imageId, body));

        /// <summary>
        /// Used to perform different actions on a given Image. .
        /// Requires the `images-import` capability.
        /// </summary>
        /// <param name="imageId">Required parameter: The ID of the requested Image..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new Image job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesTasksResponse response from the API call.</returns>
        public async Task<Models.V1ImagesTasksResponse> CreateImageJobAsync(
                string imageId,
                Models.V1ImagesTasksRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/images/{imageId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("imageId", imageId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}