// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveRawMetricQuerySumologicArgs : global::Pulumi.ResourceArgs
    {
        [Input("quantization")]
        public Input<string>? Quantization { get; set; }

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        [Input("rollup")]
        public Input<string>? Rollup { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public SloObjectiveRawMetricQuerySumologicArgs()
        {
        }
        public static new SloObjectiveRawMetricQuerySumologicArgs Empty => new SloObjectiveRawMetricQuerySumologicArgs();
    }
}
