// <copyright file="Event2Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Event2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Event2Enum
    {
        /// <summary>
        /// EnumHubimagesprune.
        /// </summary>
        [EnumMember(Value = "hub.images.prune")]
        EnumHubimagesprune,

        /// <summary>
        /// EnumHubupdate.
        /// </summary>
        [EnumMember(Value = "hub.update")]
        EnumHubupdate,

        /// <summary>
        /// EnumHubcreate.
        /// </summary>
        [EnumMember(Value = "hub.create")]
        EnumHubcreate,

        /// <summary>
        /// EnumHubtaskdelete.
        /// </summary>
        [EnumMember(Value = "hub.task.delete")]
        EnumHubtaskdelete,

        /// <summary>
        /// EnumHubtaskimagesprune.
        /// </summary>
        [EnumMember(Value = "hub.task.images.prune")]
        EnumHubtaskimagesprune,

        /// <summary>
        /// EnumEnvironmentservicesdiscoveryreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.discovery.reconfigure")]
        EnumEnvironmentservicesdiscoveryreconfigure,

        /// <summary>
        /// EnumEnvironmentserviceslbreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.lb.reconfigure")]
        EnumEnvironmentserviceslbreconfigure,

        /// <summary>
        /// EnumEnvironmentservicesvpnreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.reconfigure")]
        EnumEnvironmentservicesvpnreconfigure,

        /// <summary>
        /// EnumEnvironmentdelete.
        /// </summary>
        [EnumMember(Value = "environment.delete")]
        EnumEnvironmentdelete,

        /// <summary>
        /// EnumEnvironmentinitialize.
        /// </summary>
        [EnumMember(Value = "environment.initialize")]
        EnumEnvironmentinitialize,

        /// <summary>
        /// EnumEnvironmentstart.
        /// </summary>
        [EnumMember(Value = "environment.start")]
        EnumEnvironmentstart,

        /// <summary>
        /// EnumEnvironmentstop.
        /// </summary>
        [EnumMember(Value = "environment.stop")]
        EnumEnvironmentstop,

        /// <summary>
        /// EnumEnvironmentcreate.
        /// </summary>
        [EnumMember(Value = "environment.create")]
        EnumEnvironmentcreate,

        /// <summary>
        /// EnumEnvironmentupdate.
        /// </summary>
        [EnumMember(Value = "environment.update")]
        EnumEnvironmentupdate,

        /// <summary>
        /// EnumEnvironmenttaskdelete.
        /// </summary>
        [EnumMember(Value = "environment.task.delete")]
        EnumEnvironmenttaskdelete,

        /// <summary>
        /// EnumEnvironmentservicesdiscoverytaskreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.discovery.task.reconfigure")]
        EnumEnvironmentservicesdiscoverytaskreconfigure,

        /// <summary>
        /// EnumEnvironmentserviceslbtaskreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.lb.task.reconfigure")]
        EnumEnvironmentserviceslbtaskreconfigure,

        /// <summary>
        /// EnumEnvironmentservicesvpntaskreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.task.reconfigure")]
        EnumEnvironmentservicesvpntaskreconfigure,

        /// <summary>
        /// EnumEnvironmentservicesvpnusercreate.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.user.create")]
        EnumEnvironmentservicesvpnusercreate,

        /// <summary>
        /// EnumEnvironmentservicesvpnlogin.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.login")]
        EnumEnvironmentservicesvpnlogin,

        /// <summary>
        /// EnumEnvironmentservicesvpnreset.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.reset")]
        EnumEnvironmentservicesvpnreset,

        /// <summary>
        /// EnumEnvironmentservicesvpntaskreset.
        /// </summary>
        [EnumMember(Value = "environment.services.vpn.task.reset")]
        EnumEnvironmentservicesvpntaskreset,

        /// <summary>
        /// EnumEnvironmenttaskinitialize.
        /// </summary>
        [EnumMember(Value = "environment.task.initialize")]
        EnumEnvironmenttaskinitialize,

        /// <summary>
        /// EnumEnvironmenttaskstart.
        /// </summary>
        [EnumMember(Value = "environment.task.start")]
        EnumEnvironmenttaskstart,

        /// <summary>
        /// EnumEnvironmenttaskstop.
        /// </summary>
        [EnumMember(Value = "environment.task.stop")]
        EnumEnvironmenttaskstop,

        /// <summary>
        /// EnumEnvironmenttaskdeploymentsreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.task.deployments.reconfigure")]
        EnumEnvironmenttaskdeploymentsreconfigure,

        /// <summary>
        /// EnumEnvironmentdeploymentsreconfigure.
        /// </summary>
        [EnumMember(Value = "environment.deployments.reconfigure")]
        EnumEnvironmentdeploymentsreconfigure,

        /// <summary>
        /// EnumEnvironmentdeploymentsprune.
        /// </summary>
        [EnumMember(Value = "environment.deployments.prune")]
        EnumEnvironmentdeploymentsprune,

        /// <summary>
        /// EnumEnvironmentdeploymentstart.
        /// </summary>
        [EnumMember(Value = "environment.deployment.start")]
        EnumEnvironmentdeploymentstart,

        /// <summary>
        /// EnumEnvironmentdeploymentstop.
        /// </summary>
        [EnumMember(Value = "environment.deployment.stop")]
        EnumEnvironmentdeploymentstop,

        /// <summary>
        /// EnumEnvironmentscopedvariabledelete.
        /// </summary>
        [EnumMember(Value = "environment.scoped-variable.delete")]
        EnumEnvironmentscopedvariabledelete,

        /// <summary>
        /// EnumEnvironmentscopedvariableupdate.
        /// </summary>
        [EnumMember(Value = "environment.scoped-variable.update")]
        EnumEnvironmentscopedvariableupdate,

        /// <summary>
        /// EnumEnvironmentscopedvariabletaskdelete.
        /// </summary>
        [EnumMember(Value = "environment.scoped-variable.task.delete")]
        EnumEnvironmentscopedvariabletaskdelete,

        /// <summary>
        /// EnumEnvironmentscopedvariablecreate.
        /// </summary>
        [EnumMember(Value = "environment.scoped-variable.create")]
        EnumEnvironmentscopedvariablecreate,

        /// <summary>
        /// EnumImagedelete.
        /// </summary>
        [EnumMember(Value = "image.delete")]
        EnumImagedelete,

        /// <summary>
        /// EnumImageimport.
        /// </summary>
        [EnumMember(Value = "image.import")]
        EnumImageimport,

        /// <summary>
        /// EnumImagecreate.
        /// </summary>
        [EnumMember(Value = "image.create")]
        EnumImagecreate,

        /// <summary>
        /// EnumImageupdate.
        /// </summary>
        [EnumMember(Value = "image.update")]
        EnumImageupdate,

        /// <summary>
        /// EnumImagetaskdelete.
        /// </summary>
        [EnumMember(Value = "image.task.delete")]
        EnumImagetaskdelete,

        /// <summary>
        /// EnumImagetaskimport.
        /// </summary>
        [EnumMember(Value = "image.task.import")]
        EnumImagetaskimport,

        /// <summary>
        /// EnumImagesourcedelete.
        /// </summary>
        [EnumMember(Value = "image.source.delete")]
        EnumImagesourcedelete,

        /// <summary>
        /// EnumImagesourcecreate.
        /// </summary>
        [EnumMember(Value = "image.source.create")]
        EnumImagesourcecreate,

        /// <summary>
        /// EnumImagesourceupdate.
        /// </summary>
        [EnumMember(Value = "image.source.update")]
        EnumImagesourceupdate,

        /// <summary>
        /// EnumImagesourcetaskdelete.
        /// </summary>
        [EnumMember(Value = "image.source.task.delete")]
        EnumImagesourcetaskdelete,

        /// <summary>
        /// EnumBillinginvoicetaskvoid.
        /// </summary>
        [EnumMember(Value = "billing.invoice.task.void")]
        EnumBillinginvoicetaskvoid,

        /// <summary>
        /// EnumBillinginvoicetaskcredit.
        /// </summary>
        [EnumMember(Value = "billing.invoice.task.credit")]
        EnumBillinginvoicetaskcredit,

        /// <summary>
        /// EnumBillinginvoicetaskrefund.
        /// </summary>
        [EnumMember(Value = "billing.invoice.task.refund")]
        EnumBillinginvoicetaskrefund,

        /// <summary>
        /// EnumBillinginvoicepay.
        /// </summary>
        [EnumMember(Value = "billing.invoice.pay")]
        EnumBillinginvoicepay,

        /// <summary>
        /// EnumBillinginvoicetaskpay.
        /// </summary>
        [EnumMember(Value = "billing.invoice.task.pay")]
        EnumBillinginvoicetaskpay,

        /// <summary>
        /// EnumBillingorderconfirm.
        /// </summary>
        [EnumMember(Value = "billing.order.confirm")]
        EnumBillingorderconfirm,

        /// <summary>
        /// EnumBillingordertaskconfirm.
        /// </summary>
        [EnumMember(Value = "billing.order.task.confirm")]
        EnumBillingordertaskconfirm,

        /// <summary>
        /// EnumBillingmethodupdate.
        /// </summary>
        [EnumMember(Value = "billing.method.update")]
        EnumBillingmethodupdate,

        /// <summary>
        /// EnumBillingmethoddelete.
        /// </summary>
        [EnumMember(Value = "billing.method.delete")]
        EnumBillingmethoddelete,

        /// <summary>
        /// EnumBillingmethodtaskdelete.
        /// </summary>
        [EnumMember(Value = "billing.method.task.delete")]
        EnumBillingmethodtaskdelete,

        /// <summary>
        /// EnumBillingmethodcreate.
        /// </summary>
        [EnumMember(Value = "billing.method.create")]
        EnumBillingmethodcreate,

        /// <summary>
        /// EnumHubapikeyupdate.
        /// </summary>
        [EnumMember(Value = "hub.apikey.update")]
        EnumHubapikeyupdate,

        /// <summary>
        /// EnumHubapikeydelete.
        /// </summary>
        [EnumMember(Value = "hub.apikey.delete")]
        EnumHubapikeydelete,

        /// <summary>
        /// EnumHubapikeycreate.
        /// </summary>
        [EnumMember(Value = "hub.apikey.create")]
        EnumHubapikeycreate,

        /// <summary>
        /// EnumHubroleupdate.
        /// </summary>
        [EnumMember(Value = "hub.role.update")]
        EnumHubroleupdate,

        /// <summary>
        /// EnumHubroledelete.
        /// </summary>
        [EnumMember(Value = "hub.role.delete")]
        EnumHubroledelete,

        /// <summary>
        /// EnumHubrolecreate.
        /// </summary>
        [EnumMember(Value = "hub.role.create")]
        EnumHubrolecreate,

        /// <summary>
        /// EnumHubroletaskdelete.
        /// </summary>
        [EnumMember(Value = "hub.role.task.delete")]
        EnumHubroletaskdelete,

        /// <summary>
        /// EnumHubmembershipdelete.
        /// </summary>
        [EnumMember(Value = "hub.membership.delete")]
        EnumHubmembershipdelete,

        /// <summary>
        /// EnumHubmembershipcreate.
        /// </summary>
        [EnumMember(Value = "hub.membership.create")]
        EnumHubmembershipcreate,

        /// <summary>
        /// EnumHubmembershipupdate.
        /// </summary>
        [EnumMember(Value = "hub.membership.update")]
        EnumHubmembershipupdate,

        /// <summary>
        /// EnumHubintegrationcreate.
        /// </summary>
        [EnumMember(Value = "hub.integration.create")]
        EnumHubintegrationcreate,

        /// <summary>
        /// EnumHubintegrationupdate.
        /// </summary>
        [EnumMember(Value = "hub.integration.update")]
        EnumHubintegrationupdate,

        /// <summary>
        /// EnumHubintegrationdelete.
        /// </summary>
        [EnumMember(Value = "hub.integration.delete")]
        EnumHubintegrationdelete,

        /// <summary>
        /// EnumContainerinitialize.
        /// </summary>
        [EnumMember(Value = "container.initialize")]
        EnumContainerinitialize,

        /// <summary>
        /// EnumContainertaskstart.
        /// </summary>
        [EnumMember(Value = "container.task.start")]
        EnumContainertaskstart,

        /// <summary>
        /// EnumContainerstart.
        /// </summary>
        [EnumMember(Value = "container.start")]
        EnumContainerstart,

        /// <summary>
        /// EnumContainertaskstop.
        /// </summary>
        [EnumMember(Value = "container.task.stop")]
        EnumContainertaskstop,

        /// <summary>
        /// EnumContainerstop.
        /// </summary>
        [EnumMember(Value = "container.stop")]
        EnumContainerstop,

        /// <summary>
        /// EnumContainertaskreconfigure.
        /// </summary>
        [EnumMember(Value = "container.task.reconfigure")]
        EnumContainertaskreconfigure,

        /// <summary>
        /// EnumContainerreconfigure.
        /// </summary>
        [EnumMember(Value = "container.reconfigure")]
        EnumContainerreconfigure,

        /// <summary>
        /// EnumContainertaskvolumesreconfigure.
        /// </summary>
        [EnumMember(Value = "container.task.volumes.reconfigure")]
        EnumContainertaskvolumesreconfigure,

        /// <summary>
        /// EnumContainervolumesreconfigure.
        /// </summary>
        [EnumMember(Value = "container.volumes.reconfigure")]
        EnumContainervolumesreconfigure,

        /// <summary>
        /// EnumContainercreate.
        /// </summary>
        [EnumMember(Value = "container.create")]
        EnumContainercreate,

        /// <summary>
        /// EnumContainerrestart.
        /// </summary>
        [EnumMember(Value = "container.restart")]
        EnumContainerrestart,

        /// <summary>
        /// EnumContainertaskreimage.
        /// </summary>
        [EnumMember(Value = "container.task.reimage")]
        EnumContainertaskreimage,

        /// <summary>
        /// EnumContainerreimage.
        /// </summary>
        [EnumMember(Value = "container.reimage")]
        EnumContainerreimage,

        /// <summary>
        /// EnumContainerupdate.
        /// </summary>
        [EnumMember(Value = "container.update")]
        EnumContainerupdate,

        /// <summary>
        /// EnumContainertaskdelete.
        /// </summary>
        [EnumMember(Value = "container.task.delete")]
        EnumContainertaskdelete,

        /// <summary>
        /// EnumContainerdelete.
        /// </summary>
        [EnumMember(Value = "container.delete")]
        EnumContainerdelete,

        /// <summary>
        /// EnumContainertaskscale.
        /// </summary>
        [EnumMember(Value = "container.task.scale")]
        EnumContainertaskscale,

        /// <summary>
        /// EnumContainerscale.
        /// </summary>
        [EnumMember(Value = "container.scale")]
        EnumContainerscale,

        /// <summary>
        /// EnumContainerinstancescreate.
        /// </summary>
        [EnumMember(Value = "container.instances.create")]
        EnumContainerinstancescreate,

        /// <summary>
        /// EnumContainerinstancesdelete.
        /// </summary>
        [EnumMember(Value = "container.instances.delete")]
        EnumContainerinstancesdelete,

        /// <summary>
        /// EnumContainerinstancesautoscaleup.
        /// </summary>
        [EnumMember(Value = "container.instances.autoscale.up")]
        EnumContainerinstancesautoscaleup,

        /// <summary>
        /// EnumContainerinstancesautoscaledown.
        /// </summary>
        [EnumMember(Value = "container.instances.autoscale.down")]
        EnumContainerinstancesautoscaledown,

        /// <summary>
        /// EnumContainerinstancehealthcheckrestarted.
        /// </summary>
        [EnumMember(Value = "container.instance.healthcheck.restarted")]
        EnumContainerinstancehealthcheckrestarted,

        /// <summary>
        /// EnumContainerinstancehealthcheckfailed.
        /// </summary>
        [EnumMember(Value = "container.instance.healthcheck.failed")]
        EnumContainerinstancehealthcheckfailed,

        /// <summary>
        /// EnumContainerinstanceerror.
        /// </summary>
        [EnumMember(Value = "container.instance.error")]
        EnumContainerinstanceerror,

        /// <summary>
        /// EnumContainerinstancesshlogin.
        /// </summary>
        [EnumMember(Value = "container.instance.ssh.login")]
        EnumContainerinstancesshlogin,

        /// <summary>
        /// EnumContainerinstancemigrationstart.
        /// </summary>
        [EnumMember(Value = "container.instance.migration.start")]
        EnumContainerinstancemigrationstart,

        /// <summary>
        /// EnumContainerinstancemigrationrevert.
        /// </summary>
        [EnumMember(Value = "container.instance.migration.revert")]
        EnumContainerinstancemigrationrevert,

        /// <summary>
        /// EnumContainerinstancedelete.
        /// </summary>
        [EnumMember(Value = "container.instance.delete")]
        EnumContainerinstancedelete,

        /// <summary>
        /// EnumContainerinstancetaskmigrateRevert.
        /// </summary>
        [EnumMember(Value = "container.instance.task.migrate_revert")]
        EnumContainerinstancetaskmigrateRevert,

        /// <summary>
        /// EnumContainerinstancetaskmigrate.
        /// </summary>
        [EnumMember(Value = "container.instance.task.migrate")]
        EnumContainerinstancetaskmigrate,

        /// <summary>
        /// EnumContainerbackupcreate.
        /// </summary>
        [EnumMember(Value = "container.backup.create")]
        EnumContainerbackupcreate,

        /// <summary>
        /// EnumContainerbackuprestore.
        /// </summary>
        [EnumMember(Value = "container.backup.restore")]
        EnumContainerbackuprestore,

        /// <summary>
        /// EnumContainerbackupdelete.
        /// </summary>
        [EnumMember(Value = "container.backup.delete")]
        EnumContainerbackupdelete,

        /// <summary>
        /// EnumContainerbackuptaskdelete.
        /// </summary>
        [EnumMember(Value = "container.backup.task.delete")]
        EnumContainerbackuptaskdelete,

        /// <summary>
        /// EnumContainerbackuptaskrestore.
        /// </summary>
        [EnumMember(Value = "container.backup.task.restore")]
        EnumContainerbackuptaskrestore,

        /// <summary>
        /// EnumDnszoneverify.
        /// </summary>
        [EnumMember(Value = "dns.zone.verify")]
        EnumDnszoneverify,

        /// <summary>
        /// EnumDnszonedelete.
        /// </summary>
        [EnumMember(Value = "dns.zone.delete")]
        EnumDnszonedelete,

        /// <summary>
        /// EnumDnszonetaskverify.
        /// </summary>
        [EnumMember(Value = "dns.zone.task.verify")]
        EnumDnszonetaskverify,

        /// <summary>
        /// EnumDnszoneupdate.
        /// </summary>
        [EnumMember(Value = "dns.zone.update")]
        EnumDnszoneupdate,

        /// <summary>
        /// EnumDnszonetaskdelete.
        /// </summary>
        [EnumMember(Value = "dns.zone.task.delete")]
        EnumDnszonetaskdelete,

        /// <summary>
        /// EnumDnszonecreate.
        /// </summary>
        [EnumMember(Value = "dns.zone.create")]
        EnumDnszonecreate,

        /// <summary>
        /// EnumDnszonerecorddelete.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.delete")]
        EnumDnszonerecorddelete,

        /// <summary>
        /// EnumDnszonerecordcertgenerate.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.cert.generate")]
        EnumDnszonerecordcertgenerate,

        /// <summary>
        /// EnumDnszonerecordcertgenerateauto.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.cert.generate.auto")]
        EnumDnszonerecordcertgenerateauto,

        /// <summary>
        /// EnumDnszonerecordtaskcertgenerate.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.task.cert.generate")]
        EnumDnszonerecordtaskcertgenerate,

        /// <summary>
        /// EnumDnszonerecordupdate.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.update")]
        EnumDnszonerecordupdate,

        /// <summary>
        /// EnumDnszonerecordtaskdelete.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.task.delete")]
        EnumDnszonerecordtaskdelete,

        /// <summary>
        /// EnumDnszonerecordcreate.
        /// </summary>
        [EnumMember(Value = "dns.zone.record.create")]
        EnumDnszonerecordcreate,

        /// <summary>
        /// EnumStackupdate.
        /// </summary>
        [EnumMember(Value = "stack.update")]
        EnumStackupdate,

        /// <summary>
        /// EnumStacktaskdelete.
        /// </summary>
        [EnumMember(Value = "stack.task.delete")]
        EnumStacktaskdelete,

        /// <summary>
        /// EnumStackcreate.
        /// </summary>
        [EnumMember(Value = "stack.create")]
        EnumStackcreate,

        /// <summary>
        /// EnumStacktaskprune.
        /// </summary>
        [EnumMember(Value = "stack.task.prune")]
        EnumStacktaskprune,

        /// <summary>
        /// EnumStackprune.
        /// </summary>
        [EnumMember(Value = "stack.prune")]
        EnumStackprune,

        /// <summary>
        /// EnumStackbuildcreate.
        /// </summary>
        [EnumMember(Value = "stack.build.create")]
        EnumStackbuildcreate,

        /// <summary>
        /// EnumStackbuildgenerate.
        /// </summary>
        [EnumMember(Value = "stack.build.generate")]
        EnumStackbuildgenerate,

        /// <summary>
        /// EnumStackbuilddeploy.
        /// </summary>
        [EnumMember(Value = "stack.build.deploy")]
        EnumStackbuilddeploy,

        /// <summary>
        /// EnumStackbuilddelete.
        /// </summary>
        [EnumMember(Value = "stack.build.delete")]
        EnumStackbuilddelete,

        /// <summary>
        /// EnumStackbuildtaskdelete.
        /// </summary>
        [EnumMember(Value = "stack.build.task.delete")]
        EnumStackbuildtaskdelete,

        /// <summary>
        /// EnumStackbuildtaskgenerate.
        /// </summary>
        [EnumMember(Value = "stack.build.task.generate")]
        EnumStackbuildtaskgenerate,

        /// <summary>
        /// EnumStackbuildtaskdeploy.
        /// </summary>
        [EnumMember(Value = "stack.build.task.deploy")]
        EnumStackbuildtaskdeploy,

        /// <summary>
        /// EnumInfrastructureproviderupdate.
        /// </summary>
        [EnumMember(Value = "infrastructure.provider.update")]
        EnumInfrastructureproviderupdate,

        /// <summary>
        /// EnumInfrastructureprovidertaskdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.provider.task.delete")]
        EnumInfrastructureprovidertaskdelete,

        /// <summary>
        /// EnumInfrastructureprovidercreate.
        /// </summary>
        [EnumMember(Value = "infrastructure.provider.create")]
        EnumInfrastructureprovidercreate,

        /// <summary>
        /// EnumInfrastructureprovidertaskverify.
        /// </summary>
        [EnumMember(Value = "infrastructure.provider.task.verify")]
        EnumInfrastructureprovidertaskverify,

        /// <summary>
        /// EnumInfrastructureservertaskdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.task.delete")]
        EnumInfrastructureservertaskdelete,

        /// <summary>
        /// EnumInfrastructureservertaskrestart.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.task.restart")]
        EnumInfrastructureservertaskrestart,

        /// <summary>
        /// EnumInfrastructureserverservicessftpauth.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.services.sftp.auth")]
        EnumInfrastructureserverservicessftpauth,

        /// <summary>
        /// EnumInfrastructureserverlive.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.live")]
        EnumInfrastructureserverlive,

        /// <summary>
        /// EnumInfrastructureserverdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.delete")]
        EnumInfrastructureserverdelete,

        /// <summary>
        /// EnumInfrastructureserverrestart.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.restart")]
        EnumInfrastructureserverrestart,

        /// <summary>
        /// EnumInfrastructureservercomputerestart.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.compute.restart")]
        EnumInfrastructureservercomputerestart,

        /// <summary>
        /// EnumInfrastructureservercomputespawnerrestart.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.compute.spawner.restart")]
        EnumInfrastructureservercomputespawnerrestart,

        /// <summary>
        /// EnumInfrastructureserverfeaturesreconfigure.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.features.reconfigure")]
        EnumInfrastructureserverfeaturesreconfigure,

        /// <summary>
        /// EnumInfrastructureserversharedfsreconfigure.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.sharedfs.reconfigure")]
        EnumInfrastructureserversharedfsreconfigure,

        /// <summary>
        /// EnumInfrastructureserverprovision.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.provision")]
        EnumInfrastructureserverprovision,

        /// <summary>
        /// EnumInfrastructureserverconsole.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.console")]
        EnumInfrastructureserverconsole,

        /// <summary>
        /// EnumInfrastructureserverupdate.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.update")]
        EnumInfrastructureserverupdate,

        /// <summary>
        /// EnumInfrastructureservertaskprovision.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.task.provision")]
        EnumInfrastructureservertaskprovision,

        /// <summary>
        /// EnumInfrastructureserversshtoken.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.ssh.token")]
        EnumInfrastructureserversshtoken,

        /// <summary>
        /// EnumInfrastructureservertaskfeaturesreconfigure.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.task.features.reconfigure")]
        EnumInfrastructureservertaskfeaturesreconfigure,

        /// <summary>
        /// EnumInfrastructureservertasksharedfsreconfigure.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.task.sharedfs.reconfigure")]
        EnumInfrastructureservertasksharedfsreconfigure,

        /// <summary>
        /// EnumInfrastructureserverservicessftplockdown.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.services.sftp.lockdown")]
        EnumInfrastructureserverservicessftplockdown,

        /// <summary>
        /// EnumInfrastructureserverservicesinternalapithrottle.
        /// </summary>
        [EnumMember(Value = "infrastructure.server.services.internal-api.throttle")]
        EnumInfrastructureserverservicesinternalapithrottle,

        /// <summary>
        /// EnumInfrastructureautoscalegroupcreate.
        /// </summary>
        [EnumMember(Value = "infrastructure.autoscale.group.create")]
        EnumInfrastructureautoscalegroupcreate,

        /// <summary>
        /// EnumInfrastructureautoscalegroupupdate.
        /// </summary>
        [EnumMember(Value = "infrastructure.autoscale.group.update")]
        EnumInfrastructureautoscalegroupupdate,

        /// <summary>
        /// EnumInfrastructureautoscalegrouptaskdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.autoscale.group.task.delete")]
        EnumInfrastructureautoscalegrouptaskdelete,

        /// <summary>
        /// EnumInfrastructureautoscalegroupdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.autoscale.group.delete")]
        EnumInfrastructureautoscalegroupdelete,

        /// <summary>
        /// EnumInfrastructureipspooltaskdelete.
        /// </summary>
        [EnumMember(Value = "infrastructure.ips.pool.task.delete")]
        EnumInfrastructureipspooltaskdelete,

        /// <summary>
        /// EnumSdnnetworkupdate.
        /// </summary>
        [EnumMember(Value = "sdn.network.update")]
        EnumSdnnetworkupdate,

        /// <summary>
        /// EnumSdnnetworktaskdelete.
        /// </summary>
        [EnumMember(Value = "sdn.network.task.delete")]
        EnumSdnnetworktaskdelete,

        /// <summary>
        /// EnumSdnnetworkcreate.
        /// </summary>
        [EnumMember(Value = "sdn.network.create")]
        EnumSdnnetworkcreate,

        /// <summary>
        /// EnumSdnnetworktaskreconfigure.
        /// </summary>
        [EnumMember(Value = "sdn.network.task.reconfigure")]
        EnumSdnnetworktaskreconfigure,

        /// <summary>
        /// EnumPipelinedelete.
        /// </summary>
        [EnumMember(Value = "pipeline.delete")]
        EnumPipelinedelete,

        /// <summary>
        /// EnumPipelinetrigger.
        /// </summary>
        [EnumMember(Value = "pipeline.trigger")]
        EnumPipelinetrigger,

        /// <summary>
        /// EnumPipelineupdate.
        /// </summary>
        [EnumMember(Value = "pipeline.update")]
        EnumPipelineupdate,

        /// <summary>
        /// EnumPipelinetaskdelete.
        /// </summary>
        [EnumMember(Value = "pipeline.task.delete")]
        EnumPipelinetaskdelete,

        /// <summary>
        /// EnumPipelinecreate.
        /// </summary>
        [EnumMember(Value = "pipeline.create")]
        EnumPipelinecreate,

        /// <summary>
        /// EnumPipelinetasktrigger.
        /// </summary>
        [EnumMember(Value = "pipeline.task.trigger")]
        EnumPipelinetasktrigger,

        /// <summary>
        /// EnumPipelineruncompleted.
        /// </summary>
        [EnumMember(Value = "pipeline.run.completed")]
        EnumPipelineruncompleted,

        /// <summary>
        /// EnumPipelinekeyupdate.
        /// </summary>
        [EnumMember(Value = "pipeline.key.update")]
        EnumPipelinekeyupdate,

        /// <summary>
        /// EnumPipelinekeydelete.
        /// </summary>
        [EnumMember(Value = "pipeline.key.delete")]
        EnumPipelinekeydelete,

        /// <summary>
        /// EnumPipelinekeycreate.
        /// </summary>
        [EnumMember(Value = "pipeline.key.create")]
        EnumPipelinekeycreate
    }
}