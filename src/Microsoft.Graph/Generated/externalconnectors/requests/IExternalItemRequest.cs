// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IExternalItemRequest.
    /// </summary>
    public partial interface IExternalItemRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ExternalItem using POST.
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalItem.</returns>
        System.Threading.Tasks.Task<ExternalItem> CreateAsync(ExternalItem externalItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ExternalItem using POST and returns a <see cref="GraphResponse{ExternalItem}"/> object.
        /// </summary>
        /// <param name="externalItemToCreate">The ExternalItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalItem>> CreateResponseAsync(ExternalItem externalItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ExternalItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ExternalItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ExternalItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalItem.</returns>
        System.Threading.Tasks.Task<ExternalItem> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ExternalItem and returns a <see cref="GraphResponse{ExternalItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalItem>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalItem using PATCH.
        /// </summary>
        /// <param name="externalItemToUpdate">The ExternalItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalItem.</returns>
        System.Threading.Tasks.Task<ExternalItem> UpdateAsync(ExternalItem externalItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalItem using PATCH and returns a <see cref="GraphResponse{ExternalItem}"/> object.
        /// </summary>
        /// <param name="externalItemToUpdate">The ExternalItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExternalItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalItem>> UpdateResponseAsync(ExternalItem externalItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalItem using PUT.
        /// </summary>
        /// <param name="externalItemToUpdate">The ExternalItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ExternalItem> PutAsync(ExternalItem externalItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ExternalItem using PUT and returns a <see cref="GraphResponse{ExternalItem}"/> object.
        /// </summary>
        /// <param name="externalItemToUpdate">The ExternalItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ExternalItem}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ExternalItem>> PutResponseAsync(ExternalItem externalItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IExternalItemRequest Expand(Expression<Func<ExternalItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IExternalItemRequest Select(Expression<Func<ExternalItem, object>> selectExpression);

    }
}