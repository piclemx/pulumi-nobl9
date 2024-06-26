// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"errors"
	"github.com/piclemx/pulumi-nobl9/sdk/go/nobl9/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ThousandEyes monitors the performance of both local and wide-area networks. ThousandEyes combines Internet and WAN visibility, browser synthetics, end-user monitoring, and Internet Insights to deliver a holistic view of your hybrid digital ecosystem – across cloud, SaaS, and the Internet. It's a SaaS-based tool that helps troubleshoot application delivery and maps Internet performance. Nobl9 connects to ThousandEyes for SLI measurement collection and comparison with SLO targets.
//
// For more information, refer to [ThousandEyes Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/thousandeyes#thousandeyes-direct).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/piclemx/pulumi-nobl9/sdk/go/nobl9"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := nobl9.NewDirectThousandeyes(ctx, "test-thousandeyes", &nobl9.DirectThousandeyesArgs{
//				Description:          pulumi.String("desc"),
//				LogCollectionEnabled: pulumi.Bool(true),
//				OauthBearerToken:     pulumi.String("secret"),
//				Project:              pulumi.String("terraform"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// ## Nobl9 Official Documentation
//
// https://docs.nobl9.com/
type DirectThousandeyes struct {
	pulumi.CustomResourceState

	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrOutput `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// [required] | ThousandEyes OAuth Bearer Token.
	OauthBearerToken pulumi.StringOutput `pulumi:"oauthBearerToken"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectThousandeyesQueryDelayOutput `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringOutput `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectThousandeyes registers a new resource with the given unique name, arguments, and options.
func NewDirectThousandeyes(ctx *pulumi.Context,
	name string, args *DirectThousandeyesArgs, opts ...pulumi.ResourceOption) (*DirectThousandeyes, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.OauthBearerToken != nil {
		args.OauthBearerToken = pulumi.ToSecret(args.OauthBearerToken).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"oauthBearerToken",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DirectThousandeyes
	err := ctx.RegisterResource("nobl9:index/directThousandeyes:DirectThousandeyes", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectThousandeyes gets an existing DirectThousandeyes resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectThousandeyes(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectThousandeyesState, opts ...pulumi.ResourceOption) (*DirectThousandeyes, error) {
	var resource DirectThousandeyes
	err := ctx.ReadResource("nobl9:index/directThousandeyes:DirectThousandeyes", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectThousandeyes resources.
type directThousandeyesState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// [required] | ThousandEyes OAuth Bearer Token.
	OauthBearerToken *string `pulumi:"oauthBearerToken"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectThousandeyesQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectThousandeyesState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// [required] | ThousandEyes OAuth Bearer Token.
	OauthBearerToken pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectThousandeyesQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectThousandeyesState) ElementType() reflect.Type {
	return reflect.TypeOf((*directThousandeyesState)(nil)).Elem()
}

type directThousandeyesArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// [required] | ThousandEyes OAuth Bearer Token.
	OauthBearerToken *string `pulumi:"oauthBearerToken"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectThousandeyesQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectThousandeyes resource.
type DirectThousandeyesArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// [required] | ThousandEyes OAuth Bearer Token.
	OauthBearerToken pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectThousandeyesQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
}

func (DirectThousandeyesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directThousandeyesArgs)(nil)).Elem()
}

type DirectThousandeyesInput interface {
	pulumi.Input

	ToDirectThousandeyesOutput() DirectThousandeyesOutput
	ToDirectThousandeyesOutputWithContext(ctx context.Context) DirectThousandeyesOutput
}

func (*DirectThousandeyes) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectThousandeyes)(nil)).Elem()
}

func (i *DirectThousandeyes) ToDirectThousandeyesOutput() DirectThousandeyesOutput {
	return i.ToDirectThousandeyesOutputWithContext(context.Background())
}

func (i *DirectThousandeyes) ToDirectThousandeyesOutputWithContext(ctx context.Context) DirectThousandeyesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectThousandeyesOutput)
}

// DirectThousandeyesArrayInput is an input type that accepts DirectThousandeyesArray and DirectThousandeyesArrayOutput values.
// You can construct a concrete instance of `DirectThousandeyesArrayInput` via:
//
//	DirectThousandeyesArray{ DirectThousandeyesArgs{...} }
type DirectThousandeyesArrayInput interface {
	pulumi.Input

	ToDirectThousandeyesArrayOutput() DirectThousandeyesArrayOutput
	ToDirectThousandeyesArrayOutputWithContext(context.Context) DirectThousandeyesArrayOutput
}

type DirectThousandeyesArray []DirectThousandeyesInput

func (DirectThousandeyesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectThousandeyes)(nil)).Elem()
}

func (i DirectThousandeyesArray) ToDirectThousandeyesArrayOutput() DirectThousandeyesArrayOutput {
	return i.ToDirectThousandeyesArrayOutputWithContext(context.Background())
}

func (i DirectThousandeyesArray) ToDirectThousandeyesArrayOutputWithContext(ctx context.Context) DirectThousandeyesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectThousandeyesArrayOutput)
}

// DirectThousandeyesMapInput is an input type that accepts DirectThousandeyesMap and DirectThousandeyesMapOutput values.
// You can construct a concrete instance of `DirectThousandeyesMapInput` via:
//
//	DirectThousandeyesMap{ "key": DirectThousandeyesArgs{...} }
type DirectThousandeyesMapInput interface {
	pulumi.Input

	ToDirectThousandeyesMapOutput() DirectThousandeyesMapOutput
	ToDirectThousandeyesMapOutputWithContext(context.Context) DirectThousandeyesMapOutput
}

type DirectThousandeyesMap map[string]DirectThousandeyesInput

func (DirectThousandeyesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectThousandeyes)(nil)).Elem()
}

func (i DirectThousandeyesMap) ToDirectThousandeyesMapOutput() DirectThousandeyesMapOutput {
	return i.ToDirectThousandeyesMapOutputWithContext(context.Background())
}

func (i DirectThousandeyesMap) ToDirectThousandeyesMapOutputWithContext(ctx context.Context) DirectThousandeyesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectThousandeyesMapOutput)
}

type DirectThousandeyesOutput struct{ *pulumi.OutputState }

func (DirectThousandeyesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectThousandeyes)(nil)).Elem()
}

func (o DirectThousandeyesOutput) ToDirectThousandeyesOutput() DirectThousandeyesOutput {
	return o
}

func (o DirectThousandeyesOutput) ToDirectThousandeyesOutputWithContext(ctx context.Context) DirectThousandeyesOutput {
	return o
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectThousandeyesOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectThousandeyesOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
func (o DirectThousandeyesOutput) LogCollectionEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.BoolPtrOutput { return v.LogCollectionEnabled }).(pulumi.BoolPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectThousandeyesOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// [required] | ThousandEyes OAuth Bearer Token.
func (o DirectThousandeyesOutput) OauthBearerToken() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringOutput { return v.OauthBearerToken }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectThousandeyesOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectThousandeyesOutput) QueryDelay() DirectThousandeyesQueryDelayOutput {
	return o.ApplyT(func(v *DirectThousandeyes) DirectThousandeyesQueryDelayOutput { return v.QueryDelay }).(DirectThousandeyesQueryDelayOutput)
}

// Release channel of the created datasource [stable/beta]
func (o DirectThousandeyesOutput) ReleaseChannel() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringOutput { return v.ReleaseChannel }).(pulumi.StringOutput)
}

// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
//
// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
func (o DirectThousandeyesOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectThousandeyesOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectThousandeyes) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectThousandeyesArrayOutput struct{ *pulumi.OutputState }

func (DirectThousandeyesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectThousandeyes)(nil)).Elem()
}

func (o DirectThousandeyesArrayOutput) ToDirectThousandeyesArrayOutput() DirectThousandeyesArrayOutput {
	return o
}

func (o DirectThousandeyesArrayOutput) ToDirectThousandeyesArrayOutputWithContext(ctx context.Context) DirectThousandeyesArrayOutput {
	return o
}

func (o DirectThousandeyesArrayOutput) Index(i pulumi.IntInput) DirectThousandeyesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectThousandeyes {
		return vs[0].([]*DirectThousandeyes)[vs[1].(int)]
	}).(DirectThousandeyesOutput)
}

type DirectThousandeyesMapOutput struct{ *pulumi.OutputState }

func (DirectThousandeyesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectThousandeyes)(nil)).Elem()
}

func (o DirectThousandeyesMapOutput) ToDirectThousandeyesMapOutput() DirectThousandeyesMapOutput {
	return o
}

func (o DirectThousandeyesMapOutput) ToDirectThousandeyesMapOutputWithContext(ctx context.Context) DirectThousandeyesMapOutput {
	return o
}

func (o DirectThousandeyesMapOutput) MapIndex(k pulumi.StringInput) DirectThousandeyesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectThousandeyes {
		return vs[0].(map[string]*DirectThousandeyes)[vs[1].(string)]
	}).(DirectThousandeyesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectThousandeyesInput)(nil)).Elem(), &DirectThousandeyes{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectThousandeyesArrayInput)(nil)).Elem(), DirectThousandeyesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectThousandeyesMapInput)(nil)).Elem(), DirectThousandeyesMap{})
	pulumi.RegisterOutputType(DirectThousandeyesOutput{})
	pulumi.RegisterOutputType(DirectThousandeyesArrayOutput{})
	pulumi.RegisterOutputType(DirectThousandeyesMapOutput{})
}
