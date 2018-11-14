// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum PolicyPlatformType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PolicyPlatformType
    {
    
        /// <summary>
        /// android
        /// </summary>
        Android = 0,
	
        /// <summary>
        /// android For Work
        /// </summary>
        AndroidForWork = 1,
	
        /// <summary>
        /// i OS
        /// </summary>
        IOS = 2,
	
        /// <summary>
        /// mac OS
        /// </summary>
        MacOS = 3,
	
        /// <summary>
        /// windows Phone81
        /// </summary>
        WindowsPhone81 = 4,
	
        /// <summary>
        /// windows81And Later
        /// </summary>
        Windows81AndLater = 5,
	
        /// <summary>
        /// windows10And Later
        /// </summary>
        Windows10AndLater = 6,
	
        /// <summary>
        /// android Work Profile
        /// </summary>
        AndroidWorkProfile = 7,
	
        /// <summary>
        /// all
        /// </summary>
        All = 100,
	
    }
}
