// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class AgentPrometheusConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Base URL to Prometheus server.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public AgentPrometheusConfigGetArgs()
        {
        }
        public static new AgentPrometheusConfigGetArgs Empty => new AgentPrometheusConfigGetArgs();
    }
}
