// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EdiscoverySearchPurgeDataRequestBuilder.
    /// </summary>
    public partial class EdiscoverySearchPurgeDataRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<IEdiscoverySearchPurgeDataRequest>, IEdiscoverySearchPurgeDataRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EdiscoverySearchPurgeDataRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="purgeType">A purgeType parameter for the OData method call.</param>
        /// <param name="purgeAreas">A purgeAreas parameter for the OData method call.</param>
        public EdiscoverySearchPurgeDataRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            PurgeType? purgeType,
            PurgeAreas? purgeAreas)
            : base(requestUrl, client)
        {
            this.SetParameter("purgeType", purgeType, true);
            this.SetParameter("purgeAreas", purgeAreas, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEdiscoverySearchPurgeDataRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new EdiscoverySearchPurgeDataRequest(functionUrl, this.Client, options);

            if (this.HasParameter("purgeType"))
            {
                request.RequestBody.PurgeType = this.GetParameter<PurgeType?>("purgeType");
            }

            if (this.HasParameter("purgeAreas"))
            {
                request.RequestBody.PurgeAreas = this.GetParameter<PurgeAreas?>("purgeAreas");
            }

            return request;
        }
    }
}