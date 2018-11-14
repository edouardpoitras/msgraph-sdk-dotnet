// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ReportRootGetYammerDeviceUsageDistributionUserCountsCollectionPage.
    /// </summary>
    public partial class ReportRootGetYammerDeviceUsageDistributionUserCountsCollectionPage : CollectionPage<YammerDeviceUsageDistributionUserCounts>, IReportRootGetYammerDeviceUsageDistributionUserCountsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetYammerDeviceUsageDistributionUserCountsRequest"/> instance.
        /// </summary>
        public IReportRootGetYammerDeviceUsageDistributionUserCountsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootGetYammerDeviceUsageDistributionUserCountsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
