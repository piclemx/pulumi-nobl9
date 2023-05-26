// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Outputs
{

    [OutputType]
    public sealed class SloObjectiveRawMetricQueryInstanaApplication
    {
        public readonly string Aggregation;
        public readonly string ApiQuery;
        public readonly ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaApplicationGroupBy> GroupBies;
        public readonly bool? IncludeInternal;
        public readonly bool? IncludeSynthetic;
        public readonly string MetricId;

        [OutputConstructor]
        private SloObjectiveRawMetricQueryInstanaApplication(
            string aggregation,

            string apiQuery,

            ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaApplicationGroupBy> groupBies,

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
