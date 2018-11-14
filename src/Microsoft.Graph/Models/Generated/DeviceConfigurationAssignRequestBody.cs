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
    /// The type DeviceConfigurationAssignRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceConfigurationAssignRequestBody
    {
    
        /// <summary>
        /// Gets or sets DeviceConfigurationGroupAssignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfigurationGroupAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceConfigurationGroupAssignment> DeviceConfigurationGroupAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets Assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceConfigurationAssignment> Assignments { get; set; }
    
    }
}
