// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("metricId", required: true)]
        public Input<string> MetricId { get; set; } = null!;

        [Input("metricRetrievalMethod", required: true)]
        public Input<string> MetricRetrievalMethod { get; set; } = null!;

        [Input("pluginId", required: true)]
        public Input<string> PluginId { get; set; } = null!;

        [Input("query")]
        public Input<string>? Query { get; set; }

        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        public SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs Empty => new SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs();
    }
}
