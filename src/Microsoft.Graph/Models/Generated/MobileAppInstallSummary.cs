// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mobile App Install Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppInstallSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets installed device count.
        /// Number of Devices that have successfully installed this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed device count.
        /// Number of Devices that have failed to install this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Number of Devices that are not applicable for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed device count.
        /// Number of Devices that does not have this app installed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notInstalledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotInstalledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets pending install device count.
        /// Number of Devices that have been notified to install this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingInstallDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingInstallDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets installed user count.
        /// Number of Users whose devices have all succeeded to install this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstalledUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed user count.
        /// Number of Users that have 1 or more device that failed to install this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable user count.
        /// Number of Users whose devices were all not applicable for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets not installed user count.
        /// Number of Users that have 1 or more devices that did not install this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notInstalledUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotInstalledUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets pending install user count.
        /// Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingInstallUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PendingInstallUserCount { get; set; }
    
    }
}

