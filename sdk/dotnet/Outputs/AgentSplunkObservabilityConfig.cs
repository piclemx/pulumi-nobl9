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
    public sealed class AgentSplunkObservabilityConfig
    {
        /// <summary>
        /// SplunkObservability Realm.
        /// </summary>
        public readonly string Realm;

        [OutputConstructor]
        private AgentSplunkObservabilityConfig(string realm)
        {
            Realm = realm;
        }
    }
}