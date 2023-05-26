// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Outputs
{

    [OutputType]
    public sealed class SloObjectiveCountMetricTotalRedshift
    {
        public readonly string ClusterId;
        public readonly string DatabaseName;
        public readonly string Query;
        public readonly string Region;

        [OutputConstructor]
        private SloObjectiveCountMetricTotalRedshift(
            string clusterId,

            string databaseName,

            string query,

            string region)
        {
            ClusterId = clusterId;
            DatabaseName = databaseName;
            Query = query;
            Region = region;
        }
    }
}