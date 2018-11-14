// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type YammerDeviceUsageUserDetailRequest.
    /// </summary>
    public partial class YammerDeviceUsageUserDetailRequest : BaseRequest, IYammerDeviceUsageUserDetailRequest
    {
        /// <summary>
        /// Constructs a new YammerDeviceUsageUserDetailRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public YammerDeviceUsageUserDetailRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using POST.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <returns>The created YammerDeviceUsageUserDetail.</returns>
        public System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> CreateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate)
        {
            return this.CreateAsync(yammerDeviceUsageUserDetailToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using POST.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerDeviceUsageUserDetail.</returns>
        public async System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> CreateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<YammerDeviceUsageUserDetail>(yammerDeviceUsageUserDetailToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<YammerDeviceUsageUserDetail>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The YammerDeviceUsageUserDetail.</returns>
        public System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerDeviceUsageUserDetail.</returns>
        public async System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<YammerDeviceUsageUserDetail>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <returns>The updated YammerDeviceUsageUserDetail.</returns>
        public System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> UpdateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate)
        {
            return this.UpdateAsync(yammerDeviceUsageUserDetailToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated YammerDeviceUsageUserDetail.</returns>
        public async System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> UpdateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<YammerDeviceUsageUserDetail>(yammerDeviceUsageUserDetailToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerDeviceUsageUserDetailRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerDeviceUsageUserDetailRequest Expand(Expression<Func<YammerDeviceUsageUserDetail, object>> expandExpression)
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
        public IYammerDeviceUsageUserDetailRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IYammerDeviceUsageUserDetailRequest Select(Expression<Func<YammerDeviceUsageUserDetail, object>> selectExpression)
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
        /// <param name="yammerDeviceUsageUserDetailToInitialize">The <see cref="YammerDeviceUsageUserDetail"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToInitialize)
        {

        }
    }
}
