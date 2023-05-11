// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "nobl9:index/agent:Agent":
		r = &Agent{}
	case "nobl9:index/alertMethodDiscord:AlertMethodDiscord":
		r = &AlertMethodDiscord{}
	case "nobl9:index/alertMethodEmail:AlertMethodEmail":
		r = &AlertMethodEmail{}
	case "nobl9:index/alertMethodJira:AlertMethodJira":
		r = &AlertMethodJira{}
	case "nobl9:index/alertMethodMsteams:AlertMethodMsteams":
		r = &AlertMethodMsteams{}
	case "nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie":
		r = &AlertMethodOpsgenie{}
	case "nobl9:index/alertMethodPagerduty:AlertMethodPagerduty":
		r = &AlertMethodPagerduty{}
	case "nobl9:index/alertMethodServicenow:AlertMethodServicenow":
		r = &AlertMethodServicenow{}
	case "nobl9:index/alertMethodSlack:AlertMethodSlack":
		r = &AlertMethodSlack{}
	case "nobl9:index/alertMethodWebhook:AlertMethodWebhook":
		r = &AlertMethodWebhook{}
	case "nobl9:index/alertPolicy:AlertPolicy":
		r = &AlertPolicy{}
	case "nobl9:index/directAppdynamics:DirectAppdynamics":
		r = &DirectAppdynamics{}
	case "nobl9:index/directBigquery:DirectBigquery":
		r = &DirectBigquery{}
	case "nobl9:index/directCloudwatch:DirectCloudwatch":
		r = &DirectCloudwatch{}
	case "nobl9:index/directDatadog:DirectDatadog":
		r = &DirectDatadog{}
	case "nobl9:index/directDynatrace:DirectDynatrace":
		r = &DirectDynatrace{}
	case "nobl9:index/directGcm:DirectGcm":
		r = &DirectGcm{}
	case "nobl9:index/directInfluxdb:DirectInfluxdb":
		r = &DirectInfluxdb{}
	case "nobl9:index/directInstana:DirectInstana":
		r = &DirectInstana{}
	case "nobl9:index/directLightstep:DirectLightstep":
		r = &DirectLightstep{}
	case "nobl9:index/directNewrelic:DirectNewrelic":
		r = &DirectNewrelic{}
	case "nobl9:index/directPingdom:DirectPingdom":
		r = &DirectPingdom{}
	case "nobl9:index/directRedshift:DirectRedshift":
		r = &DirectRedshift{}
	case "nobl9:index/directSplunk:DirectSplunk":
		r = &DirectSplunk{}
	case "nobl9:index/directSplunkObservability:DirectSplunkObservability":
		r = &DirectSplunkObservability{}
	case "nobl9:index/directSumologic:DirectSumologic":
		r = &DirectSumologic{}
	case "nobl9:index/directThousandeyes:DirectThousandeyes":
		r = &DirectThousandeyes{}
	case "nobl9:index/project:Project":
		r = &Project{}
	case "nobl9:index/roleBinding:RoleBinding":
		r = &RoleBinding{}
	case "nobl9:index/service:Service":
		r = &Service{}
	case "nobl9:index/slo:Slo":
		r = &Slo{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

type pkg struct {
	version semver.Version
}

func (p *pkg) Version() semver.Version {
	return p.version
}

func (p *pkg) ConstructProvider(ctx *pulumi.Context, name, typ, urn string) (pulumi.ProviderResource, error) {
	if typ != "pulumi:providers:nobl9" {
		return nil, fmt.Errorf("unknown provider type: %s", typ)
	}

	r := &Provider{}
	err := ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return r, err
}

func init() {
	version, _ := PkgVersion()
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/agent",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodDiscord",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodEmail",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodJira",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodMsteams",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodOpsgenie",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodPagerduty",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodServicenow",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodSlack",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertMethodWebhook",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/alertPolicy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directAppdynamics",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directBigquery",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directCloudwatch",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directDatadog",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directDynatrace",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directGcm",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directInfluxdb",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directInstana",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directLightstep",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directNewrelic",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directPingdom",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directRedshift",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directSplunk",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directSplunkObservability",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directSumologic",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/directThousandeyes",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/project",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/roleBinding",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/service",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"nobl9",
		"index/slo",
		&module{version},
	)
	pulumi.RegisterResourcePackage(
		"nobl9",
		&pkg{version},
	)
}