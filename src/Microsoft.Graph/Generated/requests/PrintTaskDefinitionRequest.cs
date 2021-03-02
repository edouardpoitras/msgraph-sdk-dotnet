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
    /// The type PrintTaskDefinitionRequest.
    /// </summary>
    public partial class PrintTaskDefinitionRequest : BaseRequest, IPrintTaskDefinitionRequest
    {
        /// <summary>
        /// Constructs a new PrintTaskDefinitionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrintTaskDefinitionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PrintTaskDefinition using POST.
        /// </summary>
        /// <param name="printTaskDefinitionToCreate">The PrintTaskDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintTaskDefinition.</returns>
        public async System.Threading.Tasks.Task<PrintTaskDefinition> CreateAsync(PrintTaskDefinition printTaskDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PrintTaskDefinition>(printTaskDefinitionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PrintTaskDefinition using POST and returns a <see cref="GraphResponse{PrintTaskDefinition}"/> object.
        /// </summary>
        /// <param name="printTaskDefinitionToCreate">The PrintTaskDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskDefinition>> CreateResponseAsync(PrintTaskDefinition printTaskDefinitionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PrintTaskDefinition>(printTaskDefinitionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PrintTaskDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PrintTaskDefinition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PrintTaskDefinition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PrintTaskDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintTaskDefinition.</returns>
        public async System.Threading.Tasks.Task<PrintTaskDefinition> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PrintTaskDefinition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PrintTaskDefinition and returns a <see cref="GraphResponse{PrintTaskDefinition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskDefinition>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PrintTaskDefinition>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PrintTaskDefinition using PATCH.
        /// </summary>
        /// <param name="printTaskDefinitionToUpdate">The PrintTaskDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintTaskDefinition.</returns>
        public async System.Threading.Tasks.Task<PrintTaskDefinition> UpdateAsync(PrintTaskDefinition printTaskDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PrintTaskDefinition>(printTaskDefinitionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PrintTaskDefinition using PATCH and returns a <see cref="GraphResponse{PrintTaskDefinition}"/> object.
        /// </summary>
        /// <param name="printTaskDefinitionToUpdate">The PrintTaskDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintTaskDefinition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrintTaskDefinition>> UpdateResponseAsync(PrintTaskDefinition printTaskDefinitionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PrintTaskDefinition>(printTaskDefinitionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintTaskDefinitionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintTaskDefinitionRequest Expand(Expression<Func<PrintTaskDefinition, object>> expandExpression)
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
        public IPrintTaskDefinitionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintTaskDefinitionRequest Select(Expression<Func<PrintTaskDefinition, object>> selectExpression)
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
        /// <param name="printTaskDefinitionToInitialize">The <see cref="PrintTaskDefinition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PrintTaskDefinition printTaskDefinitionToInitialize)
        {

            if (printTaskDefinitionToInitialize != null && printTaskDefinitionToInitialize.AdditionalData != null)
            {

                if (printTaskDefinitionToInitialize.Tasks != null && printTaskDefinitionToInitialize.Tasks.CurrentPage != null)
                {
                    printTaskDefinitionToInitialize.Tasks.AdditionalData = printTaskDefinitionToInitialize.AdditionalData;

                    object nextPageLink;
                    printTaskDefinitionToInitialize.AdditionalData.TryGetValue("tasks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printTaskDefinitionToInitialize.Tasks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}