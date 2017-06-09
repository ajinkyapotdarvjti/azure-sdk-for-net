// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Billing;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A secure URL that can be used to download a PDF invoice until the URL
    /// expires.
    /// </summary>
    public partial class DownloadUrl
    {
        /// <summary>
        /// Initializes a new instance of the DownloadUrl class.
        /// </summary>
        public DownloadUrl()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DownloadUrl class.
        /// </summary>
        /// <param name="expiryTime">The time in UTC at which this download URL
        /// will expire.</param>
        /// <param name="url">The URL to the PDF file.</param>
        public DownloadUrl(System.DateTime? expiryTime = default(System.DateTime?), string url = default(string))
        {
            ExpiryTime = expiryTime;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time in UTC at which this download URL will expire.
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; private set; }

        /// <summary>
        /// Gets the URL to the PDF file.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

    }
}