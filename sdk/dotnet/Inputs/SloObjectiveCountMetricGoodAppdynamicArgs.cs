// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricGoodAppdynamicArgs : global::Pulumi.ResourceArgs
    {
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        [Input("metricPath", required: true)]
        public Input<string> MetricPath { get; set; } = null!;

        public SloObjectiveCountMetricGoodAppdynamicArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodAppdynamicArgs Empty => new SloObjectiveCountMetricGoodAppdynamicArgs();
    }
}
