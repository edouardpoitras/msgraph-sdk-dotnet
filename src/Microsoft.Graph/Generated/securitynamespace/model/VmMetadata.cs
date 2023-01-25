// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type VmMetadata.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<VmMetadata>))]
    public partial class VmMetadata
    {

        /// <summary>
        /// Gets or sets cloudProvider.
        /// The cloud provider hosting the virtual machine. The possible values are: unknown, azure, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("cloudProvider")]
        public VmCloudProvider? CloudProvider { get; set; }
    
        /// <summary>
        /// Gets or sets resourceId.
        /// Unique identifier of the Azure resource.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptionId.
        /// Unique identifier of the Azure subscription the customer tenant belongs to.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets vmId.
        /// Unique identifier of the virtual machine instance.
        /// </summary>
        [JsonPropertyName("vmId")]
        public string VmId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}