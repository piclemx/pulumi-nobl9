// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9.Outputs
{

    [OutputType]
    public sealed class SloAttachment
    {
        /// <summary>
        /// Name displayed for the attachment. Max. length: 63 characters.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// URL to the attachment
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private SloAttachment(
            string? displayName,

            string url)
        {
            DisplayName = displayName;
            Url = url;
        }
    }
}