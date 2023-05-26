// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class DirectPingdomQueryDelayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Must be one of Minute or Second.
        /// </summary>
        [Input("unit", required: true)]
        public Input<string> Unit { get; set; } = null!;

        /// <summary>
        /// Must be an integer greater than or equal to 0.
        /// </summary>
        [Input("value", required: true)]
        public Input<int> Value { get; set; } = null!;

        public DirectPingdomQueryDelayArgs()
        {
        }
        public static new DirectPingdomQueryDelayArgs Empty => new DirectPingdomQueryDelayArgs();
    }
}