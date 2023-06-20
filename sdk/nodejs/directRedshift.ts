// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Amazon Redshift is a managed scalable database warehouse where Nobl9 users can store their metrics information. Nobl9 connects with Amazon Redshift to collect SLI measurements and compare them to SLO targets.
 *
 * For more information, refer to [Amazon Redshift Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/Amazon_Redshift/?_highlight=redshift#amazon-redshift-direct).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as nobl9 from "@pulumi/nobl9";
 *
 * const test_redshift = new nobl9.DirectRedshift("test-redshift", {
 *     accessKeyId: "secret",
 *     description: "desc",
 *     project: "terraform",
 *     secretAccessKey: "secret",
 *     secretArn: "aws:arn",
 *     sourceOfs: [
 *         "Metrics",
 *         "Services",
 *     ],
 * });
 * ```
 * ## Nobl9 Official Documentation
 *
 * https://docs.nobl9.com/
 */
export class DirectRedshift extends pulumi.CustomResource {
    /**
     * Get an existing DirectRedshift resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DirectRedshiftState, opts?: pulumi.CustomResourceOptions): DirectRedshift {
        return new DirectRedshift(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'nobl9:index/directRedshift:DirectRedshift';

    /**
     * Returns true if the given object is an instance of DirectRedshift.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DirectRedshift {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DirectRedshift.__pulumiType;
    }

    /**
     * [required] | AWS Access Key ID.
     */
    public readonly accessKeyId!: pulumi.Output<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * User-friendly display name of the resource.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
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
    public readonly queryDelay!: pulumi.Output<outputs.DirectRedshiftQueryDelay | undefined>;
    /**
     * [required] | AWS Secret Access Key.
     */
    public readonly secretAccessKey!: pulumi.Output<string>;
    /**
     * AWS Secret ARN.
     */
    public readonly secretArn!: pulumi.Output<string>;
    /**
     * Source of Metrics and/or Services.
     */
    public readonly sourceOfs!: pulumi.Output<string[]>;
    /**
     * The status of the created direct.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a DirectRedshift resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DirectRedshiftArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DirectRedshiftArgs | DirectRedshiftState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DirectRedshiftState | undefined;
            resourceInputs["accessKeyId"] = state ? state.accessKeyId : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["displayName"] = state ? state.displayName : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["queryDelay"] = state ? state.queryDelay : undefined;
            resourceInputs["secretAccessKey"] = state ? state.secretAccessKey : undefined;
            resourceInputs["secretArn"] = state ? state.secretArn : undefined;
            resourceInputs["sourceOfs"] = state ? state.sourceOfs : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as DirectRedshiftArgs | undefined;
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            if ((!args || args.sourceOfs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sourceOfs'");
            }
            resourceInputs["accessKeyId"] = args ? args.accessKeyId : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["queryDelay"] = args ? args.queryDelay : undefined;
            resourceInputs["secretAccessKey"] = args ? args.secretAccessKey : undefined;
            resourceInputs["secretArn"] = args ? args.secretArn : undefined;
            resourceInputs["sourceOfs"] = args ? args.sourceOfs : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DirectRedshift.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DirectRedshift resources.
 */
export interface DirectRedshiftState {
    /**
     * [required] | AWS Access Key ID.
     */
    accessKeyId?: pulumi.Input<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
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
    queryDelay?: pulumi.Input<inputs.DirectRedshiftQueryDelay>;
    /**
     * [required] | AWS Secret Access Key.
     */
    secretAccessKey?: pulumi.Input<string>;
    /**
     * AWS Secret ARN.
     */
    secretArn?: pulumi.Input<string>;
    /**
     * Source of Metrics and/or Services.
     */
    sourceOfs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The status of the created direct.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DirectRedshift resource.
 */
export interface DirectRedshiftArgs {
    /**
     * [required] | AWS Access Key ID.
     */
    accessKeyId?: pulumi.Input<string>;
    /**
     * Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
     */
    description?: pulumi.Input<string>;
    /**
     * User-friendly display name of the resource.
     */
    displayName?: pulumi.Input<string>;
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
    queryDelay?: pulumi.Input<inputs.DirectRedshiftQueryDelay>;
    /**
     * [required] | AWS Secret Access Key.
     */
    secretAccessKey?: pulumi.Input<string>;
    /**
     * AWS Secret ARN.
     */
    secretArn?: pulumi.Input<string>;
    /**
     * Source of Metrics and/or Services.
     */
    sourceOfs: pulumi.Input<pulumi.Input<string>[]>;
}
