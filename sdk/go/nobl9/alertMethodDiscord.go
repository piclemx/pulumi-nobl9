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

type AlertMethodDiscord struct {
	pulumi.CustomResourceState

	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewAlertMethodDiscord registers a new resource with the given unique name, arguments, and options.
func NewAlertMethodDiscord(ctx *pulumi.Context,
	name string, args *AlertMethodDiscordArgs, opts ...pulumi.ResourceOption) (*AlertMethodDiscord, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.Url != nil {
		args.Url = pulumi.ToSecret(args.Url).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"url",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AlertMethodDiscord
	err := ctx.RegisterResource("nobl9:index/alertMethodDiscord:AlertMethodDiscord", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlertMethodDiscord gets an existing AlertMethodDiscord resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlertMethodDiscord(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlertMethodDiscordState, opts ...pulumi.ResourceOption) (*AlertMethodDiscord, error) {
	var resource AlertMethodDiscord
	err := ctx.ReadResource("nobl9:index/alertMethodDiscord:AlertMethodDiscord", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AlertMethodDiscord resources.
type alertMethodDiscordState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
	Url *string `pulumi:"url"`
}

type AlertMethodDiscordState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
	Url pulumi.StringPtrInput
}

func (AlertMethodDiscordState) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodDiscordState)(nil)).Elem()
}

type alertMethodDiscordArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
	Url *string `pulumi:"url"`
}

// The set of arguments for constructing a AlertMethodDiscord resource.
type AlertMethodDiscordArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
	Url pulumi.StringPtrInput
}

func (AlertMethodDiscordArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodDiscordArgs)(nil)).Elem()
}

type AlertMethodDiscordInput interface {
	pulumi.Input

	ToAlertMethodDiscordOutput() AlertMethodDiscordOutput
	ToAlertMethodDiscordOutputWithContext(ctx context.Context) AlertMethodDiscordOutput
}

func (*AlertMethodDiscord) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodDiscord)(nil)).Elem()
}

func (i *AlertMethodDiscord) ToAlertMethodDiscordOutput() AlertMethodDiscordOutput {
	return i.ToAlertMethodDiscordOutputWithContext(context.Background())
}

func (i *AlertMethodDiscord) ToAlertMethodDiscordOutputWithContext(ctx context.Context) AlertMethodDiscordOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodDiscordOutput)
}

// AlertMethodDiscordArrayInput is an input type that accepts AlertMethodDiscordArray and AlertMethodDiscordArrayOutput values.
// You can construct a concrete instance of `AlertMethodDiscordArrayInput` via:
//
//	AlertMethodDiscordArray{ AlertMethodDiscordArgs{...} }
type AlertMethodDiscordArrayInput interface {
	pulumi.Input

	ToAlertMethodDiscordArrayOutput() AlertMethodDiscordArrayOutput
	ToAlertMethodDiscordArrayOutputWithContext(context.Context) AlertMethodDiscordArrayOutput
}

type AlertMethodDiscordArray []AlertMethodDiscordInput

func (AlertMethodDiscordArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodDiscord)(nil)).Elem()
}

func (i AlertMethodDiscordArray) ToAlertMethodDiscordArrayOutput() AlertMethodDiscordArrayOutput {
	return i.ToAlertMethodDiscordArrayOutputWithContext(context.Background())
}

func (i AlertMethodDiscordArray) ToAlertMethodDiscordArrayOutputWithContext(ctx context.Context) AlertMethodDiscordArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodDiscordArrayOutput)
}

// AlertMethodDiscordMapInput is an input type that accepts AlertMethodDiscordMap and AlertMethodDiscordMapOutput values.
// You can construct a concrete instance of `AlertMethodDiscordMapInput` via:
//
//	AlertMethodDiscordMap{ "key": AlertMethodDiscordArgs{...} }
type AlertMethodDiscordMapInput interface {
	pulumi.Input

	ToAlertMethodDiscordMapOutput() AlertMethodDiscordMapOutput
	ToAlertMethodDiscordMapOutputWithContext(context.Context) AlertMethodDiscordMapOutput
}

type AlertMethodDiscordMap map[string]AlertMethodDiscordInput

func (AlertMethodDiscordMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodDiscord)(nil)).Elem()
}

func (i AlertMethodDiscordMap) ToAlertMethodDiscordMapOutput() AlertMethodDiscordMapOutput {
	return i.ToAlertMethodDiscordMapOutputWithContext(context.Background())
}

func (i AlertMethodDiscordMap) ToAlertMethodDiscordMapOutputWithContext(ctx context.Context) AlertMethodDiscordMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodDiscordMapOutput)
}

type AlertMethodDiscordOutput struct{ *pulumi.OutputState }

func (AlertMethodDiscordOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodDiscord)(nil)).Elem()
}

func (o AlertMethodDiscordOutput) ToAlertMethodDiscordOutput() AlertMethodDiscordOutput {
	return o
}

func (o AlertMethodDiscordOutput) ToAlertMethodDiscordOutputWithContext(ctx context.Context) AlertMethodDiscordOutput {
	return o
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o AlertMethodDiscordOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodDiscord) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o AlertMethodDiscordOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodDiscord) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodDiscordOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodDiscord) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodDiscordOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodDiscord) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Discord webhook endpoint URL. Refer to [Intro to webhooks | Discord documentation](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks) for more details.
func (o AlertMethodDiscordOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodDiscord) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type AlertMethodDiscordArrayOutput struct{ *pulumi.OutputState }

func (AlertMethodDiscordArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodDiscord)(nil)).Elem()
}

func (o AlertMethodDiscordArrayOutput) ToAlertMethodDiscordArrayOutput() AlertMethodDiscordArrayOutput {
	return o
}

func (o AlertMethodDiscordArrayOutput) ToAlertMethodDiscordArrayOutputWithContext(ctx context.Context) AlertMethodDiscordArrayOutput {
	return o
}

func (o AlertMethodDiscordArrayOutput) Index(i pulumi.IntInput) AlertMethodDiscordOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AlertMethodDiscord {
		return vs[0].([]*AlertMethodDiscord)[vs[1].(int)]
	}).(AlertMethodDiscordOutput)
}

type AlertMethodDiscordMapOutput struct{ *pulumi.OutputState }

func (AlertMethodDiscordMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodDiscord)(nil)).Elem()
}

func (o AlertMethodDiscordMapOutput) ToAlertMethodDiscordMapOutput() AlertMethodDiscordMapOutput {
	return o
}

func (o AlertMethodDiscordMapOutput) ToAlertMethodDiscordMapOutputWithContext(ctx context.Context) AlertMethodDiscordMapOutput {
	return o
}

func (o AlertMethodDiscordMapOutput) MapIndex(k pulumi.StringInput) AlertMethodDiscordOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AlertMethodDiscord {
		return vs[0].(map[string]*AlertMethodDiscord)[vs[1].(string)]
	}).(AlertMethodDiscordOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodDiscordInput)(nil)).Elem(), &AlertMethodDiscord{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodDiscordArrayInput)(nil)).Elem(), AlertMethodDiscordArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodDiscordMapInput)(nil)).Elem(), AlertMethodDiscordMap{})
	pulumi.RegisterOutputType(AlertMethodDiscordOutput{})
	pulumi.RegisterOutputType(AlertMethodDiscordArrayOutput{})
	pulumi.RegisterOutputType(AlertMethodDiscordMapOutput{})
}
