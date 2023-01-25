// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum PartnerTenantType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PartnerTenantType
    {
    
        /// <summary>
        /// Microsoft Support
        /// </summary>
        MicrosoftSupport = 1,
	
        /// <summary>
        /// Syndicate Partner
        /// </summary>
        SyndicatePartner = 2,
	
        /// <summary>
        /// Breadth Partner
        /// </summary>
        BreadthPartner = 3,
	
        /// <summary>
        /// Breadth Partner Delegated Admin
        /// </summary>
        BreadthPartnerDelegatedAdmin = 4,
	
        /// <summary>
        /// Reseller Partner Delegated Admin
        /// </summary>
        ResellerPartnerDelegatedAdmin = 5,
	
        /// <summary>
        /// Value Added Reseller Partner Delegated Admin
        /// </summary>
        ValueAddedResellerPartnerDelegatedAdmin = 6,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}