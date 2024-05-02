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

    public sealed class SloObjectiveCountMetricGoodGcmArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// Query for the metrics
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public SloObjectiveCountMetricGoodGcmArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodGcmArgs Empty => new SloObjectiveCountMetricGoodGcmArgs();
    }
}
