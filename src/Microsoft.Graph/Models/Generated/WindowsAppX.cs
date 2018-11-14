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
    /// The type Windows App X.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsAppX : MobileLobApp
    {
    
        /// <summary>
        /// Gets or sets applicable architectures.
        /// The Windows architecture(s) for which this app can run on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicableArchitectures", Required = Newtonsoft.Json.Required.Default)]
        public WindowsArchitecture? ApplicableArchitectures { get; set; }
    
        /// <summary>
        /// Gets or sets identity name.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityName", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityName { get; set; }
    
        /// <summary>
        /// Gets or sets identity publisher hash.
        /// The Identity Publisher Hash.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityPublisherHash", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityPublisherHash { get; set; }
    
        /// <summary>
        /// Gets or sets identity resource identifier.
        /// The Identity Resource Identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityResourceIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityResourceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets is bundle.
        /// Whether or not the app is a bundle.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isBundle", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsBundle { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSupportedOperatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public WindowsMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets identity version.
        /// The identity version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string IdentityVersion { get; set; }
    
    }
}

