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
    public sealed class AgentSumologicConfig
    {
        /// <summary>
        /// Sumo Logic API URL.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private AgentSumologicConfig(string url)
        {
            Url = url;
        }
    }
}