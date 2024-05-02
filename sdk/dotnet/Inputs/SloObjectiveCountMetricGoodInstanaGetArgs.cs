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

    public sealed class SloObjectiveCountMetricGoodInstanaGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("applications")]
        private InputList<Inputs.SloObjectiveCountMetricGoodInstanaApplicationGetArgs>? _applications;

        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricGoodInstanaApplicationGetArgs> Applications
        {
            get => _applications ?? (_applications = new InputList<Inputs.SloObjectiveCountMetricGoodInstanaApplicationGetArgs>());
            set => _applications = value;
        }

        [Input("infrastructures")]
        private InputList<Inputs.SloObjectiveCountMetricGoodInstanaInfrastructureGetArgs>? _infrastructures;

        /// <summary>
        /// Infrastructure metric type
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricGoodInstanaInfrastructureGetArgs> Infrastructures
        {
            get => _infrastructures ?? (_infrastructures = new InputList<Inputs.SloObjectiveCountMetricGoodInstanaInfrastructureGetArgs>());
            set => _infrastructures = value;
        }

        /// <summary>
        /// Instana metric type 'application' or 'infrastructure'
        /// </summary>
        [Input("metricType", required: true)]
        public Input<string> MetricType { get; set; } = null!;

        public SloObjectiveCountMetricGoodInstanaGetArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodInstanaGetArgs Empty => new SloObjectiveCountMetricGoodInstanaGetArgs();
    }
}
