// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityClient.cs.tt

namespace Microsoft.Graph
{
    using Azure.Core;
    using System;
    using System.Net.Http;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceClient.
    /// </summary>
    public partial class GraphServiceClient : BaseClient
    {
        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : this("https://graph.microsoft.com/v1.0", authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new GraphServiceClient using a <see cref="TokenCredential"/> instance.
        /// </summary>
        /// <param name="tokenCredential">The <see cref="TokenCredential"/> to use for authentication</param>
        /// <param name="scopes">Scopes required to access Microsoft Graph. This defaults to https://graph.microsoft.com/.default when none is set.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            TokenCredential tokenCredential,
            IEnumerable<string> scopes = null,
            IHttpProvider httpProvider = null)
            : this("https://graph.microsoft.com/v1.0", new TokenCredentialAuthProvider(tokenCredential,scopes), httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="baseUrl">The base service URL. For example, "https://graph.microsoft.com/v1.0".</param>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            string baseUrl,
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : base(baseUrl, authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use for making requests to Microsoft Graph. Use the <see cref="GraphClientFactory"/>
        /// to get a pre-configured HttpClient that is optimized for use with the Microsoft Graph service API. </param>
        /// <param name="baseUrl">The base service URL. For example, "https://graph.microsoft.com/v1.0".</param>
        public GraphServiceClient(
            HttpClient httpClient,
            string baseUrl = "https://graph.microsoft.com/v1.0")
            : base(baseUrl, httpClient)
        {
        }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        public virtual IGraphServiceWorkbooksCollectionRequestBuilder Workbooks
        {
            get
            {
                return new GraphServiceWorkbooksCollectionRequestBuilder(this.BaseUrl + "/workbooks", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        public virtual IGraphServiceInvitationsCollectionRequestBuilder Invitations
        {
            get
            {
                return new GraphServiceInvitationsCollectionRequestBuilder(this.BaseUrl + "/invitations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        public virtual IGraphServiceUsersCollectionRequestBuilder Users
        {
            get
            {
                return new GraphServiceUsersCollectionRequestBuilder(this.BaseUrl + "/users", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceApplicationTemplates request builder.
        /// </summary>
        public virtual IGraphServiceApplicationTemplatesCollectionRequestBuilder ApplicationTemplates
        {
            get
            {
                return new GraphServiceApplicationTemplatesCollectionRequestBuilder(this.BaseUrl + "/applicationTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAuthenticationMethodConfigurations request builder.
        /// </summary>
        public virtual IGraphServiceAuthenticationMethodConfigurationsCollectionRequestBuilder AuthenticationMethodConfigurations
        {
            get
            {
                return new GraphServiceAuthenticationMethodConfigurationsCollectionRequestBuilder(this.BaseUrl + "/authenticationMethodConfigurations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProviders request builder.
        /// </summary>
        [Obsolete("The identityProvider API is deprecated and will stop returning data on March 2023. Please use the new identityProviderBase API.")]
        public virtual IGraphServiceIdentityProvidersCollectionRequestBuilder IdentityProviders
        {
            get
            {
                return new GraphServiceIdentityProvidersCollectionRequestBuilder(this.BaseUrl + "/identityProviders", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceApplications request builder.
        /// </summary>
        public virtual IGraphServiceApplicationsCollectionRequestBuilder Applications
        {
            get
            {
                return new GraphServiceApplicationsCollectionRequestBuilder(this.BaseUrl + "/applications", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceCertificateBasedAuthConfiguration request builder.
        /// </summary>
        public virtual IGraphServiceCertificateBasedAuthConfigurationCollectionRequestBuilder CertificateBasedAuthConfiguration
        {
            get
            {
                return new GraphServiceCertificateBasedAuthConfigurationCollectionRequestBuilder(this.BaseUrl + "/certificateBasedAuthConfiguration", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceContacts request builder.
        /// </summary>
        public virtual IGraphServiceContactsCollectionRequestBuilder Contacts
        {
            get
            {
                return new GraphServiceContactsCollectionRequestBuilder(this.BaseUrl + "/contacts", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        public virtual IGraphServiceContractsCollectionRequestBuilder Contracts
        {
            get
            {
                return new GraphServiceContractsCollectionRequestBuilder(this.BaseUrl + "/contracts", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        public virtual IGraphServiceDevicesCollectionRequestBuilder Devices
        {
            get
            {
                return new GraphServiceDevicesCollectionRequestBuilder(this.BaseUrl + "/devices", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        public virtual IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects
        {
            get
            {
                return new GraphServiceDirectoryObjectsCollectionRequestBuilder(this.BaseUrl + "/directoryObjects", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        public virtual IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles
        {
            get
            {
                return new GraphServiceDirectoryRolesCollectionRequestBuilder(this.BaseUrl + "/directoryRoles", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        public virtual IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates
        {
            get
            {
                return new GraphServiceDirectoryRoleTemplatesCollectionRequestBuilder(this.BaseUrl + "/directoryRoleTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        public virtual IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords
        {
            get
            {
                return new GraphServiceDomainDnsRecordsCollectionRequestBuilder(this.BaseUrl + "/domainDnsRecords", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        public virtual IGraphServiceDomainsCollectionRequestBuilder Domains
        {
            get
            {
                return new GraphServiceDomainsCollectionRequestBuilder(this.BaseUrl + "/domains", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        public virtual IGraphServiceGroupsCollectionRequestBuilder Groups
        {
            get
            {
                return new GraphServiceGroupsCollectionRequestBuilder(this.BaseUrl + "/groups", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettings request builder.
        /// </summary>
        public virtual IGraphServiceGroupSettingsCollectionRequestBuilder GroupSettings
        {
            get
            {
                return new GraphServiceGroupSettingsCollectionRequestBuilder(this.BaseUrl + "/groupSettings", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettingTemplates request builder.
        /// </summary>
        public virtual IGraphServiceGroupSettingTemplatesCollectionRequestBuilder GroupSettingTemplates
        {
            get
            {
                return new GraphServiceGroupSettingTemplatesCollectionRequestBuilder(this.BaseUrl + "/groupSettingTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceLocalizations request builder.
        /// </summary>
        public virtual IGraphServiceLocalizationsCollectionRequestBuilder Localizations
        {
            get
            {
                return new GraphServiceLocalizationsCollectionRequestBuilder(this.BaseUrl + "/localizations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOauth2PermissionGrants request builder.
        /// </summary>
        public virtual IGraphServiceOauth2PermissionGrantsCollectionRequestBuilder Oauth2PermissionGrants
        {
            get
            {
                return new GraphServiceOauth2PermissionGrantsCollectionRequestBuilder(this.BaseUrl + "/oauth2PermissionGrants", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        public virtual IGraphServiceOrganizationCollectionRequestBuilder Organization
        {
            get
            {
                return new GraphServiceOrganizationCollectionRequestBuilder(this.BaseUrl + "/organization", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePermissionGrants request builder.
        /// </summary>
        public virtual IGraphServicePermissionGrantsCollectionRequestBuilder PermissionGrants
        {
            get
            {
                return new GraphServicePermissionGrantsCollectionRequestBuilder(this.BaseUrl + "/permissionGrants", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceScopedRoleMemberships request builder.
        /// </summary>
        public virtual IGraphServiceScopedRoleMembershipsCollectionRequestBuilder ScopedRoleMemberships
        {
            get
            {
                return new GraphServiceScopedRoleMembershipsCollectionRequestBuilder(this.BaseUrl + "/scopedRoleMemberships", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceServicePrincipals request builder.
        /// </summary>
        public virtual IGraphServiceServicePrincipalsCollectionRequestBuilder ServicePrincipals
        {
            get
            {
                return new GraphServiceServicePrincipalsCollectionRequestBuilder(this.BaseUrl + "/servicePrincipals", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        public virtual IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus
        {
            get
            {
                return new GraphServiceSubscribedSkusCollectionRequestBuilder(this.BaseUrl + "/subscribedSkus", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePlaces request builder.
        /// </summary>
        public virtual IGraphServicePlacesCollectionRequestBuilder Places
        {
            get
            {
                return new GraphServicePlacesCollectionRequestBuilder(this.BaseUrl + "/places", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        public virtual IGraphServiceDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new GraphServiceDrivesCollectionRequestBuilder(this.BaseUrl + "/drives", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        public virtual IGraphServiceSharesCollectionRequestBuilder Shares
        {
            get
            {
                return new GraphServiceSharesCollectionRequestBuilder(this.BaseUrl + "/shares", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        public virtual IGraphServiceSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new GraphServiceSitesCollectionRequestBuilder(this.BaseUrl + "/sites", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        public virtual IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions
        {
            get
            {
                return new GraphServiceSchemaExtensionsCollectionRequestBuilder(this.BaseUrl + "/schemaExtensions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupLifecyclePolicies request builder.
        /// </summary>
        public virtual IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies
        {
            get
            {
                return new GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder(this.BaseUrl + "/groupLifecyclePolicies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAgreementAcceptances request builder.
        /// </summary>
        public virtual IGraphServiceAgreementAcceptancesCollectionRequestBuilder AgreementAcceptances
        {
            get
            {
                return new GraphServiceAgreementAcceptancesCollectionRequestBuilder(this.BaseUrl + "/agreementAcceptances", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAgreements request builder.
        /// </summary>
        public virtual IGraphServiceAgreementsCollectionRequestBuilder Agreements
        {
            get
            {
                return new GraphServiceAgreementsCollectionRequestBuilder(this.BaseUrl + "/agreements", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDataPolicyOperations request builder.
        /// </summary>
        public virtual IGraphServiceDataPolicyOperationsCollectionRequestBuilder DataPolicyOperations
        {
            get
            {
                return new GraphServiceDataPolicyOperationsCollectionRequestBuilder(this.BaseUrl + "/dataPolicyOperations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        public virtual IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions
        {
            get
            {
                return new GraphServiceSubscriptionsCollectionRequestBuilder(this.BaseUrl + "/subscriptions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceConnections request builder.
        /// </summary>
        public virtual IGraphServiceConnectionsCollectionRequestBuilder Connections
        {
            get
            {
                return new GraphServiceConnectionsCollectionRequestBuilder(this.BaseUrl + "/connections", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceChats request builder.
        /// </summary>
        public virtual IGraphServiceChatsCollectionRequestBuilder Chats
        {
            get
            {
                return new GraphServiceChatsCollectionRequestBuilder(this.BaseUrl + "/chats", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeams request builder.
        /// </summary>
        public virtual IGraphServiceTeamsCollectionRequestBuilder Teams
        {
            get
            {
                return new GraphServiceTeamsCollectionRequestBuilder(this.BaseUrl + "/teams", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeamsTemplates request builder.
        /// </summary>
        public virtual IGraphServiceTeamsTemplatesCollectionRequestBuilder TeamsTemplates
        {
            get
            {
                return new GraphServiceTeamsTemplatesCollectionRequestBuilder(this.BaseUrl + "/teamsTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAuditLogs request builder.
        /// </summary>
        public virtual IAuditLogRootRequestBuilder AuditLogs
        {
            get
            {
                return new AuditLogRootRequestBuilder(this.BaseUrl + "/auditLogs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAuthenticationMethodsPolicy request builder.
        /// </summary>
        public virtual IAuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy
        {
            get
            {
                return new AuthenticationMethodsPolicyRequestBuilder(this.BaseUrl + "/authenticationMethodsPolicy", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceCompliance request builder.
        /// </summary>
        public virtual IComplianceRequestBuilder Compliance
        {
            get
            {
                return new ComplianceRequestBuilder(this.BaseUrl + "/compliance", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentity request builder.
        /// </summary>
        public virtual IIdentityContainerRequestBuilder Identity
        {
            get
            {
                return new IdentityContainerRequestBuilder(this.BaseUrl + "/identity", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceBranding request builder.
        /// </summary>
        public virtual IOrganizationalBrandingRequestBuilder Branding
        {
            get
            {
                return new OrganizationalBrandingRequestBuilder(this.BaseUrl + "/branding", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        public virtual IDirectoryRequestBuilder Directory
        {
            get
            {
                return new DirectoryRequestBuilder(this.BaseUrl + "/directory", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        public virtual IUserRequestBuilder Me
        {
            get
            {
                return new UserRequestBuilder(this.BaseUrl + "/me", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePolicies request builder.
        /// </summary>
        public virtual IPolicyRootRequestBuilder Policies
        {
            get
            {
                return new PolicyRootRequestBuilder(this.BaseUrl + "/policies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceEducation request builder.
        /// </summary>
        public virtual IEducationRootRequestBuilder Education
        {
            get
            {
                return new EducationRootRequestBuilder(this.BaseUrl + "/education", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceRoleManagement request builder.
        /// </summary>
        public virtual IRoleManagementRequestBuilder RoleManagement
        {
            get
            {
                return new RoleManagementRequestBuilder(this.BaseUrl + "/roleManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        public virtual IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.BaseUrl + "/drive", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceCommunications request builder.
        /// </summary>
        public virtual ICloudCommunicationsRequestBuilder Communications
        {
            get
            {
                return new CloudCommunicationsRequestBuilder(this.BaseUrl + "/communications", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentityGovernance request builder.
        /// </summary>
        public virtual IIdentityGovernanceRequestBuilder IdentityGovernance
        {
            get
            {
                return new IdentityGovernanceRequestBuilder(this.BaseUrl + "/identityGovernance", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        public virtual IDeviceAppManagementRequestBuilder DeviceAppManagement
        {
            get
            {
                return new DeviceAppManagementRequestBuilder(this.BaseUrl + "/deviceAppManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        public virtual IDeviceManagementRequestBuilder DeviceManagement
        {
            get
            {
                return new DeviceManagementRequestBuilder(this.BaseUrl + "/deviceManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        public virtual IReportRootRequestBuilder Reports
        {
            get
            {
                return new ReportRootRequestBuilder(this.BaseUrl + "/reports", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAdmin request builder.
        /// </summary>
        public virtual IAdminRequestBuilder Admin
        {
            get
            {
                return new AdminRequestBuilder(this.BaseUrl + "/admin", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSearch request builder.
        /// </summary>
        public virtual ISearchEntityRequestBuilder Search
        {
            get
            {
                return new SearchEntityRequestBuilder(this.BaseUrl + "/search", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        public virtual IPlannerRequestBuilder Planner
        {
            get
            {
                return new PlannerRequestBuilder(this.BaseUrl + "/planner", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePrint request builder.
        /// </summary>
        public virtual IPrintRequestBuilder Print
        {
            get
            {
                return new PrintRequestBuilder(this.BaseUrl + "/print", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSecurity request builder.
        /// </summary>
        public virtual ISecurityRequestBuilder Security
        {
            get
            {
                return new SecurityRequestBuilder(this.BaseUrl + "/security", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceExternal request builder.
        /// </summary>
        public virtual Microsoft.Graph.ExternalConnectors.IExternalRequestBuilder External
        {
            get
            {
                return new Microsoft.Graph.ExternalConnectors.ExternalRequestBuilder(this.BaseUrl + "/external", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAppCatalogs request builder.
        /// </summary>
        public virtual IAppCatalogsRequestBuilder AppCatalogs
        {
            get
            {
                return new AppCatalogsRequestBuilder(this.BaseUrl + "/appCatalogs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeamwork request builder.
        /// </summary>
        public virtual ITeamworkRequestBuilder Teamwork
        {
            get
            {
                return new TeamworkRequestBuilder(this.BaseUrl + "/teamwork", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceInformationProtection request builder.
        /// </summary>
        public virtual IInformationProtectionRequestBuilder InformationProtection
        {
            get
            {
                return new InformationProtectionRequestBuilder(this.BaseUrl + "/informationProtection", this);
            }
        }
    
    }
}
