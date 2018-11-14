// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceCommandsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceCommandsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceCommandsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceCommandsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICommandRequestBuilder"/> for the specified Command.
        /// </summary>
        /// <param name="id">The ID for the Command.</param>
        /// <returns>The <see cref="ICommandRequestBuilder"/>.</returns>
        ICommandRequestBuilder this[string id] { get; }

        
    }
}
