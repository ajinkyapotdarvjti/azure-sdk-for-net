// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics catalog secret creation and update parameters. This
    /// is deprecated and will be removed in the next release. Please use
    /// DataLakeAnalyticsCatalogCredentialCreateOrUpdateParameters instead.
    /// </summary>
    public partial class DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters class.
        /// </summary>
        public DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="password">the password for the secret to pass
        /// in</param>
        /// <param name="uri">the URI identifier for the secret in the format
        /// &lt;hostname&gt;:&lt;port&gt;</param>
        public DataLakeAnalyticsCatalogSecretCreateOrUpdateParameters(string password, string uri = default(string))
        {
            Password = password;
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the password for the secret to pass in
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the URI identifier for the secret in the format
        /// &amp;lt;hostname&amp;gt;:&amp;lt;port&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}