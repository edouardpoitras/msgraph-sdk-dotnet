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
    /// The type Access Review Schedule Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessReviewScheduleDefinition : Entity
    {
    
		///<summary>
		/// The AccessReviewScheduleDefinition constructor
		///</summary>
        public AccessReviewScheduleDefinition()
        {
            this.ODataType = "microsoft.graph.accessReviewScheduleDefinition";
        }
	
        /// <summary>
        /// Gets or sets created by.
        /// User who created this review.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp when review series was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description for admins.
        /// Description provided by review creators to provide more context of the review to admins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "descriptionForAdmins", Required = Newtonsoft.Json.Required.Default)]
        public string DescriptionForAdmins { get; set; }
    
        /// <summary>
        /// Gets or sets description for reviewers.
        /// Description provided  by review creators to provide more context of the review to reviewers. Reviewers will see this description in the email sent to them requesting their review.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "descriptionForReviewers", Required = Newtonsoft.Json.Required.Default)]
        public string DescriptionForReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of access review series. Required on create.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets fallback reviewers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fallbackReviewers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AccessReviewReviewerScope> FallbackReviewers { get; set; }
    
        /// <summary>
        /// Gets or sets instance enumeration scope.
        /// In the case of a review of guest users across all Microsoft 365 groups, this determines the scope of which groups will be reviewed. Each group will become a unique accessReviewInstance of the access review series.  For supported scopes, see accessReviewScope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instanceEnumerationScope", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewScope InstanceEnumerationScope { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Timestamp when review series was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reviewers.
        /// This collection of access review scopes is used to define who are the reviewers. See accessReviewReviewerScope. Required on create.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AccessReviewReviewerScope> Reviewers { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Defines scope of users reviewed. For supported scopes, see accessReviewScope. Required on create.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scope", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewScope Scope { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// The settings for an access review series, see type definition below.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewScheduleSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// This read-only field specifies the status of an accessReview. The typical states include Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets instances.
        /// Set of access reviews instances for this access review series. Access reviews that do not recur will only have one instance; otherwise, there will be an instance for each recurrence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instances", Required = Newtonsoft.Json.Required.Default)]
        public IAccessReviewScheduleDefinitionInstancesCollectionPage Instances { get; set; }
    
    }
}

