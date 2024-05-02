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
    public sealed class SloObjective
    {
        /// <summary>
        /// Compares two time series, calculating the ratio of either good or bad values to the total number of values. Fill either the 'good' or 'bad' series, but not both.
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetric> CountMetrics;
        /// <summary>
        /// Name to be displayed
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Objective's name. This field is computed if not provided.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Type of logical operation
        /// </summary>
        public readonly string? Op;
        /// <summary>
        /// Raw data is used to compare objective values.
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveRawMetric> RawMetrics;
        /// <summary>
        /// Designated value
        /// </summary>
        public readonly double Target;
        /// <summary>
        /// Designated value for slice
        /// </summary>
        public readonly double? TimeSliceTarget;
        /// <summary>
        /// Value
        /// </summary>
        public readonly double Value;

        [OutputConstructor]
        private SloObjective(
            ImmutableArray<Outputs.SloObjectiveCountMetric> countMetrics,

            string displayName,

            string? name,

            string? op,

            ImmutableArray<Outputs.SloObjectiveRawMetric> rawMetrics,

            double target,

            double? timeSliceTarget,

            double value)
        {
            CountMetrics = countMetrics;
            DisplayName = displayName;
            Name = name;
            Op = op;
            RawMetrics = rawMetrics;
            Target = target;
            TimeSliceTarget = timeSliceTarget;
            Value = value;
        }
    }
}
