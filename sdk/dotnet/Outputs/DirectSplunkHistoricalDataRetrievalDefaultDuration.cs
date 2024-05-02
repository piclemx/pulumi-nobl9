// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9.Outputs
{

    [OutputType]
    public sealed class DirectSplunkHistoricalDataRetrievalDefaultDuration
    {
        /// <summary>
        /// Must be one of Minute, Hour, or Day.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// Must be an integer greater than or equal to 0.
        /// </summary>
        public readonly int Value;

        [OutputConstructor]
        private DirectSplunkHistoricalDataRetrievalDefaultDuration(
            string unit,

            int value)
        {
            Unit = unit;
            Value = value;
        }
    }
}
