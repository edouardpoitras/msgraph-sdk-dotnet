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
    /// The type EducationAssignmentPointsGradeType.
    /// </summary>
    public partial class EducationAssignmentPointsGradeType : EducationAssignmentGradeType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EducationAssignmentPointsGradeType"/> class.
        /// </summary>
        public EducationAssignmentPointsGradeType()
        {
            this.ODataType = "microsoft.graph.educationAssignmentPointsGradeType";
        }

        /// <summary>
        /// Gets or sets maxPoints.
        /// Max points possible for this assignment.
        /// </summary>
        [JsonPropertyName("maxPoints")]
        public Single? MaxPoints { get; set; }
    
    }
}