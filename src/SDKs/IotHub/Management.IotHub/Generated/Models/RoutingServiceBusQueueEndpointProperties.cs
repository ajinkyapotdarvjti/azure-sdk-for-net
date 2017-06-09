// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.IotHub;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties related to service bus queue endpoint types.
    /// </summary>
    public partial class RoutingServiceBusQueueEndpointProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RoutingServiceBusQueueEndpointProperties class.
        /// </summary>
        public RoutingServiceBusQueueEndpointProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RoutingServiceBusQueueEndpointProperties class.
        /// </summary>
        /// <param name="connectionString">The connection string of the service
        /// bus queue endpoint.</param>
        /// <param name="name">The name of the service bus queue endpoint. The
        /// name can only include alphanumeric characters, periods,
        /// underscores, hyphens and has a maximum length of 64 characters. The
        /// following names are reserved;  events, operationsMonitoringEvents,
        /// fileNotifications, $default. Endpoint names must be unique across
        /// endpoint types. The name need not be the same as the actual queue
        /// name.</param>
        /// <param name="subscriptionId">The subscription identifier of the
        /// service bus queue endpoint.</param>
        /// <param name="resourceGroup">The name of the resource group of the
        /// service bus queue endpoint.</param>
        public RoutingServiceBusQueueEndpointProperties(string connectionString, string name, string subscriptionId = default(string), string resourceGroup = default(string))
        {
            ConnectionString = connectionString;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string of the service bus queue
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name of the service bus queue endpoint. The name
        /// can only include alphanumeric characters, periods, underscores,
        /// hyphens and has a maximum length of 64 characters. The following
        /// names are reserved;  events, operationsMonitoringEvents,
        /// fileNotifications, $default. Endpoint names must be unique across
        /// endpoint types. The name need not be the same as the actual queue
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subscription identifier of the service bus queue
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group of the service bus
        /// queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[A-Za-z0-9-._]{1,64}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[A-Za-z0-9-._]{1,64}$");
                }
            }
        }
    }
}