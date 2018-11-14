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
    /// The interface IAdvancedThreatProtectionOnboardingStateSummaryRequest.
    /// </summary>
    public partial interface IAdvancedThreatProtectionOnboardingStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using PUT.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> CreateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate);        /// <summary>
        /// Creates the specified AdvancedThreatProtectionOnboardingStateSummary using PUT.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToCreate">The AdvancedThreatProtectionOnboardingStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> CreateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <returns>The AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified AdvancedThreatProtectionOnboardingStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <returns>The updated AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> UpdateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified AdvancedThreatProtectionOnboardingStateSummary using PATCH.
        /// </summary>
        /// <param name="advancedThreatProtectionOnboardingStateSummaryToUpdate">The AdvancedThreatProtectionOnboardingStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AdvancedThreatProtectionOnboardingStateSummary.</returns>
        System.Threading.Tasks.Task<AdvancedThreatProtectionOnboardingStateSummary> UpdateAsync(AdvancedThreatProtectionOnboardingStateSummary advancedThreatProtectionOnboardingStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Expand(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdvancedThreatProtectionOnboardingStateSummaryRequest Select(Expression<Func<AdvancedThreatProtectionOnboardingStateSummary, object>> selectExpression);

    }
}
