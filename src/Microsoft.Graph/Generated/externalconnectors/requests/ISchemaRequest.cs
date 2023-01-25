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
    /// The interface ISchemaRequest.
    /// </summary>
    public partial interface ISchemaRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Schema using POST.
        /// </summary>
        /// <param name="schemaToCreate">The Schema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Schema.</returns>
        System.Threading.Tasks.Task<Schema> CreateAsync(Schema schemaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified Schema using POST and returns a <see cref="GraphResponse{Schema}"/> object.
        /// </summary>
        /// <param name="schemaToCreate">The Schema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Schema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Schema>> CreateResponseAsync(Schema schemaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Schema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified Schema and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Schema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Schema.</returns>
        System.Threading.Tasks.Task<Schema> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified Schema and returns a <see cref="GraphResponse{Schema}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Schema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Schema>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Schema using PATCH.
        /// </summary>
        /// <param name="schemaToUpdate">The Schema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Schema.</returns>
        System.Threading.Tasks.Task<Schema> UpdateAsync(Schema schemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Schema using PATCH and returns a <see cref="GraphResponse{Schema}"/> object.
        /// </summary>
        /// <param name="schemaToUpdate">The Schema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Schema}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Schema>> UpdateResponseAsync(Schema schemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Schema using PUT.
        /// </summary>
        /// <param name="schemaToUpdate">The Schema object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<Schema> PutAsync(Schema schemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified Schema using PUT and returns a <see cref="GraphResponse{Schema}"/> object.
        /// </summary>
        /// <param name="schemaToUpdate">The Schema object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{Schema}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<Schema>> PutResponseAsync(Schema schemaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISchemaRequest Expand(Expression<Func<Schema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISchemaRequest Select(Expression<Func<Schema, object>> selectExpression);

    }
}