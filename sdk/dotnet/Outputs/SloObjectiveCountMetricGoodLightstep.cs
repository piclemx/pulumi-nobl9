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
    public sealed class SloObjectiveCountMetricGoodLightstep
    {
        /// <summary>
        /// Optional value to filter by percentiles
        /// </summary>
        public readonly double? Percentile;
        /// <summary>
        /// ID of the metrics stream
        /// </summary>
        public readonly string? StreamId;
        /// <summary>
        /// Type of data to filter by
        /// </summary>
        public readonly string TypeOfData;
        /// <summary>
        /// UQL query
        /// </summary>
        public readonly string? Uql;

        [OutputConstructor]
        private SloObjectiveCountMetricGoodLightstep(
            double? percentile,

            string? streamId,

            string typeOfData,

            string? uql)
        {
            Percentile = percentile;
            StreamId = streamId;
            TypeOfData = typeOfData;
            Uql = uql;
        }
    }
}
