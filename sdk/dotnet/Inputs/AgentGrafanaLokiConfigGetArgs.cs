// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9.Inputs
{

    public sealed class AgentGrafanaLokiConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// API URL endpoint to the Grafana Loki instance.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public AgentGrafanaLokiConfigGetArgs()
        {
        }
        public static new AgentGrafanaLokiConfigGetArgs Empty => new AgentGrafanaLokiConfigGetArgs();
    }
}
