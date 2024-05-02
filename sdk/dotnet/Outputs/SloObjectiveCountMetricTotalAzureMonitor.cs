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
    public sealed class SloObjectiveCountMetricTotalAzureMonitor
    {
        /// <summary>
        /// Aggregation type [Required for metrics]
        /// </summary>
        public readonly string? Aggregation;
        /// <summary>
        /// Specifies source: 'metrics' or 'logs'
        /// </summary>
        public readonly string DataType;
        /// <summary>
        /// Dimensions of the metric [Optional for metrics]
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricTotalAzureMonitorDimension> Dimensions;
        /// <summary>
        /// Logs query in Kusto Query Language [Required for logs]
        /// </summary>
        public readonly string? KqlQuery;
        /// <summary>
        /// Name of the metric [Required for metrics]
        /// </summary>
        public readonly string? MetricName;
        /// <summary>
        /// Namespace of the metric [Optional for metrics]
        /// </summary>
        public readonly string? MetricNamespace;
        /// <summary>
        /// Identifier of the Azure Cloud resource [Required for metrics]
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// Log analytics workspace [Required for logs]
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricTotalAzureMonitorWorkspace> Workspaces;

        [OutputConstructor]
        private SloObjectiveCountMetricTotalAzureMonitor(
            string? aggregation,

            string dataType,

            ImmutableArray<Outputs.SloObjectiveCountMetricTotalAzureMonitorDimension> dimensions,

            string? kqlQuery,

            string? metricName,

            string? metricNamespace,

            string? resourceId,

            ImmutableArray<Outputs.SloObjectiveCountMetricTotalAzureMonitorWorkspace> workspaces)
        {
            Aggregation = aggregation;
            DataType = dataType;
            Dimensions = dimensions;
            KqlQuery = kqlQuery;
            MetricName = metricName;
            MetricNamespace = metricNamespace;
            ResourceId = resourceId;
            Workspaces = workspaces;
        }
    }
}
