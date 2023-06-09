// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricArgs : global::Pulumi.ResourceArgs
    {
        [Input("goods")]
        private InputList<Inputs.SloObjectiveCountMetricGoodArgs>? _goods;
        public InputList<Inputs.SloObjectiveCountMetricGoodArgs> Goods
        {
            get => _goods ?? (_goods = new InputList<Inputs.SloObjectiveCountMetricGoodArgs>());
            set => _goods = value;
        }

        [Input("incremental", required: true)]
        public Input<bool> Incremental { get; set; } = null!;

        [Input("totals")]
        private InputList<Inputs.SloObjectiveCountMetricTotalArgs>? _totals;
        public InputList<Inputs.SloObjectiveCountMetricTotalArgs> Totals
        {
            get => _totals ?? (_totals = new InputList<Inputs.SloObjectiveCountMetricTotalArgs>());
            set => _totals = value;
        }

        public SloObjectiveCountMetricArgs()
        {
        }
        public static new SloObjectiveCountMetricArgs Empty => new SloObjectiveCountMetricArgs();
    }
}
