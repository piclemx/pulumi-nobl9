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

    public sealed class SloCompositeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("burnRateConditions")]
        private InputList<Inputs.SloCompositeBurnRateConditionGetArgs>? _burnRateConditions;

        /// <summary>
        /// Condition when the Composite SLO’s error budget is burning.
        /// </summary>
        public InputList<Inputs.SloCompositeBurnRateConditionGetArgs> BurnRateConditions
        {
            get => _burnRateConditions ?? (_burnRateConditions = new InputList<Inputs.SloCompositeBurnRateConditionGetArgs>());
            set => _burnRateConditions = value;
        }

        /// <summary>
        /// Designated value
        /// </summary>
        [Input("target", required: true)]
        public Input<double> Target { get; set; } = null!;

        public SloCompositeGetArgs()
        {
        }
        public static new SloCompositeGetArgs Empty => new SloCompositeGetArgs();
    }
}
