// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum BookingStaffRole.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum BookingStaffRole
    {
    
        /// <summary>
        /// guest
        /// </summary>
        Guest = 0,
	
        /// <summary>
        /// administrator
        /// </summary>
        Administrator = 1,
	
        /// <summary>
        /// viewer
        /// </summary>
        Viewer = 2,
	
        /// <summary>
        /// external Guest
        /// </summary>
        ExternalGuest = 3,
	
    }
}
