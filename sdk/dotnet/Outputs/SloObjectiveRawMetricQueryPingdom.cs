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
    public sealed class SloObjectiveRawMetricQueryPingdom
    {
        /// <summary>
        /// Pingdom uptime or transaction check's ID
        /// </summary>
        public readonly string CheckId;
        /// <summary>
        /// Pingdom check type - uptime or transaction
        /// </summary>
        public readonly string? CheckType;
        /// <summary>
        /// Optional for the Uptime checks. Use it to filter the Pingdom check results by status
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private SloObjectiveRawMetricQueryPingdom(
            string checkId,

            string? checkType,

            string? status)
        {
            CheckId = checkId;
            CheckType = checkType;
            Status = status;
        }
    }
}
