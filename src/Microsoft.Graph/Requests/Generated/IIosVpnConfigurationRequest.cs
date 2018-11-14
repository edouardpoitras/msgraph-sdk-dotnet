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
    /// The interface IIosVpnConfigurationRequest.
    /// </summary>
    public partial interface IIosVpnConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosVpnConfiguration using PUT.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <returns>The created IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> CreateAsync(IosVpnConfiguration iosVpnConfigurationToCreate);        /// <summary>
        /// Creates the specified IosVpnConfiguration using PUT.
        /// </summary>
        /// <param name="iosVpnConfigurationToCreate">The IosVpnConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> CreateAsync(IosVpnConfiguration iosVpnConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosVpnConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosVpnConfiguration.
        /// </summary>
        /// <returns>The IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified IosVpnConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <returns>The updated IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> UpdateAsync(IosVpnConfiguration iosVpnConfigurationToUpdate);

        /// <summary>
        /// Updates the specified IosVpnConfiguration using PATCH.
        /// </summary>
        /// <param name="iosVpnConfigurationToUpdate">The IosVpnConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosVpnConfiguration.</returns>
        System.Threading.Tasks.Task<IosVpnConfiguration> UpdateAsync(IosVpnConfiguration iosVpnConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Expand(Expression<Func<IosVpnConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosVpnConfigurationRequest Select(Expression<Func<IosVpnConfiguration, object>> selectExpression);

    }
}
