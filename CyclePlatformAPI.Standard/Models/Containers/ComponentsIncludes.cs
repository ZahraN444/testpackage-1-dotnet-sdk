// <copyright file="ComponentsIncludes.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ComponentsIncludes>),
        new Type[] {
            typeof(ContainerCase),
            typeof(InstanceCase),
            typeof(EnvironmentCase),
            typeof(ImageCase),
            typeof(ImageSourceCase),
            typeof(ServerCase),
            typeof(InfrastructureIPPoolCase),
            typeof(IntegrationCase),
            typeof(StackCase),
            typeof(StackBuildCase),
            typeof(DNSZoneCase),
            typeof(DNSRecordCase),
            typeof(ApiKeyCase),
            typeof(NetworkCase),
            typeof(HubMembershipCase),
            typeof(PipelineCase),
            typeof(TriggerKeyCase),
            typeof(ScopedVariableCase),
            typeof(HubCase),
            typeof(BillingInvoiceCase),
            typeof(BillingMethodCase),
            typeof(AutoScaleGroupCase),
            typeof(PipelineRunCase),
            typeof(RoleCase)
        },
        true
    )]
    public abstract class ComponentsIncludes
    {
        /// <summary>
        /// This is Container case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Container value.
        /// </returns>
        public static ComponentsIncludes FromContainer(Container container)
        {
            return new ContainerCase().Set(container);
        }

        /// <summary>
        /// This is Instance case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Instance value.
        /// </returns>
        public static ComponentsIncludes FromInstance(Instance instance)
        {
            return new InstanceCase().Set(instance);
        }

        /// <summary>
        /// This is Environment case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Environment value.
        /// </returns>
        public static ComponentsIncludes FromEnvironment(Environment environment)
        {
            return new EnvironmentCase().Set(environment);
        }

        /// <summary>
        /// This is Image case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Image value.
        /// </returns>
        public static ComponentsIncludes FromImage(Image image)
        {
            return new ImageCase().Set(image);
        }

        /// <summary>
        /// This is ImageSource case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided ImageSource value.
        /// </returns>
        public static ComponentsIncludes FromImageSource(ImageSource imageSource)
        {
            return new ImageSourceCase().Set(imageSource);
        }

        /// <summary>
        /// This is Server case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Server value.
        /// </returns>
        public static ComponentsIncludes FromServer(Server server)
        {
            return new ServerCase().Set(server);
        }

        /// <summary>
        /// This is InfrastructureIPPool case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided InfrastructureIPPool value.
        /// </returns>
        public static ComponentsIncludes FromInfrastructureIPPool(InfrastructureIPPool infrastructureIPPool)
        {
            return new InfrastructureIPPoolCase().Set(infrastructureIPPool);
        }

        /// <summary>
        /// This is Integration case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Integration value.
        /// </returns>
        public static ComponentsIncludes FromIntegration(Integration integration)
        {
            return new IntegrationCase().Set(integration);
        }

        /// <summary>
        /// This is Stack case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Stack value.
        /// </returns>
        public static ComponentsIncludes FromStack(Stack stack)
        {
            return new StackCase().Set(stack);
        }

        /// <summary>
        /// This is StackBuild case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided StackBuild value.
        /// </returns>
        public static ComponentsIncludes FromStackBuild(StackBuild stackBuild)
        {
            return new StackBuildCase().Set(stackBuild);
        }

        /// <summary>
        /// This is DNSZone case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided DNSZone value.
        /// </returns>
        public static ComponentsIncludes FromDNSZone(DNSZone dNSZone)
        {
            return new DNSZoneCase().Set(dNSZone);
        }

        /// <summary>
        /// This is DNSRecord case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided DNSRecord value.
        /// </returns>
        public static ComponentsIncludes FromDNSRecord(DNSRecord dNSRecord)
        {
            return new DNSRecordCase().Set(dNSRecord);
        }

        /// <summary>
        /// This is ApiKey case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided ApiKey value.
        /// </returns>
        public static ComponentsIncludes FromApiKey(ApiKey apiKey)
        {
            return new ApiKeyCase().Set(apiKey);
        }

        /// <summary>
        /// This is Network case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Network value.
        /// </returns>
        public static ComponentsIncludes FromNetwork(Network network)
        {
            return new NetworkCase().Set(network);
        }

        /// <summary>
        /// This is HubMembership case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided HubMembership value.
        /// </returns>
        public static ComponentsIncludes FromHubMembership(HubMembership hubMembership)
        {
            return new HubMembershipCase().Set(hubMembership);
        }

        /// <summary>
        /// This is Pipeline case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Pipeline value.
        /// </returns>
        public static ComponentsIncludes FromPipeline(Pipeline pipeline)
        {
            return new PipelineCase().Set(pipeline);
        }

        /// <summary>
        /// This is TriggerKey case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided TriggerKey value.
        /// </returns>
        public static ComponentsIncludes FromTriggerKey(TriggerKey triggerKey)
        {
            return new TriggerKeyCase().Set(triggerKey);
        }

        /// <summary>
        /// This is ScopedVariable case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided ScopedVariable value.
        /// </returns>
        public static ComponentsIncludes FromScopedVariable(ScopedVariable scopedVariable)
        {
            return new ScopedVariableCase().Set(scopedVariable);
        }

        /// <summary>
        /// This is Hub case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Hub value.
        /// </returns>
        public static ComponentsIncludes FromHub(Hub hub)
        {
            return new HubCase().Set(hub);
        }

        /// <summary>
        /// This is BillingInvoice case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided BillingInvoice value.
        /// </returns>
        public static ComponentsIncludes FromBillingInvoice(BillingInvoice billingInvoice)
        {
            return new BillingInvoiceCase().Set(billingInvoice);
        }

        /// <summary>
        /// This is BillingMethod case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided BillingMethod value.
        /// </returns>
        public static ComponentsIncludes FromBillingMethod(BillingMethod billingMethod)
        {
            return new BillingMethodCase().Set(billingMethod);
        }

        /// <summary>
        /// This is AutoScaleGroup case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided AutoScaleGroup value.
        /// </returns>
        public static ComponentsIncludes FromAutoScaleGroup(AutoScaleGroup autoScaleGroup)
        {
            return new AutoScaleGroupCase().Set(autoScaleGroup);
        }

        /// <summary>
        /// This is PipelineRun case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided PipelineRun value.
        /// </returns>
        public static ComponentsIncludes FromPipelineRun(PipelineRun pipelineRun)
        {
            return new PipelineRunCase().Set(pipelineRun);
        }

        /// <summary>
        /// This is Role case.
        /// </summary>
        /// <returns>
        /// The ComponentsIncludes instance, wrapping the provided Role value.
        /// </returns>
        public static ComponentsIncludes FromRole(Role role)
        {
            return new RoleCase().Set(role);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<Container, T> container,
            Func<Instance, T> instance,
            Func<Environment, T> environment,
            Func<Image, T> image,
            Func<ImageSource, T> imageSource,
            Func<Server, T> server,
            Func<InfrastructureIPPool, T> infrastructureIPPool,
            Func<Integration, T> integration,
            Func<Stack, T> stack,
            Func<StackBuild, T> stackBuild,
            Func<DNSZone, T> dNSZone,
            Func<DNSRecord, T> dNSRecord,
            Func<ApiKey, T> apiKey,
            Func<Network, T> network,
            Func<HubMembership, T> hubMembership,
            Func<Pipeline, T> pipeline,
            Func<TriggerKey, T> triggerKey,
            Func<ScopedVariable, T> scopedVariable,
            Func<Hub, T> hub,
            Func<BillingInvoice, T> billingInvoice,
            Func<BillingMethod, T> billingMethod,
            Func<AutoScaleGroup, T> autoScaleGroup,
            Func<PipelineRun, T> pipelineRun,
            Func<Role, T> role);

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerCase, Container>))]
        private sealed class ContainerCase : ComponentsIncludes, ICaseValue<ContainerCase, Container>
        {
            public Container _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return container(_value);
            }

            public ContainerCase Set(Container value)
            {
                _value = value;
                return this;
            }

            public Container Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InstanceCase, Instance>))]
        private sealed class InstanceCase : ComponentsIncludes, ICaseValue<InstanceCase, Instance>
        {
            public Instance _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return instance(_value);
            }

            public InstanceCase Set(Instance value)
            {
                _value = value;
                return this;
            }

            public Instance Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentCase, Environment>))]
        private sealed class EnvironmentCase : ComponentsIncludes, ICaseValue<EnvironmentCase, Environment>
        {
            public Environment _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return environment(_value);
            }

            public EnvironmentCase Set(Environment value)
            {
                _value = value;
                return this;
            }

            public Environment Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageCase, Image>))]
        private sealed class ImageCase : ComponentsIncludes, ICaseValue<ImageCase, Image>
        {
            public Image _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return image(_value);
            }

            public ImageCase Set(Image value)
            {
                _value = value;
                return this;
            }

            public Image Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageSourceCase, ImageSource>))]
        private sealed class ImageSourceCase : ComponentsIncludes, ICaseValue<ImageSourceCase, ImageSource>
        {
            public ImageSource _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return imageSource(_value);
            }

            public ImageSourceCase Set(ImageSource value)
            {
                _value = value;
                return this;
            }

            public ImageSource Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ServerCase, Server>))]
        private sealed class ServerCase : ComponentsIncludes, ICaseValue<ServerCase, Server>
        {
            public Server _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return server(_value);
            }

            public ServerCase Set(Server value)
            {
                _value = value;
                return this;
            }

            public Server Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InfrastructureIPPoolCase, InfrastructureIPPool>))]
        private sealed class InfrastructureIPPoolCase : ComponentsIncludes, ICaseValue<InfrastructureIPPoolCase, InfrastructureIPPool>
        {
            public InfrastructureIPPool _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return infrastructureIPPool(_value);
            }

            public InfrastructureIPPoolCase Set(InfrastructureIPPool value)
            {
                _value = value;
                return this;
            }

            public InfrastructureIPPool Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<IntegrationCase, Integration>))]
        private sealed class IntegrationCase : ComponentsIncludes, ICaseValue<IntegrationCase, Integration>
        {
            public Integration _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return integration(_value);
            }

            public IntegrationCase Set(Integration value)
            {
                _value = value;
                return this;
            }

            public Integration Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackCase, Stack>))]
        private sealed class StackCase : ComponentsIncludes, ICaseValue<StackCase, Stack>
        {
            public Stack _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return stack(_value);
            }

            public StackCase Set(Stack value)
            {
                _value = value;
                return this;
            }

            public Stack Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildCase, StackBuild>))]
        private sealed class StackBuildCase : ComponentsIncludes, ICaseValue<StackBuildCase, StackBuild>
        {
            public StackBuild _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return stackBuild(_value);
            }

            public StackBuildCase Set(StackBuild value)
            {
                _value = value;
                return this;
            }

            public StackBuild Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DNSZoneCase, DNSZone>))]
        private sealed class DNSZoneCase : ComponentsIncludes, ICaseValue<DNSZoneCase, DNSZone>
        {
            public DNSZone _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return dNSZone(_value);
            }

            public DNSZoneCase Set(DNSZone value)
            {
                _value = value;
                return this;
            }

            public DNSZone Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DNSRecordCase, DNSRecord>))]
        private sealed class DNSRecordCase : ComponentsIncludes, ICaseValue<DNSRecordCase, DNSRecord>
        {
            public DNSRecord _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return dNSRecord(_value);
            }

            public DNSRecordCase Set(DNSRecord value)
            {
                _value = value;
                return this;
            }

            public DNSRecord Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApiKeyCase, ApiKey>))]
        private sealed class ApiKeyCase : ComponentsIncludes, ICaseValue<ApiKeyCase, ApiKey>
        {
            public ApiKey _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return apiKey(_value);
            }

            public ApiKeyCase Set(ApiKey value)
            {
                _value = value;
                return this;
            }

            public ApiKey Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<NetworkCase, Network>))]
        private sealed class NetworkCase : ComponentsIncludes, ICaseValue<NetworkCase, Network>
        {
            public Network _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return network(_value);
            }

            public NetworkCase Set(Network value)
            {
                _value = value;
                return this;
            }

            public Network Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<HubMembershipCase, HubMembership>))]
        private sealed class HubMembershipCase : ComponentsIncludes, ICaseValue<HubMembershipCase, HubMembership>
        {
            public HubMembership _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return hubMembership(_value);
            }

            public HubMembershipCase Set(HubMembership value)
            {
                _value = value;
                return this;
            }

            public HubMembership Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PipelineCase, Pipeline>))]
        private sealed class PipelineCase : ComponentsIncludes, ICaseValue<PipelineCase, Pipeline>
        {
            public Pipeline _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return pipeline(_value);
            }

            public PipelineCase Set(Pipeline value)
            {
                _value = value;
                return this;
            }

            public Pipeline Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<TriggerKeyCase, TriggerKey>))]
        private sealed class TriggerKeyCase : ComponentsIncludes, ICaseValue<TriggerKeyCase, TriggerKey>
        {
            public TriggerKey _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return triggerKey(_value);
            }

            public TriggerKeyCase Set(TriggerKey value)
            {
                _value = value;
                return this;
            }

            public TriggerKey Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScopedVariableCase, ScopedVariable>))]
        private sealed class ScopedVariableCase : ComponentsIncludes, ICaseValue<ScopedVariableCase, ScopedVariable>
        {
            public ScopedVariable _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return scopedVariable(_value);
            }

            public ScopedVariableCase Set(ScopedVariable value)
            {
                _value = value;
                return this;
            }

            public ScopedVariable Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<HubCase, Hub>))]
        private sealed class HubCase : ComponentsIncludes, ICaseValue<HubCase, Hub>
        {
            public Hub _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return hub(_value);
            }

            public HubCase Set(Hub value)
            {
                _value = value;
                return this;
            }

            public Hub Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BillingInvoiceCase, BillingInvoice>))]
        private sealed class BillingInvoiceCase : ComponentsIncludes, ICaseValue<BillingInvoiceCase, BillingInvoice>
        {
            public BillingInvoice _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return billingInvoice(_value);
            }

            public BillingInvoiceCase Set(BillingInvoice value)
            {
                _value = value;
                return this;
            }

            public BillingInvoice Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BillingMethodCase, BillingMethod>))]
        private sealed class BillingMethodCase : ComponentsIncludes, ICaseValue<BillingMethodCase, BillingMethod>
        {
            public BillingMethod _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return billingMethod(_value);
            }

            public BillingMethodCase Set(BillingMethod value)
            {
                _value = value;
                return this;
            }

            public BillingMethod Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AutoScaleGroupCase, AutoScaleGroup>))]
        private sealed class AutoScaleGroupCase : ComponentsIncludes, ICaseValue<AutoScaleGroupCase, AutoScaleGroup>
        {
            public AutoScaleGroup _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return autoScaleGroup(_value);
            }

            public AutoScaleGroupCase Set(AutoScaleGroup value)
            {
                _value = value;
                return this;
            }

            public AutoScaleGroup Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PipelineRunCase, PipelineRun>))]
        private sealed class PipelineRunCase : ComponentsIncludes, ICaseValue<PipelineRunCase, PipelineRun>
        {
            public PipelineRun _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return pipelineRun(_value);
            }

            public PipelineRunCase Set(PipelineRun value)
            {
                _value = value;
                return this;
            }

            public PipelineRun Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RoleCase, Role>))]
        private sealed class RoleCase : ComponentsIncludes, ICaseValue<RoleCase, Role>
        {
            public Role _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Instance, T> instance,
                Func<Environment, T> environment,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource,
                Func<Server, T> server,
                Func<InfrastructureIPPool, T> infrastructureIPPool,
                Func<Integration, T> integration,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<DNSZone, T> dNSZone,
                Func<DNSRecord, T> dNSRecord,
                Func<ApiKey, T> apiKey,
                Func<Network, T> network,
                Func<HubMembership, T> hubMembership,
                Func<Pipeline, T> pipeline,
                Func<TriggerKey, T> triggerKey,
                Func<ScopedVariable, T> scopedVariable,
                Func<Hub, T> hub,
                Func<BillingInvoice, T> billingInvoice,
                Func<BillingMethod, T> billingMethod,
                Func<AutoScaleGroup, T> autoScaleGroup,
                Func<PipelineRun, T> pipelineRun,
                Func<Role, T> role)
            {
                return role(_value);
            }

            public RoleCase Set(Role value)
            {
                _value = value;
                return this;
            }

            public Role Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}