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
    /// Describes the result of resource validation.
    /// </summary>
    public partial class ValidateResponse
    {
        /// <summary>
        /// Initializes a new instance of the ValidateResponse class.
        /// </summary>
        public ValidateResponse() { }

        /// <summary>
        /// Initializes a new instance of the ValidateResponse class.
        /// </summary>
        /// <param name="status">Result of validation.</param>
        /// <param name="error">Error details for the case when validation
        /// fails.</param>
        public ValidateResponse(string status = default(string), ValidateResponseError error = default(ValidateResponseError))
        {
            Status = status;
            Error = error;
        }

        /// <summary>
        /// Gets or sets result of validation.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets error details for the case when validation fails.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ValidateResponseError Error { get; set; }

    }
}
