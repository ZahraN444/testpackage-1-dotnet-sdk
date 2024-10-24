// <copyright file="DNSController.cs" company="APIMatic">
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
    /// DNSController.
    /// </summary>
    public class DNSController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSController"/> class.
        /// </summary>
        internal DNSController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1DnsZonesResponse response from the API call.</returns>
        public Models.V1DnsZonesResponse GetDNSZones(
                List<Models.Include12Enum> include = null,
                Models.Filter12 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetDNSZonesAsync(include, filter, sort, page));

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesResponse response from the API call.</returns>
        public async Task<Models.V1DnsZonesResponse> GetDNSZonesAsync(
                List<Models.Include12Enum> include = null,
                Models.Filter12 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/dns/zones")
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
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone..</param>
        /// <returns>Returns the Models.V1DnsZonesResponse1 response from the API call.</returns>
        public Models.V1DnsZonesResponse1 CreateDNSZone(
                Models.V1DnsZonesRequest body = null)
            => CoreHelper.RunTask(CreateDNSZoneAsync(body));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesResponse1 response from the API call.</returns>
        public async Task<Models.V1DnsZonesResponse1> CreateDNSZoneAsync(
                Models.V1DnsZonesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/dns/zones")
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
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <returns>Returns the Models.V1DnsZonesResponse1 response from the API call.</returns>
        public Models.V1DnsZonesResponse1 GetDNSZone(
                string zoneId)
            => CoreHelper.RunTask(GetDNSZoneAsync(zoneId));

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesResponse1 response from the API call.</returns>
        public async Task<Models.V1DnsZonesResponse1> GetDNSZoneAsync(
                string zoneId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/dns/zones/{zoneId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("zoneId", zoneId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for updating a DNS Zone..</param>
        /// <returns>Returns the Models.DNSZoneUpdateResponse response from the API call.</returns>
        public Models.DNSZoneUpdateResponse UpdateDNSZone(
                string zoneId,
                List<Models.Include12Enum> include = null,
                Models.V1DnsZonesRequest1 body = null)
            => CoreHelper.RunTask(UpdateDNSZoneAsync(zoneId, include, body));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="body">Optional parameter: Parameters for updating a DNS Zone..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DNSZoneUpdateResponse response from the API call.</returns>
        public async Task<Models.DNSZoneUpdateResponse> UpdateDNSZoneAsync(
                string zoneId,
                List<Models.Include12Enum> include = null,
                Models.V1DnsZonesRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DNSZoneUpdateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/dns/zones/{zoneId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <returns>Returns the Models.V1DnsZonesResponse3 response from the API call.</returns>
        public Models.V1DnsZonesResponse3 DeleteDNSZone(
                string zoneId)
            => CoreHelper.RunTask(DeleteDNSZoneAsync(zoneId));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesResponse3 response from the API call.</returns>
        public async Task<Models.V1DnsZonesResponse3> DeleteDNSZoneAsync(
                string zoneId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/dns/zones/{zoneId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("zoneId", zoneId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given DNS zone. .
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS zone job..</param>
        /// <returns>Returns the Models.V1DnsZonesTasksResponse response from the API call.</returns>
        public Models.V1DnsZonesTasksResponse CreateDNSZoneJob(
                string zoneId,
                Models.V1DnsZonesTasksRequest body = null)
            => CoreHelper.RunTask(CreateDNSZoneJobAsync(zoneId, body));

        /// <summary>
        /// Used to perform different actions on a given DNS zone. .
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS zone job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesTasksResponse response from the API call.</returns>
        public async Task<Models.V1DnsZonesTasksResponse> CreateDNSZoneJobAsync(
                string zoneId,
                Models.V1DnsZonesTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/dns/zones/{zoneId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.DNSZoneRecordListReturn response from the API call.</returns>
        public Models.DNSZoneRecordListReturn GetDNSZoneRecords(
                string zoneId,
                List<Models.Include14Enum> include = null,
                Models.Filter13 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetDNSZoneRecordsAsync(zoneId, include, filter, sort, page));

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="include">Optional parameter: A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return..</param>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DNSZoneRecordListReturn response from the API call.</returns>
        public async Task<Models.DNSZoneRecordListReturn> GetDNSZoneRecordsAsync(
                string zoneId,
                List<Models.Include14Enum> include = null,
                Models.Filter13 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DNSZoneRecordListReturn>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/dns/zones/{zoneId}/records")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone Record..</param>
        /// <returns>Returns the Models.DNSZoneCreateResponse response from the API call.</returns>
        public Models.DNSZoneCreateResponse CreateDNSZoneRecord(
                string zoneId,
                Models.V1DnsZonesRecordsRequest body = null)
            => CoreHelper.RunTask(CreateDNSZoneRecordAsync(zoneId, body));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone Record..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.DNSZoneCreateResponse response from the API call.</returns>
        public async Task<Models.DNSZoneCreateResponse> CreateDNSZoneRecordAsync(
                string zoneId,
                Models.V1DnsZonesRecordsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DNSZoneCreateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/dns/zones/{zoneId}/records")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="recordId">Required parameter: The ID of the record..</param>
        /// <param name="body">Optional parameter: Parameters for updating a DNS Zone Record. The name value cannot be updated and is omitted from the properties..</param>
        /// <returns>Returns the Models.V1DnsZonesRecordsResponse response from the API call.</returns>
        public Models.V1DnsZonesRecordsResponse UpdateDNSZoneRecord(
                string zoneId,
                string recordId,
                Models.V1DnsZonesRecordsRequest1 body = null)
            => CoreHelper.RunTask(UpdateDNSZoneRecordAsync(zoneId, recordId, body));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="recordId">Required parameter: The ID of the record..</param>
        /// <param name="body">Optional parameter: Parameters for updating a DNS Zone Record. The name value cannot be updated and is omitted from the properties..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesRecordsResponse response from the API call.</returns>
        public async Task<Models.V1DnsZonesRecordsResponse> UpdateDNSZoneRecordAsync(
                string zoneId,
                string recordId,
                Models.V1DnsZonesRecordsRequest1 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesRecordsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/dns/zones/{zoneId}/records/{recordId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Template(_template => _template.Setup("recordId", recordId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="recordId">Required parameter: The ID of the DNS Zone Record..</param>
        /// <returns>Returns the Models.V1DnsZonesRecordsResponse1 response from the API call.</returns>
        public Models.V1DnsZonesRecordsResponse1 DeleteDNSZoneRecord(
                string zoneId,
                string recordId)
            => CoreHelper.RunTask(DeleteDNSZoneRecordAsync(zoneId, recordId));

        /// <summary>
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the Zone..</param>
        /// <param name="recordId">Required parameter: The ID of the DNS Zone Record..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesRecordsResponse1 response from the API call.</returns>
        public async Task<Models.V1DnsZonesRecordsResponse1> DeleteDNSZoneRecordAsync(
                string zoneId,
                string recordId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesRecordsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/dns/zones/{zoneId}/records/{recordId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Template(_template => _template.Setup("recordId", recordId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Used to perform different actions on a given DNS Zone record. .
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="recordId">Required parameter: The ID of the record..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone Record Job..</param>
        /// <returns>Returns the Models.V1DnsZonesRecordsTasksResponse response from the API call.</returns>
        public Models.V1DnsZonesRecordsTasksResponse CreateDNSZoneRecordJob(
                string zoneId,
                string recordId,
                Models.V1DnsZonesRecordsTasksRequest body = null)
            => CoreHelper.RunTask(CreateDNSZoneRecordJobAsync(zoneId, recordId, body));

        /// <summary>
        /// Used to perform different actions on a given DNS Zone record. .
        /// Requires the `dns-manage` capability.
        /// </summary>
        /// <param name="zoneId">Required parameter: The ID of the zone..</param>
        /// <param name="recordId">Required parameter: The ID of the record..</param>
        /// <param name="body">Optional parameter: Parameters for creating a new DNS Zone Record Job..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsZonesRecordsTasksResponse response from the API call.</returns>
        public async Task<Models.V1DnsZonesRecordsTasksResponse> CreateDNSZoneRecordJobAsync(
                string zoneId,
                string recordId,
                Models.V1DnsZonesRecordsTasksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsZonesRecordsTasksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/dns/zones/{zoneId}/records/{recordId}/tasks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("zoneId", zoneId))
                      .Template(_template => _template.Setup("recordId", recordId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1DnsTlsAttemptsResponse response from the API call.</returns>
        public Models.V1DnsTlsAttemptsResponse GetTLSGenerationAttempts(
                Models.Filter14 filter = null,
                List<string> sort = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetTLSGenerationAttemptsAsync(filter, sort, page));

        /// <summary>
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="filter">Optional parameter: ## Filter Field  The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for..</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsTlsAttemptsResponse response from the API call.</returns>
        public async Task<Models.V1DnsTlsAttemptsResponse> GetTLSGenerationAttemptsAsync(
                Models.Filter14 filter = null,
                List<string> sort = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsTlsAttemptsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/dns/tls/attempts")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lookup and retrieve a TLS certificate bundle for a specified domain.
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="domain">Required parameter: The domain to lookup..</param>
        /// <param name="wildcard">Optional parameter: Whether or not to lookup a *. wildcard certificate that would be applicable for this domain. For example, if you are looking for a certificate for x.test.com, setting this to true will identify a *.test.com certificate that would also be applicable..</param>
        /// <returns>Returns the Models.V1DnsTlsCertificatesLookupResponse response from the API call.</returns>
        public Models.V1DnsTlsCertificatesLookupResponse LookupTLSCertificate(
                string domain,
                bool? wildcard = null)
            => CoreHelper.RunTask(LookupTLSCertificateAsync(domain, wildcard));

        /// <summary>
        /// Lookup and retrieve a TLS certificate bundle for a specified domain.
        /// Requires the `dns-view` capability.
        /// </summary>
        /// <param name="domain">Required parameter: The domain to lookup..</param>
        /// <param name="wildcard">Optional parameter: Whether or not to lookup a *. wildcard certificate that would be applicable for this domain. For example, if you are looking for a certificate for x.test.com, setting this to true will identify a *.test.com certificate that would also be applicable..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1DnsTlsCertificatesLookupResponse response from the API call.</returns>
        public async Task<Models.V1DnsTlsCertificatesLookupResponse> LookupTLSCertificateAsync(
                string domain,
                bool? wildcard = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1DnsTlsCertificatesLookupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/dns/tls/certificates/lookup")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("domain", domain))
                      .Query(_query => _query.Setup("wildcard", wildcard))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}