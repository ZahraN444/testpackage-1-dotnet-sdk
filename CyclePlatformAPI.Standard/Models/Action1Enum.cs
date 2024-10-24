// <copyright file="Action1Enum.cs" company="APIMatic">
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
    /// Action1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Action1Enum
    {
        /// <summary>
        /// EnumEnvironmentcreate.
        /// </summary>
        [EnumMember(Value = "environment.create")]
        EnumEnvironmentcreate,

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
        /// EnumEnvironmentdelete.
        /// </summary>
        [EnumMember(Value = "environment.delete")]
        EnumEnvironmentdelete,

        /// <summary>
        /// EnumEnvironmentdeploymentsprune.
        /// </summary>
        [EnumMember(Value = "environment.deployments.prune")]
        EnumEnvironmentdeploymentsprune,

        /// <summary>
        /// EnumEnvironmentdeploymentstag.
        /// </summary>
        [EnumMember(Value = "environment.deployments.tag")]
        EnumEnvironmentdeploymentstag,

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
        /// EnumEnvironmentdeploymenthealthywatch.
        /// </summary>
        [EnumMember(Value = "environment.deployment.healthy.watch")]
        EnumEnvironmentdeploymenthealthywatch,

        /// <summary>
        /// EnumImagesourcecreate.
        /// </summary>
        [EnumMember(Value = "image.source.create")]
        EnumImagesourcecreate,

        /// <summary>
        /// EnumImagecreate.
        /// </summary>
        [EnumMember(Value = "image.create")]
        EnumImagecreate,

        /// <summary>
        /// EnumImageimport.
        /// </summary>
        [EnumMember(Value = "image.import")]
        EnumImageimport,

        /// <summary>
        /// EnumImagesprune.
        /// </summary>
        [EnumMember(Value = "images.prune")]
        EnumImagesprune,

        /// <summary>
        /// EnumImagecreateimport.
        /// </summary>
        [EnumMember(Value = "image.create-import")]
        EnumImagecreateimport,

        /// <summary>
        /// EnumContainercreate.
        /// </summary>
        [EnumMember(Value = "container.create")]
        EnumContainercreate,

        /// <summary>
        /// EnumContainerreimage.
        /// </summary>
        [EnumMember(Value = "container.reimage")]
        EnumContainerreimage,

        /// <summary>
        /// EnumContainerstart.
        /// </summary>
        [EnumMember(Value = "container.start")]
        EnumContainerstart,

        /// <summary>
        /// EnumContainerstop.
        /// </summary>
        [EnumMember(Value = "container.stop")]
        EnumContainerstop,

        /// <summary>
        /// EnumContainerrestart.
        /// </summary>
        [EnumMember(Value = "container.restart")]
        EnumContainerrestart,

        /// <summary>
        /// EnumContainerdelete.
        /// </summary>
        [EnumMember(Value = "container.delete")]
        EnumContainerdelete,

        /// <summary>
        /// EnumStackbuildcreate.
        /// </summary>
        [EnumMember(Value = "stack.build.create")]
        EnumStackbuildcreate,

        /// <summary>
        /// EnumStackbuilddeploy.
        /// </summary>
        [EnumMember(Value = "stack.build.deploy")]
        EnumStackbuilddeploy,

        /// <summary>
        /// EnumStackbuildgenerate.
        /// </summary>
        [EnumMember(Value = "stack.build.generate")]
        EnumStackbuildgenerate,

        /// <summary>
        /// EnumStackprune.
        /// </summary>
        [EnumMember(Value = "stack.prune")]
        EnumStackprune,

        /// <summary>
        /// Sleep.
        /// </summary>
        [EnumMember(Value = "sleep")]
        Sleep,

        /// <summary>
        /// EnumWebhookpost.
        /// </summary>
        [EnumMember(Value = "webhook.post")]
        EnumWebhookpost,

        /// <summary>
        /// EnumWebhookget.
        /// </summary>
        [EnumMember(Value = "webhook.get")]
        EnumWebhookget
    }
}