// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the schedule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Schedule
    {
        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        public Schedule()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="name">Gets or sets the name of the schedule.</param>
        /// <param name="startTime">Gets or sets the start time of the
        /// schedule.</param>
        /// <param name="startTimeOffsetMinutes">Gets the start time's offset
        /// in minutes.</param>
        /// <param name="expiryTime">Gets or sets the end time of the
        /// schedule.</param>
        /// <param name="expiryTimeOffsetMinutes">Gets or sets the expiry
        /// time's offset in minutes.</param>
        /// <param name="isEnabled">Gets or sets a value indicating whether
        /// this schedule is enabled.</param>
        /// <param name="nextRun">Gets or sets the next run time of the
        /// schedule.</param>
        /// <param name="nextRunOffsetMinutes">Gets or sets the next run time's
        /// offset in minutes.</param>
        /// <param name="interval">Gets or sets the interval of the
        /// schedule.</param>
        /// <param name="frequency">Gets or sets the frequency of the schedule.
        /// Possible values include: 'OneTime', 'Day', 'Hour', 'Week',
        /// 'Month'</param>
        /// <param name="timeZone">Gets or sets the time zone of the
        /// schedule.</param>
        /// <param name="advancedSchedule">Gets or sets the advanced
        /// schedule.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        public Schedule(string id = default(string), string name = default(string), System.DateTime? startTime = default(System.DateTime?), double? startTimeOffsetMinutes = default(double?), System.DateTime? expiryTime = default(System.DateTime?), double? expiryTimeOffsetMinutes = default(double?), bool? isEnabled = default(bool?), System.DateTime? nextRun = default(System.DateTime?), double? nextRunOffsetMinutes = default(double?), object interval = default(object), string frequency = default(string), string timeZone = default(string), AdvancedSchedule advancedSchedule = default(AdvancedSchedule), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string))
        {
            Id = id;
            Name = name;
            StartTime = startTime;
            StartTimeOffsetMinutes = startTimeOffsetMinutes;
            ExpiryTime = expiryTime;
            ExpiryTimeOffsetMinutes = expiryTimeOffsetMinutes;
            IsEnabled = isEnabled;
            NextRun = nextRun;
            NextRunOffsetMinutes = nextRunOffsetMinutes;
            Interval = interval;
            Frequency = frequency;
            TimeZone = timeZone;
            AdvancedSchedule = advancedSchedule;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the start time of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets the start time's offset in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTimeOffsetMinutes")]
        public double? StartTimeOffsetMinutes { get; private set; }

        /// <summary>
        /// Gets or sets the end time of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the expiry time's offset in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryTimeOffsetMinutes")]
        public double? ExpiryTimeOffsetMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this schedule is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the next run time of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextRun")]
        public System.DateTime? NextRun { get; set; }

        /// <summary>
        /// Gets or sets the next run time's offset in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextRunOffsetMinutes")]
        public double? NextRunOffsetMinutes { get; set; }

        /// <summary>
        /// Gets or sets the interval of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interval")]
        public object Interval { get; set; }

        /// <summary>
        /// Gets or sets the frequency of the schedule. Possible values
        /// include: 'OneTime', 'Day', 'Hour', 'Week', 'Month'
        /// </summary>
        [JsonProperty(PropertyName = "properties.frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the time zone of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the advanced schedule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.advancedSchedule")]
        public AdvancedSchedule AdvancedSchedule { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}