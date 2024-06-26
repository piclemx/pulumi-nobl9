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
    public sealed class DirectHoneycombHistoricalDataRetrieval
    {
        /// <summary>
        /// Used by default for any SLOs connected to this data source.
        /// </summary>
        public readonly ImmutableArray<Outputs.DirectHoneycombHistoricalDataRetrievalDefaultDuration> DefaultDurations;
        /// <summary>
        /// Defines the maximum period for which data can be retrieved.
        /// </summary>
        public readonly ImmutableArray<Outputs.DirectHoneycombHistoricalDataRetrievalMaxDuration> MaxDurations;

        [OutputConstructor]
        private DirectHoneycombHistoricalDataRetrieval(
            ImmutableArray<Outputs.DirectHoneycombHistoricalDataRetrievalDefaultDuration> defaultDurations,

            ImmutableArray<Outputs.DirectHoneycombHistoricalDataRetrievalMaxDuration> maxDurations)
        {
            DefaultDurations = defaultDurations;
            MaxDurations = maxDurations;
        }
    }
}
