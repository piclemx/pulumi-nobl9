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

    public sealed class AgentHistoricalDataRetrievalGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultDurations", required: true)]
        private InputList<Inputs.AgentHistoricalDataRetrievalDefaultDurationGetArgs>? _defaultDurations;

        /// <summary>
        /// Used by default for any SLOs connected to this data source.
        /// </summary>
        public InputList<Inputs.AgentHistoricalDataRetrievalDefaultDurationGetArgs> DefaultDurations
        {
            get => _defaultDurations ?? (_defaultDurations = new InputList<Inputs.AgentHistoricalDataRetrievalDefaultDurationGetArgs>());
            set => _defaultDurations = value;
        }

        [Input("maxDurations", required: true)]
        private InputList<Inputs.AgentHistoricalDataRetrievalMaxDurationGetArgs>? _maxDurations;

        /// <summary>
        /// Defines the maximum period for which data can be retrieved.
        /// </summary>
        public InputList<Inputs.AgentHistoricalDataRetrievalMaxDurationGetArgs> MaxDurations
        {
            get => _maxDurations ?? (_maxDurations = new InputList<Inputs.AgentHistoricalDataRetrievalMaxDurationGetArgs>());
            set => _maxDurations = value;
        }

        public AgentHistoricalDataRetrievalGetArgs()
        {
        }
        public static new AgentHistoricalDataRetrievalGetArgs Empty => new AgentHistoricalDataRetrievalGetArgs();
    }
}