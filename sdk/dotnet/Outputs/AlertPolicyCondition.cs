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
    public sealed class AlertPolicyCondition
    {
        /// <summary>
        /// Duration over which the burn rate is evaluated.
        /// </summary>
        public readonly string? AlertingWindow;
        /// <summary>
        /// Indicates how long a given condition needs to be valid to mark the condition as true.
        /// </summary>
        public readonly string? LastsFor;
        /// <summary>
        /// One of `timeToBurnBudget` | `timeToBurnEntireBudget` | `burnRate` | `burnedBudget`.
        /// </summary>
        public readonly string Measurement;
        /// <summary>
        /// For `averageBurnRate`, it indicates how fast the error budget is burning. For `burnedBudget`, it tells how much error budget is already burned.
        /// </summary>
        public readonly double? Value;
        /// <summary>
        /// Used with `timeToBurnBudget` or `timeToBurnEntireBudget`, indicates when the budget would be exhausted. The expected value is a string in time duration string format.
        /// </summary>
        public readonly string? ValueString;

        [OutputConstructor]
        private AlertPolicyCondition(
            string? alertingWindow,

            string? lastsFor,

            string measurement,

            double? value,

            string? valueString)
        {
            AlertingWindow = alertingWindow;
            LastsFor = lastsFor;
            Measurement = measurement;
            Value = value;
            ValueString = valueString;
        }
    }
}
