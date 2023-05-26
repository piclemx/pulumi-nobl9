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
    public sealed class AgentGraphiteConfig
    {
        /// <summary>
        /// API URL endpoint to the Graphite's instance.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private AgentGraphiteConfig(string url)
        {
            Url = url;
        }
    }
}