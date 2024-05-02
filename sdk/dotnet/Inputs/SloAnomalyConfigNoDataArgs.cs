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

    public sealed class SloAnomalyConfigNoDataArgs : global::Pulumi.ResourceArgs
    {
        [Input("alertMethods", required: true)]
        private InputList<Inputs.SloAnomalyConfigNoDataAlertMethodArgs>? _alertMethods;

        /// <summary>
        /// Alert methods attached to Anomaly Config
        /// </summary>
        public InputList<Inputs.SloAnomalyConfigNoDataAlertMethodArgs> AlertMethods
        {
            get => _alertMethods ?? (_alertMethods = new InputList<Inputs.SloAnomalyConfigNoDataAlertMethodArgs>());
            set => _alertMethods = value;
        }

        public SloAnomalyConfigNoDataArgs()
        {
        }
        public static new SloAnomalyConfigNoDataArgs Empty => new SloAnomalyConfigNoDataArgs();
    }
}
