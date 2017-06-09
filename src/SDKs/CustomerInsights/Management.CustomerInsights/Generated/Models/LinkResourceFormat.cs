// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The link resource format.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LinkResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the LinkResourceFormat class.
        /// </summary>
        public LinkResourceFormat()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkResourceFormat class.
        /// </summary>
        /// <param name="sourceInteractionType">Name of the source Interaction
        /// Type.</param>
        /// <param name="targetProfileType">Name of the target Profile
        /// Type.</param>
        /// <param name="participantPropertyReferences">The properties that
        /// represent the participating profile.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tenantId">The hub name.</param>
        /// <param name="linkName">The link name.</param>
        /// <param name="displayName">Localized display name for the
        /// Link.</param>
        /// <param name="description">Localized descriptions for the
        /// Link.</param>
        /// <param name="mappings">The set of properties mappings between the
        /// source and target Types.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Provisioning', 'Succeeded', 'Expiring', 'Deleting',
        /// 'HumanIntervention', 'Failed'</param>
        /// <param name="referenceOnly">Indicating whether the link is
        /// reference only link. This flag is ingored if the Mappings are
        /// defined. If the mappings are not defined and it is set to true,
        /// links processing will not create or update profiles.</param>
        /// <param name="operationType">Determines whether this link is
        /// supposed to create or delete instances if Link is NOT Reference
        /// Only. Possible values include: 'Upsert', 'Delete'</param>
        public LinkResourceFormat(string sourceInteractionType, string targetProfileType, IList<ParticipantPropertyReference> participantPropertyReferences, string id = default(string), string name = default(string), string type = default(string), string tenantId = default(string), string linkName = default(string), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, string> description = default(IDictionary<string, string>), IList<TypePropertiesMapping> mappings = default(IList<TypePropertiesMapping>), string provisioningState = default(string), bool? referenceOnly = default(bool?), InstanceOperationType? operationType = default(InstanceOperationType?))
            : base(id, name, type)
        {
            TenantId = tenantId;
            LinkName = linkName;
            SourceInteractionType = sourceInteractionType;
            TargetProfileType = targetProfileType;
            DisplayName = displayName;
            Description = description;
            Mappings = mappings;
            ParticipantPropertyReferences = participantPropertyReferences;
            ProvisioningState = provisioningState;
            ReferenceOnly = referenceOnly;
            OperationType = operationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets the link name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkName")]
        public string LinkName { get; private set; }

        /// <summary>
        /// Gets or sets name of the source Interaction Type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceInteractionType")]
        public string SourceInteractionType { get; set; }

        /// <summary>
        /// Gets or sets name of the target Profile Type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetProfileType")]
        public string TargetProfileType { get; set; }

        /// <summary>
        /// Gets or sets localized display name for the Link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized descriptions for the Link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets the set of properties mappings between the source and
        /// target Types.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mappings")]
        public IList<TypePropertiesMapping> Mappings { get; set; }

        /// <summary>
        /// Gets or sets the properties that represent the participating
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.participantPropertyReferences")]
        public IList<ParticipantPropertyReference> ParticipantPropertyReferences { get; set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Provisioning',
        /// 'Succeeded', 'Expiring', 'Deleting', 'HumanIntervention', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets indicating whether the link is reference only link.
        /// This flag is ingored if the Mappings are defined. If the mappings
        /// are not defined and it is set to true, links processing will not
        /// create or update profiles.
        /// </summary>
        [JsonProperty(PropertyName = "properties.referenceOnly")]
        public bool? ReferenceOnly { get; set; }

        /// <summary>
        /// Gets or sets determines whether this link is supposed to create or
        /// delete instances if Link is NOT Reference Only. Possible values
        /// include: 'Upsert', 'Delete'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationType")]
        public InstanceOperationType? OperationType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SourceInteractionType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceInteractionType");
            }
            if (TargetProfileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetProfileType");
            }
            if (ParticipantPropertyReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ParticipantPropertyReferences");
            }
            if (Mappings != null)
            {
                foreach (var element in Mappings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ParticipantPropertyReferences != null)
            {
                foreach (var element1 in ParticipantPropertyReferences)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}