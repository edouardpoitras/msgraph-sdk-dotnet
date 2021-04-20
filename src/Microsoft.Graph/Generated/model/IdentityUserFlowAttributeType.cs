// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum IdentityUserFlowAttributeType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum IdentityUserFlowAttributeType
    {
    
        /// <summary>
        /// Built In
        /// </summary>
        BuiltIn = 1,
	
        /// <summary>
        /// Custom
        /// </summary>
        Custom = 2,
	
        /// <summary>
        /// Required
        /// </summary>
        Required = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
