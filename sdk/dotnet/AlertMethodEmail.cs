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
    [Nobl9ResourceType("nobl9:index/alertMethodEmail:AlertMethodEmail")]
    public partial class AlertMethodEmail : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Blind carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        [Output("bccs")]
        public Output<ImmutableArray<string>> Bccs { get; private set; } = null!;

        /// <summary>
        /// This value was used as the template for the email alert's body. 'body' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Output("body")]
        public Output<string?> Body { get; private set; } = null!;

        /// <summary>
        /// Carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        [Output("ccs")]
        public Output<ImmutableArray<string>> Ccs { get; private set; } = null!;

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
        /// This value was used as the email alert's subject. 'subject' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Output("subject")]
        public Output<string?> Subject { get; private set; } = null!;

        /// <summary>
        /// Recipients. The maximum number of recipients is 10.
        /// </summary>
        [Output("tos")]
        public Output<ImmutableArray<string>> Tos { get; private set; } = null!;


        /// <summary>
        /// Create a AlertMethodEmail resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertMethodEmail(string name, AlertMethodEmailArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodEmail:AlertMethodEmail", name, args ?? new AlertMethodEmailArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertMethodEmail(string name, Input<string> id, AlertMethodEmailState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/alertMethodEmail:AlertMethodEmail", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/piclemx/pulumi-nobl9",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AlertMethodEmail resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertMethodEmail Get(string name, Input<string> id, AlertMethodEmailState? state = null, CustomResourceOptions? options = null)
        {
            return new AlertMethodEmail(name, id, state, options);
        }
    }

    public sealed class AlertMethodEmailArgs : global::Pulumi.ResourceArgs
    {
        [Input("bccs")]
        private InputList<string>? _bccs;

        /// <summary>
        /// Blind carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Bccs
        {
            get => _bccs ?? (_bccs = new InputList<string>());
            set => _bccs = value;
        }

        /// <summary>
        /// This value was used as the template for the email alert's body. 'body' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Input("body")]
        public Input<string>? Body { get; set; }

        [Input("ccs")]
        private InputList<string>? _ccs;

        /// <summary>
        /// Carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Ccs
        {
            get => _ccs ?? (_ccs = new InputList<string>());
            set => _ccs = value;
        }

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
        /// This value was used as the email alert's subject. 'subject' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Input("subject")]
        public Input<string>? Subject { get; set; }

        [Input("tos", required: true)]
        private InputList<string>? _tos;

        /// <summary>
        /// Recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Tos
        {
            get => _tos ?? (_tos = new InputList<string>());
            set => _tos = value;
        }

        public AlertMethodEmailArgs()
        {
        }
        public static new AlertMethodEmailArgs Empty => new AlertMethodEmailArgs();
    }

    public sealed class AlertMethodEmailState : global::Pulumi.ResourceArgs
    {
        [Input("bccs")]
        private InputList<string>? _bccs;

        /// <summary>
        /// Blind carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Bccs
        {
            get => _bccs ?? (_bccs = new InputList<string>());
            set => _bccs = value;
        }

        /// <summary>
        /// This value was used as the template for the email alert's body. 'body' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Input("body")]
        public Input<string>? Body { get; set; }

        [Input("ccs")]
        private InputList<string>? _ccs;

        /// <summary>
        /// Carbon copy recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Ccs
        {
            get => _ccs ?? (_ccs = new InputList<string>());
            set => _ccs = value;
        }

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
        /// This value was used as the email alert's subject. 'subject' is deprecated and not used anywhere; however, its' kept for backward compatibility.
        /// </summary>
        [Input("subject")]
        public Input<string>? Subject { get; set; }

        [Input("tos")]
        private InputList<string>? _tos;

        /// <summary>
        /// Recipients. The maximum number of recipients is 10.
        /// </summary>
        public InputList<string> Tos
        {
            get => _tos ?? (_tos = new InputList<string>());
            set => _tos = value;
        }

        public AlertMethodEmailState()
        {
        }
        public static new AlertMethodEmailState Empty => new AlertMethodEmailState();
    }
}
