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
    /// An SLO is a target value or range of values for a service that is measured by a service level indicator (SLI). SLOs allows you to define the reliability of your products and services in terms of customer expectations. You can create SLOs for user journeys, internal services, or even infrastructure.
    /// 
    /// For more information, refer to [SLO configuration documentation](https://docs.nobl9.com/yaml-guide#slo)
    /// 
    /// ## Nobl9 Official Documentation
    /// 
    /// https://docs.nobl9.com/SLOs_as_code/?_highlight=slo
    /// </summary>
    [Nobl9ResourceType("nobl9:index/slo:Slo")]
    public partial class Slo : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        [Output("alertPolicies")]
        public Output<ImmutableArray<string>> AlertPolicies { get; private set; } = null!;

        [Output("attachments")]
        public Output<ImmutableArray<Outputs.SloAttachment>> Attachments { get; private set; } = null!;

        /// <summary>
        /// Method which will be use to calculate budget
        /// </summary>
        [Output("budgetingMethod")]
        public Output<string> BudgetingMethod { get; private set; } = null!;

        /// <summary>
        /// [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        /// </summary>
        [Output("composite")]
        public Output<Outputs.SloComposite?> Composite { get; private set; } = null!;

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

        [Output("indicator")]
        public Output<Outputs.SloIndicator> Indicator { get; private set; } = null!;

        /// <summary>
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableArray<Outputs.SloLabel>> Labels { get; private set; } = null!;

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        /// </summary>
        [Output("objectives")]
        public Output<ImmutableArray<Outputs.SloObjective>> Objectives { get; private set; } = null!;

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Name of the service
        /// </summary>
        [Output("service")]
        public Output<string> Service { get; private set; } = null!;

        [Output("timeWindow")]
        public Output<Outputs.SloTimeWindow> TimeWindow { get; private set; } = null!;


        /// <summary>
        /// Create a Slo resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Slo(string name, SloArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/slo:Slo", name, args ?? new SloArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Slo(string name, Input<string> id, SloState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/slo:Slo", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Slo resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Slo Get(string name, Input<string> id, SloState? state = null, CustomResourceOptions? options = null)
        {
            return new Slo(name, id, state, options);
        }
    }

    public sealed class SloArgs : global::Pulumi.ResourceArgs
    {
        [Input("alertPolicies")]
        private InputList<string>? _alertPolicies;

        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        public InputList<string> AlertPolicies
        {
            get => _alertPolicies ?? (_alertPolicies = new InputList<string>());
            set => _alertPolicies = value;
        }

        [Input("attachments")]
        private InputList<Inputs.SloAttachmentArgs>? _attachments;
        [Obsolete(@"""attachments"" argument is deprecated use ""attachment"" instead")]
        public InputList<Inputs.SloAttachmentArgs> Attachments
        {
            get => _attachments ?? (_attachments = new InputList<Inputs.SloAttachmentArgs>());
            set => _attachments = value;
        }

        /// <summary>
        /// Method which will be use to calculate budget
        /// </summary>
        [Input("budgetingMethod", required: true)]
        public Input<string> BudgetingMethod { get; set; } = null!;

        /// <summary>
        /// [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        /// </summary>
        [Input("composite")]
        public Input<Inputs.SloCompositeArgs>? Composite { get; set; }

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

        [Input("indicator", required: true)]
        public Input<Inputs.SloIndicatorArgs> Indicator { get; set; } = null!;

        [Input("labels")]
        private InputList<Inputs.SloLabelArgs>? _labels;

        /// <summary>
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        public InputList<Inputs.SloLabelArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.SloLabelArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("objectives", required: true)]
        private InputList<Inputs.SloObjectiveArgs>? _objectives;

        /// <summary>
        /// [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        /// </summary>
        public InputList<Inputs.SloObjectiveArgs> Objectives
        {
            get => _objectives ?? (_objectives = new InputList<Inputs.SloObjectiveArgs>());
            set => _objectives = value;
        }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        /// <summary>
        /// Name of the service
        /// </summary>
        [Input("service", required: true)]
        public Input<string> Service { get; set; } = null!;

        [Input("timeWindow", required: true)]
        public Input<Inputs.SloTimeWindowArgs> TimeWindow { get; set; } = null!;

        public SloArgs()
        {
        }
        public static new SloArgs Empty => new SloArgs();
    }

    public sealed class SloState : global::Pulumi.ResourceArgs
    {
        [Input("alertPolicies")]
        private InputList<string>? _alertPolicies;

        /// <summary>
        /// Alert Policies attached to SLO
        /// </summary>
        public InputList<string> AlertPolicies
        {
            get => _alertPolicies ?? (_alertPolicies = new InputList<string>());
            set => _alertPolicies = value;
        }

        [Input("attachments")]
        private InputList<Inputs.SloAttachmentGetArgs>? _attachments;
        [Obsolete(@"""attachments"" argument is deprecated use ""attachment"" instead")]
        public InputList<Inputs.SloAttachmentGetArgs> Attachments
        {
            get => _attachments ?? (_attachments = new InputList<Inputs.SloAttachmentGetArgs>());
            set => _attachments = value;
        }

        /// <summary>
        /// Method which will be use to calculate budget
        /// </summary>
        [Input("budgetingMethod")]
        public Input<string>? BudgetingMethod { get; set; }

        /// <summary>
        /// [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        /// </summary>
        [Input("composite")]
        public Input<Inputs.SloCompositeGetArgs>? Composite { get; set; }

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

        [Input("indicator")]
        public Input<Inputs.SloIndicatorGetArgs>? Indicator { get; set; }

        [Input("labels")]
        private InputList<Inputs.SloLabelGetArgs>? _labels;

        /// <summary>
        /// [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        /// </summary>
        public InputList<Inputs.SloLabelGetArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.SloLabelGetArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("objectives")]
        private InputList<Inputs.SloObjectiveGetArgs>? _objectives;

        /// <summary>
        /// [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        /// </summary>
        public InputList<Inputs.SloObjectiveGetArgs> Objectives
        {
            get => _objectives ?? (_objectives = new InputList<Inputs.SloObjectiveGetArgs>());
            set => _objectives = value;
        }

        /// <summary>
        /// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Name of the service
        /// </summary>
        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("timeWindow")]
        public Input<Inputs.SloTimeWindowGetArgs>? TimeWindow { get; set; }

        public SloState()
        {
        }
        public static new SloState Empty => new SloState();
    }
}
