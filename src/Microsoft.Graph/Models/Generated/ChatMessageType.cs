// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ChatMessageType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ChatMessageType
    {
    
        /// <summary>
        /// message
        /// </summary>
        Message = 0,
	
        /// <summary>
        /// chat Event
        /// </summary>
        ChatEvent = 1,
	
        /// <summary>
        /// typing
        /// </summary>
        Typing = 2,
	
    }
}
