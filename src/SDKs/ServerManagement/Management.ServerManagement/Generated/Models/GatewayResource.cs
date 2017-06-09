// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServerManagement;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data model for an arm gateway resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GatewayResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        public GatewayResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        /// <param name="id">Resource Manager Resource ID.</param>
        /// <param name="type">Resource Manager Resource Type.</param>
        /// <param name="name">Resource Manager Resource Name.</param>
        /// <param name="location">Resource Manager Resource Location.</param>
        /// <param name="tags">Resource Manager Resource Tags.</param>
        /// <param name="created">UTC date and time when gateway was first
        /// added to management service.</param>
        /// <param name="updated">UTC date and time when node was last
        /// updated.</param>
        /// <param name="upgradeMode">The upgradeMode property gives the
        /// flexibility to gateway to auto upgrade itself. If properties value
        /// not specified, then we assume upgradeMode = Automatic. Possible
        /// values include: 'Manual', 'Automatic'</param>
        /// <param name="desiredVersion">Latest available MSI version.</param>
        /// <param name="instances">Names of the nodes in the gateway.</param>
        /// <param name="activeMessageCount">Number of active messages.</param>
        /// <param name="latestPublishedMsiVersion">Last published MSI
        /// version.</param>
        /// <param name="publishedTimeUtc">The date/time of the last published
        /// gateway.</param>
        /// <param name="installerDownload">Installer download uri.</param>
        /// <param name="minimumVersion">Minimum gateway version.</param>
        public GatewayResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?), UpgradeMode? upgradeMode = default(UpgradeMode?), string desiredVersion = default(string), IList<GatewayStatus> instances = default(IList<GatewayStatus>), int? activeMessageCount = default(int?), string latestPublishedMsiVersion = default(string), System.DateTime? publishedTimeUtc = default(System.DateTime?), string installerDownload = default(string), string minimumVersion = default(string))
            : base(id, type, name, location, tags, etag)
        {
            Created = created;
            Updated = updated;
            UpgradeMode = upgradeMode;
            DesiredVersion = desiredVersion;
            Instances = instances;
            ActiveMessageCount = activeMessageCount;
            LatestPublishedMsiVersion = latestPublishedMsiVersion;
            PublishedTimeUtc = publishedTimeUtc;
            InstallerDownload = installerDownload;
            MinimumVersion = minimumVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets UTC date and time when gateway was first added to
        /// management service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets UTC date and time when node was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public System.DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets the upgradeMode property gives the flexibility to
        /// gateway to auto upgrade itself. If properties value not specified,
        /// then we assume upgradeMode = Automatic. Possible values include:
        /// 'Manual', 'Automatic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradeMode")]
        public UpgradeMode? UpgradeMode { get; set; }

        /// <summary>
        /// Gets or sets latest available MSI version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.desiredVersion")]
        public string DesiredVersion { get; set; }

        /// <summary>
        /// Gets or sets names of the nodes in the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instances")]
        public IList<GatewayStatus> Instances { get; set; }

        /// <summary>
        /// Gets or sets number of active messages.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeMessageCount")]
        public int? ActiveMessageCount { get; set; }

        /// <summary>
        /// Gets or sets last published MSI version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestPublishedMsiVersion")]
        public string LatestPublishedMsiVersion { get; set; }

        /// <summary>
        /// Gets or sets the date/time of the last published gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishedTimeUtc")]
        public System.DateTime? PublishedTimeUtc { get; set; }

        /// <summary>
        /// Gets installer download uri.
        /// </summary>
        [JsonProperty(PropertyName = "properties.installerDownload")]
        public string InstallerDownload { get; private set; }

        /// <summary>
        /// Gets minimum gateway version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minimumVersion")]
        public string MinimumVersion { get; private set; }

    }
}