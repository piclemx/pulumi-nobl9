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

    public sealed class SloObjectiveCountMetricGoodThousandeyeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the test
        /// </summary>
        [Input("testId", required: true)]
        public Input<int> TestId { get; set; } = null!;

        public SloObjectiveCountMetricGoodThousandeyeGetArgs()
        {
        }
        public static new SloObjectiveCountMetricGoodThousandeyeGetArgs Empty => new SloObjectiveCountMetricGoodThousandeyeGetArgs();
    }
}
