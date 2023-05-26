// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package nobl9

import (
	"fmt"
	"path/filepath"
	"strings"

	"github.com/nobl9/terraform-provider-nobl9/nobl9"
	"github.com/piclemx/pulumi-nobl9/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
	"golang.org/x/text/cases"
	"golang.org/x/text/language"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "nobl9"
	// modules:
	mainMod = "index" // the nobl9 module
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(nobl9.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "nobl9",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "piclemx",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "https://github.com/piclemx/pulumi-noble9/releases/",
		Description:       "A Pulumi package for creating and managing Nobl9 cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "nobl9", "n9", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://www.pulumi.com",
		Repository: "https://github.com/piclemx/pulumi-nobl9",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "nobl9",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources:            map[string]*tfbridge.ResourceInfo{},
		DataSources:          map[string]*tfbridge.DataSourceInfo{},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/piclemx/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	for _, res := range []string{
		"nobl9_agent",
		"nobl9_alert_method_discord",
		"nobl9_alert_method_email",
		"nobl9_alert_method_jira",
		"nobl9_alert_method_msteams",
		"nobl9_alert_method_opsgenie",
		"nobl9_alert_method_pagerduty",
		"nobl9_alert_method_servicenow",
		"nobl9_alert_method_slack",
		"nobl9_alert_method_webhook",
		"nobl9_alert_policy",
		"nobl9_direct_appdynamics",
		"nobl9_direct_bigquery",
		"nobl9_direct_cloudwatch",
		"nobl9_direct_datadog",
		"nobl9_direct_dynatrace",
		"nobl9_direct_gcm",
		"nobl9_direct_influxdb",
		"nobl9_direct_instana",
		"nobl9_direct_lightstep",
		"nobl9_direct_newrelic",
		"nobl9_direct_pingdom",
		"nobl9_direct_redshift",
		"nobl9_direct_splunk",
		"nobl9_direct_splunk_observability",
		"nobl9_direct_sumologic",
		"nobl9_direct_thousandeyes",
		"nobl9_project",
		"nobl9_role_binding",
		"nobl9_service",
		"nobl9_slo",
	} {
		name := strings.Builder{}
		caser := cases.Title(language.English)
		for _, s := range strings.Split(res, "_")[1:] {
			name.WriteString(caser.String(s))
		}
		prov.Resources[res] = &tfbridge.ResourceInfo{
			Tok: tfbridge.MakeResource(mainPkg, mainMod, name.String()),
		}
	}

	prov.SetAutonaming(255, "-")

	return prov
}
