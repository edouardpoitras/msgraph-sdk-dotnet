// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindows10PFXImportCertificateProfileRequest.
    /// </summary>
    public partial interface IWindows10PFXImportCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using PUT.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <returns>The created Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> CreateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate);        /// <summary>
        /// Creates the specified Windows10PFXImportCertificateProfile using PUT.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToCreate">The Windows10PFXImportCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> CreateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <returns>The Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified Windows10PFXImportCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <returns>The updated Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> UpdateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified Windows10PFXImportCertificateProfile using PATCH.
        /// </summary>
        /// <param name="windows10PFXImportCertificateProfileToUpdate">The Windows10PFXImportCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Windows10PFXImportCertificateProfile.</returns>
        System.Threading.Tasks.Task<Windows10PFXImportCertificateProfile> UpdateAsync(Windows10PFXImportCertificateProfile windows10PFXImportCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Expand(Expression<Func<Windows10PFXImportCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10PFXImportCertificateProfileRequest Select(Expression<Func<Windows10PFXImportCertificateProfile, object>> selectExpression);

    }
}
