// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class DirectDatadogHistoricalDataRetrievalDefaultDurationArgs : global::Pulumi.ResourceArgs
    {
        [Input("unit", required: true)]
        public Input<string> Unit { get; set; } = null!;

        [Input("value", required: true)]
        public Input<int> Value { get; set; } = null!;

        public DirectDatadogHistoricalDataRetrievalDefaultDurationArgs()
        {
        }
        public static new DirectDatadogHistoricalDataRetrievalDefaultDurationArgs Empty => new DirectDatadogHistoricalDataRetrievalDefaultDurationArgs();
    }
}
