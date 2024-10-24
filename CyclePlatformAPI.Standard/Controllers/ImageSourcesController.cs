// <copyright file="ImageSourcesController.cs" company="APIMatic">
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
    /// ImageSourcesController.
    /// </summary>
    public class ImageSourcesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSourcesController"/> class.
        /// </summary>
        internal ImageSourcesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `images-sources-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse response from the API call.</returns>
        public Models.V1ImagesSourcesResponse GetImageSources(
                List<Models.Meta26Enum> meta = null,
                List<Models.Include23Enum> include = null,
                Models.Filter19 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetImageSourcesAsync(meta, include, filter, sort, page));

        /// <summary>
        /// Requires the `images-sources-view` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse response from the API call.</returns>
        public async Task<Models.V1ImagesSourcesResponse> GetImageSourcesAsync(
                List<Models.Meta26Enum> meta = null,
                List<Models.Include23Enum> include = null,
                Models.Filter19 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesSourcesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/images/sources")
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
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an Image Source..</param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse1 response from the API call.</returns>
        public Models.V1ImagesSourcesResponse1 CreateImageSource(
                Models.V1ImagesSourcesRequest body = null)
            => CoreHelper.RunTask(CreateImageSourceAsync(body));

        /// <summary>
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating an Image Source..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse1 response from the API call.</returns>
        public async Task<Models.V1ImagesSourcesResponse1> CreateImageSourceAsync(
                Models.V1ImagesSourcesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesSourcesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/images/sources")
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
        /// Requires the `images-sources-view` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse2 response from the API call.</returns>
        public Models.V1ImagesSourcesResponse2 GetImageSource(
                string sourceId,
                List<Models.Meta26Enum> meta = null,
                List<Models.Include23Enum> include = null)
            => CoreHelper.RunTask(GetImageSourceAsync(sourceId, meta, include));

        /// <summary>
        /// Requires the `images-sources-view` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse2 response from the API call.</returns>
        public async Task<Models.V1ImagesSourcesResponse2> GetImageSourceAsync(
                string sourceId,
                List<Models.Meta26Enum> meta = null,
                List<Models.Include23Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesSourcesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/images/sources/{sourceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("sourceId", sourceId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <param name="body">Optional parameter: Parameters for updating an image source..</param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse1 response from the API call.</returns>
        public Models.V1ImagesSourcesResponse1 UpdateImageSource(
                string sourceId,
                Models.V1ImagesSourcesRequest1 body = null)
            => CoreHelper.RunTask(UpdateImageSourceAsync(sourceId, body));

        /// <summary>
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <param name="body">Optional parameter: Parameters for updating an image source..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse1 response from the API call.</returns>
        public async Task<Models.V1ImagesSourcesResponse1> UpdateImageSourceAsync(
                string sourceId,
                Models.V1ImagesSourcesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesSourcesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/images/sources/{sourceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("sourceId", sourceId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse4 response from the API call.</returns>
        public Models.V1ImagesSourcesResponse4 DeleteImageSource(
                string sourceId)
            => CoreHelper.RunTask(DeleteImageSourceAsync(sourceId));

        /// <summary>
        /// Requires the `images-sources-manage` capability.
        /// </summary>
        /// <param name="sourceId">Required parameter: The ID of the Image Source..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1ImagesSourcesResponse4 response from the API call.</returns>
        public async Task<Models.V1ImagesSourcesResponse4> DeleteImageSourceAsync(
                string sourceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1ImagesSourcesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/images/sources/{sourceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("sourceId", sourceId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}