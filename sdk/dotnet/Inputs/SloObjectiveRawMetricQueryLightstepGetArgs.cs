// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveRawMetricQueryLightstepGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("percentile")]
        public Input<double>? Percentile { get; set; }

        [Input("streamId")]
        public Input<string>? StreamId { get; set; }

        [Input("typeOfData", required: true)]
        public Input<string> TypeOfData { get; set; } = null!;

        [Input("uql")]
        public Input<string>? Uql { get; set; }

        public SloObjectiveRawMetricQueryLightstepGetArgs()
        {
        }
        public static new SloObjectiveRawMetricQueryLightstepGetArgs Empty => new SloObjectiveRawMetricQueryLightstepGetArgs();
    }
}
