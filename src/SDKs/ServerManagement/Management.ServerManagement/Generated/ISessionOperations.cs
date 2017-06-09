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
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SessionOperations operations.
    /// </summary>
    public partial interface ISessionOperations
    {
        /// <summary>
        /// Creates a session for a node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user.
        /// </param>
        /// <param name='userName'>
        /// Encrypted User name to be used to connect to node.
        /// </param>
        /// <param name='password'>
        /// Encrypted Password associated with user name.
        /// </param>
        /// <param name='retentionPeriod'>
        /// Session retention period. Possible values include: 'Session',
        /// 'Persistent'
        /// </param>
        /// <param name='credentialDataFormat'>
        /// Credential data format. Possible values include: 'RsaEncrypted'
        /// </param>
        /// <param name='encryptionCertificateThumbprint'>
        /// Encryption certificate thumbprint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SessionResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a session for a node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a session for a node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SessionResource>> GetWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a session for a node.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name uniquely identifies the resource group
        /// within the user subscriptionId.
        /// </param>
        /// <param name='nodeName'>
        /// The node name (256 characters maximum).
        /// </param>
        /// <param name='session'>
        /// The sessionId from the user.
        /// </param>
        /// <param name='userName'>
        /// Encrypted User name to be used to connect to node.
        /// </param>
        /// <param name='password'>
        /// Encrypted Password associated with user name.
        /// </param>
        /// <param name='retentionPeriod'>
        /// Session retention period. Possible values include: 'Session',
        /// 'Persistent'
        /// </param>
        /// <param name='credentialDataFormat'>
        /// Credential data format. Possible values include: 'RsaEncrypted'
        /// </param>
        /// <param name='encryptionCertificateThumbprint'>
        /// Encryption certificate thumbprint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SessionResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}