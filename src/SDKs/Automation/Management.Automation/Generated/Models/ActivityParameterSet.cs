// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the activity parameter set.
    /// </summary>
    public partial class ActivityParameterSet
    {
        /// <summary>
        /// Initializes a new instance of the ActivityParameterSet class.
        /// </summary>
        public ActivityParameterSet()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityParameterSet class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the activity parameter
        /// set.</param>
        /// <param name="parameters">Gets or sets the parameters of the
        /// activity parameter set.</param>
        public ActivityParameterSet(string name = default(string), IList<ActivityParameter> parameters = default(IList<ActivityParameter>))
        {
            Name = name;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the activity parameter set.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the activity parameter set.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<ActivityParameter> Parameters { get; set; }

    }
}