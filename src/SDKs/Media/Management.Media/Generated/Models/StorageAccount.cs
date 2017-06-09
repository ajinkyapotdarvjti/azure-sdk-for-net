// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Media.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The properties of a storage account associated with this resource.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount(string id, bool isPrimary)
        {
            Id = id;
            IsPrimary = isPrimary;
        }

        /// <summary>
        /// The id of the storage account resource. Media Services relies on
        /// tables and queues as well as blobs, so the primary storage
        /// account must be a Standard Storage account (either
        /// Microsoft.ClassicStorage or Microsoft.Storage). Blob only storage
        /// accounts can be added as secondary storage accounts (isPrimary
        /// false).
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Is this storage account resource the primary storage account for
        /// the Media Service resource. Blob only storage must set this to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "isPrimary")]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}