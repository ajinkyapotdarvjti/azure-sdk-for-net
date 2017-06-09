// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune
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
    /// IosOperations operations.
    /// </summary>
    public partial interface IIosOperations
    {
        /// <summary>
        /// Returns Intune iOSPolicies.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='select'>
        /// select specific fields in entity.
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
        Task<AzureOperationResponse<IPage<IOSMAMPolicy>>> GetMAMPoliciesWithHttpMessagesAsync(string hostName, string filter = default(string), int? top = default(int?), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns Intune iOS policies.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='select'>
        /// select specific fields in entity.
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
        Task<AzureOperationResponse<IOSMAMPolicy>> GetMAMPolicyByNameWithHttpMessagesAsync(string hostName, string policyName, string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create or update an android policy
        /// operation.
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
        Task<AzureOperationResponse<IOSMAMPolicy>> CreateOrUpdateMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, IOSMAMPolicy parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// patch an iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create or update an android policy
        /// operation.
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
        Task<AzureOperationResponse<IOSMAMPolicy>> PatchMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, IOSMAMPolicy parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Ios Policy
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
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
        Task<AzureOperationResponse> DeleteMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get apps for an iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='top'>
        /// </param>
        /// <param name='select'>
        /// select specific fields in entity.
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
        Task<AzureOperationResponse<IPage<Application>>> GetAppForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, string filter = default(string), int? top = default(int?), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add app to an iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='appName'>
        /// application unique Name
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to add an app to an ios policy.
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
        Task<AzureOperationResponse> AddAppForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, string appName, MAMPolicyAppIdOrGroupIdPayload parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete App for Ios Policy
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='appName'>
        /// application unique Name
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
        Task<AzureOperationResponse> DeleteAppForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns groups for a given iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// policy name for the tenant
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
        Task<AzureOperationResponse<IPage<GroupItem>>> GetGroupsForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add group to an iOSMAMPolicy.
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='groupId'>
        /// group Id
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create or update app to an android
        /// policy operation.
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
        Task<AzureOperationResponse> AddGroupForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, string groupId, MAMPolicyAppIdOrGroupIdPayload parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete Group for iOS Policy
        /// </summary>
        /// <param name='hostName'>
        /// Location hostName for the tenant
        /// </param>
        /// <param name='policyName'>
        /// Unique name for the policy
        /// </param>
        /// <param name='groupId'>
        /// application unique Name
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
        Task<AzureOperationResponse> DeleteGroupForMAMPolicyWithHttpMessagesAsync(string hostName, string policyName, string groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns Intune iOSPolicies.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<IOSMAMPolicy>>> GetMAMPoliciesNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get apps for an iOSMAMPolicy.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<Application>>> GetAppForMAMPolicyNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns groups for a given iOSMAMPolicy.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
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
        Task<AzureOperationResponse<IPage<GroupItem>>> GetGroupsForMAMPolicyNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}