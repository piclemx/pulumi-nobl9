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
    /// <summary>
    /// The provider type for the nobl9 package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// </summary>
    [Nobl9ResourceType("pulumi:providers:nobl9")]
    public partial class Provider : global::Pulumi.ProviderResource
    {
        /// <summary>
        /// the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
        /// Nobl9.
        /// </summary>
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        /// <summary>
        /// the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
        /// to Nobl9.
        /// </summary>
        [Output("clientSecret")]
        public Output<string> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// Nobl9 API URL.
        /// </summary>
        [Output("ingestUrl")]
        public Output<string?> IngestUrl { get; private set; } = null!;

        /// <summary>
        /// Authorization service configuration.
        /// </summary>
        [Output("oktaAuthServer")]
        public Output<string?> OktaAuthServer { get; private set; } = null!;

        /// <summary>
        /// Authorization service URL.
        /// </summary>
        [Output("oktaOrgUrl")]
        public Output<string?> OktaOrgUrl { get; private set; } = null!;

        /// <summary>
        /// Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
        /// contains resources managed by the Nobl9 Terraform provider.
        /// </summary>
        [Output("organization")]
        public Output<string?> Organization { get; private set; } = null!;

        /// <summary>
        /// Nobl9 project used when importing resources.
        /// </summary>
        [Output("project")]
        public Output<string?> Project { get; private set; } = null!;


        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs args, CustomResourceOptions? options = null)
            : base("nobl9", name, args ?? new ProviderArgs(), MakeResourceOptions(options, ""))
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
                    "clientSecret",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
        /// Nobl9.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        [Input("clientSecret", required: true)]
        private Input<string>? _clientSecret;

        /// <summary>
        /// the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
        /// to Nobl9.
        /// </summary>
        public Input<string>? ClientSecret
        {
            get => _clientSecret;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _clientSecret = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Nobl9 API URL.
        /// </summary>
        [Input("ingestUrl")]
        public Input<string>? IngestUrl { get; set; }

        /// <summary>
        /// Authorization service configuration.
        /// </summary>
        [Input("oktaAuthServer")]
        public Input<string>? OktaAuthServer { get; set; }

        /// <summary>
        /// Authorization service URL.
        /// </summary>
        [Input("oktaOrgUrl")]
        public Input<string>? OktaOrgUrl { get; set; }

        /// <summary>
        /// Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
        /// contains resources managed by the Nobl9 Terraform provider.
        /// </summary>
        [Input("organization")]
        public Input<string>? Organization { get; set; }

        /// <summary>
        /// Nobl9 project used when importing resources.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        public ProviderArgs()
        {
        }
        public static new ProviderArgs Empty => new ProviderArgs();
    }
}
