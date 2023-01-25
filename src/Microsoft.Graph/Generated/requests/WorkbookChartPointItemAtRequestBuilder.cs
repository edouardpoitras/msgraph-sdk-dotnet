// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartPointItemAtRequestBuilder.
    /// </summary>
    public partial class WorkbookChartPointItemAtRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookChartPointItemAtRequest>, IWorkbookChartPointItemAtRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookChartPointItemAtRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        public WorkbookChartPointItemAtRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 index)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookChartPointItemAtRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookChartPointItemAtRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartPointCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointCountRequestBuilder"/>.</returns>
        public IWorkbookChartPointCountRequestBuilder Count()
        {
            return new WorkbookChartPointCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartPointItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartPointItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartPointItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartPointItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for Format.
        /// Encapsulates the format properties chart point. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointFormatRequestBuilder"/>.</returns>
        public IWorkbookChartPointFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartPointFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }
    }
}