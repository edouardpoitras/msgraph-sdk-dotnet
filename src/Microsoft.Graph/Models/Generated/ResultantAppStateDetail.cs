// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ResultantAppStateDetail.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ResultantAppStateDetail
    {
    
        /// <summary>
        /// no Additional Details
        /// </summary>
        NoAdditionalDetails = 0,
	
        /// <summary>
        /// see Install Error Code
        /// </summary>
        SeeInstallErrorCode = 2000,
	
        /// <summary>
        /// see Uninstall Error Code
        /// </summary>
        SeeUninstallErrorCode = 4000,
	
        /// <summary>
        /// pending Reboot
        /// </summary>
        PendingReboot = 5000,
	
        /// <summary>
        /// platform Not Applicable
        /// </summary>
        PlatformNotApplicable = -1006,
	
        /// <summary>
        /// minimum Cpu Speed Not Met
        /// </summary>
        MinimumCpuSpeedNotMet = -1005,
	
        /// <summary>
        /// minimum Logical Processor Count Not Met
        /// </summary>
        MinimumLogicalProcessorCountNotMet = -1004,
	
        /// <summary>
        /// minimum Physical Memory Not Met
        /// </summary>
        MinimumPhysicalMemoryNotMet = -1003,
	
        /// <summary>
        /// minimum Os Version Not Met
        /// </summary>
        MinimumOsVersionNotMet = -1002,
	
        /// <summary>
        /// minimum Disk Space Not Met
        /// </summary>
        MinimumDiskSpaceNotMet = -1001,
	
        /// <summary>
        /// processor Architecture Not Applicable
        /// </summary>
        ProcessorArchitectureNotApplicable = -1000,
	
    }
}
