// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Azure;
    using Management;
    using Storage;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The List SAS credentials operation response.
    /// </summary>
    public partial class ListAccountSasResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListAccountSasResponse class.
        /// </summary>
        public ListAccountSasResponse() { }

        /// <summary>
        /// Initializes a new instance of the ListAccountSasResponse class.
        /// </summary>
        /// <param name="accountSasToken">List SAS credentials of storage
        /// account.</param>
        public ListAccountSasResponse(string accountSasToken = default(string))
        {
            AccountSasToken = accountSasToken;
        }

        /// <summary>
        /// Gets list SAS credentials of storage account.
        /// </summary>
        [JsonProperty(PropertyName = "accountSasToken")]
        public string AccountSasToken { get; protected set; }

    }
}
