// <copyright file="InfrastructureControllerTest.cs" company="APIMatic">
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
    /// InfrastructureControllerTest.
    /// </summary>
    [TestFixture]
    public class InfrastructureControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private InfrastructureController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.InfrastructureController;
        }

        /// <summary>
        /// Requires the `infrastructure-servers-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetInfrastructureSummary()
        {
            // Parameters for the API call
            Standard.Models.Filter20 filter = null;

            // Perform API call
            Standard.Models.V1InfrastructureSummaryResponse result = null;
            try
            {
                result = await this.controller.GetInfrastructureSummaryAsync(filter);
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
        /// Requires the `autoscale-groups-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAutoScaleGroups()
        {
            // Parameters for the API call
            Standard.Models.Page page = null;
            List<Standard.Models.Include25Enum> include = null;
            Standard.Models.Filter22 filter = null;

            // Perform API call
            Standard.Models.V1InfrastructureAutoScaleGroupsResponse result = null;
            try
            {
                result = await this.controller.GetAutoScaleGroupsAsync(page, include, filter);
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
        /// Requires the 'autoscale-groups-manage'.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateAutoScaleGroup()
        {
            // Parameters for the API call
            Standard.Models.V1InfrastructureAutoScaleGroupsRequest body = null;

            // Perform API call
            Standard.Models.CreateAutoScaleGroupResponse result = null;
            try
            {
                result = await this.controller.CreateAutoScaleGroupAsync(body);
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
        /// Requires the `servers-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetServers()
        {
            // Parameters for the API call
            List<Standard.Models.Meta13Enum> meta = null;
            List<Standard.Models.Include25Enum> include = null;
            Standard.Models.Filter23 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1InfrastructureServersResponse result = null;
            try
            {
                result = await this.controller.GetServersAsync(meta, include, filter, sort, page);
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
        /// Requires the `servers-provision` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateServer()
        {
            // Parameters for the API call
            Standard.Models.V1InfrastructureServersRequest body = null;

            // Perform API call
            Standard.Models.V1InfrastructureServersResponse1 result = null;
            try
            {
                result = await this.controller.CreateServerAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(202, HttpCallBack.Response.StatusCode, "Status should be 202");

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
        /// Requires the `servers-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetServerTags()
        {
            // Parameters for the API call
            Standard.Models.Filter25 filter = null;

            // Perform API call
            Standard.Models.ServerTags result = null;
            try
            {
                result = await this.controller.GetServerTagsAsync(filter);
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
        /// Requires the `servers-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetClusters()
        {
            // Perform API call
            Standard.Models.ServerClustersReturn result = null;
            try
            {
                result = await this.controller.GetClustersAsync();
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
        /// Requires the `infrastructure-ips-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetInfrastructureIPPools()
        {
            // Parameters for the API call
            List<Standard.Models.Include30Enum> include = null;
            Standard.Models.Filter26 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1InfrastructureIpsPoolsResponse result = null;
            try
            {
                result = await this.controller.GetInfrastructureIPPoolsAsync(include, filter, sort, page);
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
        /// Gets the available deployment strategies that can be used to orchestrate containers..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetDeploymentStrategies()
        {
            // Perform API call
            Standard.Models.V1InfrastructureDeploymentStrategiesResponse result = null;
            try
            {
                result = await this.controller.GetDeploymentStrategiesAsync();
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