// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Salesforce discover setting.
    /// </summary>
    public partial class SalesforceDiscoverSetting
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceDiscoverSetting class.
        /// </summary>
        public SalesforceDiscoverSetting()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SalesforceDiscoverSetting class.
        /// </summary>
        /// <param name="salesforceConnectionStringSecretUrl">The salesforce
        /// connection string secret URL.</param>
        public SalesforceDiscoverSetting(string salesforceConnectionStringSecretUrl)
        {
            SalesforceConnectionStringSecretUrl = salesforceConnectionStringSecretUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the salesforce connection string secret URL.
        /// </summary>
        [JsonProperty(PropertyName = "salesforceConnectionStringSecretUrl")]
        public string SalesforceConnectionStringSecretUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SalesforceConnectionStringSecretUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SalesforceConnectionStringSecretUrl");
            }
        }
    }
}