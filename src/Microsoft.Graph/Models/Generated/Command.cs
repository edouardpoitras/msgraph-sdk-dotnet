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
    /// The type Command.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Command : Entity
    {
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Type", Required = Newtonsoft.Json.Required.Default)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets app service name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "AppServiceName", Required = Newtonsoft.Json.Required.Default)]
        public string AppServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets package family name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "PackageFamilyName", Required = Newtonsoft.Json.Required.Default)]
        public string PackageFamilyName { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Error", Required = Newtonsoft.Json.Required.Default)]
        public string Error { get; set; }
    
        /// <summary>
        /// Gets or sets payload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Payload", Required = Newtonsoft.Json.Required.Default)]
        public PayloadRequest Payload { get; set; }
    
        /// <summary>
        /// Gets or sets permission ticket.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "PermissionTicket", Required = Newtonsoft.Json.Required.Default)]
        public string PermissionTicket { get; set; }
    
        /// <summary>
        /// Gets or sets post back uri.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "PostBackUri", Required = Newtonsoft.Json.Required.Default)]
        public string PostBackUri { get; set; }
    
        /// <summary>
        /// Gets or sets responsepayload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responsepayload", Required = Newtonsoft.Json.Required.Default)]
        public PayloadResponse Responsepayload { get; set; }
    
    }
}

