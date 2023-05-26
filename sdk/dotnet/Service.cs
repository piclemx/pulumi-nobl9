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
    /// A **service** in Nobl9 is a high-level grouping of Service Level Objectives (SLOs). A service can represent a logical service endpoint like an API, a database, an application, or anything else you care about setting an SLO for. Every SLO in Nobl9 is tied to a service, and the service can have one or more SLOs.
    /// 
    /// For more details, refer to the [Service configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#service).
    /// 
    /// ## Example Usage
    /// 
    /// Here's an example of Service resource configuration:
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Nobl9 = Pulumi.Nobl9;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var thisProject = new Nobl9.Project("thisProject", new()
    ///     {
    ///         DisplayName = "My Project",
    ///         Description = "An example N9 Terraform project",
    ///     });
    /// 
    ///     var thisService = new Nobl9.Service("thisService", new()
    ///     {
    ///         Project = thisProject.Name,
    ///         DisplayName = thisProject.DisplayName.Apply(displayName =&gt; $"{displayName} Front Page"),
    ///         Description = "Front page service",
    ///         Labels = new[]
    ///         {
    ///             new Nobl9.Inputs.ServiceLabelArgs
    ///             {
    ///                 Key = "env",
    ///                 Values = new[]
    ///                 {
    ///                     "dev",
    ///                     "prod",
    ///                 },
    ///             },
    ///             new Nobl9.Inputs.ServiceLabelArgs
    ///             {
    ///                 Key = "team",
    ///                 Values = new[]
    ///                 {
    ///                     "red",
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ## Useful Links
    /// 
    /// [Services in Nobl9 | Nobl9 Documentation](https://docs.nobl9.com/#services)
    /// 
    /// [Service YAML Configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide/#service)
    /// </summary>
    [Nobl9ResourceType("nobl9:index/service:Service")]
    public partial class Service : global::Pulumi.CustomResource
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
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableArray<Outputs.ServiceLabel>> Labels { get; private set; } = null!;

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
        /// Status of created service.
        /// </summary>
        [Output("status")]
        public Output<ImmutableDictionary<string, double>> Status { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/service:Service", name, args ?? new ServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/service:Service", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : global::Pulumi.ResourceArgs
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

        [Input("labels")]
        private InputList<Inputs.ServiceLabelArgs>? _labels;

        /// <summary>
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        public InputList<Inputs.ServiceLabelArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.ServiceLabelArgs>());
            set => _labels = value;
        }

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

        public ServiceArgs()
        {
        }
        public static new ServiceArgs Empty => new ServiceArgs();
    }

    public sealed class ServiceState : global::Pulumi.ResourceArgs
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

        [Input("labels")]
        private InputList<Inputs.ServiceLabelGetArgs>? _labels;

        /// <summary>
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        public InputList<Inputs.ServiceLabelGetArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.ServiceLabelGetArgs>());
            set => _labels = value;
        }

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

        [Input("status")]
        private InputMap<double>? _status;

        /// <summary>
        /// Status of created service.
        /// </summary>
        public InputMap<double> Status
        {
            get => _status ?? (_status = new InputMap<double>());
            set => _status = value;
        }

        public ServiceState()
        {
        }
        public static new ServiceState Empty => new ServiceState();
    }
}