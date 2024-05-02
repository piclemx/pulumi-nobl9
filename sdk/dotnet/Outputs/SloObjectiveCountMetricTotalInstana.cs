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
    public sealed class SloObjectiveCountMetricTotalInstana
    {
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricTotalInstanaApplication> Applications;
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricTotalInstanaInfrastructure> Infrastructures;
        /// <summary>
        /// Instana metric type 'application' or 'infrastructure'
        /// </summary>
        public readonly string MetricType;

        [OutputConstructor]
        private SloObjectiveCountMetricTotalInstana(
            ImmutableArray<Outputs.SloObjectiveCountMetricTotalInstanaApplication> applications,

            ImmutableArray<Outputs.SloObjectiveCountMetricTotalInstanaInfrastructure> infrastructures,

            string metricType)
        {
            Applications = applications;
            Infrastructures = infrastructures;
            MetricType = metricType;
        }
    }
}
