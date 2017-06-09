// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response of suggest relationship links operation.
    /// </summary>
    public partial class SuggestRelationshipLinksResponse
    {
        /// <summary>
        /// Initializes a new instance of the SuggestRelationshipLinksResponse
        /// class.
        /// </summary>
        public SuggestRelationshipLinksResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuggestRelationshipLinksResponse
        /// class.
        /// </summary>
        /// <param name="interactionName">The interaction name.</param>
        /// <param name="suggestedRelationships">Suggested relationships for
        /// the type.</param>
        public SuggestRelationshipLinksResponse(string interactionName = default(string), IList<RelationshipsLookup> suggestedRelationships = default(IList<RelationshipsLookup>))
        {
            InteractionName = interactionName;
            SuggestedRelationships = suggestedRelationships;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the interaction name.
        /// </summary>
        [JsonProperty(PropertyName = "interactionName")]
        public string InteractionName { get; private set; }

        /// <summary>
        /// Gets suggested relationships for the type.
        /// </summary>
        [JsonProperty(PropertyName = "suggestedRelationships")]
        public IList<RelationshipsLookup> SuggestedRelationships { get; private set; }

    }
}