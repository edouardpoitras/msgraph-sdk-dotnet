// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceManagementSettings
    {

        /// <summary>
        /// Gets or sets deviceComplianceCheckinThresholdDays.
        /// The number of days a device is allowed to go without checking in to remain compliant. Valid values 0 to 120
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceComplianceCheckinThresholdDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceComplianceCheckinThresholdDays { get; set; }
    
        /// <summary>
        /// Gets or sets isScheduledActionEnabled.
        /// Is feature enabled or not for scheduled action for rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isScheduledActionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsScheduledActionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets secureByDefault.
        /// Device should be noncompliant when there is no compliance policy targeted when this is true
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureByDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecureByDefault { get; set; }
    
        /// <summary>
        /// Gets or sets enhancedJailBreak.
        /// Is feature enabled or not for enhanced jailbreak detection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enhancedJailBreak", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnhancedJailBreak { get; set; }
    
        /// <summary>
        /// Gets or sets deviceInactivityBeforeRetirementInDay.
        /// When the device does not check in for specified number of days, the company data might be removed and the device will not be under management. Valid values 30 to 270
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceInactivityBeforeRetirementInDay", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceInactivityBeforeRetirementInDay { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
