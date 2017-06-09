// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.PowerBIEmbedded;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Display
    {
        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        public Display()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        /// <param name="provider">The localized friendly form of the resource
        /// provider name. This form is also expected to include the
        /// publisher/company responsible. Use Title Casing. Begin with
        /// “Microsoft” for 1st party services.</param>
        /// <param name="resource">The localized friendly form of the resource
        /// type related to this action/operation. This form should match the
        /// public documentation for the resource provider. Use Title Casing.
        /// For examples, refer to the “name” section.</param>
        /// <param name="operation">The localized friendly name for the
        /// operation as shown to the user. This name should be concise (to fit
        /// in drop downs), but clear (self-documenting). Use Title Casing and
        /// include the entity/resource to which it applies.</param>
        /// <param name="description">The localized friendly description for
        /// the operation as shown to the user. This description should be
        /// thorough, yet concise. It will be used in tool-tips and detailed
        /// views.</param>
        /// <param name="origin">The intended executor of the operation;
        /// governs the display of the operation in the RBAC UX and the audit
        /// logs UX. Default value is 'user,system'</param>
        public Display(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string), string origin = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            Origin = origin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the localized friendly form of the resource provider
        /// name. This form is also expected to include the publisher/company
        /// responsible. Use Title Casing. Begin with “Microsoft” for 1st party
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly form of the resource type
        /// related to this action/operation. This form should match the public
        /// documentation for the resource provider. Use Title Casing. For
        /// examples, refer to the “name” section.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly name for the operation as shown
        /// to the user. This name should be concise (to fit in drop downs),
        /// but clear (self-documenting). Use Title Casing and include the
        /// entity/resource to which it applies.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets the localized friendly description for the operation
        /// as shown to the user. This description should be thorough, yet
        /// concise. It will be used in tool-tips and detailed views.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the intended executor of the operation; governs the
        /// display of the operation in the RBAC UX and the audit logs UX.
        /// Default value is 'user,system'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

    }
}