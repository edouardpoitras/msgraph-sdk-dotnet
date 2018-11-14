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
    /// The interface IDeviceManagementApplicabilityRuleOsVersionRequest.
    /// </summary>
    public partial interface IDeviceManagementApplicabilityRuleOsVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementApplicabilityRuleOsVersion using PUT.
        /// </summary>
        /// <param name="deviceManagementApplicabilityRuleOsVersionToCreate">The DeviceManagementApplicabilityRuleOsVersion to create.</param>
        /// <returns>The created DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> CreateAsync(DeviceManagementApplicabilityRuleOsVersion deviceManagementApplicabilityRuleOsVersionToCreate);        /// <summary>
        /// Creates the specified DeviceManagementApplicabilityRuleOsVersion using PUT.
        /// </summary>
        /// <param name="deviceManagementApplicabilityRuleOsVersionToCreate">The DeviceManagementApplicabilityRuleOsVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> CreateAsync(DeviceManagementApplicabilityRuleOsVersion deviceManagementApplicabilityRuleOsVersionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceManagementApplicabilityRuleOsVersion.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceManagementApplicabilityRuleOsVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementApplicabilityRuleOsVersion.
        /// </summary>
        /// <returns>The DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementApplicabilityRuleOsVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementApplicabilityRuleOsVersion using PATCH.
        /// </summary>
        /// <param name="deviceManagementApplicabilityRuleOsVersionToUpdate">The DeviceManagementApplicabilityRuleOsVersion to update.</param>
        /// <returns>The updated DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> UpdateAsync(DeviceManagementApplicabilityRuleOsVersion deviceManagementApplicabilityRuleOsVersionToUpdate);

        /// <summary>
        /// Updates the specified DeviceManagementApplicabilityRuleOsVersion using PATCH.
        /// </summary>
        /// <param name="deviceManagementApplicabilityRuleOsVersionToUpdate">The DeviceManagementApplicabilityRuleOsVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceManagementApplicabilityRuleOsVersion.</returns>
        System.Threading.Tasks.Task<DeviceManagementApplicabilityRuleOsVersion> UpdateAsync(DeviceManagementApplicabilityRuleOsVersion deviceManagementApplicabilityRuleOsVersionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementApplicabilityRuleOsVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementApplicabilityRuleOsVersionRequest Expand(Expression<Func<DeviceManagementApplicabilityRuleOsVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementApplicabilityRuleOsVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementApplicabilityRuleOsVersionRequest Select(Expression<Func<DeviceManagementApplicabilityRuleOsVersion, object>> selectExpression);

    }
}
