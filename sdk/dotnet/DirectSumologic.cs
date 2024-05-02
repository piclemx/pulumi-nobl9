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
    /// Sumo Logic is an observability platform that provides visibility into AWS, Azure, and GCP cloud applications and infrastructure. Nobl9 connects to Sumo Logic for SLI measurement collection and comparison with SLO targets.
    /// 
    /// For more information, refer to [Sumo Logic Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/sumo-logic#sumo-logic-direct).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nobl9 = Piclemx.Nobl9;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var test_sumologic = new Nobl9.DirectSumologic("test-sumologic", new()
    ///     {
    ///         AccessId = "secret",
    ///         AccessKey = "secret",
    ///         Description = "desc",
    ///         LogCollectionEnabled = true,
    ///         Project = "terraform",
    ///         Url = "http://web.net",
    ///     });
    /// 
    /// });
    /// ```
    /// ## Nobl9 Official Documentation
    /// 
    /// https://docs.nobl9.com/
    /// </summary>
    [Nobl9ResourceType("nobl9:index/directSumologic:DirectSumologic")]
    public partial class DirectSumologic : global::Pulumi.CustomResource
    {
        /// <summary>
        /// [required] | Sumo Logic API Access ID.
        /// </summary>
        [Output("accessId")]
        public Output<string> AccessId { get; private set; } = null!;

        /// <summary>
        /// [required] | Sumo Logic API Access Key.
        /// </summary>
        [Output("accessKey")]
        public Output<string> AccessKey { get; private set; } = null!;

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
        /// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        /// </summary>
        [Output("logCollectionEnabled")]
        public Output<bool?> LogCollectionEnabled { get; private set; } = null!;

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
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Output("queryDelay")]
        public Output<Outputs.DirectSumologicQueryDelay> QueryDelay { get; private set; } = null!;

        /// <summary>
        /// Release channel of the created datasource [stable/beta]
        /// </summary>
        [Output("releaseChannel")]
        public Output<string> ReleaseChannel { get; private set; } = null!;

        /// <summary>
        /// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        /// </summary>
        [Output("sourceOfs")]
        public Output<ImmutableArray<string>> SourceOfs { get; private set; } = null!;

        /// <summary>
        /// The status of the created direct.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Sumo Logic API URL.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a DirectSumologic resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DirectSumologic(string name, DirectSumologicArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/directSumologic:DirectSumologic", name, args ?? new DirectSumologicArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DirectSumologic(string name, Input<string> id, DirectSumologicState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/directSumologic:DirectSumologic", name, state, MakeResourceOptions(options, id))
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
                    "accessId",
                    "accessKey",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DirectSumologic resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DirectSumologic Get(string name, Input<string> id, DirectSumologicState? state = null, CustomResourceOptions? options = null)
        {
            return new DirectSumologic(name, id, state, options);
        }
    }

    public sealed class DirectSumologicArgs : global::Pulumi.ResourceArgs
    {
        [Input("accessId")]
        private Input<string>? _accessId;

        /// <summary>
        /// [required] | Sumo Logic API Access ID.
        /// </summary>
        public Input<string>? AccessId
        {
            get => _accessId;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessId = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("accessKey")]
        private Input<string>? _accessKey;

        /// <summary>
        /// [required] | Sumo Logic API Access Key.
        /// </summary>
        public Input<string>? AccessKey
        {
            get => _accessKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
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
        /// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        /// </summary>
        [Input("logCollectionEnabled")]
        public Input<bool>? LogCollectionEnabled { get; set; }

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
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Input("queryDelay")]
        public Input<Inputs.DirectSumologicQueryDelayArgs>? QueryDelay { get; set; }

        /// <summary>
        /// Release channel of the created datasource [stable/beta]
        /// </summary>
        [Input("releaseChannel")]
        public Input<string>? ReleaseChannel { get; set; }

        [Input("sourceOfs")]
        private InputList<string>? _sourceOfs;

        /// <summary>
        /// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        /// </summary>
        [Obsolete(@"'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.")]
        public InputList<string> SourceOfs
        {
            get => _sourceOfs ?? (_sourceOfs = new InputList<string>());
            set => _sourceOfs = value;
        }

        /// <summary>
        /// Sumo Logic API URL.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public DirectSumologicArgs()
        {
        }
        public static new DirectSumologicArgs Empty => new DirectSumologicArgs();
    }

    public sealed class DirectSumologicState : global::Pulumi.ResourceArgs
    {
        [Input("accessId")]
        private Input<string>? _accessId;

        /// <summary>
        /// [required] | Sumo Logic API Access ID.
        /// </summary>
        public Input<string>? AccessId
        {
            get => _accessId;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessId = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        [Input("accessKey")]
        private Input<string>? _accessKey;

        /// <summary>
        /// [required] | Sumo Logic API Access Key.
        /// </summary>
        public Input<string>? AccessKey
        {
            get => _accessKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _accessKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
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
        /// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        /// </summary>
        [Input("logCollectionEnabled")]
        public Input<bool>? LogCollectionEnabled { get; set; }

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
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Input("queryDelay")]
        public Input<Inputs.DirectSumologicQueryDelayGetArgs>? QueryDelay { get; set; }

        /// <summary>
        /// Release channel of the created datasource [stable/beta]
        /// </summary>
        [Input("releaseChannel")]
        public Input<string>? ReleaseChannel { get; set; }

        [Input("sourceOfs")]
        private InputList<string>? _sourceOfs;

        /// <summary>
        /// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        /// </summary>
        [Obsolete(@"'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.")]
        public InputList<string> SourceOfs
        {
            get => _sourceOfs ?? (_sourceOfs = new InputList<string>());
            set => _sourceOfs = value;
        }

        /// <summary>
        /// The status of the created direct.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Sumo Logic API URL.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public DirectSumologicState()
        {
        }
        public static new DirectSumologicState Empty => new DirectSumologicState();
    }
}
