// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLabs;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about a Windows OS.
    /// </summary>
    public partial class WindowsOsInfo
    {
        /// <summary>
        /// Initializes a new instance of the WindowsOsInfo class.
        /// </summary>
        public WindowsOsInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WindowsOsInfo class.
        /// </summary>
        /// <param name="windowsOsState">The state of the Windows OS (i.e.
        /// NonSysprepped, SysprepRequested, SysprepApplied). Possible values
        /// include: 'NonSysprepped', 'SysprepRequested',
        /// 'SysprepApplied'</param>
        public WindowsOsInfo(string windowsOsState = default(string))
        {
            WindowsOsState = windowsOsState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the Windows OS (i.e. NonSysprepped,
        /// SysprepRequested, SysprepApplied). Possible values include:
        /// 'NonSysprepped', 'SysprepRequested', 'SysprepApplied'
        /// </summary>
        [JsonProperty(PropertyName = "windowsOsState")]
        public string WindowsOsState { get; set; }

    }
}