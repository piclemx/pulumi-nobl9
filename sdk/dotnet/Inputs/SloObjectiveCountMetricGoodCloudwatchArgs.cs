// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricGoodCloudwatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("dimensions")]
        private InputList<Inputs.SloObjectiveCountMetricGoodCloudwatchDimensionArgs>? _dimensions;
        public InputList<Inputs.SloObjectiveCountMetricGoodCloudwatchDimensionArgs> Dimensions
        {
            get => _dimensions ?? (_dimensions = new InputList<Inputs.SloObjectiveCountMetricGoodCloudwatchDimensionArgs>());
            set => _dimensions = value;
        }

        [Input("json")]
        public Input<string>? Json { get; set; }

        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        [Input("sql")]
        public Input<string>? Sql { get; set; }

        [Input("stat")]
        public Input<string>? Stat { get; set; }

        public SloObjectiveCountMetricGoodCloudwatchArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodCloudwatchArgs Empty => new SloObjectiveCountMetricGoodCloudwatchArgs();
    }
}
