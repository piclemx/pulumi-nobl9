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

    public sealed class SloObjectiveRawMetricQueryNewrelicArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Query for the metrics
        /// </summary>
        [Input("nrql", required: true)]
        public Input<string> Nrql { get; set; } = null!;

        public SloObjectiveRawMetricQueryNewrelicArgs()
        {
        }
        public static new SloObjectiveRawMetricQueryNewrelicArgs Empty => new SloObjectiveRawMetricQueryNewrelicArgs();
    }
}