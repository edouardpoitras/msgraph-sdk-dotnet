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
    /// The interface IEducationPointsOutcomeRequest.
    /// </summary>
    public partial interface IEducationPointsOutcomeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationPointsOutcome using POST.
        /// </summary>
        /// <param name="educationPointsOutcomeToCreate">The EducationPointsOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationPointsOutcome.</returns>
        System.Threading.Tasks.Task<EducationPointsOutcome> CreateAsync(EducationPointsOutcome educationPointsOutcomeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified EducationPointsOutcome using POST and returns a <see cref="GraphResponse{EducationPointsOutcome}"/> object.
        /// </summary>
        /// <param name="educationPointsOutcomeToCreate">The EducationPointsOutcome to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationPointsOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationPointsOutcome>> CreateResponseAsync(EducationPointsOutcome educationPointsOutcomeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationPointsOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified EducationPointsOutcome and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationPointsOutcome.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationPointsOutcome.</returns>
        System.Threading.Tasks.Task<EducationPointsOutcome> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified EducationPointsOutcome and returns a <see cref="GraphResponse{EducationPointsOutcome}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationPointsOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationPointsOutcome>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationPointsOutcome using PATCH.
        /// </summary>
        /// <param name="educationPointsOutcomeToUpdate">The EducationPointsOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationPointsOutcome.</returns>
        System.Threading.Tasks.Task<EducationPointsOutcome> UpdateAsync(EducationPointsOutcome educationPointsOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationPointsOutcome using PATCH and returns a <see cref="GraphResponse{EducationPointsOutcome}"/> object.
        /// </summary>
        /// <param name="educationPointsOutcomeToUpdate">The EducationPointsOutcome to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationPointsOutcome}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationPointsOutcome>> UpdateResponseAsync(EducationPointsOutcome educationPointsOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationPointsOutcome using PUT.
        /// </summary>
        /// <param name="educationPointsOutcomeToUpdate">The EducationPointsOutcome object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<EducationPointsOutcome> PutAsync(EducationPointsOutcome educationPointsOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified EducationPointsOutcome using PUT and returns a <see cref="GraphResponse{EducationPointsOutcome}"/> object.
        /// </summary>
        /// <param name="educationPointsOutcomeToUpdate">The EducationPointsOutcome object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{EducationPointsOutcome}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationPointsOutcome>> PutResponseAsync(EducationPointsOutcome educationPointsOutcomeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationPointsOutcomeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationPointsOutcomeRequest Expand(Expression<Func<EducationPointsOutcome, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationPointsOutcomeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationPointsOutcomeRequest Select(Expression<Func<EducationPointsOutcome, object>> selectExpression);

    }
}