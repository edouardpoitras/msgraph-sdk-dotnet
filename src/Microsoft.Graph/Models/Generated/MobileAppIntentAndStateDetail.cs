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
    /// The type MobileAppIntentAndStateDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MobileAppIntentAndStateDetail
    {

        /// <summary>
        /// Gets or sets applicationId.
        /// MobieApp identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The admin provided or imported title of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets mobileAppIntent.
        /// Mobile App Intent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobileAppIntent", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppIntent? MobileAppIntent { get; set; }
    
        /// <summary>
        /// Gets or sets displayVersion.
        /// Human readable version of the application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayVersion", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayVersion { get; set; }
    
        /// <summary>
        /// Gets or sets installState.
        /// The install state of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installState", Required = Newtonsoft.Json.Required.Default)]
        public ResultantAppState? InstallState { get; set; }
    
        /// <summary>
        /// Gets or sets supportedDeviceTypes.
        /// The supported platforms for the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedDeviceTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MobileAppSupportedDeviceType> SupportedDeviceTypes { get; set; }
    
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
