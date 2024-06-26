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

    public sealed class SloObjectiveCountMetricBadInstanaInfrastructureArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Metric ID one of 'calls', 'erroneousCalls', 'errors', 'latency'
        /// </summary>
        [Input("metricId", required: true)]
        public Input<string> MetricId { get; set; } = null!;

        /// <summary>
        /// Metric retrieval method 'query' or 'snapshot'
        /// </summary>
        [Input("metricRetrievalMethod", required: true)]
        public Input<string> MetricRetrievalMethod { get; set; } = null!;

        /// <summary>
        /// Plugin ID
        /// </summary>
        [Input("pluginId", required: true)]
        public Input<string> PluginId { get; set; } = null!;

        /// <summary>
        /// Query for the metrics
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// Snapshot ID
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        public SloObjectiveCountMetricBadInstanaInfrastructureArgs()
        {
        }
        public static new SloObjectiveCountMetricBadInstanaInfrastructureArgs Empty => new SloObjectiveCountMetricBadInstanaInfrastructureArgs();
    }
}
