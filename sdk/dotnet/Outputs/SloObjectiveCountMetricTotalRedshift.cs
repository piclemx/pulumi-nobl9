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
    public sealed class SloObjectiveCountMetricTotalRedshift
    {
        /// <summary>
        /// Redshift custer ID
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// Database name
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// Query for the metrics
        /// </summary>
        public readonly string Query;
        /// <summary>
        /// Region of the CloudWatch instance
        /// </summary>
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
