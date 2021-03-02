// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
    /// </summary>
    public partial class Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder : BaseRequestBuilder, IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IFido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new Fido2AuthenticationMethodConfigurationIncludeTargetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAuthenticationMethodTargetRequestBuilder"/> for the specified Fido2AuthenticationMethodConfigurationAuthenticationMethodTarget.
        /// </summary>
        /// <param name="id">The ID for the Fido2AuthenticationMethodConfigurationAuthenticationMethodTarget.</param>
        /// <returns>The <see cref="IAuthenticationMethodTargetRequestBuilder"/>.</returns>
        public IAuthenticationMethodTargetRequestBuilder this[string id]
        {
            get
            {
                return new AuthenticationMethodTargetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}