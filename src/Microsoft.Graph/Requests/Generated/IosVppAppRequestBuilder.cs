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
    /// The type IosVppAppRequestBuilder.
    /// </summary>
    public partial class IosVppAppRequestBuilder : MobileAppRequestBuilder, IIosVppAppRequestBuilder
    {

        /// <summary>
        /// Constructs a new IosVppAppRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IosVppAppRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IIosVppAppRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IIosVppAppRequest Request(IEnumerable<Option> options)
        {
            return new IosVppAppRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AssignedLicenses.
        /// </summary>
        /// <returns>The <see cref="IIosVppAppAssignedLicensesCollectionRequestBuilder"/>.</returns>
        public IIosVppAppAssignedLicensesCollectionRequestBuilder AssignedLicenses
        {
            get
            {
                return new IosVppAppAssignedLicensesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignedLicenses"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for IosVppAppRevokeAllLicenses.
        /// </summary>
        /// <returns>The <see cref="IIosVppAppRevokeAllLicensesRequestBuilder"/>.</returns>
        public IIosVppAppRevokeAllLicensesRequestBuilder RevokeAllLicenses(
            bool notifyManagedDevices)
        {
            return new IosVppAppRevokeAllLicensesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.revokeAllLicenses"),
                this.Client,
                notifyManagedDevices);
        }

        /// <summary>
        /// Gets the request builder for IosVppAppRevokeUserLicense.
        /// </summary>
        /// <returns>The <see cref="IIosVppAppRevokeUserLicenseRequestBuilder"/>.</returns>
        public IIosVppAppRevokeUserLicenseRequestBuilder RevokeUserLicense(
            bool notifyManagedDevices,
            string userId = null)
        {
            return new IosVppAppRevokeUserLicenseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.revokeUserLicense"),
                this.Client,
                notifyManagedDevices,
                userId);
        }

        /// <summary>
        /// Gets the request builder for IosVppAppRevokeDeviceLicense.
        /// </summary>
        /// <returns>The <see cref="IIosVppAppRevokeDeviceLicenseRequestBuilder"/>.</returns>
        public IIosVppAppRevokeDeviceLicenseRequestBuilder RevokeDeviceLicense(
            bool notifyManagedDevices,
            string managedDeviceId = null)
        {
            return new IosVppAppRevokeDeviceLicenseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.revokeDeviceLicense"),
                this.Client,
                notifyManagedDevices,
                managedDeviceId);
        }
    
    }
}
