// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job creation parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the JobCreateParameters class.
        /// </summary>
        public JobCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobCreateParameters class.
        /// </summary>
        /// <param name="cluster">Cluster.</param>
        /// <param name="nodeCount">Node count.</param>
        /// <param name="stdOutErrPathPrefix">Standard output path
        /// prefix.</param>
        /// <param name="schedulingPriority">Scheduling priority.</param>
        /// <param name="mountVolumes">Mount volumes.</param>
        /// <param name="containerSettings">Container settings.</param>
        /// <param name="cntkSettings">CNTK settings.</param>
        /// <param name="pyTorchSettings">pyTorch settings.</param>
        /// <param name="tensorFlowSettings">TensorFlow settings.</param>
        /// <param name="caffeSettings">Caffe settings.</param>
        /// <param name="caffe2Settings">Caffe2 settings.</param>
        /// <param name="chainerSettings">Chainer settings.</param>
        /// <param name="customToolkitSettings">Custom tool kit job.</param>
        /// <param name="customMpiSettings">Custom MPI settings.</param>
        /// <param name="horovodSettings">Horovod settings.</param>
        /// <param name="jobPreparation">Job preparation.</param>
        /// <param name="inputDirectories">Input directories.</param>
        /// <param name="outputDirectories">Output directories.</param>
        /// <param name="environmentVariables">Environment variables.</param>
        /// <param name="secrets">Secrets.</param>
        /// <param name="constraints">Constraints associated with the
        /// Job.</param>
        public JobCreateParameters(ResourceId cluster, int nodeCount, string stdOutErrPathPrefix, string schedulingPriority = default(string), MountVolumes mountVolumes = default(MountVolumes), ContainerSettings containerSettings = default(ContainerSettings), CNTKsettings cntkSettings = default(CNTKsettings), PyTorchSettings pyTorchSettings = default(PyTorchSettings), TensorFlowSettings tensorFlowSettings = default(TensorFlowSettings), CaffeSettings caffeSettings = default(CaffeSettings), Caffe2Settings caffe2Settings = default(Caffe2Settings), ChainerSettings chainerSettings = default(ChainerSettings), CustomToolkitSettings customToolkitSettings = default(CustomToolkitSettings), CustomMpiSettings customMpiSettings = default(CustomMpiSettings), HorovodSettings horovodSettings = default(HorovodSettings), JobPreparation jobPreparation = default(JobPreparation), IList<InputDirectory> inputDirectories = default(IList<InputDirectory>), IList<OutputDirectory> outputDirectories = default(IList<OutputDirectory>), IList<EnvironmentVariable> environmentVariables = default(IList<EnvironmentVariable>), IList<EnvironmentVariableWithSecretValue> secrets = default(IList<EnvironmentVariableWithSecretValue>), JobBasePropertiesConstraints constraints = default(JobBasePropertiesConstraints))
        {
            SchedulingPriority = schedulingPriority;
            Cluster = cluster;
            MountVolumes = mountVolumes;
            NodeCount = nodeCount;
            ContainerSettings = containerSettings;
            CntkSettings = cntkSettings;
            PyTorchSettings = pyTorchSettings;
            TensorFlowSettings = tensorFlowSettings;
            CaffeSettings = caffeSettings;
            Caffe2Settings = caffe2Settings;
            ChainerSettings = chainerSettings;
            CustomToolkitSettings = customToolkitSettings;
            CustomMpiSettings = customMpiSettings;
            HorovodSettings = horovodSettings;
            JobPreparation = jobPreparation;
            StdOutErrPathPrefix = stdOutErrPathPrefix;
            InputDirectories = inputDirectories;
            OutputDirectories = outputDirectories;
            EnvironmentVariables = environmentVariables;
            Secrets = secrets;
            Constraints = constraints;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scheduling priority.
        /// </summary>
        /// <remarks>
        /// Scheduling priority associated with the job. Possible values: low,
        /// normal, high. Possible values include: 'low', 'normal', 'high'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.schedulingPriority")]
        public string SchedulingPriority { get; set; }

        /// <summary>
        /// Gets or sets cluster.
        /// </summary>
        /// <remarks>
        /// Resource ID of the cluster on which this job will run.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.cluster")]
        public ResourceId Cluster { get; set; }

        /// <summary>
        /// Gets or sets mount volumes.
        /// </summary>
        /// <remarks>
        /// Information on mount volumes to be used by the job. These volumes
        /// will be mounted before the job execution and will be unmouted after
        /// the job completion. The volumes will be mounted at location
        /// specified by $AZ_BATCHAI_JOB_MOUNT_ROOT environment variable.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.mountVolumes")]
        public MountVolumes MountVolumes { get; set; }

        /// <summary>
        /// Gets or sets node count.
        /// </summary>
        /// <remarks>
        /// Number of compute nodes to run the job on. The job will be gang
        /// scheduled on that many compute nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.nodeCount")]
        public int NodeCount { get; set; }

        /// <summary>
        /// Gets or sets container settings.
        /// </summary>
        /// <remarks>
        /// Docker container settings for the job. If not provided, the job
        /// will run directly on the node.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.containerSettings")]
        public ContainerSettings ContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets CNTK settings.
        /// </summary>
        /// <remarks>
        /// Settings for CNTK (aka Microsoft Cognitive Toolkit) job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.cntkSettings")]
        public CNTKsettings CntkSettings { get; set; }

        /// <summary>
        /// Gets or sets pyTorch settings.
        /// </summary>
        /// <remarks>
        /// Settings for pyTorch job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.pyTorchSettings")]
        public PyTorchSettings PyTorchSettings { get; set; }

        /// <summary>
        /// Gets or sets tensorFlow settings.
        /// </summary>
        /// <remarks>
        /// Settings for Tensor Flow job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.tensorFlowSettings")]
        public TensorFlowSettings TensorFlowSettings { get; set; }

        /// <summary>
        /// Gets or sets caffe settings.
        /// </summary>
        /// <remarks>
        /// Settings for Caffe job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.caffeSettings")]
        public CaffeSettings CaffeSettings { get; set; }

        /// <summary>
        /// Gets or sets caffe2 settings.
        /// </summary>
        /// <remarks>
        /// Settings for Caffe2 job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.caffe2Settings")]
        public Caffe2Settings Caffe2Settings { get; set; }

        /// <summary>
        /// Gets or sets chainer settings.
        /// </summary>
        /// <remarks>
        /// Settings for Chainer job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.chainerSettings")]
        public ChainerSettings ChainerSettings { get; set; }

        /// <summary>
        /// Gets or sets custom tool kit job.
        /// </summary>
        /// <remarks>
        /// Settings for custom tool kit job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.customToolkitSettings")]
        public CustomToolkitSettings CustomToolkitSettings { get; set; }

        /// <summary>
        /// Gets or sets custom MPI settings.
        /// </summary>
        /// <remarks>
        /// Settings for custom MPI job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.customMpiSettings")]
        public CustomMpiSettings CustomMpiSettings { get; set; }

        /// <summary>
        /// Gets or sets horovod settings.
        /// </summary>
        /// <remarks>
        /// Settings for Horovod job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.horovodSettings")]
        public HorovodSettings HorovodSettings { get; set; }

        /// <summary>
        /// Gets or sets job preparation.
        /// </summary>
        /// <remarks>
        /// A command line to be executed on each node allocated for the job
        /// before tool kit is launched.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.jobPreparation")]
        public JobPreparation JobPreparation { get; set; }

        /// <summary>
        /// Gets or sets standard output path prefix.
        /// </summary>
        /// <remarks>
        /// The path where the Batch AI service will store stdout, stderror and
        /// execution log of the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.stdOutErrPathPrefix")]
        public string StdOutErrPathPrefix { get; set; }

        /// <summary>
        /// Gets or sets input directories.
        /// </summary>
        /// <remarks>
        /// A list of input directories for the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.inputDirectories")]
        public IList<InputDirectory> InputDirectories { get; set; }

        /// <summary>
        /// Gets or sets output directories.
        /// </summary>
        /// <remarks>
        /// A list of output directories for the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.outputDirectories")]
        public IList<OutputDirectory> OutputDirectories { get; set; }

        /// <summary>
        /// Gets or sets environment variables.
        /// </summary>
        /// <remarks>
        /// A list of user defined environment variables which will be setup
        /// for the job.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.environmentVariables")]
        public IList<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets secrets.
        /// </summary>
        /// <remarks>
        /// A list of user defined environment variables with secret values
        /// which will be setup for the job. Server will never report values of
        /// these variables back.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.secrets")]
        public IList<EnvironmentVariableWithSecretValue> Secrets { get; set; }

        /// <summary>
        /// Gets or sets constraints associated with the Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.constraints")]
        public JobBasePropertiesConstraints Constraints { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Cluster == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Cluster");
            }
            if (StdOutErrPathPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StdOutErrPathPrefix");
            }
            if (Cluster != null)
            {
                Cluster.Validate();
            }
            if (ContainerSettings != null)
            {
                ContainerSettings.Validate();
            }
            if (PyTorchSettings != null)
            {
                PyTorchSettings.Validate();
            }
            if (TensorFlowSettings != null)
            {
                TensorFlowSettings.Validate();
            }
            if (Caffe2Settings != null)
            {
                Caffe2Settings.Validate();
            }
            if (ChainerSettings != null)
            {
                ChainerSettings.Validate();
            }
            if (CustomMpiSettings != null)
            {
                CustomMpiSettings.Validate();
            }
            if (HorovodSettings != null)
            {
                HorovodSettings.Validate();
            }
            if (JobPreparation != null)
            {
                JobPreparation.Validate();
            }
            if (InputDirectories != null)
            {
                foreach (var element in InputDirectories)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (OutputDirectories != null)
            {
                foreach (var element1 in OutputDirectories)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (EnvironmentVariables != null)
            {
                foreach (var element2 in EnvironmentVariables)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Secrets != null)
            {
                foreach (var element3 in Secrets)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}