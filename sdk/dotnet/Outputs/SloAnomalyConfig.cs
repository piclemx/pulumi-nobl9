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
    public sealed class SloAnomalyConfig
    {
        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        public readonly Outputs.SloAnomalyConfigNoData NoData;

        [OutputConstructor]
        private SloAnomalyConfig(Outputs.SloAnomalyConfigNoData noData)
        {
            NoData = noData;
        }
    }
}