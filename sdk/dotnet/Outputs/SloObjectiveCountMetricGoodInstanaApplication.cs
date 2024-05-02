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
    public sealed class SloObjectiveCountMetricGoodInstanaApplication
    {
        /// <summary>
        /// Aggregation type [Required for metrics]
        /// </summary>
        public readonly string Aggregation;
        /// <summary>
        /// API query user passes in a JSON format
        /// </summary>
        public readonly string ApiQuery;
        /// <summary>
        /// Group by method
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaApplicationGroupBy> GroupBies;
        /// <summary>
        /// Include internal
        /// </summary>
        public readonly bool? IncludeInternal;
        /// <summary>
        /// Include synthetic
        /// </summary>
        public readonly bool? IncludeSynthetic;
        /// <summary>
        /// Metric ID one of 'calls', 'erroneousCalls', 'errors', 'latency'
        /// </summary>
        public readonly string MetricId;

        [OutputConstructor]
        private SloObjectiveCountMetricGoodInstanaApplication(
            string aggregation,

            string apiQuery,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaApplicationGroupBy> groupBies,

            bool? includeInternal,

            bool? includeSynthetic,

            string metricId)
        {
            Aggregation = aggregation;
            ApiQuery = apiQuery;
            GroupBies = groupBies;
            IncludeInternal = includeInternal;
            IncludeSynthetic = includeSynthetic;
            MetricId = metricId;
        }
    }
}
