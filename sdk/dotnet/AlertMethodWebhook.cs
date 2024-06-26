// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9
{
    [Nobl9ResourceType("nobl9:index/alertMethodWebhook:AlertMethodWebhook")]
    public partial class AlertMethodWebhook : global::Pulumi.CustomResource
    {
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
        /// Webhook message template. See documentation for template format and samples.
        /// </summary>
        [Output("template")]
        public Output<string?> Template { get; private set; } = null!;

        /// <summary>
        /// Webhook message fields. The message contains JSON payload with specified fields. See documentation for allowed fields.
        /// </summary>
        [Output("templateFields")]
        public Output<ImmutableArray<string>> TemplateFields { get; private set; } = null!;

        /// <summary>
        /// URL of the webhook endpoint.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a AlertMethodWebhook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertMethodWebhook(string name, AlertMethodWebhookArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodWebhook:AlertMethodWebhook", name, args ?? new AlertMethodWebhookArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertMethodWebhook(string name, Input<string> id, AlertMethodWebhookState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodWebhook:AlertMethodWebhook", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/piclemx/pulumi-nobl9",
                AdditionalSecretOutputs =
                {
                    "url",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AlertMethodWebhook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertMethodWebhook Get(string name, Input<string> id, AlertMethodWebhookState? state = null, CustomResourceOptions? options = null)
        {
            return new AlertMethodWebhook(name, id, state, options);
        }
    }

    public sealed class AlertMethodWebhookArgs : global::Pulumi.ResourceArgs
    {
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
        /// Webhook message template. See documentation for template format and samples.
        /// </summary>
        [Input("template")]
        public Input<string>? Template { get; set; }

        [Input("templateFields")]
        private InputList<string>? _templateFields;

        /// <summary>
        /// Webhook message fields. The message contains JSON payload with specified fields. See documentation for allowed fields.
        /// </summary>
        public InputList<string> TemplateFields
        {
            get => _templateFields ?? (_templateFields = new InputList<string>());
            set => _templateFields = value;
        }

        [Input("url")]
        private Input<string>? _url;

        /// <summary>
        /// URL of the webhook endpoint.
        /// </summary>
        public Input<string>? Url
        {
            get => _url;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _url = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AlertMethodWebhookArgs()
        {
        }
        public static new AlertMethodWebhookArgs Empty => new AlertMethodWebhookArgs();
    }

    public sealed class AlertMethodWebhookState : global::Pulumi.ResourceArgs
    {
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
        /// Webhook message template. See documentation for template format and samples.
        /// </summary>
        [Input("template")]
        public Input<string>? Template { get; set; }

        [Input("templateFields")]
        private InputList<string>? _templateFields;

        /// <summary>
        /// Webhook message fields. The message contains JSON payload with specified fields. See documentation for allowed fields.
        /// </summary>
        public InputList<string> TemplateFields
        {
            get => _templateFields ?? (_templateFields = new InputList<string>());
            set => _templateFields = value;
        }

        [Input("url")]
        private Input<string>? _url;

        /// <summary>
        /// URL of the webhook endpoint.
        /// </summary>
        public Input<string>? Url
        {
            get => _url;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _url = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public AlertMethodWebhookState()
        {
        }
        public static new AlertMethodWebhookState Empty => new AlertMethodWebhookState();
    }
}
