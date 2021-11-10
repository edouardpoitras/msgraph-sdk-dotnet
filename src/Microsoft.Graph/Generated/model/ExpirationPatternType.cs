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
    /// The enum ExpirationPatternType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExpirationPatternType
    {
    
        /// <summary>
        /// Not Specified
        /// </summary>
        NotSpecified = 0,
	
        /// <summary>
        /// No Expiration
        /// </summary>
        NoExpiration = 1,
	
        /// <summary>
        /// After Date Time
        /// </summary>
        AfterDateTime = 2,
	
        /// <summary>
        /// After Duration
        /// </summary>
        AfterDuration = 3,
	
    }
}
