// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalGcmGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("query", required: true)]
        public Input<string> Query { get; set; } = null!;

        public SloObjectiveCountMetricTotalGcmGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalGcmGetArgs Empty => new SloObjectiveCountMetricTotalGcmGetArgs();
    }
}