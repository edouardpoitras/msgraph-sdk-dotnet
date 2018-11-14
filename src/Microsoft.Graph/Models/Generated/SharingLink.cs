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
    /// The type SharingLink.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SharingLink
    {

        /// <summary>
        /// Gets or sets application.
        /// The app the link is associated with.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "application", Required = Newtonsoft.Json.Required.Default)]
        public Identity Application { get; set; }
    
        /// <summary>
        /// Gets or sets preventsDownload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preventsDownload", Required = Newtonsoft.Json.Required.Default)]
        public bool? PreventsDownload { get; set; }
    
        /// <summary>
        /// Gets or sets configuratorUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configuratorUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ConfiguratorUrl { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// The scope of the link represented by this permission. Value anonymous indicates the link is usable by anyone, organization indicates the link is only usable for users signed into the same tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scope", Required = Newtonsoft.Json.Required.Default)]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of the link created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets webHtml.
        /// For embed links, this property contains the HTML code for an &amp;lt;iframe&amp;gt; element that will embed the item in a webpage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webHtml", Required = Newtonsoft.Json.Required.Default)]
        public string WebHtml { get; set; }
    
        /// <summary>
        /// Gets or sets webUrl.
        /// A URL that opens the item in the browser on the OneDrive website.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebUrl { get; set; }
    
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
