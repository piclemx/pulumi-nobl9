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

    public sealed class SloObjectiveCountMetricTotalRedshiftGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Redshift custer ID
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Database name
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        /// <summary>
        /// Query for the metrics
        /// </summary>
        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        /// <summary>
        /// Region of the CloudWatch instance
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        public SloObjectiveCountMetricTotalRedshiftGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalRedshiftGetArgs Empty => new SloObjectiveCountMetricTotalRedshiftGetArgs();
    }
}
