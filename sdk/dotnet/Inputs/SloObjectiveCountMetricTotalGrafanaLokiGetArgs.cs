// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricTotalGrafanaLokiGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("logql", required: true)]
        public Input<string> Logql { get; set; } = null!;

        public SloObjectiveCountMetricTotalGrafanaLokiGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalGrafanaLokiGetArgs Empty => new SloObjectiveCountMetricTotalGrafanaLokiGetArgs();
    }
}