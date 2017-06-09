// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System.Linq;

    /// <summary>
    /// A single Redis item in List or Get Operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RedisResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RedisResource class.
        /// </summary>
        public RedisResource() { }

        /// <summary>
        /// Initializes a new instance of the RedisResource class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="redisConfiguration">All Redis Settings. Few possible
        /// keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.</param>
        /// <param name="enableNonSslPort">Specifies whether the non-ssl Redis
        /// server port (6379) is enabled.</param>
        /// <param name="tenantSettings">tenantSettings</param>
        /// <param name="shardCount">The number of shards to be created on a
        /// Premium Cluster Cache.</param>
        /// <param name="subnetId">The full resource ID of a subnet in a
        /// virtual network to deploy the Redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1</param>
        /// <param name="staticIP">Static IP address. Required when deploying
        /// a Redis cache inside an existing Azure Virtual Network.</param>
        /// <param name="sku">The SKU of the Redis cache to deploy.</param>
        /// <param name="redisVersion">Redis version.</param>
        /// <param name="provisioningState">Redis instance provisioning
        /// status.</param>
        /// <param name="hostName">Redis host name.</param>
        /// <param name="port">Redis non-SSL port.</param>
        /// <param name="sslPort">Redis SSL port.</param>
        /// <param name="accessKeys">The keys of the Redis cache - not set if
        /// this object is not the response to Create or Update redis
        /// cache</param>
        public RedisResource(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IDictionary<string, string> redisConfiguration = default(System.Collections.Generic.IDictionary<string, string>), bool? enableNonSslPort = default(bool?), System.Collections.Generic.IDictionary<string, string> tenantSettings = default(System.Collections.Generic.IDictionary<string, string>), int? shardCount = default(int?), string subnetId = default(string), string staticIP = default(string), Sku sku = default(Sku), string redisVersion = default(string), string provisioningState = default(string), string hostName = default(string), int? port = default(int?), int? sslPort = default(int?), RedisAccessKeys accessKeys = default(RedisAccessKeys))
            : base(location, id, name, type, tags)
        {
            RedisConfiguration = redisConfiguration;
            EnableNonSslPort = enableNonSslPort;
            TenantSettings = tenantSettings;
            ShardCount = shardCount;
            SubnetId = subnetId;
            StaticIP = staticIP;
            Sku = sku;
            RedisVersion = redisVersion;
            ProvisioningState = provisioningState;
            HostName = hostName;
            Port = port;
            SslPort = sslPort;
            AccessKeys = accessKeys;
        }

        /// <summary>
        /// Gets or sets all Redis Settings. Few possible keys:
        /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.redisConfiguration")]
        public System.Collections.Generic.IDictionary<string, string> RedisConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the non-ssl Redis server port
        /// (6379) is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableNonSslPort")]
        public bool? EnableNonSslPort { get; set; }

        /// <summary>
        /// Gets or sets tenantSettings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.tenantSettings")]
        public System.Collections.Generic.IDictionary<string, string> TenantSettings { get; set; }

        /// <summary>
        /// Gets or sets the number of shards to be created on a Premium
        /// Cluster Cache.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shardCount")]
        public int? ShardCount { get; set; }

        /// <summary>
        /// Gets or sets the full resource ID of a subnet in a virtual network
        /// to deploy the Redis cache in. Example format:
        /// /subscriptions/{subid}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets static IP address. Required when deploying a Redis
        /// cache inside an existing Azure Virtual Network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.staticIP")]
        public string StaticIP { get; set; }

        /// <summary>
        /// Gets or sets the SKU of the Redis cache to deploy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets redis version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.redisVersion")]
        public string RedisVersion { get; private set; }

        /// <summary>
        /// Gets redis instance provisioning status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets redis host name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets redis non-SSL port.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; private set; }

        /// <summary>
        /// Gets redis SSL port.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sslPort")]
        public int? SslPort { get; private set; }

        /// <summary>
        /// Gets the keys of the Redis cache - not set if this object is not
        /// the response to Create or Update redis cache
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessKeys")]
        public RedisAccessKeys AccessKeys { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.SubnetId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.SubnetId, "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "SubnetId", "^/subscriptions/[^/]*/resourceGroups/[^/]*/providers/Microsoft.(ClassicNetwork|Network)/virtualNetworks/[^/]*/subnets/[^/]*$");
                }
            }
            if (this.StaticIP != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.StaticIP, "^\\d+\\.\\d+\\.\\d+\\.\\d+$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "StaticIP", "^\\d+\\.\\d+\\.\\d+\\.\\d+$");
                }
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
        }
    }
}