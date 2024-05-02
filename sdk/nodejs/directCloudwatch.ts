// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Amazon CloudWatch is a monitoring and observability service and a repository that aggregates data from more than 70 AWS data sources. CloudWatch also allows users to publish custom metrics from their services. Creating SLOs using this data is a powerful tool to monitor large portfolios of products. Nobl9 connects to Amazon CloudWatch for SLI measurement collection and comparison with SLO targets.
 *
 * For more information, refer to [Amazon CloudWatch Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cloudwatch-direct)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nobl9 from "@piclemx/pulumi-nobl9";
 *
 * const test_cloudwatch = new nobl9.DirectCloudwatch("test-cloudwatch", {
 *     description: "desc",
 *     historicalDataRetrieval: {
 *         defaultDurations: [{
 *             unit: "Day",
 *             value: 0,
 *         }],
 *         maxDurations: [{
 *             unit: "Day",
 *             value: 15,
 *         }],
 *     },
 *     logCollectionEnabled: true,
 *     project: "terraform",
 *     roleArn: "secret",
 * });
 * ```
 * ## Nobl9 Official Documentation
 *
 * https://docs.nobl9.com/
 */
export class DirectCloudwatch extends pulumi.CustomResource {
    /**
     * Get an existing DirectCloudwatch resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DirectCloudwatchState, opts?: pulumi.CustomResourceOptions): DirectCloudwatch {
        return new DirectCloudwatch(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nobl9:index/directCloudwatch:DirectCloudwatch';

    /**
     * Returns true if the given object is an instance of DirectCloudwatch.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DirectCloudwatch {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DirectCloudwatch.__pulumiType;
    }

    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * User-friendly display name of the resource.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * [Replay configuration documentation](https://docs.nobl9.com/replay)
     */
    public readonly historicalDataRetrieval!: pulumi.Output<outputs.DirectCloudwatchHistoricalDataRetrieval>;
    /**
     * [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
     */
    public readonly logCollectionEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
     */
    public readonly queryDelay!: pulumi.Output<outputs.DirectCloudwatchQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    public readonly releaseChannel!: pulumi.Output<string>;
    /**
     * [required] | ARN of the AWS IAM Role to assume.
     */
    public readonly roleArn!: pulumi.Output<string>;
    /**
     * This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
     *
     * @deprecated 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
     */
    public readonly sourceOfs!: pulumi.Output<string[] | undefined>;
    /**
     * The status of the created direct.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a DirectCloudwatch resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DirectCloudwatchArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DirectCloudwatchArgs | DirectCloudwatchState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DirectCloudwatchState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["historicalDataRetrieval"] = state ? state.historicalDataRetrieval : undefined;
            resourceInputs["logCollectionEnabled"] = state ? state.logCollectionEnabled : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["queryDelay"] = state ? state.queryDelay : undefined;
            resourceInputs["releaseChannel"] = state ? state.releaseChannel : undefined;
            resourceInputs["roleArn"] = state ? state.roleArn : undefined;
            resourceInputs["sourceOfs"] = state ? state.sourceOfs : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as DirectCloudwatchArgs | undefined;
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["historicalDataRetrieval"] = args ? args.historicalDataRetrieval : undefined;
            resourceInputs["logCollectionEnabled"] = args ? args.logCollectionEnabled : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["queryDelay"] = args ? args.queryDelay : undefined;
            resourceInputs["releaseChannel"] = args ? args.releaseChannel : undefined;
            resourceInputs["roleArn"] = args?.roleArn ? pulumi.secret(args.roleArn) : undefined;
            resourceInputs["sourceOfs"] = args ? args.sourceOfs : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["roleArn"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(DirectCloudwatch.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DirectCloudwatch resources.
 */
export interface DirectCloudwatchState {
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
    /**
     * [Replay configuration documentation](https://docs.nobl9.com/replay)
     */
    historicalDataRetrieval?: pulumi.Input<inputs.DirectCloudwatchHistoricalDataRetrieval>;
    /**
     * [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
     */
    logCollectionEnabled?: pulumi.Input<boolean>;
    /**
     * Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    project?: pulumi.Input<string>;
    /**
     * [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
     */
    queryDelay?: pulumi.Input<inputs.DirectCloudwatchQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * [required] | ARN of the AWS IAM Role to assume.
     */
    roleArn?: pulumi.Input<string>;
    /**
     * This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
     *
     * @deprecated 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
     */
    sourceOfs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The status of the created direct.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DirectCloudwatch resource.
 */
export interface DirectCloudwatchArgs {
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
    /**
     * [Replay configuration documentation](https://docs.nobl9.com/replay)
     */
    historicalDataRetrieval?: pulumi.Input<inputs.DirectCloudwatchHistoricalDataRetrieval>;
    /**
     * [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
     */
    logCollectionEnabled?: pulumi.Input<boolean>;
    /**
     * Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    name?: pulumi.Input<string>;
    /**
     * Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
     */
    project: pulumi.Input<string>;
    /**
     * [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
     */
    queryDelay?: pulumi.Input<inputs.DirectCloudwatchQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * [required] | ARN of the AWS IAM Role to assume.
     */
    roleArn?: pulumi.Input<string>;
    /**
     * This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
     *
     * @deprecated 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
     */
    sourceOfs?: pulumi.Input<pulumi.Input<string>[]>;
}
