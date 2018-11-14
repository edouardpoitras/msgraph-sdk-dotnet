// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ChassisType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ChassisType
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// desktop
        /// </summary>
        Desktop = 1,
	
        /// <summary>
        /// laptop
        /// </summary>
        Laptop = 2,
	
        /// <summary>
        /// works Workstation
        /// </summary>
        WorksWorkstation = 3,
	
        /// <summary>
        /// enterprise Server
        /// </summary>
        EnterpriseServer = 4,
	
        /// <summary>
        /// phone
        /// </summary>
        Phone = 100,
	
        /// <summary>
        /// tablet
        /// </summary>
        Tablet = 101,
	
        /// <summary>
        /// mobile Other
        /// </summary>
        MobileOther = 102,
	
        /// <summary>
        /// mobile Unknown
        /// </summary>
        MobileUnknown = 103,
	
    }
}