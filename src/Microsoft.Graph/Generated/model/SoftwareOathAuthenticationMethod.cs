// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Software Oath Authentication Method.
    /// </summary>
    public partial class SoftwareOathAuthenticationMethod : AuthenticationMethod
    {
    
        ///<summary>
        /// The SoftwareOathAuthenticationMethod constructor
        ///</summary>
        public SoftwareOathAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.softwareOathAuthenticationMethod";
        }

        /// <summary>
        /// Gets or sets secret key.
        /// The secret key of the method. Always returns null.
        /// </summary>
        [JsonPropertyName("secretKey")]
        public string SecretKey { get; set; }
    
    }
}
