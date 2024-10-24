// <copyright file="CyclePlatformAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using CyclePlatformAPI.Standard.Authentication;
using CyclePlatformAPI.Standard.Controllers;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Utilities;

namespace CyclePlatformAPI.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class CyclePlatformAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.cycle.io" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<EnvironmentsController> environments;
        private readonly Lazy<ContainersController> containers;
        private readonly Lazy<ImagesController> images;
        private readonly Lazy<StacksController> stacks;
        private readonly Lazy<PipelinesController> pipelines;
        private readonly Lazy<DNSController> dNS;
        private readonly Lazy<InfrastructureController> infrastructure;
        private readonly Lazy<ServersController> servers;
        private readonly Lazy<SDNController> sDN;
        private readonly Lazy<InstancesController> instances;
        private readonly Lazy<JobsController> jobs;
        private readonly Lazy<AccountsController> accounts;
        private readonly Lazy<AnnouncementsController> announcements;
        private readonly Lazy<BillingController> billing;
        private readonly Lazy<HubsController> hubs;
        private readonly Lazy<SearchController> search;
        private readonly Lazy<ImageSourcesController> imageSources;
        private readonly Lazy<SecurityController> security;
        private readonly Lazy<UtilityController> utility;

        private CyclePlatformAPIClient(
            string xHubId2,
            Environment environment,
            BearerAuthModel bearerAuthModel,
            HubAuthModel hubAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.XHubId2 = xHubId2;
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            HubAuthModel = hubAuthModel;
            var hubAuthManager = new HubAuthManager(hubAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"bearerAuth", bearerAuthManager},
                    {"hubAuth", hubAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("X-Hub-Id", this.XHubId2))
)
                .UserAgent(userAgent)
                .Build();

            BearerAuthCredentials = bearerAuthManager;
            HubAuthCredentials = hubAuthManager;

            this.environments = new Lazy<EnvironmentsController>(
                () => new EnvironmentsController(globalConfiguration));
            this.containers = new Lazy<ContainersController>(
                () => new ContainersController(globalConfiguration));
            this.images = new Lazy<ImagesController>(
                () => new ImagesController(globalConfiguration));
            this.stacks = new Lazy<StacksController>(
                () => new StacksController(globalConfiguration));
            this.pipelines = new Lazy<PipelinesController>(
                () => new PipelinesController(globalConfiguration));
            this.dNS = new Lazy<DNSController>(
                () => new DNSController(globalConfiguration));
            this.infrastructure = new Lazy<InfrastructureController>(
                () => new InfrastructureController(globalConfiguration));
            this.servers = new Lazy<ServersController>(
                () => new ServersController(globalConfiguration));
            this.sDN = new Lazy<SDNController>(
                () => new SDNController(globalConfiguration));
            this.instances = new Lazy<InstancesController>(
                () => new InstancesController(globalConfiguration));
            this.jobs = new Lazy<JobsController>(
                () => new JobsController(globalConfiguration));
            this.accounts = new Lazy<AccountsController>(
                () => new AccountsController(globalConfiguration));
            this.announcements = new Lazy<AnnouncementsController>(
                () => new AnnouncementsController(globalConfiguration));
            this.billing = new Lazy<BillingController>(
                () => new BillingController(globalConfiguration));
            this.hubs = new Lazy<HubsController>(
                () => new HubsController(globalConfiguration));
            this.search = new Lazy<SearchController>(
                () => new SearchController(globalConfiguration));
            this.imageSources = new Lazy<ImageSourcesController>(
                () => new ImageSourcesController(globalConfiguration));
            this.security = new Lazy<SecurityController>(
                () => new SecurityController(globalConfiguration));
            this.utility = new Lazy<UtilityController>(
                () => new UtilityController(globalConfiguration));
        }

        /// <summary>
        /// Gets EnvironmentsController controller.
        /// </summary>
        public EnvironmentsController EnvironmentsController => this.environments.Value;

        /// <summary>
        /// Gets ContainersController controller.
        /// </summary>
        public ContainersController ContainersController => this.containers.Value;

        /// <summary>
        /// Gets ImagesController controller.
        /// </summary>
        public ImagesController ImagesController => this.images.Value;

        /// <summary>
        /// Gets StacksController controller.
        /// </summary>
        public StacksController StacksController => this.stacks.Value;

        /// <summary>
        /// Gets PipelinesController controller.
        /// </summary>
        public PipelinesController PipelinesController => this.pipelines.Value;

        /// <summary>
        /// Gets DNSController controller.
        /// </summary>
        public DNSController DNSController => this.dNS.Value;

        /// <summary>
        /// Gets InfrastructureController controller.
        /// </summary>
        public InfrastructureController InfrastructureController => this.infrastructure.Value;

        /// <summary>
        /// Gets ServersController controller.
        /// </summary>
        public ServersController ServersController => this.servers.Value;

        /// <summary>
        /// Gets SDNController controller.
        /// </summary>
        public SDNController SDNController => this.sDN.Value;

        /// <summary>
        /// Gets InstancesController controller.
        /// </summary>
        public InstancesController InstancesController => this.instances.Value;

        /// <summary>
        /// Gets JobsController controller.
        /// </summary>
        public JobsController JobsController => this.jobs.Value;

        /// <summary>
        /// Gets AccountsController controller.
        /// </summary>
        public AccountsController AccountsController => this.accounts.Value;

        /// <summary>
        /// Gets AnnouncementsController controller.
        /// </summary>
        public AnnouncementsController AnnouncementsController => this.announcements.Value;

        /// <summary>
        /// Gets BillingController controller.
        /// </summary>
        public BillingController BillingController => this.billing.Value;

        /// <summary>
        /// Gets HubsController controller.
        /// </summary>
        public HubsController HubsController => this.hubs.Value;

        /// <summary>
        /// Gets SearchController controller.
        /// </summary>
        public SearchController SearchController => this.search.Value;

        /// <summary>
        /// Gets ImageSourcesController controller.
        /// </summary>
        public ImageSourcesController ImageSourcesController => this.imageSources.Value;

        /// <summary>
        /// Gets SecurityController controller.
        /// </summary>
        public SecurityController SecurityController => this.security.Value;

        /// <summary>
        /// Gets UtilityController controller.
        /// </summary>
        public UtilityController UtilityController => this.utility.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets XHubId2.
        /// Defines the scope of the request to a specific Hub.
        /// </summary>
        public string XHubId2 { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        public IBearerAuthCredentials BearerAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerAuth.
        /// </summary>
        public BearerAuthModel BearerAuthModel { get; private set; }

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the credentials to use with HubAuth.
        /// </summary>
        public IHubAuthCredentials HubAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with HubAuth.
        /// </summary>
        public HubAuthModel HubAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the CyclePlatformAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .XHubId2(this.XHubId2)
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (BearerAuthModel != null)
            {
                builder.BearerAuthCredentials(BearerAuthModel.ToBuilder().Build());
            }

            if (HubAuthModel != null)
            {
                builder.HubAuthCredentials(HubAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"XHubId2 = {this.XHubId2}, " +
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> CyclePlatformAPIClient.</returns>
        internal static CyclePlatformAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string xHubId2 = System.Environment.GetEnvironmentVariable("CYCLE_PLATFORM_API_STANDARD_X_HUB_ID_2");
            string environment = System.Environment.GetEnvironmentVariable("CYCLE_PLATFORM_API_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("CYCLE_PLATFORM_API_STANDARD_ACCESS_TOKEN");
            string xHubId = System.Environment.GetEnvironmentVariable("CYCLE_PLATFORM_API_STANDARD_X_HUB_ID");

            if (xHubId2 != null)
            {
                builder.XHubId2(xHubId2);
            }

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.BearerAuthCredentials(new BearerAuthModel
                .Builder(accessToken)
                .Build());
            }

            if (xHubId != null)
            {
                builder.HubAuthCredentials(new HubAuthModel
                .Builder(xHubId)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string xHubId2 = String.Empty;
            private Environment environment = CyclePlatformAPI.Standard.Environment.Production;
            private BearerAuthModel bearerAuthModel = new BearerAuthModel();
            private HubAuthModel hubAuthModel = new HubAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="bearerAuthModel">BearerAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerAuthCredentials(BearerAuthModel bearerAuthModel)
            {
                if (bearerAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(bearerAuthModel));
                }

                this.bearerAuthModel = bearerAuthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for HubAuth.
            /// </summary>
            /// <param name="hubAuthModel">HubAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder HubAuthCredentials(HubAuthModel hubAuthModel)
            {
                if (hubAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(hubAuthModel));
                }

                this.hubAuthModel = hubAuthModel;
                return this;
            }

            /// <summary>
            /// Sets XHubId2.
            /// </summary>
            /// <param name="xHubId2"> XHubId2. </param>
            /// <returns> Builder. </returns>
            public Builder XHubId2(string xHubId2)
            {
                this.xHubId2 = xHubId2 ?? throw new ArgumentNullException(nameof(xHubId2));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the CyclePlatformAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>CyclePlatformAPIClient.</returns>
            public CyclePlatformAPIClient Build()
            {
                if (bearerAuthModel.AccessToken == null)
                {
                    bearerAuthModel = null;
                }
                if (hubAuthModel.XHubId == null)
                {
                    hubAuthModel = null;
                }
                return new CyclePlatformAPIClient(
                    xHubId2,
                    environment,
                    bearerAuthModel,
                    hubAuthModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
