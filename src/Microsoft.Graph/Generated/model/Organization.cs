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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Organization.
    /// </summary>
    public partial class Organization : DirectoryObject
    {
    
		///<summary>
		/// The Organization constructor
		///</summary>
        public Organization()
        {
            this.ODataType = "microsoft.graph.organization";
        }
	
        /// <summary>
        /// Gets or sets assigned plans.
        /// The collection of service plans associated with the tenant. Not nullable.
        /// </summary>
        [JsonPropertyName("assignedPlans")]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// Telephone number for the organization. Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [JsonPropertyName("businessPhones")]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// City name of the address for the organization.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets country.
        /// Country/region name of the address for the organization.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or sets country letter code.
        /// Country/region abbreviation for the organization.
        /// </summary>
        [JsonPropertyName("countryLetterCode")]
        public string CountryLetterCode { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the tenant.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets marketing notification emails.
        /// Not nullable.
        /// </summary>
        [JsonPropertyName("marketingNotificationEmails")]
        public IEnumerable<string> MarketingNotificationEmails { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// The time and date at which the tenant was last synced with the on-premise directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).
        /// </summary>
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets postal code.
        /// Postal code of the address for the organization.
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the organization. Should follow ISO 639-1 Code; for example en.
        /// </summary>
        [JsonPropertyName("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets privacy profile.
        /// The privacy profile of an organization.
        /// </summary>
        [JsonPropertyName("privacyProfile")]
        public PrivacyProfile PrivacyProfile { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// Not nullable.
        /// </summary>
        [JsonPropertyName("provisionedPlans")]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets security compliance notification mails.
        /// </summary>
        [JsonPropertyName("securityComplianceNotificationMails")]
        public IEnumerable<string> SecurityComplianceNotificationMails { get; set; }
    
        /// <summary>
        /// Gets or sets security compliance notification phones.
        /// </summary>
        [JsonPropertyName("securityComplianceNotificationPhones")]
        public IEnumerable<string> SecurityComplianceNotificationPhones { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// State name of the address for the organization.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets street.
        /// Street name of the address for organization.
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }
    
        /// <summary>
        /// Gets or sets technical notification mails.
        /// Not nullable.
        /// </summary>
        [JsonPropertyName("technicalNotificationMails")]
        public IEnumerable<string> TechnicalNotificationMails { get; set; }
    
        /// <summary>
        /// Gets or sets tenant type.
        /// </summary>
        [JsonPropertyName("tenantType")]
        public string TenantType { get; set; }
    
        /// <summary>
        /// Gets or sets verified domains.
        /// The collection of domains associated with this tenant. Not nullable.
        /// </summary>
        [JsonPropertyName("verifiedDomains")]
        public IEnumerable<VerifiedDomain> VerifiedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets mobile device management authority.
        /// Mobile device management authority. Possible values are: unknown, intune, sccm, office365.
        /// </summary>
        [JsonPropertyName("mobileDeviceManagementAuthority")]
        public MdmAuthority? MobileDeviceManagementAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets branding.
        /// </summary>
        [JsonPropertyName("branding")]
        public OrganizationalBranding Branding { get; set; }
    
        /// <summary>
        /// Gets or sets certificate based auth configuration.
        /// Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.
        /// </summary>
        [JsonPropertyName("certificateBasedAuthConfiguration")]
        public IOrganizationCertificateBasedAuthConfigurationCollectionWithReferencesPage CertificateBasedAuthConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the organization. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IOrganizationExtensionsCollectionPage Extensions { get; set; }
    
    }
}

