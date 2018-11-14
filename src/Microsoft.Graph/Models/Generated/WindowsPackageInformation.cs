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
    /// The type WindowsPackageInformation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WindowsPackageInformation
    {

        /// <summary>
        /// Gets or sets applicableArchitecture.
        /// The Windows architecture for which this app can run on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicableArchitecture", Required = Newtonsoft.Json.Required.Default)]
        public WindowsArchitecture? ApplicableArchitecture { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The Display Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets identityName.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityName", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityName { get; set; }
    
        /// <summary>
        /// Gets or sets identityPublisher.
        /// The Identity Publisher.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityPublisher", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityPublisher { get; set; }
    
        /// <summary>
        /// Gets or sets identityResourceIdentifier.
        /// The Identity Resource Identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityResourceIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityResourceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets identityVersion.
        /// The Identity Version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimumSupportedOperatingSystem.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSupportedOperatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
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
