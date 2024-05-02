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
    public sealed class SloObjectiveCountMetricBadHoneycomb
    {
        /// <summary>
        /// Column name - required for all calculation types besides 'CONCURRENCY' and 'COUNT'
        /// </summary>
        public readonly string? Attribute;
        /// <summary>
        /// Calculation type
        /// </summary>
        public readonly string Calculation;

        [OutputConstructor]
        private SloObjectiveCountMetricBadHoneycomb(
            string? attribute,

            string calculation)
        {
            Attribute = attribute;
            Calculation = calculation;
        }
    }
}
