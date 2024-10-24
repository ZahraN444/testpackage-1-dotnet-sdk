// <copyright file="AnnouncementsController.cs" company="APIMatic">
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
    /// AnnouncementsController.
    /// </summary>
    public class AnnouncementsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnouncementsController"/> class.
        /// </summary>
        internal AnnouncementsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists any important updates posted by the Cycle team.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.AnnouncementsListResponse response from the API call.</returns>
        public Models.AnnouncementsListResponse GetAnnouncements(
                List<string> sort = null,
                Models.Page page = null,
                Models.Filter filter = null)
            => CoreHelper.RunTask(GetAnnouncementsAsync(sort, page, filter));

        /// <summary>
        /// Lists any important updates posted by the Cycle team.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AnnouncementsListResponse response from the API call.</returns>
        public async Task<Models.AnnouncementsListResponse> GetAnnouncementsAsync(
                List<string> sort = null,
                Models.Page page = null,
                Models.Filter filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AnnouncementsListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/announcements")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}