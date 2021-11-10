// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IConnectedOrganizationRequest.
    /// </summary>
    public partial interface IConnectedOrganizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConnectedOrganization using POST.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectedOrganization.</returns>
        System.Threading.Tasks.Task<ConnectedOrganization> CreateAsync(ConnectedOrganization connectedOrganizationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ConnectedOrganization using POST and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToCreate">The ConnectedOrganization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> CreateResponseAsync(ConnectedOrganization connectedOrganizationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConnectedOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConnectedOrganization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConnectedOrganization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectedOrganization.</returns>
        System.Threading.Tasks.Task<ConnectedOrganization> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConnectedOrganization and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectedOrganization using PATCH.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectedOrganization.</returns>
        System.Threading.Tasks.Task<ConnectedOrganization> UpdateAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectedOrganization using PATCH and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConnectedOrganization}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> UpdateResponseAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectedOrganization using PUT.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ConnectedOrganization> PutAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectedOrganization using PUT and returns a <see cref="GraphResponse{ConnectedOrganization}"/> object.
        /// </summary>
        /// <param name="connectedOrganizationToUpdate">The ConnectedOrganization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ConnectedOrganization}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectedOrganization>> PutResponseAsync(ConnectedOrganization connectedOrganizationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectedOrganizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectedOrganizationRequest Expand(Expression<Func<ConnectedOrganization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectedOrganizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectedOrganizationRequest Select(Expression<Func<ConnectedOrganization, object>> selectExpression);

    }
}
