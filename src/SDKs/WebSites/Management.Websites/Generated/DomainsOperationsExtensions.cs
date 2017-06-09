// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DomainsOperations.
    /// </summary>
    public static partial class DomainsOperationsExtensions
    {
            /// <summary>
            /// Check if a domain is available for registration.
            /// </summary>
            /// <remarks>
            /// Check if a domain is available for registration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain.
            /// </param>
            public static DomainAvailablilityCheckResult CheckAvailability(this IDomainsOperations operations, NameIdentifier identifier)
            {
                return operations.CheckAvailabilityAsync(identifier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if a domain is available for registration.
            /// </summary>
            /// <remarks>
            /// Check if a domain is available for registration.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainAvailablilityCheckResult> CheckAvailabilityAsync(this IDomainsOperations operations, NameIdentifier identifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckAvailabilityWithHttpMessagesAsync(identifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all domains in a subscription.
            /// </summary>
            /// <remarks>
            /// Get all domains in a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Domain> List(this IDomainsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all domains in a subscription.
            /// </summary>
            /// <remarks>
            /// Get all domains in a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListAsync(this IDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generate a single sign-on request for the domain management portal.
            /// </summary>
            /// <remarks>
            /// Generate a single sign-on request for the domain management portal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DomainControlCenterSsoRequest GetControlCenterSsoRequest(this IDomainsOperations operations)
            {
                return operations.GetControlCenterSsoRequestAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate a single sign-on request for the domain management portal.
            /// </summary>
            /// <remarks>
            /// Generate a single sign-on request for the domain management portal.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainControlCenterSsoRequest> GetControlCenterSsoRequestAsync(this IDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetControlCenterSsoRequestWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get domain name recommendations based on keywords.
            /// </summary>
            /// <remarks>
            /// Get domain name recommendations based on keywords.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Search parameters for domain name recommendations.
            /// </param>
            public static IPage<NameIdentifier> ListRecommendations(this IDomainsOperations operations, DomainRecommendationSearchParameters parameters)
            {
                return operations.ListRecommendationsAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get domain name recommendations based on keywords.
            /// </summary>
            /// <remarks>
            /// Get domain name recommendations based on keywords.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Search parameters for domain name recommendations.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NameIdentifier>> ListRecommendationsAsync(this IDomainsOperations operations, DomainRecommendationSearchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendationsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all domains in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all domains in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            public static IPage<Domain> ListByResourceGroup(this IDomainsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all domains in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all domains in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListByResourceGroupAsync(this IDomainsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a domain.
            /// </summary>
            /// <remarks>
            /// Get a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            public static Domain Get(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                return operations.GetAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a domain.
            /// </summary>
            /// <remarks>
            /// Get a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> GetAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a domain.
            /// </summary>
            /// <remarks>
            /// Creates or updates a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='domain'>
            /// Domain registration information.
            /// </param>
            public static Domain CreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, domainName, domain).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a domain.
            /// </summary>
            /// <remarks>
            /// Creates or updates a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='domain'>
            /// Domain registration information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> CreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a domain.
            /// </summary>
            /// <remarks>
            /// Delete a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='forceHardDeleteDomain'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to delete the domain immediately. The
            /// default is &lt;code&gt;false&lt;/code&gt; which deletes the domain after 24
            /// hours.
            /// </param>
            public static void Delete(this IDomainsOperations operations, string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?))
            {
                operations.DeleteAsync(resourceGroupName, domainName, forceHardDeleteDomain).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a domain.
            /// </summary>
            /// <remarks>
            /// Delete a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='forceHardDeleteDomain'>
            /// Specify &lt;code&gt;true&lt;/code&gt; to delete the domain immediately. The
            /// default is &lt;code&gt;false&lt;/code&gt; which deletes the domain after 24
            /// hours.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, domainName, forceHardDeleteDomain, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists domain ownership identifiers.
            /// </summary>
            /// <remarks>
            /// Lists domain ownership identifiers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            public static IPage<DomainOwnershipIdentifier> ListOwnershipIdentifiers(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                return operations.ListOwnershipIdentifiersAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domain ownership identifiers.
            /// </summary>
            /// <remarks>
            /// Lists domain ownership identifiers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DomainOwnershipIdentifier>> ListOwnershipIdentifiersAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOwnershipIdentifiersWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get ownership identifier for domain
            /// </summary>
            /// <remarks>
            /// Get ownership identifier for domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            public static DomainOwnershipIdentifier GetOwnershipIdentifier(this IDomainsOperations operations, string resourceGroupName, string domainName, string name)
            {
                return operations.GetOwnershipIdentifierAsync(resourceGroupName, domainName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ownership identifier for domain
            /// </summary>
            /// <remarks>
            /// Get ownership identifier for domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainOwnershipIdentifier> GetOwnershipIdentifierAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOwnershipIdentifierWithHttpMessagesAsync(resourceGroupName, domainName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </summary>
            /// <remarks>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='domainOwnershipIdentifier'>
            /// A JSON representation of the domain ownership properties.
            /// </param>
            public static DomainOwnershipIdentifier CreateOrUpdateOwnershipIdentifier(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, DomainOwnershipIdentifier domainOwnershipIdentifier)
            {
                return operations.CreateOrUpdateOwnershipIdentifierAsync(resourceGroupName, domainName, name, domainOwnershipIdentifier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </summary>
            /// <remarks>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='domainOwnershipIdentifier'>
            /// A JSON representation of the domain ownership properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainOwnershipIdentifier> CreateOrUpdateOwnershipIdentifierAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, DomainOwnershipIdentifier domainOwnershipIdentifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateOwnershipIdentifierWithHttpMessagesAsync(resourceGroupName, domainName, name, domainOwnershipIdentifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete ownership identifier for domain
            /// </summary>
            /// <remarks>
            /// Delete ownership identifier for domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            public static void DeleteOwnershipIdentifier(this IDomainsOperations operations, string resourceGroupName, string domainName, string name)
            {
                operations.DeleteOwnershipIdentifierAsync(resourceGroupName, domainName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete ownership identifier for domain
            /// </summary>
            /// <remarks>
            /// Delete ownership identifier for domain
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteOwnershipIdentifierAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteOwnershipIdentifierWithHttpMessagesAsync(resourceGroupName, domainName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </summary>
            /// <remarks>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='domainOwnershipIdentifier'>
            /// A JSON representation of the domain ownership properties.
            /// </param>
            public static DomainOwnershipIdentifier UpdateOwnershipIdentifier(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, DomainOwnershipIdentifier domainOwnershipIdentifier)
            {
                return operations.UpdateOwnershipIdentifierAsync(resourceGroupName, domainName, name, domainOwnershipIdentifier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </summary>
            /// <remarks>
            /// Creates an ownership identifier for a domain or updates identifier details
            /// for an existing identifer
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of domain.
            /// </param>
            /// <param name='name'>
            /// Name of identifier.
            /// </param>
            /// <param name='domainOwnershipIdentifier'>
            /// A JSON representation of the domain ownership properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainOwnershipIdentifier> UpdateOwnershipIdentifierAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string name, DomainOwnershipIdentifier domainOwnershipIdentifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateOwnershipIdentifierWithHttpMessagesAsync(resourceGroupName, domainName, name, domainOwnershipIdentifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a domain.
            /// </summary>
            /// <remarks>
            /// Creates or updates a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='domain'>
            /// Domain registration information.
            /// </param>
            public static Domain BeginCreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, domainName, domain).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a domain.
            /// </summary>
            /// <remarks>
            /// Creates or updates a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain.
            /// </param>
            /// <param name='domain'>
            /// Domain registration information.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> BeginCreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all domains in a subscription.
            /// </summary>
            /// <remarks>
            /// Get all domains in a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Domain> ListNext(this IDomainsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all domains in a subscription.
            /// </summary>
            /// <remarks>
            /// Get all domains in a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get domain name recommendations based on keywords.
            /// </summary>
            /// <remarks>
            /// Get domain name recommendations based on keywords.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NameIdentifier> ListRecommendationsNext(this IDomainsOperations operations, string nextPageLink)
            {
                return operations.ListRecommendationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get domain name recommendations based on keywords.
            /// </summary>
            /// <remarks>
            /// Get domain name recommendations based on keywords.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NameIdentifier>> ListRecommendationsNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all domains in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all domains in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Domain> ListByResourceGroupNext(this IDomainsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all domains in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all domains in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListByResourceGroupNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domain ownership identifiers.
            /// </summary>
            /// <remarks>
            /// Lists domain ownership identifiers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DomainOwnershipIdentifier> ListOwnershipIdentifiersNext(this IDomainsOperations operations, string nextPageLink)
            {
                return operations.ListOwnershipIdentifiersNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domain ownership identifiers.
            /// </summary>
            /// <remarks>
            /// Lists domain ownership identifiers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DomainOwnershipIdentifier>> ListOwnershipIdentifiersNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOwnershipIdentifiersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
