// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Outputs
{

    [OutputType]
    public sealed class AgentLightstepConfig
    {
        /// <summary>
        /// Organization name registered in Lightstep.
        /// </summary>
        public readonly string Organization;
        /// <summary>
        /// Name of the Lightstep project.
        /// </summary>
        public readonly string Project;

        [OutputConstructor]
        private AgentLightstepConfig(
            string organization,

            string project)
        {
            Organization = organization;
            Project = project;
        }
    }
}