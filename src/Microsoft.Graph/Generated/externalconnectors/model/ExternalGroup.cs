// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type External Group.
    /// </summary>
    public partial class ExternalGroup : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the external group. Optional.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name of the external group. Optional.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// A member added to an externalGroup. You can add Azure Active Directory users, Azure Active Directory groups, or an externalGroup as members.
        /// </summary>
        [JsonPropertyName("members")]
        public IExternalGroupMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
    }
}

