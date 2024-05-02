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
    public sealed class SloTimeWindow
    {
        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        public readonly ImmutableArray<Outputs.SloTimeWindowCalendar> Calendars;
        /// <summary>
        /// Count of the time unit
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// Is the window moving or not
        /// </summary>
        public readonly bool? IsRolling;
        /// <summary>
        /// Period between start time and added count
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Period;
        /// <summary>
        /// Unit of time
        /// </summary>
        public readonly string Unit;

        [OutputConstructor]
        private SloTimeWindow(
            ImmutableArray<Outputs.SloTimeWindowCalendar> calendars,

            int count,

            bool? isRolling,

            ImmutableDictionary<string, string>? period,

            string unit)
        {
            Calendars = calendars;
            Count = count;
            IsRolling = isRolling;
            Period = period;
            Unit = unit;
        }
    }
}
