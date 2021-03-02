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
    /// The interface ITeamworkBotRequest.
    /// </summary>
    public partial interface ITeamworkBotRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamworkBot using POST.
        /// </summary>
        /// <param name="teamworkBotToCreate">The TeamworkBot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamworkBot.</returns>
        System.Threading.Tasks.Task<TeamworkBot> CreateAsync(TeamworkBot teamworkBotToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamworkBot using POST and returns a <see cref="GraphResponse{TeamworkBot}"/> object.
        /// </summary>
        /// <param name="teamworkBotToCreate">The TeamworkBot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkBot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkBot>> CreateResponseAsync(TeamworkBot teamworkBotToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkBot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamworkBot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkBot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamworkBot.</returns>
        System.Threading.Tasks.Task<TeamworkBot> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamworkBot and returns a <see cref="GraphResponse{TeamworkBot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamworkBot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkBot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkBot using PATCH.
        /// </summary>
        /// <param name="teamworkBotToUpdate">The TeamworkBot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamworkBot.</returns>
        System.Threading.Tasks.Task<TeamworkBot> UpdateAsync(TeamworkBot teamworkBotToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamworkBot using PATCH and returns a <see cref="GraphResponse{TeamworkBot}"/> object.
        /// </summary>
        /// <param name="teamworkBotToUpdate">The TeamworkBot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamworkBot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamworkBot>> UpdateResponseAsync(TeamworkBot teamworkBotToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkBotRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkBotRequest Expand(Expression<Func<TeamworkBot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkBotRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamworkBotRequest Select(Expression<Func<TeamworkBot, object>> selectExpression);

    }
}