// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrivilegedRoleAssignmentsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedRoleAssignmentsCollectionWithReferencesRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrivilegedRoleAssignmentsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrivilegedRoleAssignmentsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedRoleAssignmentWithReferenceRequestBuilder"/> for the specified PrivilegedRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedRoleAssignment.</param>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentWithReferenceRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IPrivilegedRoleAssignmentsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentsCollectionReferencesRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentsCollectionReferencesRequestBuilder References { get; }

    }
}
