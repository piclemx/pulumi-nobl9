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
    public sealed class SloObjectiveCountMetricGoodInstana
    {
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaApplication> Applications;
        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaInfrastructure> Infrastructures;
        /// <summary>
        /// Instana metric type 'application' or 'infrastructure'
        /// </summary>
        public readonly string MetricType;

        [OutputConstructor]
        private SloObjectiveCountMetricGoodInstana(
            ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaApplication> applications,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstanaInfrastructure> infrastructures,

            string metricType)
        {
            Applications = applications;
            Infrastructures = infrastructures;
            MetricType = metricType;
        }
    }
}
