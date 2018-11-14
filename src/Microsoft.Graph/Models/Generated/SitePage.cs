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
    /// The type Site Page.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SitePage : BaseItem
    {
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public ContentTypeInfo ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets page layout type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pageLayoutType", Required = Newtonsoft.Json.Required.Default)]
        public string PageLayoutType { get; set; }
    
        /// <summary>
        /// Gets or sets web parts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webParts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WebPart> WebParts { get; set; }
    
        /// <summary>
        /// Gets or sets publishing state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishingState", Required = Newtonsoft.Json.Required.Default)]
        public PublicationFacet PublishingState { get; set; }
    
    }
}

