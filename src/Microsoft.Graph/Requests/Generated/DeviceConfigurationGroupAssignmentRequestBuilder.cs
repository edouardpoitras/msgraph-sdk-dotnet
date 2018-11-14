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
    /// The type DeviceConfigurationGroupAssignmentRequestBuilder.
    /// </summary>
    public partial class DeviceConfigurationGroupAssignmentRequestBuilder : EntityRequestBuilder, IDeviceConfigurationGroupAssignmentRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceConfigurationGroupAssignmentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceConfigurationGroupAssignmentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationGroupAssignmentRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceConfigurationGroupAssignmentRequest Request(IEnumerable<Option> options)
        {
            return new DeviceConfigurationGroupAssignmentRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DeviceConfiguration.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationWithReferenceRequestBuilder"/>.</returns>
        public IDeviceConfigurationWithReferenceRequestBuilder DeviceConfiguration
        {
            get
            {
                return new DeviceConfigurationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("deviceConfiguration"), this.Client);
            }
        }
    
    }
}
