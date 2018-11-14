// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDepIOSEnrollmentProfileWithReferenceRequest.
    /// </summary>
    public partial interface IDepIOSEnrollmentProfileWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <returns>The DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> GetAsync();

        /// <summary>
        /// Gets the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DepIOSEnrollmentProfile using PUT.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToCreate">The DepIOSEnrollmentProfile to create.</param>
        /// <returns>The created DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> CreateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToCreate);        /// <summary>
        /// Creates the specified DepIOSEnrollmentProfile using PUT.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToCreate">The DepIOSEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> CreateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile to update.</param>
        /// <returns>The updated DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> UpdateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate);

        /// <summary>
        /// Updates the specified DepIOSEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depIOSEnrollmentProfileToUpdate">The DepIOSEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DepIOSEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepIOSEnrollmentProfile> UpdateAsync(DepIOSEnrollmentProfile depIOSEnrollmentProfileToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DepIOSEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepIOSEnrollmentProfileWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepIOSEnrollmentProfileWithReferenceRequest Expand(Expression<Func<DepIOSEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDepIOSEnrollmentProfileWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDepIOSEnrollmentProfileWithReferenceRequest Select(Expression<Func<DepIOSEnrollmentProfile, object>> selectExpression);

    }
}
