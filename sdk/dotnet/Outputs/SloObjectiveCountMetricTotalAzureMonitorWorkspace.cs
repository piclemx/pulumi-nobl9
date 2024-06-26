// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9.Outputs
{

    [OutputType]
    public sealed class SloObjectiveCountMetricTotalAzureMonitorWorkspace
    {
        /// <summary>
        /// Resource group of the workspace
        /// </summary>
        public readonly string ResourceGroup;
        /// <summary>
        /// Subscription ID of the workspace
        /// </summary>
        public readonly string SubscriptionId;
        /// <summary>
        /// ID of the workspace
        /// </summary>
        public readonly string WorkspaceId;

        [OutputConstructor]
        private SloObjectiveCountMetricTotalAzureMonitorWorkspace(
            string resourceGroup,

            string subscriptionId,

            string workspaceId)
        {
            ResourceGroup = resourceGroup;
            SubscriptionId = subscriptionId;
            WorkspaceId = workspaceId;
        }
    }
}
