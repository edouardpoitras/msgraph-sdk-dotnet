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
    /// The type Synchronization Template.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SynchronizationTemplate : Entity
    {
    
        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? ApplicationId { get; set; }
    
        /// <summary>
        /// Gets or sets default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "default", Required = Newtonsoft.Json.Required.Default)]
        public bool? Default { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets discoverable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discoverable", Required = Newtonsoft.Json.Required.Default)]
        public bool? Discoverable { get; set; }
    
        /// <summary>
        /// Gets or sets factory tag.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryTag", Required = Newtonsoft.Json.Required.Default)]
        public string FactoryTag { get; set; }
    
        /// <summary>
        /// Gets or sets metadata.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metadata", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MetadataEntry> Metadata { get; set; }
    
        /// <summary>
        /// Gets or sets schema.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schema", Required = Newtonsoft.Json.Required.Default)]
        public SynchronizationSchema Schema { get; set; }
    
    }
}

