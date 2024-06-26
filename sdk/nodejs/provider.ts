// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The provider type for the nobl9 package. By default, resources use package-wide configuration
 * settings, however an explicit `Provider` instance may be created and passed during resource
 * construction to achieve fine-grained programmatic control over provider settings. See the
 * [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
 */
export class Provider extends pulumi.ProviderResource {
    /** @internal */
    public static readonly __pulumiType = 'nobl9';

    /**
     * Returns true if the given object is an instance of Provider.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Provider {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === "pulumi:providers:" + Provider.__pulumiType;
    }

    /**
     * the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
     * Nobl9.
     */
    public readonly clientId!: pulumi.Output<string>;
    /**
     * the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
     * to Nobl9.
     */
    public readonly clientSecret!: pulumi.Output<string>;
    /**
     * Nobl9 API URL.
     */
    public readonly ingestUrl!: pulumi.Output<string | undefined>;
    /**
     * Authorization service configuration.
     */
    public readonly oktaAuthServer!: pulumi.Output<string | undefined>;
    /**
     * Authorization service URL.
     */
    public readonly oktaOrgUrl!: pulumi.Output<string | undefined>;
    /**
     * Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
     * contains resources managed by the Nobl9 Terraform provider.
     */
    public readonly organization!: pulumi.Output<string | undefined>;
    /**
     * Nobl9 project used when importing resources.
     */
    public readonly project!: pulumi.Output<string | undefined>;

    /**
     * Create a Provider resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProviderArgs, opts?: pulumi.ResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        {
            if ((!args || args.clientId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientId'");
            }
            if ((!args || args.clientSecret === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clientSecret'");
            }
            resourceInputs["clientId"] = args ? args.clientId : undefined;
            resourceInputs["clientSecret"] = args?.clientSecret ? pulumi.secret(args.clientSecret) : undefined;
            resourceInputs["ingestUrl"] = args ? args.ingestUrl : undefined;
            resourceInputs["oktaAuthServer"] = args ? args.oktaAuthServer : undefined;
            resourceInputs["oktaOrgUrl"] = args ? args.oktaOrgUrl : undefined;
            resourceInputs["organization"] = args ? args.organization : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["clientSecret"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Provider.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Provider resource.
 */
export interface ProviderArgs {
    /**
     * the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
     * Nobl9.
     */
    clientId: pulumi.Input<string>;
    /**
     * the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
     * to Nobl9.
     */
    clientSecret: pulumi.Input<string>;
    /**
     * Nobl9 API URL.
     */
    ingestUrl?: pulumi.Input<string>;
    /**
     * Authorization service configuration.
     */
    oktaAuthServer?: pulumi.Input<string>;
    /**
     * Authorization service URL.
     */
    oktaOrgUrl?: pulumi.Input<string>;
    /**
     * Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
     * contains resources managed by the Nobl9 Terraform provider.
     */
    organization?: pulumi.Input<string>;
    /**
     * Nobl9 project used when importing resources.
     */
    project?: pulumi.Input<string>;
}
