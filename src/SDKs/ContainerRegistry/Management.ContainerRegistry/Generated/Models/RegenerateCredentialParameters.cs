// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Azure;
    using Management;
    using ContainerRegistry;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to regenerate the login credential.
    /// </summary>
    public partial class RegenerateCredentialParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateCredentialParameters
        /// class.
        /// </summary>
        public RegenerateCredentialParameters() { }

        /// <summary>
        /// Initializes a new instance of the RegenerateCredentialParameters
        /// class.
        /// </summary>
        /// <param name="name">Specifies name of the password which should be
        /// regenerated -- password or password2. Possible values include:
        /// 'password', 'password2'</param>
        public RegenerateCredentialParameters(PasswordName name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets specifies name of the password which should be
        /// regenerated -- password or password2. Possible values include:
        /// 'password', 'password2'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public PasswordName Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
