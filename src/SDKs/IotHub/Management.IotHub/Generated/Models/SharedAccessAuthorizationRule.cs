// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class SharedAccessAuthorizationRule
    {
        /// <summary>
        /// Initializes a new instance of the SharedAccessAuthorizationRule
        /// class.
        /// </summary>
        public SharedAccessAuthorizationRule() { }

        /// <summary>
        /// Initializes a new instance of the SharedAccessAuthorizationRule
        /// class.
        /// </summary>
        public SharedAccessAuthorizationRule(string keyName = default(string), string primaryKey = default(string), string issuerName = default(string), string secondaryKey = default(string), string claimType = default(string), string claimValue = default(string), IList<SBAccessRights?> rights = default(IList<SBAccessRights?>), DateTime? createdTime = default(DateTime?), DateTime? modifiedTime = default(DateTime?), long? revision = default(long?))
        {
            KeyName = keyName;
            PrimaryKey = primaryKey;
            IssuerName = issuerName;
            SecondaryKey = secondaryKey;
            ClaimType = claimType;
            ClaimValue = claimValue;
            Rights = rights;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            Revision = revision;
        }

        /// <summary>
        /// The key name.
        /// </summary>
        [JsonProperty(PropertyName = "KeyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// The primary key.
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// The issuer name.
        /// </summary>
        [JsonProperty(PropertyName = "IssuerName")]
        public string IssuerName { get; set; }

        /// <summary>
        /// The secondary key.
        /// </summary>
        [JsonProperty(PropertyName = "SecondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// The claim type.
        /// </summary>
        [JsonProperty(PropertyName = "ClaimType")]
        public string ClaimType { get; set; }

        /// <summary>
        /// The claim value.
        /// </summary>
        [JsonProperty(PropertyName = "ClaimValue")]
        public string ClaimValue { get; set; }

        /// <summary>
        /// The rights.
        /// </summary>
        [JsonProperty(PropertyName = "Rights")]
        public IList<SBAccessRights?> Rights { get; set; }

        /// <summary>
        /// The created time.
        /// </summary>
        [JsonProperty(PropertyName = "CreatedTime")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// The modified time.
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// The revision.
        /// </summary>
        [JsonProperty(PropertyName = "Revision")]
        public long? Revision { get; set; }

    }
}
