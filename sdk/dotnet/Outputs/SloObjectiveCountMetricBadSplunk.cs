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
    public sealed class SloObjectiveCountMetricBadSplunk
    {
        /// <summary>
        /// Query for the metrics
        /// </summary>
        public readonly string Query;

        [OutputConstructor]
        private SloObjectiveCountMetricBadSplunk(string query)
        {
            Query = query;
        }
    }
}
