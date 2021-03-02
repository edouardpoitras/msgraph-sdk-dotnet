// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PrinterCreateRequestBody.
    /// </summary>
    public partial class PrinterCreateRequestBody
    {
    
        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets Manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets Model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets PhysicalDeviceId.
        /// </summary>
        [JsonPropertyName("physicalDeviceId")]
        public string PhysicalDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets HasPhysicalDevice.
        /// </summary>
        [JsonPropertyName("hasPhysicalDevice")]
        public bool? HasPhysicalDevice { get; set; }
    
        /// <summary>
        /// Gets or sets CertificateSigningRequest.
        /// </summary>
        [JsonPropertyName("certificateSigningRequest")]
        public PrintCertificateSigningRequestObject CertificateSigningRequest { get; set; }
    
        /// <summary>
        /// Gets or sets ConnectorId.
        /// </summary>
        [JsonPropertyName("connectorId")]
        public string ConnectorId { get; set; }
    
    }
}