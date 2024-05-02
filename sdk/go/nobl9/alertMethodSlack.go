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

type AlertMethodSlack struct {
	pulumi.CustomResourceState

	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewAlertMethodSlack registers a new resource with the given unique name, arguments, and options.
func NewAlertMethodSlack(ctx *pulumi.Context,
	name string, args *AlertMethodSlackArgs, opts ...pulumi.ResourceOption) (*AlertMethodSlack, error) {
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
	var resource AlertMethodSlack
	err := ctx.RegisterResource("nobl9:index/alertMethodSlack:AlertMethodSlack", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlertMethodSlack gets an existing AlertMethodSlack resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlertMethodSlack(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlertMethodSlackState, opts ...pulumi.ResourceOption) (*AlertMethodSlack, error) {
	var resource AlertMethodSlack
	err := ctx.ReadResource("nobl9:index/alertMethodSlack:AlertMethodSlack", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AlertMethodSlack resources.
type alertMethodSlackState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
	Url *string `pulumi:"url"`
}

type AlertMethodSlackState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
	Url pulumi.StringPtrInput
}

func (AlertMethodSlackState) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodSlackState)(nil)).Elem()
}

type alertMethodSlackArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
	Url *string `pulumi:"url"`
}

// The set of arguments for constructing a AlertMethodSlack resource.
type AlertMethodSlackArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
	Url pulumi.StringPtrInput
}

func (AlertMethodSlackArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodSlackArgs)(nil)).Elem()
}

type AlertMethodSlackInput interface {
	pulumi.Input

	ToAlertMethodSlackOutput() AlertMethodSlackOutput
	ToAlertMethodSlackOutputWithContext(ctx context.Context) AlertMethodSlackOutput
}

func (*AlertMethodSlack) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodSlack)(nil)).Elem()
}

func (i *AlertMethodSlack) ToAlertMethodSlackOutput() AlertMethodSlackOutput {
	return i.ToAlertMethodSlackOutputWithContext(context.Background())
}

func (i *AlertMethodSlack) ToAlertMethodSlackOutputWithContext(ctx context.Context) AlertMethodSlackOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodSlackOutput)
}

// AlertMethodSlackArrayInput is an input type that accepts AlertMethodSlackArray and AlertMethodSlackArrayOutput values.
// You can construct a concrete instance of `AlertMethodSlackArrayInput` via:
//
//	AlertMethodSlackArray{ AlertMethodSlackArgs{...} }
type AlertMethodSlackArrayInput interface {
	pulumi.Input

	ToAlertMethodSlackArrayOutput() AlertMethodSlackArrayOutput
	ToAlertMethodSlackArrayOutputWithContext(context.Context) AlertMethodSlackArrayOutput
}

type AlertMethodSlackArray []AlertMethodSlackInput

func (AlertMethodSlackArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodSlack)(nil)).Elem()
}

func (i AlertMethodSlackArray) ToAlertMethodSlackArrayOutput() AlertMethodSlackArrayOutput {
	return i.ToAlertMethodSlackArrayOutputWithContext(context.Background())
}

func (i AlertMethodSlackArray) ToAlertMethodSlackArrayOutputWithContext(ctx context.Context) AlertMethodSlackArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodSlackArrayOutput)
}

// AlertMethodSlackMapInput is an input type that accepts AlertMethodSlackMap and AlertMethodSlackMapOutput values.
// You can construct a concrete instance of `AlertMethodSlackMapInput` via:
//
//	AlertMethodSlackMap{ "key": AlertMethodSlackArgs{...} }
type AlertMethodSlackMapInput interface {
	pulumi.Input

	ToAlertMethodSlackMapOutput() AlertMethodSlackMapOutput
	ToAlertMethodSlackMapOutputWithContext(context.Context) AlertMethodSlackMapOutput
}

type AlertMethodSlackMap map[string]AlertMethodSlackInput

func (AlertMethodSlackMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodSlack)(nil)).Elem()
}

func (i AlertMethodSlackMap) ToAlertMethodSlackMapOutput() AlertMethodSlackMapOutput {
	return i.ToAlertMethodSlackMapOutputWithContext(context.Background())
}

func (i AlertMethodSlackMap) ToAlertMethodSlackMapOutputWithContext(ctx context.Context) AlertMethodSlackMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodSlackMapOutput)
}

type AlertMethodSlackOutput struct{ *pulumi.OutputState }

func (AlertMethodSlackOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodSlack)(nil)).Elem()
}

func (o AlertMethodSlackOutput) ToAlertMethodSlackOutput() AlertMethodSlackOutput {
	return o
}

func (o AlertMethodSlackOutput) ToAlertMethodSlackOutputWithContext(ctx context.Context) AlertMethodSlackOutput {
	return o
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o AlertMethodSlackOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodSlack) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o AlertMethodSlackOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodSlack) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodSlackOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodSlack) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodSlackOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodSlack) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Slack [webhook endpoint URL](https://slack.com/help/articles/115005265063-Incoming-webhooks-for-Slack%22).
func (o AlertMethodSlackOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodSlack) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type AlertMethodSlackArrayOutput struct{ *pulumi.OutputState }

func (AlertMethodSlackArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodSlack)(nil)).Elem()
}

func (o AlertMethodSlackArrayOutput) ToAlertMethodSlackArrayOutput() AlertMethodSlackArrayOutput {
	return o
}

func (o AlertMethodSlackArrayOutput) ToAlertMethodSlackArrayOutputWithContext(ctx context.Context) AlertMethodSlackArrayOutput {
	return o
}

func (o AlertMethodSlackArrayOutput) Index(i pulumi.IntInput) AlertMethodSlackOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AlertMethodSlack {
		return vs[0].([]*AlertMethodSlack)[vs[1].(int)]
	}).(AlertMethodSlackOutput)
}

type AlertMethodSlackMapOutput struct{ *pulumi.OutputState }

func (AlertMethodSlackMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodSlack)(nil)).Elem()
}

func (o AlertMethodSlackMapOutput) ToAlertMethodSlackMapOutput() AlertMethodSlackMapOutput {
	return o
}

func (o AlertMethodSlackMapOutput) ToAlertMethodSlackMapOutputWithContext(ctx context.Context) AlertMethodSlackMapOutput {
	return o
}

func (o AlertMethodSlackMapOutput) MapIndex(k pulumi.StringInput) AlertMethodSlackOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AlertMethodSlack {
		return vs[0].(map[string]*AlertMethodSlack)[vs[1].(string)]
	}).(AlertMethodSlackOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodSlackInput)(nil)).Elem(), &AlertMethodSlack{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodSlackArrayInput)(nil)).Elem(), AlertMethodSlackArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodSlackMapInput)(nil)).Elem(), AlertMethodSlackMap{})
	pulumi.RegisterOutputType(AlertMethodSlackOutput{})
	pulumi.RegisterOutputType(AlertMethodSlackArrayOutput{})
	pulumi.RegisterOutputType(AlertMethodSlackMapOutput{})
}
