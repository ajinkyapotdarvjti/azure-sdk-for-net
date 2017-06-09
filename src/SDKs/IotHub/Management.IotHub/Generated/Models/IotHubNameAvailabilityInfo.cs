// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.IotHub;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties indicating whether a given IoT hub name is available.
    /// </summary>
    public partial class IotHubNameAvailabilityInfo
    {
        /// <summary>
        /// Initializes a new instance of the IotHubNameAvailabilityInfo class.
        /// </summary>
        public IotHubNameAvailabilityInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubNameAvailabilityInfo class.
        /// </summary>
        /// <param name="nameAvailable">The value which indicates whether the
        /// provided name is available.</param>
        /// <param name="reason">The reason for unavailability. Possible values
        /// include: 'Invalid', 'AlreadyExists'</param>
        /// <param name="message">The detailed reason message.</param>
        public IotHubNameAvailabilityInfo(bool? nameAvailable = default(bool?), IotHubNameUnavailabilityReason? reason = default(IotHubNameUnavailabilityReason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the value which indicates whether the provided name is
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; private set; }

        /// <summary>
        /// Gets the reason for unavailability. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public IotHubNameUnavailabilityReason? Reason { get; private set; }

        /// <summary>
        /// Gets or sets the detailed reason message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}