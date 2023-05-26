// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Inputs
{

    public sealed class DirectCloudwatchHistoricalDataRetrievalArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultDurations", required: true)]
        private InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalDefaultDurationArgs>? _defaultDurations;

        /// <summary>
        /// Used by default for any SLOs connected to this data source.
        /// </summary>
        public InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalDefaultDurationArgs> DefaultDurations
        {
            get => _defaultDurations ?? (_defaultDurations = new InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalDefaultDurationArgs>());
            set => _defaultDurations = value;
        }

        [Input("maxDurations", required: true)]
        private InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalMaxDurationArgs>? _maxDurations;

        /// <summary>
        /// Defines the maximum period for which data can be retrieved.
        /// </summary>
        public InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalMaxDurationArgs> MaxDurations
        {
            get => _maxDurations ?? (_maxDurations = new InputList<Inputs.DirectCloudwatchHistoricalDataRetrievalMaxDurationArgs>());
            set => _maxDurations = value;
        }

        public DirectCloudwatchHistoricalDataRetrievalArgs()
        {
        }
        public static new DirectCloudwatchHistoricalDataRetrievalArgs Empty => new DirectCloudwatchHistoricalDataRetrievalArgs();
    }
}
