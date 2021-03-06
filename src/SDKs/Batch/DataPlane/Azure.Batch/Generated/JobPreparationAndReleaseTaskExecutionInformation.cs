// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The status of the Job Preparation task and Job Release task on a compute node.
    /// </summary>
    public partial class JobPreparationAndReleaseTaskExecutionInformation : IPropertyMetadata
    {
        private readonly string computeNodeId;
        private readonly string computeNodeUrl;
        private readonly JobPreparationTaskExecutionInformation jobPreparationTaskExecutionInformation;
        private readonly JobReleaseTaskExecutionInformation jobReleaseTaskExecutionInformation;
        private readonly string poolId;

        #region Constructors

        internal JobPreparationAndReleaseTaskExecutionInformation(Models.JobPreparationAndReleaseTaskExecutionInformation protocolObject)
        {
            this.computeNodeId = protocolObject.NodeId;
            this.computeNodeUrl = protocolObject.NodeUrl;
            this.jobPreparationTaskExecutionInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.JobPreparationTaskExecutionInfo, o => new JobPreparationTaskExecutionInformation(o).Freeze());
            this.jobReleaseTaskExecutionInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.JobReleaseTaskExecutionInfo, o => new JobReleaseTaskExecutionInformation(o).Freeze());
            this.poolId = protocolObject.PoolId;
        }

        #endregion Constructors

        #region JobPreparationAndReleaseTaskExecutionInformation

        /// <summary>
        /// Gets the id of the compute node.
        /// </summary>
        public string ComputeNodeId
        {
            get { return this.computeNodeId; }
        }

        /// <summary>
        /// Gets the URL of the compute node.
        /// </summary>
        public string ComputeNodeUrl
        {
            get { return this.computeNodeUrl; }
        }

        /// <summary>
        /// Gets details of the <see cref="CloudJob.JobPreparationTask">Job Preparation task</see> on this compute node.
        /// </summary>
        public JobPreparationTaskExecutionInformation JobPreparationTaskExecutionInformation
        {
            get { return this.jobPreparationTaskExecutionInformation; }
        }

        /// <summary>
        /// Gets details of the <see cref="CloudJob.JobReleaseTask">Job Release task</see> on this compute node.
        /// </summary>
        public JobReleaseTaskExecutionInformation JobReleaseTaskExecutionInformation
        {
            get { return this.jobReleaseTaskExecutionInformation; }
        }

        /// <summary>
        /// Gets the id of the pool containing the compute node.
        /// </summary>
        public string PoolId
        {
            get { return this.poolId; }
        }

        #endregion // JobPreparationAndReleaseTaskExecutionInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}