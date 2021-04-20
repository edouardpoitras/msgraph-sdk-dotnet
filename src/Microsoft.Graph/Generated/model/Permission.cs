// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Permission.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Permission : Entity
    {
    
		///<summary>
		/// The Permission constructor
		///</summary>
        public Permission()
        {
            this.ODataType = "microsoft.graph.permission";
        }
	
        /// <summary>
        /// Gets or sets expiration date time.
        /// A format of yyyy-MM-ddTHH:mm:ssZ of DateTimeOffset indicates the expiration time of the permission. DateTime.MinValue indicates there is no expiration set for this permission. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets granted to.
        /// For user type permissions, the details of the users &amp; applications for this permission. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grantedTo", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet GrantedTo { get; set; }
    
        /// <summary>
        /// Gets or sets granted to identities.
        /// For link type permissions, the details of the users to whom permission was granted. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "grantedToIdentities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IdentitySet> GrantedToIdentities { get; set; }
    
        /// <summary>
        /// Gets or sets has password.
        /// This indicates whether password is set for this permission, it's only showing in response. Optional and Read-only and for OneDrive Personal only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasPassword", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasPassword { get; set; }
    
        /// <summary>
        /// Gets or sets inherited from.
        /// Provides a reference to the ancestor of the current permission, if it is inherited from an ancestor. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inheritedFrom", Required = Newtonsoft.Json.Required.Default)]
        public ItemReference InheritedFrom { get; set; }
    
        /// <summary>
        /// Gets or sets invitation.
        /// Details of any associated sharing invitation for this permission. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invitation", Required = Newtonsoft.Json.Required.Default)]
        public SharingInvitation Invitation { get; set; }
    
        /// <summary>
        /// Gets or sets link.
        /// Provides the link details of the current permission, if it is a link type permissions. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "link", Required = Newtonsoft.Json.Required.Default)]
        public SharingLink Link { get; set; }
    
        /// <summary>
        /// Gets or sets roles.
        /// The type of permission, e.g. read. See below for the full list of roles. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets share id.
        /// A unique token that can be used to access this shared item via the [shares API][]. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shareId", Required = Newtonsoft.Json.Required.Default)]
        public string ShareId { get; set; }
    
    }
}

