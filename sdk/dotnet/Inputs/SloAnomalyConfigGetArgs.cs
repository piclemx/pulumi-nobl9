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

    public sealed class SloAnomalyConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        [Input("noData", required: true)]
        public Input<Inputs.SloAnomalyConfigNoDataGetArgs> NoData { get; set; } = null!;

        public SloAnomalyConfigGetArgs()
        {
        }
        public static new SloAnomalyConfigGetArgs Empty => new SloAnomalyConfigGetArgs();
    }
}
