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
    /// The interface IRoleManagementRequest.
    /// </summary>
    public partial interface IRoleManagementRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RoleManagement using POST.
        /// </summary>
        /// <param name="roleManagementToCreate">The RoleManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RoleManagement.</returns>
        System.Threading.Tasks.Task<RoleManagement> CreateAsync(RoleManagement roleManagementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified RoleManagement using POST and returns a <see cref="GraphResponse{RoleManagement}"/> object.
        /// </summary>
        /// <param name="roleManagementToCreate">The RoleManagement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RoleManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleManagement>> CreateResponseAsync(RoleManagement roleManagementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RoleManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RoleManagement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RoleManagement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RoleManagement.</returns>
        System.Threading.Tasks.Task<RoleManagement> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RoleManagement and returns a <see cref="GraphResponse{RoleManagement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RoleManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleManagement>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RoleManagement using PATCH.
        /// </summary>
        /// <param name="roleManagementToUpdate">The RoleManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RoleManagement.</returns>
        System.Threading.Tasks.Task<RoleManagement> UpdateAsync(RoleManagement roleManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RoleManagement using PATCH and returns a <see cref="GraphResponse{RoleManagement}"/> object.
        /// </summary>
        /// <param name="roleManagementToUpdate">The RoleManagement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RoleManagement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleManagement>> UpdateResponseAsync(RoleManagement roleManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RoleManagement using PUT.
        /// </summary>
        /// <param name="roleManagementToUpdate">The RoleManagement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<RoleManagement> PutAsync(RoleManagement roleManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RoleManagement using PUT and returns a <see cref="GraphResponse{RoleManagement}"/> object.
        /// </summary>
        /// <param name="roleManagementToUpdate">The RoleManagement object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{RoleManagement}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<RoleManagement>> PutResponseAsync(RoleManagement roleManagementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleManagementRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRoleManagementRequest Expand(Expression<Func<RoleManagement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleManagementRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRoleManagementRequest Select(Expression<Func<RoleManagement, object>> selectExpression);

    }
}