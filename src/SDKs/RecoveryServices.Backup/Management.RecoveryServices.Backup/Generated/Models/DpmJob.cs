// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DPM workload-specifc job object.
    /// </summary>
    public partial class DpmJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the DpmJob class.
        /// </summary>
        public DpmJob()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DpmJob class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        /// <param name="duration">Time elapsed for job.</param>
        /// <param name="dpmServerName">DPM server name managing the backup
        /// item or backup job.</param>
        /// <param name="containerName">Name of cluster/server protecting
        /// current backup item, if any.</param>
        /// <param name="containerType">Type of container.</param>
        /// <param name="workloadType">Type of backup item.</param>
        /// <param name="actionsInfo">The state/actions applicable on this job
        /// like cancel/retry.</param>
        /// <param name="errorDetails">The errors.</param>
        /// <param name="extendedInfo">Additional information for this
        /// job.</param>
        public DpmJob(string entityFriendlyName = default(string), string backupManagementType = default(string), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), string dpmServerName = default(string), string containerName = default(string), string containerType = default(string), string workloadType = default(string), IList<JobSupportedAction?> actionsInfo = default(IList<JobSupportedAction?>), IList<DpmErrorInfo> errorDetails = default(IList<DpmErrorInfo>), DpmJobExtendedInfo extendedInfo = default(DpmJobExtendedInfo))
            : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            Duration = duration;
            DpmServerName = dpmServerName;
            ContainerName = containerName;
            ContainerType = containerType;
            WorkloadType = workloadType;
            ActionsInfo = actionsInfo;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time elapsed for job.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets DPM server name managing the backup item or backup
        /// job.
        /// </summary>
        [JsonProperty(PropertyName = "dpmServerName")]
        public string DpmServerName { get; set; }

        /// <summary>
        /// Gets or sets name of cluster/server protecting current backup item,
        /// if any.
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets type of container.
        /// </summary>
        [JsonProperty(PropertyName = "containerType")]
        public string ContainerType { get; set; }

        /// <summary>
        /// Gets or sets type of backup item.
        /// </summary>
        [JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType { get; set; }

        /// <summary>
        /// Gets or sets the state/actions applicable on this job like
        /// cancel/retry.
        /// </summary>
        [JsonProperty(PropertyName = "actionsInfo")]
        public IList<JobSupportedAction?> ActionsInfo { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<DpmErrorInfo> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets additional information for this job.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public DpmJobExtendedInfo ExtendedInfo { get; set; }

    }
}