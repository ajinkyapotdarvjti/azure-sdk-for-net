// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CDN origin is the source of the content being delivered via CDN. When
    /// the edge nodes represented by an endpoint do not have the requested
    /// content cached, they attempt to fetch it from one or more of the
    /// configured origins.
    /// </summary>
    [JsonTransformation]
    public partial class Origin : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Origin class.
        /// </summary>
        public Origin() { }

        /// <summary>
        /// Initializes a new instance of the Origin class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535.</param>
        /// <param name="httpsPort">The value of the https port. Must be
        /// between 1 and 65535.</param>
        /// <param name="resourceState">Resource status of the origin. Possible
        /// values include: 'Creating', 'Active', 'Deleting'</param>
        /// <param name="provisioningState">Provisioning status of the
        /// origin.</param>
        public Origin(string location, string hostName, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), int? httpPort = default(int?), int? httpsPort = default(int?), string resourceState = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the https port. Must be between 1 and
        /// 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// Gets resource status of the origin. Possible values include:
        /// 'Creating', 'Active', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; protected set; }

        /// <summary>
        /// Gets provisioning status of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
            if (HttpPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpPort", 65535);
            }
            if (HttpPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpPort", 1);
            }
            if (HttpsPort > 65535)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "HttpsPort", 65535);
            }
            if (HttpsPort < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "HttpsPort", 1);
            }
        }
    }
}
