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
    /// The interface INotificationRequest.
    /// </summary>
    public partial interface INotificationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Notification using PUT.
        /// </summary>
        /// <param name="notificationToCreate">The Notification to create.</param>
        /// <returns>The created Notification.</returns>
        System.Threading.Tasks.Task<Notification> CreateAsync(Notification notificationToCreate);        /// <summary>
        /// Creates the specified Notification using PUT.
        /// </summary>
        /// <param name="notificationToCreate">The Notification to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Notification.</returns>
        System.Threading.Tasks.Task<Notification> CreateAsync(Notification notificationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Notification.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Notification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Notification.
        /// </summary>
        /// <returns>The Notification.</returns>
        System.Threading.Tasks.Task<Notification> GetAsync();

        /// <summary>
        /// Gets the specified Notification.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Notification.</returns>
        System.Threading.Tasks.Task<Notification> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Notification using PATCH.
        /// </summary>
        /// <param name="notificationToUpdate">The Notification to update.</param>
        /// <returns>The updated Notification.</returns>
        System.Threading.Tasks.Task<Notification> UpdateAsync(Notification notificationToUpdate);

        /// <summary>
        /// Updates the specified Notification using PATCH.
        /// </summary>
        /// <param name="notificationToUpdate">The Notification to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Notification.</returns>
        System.Threading.Tasks.Task<Notification> UpdateAsync(Notification notificationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        INotificationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        INotificationRequest Expand(Expression<Func<Notification, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        INotificationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        INotificationRequest Select(Expression<Func<Notification, object>> selectExpression);

    }
}
