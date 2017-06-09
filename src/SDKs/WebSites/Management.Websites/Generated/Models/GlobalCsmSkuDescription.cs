// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Global SKU Description.
    /// </summary>
    public partial class GlobalCsmSkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the GlobalCsmSkuDescription class.
        /// </summary>
        public GlobalCsmSkuDescription() { }

        /// <summary>
        /// Initializes a new instance of the GlobalCsmSkuDescription class.
        /// </summary>
        /// <param name="name">Name of the resource SKU.</param>
        /// <param name="tier">Service Tier of the resource SKU.</param>
        /// <param name="capacity">Min, max, and default scale values of the
        /// SKU.</param>
        /// <param name="locations">Locations of the SKU.</param>
        /// <param name="capabilities">Capabilities of the SKU, e.g., is
        /// traffic manager enabled?</param>
        public GlobalCsmSkuDescription(string name = default(string), string tier = default(string), SkuCapacity capacity = default(SkuCapacity), IList<string> locations = default(IList<string>), IList<Capability> capabilities = default(IList<Capability>))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            Locations = locations;
            Capabilities = capabilities;
        }

        /// <summary>
        /// Gets or sets name of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets service Tier of the resource SKU.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets min, max, and default scale values of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public SkuCapacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets locations of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets capabilities of the SKU, e.g., is traffic manager
        /// enabled?
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<Capability> Capabilities { get; set; }

    }
}
