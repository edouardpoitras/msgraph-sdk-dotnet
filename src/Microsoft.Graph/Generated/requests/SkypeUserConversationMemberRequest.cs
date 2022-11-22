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
    /// The type SkypeUserConversationMemberRequest.
    /// </summary>
    public partial class SkypeUserConversationMemberRequest : BaseRequest, ISkypeUserConversationMemberRequest
    {
        /// <summary>
        /// Constructs a new SkypeUserConversationMemberRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SkypeUserConversationMemberRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SkypeUserConversationMember using POST.
        /// </summary>
        /// <param name="skypeUserConversationMemberToCreate">The SkypeUserConversationMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeUserConversationMember.</returns>
        public async System.Threading.Tasks.Task<SkypeUserConversationMember> CreateAsync(SkypeUserConversationMember skypeUserConversationMemberToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<SkypeUserConversationMember>(skypeUserConversationMemberToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified SkypeUserConversationMember using POST and returns a <see cref="GraphResponse{SkypeUserConversationMember}"/> object.
        /// </summary>
        /// <param name="skypeUserConversationMemberToCreate">The SkypeUserConversationMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeUserConversationMember}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeUserConversationMember>> CreateResponseAsync(SkypeUserConversationMember skypeUserConversationMemberToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<SkypeUserConversationMember>(skypeUserConversationMemberToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified SkypeUserConversationMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<SkypeUserConversationMember>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified SkypeUserConversationMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified SkypeUserConversationMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeUserConversationMember.</returns>
        public async System.Threading.Tasks.Task<SkypeUserConversationMember> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<SkypeUserConversationMember>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified SkypeUserConversationMember and returns a <see cref="GraphResponse{SkypeUserConversationMember}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeUserConversationMember}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeUserConversationMember>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<SkypeUserConversationMember>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SkypeUserConversationMember using PATCH.
        /// </summary>
        /// <param name="skypeUserConversationMemberToUpdate">The SkypeUserConversationMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeUserConversationMember.</returns>
        public async System.Threading.Tasks.Task<SkypeUserConversationMember> UpdateAsync(SkypeUserConversationMember skypeUserConversationMemberToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<SkypeUserConversationMember>(skypeUserConversationMemberToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeUserConversationMember using PATCH and returns a <see cref="GraphResponse{SkypeUserConversationMember}"/> object.
        /// </summary>
        /// <param name="skypeUserConversationMemberToUpdate">The SkypeUserConversationMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeUserConversationMember}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeUserConversationMember>> UpdateResponseAsync(SkypeUserConversationMember skypeUserConversationMemberToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<SkypeUserConversationMember>(skypeUserConversationMemberToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified SkypeUserConversationMember using PUT.
        /// </summary>
        /// <param name="skypeUserConversationMemberToUpdate">The SkypeUserConversationMember object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<SkypeUserConversationMember> PutAsync(SkypeUserConversationMember skypeUserConversationMemberToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<SkypeUserConversationMember>(skypeUserConversationMemberToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified SkypeUserConversationMember using PUT and returns a <see cref="GraphResponse{SkypeUserConversationMember}"/> object.
        /// </summary>
        /// <param name="skypeUserConversationMemberToUpdate">The SkypeUserConversationMember object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{SkypeUserConversationMember}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<SkypeUserConversationMember>> PutResponseAsync(SkypeUserConversationMember skypeUserConversationMemberToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<SkypeUserConversationMember>(skypeUserConversationMemberToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeUserConversationMemberRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeUserConversationMemberRequest Expand(Expression<Func<SkypeUserConversationMember, object>> expandExpression)
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
        public ISkypeUserConversationMemberRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISkypeUserConversationMemberRequest Select(Expression<Func<SkypeUserConversationMember, object>> selectExpression)
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
        /// <param name="skypeUserConversationMemberToInitialize">The <see cref="SkypeUserConversationMember"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SkypeUserConversationMember skypeUserConversationMemberToInitialize)
        {

        }
    }
}