// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * An SLO is a target value or range of values for a service that is measured by a service level indicator (SLI). SLOs allows you to define the reliability of your products and services in terms of customer expectations. You can create SLOs for user journeys, internal services, or even infrastructure.
 *
 * For more information, refer to [SLO configuration documentation](https://docs.nobl9.com/yaml-guide#slo)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nobl9 from "@piclemx/pulumi-nobl9";
 *
 * const thisProject = new nobl9.Project("thisProject", {
 *     displayName: "Test N9 Terraform",
 *     description: "An example N9 Terraform project",
 * });
 * const thisService = new nobl9.Service("thisService", {
 *     project: thisProject.name,
 *     displayName: thisProject.displayName.apply(displayName => `${displayName} Front Page`),
 *     description: "Front page service",
 * });
 * const thisSlo = new nobl9.Slo("thisSlo", {
 *     service: thisService.name,
 *     budgetingMethod: "Occurrences",
 *     project: thisProject.name,
 *     labels: [
 *         {
 *             key: "env",
 *             values: [
 *                 "dev",
 *                 "prod",
 *             ],
 *         },
 *         {
 *             key: "team",
 *             values: ["red"],
 *         },
 *     ],
 *     attachments: [
 *         {
 *             url: "https://www.nobl9.com/",
 *             displayName: "Nobl9 Reliability Center",
 *         },
 *         {
 *             url: "https://duckduckgo.com/",
 *             displayName: "Nice search engine",
 *         },
 *     ],
 *     alertPolicies: ["foo-front-page-latency"],
 *     timeWindow: {
 *         unit: "Day",
 *         count: 30,
 *         isRolling: true,
 *     },
 *     objectives: [{
 *         name: "tf-objective-1",
 *         target: 0.99,
 *         displayName: "OK",
 *         value: 2000,
 *         op: "gte",
 *         rawMetrics: [{
 *             queries: [{
 *                 prometheuses: [{
 *                     promql: "          latency_west_c7{code=\"ALL\",instance=\"localhost:3000\",job=\"prometheus\",service=\"glob_account\"}\n",
 *                 }],
 *             }],
 *         }],
 *     }],
 *     indicator: {
 *         name: "test-terraform-prom-agent",
 *     },
 * });
 * const thisIndex_sloSlo = new nobl9.Slo("thisIndex/sloSlo", {
 *     service: thisService.name,
 *     budgetingMethod: "Occurrences",
 *     project: thisProject.name,
 *     timeWindow: {
 *         unit: "Day",
 *         count: 30,
 *         isRolling: true,
 *     },
 *     objectives: [{
 *         name: "tf-objective-1",
 *         target: 0.99,
 *         displayName: "OK",
 *         value: 1,
 *         countMetrics: [{
 *             incremental: true,
 *             goods: [{
 *                 prometheuses: [{
 *                     promql: "1.0",
 *                 }],
 *             }],
 *             totals: [{
 *                 prometheuses: [{
 *                     promql: "1.0",
 *                 }],
 *             }],
 *         }],
 *     }],
 *     indicator: {
 *         name: "test-terraform-prom-agent",
 *     },
 *     anomalyConfig: {
 *         noData: {
 *             alertMethods: [
 *                 {
 *                     name: "foo-method-method",
 *                     project: "default",
 *                 },
 *                 {
 *                     name: "bar-alert-method",
 *                     project: "default",
 *                 },
 *             ],
 *         },
 *     },
 * });
 * ```
 * ## Nobl9 Official Documentation
 *
 * https://docs.nobl9.com/SLOs_as_code/?_highlight=slo
 */
export class Slo extends pulumi.CustomResource {
    /**
     * Get an existing Slo resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SloState, opts?: pulumi.CustomResourceOptions): Slo {
        return new Slo(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nobl9:index/slo:Slo';

    /**
     * Returns true if the given object is an instance of Slo.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Slo {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Slo.__pulumiType;
    }

    /**
     * Alert Policies attached to SLO
     */
    public readonly alertPolicies!: pulumi.Output<string[] | undefined>;
    /**
     * Configuration for Anomalies. Currently supported Anomaly Type is NoData
     */
    public readonly anomalyConfig!: pulumi.Output<outputs.SloAnomalyConfig | undefined>;
    public readonly attachment!: pulumi.Output<outputs.SloAttachment[] | undefined>;
    /**
     * @deprecated "attachments" argument is deprecated use "attachment" instead
     */
    public readonly attachments!: pulumi.Output<outputs.SloAttachment[] | undefined>;
    /**
     * Method which will be use to calculate budget
     */
    public readonly budgetingMethod!: pulumi.Output<string>;
    /**
     * [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
     */
    public readonly composite!: pulumi.Output<outputs.SloComposite | undefined>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Name displayed for the attachment. Max. length: 63 characters.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     */
    public readonly indicator!: pulumi.Output<outputs.SloIndicator>;
    /**
     * [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
     */
    public readonly labels!: pulumi.Output<outputs.SloLabel[] | undefined>;
    /**
     * The name of the previously defined alert method.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
     */
    public readonly objectives!: pulumi.Output<outputs.SloObjective[]>;
    /**
     * Project name the Alert Method is in,  must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * Name of the service
     */
    public readonly service!: pulumi.Output<string>;
    /**
     */
    public readonly timeWindow!: pulumi.Output<outputs.SloTimeWindow>;

    /**
     * Create a Slo resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SloArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SloArgs | SloState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SloState | undefined;
            resourceInputs["alertPolicies"] = state ? state.alertPolicies : undefined;
            resourceInputs["anomalyConfig"] = state ? state.anomalyConfig : undefined;
            resourceInputs["attachment"] = state ? state.attachment : undefined;
            resourceInputs["attachments"] = state ? state.attachments : undefined;
            resourceInputs["budgetingMethod"] = state ? state.budgetingMethod : undefined;
            resourceInputs["composite"] = state ? state.composite : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["indicator"] = state ? state.indicator : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["objectives"] = state ? state.objectives : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["service"] = state ? state.service : undefined;
            resourceInputs["timeWindow"] = state ? state.timeWindow : undefined;
        } else {
            const args = argsOrState as SloArgs | undefined;
            if ((!args || args.budgetingMethod === undefined) && !opts.urn) {
                throw new Error("Missing required property 'budgetingMethod'");
            }
            if ((!args || args.indicator === undefined) && !opts.urn) {
                throw new Error("Missing required property 'indicator'");
            }
            if ((!args || args.objectives === undefined) && !opts.urn) {
                throw new Error("Missing required property 'objectives'");
            }
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.service === undefined) && !opts.urn) {
                throw new Error("Missing required property 'service'");
            }
            if ((!args || args.timeWindow === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timeWindow'");
            }
            resourceInputs["alertPolicies"] = args ? args.alertPolicies : undefined;
            resourceInputs["anomalyConfig"] = args ? args.anomalyConfig : undefined;
            resourceInputs["attachment"] = args ? args.attachment : undefined;
            resourceInputs["attachments"] = args ? args.attachments : undefined;
            resourceInputs["budgetingMethod"] = args ? args.budgetingMethod : undefined;
            resourceInputs["composite"] = args ? args.composite : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["indicator"] = args ? args.indicator : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["objectives"] = args ? args.objectives : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["service"] = args ? args.service : undefined;
            resourceInputs["timeWindow"] = args ? args.timeWindow : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Slo.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Slo resources.
 */
export interface SloState {
    /**
     * Alert Policies attached to SLO
     */
    alertPolicies?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Configuration for Anomalies. Currently supported Anomaly Type is NoData
     */
    anomalyConfig?: pulumi.Input<inputs.SloAnomalyConfig>;
    attachment?: pulumi.Input<pulumi.Input<inputs.SloAttachment>[]>;
    /**
     * @deprecated "attachments" argument is deprecated use "attachment" instead
     */
    attachments?: pulumi.Input<pulumi.Input<inputs.SloAttachment>[]>;
    /**
     * Method which will be use to calculate budget
     */
    budgetingMethod?: pulumi.Input<string>;
    /**
     * [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
     */
    composite?: pulumi.Input<inputs.SloComposite>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * Name displayed for the attachment. Max. length: 63 characters.
     */
    displayName?: pulumi.Input<string>;
    /**
     */
    indicator?: pulumi.Input<inputs.SloIndicator>;
    /**
     * [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
     */
    labels?: pulumi.Input<pulumi.Input<inputs.SloLabel>[]>;
    /**
     * The name of the previously defined alert method.
     */
    name?: pulumi.Input<string>;
    /**
     * [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
     */
    objectives?: pulumi.Input<pulumi.Input<inputs.SloObjective>[]>;
    /**
     * Project name the Alert Method is in,  must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
     */
    project?: pulumi.Input<string>;
    /**
     * Name of the service
     */
    service?: pulumi.Input<string>;
    /**
     */
    timeWindow?: pulumi.Input<inputs.SloTimeWindow>;
}

/**
 * The set of arguments for constructing a Slo resource.
 */
export interface SloArgs {
    /**
     * Alert Policies attached to SLO
     */
    alertPolicies?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Configuration for Anomalies. Currently supported Anomaly Type is NoData
     */
    anomalyConfig?: pulumi.Input<inputs.SloAnomalyConfig>;
    attachment?: pulumi.Input<pulumi.Input<inputs.SloAttachment>[]>;
    /**
     * @deprecated "attachments" argument is deprecated use "attachment" instead
     */
    attachments?: pulumi.Input<pulumi.Input<inputs.SloAttachment>[]>;
    /**
     * Method which will be use to calculate budget
     */
    budgetingMethod: pulumi.Input<string>;
    /**
     * [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
     */
    composite?: pulumi.Input<inputs.SloComposite>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * Name displayed for the attachment. Max. length: 63 characters.
     */
    displayName?: pulumi.Input<string>;
    /**
     */
    indicator: pulumi.Input<inputs.SloIndicator>;
    /**
     * [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
     */
    labels?: pulumi.Input<pulumi.Input<inputs.SloLabel>[]>;
    /**
     * The name of the previously defined alert method.
     */
    name?: pulumi.Input<string>;
    /**
     * [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
     */
    objectives: pulumi.Input<pulumi.Input<inputs.SloObjective>[]>;
    /**
     * Project name the Alert Method is in,  must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
     */
    project: pulumi.Input<string>;
    /**
     * Name of the service
     */
    service: pulumi.Input<string>;
    /**
     */
    timeWindow: pulumi.Input<inputs.SloTimeWindow>;
}
