// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeviceEvidence.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DeviceEvidence>))]
    public partial class DeviceEvidence : AlertEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceEvidence"/> class.
        /// </summary>
        public DeviceEvidence()
        {
            this.ODataType = "microsoft.graph.security.deviceEvidence";
        }

        /// <summary>
        /// Gets or sets azureAdDeviceId.
        /// A unique identifier assigned to a device by Azure Active Directory (Azure AD) when device is Azure AD-joined.
        /// </summary>
        [JsonPropertyName("azureAdDeviceId")]
        public string AzureAdDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets defenderAvStatus.
        /// State of the Defender AntiMalware engine. The possible values are: notReporting, disabled, notUpdated, updated, unknown, notSupported, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("defenderAvStatus")]
        public DefenderAvStatus? DefenderAvStatus { get; set; }
    
        /// <summary>
        /// Gets or sets deviceDnsName.
        /// The fully qualified domain name (FQDN) for the device.
        /// </summary>
        [JsonPropertyName("deviceDnsName")]
        public string DeviceDnsName { get; set; }
    
        /// <summary>
        /// Gets or sets firstSeenDateTime.
        /// The date and time when the device was first seen.
        /// </summary>
        [JsonPropertyName("firstSeenDateTime")]
        public DateTimeOffset? FirstSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets healthStatus.
        /// The health state of the device.The possible values are: active, inactive, impairedCommunication, noSensorData, noSensorDataImpairedCommunication, unknown, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("healthStatus")]
        public DeviceHealthStatus? HealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets loggedOnUsers.
        /// Users that were logged on the machine during the time of the alert.
        /// </summary>
        [JsonPropertyName("loggedOnUsers")]
        public IEnumerable<LoggedOnUser> LoggedOnUsers { get; set; }
    
        /// <summary>
        /// Gets or sets mdeDeviceId.
        /// A unique identifier assigned to a device by Microsoft Defender for Endpoint.
        /// </summary>
        [JsonPropertyName("mdeDeviceId")]
        public string MdeDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets onboardingStatus.
        /// The status of the machine onboarding to Microsoft Defender for Endpoint.The possible values are: insufficientInfo, onboarded, canBeOnboarded, unsupported, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("onboardingStatus")]
        public OnboardingStatus? OnboardingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets osBuild.
        /// The build version for the operating system the device is running.
        /// </summary>
        [JsonPropertyName("osBuild")]
        public Int64? OsBuild { get; set; }
    
        /// <summary>
        /// Gets or sets osPlatform.
        /// The operating system platform the device is running.
        /// </summary>
        [JsonPropertyName("osPlatform")]
        public string OsPlatform { get; set; }
    
        /// <summary>
        /// Gets or sets rbacGroupId.
        /// The ID of the role-based access control (RBAC) device group.
        /// </summary>
        [JsonPropertyName("rbacGroupId")]
        public Int32? RbacGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets rbacGroupName.
        /// The name of the RBAC device group.
        /// </summary>
        [JsonPropertyName("rbacGroupName")]
        public string RbacGroupName { get; set; }
    
        /// <summary>
        /// Gets or sets riskScore.
        /// Risk score as evaluated by Microsoft Defender for Endpoint. The possible values are: none, informational, low, medium, high, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskScore")]
        public DeviceRiskScore? RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version of the operating system platform.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets vmMetadata.
        /// Metadata of the virtual machine (VM) on which Microsoft Defender for Endpoint is running.
        /// </summary>
        [JsonPropertyName("vmMetadata")]
        public VmMetadata VmMetadata { get; set; }
    
    }
}