// <copyright file="Capability1Enum.cs" company="APIMatic">
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
    /// Capability1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Capability1Enum
    {
        /// <summary>
        /// Apikeysmanage.
        /// </summary>
        [EnumMember(Value = "api-keys-manage")]
        Apikeysmanage,

        /// <summary>
        /// Apionlyjobsview.
        /// </summary>
        [EnumMember(Value = "apionly-jobs-view")]
        Apionlyjobsview,

        /// <summary>
        /// Apionlynotificationslisten.
        /// </summary>
        [EnumMember(Value = "apionly-notifications-listen")]
        Apionlynotificationslisten,

        /// <summary>
        /// Autoscalegroupsmanage.
        /// </summary>
        [EnumMember(Value = "autoscale-groups-manage")]
        Autoscalegroupsmanage,

        /// <summary>
        /// Autoscalegroupsview.
        /// </summary>
        [EnumMember(Value = "autoscale-groups-view")]
        Autoscalegroupsview,

        /// <summary>
        /// Billingcreditsview.
        /// </summary>
        [EnumMember(Value = "billing-credits-view")]
        Billingcreditsview,

        /// <summary>
        /// Billinginvoicespay.
        /// </summary>
        [EnumMember(Value = "billing-invoices-pay")]
        Billinginvoicespay,

        /// <summary>
        /// Billinginvoicesview.
        /// </summary>
        [EnumMember(Value = "billing-invoices-view")]
        Billinginvoicesview,

        /// <summary>
        /// Billingmethodsmanage.
        /// </summary>
        [EnumMember(Value = "billing-methods-manage")]
        Billingmethodsmanage,

        /// <summary>
        /// Billingservicesmanage.
        /// </summary>
        [EnumMember(Value = "billing-services-manage")]
        Billingservicesmanage,

        /// <summary>
        /// Billingservicesview.
        /// </summary>
        [EnumMember(Value = "billing-services-view")]
        Billingservicesview,

        /// <summary>
        /// Containersbackupsmanage.
        /// </summary>
        [EnumMember(Value = "containers-backups-manage")]
        Containersbackupsmanage,

        /// <summary>
        /// Containersbackupsview.
        /// </summary>
        [EnumMember(Value = "containers-backups-view")]
        Containersbackupsview,

        /// <summary>
        /// Containersconsole.
        /// </summary>
        [EnumMember(Value = "containers-console")]
        Containersconsole,

        /// <summary>
        /// Containersdeploy.
        /// </summary>
        [EnumMember(Value = "containers-deploy")]
        Containersdeploy,

        /// <summary>
        /// Containersinstancesmigrate.
        /// </summary>
        [EnumMember(Value = "containers-instances-migrate")]
        Containersinstancesmigrate,

        /// <summary>
        /// Containerslock.
        /// </summary>
        [EnumMember(Value = "containers-lock")]
        Containerslock,

        /// <summary>
        /// Containersssh.
        /// </summary>
        [EnumMember(Value = "containers-ssh")]
        Containersssh,

        /// <summary>
        /// Containersmanage.
        /// </summary>
        [EnumMember(Value = "containers-manage")]
        Containersmanage,

        /// <summary>
        /// Containersview.
        /// </summary>
        [EnumMember(Value = "containers-view")]
        Containersview,

        /// <summary>
        /// Containersvolumesmanage.
        /// </summary>
        [EnumMember(Value = "containers-volumes-manage")]
        Containersvolumesmanage,

        /// <summary>
        /// Containersvolumesview.
        /// </summary>
        [EnumMember(Value = "containers-volumes-view")]
        Containersvolumesview,

        /// <summary>
        /// Dnscertsview.
        /// </summary>
        [EnumMember(Value = "dns-certs-view")]
        Dnscertsview,

        /// <summary>
        /// Dnsmanage.
        /// </summary>
        [EnumMember(Value = "dns-manage")]
        Dnsmanage,

        /// <summary>
        /// Dnsview.
        /// </summary>
        [EnumMember(Value = "dns-view")]
        Dnsview,

        /// <summary>
        /// Environmentsdeploymentsmanage.
        /// </summary>
        [EnumMember(Value = "environments-deployments-manage")]
        Environmentsdeploymentsmanage,

        /// <summary>
        /// Environmentsmanage.
        /// </summary>
        [EnumMember(Value = "environments-manage")]
        Environmentsmanage,

        /// <summary>
        /// Environmentsscopedvariablesmanage.
        /// </summary>
        [EnumMember(Value = "environments-scopedvariables-manage")]
        Environmentsscopedvariablesmanage,

        /// <summary>
        /// Environmentsscopedvariablesview.
        /// </summary>
        [EnumMember(Value = "environments-scopedvariables-view")]
        Environmentsscopedvariablesview,

        /// <summary>
        /// Environmentsservicesmanage.
        /// </summary>
        [EnumMember(Value = "environments-services-manage")]
        Environmentsservicesmanage,

        /// <summary>
        /// Environmentsview.
        /// </summary>
        [EnumMember(Value = "environments-view")]
        Environmentsview,

        /// <summary>
        /// Environmentsvpn.
        /// </summary>
        [EnumMember(Value = "environments-vpn")]
        Environmentsvpn,

        /// <summary>
        /// Environmentsvpnmanage.
        /// </summary>
        [EnumMember(Value = "environments-vpn-manage")]
        Environmentsvpnmanage,

        /// <summary>
        /// Hubsdelete.
        /// </summary>
        [EnumMember(Value = "hubs-delete")]
        Hubsdelete,

        /// <summary>
        /// Hubsintegrationsmanage.
        /// </summary>
        [EnumMember(Value = "hubs-integrations-manage")]
        Hubsintegrationsmanage,

        /// <summary>
        /// Hubsintegrationsview.
        /// </summary>
        [EnumMember(Value = "hubs-integrations-view")]
        Hubsintegrationsview,

        /// <summary>
        /// Hubsinvitesmanage.
        /// </summary>
        [EnumMember(Value = "hubs-invites-manage")]
        Hubsinvitesmanage,

        /// <summary>
        /// Hubsinvitessend.
        /// </summary>
        [EnumMember(Value = "hubs-invites-send")]
        Hubsinvitessend,

        /// <summary>
        /// Hubsmembersmanage.
        /// </summary>
        [EnumMember(Value = "hubs-members-manage")]
        Hubsmembersmanage,

        /// <summary>
        /// Hubsmembersview.
        /// </summary>
        [EnumMember(Value = "hubs-members-view")]
        Hubsmembersview,

        /// <summary>
        /// Hubsrolesmanage.
        /// </summary>
        [EnumMember(Value = "hubs-roles-manage")]
        Hubsrolesmanage,

        /// <summary>
        /// Hubsrolesview.
        /// </summary>
        [EnumMember(Value = "hubs-roles-view")]
        Hubsrolesview,

        /// <summary>
        /// Hubsusageview.
        /// </summary>
        [EnumMember(Value = "hubs-usage-view")]
        Hubsusageview,

        /// <summary>
        /// Hubsupdate.
        /// </summary>
        [EnumMember(Value = "hubs-update")]
        Hubsupdate,

        /// <summary>
        /// Hubsauditlogview.
        /// </summary>
        [EnumMember(Value = "hubs-auditlog-view")]
        Hubsauditlogview,

        /// <summary>
        /// Imagesmanage.
        /// </summary>
        [EnumMember(Value = "images-manage")]
        Imagesmanage,

        /// <summary>
        /// Imagessourcesmanage.
        /// </summary>
        [EnumMember(Value = "images-sources-manage")]
        Imagessourcesmanage,

        /// <summary>
        /// Imagessourcesview.
        /// </summary>
        [EnumMember(Value = "images-sources-view")]
        Imagessourcesview,

        /// <summary>
        /// Imagesview.
        /// </summary>
        [EnumMember(Value = "images-view")]
        Imagesview,

        /// <summary>
        /// Ipsmanage.
        /// </summary>
        [EnumMember(Value = "ips-manage")]
        Ipsmanage,

        /// <summary>
        /// Serversconsole.
        /// </summary>
        [EnumMember(Value = "servers-console")]
        Serversconsole,

        /// <summary>
        /// Serversdecommission.
        /// </summary>
        [EnumMember(Value = "servers-decommission")]
        Serversdecommission,

        /// <summary>
        /// Serverslogin.
        /// </summary>
        [EnumMember(Value = "servers-login")]
        Serverslogin,

        /// <summary>
        /// Serversprovision.
        /// </summary>
        [EnumMember(Value = "servers-provision")]
        Serversprovision,

        /// <summary>
        /// Serversmanage.
        /// </summary>
        [EnumMember(Value = "servers-manage")]
        Serversmanage,

        /// <summary>
        /// Serversview.
        /// </summary>
        [EnumMember(Value = "servers-view")]
        Serversview,

        /// <summary>
        /// Monitormanage.
        /// </summary>
        [EnumMember(Value = "monitor-manage")]
        Monitormanage,

        /// <summary>
        /// Monitorview.
        /// </summary>
        [EnumMember(Value = "monitor-view")]
        Monitorview,

        /// <summary>
        /// Pipelinesmanage.
        /// </summary>
        [EnumMember(Value = "pipelines-manage")]
        Pipelinesmanage,

        /// <summary>
        /// Pipelinestrigger.
        /// </summary>
        [EnumMember(Value = "pipelines-trigger")]
        Pipelinestrigger,

        /// <summary>
        /// Pipelinesview.
        /// </summary>
        [EnumMember(Value = "pipelines-view")]
        Pipelinesview,

        /// <summary>
        /// Sdnnetworksmanage.
        /// </summary>
        [EnumMember(Value = "sdn-networks-manage")]
        Sdnnetworksmanage,

        /// <summary>
        /// Sdnnetworksview.
        /// </summary>
        [EnumMember(Value = "sdn-networks-view")]
        Sdnnetworksview,

        /// <summary>
        /// Securitymanage.
        /// </summary>
        [EnumMember(Value = "security-manage")]
        Securitymanage,

        /// <summary>
        /// Securityview.
        /// </summary>
        [EnumMember(Value = "security-view")]
        Securityview,

        /// <summary>
        /// Stacksbuildsdeploy.
        /// </summary>
        [EnumMember(Value = "stacks-builds-deploy")]
        Stacksbuildsdeploy,

        /// <summary>
        /// Stacksbuildsmanage.
        /// </summary>
        [EnumMember(Value = "stacks-builds-manage")]
        Stacksbuildsmanage,

        /// <summary>
        /// Stacksmanage.
        /// </summary>
        [EnumMember(Value = "stacks-manage")]
        Stacksmanage,

        /// <summary>
        /// Stacksview.
        /// </summary>
        [EnumMember(Value = "stacks-view")]
        Stacksview
    }
}