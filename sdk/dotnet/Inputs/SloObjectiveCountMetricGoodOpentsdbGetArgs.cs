// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricGoodOpentsdbGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public SloObjectiveCountMetricGoodOpentsdbGetArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodOpentsdbGetArgs Empty => new SloObjectiveCountMetricGoodOpentsdbGetArgs();
    }
}
