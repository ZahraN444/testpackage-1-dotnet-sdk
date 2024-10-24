// <copyright file="BillingControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Controllers;
using CyclePlatformAPI.Standard.Exceptions;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Http.Response;
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace CyclePlatformAPI.Tests
{
    /// <summary>
    /// BillingControllerTest.
    /// </summary>
    [TestFixture]
    public class BillingControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private BillingController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.BillingController;
        }

        /// <summary>
        /// Requires the `billing-services-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetOrders()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;
            List<Standard.Models.Meta2Enum> meta = null;
            List<Standard.Models.Include1Enum> include = null;

            // Perform API call
            Standard.Models.V1BillingOrdersResponse result = null;
            try
            {
                result = await this.controller.GetOrdersAsync(sort, filter, page, meta, include);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Requires the `billing-orders-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateOrder()
        {
            // Parameters for the API call
            List<Standard.Models.Meta2Enum> meta = null;
            List<Standard.Models.Include1Enum> include = null;
            Standard.Models.V1BillingOrdersRequest body = null;

            // Perform API call
            Standard.Models.V1BillingOrdersResponse1 result = null;
            try
            {
                result = await this.controller.CreateOrderAsync(meta, include, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// List Support Plans.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetBillingSupportPlans()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1BillingPlansSupportResponse result = null;
            try
            {
                result = await this.controller.GetBillingSupportPlansAsync(sort, filter, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Returns list of availiable Billing Tiers..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetBillingTiers()
        {
            // Perform API call
            Standard.Models.V1BillingPlansTiersResponse result = null;
            try
            {
                result = await this.controller.GetBillingTiersAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Lists the Billing Methods associated with the Hub defined in X-Hub-ID.
        ///
        ///Requires the `billing-methods-manage` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetBillingMethods()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1BillingMethodsResponse result = null;
            try
            {
                result = await this.controller.GetBillingMethodsAsync(sort, filter, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Requires the `billing-methods-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateBillingMethod()
        {
            // Parameters for the API call
            Standard.Models.V1BillingMethodsRequest body = null;

            // Perform API call
            Standard.Models.V1BillingMethodsResponse1 result = null;
            try
            {
                result = await this.controller.CreateBillingMethodAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// List the Invoices assoicated with the Hub.  
        ///
        ///Requires the `billing-invoices-view` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetInvoices()
        {
            // Parameters for the API call
            List<string> sort = null;
            Standard.Models.Page page = null;
            List<Standard.Models.Meta2Enum> meta = null;
            Standard.Models.Filter1 filter = null;

            // Perform API call
            Standard.Models.V1BillingInvoicesResponse result = null;
            try
            {
                result = await this.controller.GetInvoicesAsync(sort, page, meta, filter);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Requries the `billing-services-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetBillingServices()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1BillingServicesResponse result = null;
            try
            {
                result = await this.controller.GetBillingServicesAsync(sort, filter, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// List Billing Overages.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetBillingOverages()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1BillingServicesOveragesResponse result = null;
            try
            {
                result = await this.controller.GetBillingOveragesAsync(sort, filter, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Lists the Billing Credits associated with the current Hub.
        ///
        ///Requires the `billing-credits-view` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCredits()
        {
            // Parameters for the API call
            List<string> sort = null;
            Standard.Models.Filter2 filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1BillingCreditsResponse result = null;
            try
            {
                result = await this.controller.GetCreditsAsync(sort, filter, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}