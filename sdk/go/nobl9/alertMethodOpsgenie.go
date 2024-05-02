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

type AlertMethodOpsgenie struct {
	pulumi.CustomResourceState

	// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
	Auth pulumi.StringOutput `pulumi:"auth"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewAlertMethodOpsgenie registers a new resource with the given unique name, arguments, and options.
func NewAlertMethodOpsgenie(ctx *pulumi.Context,
	name string, args *AlertMethodOpsgenieArgs, opts ...pulumi.ResourceOption) (*AlertMethodOpsgenie, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	if args.Auth != nil {
		args.Auth = pulumi.ToSecret(args.Auth).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"auth",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AlertMethodOpsgenie
	err := ctx.RegisterResource("nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlertMethodOpsgenie gets an existing AlertMethodOpsgenie resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlertMethodOpsgenie(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlertMethodOpsgenieState, opts ...pulumi.ResourceOption) (*AlertMethodOpsgenie, error) {
	var resource AlertMethodOpsgenie
	err := ctx.ReadResource("nobl9:index/alertMethodOpsgenie:AlertMethodOpsgenie", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AlertMethodOpsgenie resources.
type alertMethodOpsgenieState struct {
	// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
	Auth *string `pulumi:"auth"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
	Url *string `pulumi:"url"`
}

type AlertMethodOpsgenieState struct {
	// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
	Auth pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
	Url pulumi.StringPtrInput
}

func (AlertMethodOpsgenieState) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodOpsgenieState)(nil)).Elem()
}

type alertMethodOpsgenieArgs struct {
	// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
	Auth *string `pulumi:"auth"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
	Url string `pulumi:"url"`
}

// The set of arguments for constructing a AlertMethodOpsgenie resource.
type AlertMethodOpsgenieArgs struct {
	// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
	Auth pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
	Url pulumi.StringInput
}

func (AlertMethodOpsgenieArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodOpsgenieArgs)(nil)).Elem()
}

type AlertMethodOpsgenieInput interface {
	pulumi.Input

	ToAlertMethodOpsgenieOutput() AlertMethodOpsgenieOutput
	ToAlertMethodOpsgenieOutputWithContext(ctx context.Context) AlertMethodOpsgenieOutput
}

func (*AlertMethodOpsgenie) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodOpsgenie)(nil)).Elem()
}

func (i *AlertMethodOpsgenie) ToAlertMethodOpsgenieOutput() AlertMethodOpsgenieOutput {
	return i.ToAlertMethodOpsgenieOutputWithContext(context.Background())
}

func (i *AlertMethodOpsgenie) ToAlertMethodOpsgenieOutputWithContext(ctx context.Context) AlertMethodOpsgenieOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodOpsgenieOutput)
}

// AlertMethodOpsgenieArrayInput is an input type that accepts AlertMethodOpsgenieArray and AlertMethodOpsgenieArrayOutput values.
// You can construct a concrete instance of `AlertMethodOpsgenieArrayInput` via:
//
//	AlertMethodOpsgenieArray{ AlertMethodOpsgenieArgs{...} }
type AlertMethodOpsgenieArrayInput interface {
	pulumi.Input

	ToAlertMethodOpsgenieArrayOutput() AlertMethodOpsgenieArrayOutput
	ToAlertMethodOpsgenieArrayOutputWithContext(context.Context) AlertMethodOpsgenieArrayOutput
}

type AlertMethodOpsgenieArray []AlertMethodOpsgenieInput

func (AlertMethodOpsgenieArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodOpsgenie)(nil)).Elem()
}

func (i AlertMethodOpsgenieArray) ToAlertMethodOpsgenieArrayOutput() AlertMethodOpsgenieArrayOutput {
	return i.ToAlertMethodOpsgenieArrayOutputWithContext(context.Background())
}

func (i AlertMethodOpsgenieArray) ToAlertMethodOpsgenieArrayOutputWithContext(ctx context.Context) AlertMethodOpsgenieArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodOpsgenieArrayOutput)
}

// AlertMethodOpsgenieMapInput is an input type that accepts AlertMethodOpsgenieMap and AlertMethodOpsgenieMapOutput values.
// You can construct a concrete instance of `AlertMethodOpsgenieMapInput` via:
//
//	AlertMethodOpsgenieMap{ "key": AlertMethodOpsgenieArgs{...} }
type AlertMethodOpsgenieMapInput interface {
	pulumi.Input

	ToAlertMethodOpsgenieMapOutput() AlertMethodOpsgenieMapOutput
	ToAlertMethodOpsgenieMapOutputWithContext(context.Context) AlertMethodOpsgenieMapOutput
}

type AlertMethodOpsgenieMap map[string]AlertMethodOpsgenieInput

func (AlertMethodOpsgenieMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodOpsgenie)(nil)).Elem()
}

func (i AlertMethodOpsgenieMap) ToAlertMethodOpsgenieMapOutput() AlertMethodOpsgenieMapOutput {
	return i.ToAlertMethodOpsgenieMapOutputWithContext(context.Background())
}

func (i AlertMethodOpsgenieMap) ToAlertMethodOpsgenieMapOutputWithContext(ctx context.Context) AlertMethodOpsgenieMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodOpsgenieMapOutput)
}

type AlertMethodOpsgenieOutput struct{ *pulumi.OutputState }

func (AlertMethodOpsgenieOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodOpsgenie)(nil)).Elem()
}

func (o AlertMethodOpsgenieOutput) ToAlertMethodOpsgenieOutput() AlertMethodOpsgenieOutput {
	return o
}

func (o AlertMethodOpsgenieOutput) ToAlertMethodOpsgenieOutputWithContext(ctx context.Context) AlertMethodOpsgenieOutput {
	return o
}

// Opsgenie authentication credentials. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#authentication) for supported formats.
func (o AlertMethodOpsgenieOutput) Auth() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringOutput { return v.Auth }).(pulumi.StringOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o AlertMethodOpsgenieOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o AlertMethodOpsgenieOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodOpsgenieOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodOpsgenieOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// Opsgenie API URL. See [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/opsgenie#creating-opsgenie-api-key) for more details.
func (o AlertMethodOpsgenieOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodOpsgenie) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type AlertMethodOpsgenieArrayOutput struct{ *pulumi.OutputState }

func (AlertMethodOpsgenieArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodOpsgenie)(nil)).Elem()
}

func (o AlertMethodOpsgenieArrayOutput) ToAlertMethodOpsgenieArrayOutput() AlertMethodOpsgenieArrayOutput {
	return o
}

func (o AlertMethodOpsgenieArrayOutput) ToAlertMethodOpsgenieArrayOutputWithContext(ctx context.Context) AlertMethodOpsgenieArrayOutput {
	return o
}

func (o AlertMethodOpsgenieArrayOutput) Index(i pulumi.IntInput) AlertMethodOpsgenieOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AlertMethodOpsgenie {
		return vs[0].([]*AlertMethodOpsgenie)[vs[1].(int)]
	}).(AlertMethodOpsgenieOutput)
}

type AlertMethodOpsgenieMapOutput struct{ *pulumi.OutputState }

func (AlertMethodOpsgenieMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodOpsgenie)(nil)).Elem()
}

func (o AlertMethodOpsgenieMapOutput) ToAlertMethodOpsgenieMapOutput() AlertMethodOpsgenieMapOutput {
	return o
}

func (o AlertMethodOpsgenieMapOutput) ToAlertMethodOpsgenieMapOutputWithContext(ctx context.Context) AlertMethodOpsgenieMapOutput {
	return o
}

func (o AlertMethodOpsgenieMapOutput) MapIndex(k pulumi.StringInput) AlertMethodOpsgenieOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AlertMethodOpsgenie {
		return vs[0].(map[string]*AlertMethodOpsgenie)[vs[1].(string)]
	}).(AlertMethodOpsgenieOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodOpsgenieInput)(nil)).Elem(), &AlertMethodOpsgenie{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodOpsgenieArrayInput)(nil)).Elem(), AlertMethodOpsgenieArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodOpsgenieMapInput)(nil)).Elem(), AlertMethodOpsgenieMap{})
	pulumi.RegisterOutputType(AlertMethodOpsgenieOutput{})
	pulumi.RegisterOutputType(AlertMethodOpsgenieArrayOutput{})
	pulumi.RegisterOutputType(AlertMethodOpsgenieMapOutput{})
}
