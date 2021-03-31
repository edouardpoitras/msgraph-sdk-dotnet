// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type RbacApplicationRequest.
    /// </summary>
    public partial class RbacApplicationRequest : BaseRequest, IRbacApplicationRequest
    {
        /// <summary>
        /// Constructs a new RbacApplicationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RbacApplicationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RbacApplication using POST.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> CreateAsync(RbacApplication rbacApplicationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<RbacApplication>(rbacApplicationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified RbacApplication using POST and returns a <see cref="GraphResponse{RbacApplication}"/> object.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RbacApplication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RbacApplication>> CreateResponseAsync(RbacApplication rbacApplicationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<RbacApplication>(rbacApplicationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<RbacApplication>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified RbacApplication and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<RbacApplication>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified RbacApplication and returns a <see cref="GraphResponse{RbacApplication}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RbacApplication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RbacApplication>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<RbacApplication>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RbacApplication using PATCH.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> UpdateAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<RbacApplication>(rbacApplicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RbacApplication using PATCH and returns a <see cref="GraphResponse{RbacApplication}"/> object.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RbacApplication}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RbacApplication>> UpdateResponseAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<RbacApplication>(rbacApplicationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified RbacApplication using PUT.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> PutAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<RbacApplication>(rbacApplicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified RbacApplication using PUT and returns a <see cref="GraphResponse{RbacApplication}"/> object.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{RbacApplication}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<RbacApplication>> PutResponseAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<RbacApplication>(rbacApplicationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Expand(Expression<Func<RbacApplication, object>> expandExpression)
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
        public IRbacApplicationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Select(Expression<Func<RbacApplication, object>> selectExpression)
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

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="rbacApplicationToInitialize">The <see cref="RbacApplication"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RbacApplication rbacApplicationToInitialize)
        {

            if (rbacApplicationToInitialize != null && rbacApplicationToInitialize.AdditionalData != null)
            {

                if (rbacApplicationToInitialize.RoleAssignments != null && rbacApplicationToInitialize.RoleAssignments.CurrentPage != null)
                {
                    rbacApplicationToInitialize.RoleAssignments.AdditionalData = rbacApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationToInitialize.AdditionalData.TryGetValue("roleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationToInitialize.RoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (rbacApplicationToInitialize.RoleDefinitions != null && rbacApplicationToInitialize.RoleDefinitions.CurrentPage != null)
                {
                    rbacApplicationToInitialize.RoleDefinitions.AdditionalData = rbacApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationToInitialize.AdditionalData.TryGetValue("roleDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationToInitialize.RoleDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
