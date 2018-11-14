// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsSModeConfiguration.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsSModeConfiguration
    {
    
        /// <summary>
        /// no Restriction
        /// </summary>
        NoRestriction = 0,
	
        /// <summary>
        /// block
        /// </summary>
        Block = 1,
	
        /// <summary>
        /// unlock
        /// </summary>
        Unlock = 2,
	
    }
}
