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
    /// InfluxDB is an open source time series database platform that enables users to collect, process, and analyze data to optimize their infrastructure. Nobl9 connects with InfluxDB to collect SLI measurements and compare them to SLO targets.
    /// 
    /// For more information, refer to [InfluxDB Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/influxdb#influxdb-direct).
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
    ///     var test_influxdb = new Nobl9.DirectInfluxdb("test-influxdb", new()
    ///     {
    ///         ApiToken = "secret",
    ///         Description = "desc",
    ///         OrganizationId = "secret",
    ///         Project = "terraform",
    ///         SourceOfs = new[]
    ///         {
    ///             "Metrics",
    ///             "Services",
    ///         },
    ///         Url = "https://web.net",
    ///     });
    /// 
    /// });
    /// ```
    /// ## Nobl9 Official Documentation
    /// 
    /// https://docs.nobl9.com/
    /// </summary>
    [Nobl9ResourceType("nobl9:index/directInfluxdb:DirectInfluxdb")]
    public partial class DirectInfluxdb : global::Pulumi.CustomResource
    {
        /// <summary>
        /// [required] | InfluxDB API Token.
        /// </summary>
        [Output("apiToken")]
        public Output<string> ApiToken { get; private set; } = null!;

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
        /// [required] | InfluxDB Organization ID.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Output("queryDelay")]
        public Output<Outputs.DirectInfluxdbQueryDelay?> QueryDelay { get; private set; } = null!;

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
        /// API URL endpoint to the InfluxDB's instance.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a DirectInfluxdb resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DirectInfluxdb(string name, DirectInfluxdbArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/directInfluxdb:DirectInfluxdb", name, args ?? new DirectInfluxdbArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DirectInfluxdb(string name, Input<string> id, DirectInfluxdbState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/directInfluxdb:DirectInfluxdb", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DirectInfluxdb resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DirectInfluxdb Get(string name, Input<string> id, DirectInfluxdbState? state = null, CustomResourceOptions? options = null)
        {
            return new DirectInfluxdb(name, id, state, options);
        }
    }

    public sealed class DirectInfluxdbArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [required] | InfluxDB API Token.
        /// </summary>
        [Input("apiToken")]
        public Input<string>? ApiToken { get; set; }

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
        /// [required] | InfluxDB Organization ID.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        /// <summary>
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Input("queryDelay")]
        public Input<Inputs.DirectInfluxdbQueryDelayArgs>? QueryDelay { get; set; }

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

        /// <summary>
        /// API URL endpoint to the InfluxDB's instance.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public DirectInfluxdbArgs()
        {
        }
        public static new DirectInfluxdbArgs Empty => new DirectInfluxdbArgs();
    }

    public sealed class DirectInfluxdbState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// [required] | InfluxDB API Token.
        /// </summary>
        [Input("apiToken")]
        public Input<string>? ApiToken { get; set; }

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
        /// [required] | InfluxDB Organization ID.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        /// </summary>
        [Input("queryDelay")]
        public Input<Inputs.DirectInfluxdbQueryDelayGetArgs>? QueryDelay { get; set; }

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

        /// <summary>
        /// API URL endpoint to the InfluxDB's instance.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public DirectInfluxdbState()
        {
        }
        public static new DirectInfluxdbState Empty => new DirectInfluxdbState();
    }
}