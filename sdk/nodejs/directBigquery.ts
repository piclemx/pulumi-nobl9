// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Google BigQuery is a serverless data warehouse that enables scalable analysis over petabytes of data. It is a Platform as a Service that supports querying using ANSI SQL. BigQuery integration with Nobl9 enables users to turn their big data into valuable business insights. Nobl9 connects to BigQuery for SLI measurement collection and comparison with SLO targets.
 *
 * For more information, refer to [BigQuery Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/bigquery#bigquery-direct)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nobl9 from "@piclemx/pulumi-nobl9";
 *
 * const test_bigquery = new nobl9.DirectBigquery("test-bigquery", {
 *     description: "desc",
 *     logCollectionEnabled: true,
 *     project: "terraform",
 *     serviceAccountKey: "secret",
 * });
 * ```
 * ## Nobl9 Official Documentation
 *
 * https://docs.nobl9.com/
 */
export class DirectBigquery extends pulumi.CustomResource {
    /**
     * Get an existing DirectBigquery resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DirectBigqueryState, opts?: pulumi.CustomResourceOptions): DirectBigquery {
        return new DirectBigquery(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nobl9:index/directBigquery:DirectBigquery';

    /**
     * Returns true if the given object is an instance of DirectBigquery.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DirectBigquery {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DirectBigquery.__pulumiType;
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
    public readonly queryDelay!: pulumi.Output<outputs.DirectBigqueryQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    public readonly releaseChannel!: pulumi.Output<string>;
    /**
     * [required] | Service Account Key.
     */
    public readonly serviceAccountKey!: pulumi.Output<string>;
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
     * Create a DirectBigquery resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DirectBigqueryArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DirectBigqueryArgs | DirectBigqueryState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DirectBigqueryState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["logCollectionEnabled"] = state ? state.logCollectionEnabled : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["queryDelay"] = state ? state.queryDelay : undefined;
            resourceInputs["releaseChannel"] = state ? state.releaseChannel : undefined;
            resourceInputs["serviceAccountKey"] = state ? state.serviceAccountKey : undefined;
            resourceInputs["sourceOfs"] = state ? state.sourceOfs : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as DirectBigqueryArgs | undefined;
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["logCollectionEnabled"] = args ? args.logCollectionEnabled : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["queryDelay"] = args ? args.queryDelay : undefined;
            resourceInputs["releaseChannel"] = args ? args.releaseChannel : undefined;
            resourceInputs["serviceAccountKey"] = args?.serviceAccountKey ? pulumi.secret(args.serviceAccountKey) : undefined;
            resourceInputs["sourceOfs"] = args ? args.sourceOfs : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["serviceAccountKey"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(DirectBigquery.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DirectBigquery resources.
 */
export interface DirectBigqueryState {
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
    queryDelay?: pulumi.Input<inputs.DirectBigqueryQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * [required] | Service Account Key.
     */
    serviceAccountKey?: pulumi.Input<string>;
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
 * The set of arguments for constructing a DirectBigquery resource.
 */
export interface DirectBigqueryArgs {
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
    queryDelay?: pulumi.Input<inputs.DirectBigqueryQueryDelay>;
    /**
     * Release channel of the created datasource [stable/beta]
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * [required] | Service Account Key.
     */
    serviceAccountKey?: pulumi.Input<string>;
    /**
     * This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
     *
     * @deprecated 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
     */
    sourceOfs?: pulumi.Input<pulumi.Input<string>[]>;
}
