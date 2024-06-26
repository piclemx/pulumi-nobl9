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

    public sealed class SloCompositeBurnRateConditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of logical operation
        /// </summary>
        [Input("op", required: true)]
        public Input<string> Op { get; set; } = null!;

        /// <summary>
        /// Burn rate value.
        /// </summary>
        [Input("value", required: true)]
        public Input<double> Value { get; set; } = null!;

        public SloCompositeBurnRateConditionGetArgs()
        {
        }
        public static new SloCompositeBurnRateConditionGetArgs Empty => new SloCompositeBurnRateConditionGetArgs();
    }
}
