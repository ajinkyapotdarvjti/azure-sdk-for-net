// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Media.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The response body for CheckNameAvailability API.
    /// </summary>
    public partial class CheckNameAvailabilityOutput
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityOutput
        /// class.
        /// </summary>
        public CheckNameAvailabilityOutput() { }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityOutput
        /// class.
        /// </summary>
        public CheckNameAvailabilityOutput(bool? nameAvailable = default(bool?), EntityNameUnavailabilityReason? reason = default(EntityNameUnavailabilityReason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// Specifies if the name is available.
        /// </summary>
        [JsonProperty(PropertyName = "NameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Specifies the reason if the name is not available. Possible values
        /// include: 'None', 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "Reason")]
        public EntityNameUnavailabilityReason? Reason { get; set; }

        /// <summary>
        /// Specifies the detailed reason if the name is not available.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

    }
}