// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalElasticsearchGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public SloObjectiveCountMetricTotalElasticsearchGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalElasticsearchGetArgs Empty => new SloObjectiveCountMetricTotalElasticsearchGetArgs();
    }
}