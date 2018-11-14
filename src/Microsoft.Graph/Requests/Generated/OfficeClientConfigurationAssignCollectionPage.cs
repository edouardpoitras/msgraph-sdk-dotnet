// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type OfficeClientConfigurationAssignCollectionPage.
    /// </summary>
    public partial class OfficeClientConfigurationAssignCollectionPage : CollectionPage<OfficeClientConfigurationAssignment>, IOfficeClientConfigurationAssignCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IOfficeClientConfigurationAssignRequest"/> instance.
        /// </summary>
        public IOfficeClientConfigurationAssignRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new OfficeClientConfigurationAssignRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
