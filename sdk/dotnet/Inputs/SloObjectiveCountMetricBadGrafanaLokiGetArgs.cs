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

    public sealed class SloObjectiveCountMetricBadGrafanaLokiGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Query for the logs
        /// </summary>
        [Input("logql", required: true)]
        public Input<string> Logql { get; set; } = null!;

        public SloObjectiveCountMetricBadGrafanaLokiGetArgs()
        {
        }
        public static new SloObjectiveCountMetricBadGrafanaLokiGetArgs Empty => new SloObjectiveCountMetricBadGrafanaLokiGetArgs();
    }
}
