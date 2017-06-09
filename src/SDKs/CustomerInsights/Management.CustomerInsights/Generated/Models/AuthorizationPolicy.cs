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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The authorization policy.
    /// </summary>
    public partial class AuthorizationPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AuthorizationPolicy class.
        /// </summary>
        public AuthorizationPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuthorizationPolicy class.
        /// </summary>
        /// <param name="permissions">The permissions associated with the
        /// policy.</param>
        /// <param name="policyName">Name of the policy.</param>
        /// <param name="primaryKey">Primary key assiciated with the
        /// policy.</param>
        /// <param name="secondaryKey">Secondary key assiciated with the
        /// policy.</param>
        public AuthorizationPolicy(IList<PermissionTypes?> permissions, string policyName = default(string), string primaryKey = default(string), string secondaryKey = default(string))
        {
            PolicyName = policyName;
            Permissions = permissions;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "policyName")]
        public string PolicyName { get; private set; }

        /// <summary>
        /// Gets or sets the permissions associated with the policy.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public IList<PermissionTypes?> Permissions { get; set; }

        /// <summary>
        /// Gets or sets primary key assiciated with the policy.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets secondary key assiciated with the policy.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Permissions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permissions");
            }
            if (Permissions != null)
            {
                if (Permissions.Count != Permissions.Distinct().Count())
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Permissions");
                }
            }
        }
    }
}