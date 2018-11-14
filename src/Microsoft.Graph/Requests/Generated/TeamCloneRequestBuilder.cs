// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type TeamCloneRequestBuilder.
    /// </summary>
    public partial class TeamCloneRequestBuilder : BaseActionMethodRequestBuilder<ITeamCloneRequest>, ITeamCloneRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="TeamCloneRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="visibility">A visibility parameter for the OData method call.</param>
        /// <param name="partsToClone">A partsToClone parameter for the OData method call.</param>
        /// <param name="displayName">A displayName parameter for the OData method call.</param>
        /// <param name="description">A description parameter for the OData method call.</param>
        /// <param name="mailNickname">A mailNickname parameter for the OData method call.</param>
        /// <param name="classification">A classification parameter for the OData method call.</param>
        public TeamCloneRequestBuilder(
            string requestUrl,
            IBaseClient client,
            TeamVisibilityType visibility,
            ClonableTeamParts partsToClone,
            string displayName,
            string description,
            string mailNickname,
            string classification)
            : base(requestUrl, client)
        {
            this.SetParameter("visibility", visibility, false);
            this.SetParameter("partsToClone", partsToClone, false);
            this.SetParameter("displayName", displayName, true);
            this.SetParameter("description", description, true);
            this.SetParameter("mailNickname", mailNickname, true);
            this.SetParameter("classification", classification, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ITeamCloneRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new TeamCloneRequest(functionUrl, this.Client, options);

            if (this.HasParameter("visibility"))
            {
                request.RequestBody.Visibility = this.GetParameter<TeamVisibilityType>("visibility");
            }

            if (this.HasParameter("partsToClone"))
            {
                request.RequestBody.PartsToClone = this.GetParameter<ClonableTeamParts>("partsToClone");
            }

            if (this.HasParameter("displayName"))
            {
                request.RequestBody.DisplayName = this.GetParameter<string>("displayName");
            }

            if (this.HasParameter("description"))
            {
                request.RequestBody.Description = this.GetParameter<string>("description");
            }

            if (this.HasParameter("mailNickname"))
            {
                request.RequestBody.MailNickname = this.GetParameter<string>("mailNickname");
            }

            if (this.HasParameter("classification"))
            {
                request.RequestBody.Classification = this.GetParameter<string>("classification");
            }

            return request;
        }
    }
}
