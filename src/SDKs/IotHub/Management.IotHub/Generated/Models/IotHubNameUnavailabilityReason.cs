// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.IotHub;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IotHubNameUnavailabilityReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IotHubNameUnavailabilityReason
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "AlreadyExists")]
        AlreadyExists
    }
}