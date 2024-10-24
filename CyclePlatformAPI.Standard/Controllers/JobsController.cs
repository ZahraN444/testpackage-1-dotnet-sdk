// <copyright file="JobsController.cs" company="APIMatic">
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
    /// JobsController.
    /// </summary>
    public class JobsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobsController"/> class.
        /// </summary>
        internal JobsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1JobsResponse response from the API call.</returns>
        public Models.V1JobsResponse GetJobs(
                List<Models.Include12Enum> include = null,
                Models.Filter27 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetJobsAsync(include, filter, sort, page));

        /// <summary>
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1JobsResponse response from the API call.</returns>
        public async Task<Models.V1JobsResponse> GetJobsAsync(
                List<Models.Include12Enum> include = null,
                Models.Filter27 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1JobsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/jobs")
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
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <param name="jobId">Required parameter: The ID for the given Job..</param>
        /// <returns>Returns the Models.V1JobsResponse1 response from the API call.</returns>
        public Models.V1JobsResponse1 GetJob(
                string jobId)
            => CoreHelper.RunTask(GetJobAsync(jobId));

        /// <summary>
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <param name="jobId">Required parameter: The ID for the given Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1JobsResponse1 response from the API call.</returns>
        public async Task<Models.V1JobsResponse1> GetJobAsync(
                string jobId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1JobsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/jobs/{jobId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("jobId", jobId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <returns>Returns the Models.V1JobsLatestResponse response from the API call.</returns>
        public Models.V1JobsLatestResponse GetLatestJobs()
            => CoreHelper.RunTask(GetLatestJobsAsync());

        /// <summary>
        /// Requires the `apionly-jobs-view` permission.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1JobsLatestResponse response from the API call.</returns>
        public async Task<Models.V1JobsLatestResponse> GetLatestJobsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1JobsLatestResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/jobs/latest")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}