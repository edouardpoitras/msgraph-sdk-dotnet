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
    /// The type Office Client Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OfficeClientConfiguration : Entity
    {
    
		///<summary>
		/// The internal OfficeClientConfiguration constructor
		///</summary>
        protected internal OfficeClientConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets user preference payload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPreferencePayload", Required = Newtonsoft.Json.Required.Default)]
        public Stream UserPreferencePayload { get; set; }
    
        /// <summary>
        /// Gets or sets policy payload.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyPayload", Required = Newtonsoft.Json.Required.Default)]
        public Stream PolicyPayload { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "priority", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets user checkin summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userCheckinSummary", Required = Newtonsoft.Json.Required.Default)]
        public OfficeUserCheckinSummary UserCheckinSummary { get; set; }
    
        /// <summary>
        /// Gets or sets checkin statuses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "checkinStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OfficeClientCheckinStatus> CheckinStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IOfficeClientConfigurationAssignmentsCollectionPage Assignments { get; set; }
    
    }
}

