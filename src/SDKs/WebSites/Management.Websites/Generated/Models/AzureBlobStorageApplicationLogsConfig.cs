// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Application logs azure blob storage configuration.
    /// </summary>
    public partial class AzureBlobStorageApplicationLogsConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureBlobStorageApplicationLogsConfig class.
        /// </summary>
        public AzureBlobStorageApplicationLogsConfig() { }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureBlobStorageApplicationLogsConfig class.
        /// </summary>
        /// <param name="level">Log level. Possible values include: 'Off',
        /// 'Verbose', 'Information', 'Warning', 'Error'</param>
        /// <param name="sasUrl">SAS url to a azure blob container with
        /// read/write/list/delete permissions.</param>
        /// <param name="retentionInDays">Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.</param>
        public AzureBlobStorageApplicationLogsConfig(LogLevel? level = default(LogLevel?), string sasUrl = default(string), int? retentionInDays = default(int?))
        {
            Level = level;
            SasUrl = sasUrl;
            RetentionInDays = retentionInDays;
        }

        /// <summary>
        /// Gets or sets log level. Possible values include: 'Off', 'Verbose',
        /// 'Information', 'Warning', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public LogLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets SAS url to a azure blob container with
        /// read/write/list/delete permissions.
        /// </summary>
        [JsonProperty(PropertyName = "sasUrl")]
        public string SasUrl { get; set; }

        /// <summary>
        /// Gets or sets retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        [JsonProperty(PropertyName = "retentionInDays")]
        public int? RetentionInDays { get; set; }

    }
}
