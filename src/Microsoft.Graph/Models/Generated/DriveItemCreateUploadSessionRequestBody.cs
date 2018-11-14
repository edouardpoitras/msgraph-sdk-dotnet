// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DriveItemCreateUploadSessionRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DriveItemCreateUploadSessionRequestBody
    {
    
        /// <summary>
        /// Gets or sets Item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "item", Required = Newtonsoft.Json.Required.Default)]
        public DriveItemUploadableProperties Item { get; set; }
    
        /// <summary>
        /// Gets or sets DeferCommit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deferCommit", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeferCommit { get; set; }
    
    }
}
