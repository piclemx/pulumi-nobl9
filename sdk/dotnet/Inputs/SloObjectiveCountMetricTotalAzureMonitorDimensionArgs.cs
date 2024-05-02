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

    public sealed class SloObjectiveCountMetricTotalAzureMonitorDimensionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the previously defined alert method.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Burn rate value.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public SloObjectiveCountMetricTotalAzureMonitorDimensionArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalAzureMonitorDimensionArgs Empty => new SloObjectiveCountMetricTotalAzureMonitorDimensionArgs();
    }
}
