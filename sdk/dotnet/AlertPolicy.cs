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
    /// An **Alert Policy** expresses a set of conditions you want to track or monitor. The conditions for an Alert Policy define what is monitored and when to activate an alert: when the performance of your service is declining, Nobl9 will send a notification to a predefined channel.
    /// 
    /// A Nobl9 AlertPolicy accepts up to 7 conditions. All the specified conditions must be satisfied to trigger an alert.
    /// 
    /// For more details, refer to the [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy).
    /// 
    /// ## Example Usage
    /// 
    /// Here's an example of Alert Policy resource configuration:
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
    ///     });
    /// 
    ///     var thisAlertPolicy = new Nobl9.AlertPolicy("thisAlertPolicy", new()
    ///     {
    ///         Project = thisProject.Name,
    ///         DisplayName = thisProject.DisplayName.Apply(displayName =&gt; $"{displayName} Front Page Latency"),
    ///         Severity = "High",
    ///         Description = "Alert when page latency is &gt; 2000 and error budget would be exhausted",
    ///         Conditions = new[]
    ///         {
    ///             new Nobl9.Inputs.AlertPolicyConditionArgs
    ///             {
    ///                 Measurement = "timeToBurnBudget",
    ///                 ValueString = "72h",
    ///                 LastsFor = "30m",
    ///             },
    ///         },
    ///         AlertMethods = new[]
    ///         {
    ///             new Nobl9.Inputs.AlertPolicyAlertMethodArgs
    ///             {
    ///                 Name = "my-alert-method",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ## Useful Links
    /// 
    /// [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy)
    /// </summary>
    [Nobl9ResourceType("nobl9:index/alertPolicy:AlertPolicy")]
    public partial class AlertPolicy : global::Pulumi.CustomResource
    {
        [Output("alertMethods")]
        public Output<ImmutableArray<Outputs.AlertPolicyAlertMethod>> AlertMethods { get; private set; } = null!;

        /// <summary>
        /// Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        /// </summary>
        [Output("conditions")]
        public Output<ImmutableArray<Outputs.AlertPolicyCondition>> Conditions { get; private set; } = null!;

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
        /// Alert severity. One of `Low` | `Medium` | `High`.
        /// </summary>
        [Output("severity")]
        public Output<string> Severity { get; private set; } = null!;


        /// <summary>
        /// Create a AlertPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertPolicy(string name, AlertPolicyArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/alertPolicy:AlertPolicy", name, args ?? new AlertPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertPolicy(string name, Input<string> id, AlertPolicyState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/alertPolicy:AlertPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AlertPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertPolicy Get(string name, Input<string> id, AlertPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new AlertPolicy(name, id, state, options);
        }
    }

    public sealed class AlertPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("alertMethods")]
        private InputList<Inputs.AlertPolicyAlertMethodArgs>? _alertMethods;
        public InputList<Inputs.AlertPolicyAlertMethodArgs> AlertMethods
        {
            get => _alertMethods ?? (_alertMethods = new InputList<Inputs.AlertPolicyAlertMethodArgs>());
            set => _alertMethods = value;
        }

        [Input("conditions", required: true)]
        private InputList<Inputs.AlertPolicyConditionArgs>? _conditions;

        /// <summary>
        /// Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        /// </summary>
        public InputList<Inputs.AlertPolicyConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.AlertPolicyConditionArgs>());
            set => _conditions = value;
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
        /// Alert severity. One of `Low` | `Medium` | `High`.
        /// </summary>
        [Input("severity", required: true)]
        public Input<string> Severity { get; set; } = null!;

        public AlertPolicyArgs()
        {
        }
        public static new AlertPolicyArgs Empty => new AlertPolicyArgs();
    }

    public sealed class AlertPolicyState : global::Pulumi.ResourceArgs
    {
        [Input("alertMethods")]
        private InputList<Inputs.AlertPolicyAlertMethodGetArgs>? _alertMethods;
        public InputList<Inputs.AlertPolicyAlertMethodGetArgs> AlertMethods
        {
            get => _alertMethods ?? (_alertMethods = new InputList<Inputs.AlertPolicyAlertMethodGetArgs>());
            set => _alertMethods = value;
        }

        [Input("conditions")]
        private InputList<Inputs.AlertPolicyConditionGetArgs>? _conditions;

        /// <summary>
        /// Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        /// </summary>
        public InputList<Inputs.AlertPolicyConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.AlertPolicyConditionGetArgs>());
            set => _conditions = value;
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
        /// Alert severity. One of `Low` | `Medium` | `High`.
        /// </summary>
        [Input("severity")]
        public Input<string>? Severity { get; set; }

        public AlertPolicyState()
        {
        }
        public static new AlertPolicyState Empty => new AlertPolicyState();
    }
}
