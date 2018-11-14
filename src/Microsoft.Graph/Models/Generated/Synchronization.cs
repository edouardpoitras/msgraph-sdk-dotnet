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
    /// The type Synchronization.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Synchronization : Entity
    {
    
        /// <summary>
        /// Gets or sets secrets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secrets", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SynchronizationSecretKeyStringValuePair> Secrets { get; set; }
    
        /// <summary>
        /// Gets or sets jobs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobs", Required = Newtonsoft.Json.Required.Default)]
        public ISynchronizationJobsCollectionPage Jobs { get; set; }
    
        /// <summary>
        /// Gets or sets templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templates", Required = Newtonsoft.Json.Required.Default)]
        public ISynchronizationTemplatesCollectionPage Templates { get; set; }
    
    }
}

