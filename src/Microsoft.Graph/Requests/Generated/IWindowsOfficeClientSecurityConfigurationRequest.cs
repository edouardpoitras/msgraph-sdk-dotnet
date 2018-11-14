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
    /// The interface IWindowsOfficeClientSecurityConfigurationRequest.
    /// </summary>
    public partial interface IWindowsOfficeClientSecurityConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsOfficeClientSecurityConfiguration using PUT.
        /// </summary>
        /// <param name="windowsOfficeClientSecurityConfigurationToCreate">The WindowsOfficeClientSecurityConfiguration to create.</param>
        /// <returns>The created WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> CreateAsync(WindowsOfficeClientSecurityConfiguration windowsOfficeClientSecurityConfigurationToCreate);        /// <summary>
        /// Creates the specified WindowsOfficeClientSecurityConfiguration using PUT.
        /// </summary>
        /// <param name="windowsOfficeClientSecurityConfigurationToCreate">The WindowsOfficeClientSecurityConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> CreateAsync(WindowsOfficeClientSecurityConfiguration windowsOfficeClientSecurityConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsOfficeClientSecurityConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsOfficeClientSecurityConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsOfficeClientSecurityConfiguration.
        /// </summary>
        /// <returns>The WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified WindowsOfficeClientSecurityConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsOfficeClientSecurityConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsOfficeClientSecurityConfigurationToUpdate">The WindowsOfficeClientSecurityConfiguration to update.</param>
        /// <returns>The updated WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> UpdateAsync(WindowsOfficeClientSecurityConfiguration windowsOfficeClientSecurityConfigurationToUpdate);

        /// <summary>
        /// Updates the specified WindowsOfficeClientSecurityConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsOfficeClientSecurityConfigurationToUpdate">The WindowsOfficeClientSecurityConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WindowsOfficeClientSecurityConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsOfficeClientSecurityConfiguration> UpdateAsync(WindowsOfficeClientSecurityConfiguration windowsOfficeClientSecurityConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientSecurityConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientSecurityConfigurationRequest Expand(Expression<Func<WindowsOfficeClientSecurityConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientSecurityConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsOfficeClientSecurityConfigurationRequest Select(Expression<Func<WindowsOfficeClientSecurityConfiguration, object>> selectExpression);

    }
}
