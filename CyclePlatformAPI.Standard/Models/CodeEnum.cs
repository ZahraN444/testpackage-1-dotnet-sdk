// <copyright file="CodeEnum.cs" company="APIMatic">
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
    /// CodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// Enum400invalidSyntax.
        /// </summary>
        [EnumMember(Value = "400.invalid_syntax")]
        Enum400invalidSyntax,

        /// <summary>
        /// Enum401authInvalid.
        /// </summary>
        [EnumMember(Value = "401.auth_invalid")]
        Enum401authInvalid,

        /// <summary>
        /// Enum401authExpired.
        /// </summary>
        [EnumMember(Value = "401.auth_expired")]
        Enum401authExpired,

        /// <summary>
        /// Enum401noCookie.
        /// </summary>
        [EnumMember(Value = "401.no_cookie")]
        Enum401noCookie,

        /// <summary>
        /// Enum401unauthorizedApplication.
        /// </summary>
        [EnumMember(Value = "401.unauthorized_application")]
        Enum401unauthorizedApplication,

        /// <summary>
        /// Enum403mismatch.
        /// </summary>
        [EnumMember(Value = "403.mismatch")]
        Enum403mismatch,

        /// <summary>
        /// Enum403wrongHub.
        /// </summary>
        [EnumMember(Value = "403.wrong_hub")]
        Enum403wrongHub,

        /// <summary>
        /// Enum403notReady.
        /// </summary>
        [EnumMember(Value = "403.not_ready")]
        Enum403notReady,

        /// <summary>
        /// Enum403expired.
        /// </summary>
        [EnumMember(Value = "403.expired")]
        Enum403expired,

        /// <summary>
        /// Enum403restrictedPortal.
        /// </summary>
        [EnumMember(Value = "403.restricted_portal")]
        Enum403restrictedPortal,

        /// <summary>
        /// Enum403permissions.
        /// </summary>
        [EnumMember(Value = "403.permissions")]
        Enum403permissions,

        /// <summary>
        /// Enum403wrongScope.
        /// </summary>
        [EnumMember(Value = "403.wrong_scope")]
        Enum403wrongScope,

        /// <summary>
        /// Enum403invalidIp.
        /// </summary>
        [EnumMember(Value = "403.invalid_ip")]
        Enum403invalidIp,

        /// <summary>
        /// Enum403invalidState.
        /// </summary>
        [EnumMember(Value = "403.invalid_state")]
        Enum403invalidState,

        /// <summary>
        /// Enum403notApproved.
        /// </summary>
        [EnumMember(Value = "403.not_approved")]
        Enum403notApproved,

        /// <summary>
        /// Enum403notAllowed.
        /// </summary>
        [EnumMember(Value = "403.not_allowed")]
        Enum403notAllowed,

        /// <summary>
        /// Enum403platformDisabled.
        /// </summary>
        [EnumMember(Value = "403.platform_disabled")]
        Enum403platformDisabled,

        /// <summary>
        /// Enum4032faRequired.
        /// </summary>
        [EnumMember(Value = "403.2fa_required")]
        Enum4032faRequired,

        /// <summary>
        /// Enum4032faFailed.
        /// </summary>
        [EnumMember(Value = "403.2fa_failed")]
        Enum4032faFailed,

        /// <summary>
        /// Enum403newApplicationCapabilities.
        /// </summary>
        [EnumMember(Value = "403.new_application_capabilities")]
        Enum403newApplicationCapabilities,

        /// <summary>
        /// Enum403tierRestricted.
        /// </summary>
        [EnumMember(Value = "403.tier_restricted")]
        Enum403tierRestricted,

        /// <summary>
        /// Enum404hub.
        /// </summary>
        [EnumMember(Value = "404.hub")]
        Enum404hub,

        /// <summary>
        /// Enum404hubinvitation.
        /// </summary>
        [EnumMember(Value = "404.hub.invitation")]
        Enum404hubinvitation,

        /// <summary>
        /// Enum404sdnNetwork.
        /// </summary>
        [EnumMember(Value = "404.sdn_network")]
        Enum404sdnNetwork,

        /// <summary>
        /// Enum404environment.
        /// </summary>
        [EnumMember(Value = "404.environment")]
        Enum404environment,

        /// <summary>
        /// Enum404environmentscopedvariable.
        /// </summary>
        [EnumMember(Value = "404.environment.scoped-variable")]
        Enum404environmentscopedvariable,

        /// <summary>
        /// Enum404hubapiKey.
        /// </summary>
        [EnumMember(Value = "404.hub.api_key")]
        Enum404hubapiKey,

        /// <summary>
        /// Enum404hubprovider.
        /// </summary>
        [EnumMember(Value = "404.hub.provider")]
        Enum404hubprovider,

        /// <summary>
        /// Enum404hubintegration.
        /// </summary>
        [EnumMember(Value = "404.hub.integration")]
        Enum404hubintegration,

        /// <summary>
        /// Enum404uri.
        /// </summary>
        [EnumMember(Value = "404.uri")]
        Enum404uri,

        /// <summary>
        /// Enum404provider.
        /// </summary>
        [EnumMember(Value = "404.provider")]
        Enum404provider,

        /// <summary>
        /// Enum404stack.
        /// </summary>
        [EnumMember(Value = "404.stack")]
        Enum404stack,

        /// <summary>
        /// Enum404survey.
        /// </summary>
        [EnumMember(Value = "404.survey")]
        Enum404survey,

        /// <summary>
        /// Enum404surveyResponse.
        /// </summary>
        [EnumMember(Value = "404.survey_response")]
        Enum404surveyResponse,

        /// <summary>
        /// Enum404notification.
        /// </summary>
        [EnumMember(Value = "404.notification")]
        Enum404notification,

        /// <summary>
        /// Enum404stackBuild.
        /// </summary>
        [EnumMember(Value = "404.stack_build")]
        Enum404stackBuild,

        /// <summary>
        /// Enum404image.
        /// </summary>
        [EnumMember(Value = "404.image")]
        Enum404image,

        /// <summary>
        /// Enum404imagesource.
        /// </summary>
        [EnumMember(Value = "404.image.source")]
        Enum404imagesource,

        /// <summary>
        /// Enum404imagebuildLog.
        /// </summary>
        [EnumMember(Value = "404.image.build_log")]
        Enum404imagebuildLog,

        /// <summary>
        /// Enum404job.
        /// </summary>
        [EnumMember(Value = "404.job")]
        Enum404job,

        /// <summary>
        /// Enum404billingorder.
        /// </summary>
        [EnumMember(Value = "404.billing.order")]
        Enum404billingorder,

        /// <summary>
        /// Enum404billingservice.
        /// </summary>
        [EnumMember(Value = "404.billing.service")]
        Enum404billingservice,

        /// <summary>
        /// Enum404billingcredit.
        /// </summary>
        [EnumMember(Value = "404.billing.credit")]
        Enum404billingcredit,

        /// <summary>
        /// Enum404billinginvoice.
        /// </summary>
        [EnumMember(Value = "404.billing.invoice")]
        Enum404billinginvoice,

        /// <summary>
        /// Enum404billingtier.
        /// </summary>
        [EnumMember(Value = "404.billing.tier")]
        Enum404billingtier,

        /// <summary>
        /// Enum404billingsupport.
        /// </summary>
        [EnumMember(Value = "404.billing.support")]
        Enum404billingsupport,

        /// <summary>
        /// Enum404billingpaymentMethod.
        /// </summary>
        [EnumMember(Value = "404.billing.payment_method")]
        Enum404billingpaymentMethod,

        /// <summary>
        /// Enum404billingpromoCode.
        /// </summary>
        [EnumMember(Value = "404.billing.promo_code")]
        Enum404billingpromoCode,

        /// <summary>
        /// Enum404node.
        /// </summary>
        [EnumMember(Value = "404.node")]
        Enum404node,

        /// <summary>
        /// Enum404infrastructurelocation.
        /// </summary>
        [EnumMember(Value = "404.infrastructure.location")]
        Enum404infrastructurelocation,

        /// <summary>
        /// Enum404infrastructureipspool.
        /// </summary>
        [EnumMember(Value = "404.infrastructure.ips.pool")]
        Enum404infrastructureipspool,

        /// <summary>
        /// Enum404infrastructureprovider.
        /// </summary>
        [EnumMember(Value = "404.infrastructure.provider")]
        Enum404infrastructureprovider,

        /// <summary>
        /// Enum404infrastructureserver.
        /// </summary>
        [EnumMember(Value = "404.infrastructure.server")]
        Enum404infrastructureserver,

        /// <summary>
        /// Enum404infrastructuremodel.
        /// </summary>
        [EnumMember(Value = "404.infrastructure.model")]
        Enum404infrastructuremodel,

        /// <summary>
        /// Enum404account.
        /// </summary>
        [EnumMember(Value = "404.account")]
        Enum404account,

        /// <summary>
        /// Enum404container.
        /// </summary>
        [EnumMember(Value = "404.container")]
        Enum404container,

        /// <summary>
        /// Enum404containerbackup.
        /// </summary>
        [EnumMember(Value = "404.container.backup")]
        Enum404containerbackup,

        /// <summary>
        /// Enum404vpnAccount.
        /// </summary>
        [EnumMember(Value = "404.vpn_account")]
        Enum404vpnAccount,

        /// <summary>
        /// Enum404instance.
        /// </summary>
        [EnumMember(Value = "404.instance")]
        Enum404instance,

        /// <summary>
        /// Enum404pipeline.
        /// </summary>
        [EnumMember(Value = "404.pipeline")]
        Enum404pipeline,

        /// <summary>
        /// Enum404pipelinerun.
        /// </summary>
        [EnumMember(Value = "404.pipeline.run")]
        Enum404pipelinerun,

        /// <summary>
        /// Enum404pipelinekey.
        /// </summary>
        [EnumMember(Value = "404.pipeline.key")]
        Enum404pipelinekey,

        /// <summary>
        /// Enum404dnszone.
        /// </summary>
        [EnumMember(Value = "404.dns.zone")]
        Enum404dnszone,

        /// <summary>
        /// Enum404dnsrecord.
        /// </summary>
        [EnumMember(Value = "404.dns.record")]
        Enum404dnsrecord,

        /// <summary>
        /// Enum404cluster.
        /// </summary>
        [EnumMember(Value = "404.cluster")]
        Enum404cluster,

        /// <summary>
        /// Enum404platformBuild.
        /// </summary>
        [EnumMember(Value = "404.platform_build")]
        Enum404platformBuild,

        /// <summary>
        /// Enum404cycleosBuild.
        /// </summary>
        [EnumMember(Value = "404.cycleos_build")]
        Enum404cycleosBuild,

        /// <summary>
        /// Enum404emailVerification.
        /// </summary>
        [EnumMember(Value = "404.email_verification")]
        Enum404emailVerification,

        /// <summary>
        /// Enum404hubmembership.
        /// </summary>
        [EnumMember(Value = "404.hub.membership")]
        Enum404hubmembership,

        /// <summary>
        /// Enum404announcement.
        /// </summary>
        [EnumMember(Value = "404.announcement")]
        Enum404announcement,

        /// <summary>
        /// Enum404haServiceSession.
        /// </summary>
        [EnumMember(Value = "404.ha_service_session")]
        Enum404haServiceSession,

        /// <summary>
        /// Enum404salesLead.
        /// </summary>
        [EnumMember(Value = "404.sales_lead")]
        Enum404salesLead,

        /// <summary>
        /// Enum409duplicateFound.
        /// </summary>
        [EnumMember(Value = "409.duplicate_found")]
        Enum409duplicateFound,

        /// <summary>
        /// Enum415invalidContentType.
        /// </summary>
        [EnumMember(Value = "415.invalid_content_type")]
        Enum415invalidContentType,

        /// <summary>
        /// Enum422missingArgument.
        /// </summary>
        [EnumMember(Value = "422.missing_argument")]
        Enum422missingArgument,

        /// <summary>
        /// Enum422invalidArgument.
        /// </summary>
        [EnumMember(Value = "422.invalid_argument")]
        Enum422invalidArgument,

        /// <summary>
        /// Enum422invalidInput.
        /// </summary>
        [EnumMember(Value = "422.invalid_input")]
        Enum422invalidInput,

        /// <summary>
        /// Enum422maxExceeded.
        /// </summary>
        [EnumMember(Value = "422.max_exceeded")]
        Enum422maxExceeded,

        /// <summary>
        /// Enum422notCompatible.
        /// </summary>
        [EnumMember(Value = "422.not_compatible")]
        Enum422notCompatible,

        /// <summary>
        /// Enum422alreadyExists.
        /// </summary>
        [EnumMember(Value = "422.already_exists")]
        Enum422alreadyExists,

        /// <summary>
        /// Enum429rateLimiting.
        /// </summary>
        [EnumMember(Value = "429.rate_limiting")]
        Enum429rateLimiting,

        /// <summary>
        /// Enum500database.
        /// </summary>
        [EnumMember(Value = "500.database")]
        Enum500database,

        /// <summary>
        /// Enum500databaseInsert.
        /// </summary>
        [EnumMember(Value = "500.database_insert")]
        Enum500databaseInsert,

        /// <summary>
        /// Enum500databaseUpdate.
        /// </summary>
        [EnumMember(Value = "500.database_update")]
        Enum500databaseUpdate,

        /// <summary>
        /// Enum500databaseRemove.
        /// </summary>
        [EnumMember(Value = "500.database_remove")]
        Enum500databaseRemove,

        /// <summary>
        /// Enum500jobd.
        /// </summary>
        [EnumMember(Value = "500.jobd")]
        Enum500jobd,

        /// <summary>
        /// Enum500unknown.
        /// </summary>
        [EnumMember(Value = "500.unknown")]
        Enum500unknown,

        /// <summary>
        /// Enum500dev.
        /// </summary>
        [EnumMember(Value = "500.dev")]
        Enum500dev,

        /// <summary>
        /// Enum500email.
        /// </summary>
        [EnumMember(Value = "500.email")]
        Enum500email,

        /// <summary>
        /// Enum500paymentGateway.
        /// </summary>
        [EnumMember(Value = "500.payment_gateway")]
        Enum500paymentGateway,

        /// <summary>
        /// Enum503notReady.
        /// </summary>
        [EnumMember(Value = "503.not_ready")]
        Enum503notReady,

        /// <summary>
        /// Enum503notEnabled.
        /// </summary>
        [EnumMember(Value = "503.not_enabled")]
        Enum503notEnabled,

        /// <summary>
        /// Enum503dependencyNotEnabled.
        /// </summary>
        [EnumMember(Value = "503.dependency_not_enabled")]
        Enum503dependencyNotEnabled
    }
}