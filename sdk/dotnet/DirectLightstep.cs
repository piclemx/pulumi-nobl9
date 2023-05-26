// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Nobl9
{
    /// <summary>
    /// Lightstep is an observability platform that enables distributed tracing, that can be used to rapidly pinpoint the causes of failures and poor performance across the deeply complex dependencies among services, teams, and workloads in modern production systems. Nobl9 integration with Lightstep enables organizations to establish service level objectives from performance data captured through distributed traces in the Lightstep platform. Nobl9 connects with Lightstep to collect SLI measurements and compare them to SLO targets.
    /// 
    /// For more information, refer to [Lightstep Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/lightstep#lightstep-direct).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Nobl9 = Pulumi.Nobl9;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var test_lightstep = new Nobl9.DirectLightstep("test-lightstep", new()
    ///     {
    ///         AppToken = "secret",
    ///         Description = "desc",
    ///         HistoricalDataRetrieval = new Nobl9.Inputs.DirectLightstepHistoricalDataRetrievalArgs
    ///         {
    ///             DefaultDurations = new[]
    ///             {
    ///                 new Nobl9.Inputs.DirectLightstepHistoricalDataRetrievalDefaultDurationArgs
    ///                 {
    ///                     Unit = "Day",
    ///                     Value = 0,
    ///                 },
    ///             },
    ///             MaxDurations = new[]
    ///             {
    ///                 new Nobl9.Inputs.DirectLightstepHistoricalDataRetrievalMaxDurationArgs
    ///                 {
    ///                     Unit = "Day",
    ///                     Value = 30,
    ///                 },
    ///             },
    ///         },
    ///         LightstepOrganization = "acme",
    ///         LightstepProject = "project1",
    ///         Project = "terraform",
    ///         SourceOfs = new[]
    ///         {
    ///             "Metrics",
    ///             "Services",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ## Nobl9 Official Documentation
    /// 
    /// https://docs.nobl9.com/
    /// </summary>
    [Nobl9ResourceType("nobl9:index/directLightstep:DirectLightstep")]
    public partial class DirectLightstep : global::Pulumi.CustomResource
    {
        /// <summary>
        /// [required] | Lightstep App Token.
        /// </summary>
        [Output("appToken")]
        public Output<string> AppToken { get; private set; } = null!;

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
        /// [Replay configuration documentation](https://docs.nobl9.com/replay)
        /// </summary>
        [Output("historicalDataRetrieval")]
        public Output<Outputs.DirectLightstepHistoricalDataRetrieval?> HistoricalDataRetrieval { get; private set; } = null!;

        /// <summary>
        /// Organization name registered in Lightstep.
        /// </summary>
        [Output("lightstepOrganization")]
        public Output<string> LightstepOrganization { get; private set; } = null!;

        /// <summary>
        /// Name of the Lightstep project.
        /// </summary>
        [Output("lightstepProject")]
        public Output<string> LightstepProject { get; private set; } = null!;

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
        public Output<Outputs.DirectLightstepQueryDelay?> QueryDelay { get; private set; } = null!;

        /// <summary>
        /// Source of Metrics and/or Services.
        /// </summary>
        [Output("sourceOfs")]
        public Output<ImmutableArray<string>> SourceOfs { get; private set; } = null!;

        /// <summary>
        /// The status of the created direct.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a DirectLightstep resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DirectLightstep(string name, DirectLightstepArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/directLightstep:DirectLightstep", name, args ?? new DirectLightstepArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DirectLightstep(string name, Input<string> id, DirectLightstepState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/directLightstep:DirectLightstep", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DirectLightstep resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DirectLightstep Get(string name, Input<string> id, DirectLightstepState? state = null, CustomResourceOptions? options = null)
        {
            return new DirectLightstep(name, id, state, options);
        }
    }

    public sealed class DirectLightstepArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [required] | Lightstep App Token.
        /// </summary>
        [Input("appToken")]
        public Input<string>? AppToken { get; set; }

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
        /// [Replay configuration documentation](https://docs.nobl9.com/replay)
        /// </summary>
        [Input("historicalDataRetrieval")]
        public Input<Inputs.DirectLightstepHistoricalDataRetrievalArgs>? HistoricalDataRetrieval { get; set; }

        /// <summary>
        /// Organization name registered in Lightstep.
        /// </summary>
        [Input("lightstepOrganization", required: true)]
        public Input<string> LightstepOrganization { get; set; } = null!;

        /// <summary>
        /// Name of the Lightstep project.
        /// </summary>
        [Input("lightstepProject", required: true)]
        public Input<string> LightstepProject { get; set; } = null!;

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
        public Input<Inputs.DirectLightstepQueryDelayArgs>? QueryDelay { get; set; }

        [Input("sourceOfs", required: true)]
        private InputList<string>? _sourceOfs;

        /// <summary>
        /// Source of Metrics and/or Services.
        /// </summary>
        public InputList<string> SourceOfs
        {
            get => _sourceOfs ?? (_sourceOfs = new InputList<string>());
            set => _sourceOfs = value;
        }

        public DirectLightstepArgs()
        {
        }
        public static new DirectLightstepArgs Empty => new DirectLightstepArgs();
    }

    public sealed class DirectLightstepState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [required] | Lightstep App Token.
        /// </summary>
        [Input("appToken")]
        public Input<string>? AppToken { get; set; }

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
        /// [Replay configuration documentation](https://docs.nobl9.com/replay)
        /// </summary>
        [Input("historicalDataRetrieval")]
        public Input<Inputs.DirectLightstepHistoricalDataRetrievalGetArgs>? HistoricalDataRetrieval { get; set; }

        /// <summary>
        /// Organization name registered in Lightstep.
        /// </summary>
        [Input("lightstepOrganization")]
        public Input<string>? LightstepOrganization { get; set; }

        /// <summary>
        /// Name of the Lightstep project.
        /// </summary>
        [Input("lightstepProject")]
        public Input<string>? LightstepProject { get; set; }

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
        public Input<Inputs.DirectLightstepQueryDelayGetArgs>? QueryDelay { get; set; }

        [Input("sourceOfs")]
        private InputList<string>? _sourceOfs;

        /// <summary>
        /// Source of Metrics and/or Services.
        /// </summary>
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

        public DirectLightstepState()
        {
        }
        public static new DirectLightstepState Empty => new DirectLightstepState();
    }
}
