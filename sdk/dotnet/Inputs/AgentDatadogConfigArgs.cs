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

    public sealed class AgentDatadogConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// `com` or `eu`, Datadog SaaS instance, which corresponds to one of Datadog's two locations (https://www.datadoghq.com/ in the U.S. or https://datadoghq.eu/ in the European Union)
        /// </summary>
        [Input("site", required: true)]
        public Input<string> Site { get; set; } = null!;

        public AgentDatadogConfigArgs()
        {
        }
        public static new AgentDatadogConfigArgs Empty => new AgentDatadogConfigArgs();
    }
}
