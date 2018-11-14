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
    /// The type Device Enrollment Platform Restrictions Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration
    {
    
        /// <summary>
        /// Gets or sets ios restriction.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction IosRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets windows restriction.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction WindowsRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets windows mobile restriction.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsMobileRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets android restriction.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction AndroidRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets android for work restriction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidForWorkRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction AndroidForWorkRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets mac restriction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction MacRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets mac osrestriction.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macOSRestriction", Required = Newtonsoft.Json.Required.Default)]
        public DeviceEnrollmentPlatformRestriction MacOSRestriction { get; set; }
    
    }
}

