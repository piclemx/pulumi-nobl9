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
    public sealed class SloObjectiveRawMetricQueryCloudwatch
    {
        /// <summary>
        /// AccountID used with cross-account observability feature
        /// </summary>
        public readonly string? AccountId;
        /// <summary>
        /// Dimensions of the metric [Optional for metrics]
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveRawMetricQueryCloudwatchDimension> Dimensions;
        /// <summary>
        /// JSON query
        /// </summary>
        public readonly string? Json;
        /// <summary>
        /// Name of the metric [Required for metrics]
        /// </summary>
        public readonly string? MetricName;
        /// <summary>
        /// Namespace of the metric
        /// </summary>
        public readonly string? Namespace;
        /// <summary>
        /// Region of the CloudWatch instance
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// SQL query
        /// </summary>
        public readonly string? Sql;
        /// <summary>
        /// Metric data aggregations
        /// </summary>
        public readonly string? Stat;

        [OutputConstructor]
        private SloObjectiveRawMetricQueryCloudwatch(
            string? accountId,

            ImmutableArray<Outputs.SloObjectiveRawMetricQueryCloudwatchDimension> dimensions,

            string? json,

            string? metricName,

            string? @namespace,

            string region,

            string? sql,

            string? stat)
        {
            AccountId = accountId;
            Dimensions = dimensions;
            Json = json;
            MetricName = metricName;
            Namespace = @namespace;
            Region = region;
            Sql = sql;
            Stat = stat;
        }
    }
}
