// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ReportRootGetOffice365GroupsActivityGroupCountsCollectionPage.
    /// </summary>
    public partial class ReportRootGetOffice365GroupsActivityGroupCountsCollectionPage : CollectionPage<Office365GroupsActivityGroupCounts>, IReportRootGetOffice365GroupsActivityGroupCountsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetOffice365GroupsActivityGroupCountsRequest"/> instance.
        /// </summary>
        public IReportRootGetOffice365GroupsActivityGroupCountsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootGetOffice365GroupsActivityGroupCountsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
