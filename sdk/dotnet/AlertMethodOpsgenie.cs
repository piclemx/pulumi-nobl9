// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9
{
    [Nobl9ResourceType("nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie")]
    public partial class AlertMethodOpsgenie : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
        /// </summary>
        [Output("auth")]
        public Output<string> Auth { get; private set; } = null!;

        /// <summary>
        /// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a AlertMethodOpsgenie resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertMethodOpsgenie(string name, AlertMethodOpsgenieArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie", name, args ?? new AlertMethodOpsgenieArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertMethodOpsgenie(string name, Input<string> id, AlertMethodOpsgenieState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/piclemx/pulumi-noble9/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AlertMethodOpsgenie resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertMethodOpsgenie Get(string name, Input<string> id, AlertMethodOpsgenieState? state = null, CustomResourceOptions? options = null)
        {
            return new AlertMethodOpsgenie(name, id, state, options);
        }
    }

    public sealed class AlertMethodOpsgenieArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
        /// </summary>
        [Input("auth")]
        public Input<string>? Auth { get; set; }

        /// <summary>
        /// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        /// <summary>
        /// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public AlertMethodOpsgenieArgs()
        {
        }
        public static new AlertMethodOpsgenieArgs Empty => new AlertMethodOpsgenieArgs();
    }

    public sealed class AlertMethodOpsgenieState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
        /// </summary>
        [Input("auth")]
        public Input<string>? Auth { get; set; }

        /// <summary>
        /// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public AlertMethodOpsgenieState()
        {
        }
        public static new AlertMethodOpsgenieState Empty => new AlertMethodOpsgenieState();
    }
}
