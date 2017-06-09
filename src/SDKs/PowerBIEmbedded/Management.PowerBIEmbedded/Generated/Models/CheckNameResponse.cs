// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.PowerBIEmbedded;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CheckNameResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameResponse class.
        /// </summary>
        public CheckNameResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameResponse class.
        /// </summary>
        /// <param name="nameAvailable">Specifies a Boolean value that
        /// indicates whether the specified Power BI Workspace Collection name
        /// is available to use.</param>
        /// <param name="reason">Reason why the workspace collection name
        /// cannot be used. Possible values include: 'Unavailable',
        /// 'Invalid'</param>
        /// <param name="message">Message indicating an unavailable name due to
        /// a conflict, or a description of the naming rules that are
        /// violated.</param>
        public CheckNameResponse(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies a Boolean value that indicates whether the
        /// specified Power BI Workspace Collection name is available to use.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets reason why the workspace collection name cannot be
        /// used. Possible values include: 'Unavailable', 'Invalid'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets message indicating an unavailable name due to a
        /// conflict, or a description of the naming rules that are violated.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}