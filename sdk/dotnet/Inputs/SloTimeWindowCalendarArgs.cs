// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloTimeWindowCalendarArgs : global::Pulumi.ResourceArgs
    {
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        [Input("timeZone", required: true)]
        public Input<string> TimeZone { get; set; } = null!;

        public SloTimeWindowCalendarArgs()
        {
        }
        public static new SloTimeWindowCalendarArgs Empty => new SloTimeWindowCalendarArgs();
    }
}
