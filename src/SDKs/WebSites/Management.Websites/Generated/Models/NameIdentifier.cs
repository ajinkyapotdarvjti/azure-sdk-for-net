// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identifies an object.
    /// </summary>
    public partial class NameIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the NameIdentifier class.
        /// </summary>
        public NameIdentifier() { }

        /// <summary>
        /// Initializes a new instance of the NameIdentifier class.
        /// </summary>
        /// <param name="name">Name of the object.</param>
        public NameIdentifier(string name = default(string))
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets name of the object.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
