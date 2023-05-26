// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveRawMetricQueryInstanaApplicationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("aggregation", required: true)]
        public Input<string> Aggregation { get; set; } = null!;

        [Input("apiQuery", required: true)]
        public Input<string> ApiQuery { get; set; } = null!;

        [Input("groupBies", required: true)]
        private InputList<Inputs.SloObjectiveRawMetricQueryInstanaApplicationGroupByGetArgs>? _groupBies;
        public InputList<Inputs.SloObjectiveRawMetricQueryInstanaApplicationGroupByGetArgs> GroupBies
        {
            get => _groupBies ?? (_groupBies = new InputList<Inputs.SloObjectiveRawMetricQueryInstanaApplicationGroupByGetArgs>());
            set => _groupBies = value;
        }

        [Input("includeInternal")]
        public Input<bool>? IncludeInternal { get; set; }

        [Input("includeSynthetic")]
        public Input<bool>? IncludeSynthetic { get; set; }

        [Input("metricId", required: true)]
        public Input<string> MetricId { get; set; } = null!;

        public SloObjectiveRawMetricQueryInstanaApplicationGetArgs()
        {
        }
        public static new SloObjectiveRawMetricQueryInstanaApplicationGetArgs Empty => new SloObjectiveRawMetricQueryInstanaApplicationGetArgs();
    }
}