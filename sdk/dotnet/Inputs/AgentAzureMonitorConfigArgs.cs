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

    public sealed class AgentAzureMonitorConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Azure Tenant Id.
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        public AgentAzureMonitorConfigArgs()
        {
        }
        public static new AgentAzureMonitorConfigArgs Empty => new AgentAzureMonitorConfigArgs();
    }
}
