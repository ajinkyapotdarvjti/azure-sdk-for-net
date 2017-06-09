// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of a weekly schedule.
    /// </summary>
    public partial class WeekDetailsFragment
    {
        /// <summary>
        /// Initializes a new instance of the WeekDetailsFragment class.
        /// </summary>
        public WeekDetailsFragment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WeekDetailsFragment class.
        /// </summary>
        /// <param name="weekdays">The days of the week for which the schedule
        /// is set (e.g. Sunday, Monday, Tuesday, etc.).</param>
        /// <param name="time">The time of the day the schedule will
        /// occur.</param>
        public WeekDetailsFragment(IList<string> weekdays = default(IList<string>), string time = default(string))
        {
            Weekdays = weekdays;
            Time = time;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the days of the week for which the schedule is set
        /// (e.g. Sunday, Monday, Tuesday, etc.).
        /// </summary>
        [JsonProperty(PropertyName = "weekdays")]
        public IList<string> Weekdays { get; set; }

        /// <summary>
        /// Gets or sets the time of the day the schedule will occur.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

    }
}