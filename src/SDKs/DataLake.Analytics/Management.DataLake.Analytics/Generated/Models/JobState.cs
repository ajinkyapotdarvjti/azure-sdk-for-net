// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobState
    {
        [EnumMember(Value = "Accepted")]
        Accepted,
        [EnumMember(Value = "Compiling")]
        Compiling,
        [EnumMember(Value = "Ended")]
        Ended,
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Queued")]
        Queued,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Scheduling")]
        Scheduling,
        [EnumMember(Value = "Starting")]
        Starting,
        [EnumMember(Value = "Paused")]
        Paused,
        [EnumMember(Value = "WaitingForCapacity")]
        WaitingForCapacity
    }
}