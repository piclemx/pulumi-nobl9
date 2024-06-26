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
    public sealed class SloComposite
    {
        /// <summary>
        /// Condition when the Composite SLO’s error budget is burning.
        /// </summary>
        public readonly ImmutableArray<Outputs.SloCompositeBurnRateCondition> BurnRateConditions;
        /// <summary>
        /// Designated value
        /// </summary>
        public readonly double Target;

        [OutputConstructor]
        private SloComposite(
            ImmutableArray<Outputs.SloCompositeBurnRateCondition> burnRateConditions,

            double target)
        {
            BurnRateConditions = burnRateConditions;
            Target = target;
        }
    }
}
