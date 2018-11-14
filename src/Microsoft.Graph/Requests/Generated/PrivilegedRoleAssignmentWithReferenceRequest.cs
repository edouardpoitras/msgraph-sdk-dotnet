// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PrivilegedRoleAssignmentWithReferenceRequest.
    /// </summary>
    public partial class PrivilegedRoleAssignmentWithReferenceRequest : BaseRequest, IPrivilegedRoleAssignmentWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new PrivilegedRoleAssignmentWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrivilegedRoleAssignmentWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <returns>The PrivilegedRoleAssignment.</returns>
        public System.Threading.Tasks.Task<PrivilegedRoleAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PrivilegedRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified PrivilegedRoleAssignment using POST.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToCreate">The PrivilegedRoleAssignment to create.</param>
        /// <returns>The created PrivilegedRoleAssignment.</returns>
        public System.Threading.Tasks.Task<PrivilegedRoleAssignment> CreateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToCreate)
        {
            return this.CreateAsync(privilegedRoleAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PrivilegedRoleAssignment using POST.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToCreate">The PrivilegedRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleAssignment> CreateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PrivilegedRoleAssignment>(privilegedRoleAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified PrivilegedRoleAssignment using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToUpdate">The PrivilegedRoleAssignment to update.</param>
        /// <returns>The updated PrivilegedRoleAssignment.</returns>
        public System.Threading.Tasks.Task<PrivilegedRoleAssignment> UpdateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToUpdate)
        {
            return this.UpdateAsync(privilegedRoleAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PrivilegedRoleAssignment using PATCH.
        /// </summary>
        /// <param name="privilegedRoleAssignmentToUpdate">The PrivilegedRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PrivilegedRoleAssignment.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleAssignment> UpdateAsync(PrivilegedRoleAssignment privilegedRoleAssignmentToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PrivilegedRoleAssignment>(privilegedRoleAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PrivilegedRoleAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Expand(Expression<Func<PrivilegedRoleAssignment, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleAssignmentWithReferenceRequest Select(Expression<Func<PrivilegedRoleAssignment, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

    }
}
