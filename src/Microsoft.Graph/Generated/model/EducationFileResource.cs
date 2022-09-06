// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type EducationFileResource.
    /// </summary>
    public partial class EducationFileResource : EducationResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationFileResource"/> class.
        /// </summary>
        public EducationFileResource()
        {
            this.ODataType = "microsoft.graph.educationFileResource";
        }

        /// <summary>
        /// Gets or sets fileUrl.
        /// Location on disk of the file resource.
        /// </summary>
        [JsonPropertyName("fileUrl")]
        public string FileUrl { get; set; }
    
    }
}