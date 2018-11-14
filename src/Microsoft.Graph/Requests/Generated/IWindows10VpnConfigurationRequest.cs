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
    /// The interface IWindows10VpnConfigurationRequest.
    /// </summary>
    public partial interface IWindows10VpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10VpnConfiguration using PUT.
        /// </summary>
        /// <param name="windows10VpnConfigurationToCreate">The Windows10VpnConfiguration to create.</param>
        /// <returns>The created Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> CreateAsync(Windows10VpnConfiguration windows10VpnConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows10VpnConfiguration using PUT.
        /// </summary>
        /// <param name="windows10VpnConfigurationToCreate">The Windows10VpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> CreateAsync(Windows10VpnConfiguration windows10VpnConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10VpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10VpnConfiguration.
        /// </summary>
        /// <returns>The Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10VpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration to update.</param>
        /// <returns>The updated Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> UpdateAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10VpnConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10VpnConfigurationToUpdate">The Windows10VpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Windows10VpnConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10VpnConfiguration> UpdateAsync(Windows10VpnConfiguration windows10VpnConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Expand(Expression<Func<Windows10VpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10VpnConfigurationRequest Select(Expression<Func<Windows10VpnConfiguration, object>> selectExpression);

    }
}
