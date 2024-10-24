// <copyright file="HubsControllerTest.cs" company="APIMatic">
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
    /// HubsControllerTest.
    /// </summary>
    [TestFixture]
    public class HubsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private HubsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.HubsController;
        }

        /// <summary>
        /// Lists all associated Hubs..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubs()
        {
            // Parameters for the API call
            Standard.Models.Page page = null;
            Standard.Models.Filter15 filter = null;

            // Perform API call
            Standard.Models.ListHubsResponse result = null;
            try
            {
                result = await this.controller.GetHubsAsync(page, filter);
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
        /// Create a Hub..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateHub()
        {
            // Parameters for the API call
            Standard.Models.V1HubsRequest body = null;

            // Perform API call
            Standard.Models.V1HubsResponse result = null;
            try
            {
                result = await this.controller.CreateHubAsync(body);
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
        /// Requires the `hubs-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHub()
        {
            // Parameters for the API call
            List<Standard.Models.Meta14Enum> meta = null;

            // Perform API call
            Standard.Models.V1HubsCurrentResponse result = null;
            try
            {
                result = await this.controller.GetHubAsync(meta);
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
        /// Updates the specified hub, setting the values of the parameters passed..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateHub()
        {
            // Parameters for the API call
            Standard.Models.V1HubsCurrentRequest body = null;

            // Perform API call
            Standard.Models.HubUpdateResponse result = null;
            try
            {
                result = await this.controller.UpdateHubAsync(body);
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
        /// Requires the `hubs-delete` capability. This can only be aquired by being the hub owner..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteHub()
        {
            // Perform API call
            Standard.Models.V1HubsCurrentResponse1 result = null;
            try
            {
                result = await this.controller.DeleteHubAsync();
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
        /// List Hub Capabilities.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubCapabilities()
        {
            // Perform API call
            Standard.Models.V1HubsCapabilitiesResponse result = null;
            try
            {
                result = await this.controller.GetHubCapabilitiesAsync();
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
        /// Requires the `hubs-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubUsage()
        {
            // Parameters for the API call
            object filter = null;

            // Perform API call
            Standard.Models.V1HubsCurrentUsageResponse result = null;
            try
            {
                result = await this.controller.GetHubUsageAsync(filter);
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
        /// List Hub Activity.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubActivity()
        {
            // Parameters for the API call
            List<Standard.Models.Include15Enum> include = null;
            Standard.Models.Filter16 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1HubsCurrentActivityResponse result = null;
            try
            {
                result = await this.controller.GetHubActivityAsync(include, filter, sort, page);
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
        /// Requires the `hubs-invites-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubInvites()
        {
            // Parameters for the API call
            List<Standard.Models.Meta1Enum> meta = null;
            List<Standard.Models.Include16Enum> include = null;
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1HubsCurrentInvitesResponse1 result = null;
            try
            {
                result = await this.controller.GetHubInvitesAsync(meta, include, sort, filter, page);
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
        /// Requires the `hubs-invites-send` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateHubInvite()
        {
            // Parameters for the API call
            Standard.Models.V1HubsCurrentInvitesRequest body = null;

            // Perform API call
            Standard.Models.V1HubsCurrentInvitesResponse result = null;
            try
            {
                result = await this.controller.CreateHubInviteAsync(body);
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
        /// Requires the `hubs-members-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubMembers()
        {
            // Parameters for the API call
            List<Standard.Models.Meta1Enum> meta = null;
            List<Standard.Models.IncludeEnum> include = null;
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1HubsCurrentMembersResponse result = null;
            try
            {
                result = await this.controller.GetHubMembersAsync(meta, include, sort, filter, page);
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
        /// Gets the Hub Membership for the requesting Account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubMembership()
        {
            // Parameters for the API call
            List<Standard.Models.Meta1Enum> meta = null;
            List<Standard.Models.IncludeEnum> include = null;
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1HubsCurrentMembershipResponse result = null;
            try
            {
                result = await this.controller.GetHubMembershipAsync(meta, include, sort, filter, page);
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
        /// Requires the `api-keys-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetApiKeys()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.ListApiKeysResponse result = null;
            try
            {
                result = await this.controller.GetApiKeysAsync(sort, filter, page);
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
        /// Requires the `api-keys-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateApiKey()
        {
            // Parameters for the API call
            Standard.Models.V1HubsCurrentApiKeysRequest body = null;

            // Perform API call
            Standard.Models.V1HubsCurrentApiKeysResponse result = null;
            try
            {
                result = await this.controller.CreateApiKeyAsync(body);
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
        /// Lists the Roles that have been created for this Hub.
        ///
        ///Requires the `hubs-roles-manage` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetRoles()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1HubsCurrentRolesResponse result = null;
            try
            {
                result = await this.controller.GetRolesAsync(sort, filter, page);
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
        /// Creates a custom Role for a Hub.
        ///
        ///Requires the `hubs-roles-manage` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateRole()
        {
            // Parameters for the API call
            Standard.Models.V1HubsCurrentRolesRequest body = null;

            // Perform API call
            Standard.Models.V1HubsCurrentRolesResponse1 result = null;
            try
            {
                result = await this.controller.CreateRoleAsync(body);
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
        /// Lists all integrations associated with the current Hub, with optional filtering.
        ///
        ///Requires the `hubs-integrations-view` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetIntegrations()
        {
            // Parameters for the API call
            Standard.Models.Page page = null;
            List<Standard.Models.Meta20Enum> meta = null;
            Standard.Models.Filter17 filter = null;

            // Perform API call
            Standard.Models.V1HubsCurrentIntegrationsResponse3 result = null;
            try
            {
                result = await this.controller.GetIntegrationsAsync(page, meta, filter);
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
        /// Returns a map of available integrations categorized by their type..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAvailableIntegrations()
        {
            // Perform API call
            Standard.Models.V1HubsCurrentIntegrationsAvailableResponse result = null;
            try
            {
                result = await this.controller.GetAvailableIntegrationsAsync();
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
        /// Initializes authorization for the Hub notification pipeline. The Hub notification pipeline is a one-way streaming websocket that
        ///sends real-time 'notifications' as things are happening on the Hub. These notifications tell some basic information about an event,
        ///and it is up to the user to fetch additional details, if deemed necessary.
        ///
        ///Requesting this endpoint without a `?token=<token>` URL parameter will result in receiving a short lived token in the response body. That 
        ///token can then be applied to the URL parameter to the same endpoint to upgrade the connection to a WebSocket.
        ///
        ///Requires the `apionly-notifications-listen` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetHubNotificationSocketAuth()
        {
            // Perform API call
            Standard.Models.V1HubsCurrentNotificationsResponse result = null;
            try
            {
                result = await this.controller.GetHubNotificationSocketAuthAsync();
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