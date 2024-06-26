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

    public sealed class DirectDynatraceHistoricalDataRetrievalGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultDurations", required: true)]
        private InputList<Inputs.DirectDynatraceHistoricalDataRetrievalDefaultDurationGetArgs>? _defaultDurations;

        /// <summary>
        /// Used by default for any SLOs connected to this data source.
        /// </summary>
        public InputList<Inputs.DirectDynatraceHistoricalDataRetrievalDefaultDurationGetArgs> DefaultDurations
        {
            get => _defaultDurations ?? (_defaultDurations = new InputList<Inputs.DirectDynatraceHistoricalDataRetrievalDefaultDurationGetArgs>());
            set => _defaultDurations = value;
        }

        [Input("maxDurations", required: true)]
        private InputList<Inputs.DirectDynatraceHistoricalDataRetrievalMaxDurationGetArgs>? _maxDurations;

        /// <summary>
        /// Defines the maximum period for which data can be retrieved.
        /// </summary>
        public InputList<Inputs.DirectDynatraceHistoricalDataRetrievalMaxDurationGetArgs> MaxDurations
        {
            get => _maxDurations ?? (_maxDurations = new InputList<Inputs.DirectDynatraceHistoricalDataRetrievalMaxDurationGetArgs>());
            set => _maxDurations = value;
        }

        public DirectDynatraceHistoricalDataRetrievalGetArgs()
        {
        }
        public static new DirectDynatraceHistoricalDataRetrievalGetArgs Empty => new DirectDynatraceHistoricalDataRetrievalGetArgs();
    }
}
