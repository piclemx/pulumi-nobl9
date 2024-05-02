// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Sumo Logic is an observability platform that provides visibility into AWS, Azure, and GCP cloud applications and infrastructure. Nobl9 connects to Sumo Logic for SLI measurement collection and comparison with SLO targets.
 *
 * For more information, refer to [Sumo Logic Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/sumo-logic#sumo-logic-direct).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nobl9 from "@piclemx/pulumi-nobl9";
 *
 * const test_sumologic = new nobl9.DirectSumologic("test-sumologic", {
 *     accessId: "secret",
 *     accessKey: "secret",
 *     description: "desc",
 *     logCollectionEnabled: true,
 *     project: "terraform",
 *     url: "http://web.net",
 * });
 * ```
 * ## Nobl9 Official Documentation
 *
 * https://docs.nobl9.com/
 */
export class DirectSumologic extends pulumi.CustomResource {
    /**
     * Get an existing DirectSumologic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DirectSumologicState, opts?: pulumi.CustomResourceOptions): DirectSumologic {
        return new DirectSumologic(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nobl9:index/directSumologic:DirectSumologic';

    /**
     * Returns true if the given object is an instance of DirectSumologic.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DirectSumologic {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DirectSumologic.__pulumiType;
    }

    /**
     * [required] | Sumo Logic API Access ID.
     */
    public readonly accessId!: pulumi.Output<string>;
    /**
     * [required] | Sumo Logic API Access Key.
     */
    public readonly accessKey!: pulumi.Output<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * User-friendly display name of the resource.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
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
    public readonly queryDelay!: pulumi.Output<outputs.DirectSumologicQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    public readonly releaseChannel!: pulumi.Output<string>;
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
     * Sumo Logic API URL.
     */
    public readonly url!: pulumi.Output<string>;

    /**
     * Create a DirectSumologic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DirectSumologicArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DirectSumologicArgs | DirectSumologicState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DirectSumologicState | undefined;
            resourceInputs["accessId"] = state ? state.accessId : undefined;
            resourceInputs["accessKey"] = state ? state.accessKey : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["logCollectionEnabled"] = state ? state.logCollectionEnabled : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["queryDelay"] = state ? state.queryDelay : undefined;
            resourceInputs["releaseChannel"] = state ? state.releaseChannel : undefined;
            resourceInputs["sourceOfs"] = state ? state.sourceOfs : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
        } else {
            const args = argsOrState as DirectSumologicArgs | undefined;
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.url === undefined) && !opts.urn) {
                throw new Error("Missing required property 'url'");
            }
            resourceInputs["accessId"] = args?.accessId ? pulumi.secret(args.accessId) : undefined;
            resourceInputs["accessKey"] = args?.accessKey ? pulumi.secret(args.accessKey) : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["logCollectionEnabled"] = args ? args.logCollectionEnabled : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["queryDelay"] = args ? args.queryDelay : undefined;
            resourceInputs["releaseChannel"] = args ? args.releaseChannel : undefined;
            resourceInputs["sourceOfs"] = args ? args.sourceOfs : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["accessId", "accessKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(DirectSumologic.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DirectSumologic resources.
 */
export interface DirectSumologicState {
    /**
     * [required] | Sumo Logic API Access ID.
     */
    accessId?: pulumi.Input<string>;
    /**
     * [required] | Sumo Logic API Access Key.
     */
    accessKey?: pulumi.Input<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
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
    queryDelay?: pulumi.Input<inputs.DirectSumologicQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
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
    /**
     * Sumo Logic API URL.
     */
    url?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DirectSumologic resource.
 */
export interface DirectSumologicArgs {
    /**
     * [required] | Sumo Logic API Access ID.
     */
    accessId?: pulumi.Input<string>;
    /**
     * [required] | Sumo Logic API Access Key.
     */
    accessKey?: pulumi.Input<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
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
    queryDelay?: pulumi.Input<inputs.DirectSumologicQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
     *
     * @deprecated 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
     */
    sourceOfs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Sumo Logic API URL.
     */
    url: pulumi.Input<string>;
}
