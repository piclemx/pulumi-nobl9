---
title: Nobl9 Installation & Configuration
meta_desc: Information on how to install the Nobl9 provider.
layout: installation
---

## Installation

The Pulumi Nobl9 provider is available as a package in all Pulumi languages:

* JavaScript/TypeScript: [`@piclemx/pulumi-nobl9`](https://www.npmjs.com/package/@piclemx/pulumi-nobl9)
* Python: [`piclemx_pulumi_nobl9`](https://pypi.org/project/piclemx_pulumi_nobl9/)
* Go: [`github.com/piclemx/pulumi-nobl9/sdk/go/nobl9`](https://pkg.go.dev/github.com/piclemx/pulumi-nobl9/sdk/go/nobl9)
* .NET: [`Piclemx.Nobl9`](https://www.nuget.org/packages/Piclemx.Nobl9)


## Configuration

> Note:  
> Replace the following **sample content**, with the configuration options
> of the wrapped Terraform provider and remove this note.

The following configuration points are available for the `nobl9` provider:

- `nobl9:apiKey` (environment: `nobl9_API_KEY`) - the API key for `nobl9`
- `nobl9:region` (environment: `nobl9_REGION`) - the region in which to deploy resources

### Provider Binary

The Nobl9 provider binary is a third party binary. It can be installed using the `pulumi plugin` command.

```bash
pulumi plugin install resource nobl9 <version>
```

Replace the version string `<version>` with your desired version.
