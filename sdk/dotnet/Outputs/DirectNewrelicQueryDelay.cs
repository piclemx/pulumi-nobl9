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
    public sealed class DirectNewrelicQueryDelay
    {
        /// <summary>
        /// Must be one of Minute or Second.
        /// </summary>
        public readonly string Unit;
        /// <summary>
        /// Must be an integer greater than or equal to 0.
        /// </summary>
        public readonly int Value;

        [OutputConstructor]
        private DirectNewrelicQueryDelay(
            string unit,

            int value)
        {
            Unit = unit;
            Value = value;
        }
    }
}
