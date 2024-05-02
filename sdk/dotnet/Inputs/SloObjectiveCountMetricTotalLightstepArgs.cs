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

    public sealed class SloObjectiveCountMetricTotalLightstepArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional value to filter by percentiles
        /// </summary>
        [Input("percentile")]
        public Input<double>? Percentile { get; set; }

        /// <summary>
        /// ID of the metrics stream
        /// </summary>
        [Input("streamId")]
        public Input<string>? StreamId { get; set; }

        /// <summary>
        /// Type of data to filter by
        /// </summary>
        [Input("typeOfData", required: true)]
        public Input<string> TypeOfData { get; set; } = null!;

        /// <summary>
        /// UQL query
        /// </summary>
        [Input("uql")]
        public Input<string>? Uql { get; set; }

        public SloObjectiveCountMetricTotalLightstepArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalLightstepArgs Empty => new SloObjectiveCountMetricTotalLightstepArgs();
    }
}
