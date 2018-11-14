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
    /// The type DepOnboardingSettingRequest.
    /// </summary>
    public partial class DepOnboardingSettingRequest : BaseRequest, IDepOnboardingSettingRequest
    {
        /// <summary>
        /// Constructs a new DepOnboardingSettingRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DepOnboardingSettingRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DepOnboardingSetting using POST.
        /// </summary>
        /// <param name="depOnboardingSettingToCreate">The DepOnboardingSetting to create.</param>
        /// <returns>The created DepOnboardingSetting.</returns>
        public System.Threading.Tasks.Task<DepOnboardingSetting> CreateAsync(DepOnboardingSetting depOnboardingSettingToCreate)
        {
            return this.CreateAsync(depOnboardingSettingToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DepOnboardingSetting using POST.
        /// </summary>
        /// <param name="depOnboardingSettingToCreate">The DepOnboardingSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepOnboardingSetting.</returns>
        public async System.Threading.Tasks.Task<DepOnboardingSetting> CreateAsync(DepOnboardingSetting depOnboardingSettingToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DepOnboardingSetting>(depOnboardingSettingToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DepOnboardingSetting.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DepOnboardingSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DepOnboardingSetting>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DepOnboardingSetting.
        /// </summary>
        /// <returns>The DepOnboardingSetting.</returns>
        public System.Threading.Tasks.Task<DepOnboardingSetting> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DepOnboardingSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepOnboardingSetting.</returns>
        public async System.Threading.Tasks.Task<DepOnboardingSetting> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DepOnboardingSetting>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DepOnboardingSetting using PATCH.
        /// </summary>
        /// <param name="depOnboardingSettingToUpdate">The DepOnboardingSetting to update.</param>
        /// <returns>The updated DepOnboardingSetting.</returns>
        public System.Threading.Tasks.Task<DepOnboardingSetting> UpdateAsync(DepOnboardingSetting depOnboardingSettingToUpdate)
        {
            return this.UpdateAsync(depOnboardingSettingToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DepOnboardingSetting using PATCH.
        /// </summary>
        /// <param name="depOnboardingSettingToUpdate">The DepOnboardingSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DepOnboardingSetting.</returns>
        public async System.Threading.Tasks.Task<DepOnboardingSetting> UpdateAsync(DepOnboardingSetting depOnboardingSettingToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DepOnboardingSetting>(depOnboardingSettingToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDepOnboardingSettingRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDepOnboardingSettingRequest Expand(Expression<Func<DepOnboardingSetting, object>> expandExpression)
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
        public IDepOnboardingSettingRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDepOnboardingSettingRequest Select(Expression<Func<DepOnboardingSetting, object>> selectExpression)
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
        /// <param name="depOnboardingSettingToInitialize">The <see cref="DepOnboardingSetting"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DepOnboardingSetting depOnboardingSettingToInitialize)
        {

            if (depOnboardingSettingToInitialize != null && depOnboardingSettingToInitialize.AdditionalData != null)
            {

                if (depOnboardingSettingToInitialize.EnrollmentProfiles != null && depOnboardingSettingToInitialize.EnrollmentProfiles.CurrentPage != null)
                {
                    depOnboardingSettingToInitialize.EnrollmentProfiles.AdditionalData = depOnboardingSettingToInitialize.AdditionalData;

                    object nextPageLink;
                    depOnboardingSettingToInitialize.AdditionalData.TryGetValue("enrollmentProfiles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        depOnboardingSettingToInitialize.EnrollmentProfiles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (depOnboardingSettingToInitialize.ImportedAppleDeviceIdentities != null && depOnboardingSettingToInitialize.ImportedAppleDeviceIdentities.CurrentPage != null)
                {
                    depOnboardingSettingToInitialize.ImportedAppleDeviceIdentities.AdditionalData = depOnboardingSettingToInitialize.AdditionalData;

                    object nextPageLink;
                    depOnboardingSettingToInitialize.AdditionalData.TryGetValue("importedAppleDeviceIdentities@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        depOnboardingSettingToInitialize.ImportedAppleDeviceIdentities.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
