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
    using System.Linq;

    /// <summary>
    /// Operation status extended info for ILR provision action.
    /// </summary>
    public partial class OperationStatusProvisionILRExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationStatusProvisionILRExtendedInfo class.
        /// </summary>
        public OperationStatusProvisionILRExtendedInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationStatusProvisionILRExtendedInfo class.
        /// </summary>
        /// <param name="recoveryTarget">Target details for file / folder
        /// restore.</param>
        public OperationStatusProvisionILRExtendedInfo(InstantItemRecoveryTarget recoveryTarget = default(InstantItemRecoveryTarget))
        {
            RecoveryTarget = recoveryTarget;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target details for file / folder restore.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryTarget")]
        public InstantItemRecoveryTarget RecoveryTarget { get; set; }

    }
}