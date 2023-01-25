// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceComplianceScheduledActionForRuleScheduledActionConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceComplianceActionItemRequestBuilder"/> for the specified DeviceComplianceScheduledActionForRuleDeviceComplianceActionItem.
        /// </summary>
        /// <param name="id">The ID for the DeviceComplianceScheduledActionForRuleDeviceComplianceActionItem.</param>
        /// <returns>The <see cref="IDeviceComplianceActionItemRequestBuilder"/>.</returns>
        public IDeviceComplianceActionItemRequestBuilder this[string id]
        {
            get
            {
                return new DeviceComplianceActionItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}