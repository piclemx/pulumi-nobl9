// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalPingdomArgs : global::Pulumi.ResourceArgs
    {
        [Input("checkId", required: true)]
        public Input<string> CheckId { get; set; } = null!;

        [Input("checkType")]
        public Input<string>? CheckType { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        public SloObjectiveCountMetricTotalPingdomArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalPingdomArgs Empty => new SloObjectiveCountMetricTotalPingdomArgs();
    }
}
