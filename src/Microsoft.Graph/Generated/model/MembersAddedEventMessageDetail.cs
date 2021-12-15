// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type MembersAddedEventMessageDetail.
    /// </summary>
    public partial class MembersAddedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MembersAddedEventMessageDetail"/> class.
        /// </summary>
        public MembersAddedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.membersAddedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets initiator.
        /// Initiator of the event.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// List of members added.
        /// </summary>
        [JsonPropertyName("members")]
        public IEnumerable<TeamworkUserIdentity> Members { get; set; }
    
        /// <summary>
        /// Gets or sets visibleHistoryStartDateTime.
        /// The timestamp that denotes how far back a conversation's history is shared with the conversation members.
        /// </summary>
        [JsonPropertyName("visibleHistoryStartDateTime")]
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
    
    }
}