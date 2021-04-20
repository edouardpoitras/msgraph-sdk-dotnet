// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IAccessReviewScheduleDefinitionFilterByCurrentUserCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<AccessReviewScheduleDefinitionFilterByCurrentUserCollectionPage>))]
    public interface IAccessReviewScheduleDefinitionFilterByCurrentUserCollectionPage : ICollectionPage<AccessReviewScheduleDefinition>
    {
        /// <summary>
        /// Gets the next page <see cref="IAccessReviewScheduleDefinitionFilterByCurrentUserRequest"/> instance.
        /// </summary>
        IAccessReviewScheduleDefinitionFilterByCurrentUserRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
