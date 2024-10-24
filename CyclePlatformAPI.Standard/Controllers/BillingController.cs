// <copyright file="BillingController.cs" company="APIMatic">
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
    /// BillingController.
    /// </summary>
    public class BillingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingController"/> class.
        /// </summary>
        internal BillingController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingOrdersResponse response from the API call.</returns>
        public Models.V1BillingOrdersResponse GetOrders(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null)
            => CoreHelper.RunTask(GetOrdersAsync(sort, filter, page, meta, include));

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingOrdersResponse response from the API call.</returns>
        public async Task<Models.V1BillingOrdersResponse> GetOrdersAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingOrdersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/orders")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `billing-orders-manage` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Parameters for creating a new order.</param>
        /// <returns>Returns the Models.V1BillingOrdersResponse1 response from the API call.</returns>
        public Models.V1BillingOrdersResponse1 CreateOrder(
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                Models.V1BillingOrdersRequest body = null)
            => CoreHelper.RunTask(CreateOrderAsync(meta, include, body));

        /// <summary>
        /// Requires the `billing-orders-manage` capability.
        /// </summary>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Parameters for creating a new order.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingOrdersResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingOrdersResponse1> CreateOrderAsync(
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                Models.V1BillingOrdersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingOrdersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/billing/orders")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the billing order..</param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingOrdersResponse2 response from the API call.</returns>
        public Models.V1BillingOrdersResponse2 GetBillingOrder(
                string orderId,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null)
            => CoreHelper.RunTask(GetBillingOrderAsync(orderId, meta, include));

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the billing order..</param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingOrdersResponse2 response from the API call.</returns>
        public async Task<Models.V1BillingOrdersResponse2> GetBillingOrderAsync(
                string orderId,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingOrdersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/orders/{orderId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the billing order..</param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingOrdersResponse2 response from the API call.</returns>
        public Models.V1BillingOrdersResponse2 UpdateBillingOrder(
                string orderId,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                Models.V1BillingOrdersRequest body = null)
            => CoreHelper.RunTask(UpdateBillingOrderAsync(orderId, meta, include, body));

        /// <summary>
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the billing order..</param>
        /// <param name="meta">Optional parameter: Example: .</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingOrdersResponse2 response from the API call.</returns>
        public async Task<Models.V1BillingOrdersResponse2> UpdateBillingOrderAsync(
                string orderId,
                List<Models.Meta2Enum> meta = null,
                List<Models.Include1Enum> include = null,
                Models.V1BillingOrdersRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingOrdersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/billing/orders/{orderId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to confirm a Billing Order.
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the requested Order.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingOrdersTasksResponse response from the API call.</returns>
        public Models.V1BillingOrdersTasksResponse CreateOrderJob(
                string orderId,
                Models.V1BillingOrdersTasksRequest body = null)
            => CoreHelper.RunTask(CreateOrderJobAsync(orderId, body));

        /// <summary>
        /// Used to confirm a Billing Order.
        /// Requires the `billing-services-manage` capability.
        /// </summary>
        /// <param name="orderId">Required parameter: The ID of the requested Order.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingOrdersTasksResponse response from the API call.</returns>
        public async Task<Models.V1BillingOrdersTasksResponse> CreateOrderJobAsync(
                string orderId,
                Models.V1BillingOrdersTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingOrdersTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/billing/orders/{orderId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("orderId", orderId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getBillingSupportPlans EndPoint.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1BillingPlansSupportResponse response from the API call.</returns>
        [Obsolete]
        public Models.V1BillingPlansSupportResponse GetBillingSupportPlans(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetBillingSupportPlansAsync(sort, filter, page));

        /// <summary>
        /// getBillingSupportPlans EndPoint.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingPlansSupportResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.V1BillingPlansSupportResponse> GetBillingSupportPlansAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingPlansSupportResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/plans/support")
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
        /// Returns list of availiable Billing Tiers.
        /// </summary>
        /// <returns>Returns the Models.V1BillingPlansTiersResponse response from the API call.</returns>
        public Models.V1BillingPlansTiersResponse GetBillingTiers()
            => CoreHelper.RunTask(GetBillingTiersAsync());

        /// <summary>
        /// Returns list of availiable Billing Tiers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingPlansTiersResponse response from the API call.</returns>
        public async Task<Models.V1BillingPlansTiersResponse> GetBillingTiersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingPlansTiersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/plans/tiers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the Billing Methods associated with the Hub defined in X-Hub-ID.
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1BillingMethodsResponse response from the API call.</returns>
        public Models.V1BillingMethodsResponse GetBillingMethods(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetBillingMethodsAsync(sort, filter, page));

        /// <summary>
        /// Lists the Billing Methods associated with the Hub defined in X-Hub-ID.
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingMethodsResponse response from the API call.</returns>
        public async Task<Models.V1BillingMethodsResponse> GetBillingMethodsAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingMethodsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/methods")
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
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new billing method..</param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public Models.V1BillingMethodsResponse1 CreateBillingMethod(
                Models.V1BillingMethodsRequest body = null)
            => CoreHelper.RunTask(CreateBillingMethodAsync(body));

        /// <summary>
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new billing method..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingMethodsResponse1> CreateBillingMethodAsync(
                Models.V1BillingMethodsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingMethodsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/billing/methods")
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
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public Models.V1BillingMethodsResponse1 GetBillingMethod(
                string methodId)
            => CoreHelper.RunTask(GetBillingMethodAsync(methodId));

        /// <summary>
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingMethodsResponse1> GetBillingMethodAsync(
                string methodId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingMethodsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/methods/{methodId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("methodId", methodId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public Models.V1BillingMethodsResponse1 UpdateBillingMethod(
                string methodId,
                Models.V1BillingMethodsRequest1 body = null)
            => CoreHelper.RunTask(UpdateBillingMethodAsync(methodId, body));

        /// <summary>
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingMethodsResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingMethodsResponse1> UpdateBillingMethodAsync(
                string methodId,
                Models.V1BillingMethodsRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingMethodsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/billing/methods/{methodId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("methodId", methodId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes the Billing Method. However, the primary payment method may not be deleted.
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public Models.TaskResponse DeleteBillingMethod(
                string methodId)
            => CoreHelper.RunTask(DeleteBillingMethodAsync(methodId));

        /// <summary>
        /// Deletes the Billing Method. However, the primary payment method may not be deleted.
        /// Requires the `billing-methods-manage` capability.
        /// </summary>
        /// <param name="methodId">Required parameter: The ID of the billing method..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TaskResponse response from the API call.</returns>
        public async Task<Models.TaskResponse> DeleteBillingMethodAsync(
                string methodId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TaskResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/billing/methods/{methodId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("methodId", methodId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List the Invoices assoicated with the Hub.  .
        /// Requires the `billing-invoices-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <returns>Returns the Models.V1BillingInvoicesResponse response from the API call.</returns>
        public Models.V1BillingInvoicesResponse GetInvoices(
                List<string> sort = null,
                Models.Page page = null,
                List<Models.Meta2Enum> meta = null,
                Models.Filter1 filter = null)
            => CoreHelper.RunTask(GetInvoicesAsync(sort, page, meta, filter));

        /// <summary>
        /// List the Invoices assoicated with the Hub.  .
        /// Requires the `billing-invoices-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingInvoicesResponse response from the API call.</returns>
        public async Task<Models.V1BillingInvoicesResponse> GetInvoicesAsync(
                List<string> sort = null,
                Models.Page page = null,
                List<Models.Meta2Enum> meta = null,
                Models.Filter1 filter = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingInvoicesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/invoices")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `billing-invoices-view` capability.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The ID of the invoice..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <returns>Returns the Models.V1BillingInvoicesResponse1 response from the API call.</returns>
        public Models.V1BillingInvoicesResponse1 GetInvoice(
                string invoiceId,
                List<Models.Meta2Enum> meta = null)
            => CoreHelper.RunTask(GetInvoiceAsync(invoiceId, meta));

        /// <summary>
        /// Requires the `billing-invoices-view` capability.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The ID of the invoice..</param>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingInvoicesResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingInvoicesResponse1> GetInvoiceAsync(
                string invoiceId,
                List<Models.Meta2Enum> meta = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingInvoicesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/invoices/{invoiceId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("invoiceId", invoiceId))
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a new Job on an Invoice. Generally used to make a payment on an Invoice.
        /// Requires the `billing-invoices-pay` capability.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The ID of the invoice..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1BillingInvoicesTasksResponse response from the API call.</returns>
        public Models.V1BillingInvoicesTasksResponse CreateInvoiceJob(
                string invoiceId,
                Models.ContainerStartActionTask body = null)
            => CoreHelper.RunTask(CreateInvoiceJobAsync(invoiceId, body));

        /// <summary>
        /// Creates a new Job on an Invoice. Generally used to make a payment on an Invoice.
        /// Requires the `billing-invoices-pay` capability.
        /// </summary>
        /// <param name="invoiceId">Required parameter: The ID of the invoice..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingInvoicesTasksResponse response from the API call.</returns>
        public async Task<Models.V1BillingInvoicesTasksResponse> CreateInvoiceJobAsync(
                string invoiceId,
                Models.ContainerStartActionTask body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingInvoicesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/billing/invoices/{invoiceId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("invoiceId", invoiceId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requries the `billing-services-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1BillingServicesResponse response from the API call.</returns>
        public Models.V1BillingServicesResponse GetBillingServices(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetBillingServicesAsync(sort, filter, page));

        /// <summary>
        /// Requries the `billing-services-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingServicesResponse response from the API call.</returns>
        public async Task<Models.V1BillingServicesResponse> GetBillingServicesAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingServicesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/services")
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
        /// Requries the `billing-services-view` capability.
        /// </summary>
        /// <param name="servicesId">Required parameter: The ID of the Billing Service..</param>
        /// <returns>Returns the Models.V1BillingServicesResponse1 response from the API call.</returns>
        public Models.V1BillingServicesResponse1 GetBillingService(
                string servicesId)
            => CoreHelper.RunTask(GetBillingServiceAsync(servicesId));

        /// <summary>
        /// Requries the `billing-services-view` capability.
        /// </summary>
        /// <param name="servicesId">Required parameter: The ID of the Billing Service..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingServicesResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingServicesResponse1> GetBillingServiceAsync(
                string servicesId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingServicesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/services/{servicesId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("servicesId", servicesId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getBillingOverages EndPoint.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1BillingServicesOveragesResponse response from the API call.</returns>
        public Models.V1BillingServicesOveragesResponse GetBillingOverages(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetBillingOveragesAsync(sort, filter, page));

        /// <summary>
        /// getBillingOverages EndPoint.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingServicesOveragesResponse response from the API call.</returns>
        public async Task<Models.V1BillingServicesOveragesResponse> GetBillingOveragesAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingServicesOveragesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/services/overages")
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
        /// Lists the Billing Credits associated with the current Hub.
        /// Requires the `billing-credits-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1BillingCreditsResponse response from the API call.</returns>
        public Models.V1BillingCreditsResponse GetCredits(
                List<string> sort = null,
                Models.Filter2 filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetCreditsAsync(sort, filter, page));

        /// <summary>
        /// Lists the Billing Credits associated with the current Hub.
        /// Requires the `billing-credits-view` capability.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingCreditsResponse response from the API call.</returns>
        public async Task<Models.V1BillingCreditsResponse> GetCreditsAsync(
                List<string> sort = null,
                Models.Filter2 filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingCreditsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/credits")
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
        /// Requires the `billing-credits-view` capability.
        /// </summary>
        /// <param name="creditsId">Required parameter: The ID for a given credit..</param>
        /// <returns>Returns the Models.V1BillingCreditsResponse1 response from the API call.</returns>
        public Models.V1BillingCreditsResponse1 GetCredit(
                string creditsId)
            => CoreHelper.RunTask(GetCreditAsync(creditsId));

        /// <summary>
        /// Requires the `billing-credits-view` capability.
        /// </summary>
        /// <param name="creditsId">Required parameter: The ID for a given credit..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1BillingCreditsResponse1 response from the API call.</returns>
        public async Task<Models.V1BillingCreditsResponse1> GetCreditAsync(
                string creditsId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1BillingCreditsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/billing/credits/{creditsId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creditsId", creditsId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}