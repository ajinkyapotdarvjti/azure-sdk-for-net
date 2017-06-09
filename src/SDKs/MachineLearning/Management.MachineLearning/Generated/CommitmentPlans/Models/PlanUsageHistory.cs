// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.CommitmentPlans;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents historical information about usage of the Azure resources
    /// associated with a commitment plan.
    /// </summary>
    public partial class PlanUsageHistory
    {
        /// <summary>
        /// Initializes a new instance of the PlanUsageHistory class.
        /// </summary>
        public PlanUsageHistory()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlanUsageHistory class.
        /// </summary>
        /// <param name="planDeletionOverage">Overage incurred as a result of
        /// deleting a commitment plan.</param>
        /// <param name="planMigrationOverage">Overage incurred as a result of
        /// migrating a commitment plan from one SKU to another.</param>
        /// <param name="planQuantitiesAfterUsage">Included quantities
        /// remaining after usage against the commitment plan's associated
        /// resources was calculated.</param>
        /// <param name="planQuantitiesBeforeUsage">Included quantities
        /// remaining before usage against the commitment plan's associated
        /// resources was calculated.</param>
        /// <param name="planUsageOverage">Usage against the commitment plan's
        /// associated resources which was not covered by included quantities
        /// and is therefore overage.</param>
        /// <param name="usage">Usage against the commitment plan's associated
        /// resources.</param>
        /// <param name="usageDate">The date of usage, in ISO 8601
        /// format.</param>
        public PlanUsageHistory(IDictionary<string, double?> planDeletionOverage = default(IDictionary<string, double?>), IDictionary<string, double?> planMigrationOverage = default(IDictionary<string, double?>), IDictionary<string, double?> planQuantitiesAfterUsage = default(IDictionary<string, double?>), IDictionary<string, double?> planQuantitiesBeforeUsage = default(IDictionary<string, double?>), IDictionary<string, double?> planUsageOverage = default(IDictionary<string, double?>), IDictionary<string, double?> usage = default(IDictionary<string, double?>), System.DateTime? usageDate = default(System.DateTime?))
        {
            PlanDeletionOverage = planDeletionOverage;
            PlanMigrationOverage = planMigrationOverage;
            PlanQuantitiesAfterUsage = planQuantitiesAfterUsage;
            PlanQuantitiesBeforeUsage = planQuantitiesBeforeUsage;
            PlanUsageOverage = planUsageOverage;
            Usage = usage;
            UsageDate = usageDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets overage incurred as a result of deleting a commitment
        /// plan.
        /// </summary>
        [JsonProperty(PropertyName = "planDeletionOverage")]
        public IDictionary<string, double?> PlanDeletionOverage { get; set; }

        /// <summary>
        /// Gets or sets overage incurred as a result of migrating a commitment
        /// plan from one SKU to another.
        /// </summary>
        [JsonProperty(PropertyName = "planMigrationOverage")]
        public IDictionary<string, double?> PlanMigrationOverage { get; set; }

        /// <summary>
        /// Gets or sets included quantities remaining after usage against the
        /// commitment plan's associated resources was calculated.
        /// </summary>
        [JsonProperty(PropertyName = "planQuantitiesAfterUsage")]
        public IDictionary<string, double?> PlanQuantitiesAfterUsage { get; set; }

        /// <summary>
        /// Gets or sets included quantities remaining before usage against the
        /// commitment plan's associated resources was calculated.
        /// </summary>
        [JsonProperty(PropertyName = "planQuantitiesBeforeUsage")]
        public IDictionary<string, double?> PlanQuantitiesBeforeUsage { get; set; }

        /// <summary>
        /// Gets or sets usage against the commitment plan's associated
        /// resources which was not covered by included quantities and is
        /// therefore overage.
        /// </summary>
        [JsonProperty(PropertyName = "planUsageOverage")]
        public IDictionary<string, double?> PlanUsageOverage { get; set; }

        /// <summary>
        /// Gets or sets usage against the commitment plan's associated
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public IDictionary<string, double?> Usage { get; set; }

        /// <summary>
        /// Gets or sets the date of usage, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "usageDate")]
        public System.DateTime? UsageDate { get; set; }

    }
}