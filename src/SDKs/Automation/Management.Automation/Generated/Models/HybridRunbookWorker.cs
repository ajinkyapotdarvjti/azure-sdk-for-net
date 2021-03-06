// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of hybrid runbook worker.
    /// </summary>
    public partial class HybridRunbookWorker
    {
        private string _ipAddress;
        
        /// <summary>
        /// Optional. Gets or sets the assigned machine IP address.
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the worker machine name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private DateTimeOffset _registrationDateTime;
        
        /// <summary>
        /// Optional. Gets or sets the registration time of the worker machine.
        /// </summary>
        public DateTimeOffset RegistrationDateTime
        {
            get { return this._registrationDateTime; }
            set { this._registrationDateTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HybridRunbookWorker class.
        /// </summary>
        public HybridRunbookWorker()
        {
        }
    }
}
