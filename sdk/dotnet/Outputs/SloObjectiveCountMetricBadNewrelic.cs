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
    public sealed class SloObjectiveCountMetricBadNewrelic
    {
        /// <summary>
        /// Query for the metrics
        /// </summary>
        public readonly string Nrql;

        [OutputConstructor]
        private SloObjectiveCountMetricBadNewrelic(string nrql)
        {
            Nrql = nrql;
        }
    }
}
