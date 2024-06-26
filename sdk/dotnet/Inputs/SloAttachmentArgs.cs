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

    public sealed class SloAttachmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name displayed for the attachment. Max. length: 63 characters.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// URL to the attachment
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public SloAttachmentArgs()
        {
        }
        public static new SloAttachmentArgs Empty => new SloAttachmentArgs();
    }
}
