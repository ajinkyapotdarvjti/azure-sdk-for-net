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
    /// Definition of the test job.
    /// </summary>
    public partial class TestJob
    {
        /// <summary>
        /// Initializes a new instance of the TestJob class.
        /// </summary>
        public TestJob()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestJob class.
        /// </summary>
        /// <param name="creationTime">Gets or sets the creation time of the
        /// test job.</param>
        /// <param name="status">Gets or sets the status of the test
        /// job.</param>
        /// <param name="statusDetails">Gets or sets the status details of the
        /// test job.</param>
        /// <param name="runOn">Gets or sets the runOn which specifies the
        /// group name where the job is to be executed.</param>
        /// <param name="startTime">Gets or sets the start time of the test
        /// job.</param>
        /// <param name="endTime">Gets or sets the end time of the test
        /// job.</param>
        /// <param name="exception">Gets or sets the exception of the test
        /// job.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified time
        /// of the test job.</param>
        /// <param name="lastStatusModifiedTime">Gets or sets the last status
        /// modified time of the test job.</param>
        /// <param name="parameters">Gets or sets the parameters of the test
        /// job.</param>
        public TestJob(System.DateTime? creationTime = default(System.DateTime?), string status = default(string), string statusDetails = default(string), string runOn = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string exception = default(string), System.DateTime? lastModifiedTime = default(System.DateTime?), System.DateTime? lastStatusModifiedTime = default(System.DateTime?), IDictionary<string, string> parameters = default(IDictionary<string, string>))
        {
            CreationTime = creationTime;
            Status = status;
            StatusDetails = statusDetails;
            RunOn = runOn;
            StartTime = startTime;
            EndTime = endTime;
            Exception = exception;
            LastModifiedTime = lastModifiedTime;
            LastStatusModifiedTime = lastStatusModifiedTime;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the creation time of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the status of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status details of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets the runOn which specifies the group name where the job
        /// is to be executed.
        /// </summary>
        [JsonProperty(PropertyName = "runOn")]
        public string RunOn { get; set; }

        /// <summary>
        /// Gets or sets the start time of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exception of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "exception")]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the last status modified time of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "lastStatusModifiedTime")]
        public System.DateTime? LastStatusModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the test job.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, string> Parameters { get; set; }

    }
}