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

    public sealed class SloObjectiveRawMetricQueryAzureMonitorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Aggregation type [Required for metrics]
        /// </summary>
        [Input("aggregation")]
        public Input<string>? Aggregation { get; set; }

        /// <summary>
        /// Specifies source: 'metrics' or 'logs'
        /// </summary>
        [Input("dataType", required: true)]
        public Input<string> DataType { get; set; } = null!;

        [Input("dimensions")]
        private InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorDimensionGetArgs>? _dimensions;

        /// <summary>
        /// Dimensions of the metric [Optional for metrics]
        /// </summary>
        public InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorDimensionGetArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorDimensionGetArgs>());
            set => _dimensions = value;
        }

        /// <summary>
        /// Logs query in Kusto Query Language [Required for logs]
        /// </summary>
        [Input("kqlQuery")]
        public Input<string>? KqlQuery { get; set; }

        /// <summary>
        /// Name of the metric [Required for metrics]
        /// </summary>
        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        /// <summary>
        /// Namespace of the metric [Optional for metrics]
        /// </summary>
        [Input("metricNamespace")]
        public Input<string>? MetricNamespace { get; set; }

        /// <summary>
        /// Identifier of the Azure Cloud resource [Required for metrics]
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        [Input("workspaces")]
        private InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorWorkspaceGetArgs>? _workspaces;

        /// <summary>
        /// Log analytics workspace [Required for logs]
        /// </summary>
        public InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorWorkspaceGetArgs> Workspaces
        {
            get => _workspaces ?? (_workspaces = new InputList<Inputs.SloObjectiveRawMetricQueryAzureMonitorWorkspaceGetArgs>());
            set => _workspaces = value;
        }

        public SloObjectiveRawMetricQueryAzureMonitorGetArgs()
        {
        }
        public static new SloObjectiveRawMetricQueryAzureMonitorGetArgs Empty => new SloObjectiveRawMetricQueryAzureMonitorGetArgs();
    }
}
