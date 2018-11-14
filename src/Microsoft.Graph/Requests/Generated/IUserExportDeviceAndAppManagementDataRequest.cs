// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IUserExportDeviceAndAppManagementDataRequest.
    /// </summary>
    public partial interface IUserExportDeviceAndAppManagementDataRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> GetAsync();
        
        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> GetAsync(
            CancellationToken cancellationToken);
  


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> PatchAsync(DeviceAndAppManagementData deviceandappmanagementdata);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> PatchAsync(DeviceAndAppManagementData deviceandappmanagementdata, 
            CancellationToken cancellationToken);
          

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> PutAsync(DeviceAndAppManagementData deviceandappmanagementdata);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="deviceandappmanagementdata">The DeviceAndAppManagementData object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementData> PutAsync(DeviceAndAppManagementData deviceandappmanagementdata, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExportDeviceAndAppManagementDataRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExportDeviceAndAppManagementDataRequest Select(string value);
    }
}
