// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing the Geographic hierarchy used with the Geographic
    /// traffic routing method.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TrafficManagerGeographicHierarchy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the TrafficManagerGeographicHierarchy
        /// class.
        /// </summary>
        public TrafficManagerGeographicHierarchy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficManagerGeographicHierarchy
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="geographicHierarchy">The region at the root of the
        /// hierarchy from all the regions in the hierarchy can be
        /// retrieved.</param>
        public TrafficManagerGeographicHierarchy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Region geographicHierarchy = default(Region))
            : base(id, name, type, location, tags)
        {
            GeographicHierarchy = geographicHierarchy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region at the root of the hierarchy from all the
        /// regions in the hierarchy can be retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.geographicHierarchy")]
        public Region GeographicHierarchy { get; set; }

    }
}