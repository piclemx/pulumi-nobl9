// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
)

// the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
// Nobl9.
func GetClientId(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:clientId")
}

// the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
// to Nobl9.
func GetClientSecret(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:clientSecret")
}

// Nobl9 API URL.
func GetIngestUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:ingestUrl")
}

// Authorization service configuration.
func GetOktaAuthServer(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:oktaAuthServer")
}

// Authorization service URL.
func GetOktaOrgUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:oktaOrgUrl")
}

// Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
// contains resources managed by the Nobl9 Terraform provider.
func GetOrganization(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:organization")
}

// Nobl9 project used when importing resources.
func GetProject(ctx *pulumi.Context) string {
	return config.Get(ctx, "nobl9:project")
}
