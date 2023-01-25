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
    /// The enum BookingStaffRole.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BookingStaffRole
    {
    
        /// <summary>
        /// Guest
        /// </summary>
        Guest = 0,
	
        /// <summary>
        /// Administrator
        /// </summary>
        Administrator = 1,
	
        /// <summary>
        /// Viewer
        /// </summary>
        Viewer = 2,
	
        /// <summary>
        /// External Guest
        /// </summary>
        ExternalGuest = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
        /// <summary>
        /// Scheduler
        /// </summary>
        Scheduler = 5,
	
        /// <summary>
        /// Team Member
        /// </summary>
        TeamMember = 6,
	
    }
}