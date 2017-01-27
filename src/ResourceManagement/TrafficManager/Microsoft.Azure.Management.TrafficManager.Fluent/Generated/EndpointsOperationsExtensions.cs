// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for EndpointsOperations.
    /// </summary>
    public static partial class EndpointsOperationsExtensions
    {
            /// <summary>
            /// Update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the Update operation.
            /// </param>
            public static EndpointInner Update(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).UpdateAsync(resourceGroupName, profileName, endpointType, endpointName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the Update operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<EndpointInner> UpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint.
            /// </param>
            public static EndpointInner Get(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).GetAsync(resourceGroupName, profileName, endpointType, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<EndpointInner> GetAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be created or updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            public static EndpointInner CreateOrUpdate(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).CreateOrUpdateAsync(resourceGroupName, profileName, endpointType, endpointName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be created or updated.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The Traffic Manager endpoint parameters supplied to the CreateOrUpdate
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<EndpointInner> CreateOrUpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, EndpointInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be deleted.
            /// </param>
            public static void Delete(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).DeleteAsync(resourceGroupName, profileName, endpointType, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Traffic Manager endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Traffic Manager endpoint to
            /// be deleted.
            /// </param>
            /// <param name='profileName'>
            /// The name of the Traffic Manager profile.
            /// </param>
            /// <param name='endpointType'>
            /// The type of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='endpointName'>
            /// The name of the Traffic Manager endpoint to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointType, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointType, endpointName, null, cancellationToken).ConfigureAwait(false);
            }

    }
}