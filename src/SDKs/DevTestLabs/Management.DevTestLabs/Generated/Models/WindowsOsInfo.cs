// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about a Windows OS.
    /// </summary>
    public partial class WindowsOsInfo
    {
        /// <summary>
        /// Initializes a new instance of the WindowsOsInfo class.
        /// </summary>
        public WindowsOsInfo() { }

        /// <summary>
        /// Initializes a new instance of the WindowsOsInfo class.
        /// </summary>
        public WindowsOsInfo(string windowsOsState = default(string))
        {
            WindowsOsState = windowsOsState;
        }

        /// <summary>
        /// The state of the Windows OS (i.e. NonSysprepped, SysprepRequested,
        /// SysprepApplied). Possible values include: 'NonSysprepped',
        /// 'SysprepRequested', 'SysprepApplied'
        /// </summary>
        [JsonProperty(PropertyName = "windowsOsState")]
        public string WindowsOsState { get; set; }

    }
}
