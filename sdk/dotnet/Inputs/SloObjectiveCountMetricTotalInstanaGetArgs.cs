// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalInstanaGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("applications")]
        private InputList<Inputs.SloObjectiveCountMetricTotalInstanaApplicationGetArgs>? _applications;
        public InputList<Inputs.SloObjectiveCountMetricTotalInstanaApplicationGetArgs> Applications
        {
            get => _applications ?? (_applications = new InputList<Inputs.SloObjectiveCountMetricTotalInstanaApplicationGetArgs>());
            set => _applications = value;
        }

        [Input("infrastructures")]
        private InputList<Inputs.SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs>? _infrastructures;
        public InputList<Inputs.SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs> Infrastructures
        {
            get => _infrastructures ?? (_infrastructures = new InputList<Inputs.SloObjectiveCountMetricTotalInstanaInfrastructureGetArgs>());
            set => _infrastructures = value;
        }

        [Input("metricType", required: true)]
        public Input<string> MetricType { get; set; } = null!;

        public SloObjectiveCountMetricTotalInstanaGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalInstanaGetArgs Empty => new SloObjectiveCountMetricTotalInstanaGetArgs();
    }
}