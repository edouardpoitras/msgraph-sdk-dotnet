// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IRestrictedAppsViolationRequest.
    /// </summary>
    public partial interface IRestrictedAppsViolationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RestrictedAppsViolation using PUT.
        /// </summary>
        /// <param name="restrictedAppsViolationToCreate">The RestrictedAppsViolation to create.</param>
        /// <returns>The created RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> CreateAsync(RestrictedAppsViolation restrictedAppsViolationToCreate);        /// <summary>
        /// Creates the specified RestrictedAppsViolation using PUT.
        /// </summary>
        /// <param name="restrictedAppsViolationToCreate">The RestrictedAppsViolation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> CreateAsync(RestrictedAppsViolation restrictedAppsViolationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified RestrictedAppsViolation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified RestrictedAppsViolation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified RestrictedAppsViolation.
        /// </summary>
        /// <returns>The RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> GetAsync();

        /// <summary>
        /// Gets the specified RestrictedAppsViolation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified RestrictedAppsViolation using PATCH.
        /// </summary>
        /// <param name="restrictedAppsViolationToUpdate">The RestrictedAppsViolation to update.</param>
        /// <returns>The updated RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> UpdateAsync(RestrictedAppsViolation restrictedAppsViolationToUpdate);

        /// <summary>
        /// Updates the specified RestrictedAppsViolation using PATCH.
        /// </summary>
        /// <param name="restrictedAppsViolationToUpdate">The RestrictedAppsViolation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated RestrictedAppsViolation.</returns>
        System.Threading.Tasks.Task<RestrictedAppsViolation> UpdateAsync(RestrictedAppsViolation restrictedAppsViolationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedAppsViolationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedAppsViolationRequest Expand(Expression<Func<RestrictedAppsViolation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedAppsViolationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRestrictedAppsViolationRequest Select(Expression<Func<RestrictedAppsViolation, object>> selectExpression);

    }
}
