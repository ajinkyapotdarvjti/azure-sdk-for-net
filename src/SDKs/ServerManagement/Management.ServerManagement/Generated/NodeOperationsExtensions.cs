// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NodeOperations.
    /// </summary>
    public static partial class NodeOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            public static NodeResource Create(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return operations.CreateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> CreateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            public static NodeResource Update(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> UpdateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// deletes a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            public static void Delete(this INodeOperations operations, string resourceGroupName, string nodeName)
            {
                operations.DeleteAsync(resourceGroupName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// deletes a management node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INodeOperations operations, string resourceGroupName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, nodeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            public static NodeResource Get(this INodeOperations operations, string resourceGroupName, string nodeName)
            {
                return operations.GetAsync(resourceGroupName, nodeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> GetAsync(this INodeOperations operations, string resourceGroupName, string nodeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, nodeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists nodes in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NodeResource> List(this INodeOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists nodes in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeResource>> ListAsync(this INodeOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists nodes in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            public static IPage<NodeResource> ListForResourceGroup(this INodeOperations operations, string resourceGroupName)
            {
                return operations.ListForResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists nodes in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeResource>> ListForResourceGroupAsync(this INodeOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            public static NodeResource BeginCreate(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return operations.BeginCreateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> BeginCreateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            public static NodeResource BeginUpdate(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
            {
                return operations.BeginUpdateAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a management node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='gatewayId'>
            /// Gateway ID which will manage this node.
            /// </param>
            /// <param name='connectionName'>
            /// myhost.domain.com
            /// </param>
            /// <param name='userName'>
            /// User name to be used to connect to node.
            /// </param>
            /// <param name='password'>
            /// Password associated with user name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeResource> BeginUpdateAsync(this INodeOperations operations, string resourceGroupName, string nodeName, string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, nodeName, location, tags, gatewayId, connectionName, userName, password, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists nodes in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NodeResource> ListNext(this INodeOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists nodes in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeResource>> ListNextAsync(this INodeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists nodes in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NodeResource> ListForResourceGroupNext(this INodeOperations operations, string nextPageLink)
            {
                return operations.ListForResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists nodes in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeResource>> ListForResourceGroupNextAsync(this INodeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListForResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}