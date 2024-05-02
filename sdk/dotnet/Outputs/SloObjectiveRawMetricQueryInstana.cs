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
    public sealed class SloObjectiveRawMetricQueryInstana
    {
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaApplication> Applications;
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaInfrastructure> Infrastructures;
        /// <summary>
        /// Instana metric type 'application' or 'infrastructure'
        /// </summary>
        public readonly string MetricType;

        [OutputConstructor]
        private SloObjectiveRawMetricQueryInstana(
            ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaApplication> applications,

            ImmutableArray<Outputs.SloObjectiveRawMetricQueryInstanaInfrastructure> infrastructures,

            string metricType)
        {
            Applications = applications;
            Infrastructures = infrastructures;
            MetricType = metricType;
        }
    }
}