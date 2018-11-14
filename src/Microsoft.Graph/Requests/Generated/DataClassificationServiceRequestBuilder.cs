// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DataClassificationServiceRequestBuilder.
    /// </summary>
    public partial class DataClassificationServiceRequestBuilder : EntityRequestBuilder, IDataClassificationServiceRequestBuilder
    {

        /// <summary>
        /// Constructs a new DataClassificationServiceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DataClassificationServiceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDataClassificationServiceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDataClassificationServiceRequest Request(IEnumerable<Option> options)
        {
            return new DataClassificationServiceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SensitiveTypes.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceSensitiveTypesCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceSensitiveTypesCollectionRequestBuilder SensitiveTypes
        {
            get
            {
                return new DataClassificationServiceSensitiveTypesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sensitiveTypes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Jobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceJobsCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceJobsCollectionRequestBuilder Jobs
        {
            get
            {
                return new DataClassificationServiceJobsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("jobs"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClassifyText.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyTextCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyTextCollectionRequestBuilder ClassifyText
        {
            get
            {
                return new DataClassificationServiceClassifyTextCollectionRequestBuilder(this.AppendSegmentToRequestUrl("classifyText"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ClassifyFile.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyFileCollectionRequestBuilder"/>.</returns>
        public IDataClassificationServiceClassifyFileCollectionRequestBuilder ClassifyFile
        {
            get
            {
                return new DataClassificationServiceClassifyFileCollectionRequestBuilder(this.AppendSegmentToRequestUrl("classifyFile"), this.Client);
            }
        }
    
    }
}
