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
    /// The interface IProgramControlTypeRequest.
    /// </summary>
    public partial interface IProgramControlTypeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ProgramControlType using PUT.
        /// </summary>
        /// <param name="programControlTypeToCreate">The ProgramControlType to create.</param>
        /// <returns>The created ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> CreateAsync(ProgramControlType programControlTypeToCreate);        /// <summary>
        /// Creates the specified ProgramControlType using PUT.
        /// </summary>
        /// <param name="programControlTypeToCreate">The ProgramControlType to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> CreateAsync(ProgramControlType programControlTypeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ProgramControlType.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ProgramControlType.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ProgramControlType.
        /// </summary>
        /// <returns>The ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> GetAsync();

        /// <summary>
        /// Gets the specified ProgramControlType.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ProgramControlType using PATCH.
        /// </summary>
        /// <param name="programControlTypeToUpdate">The ProgramControlType to update.</param>
        /// <returns>The updated ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> UpdateAsync(ProgramControlType programControlTypeToUpdate);

        /// <summary>
        /// Updates the specified ProgramControlType using PATCH.
        /// </summary>
        /// <param name="programControlTypeToUpdate">The ProgramControlType to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ProgramControlType.</returns>
        System.Threading.Tasks.Task<ProgramControlType> UpdateAsync(ProgramControlType programControlTypeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IProgramControlTypeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IProgramControlTypeRequest Expand(Expression<Func<ProgramControlType, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IProgramControlTypeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IProgramControlTypeRequest Select(Expression<Func<ProgramControlType, object>> selectExpression);

    }
}
