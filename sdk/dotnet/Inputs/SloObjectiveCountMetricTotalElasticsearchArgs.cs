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

    public sealed class SloObjectiveCountMetricTotalElasticsearchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Index of metrics we want to query
        /// </summary>
        [Input("index", required: true)]
        public Input<string> Index { get; set; } = null!;

        /// <summary>
        /// Query for the metrics
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public SloObjectiveCountMetricTotalElasticsearchArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalElasticsearchArgs Empty => new SloObjectiveCountMetricTotalElasticsearchArgs();
    }
}