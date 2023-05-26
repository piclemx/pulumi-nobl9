// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type AlertMethodEmail struct {
	pulumi.CustomResourceState

	// Blind carbon copy recipients. The maximum number of recipients is 10.
	Bccs pulumi.StringArrayOutput `pulumi:"bccs"`
	// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
	Body pulumi.StringOutput `pulumi:"body"`
	// Carbon copy recipients. The maximum number of recipients is 10.
	Ccs pulumi.StringArrayOutput `pulumi:"ccs"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// The Subject of the email alert.
	Subject pulumi.StringOutput `pulumi:"subject"`
	// Recipients. The maximum number of recipients is 10.
	Tos pulumi.StringArrayOutput `pulumi:"tos"`
}

// NewAlertMethodEmail registers a new resource with the given unique name, arguments, and options.
func NewAlertMethodEmail(ctx *pulumi.Context,
	name string, args *AlertMethodEmailArgs, opts ...pulumi.ResourceOption) (*AlertMethodEmail, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Body == nil {
		return nil, errors.New("invalid value for required argument 'Body'")
	}
	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.Subject == nil {
		return nil, errors.New("invalid value for required argument 'Subject'")
	}
	if args.Tos == nil {
		return nil, errors.New("invalid value for required argument 'Tos'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource AlertMethodEmail
	err := ctx.RegisterResource("nobl9:index/alertMethodEmail:AlertMethodEmail", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAlertMethodEmail gets an existing AlertMethodEmail resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAlertMethodEmail(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AlertMethodEmailState, opts ...pulumi.ResourceOption) (*AlertMethodEmail, error) {
	var resource AlertMethodEmail
	err := ctx.ReadResource("nobl9:index/alertMethodEmail:AlertMethodEmail", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AlertMethodEmail resources.
type alertMethodEmailState struct {
	// Blind carbon copy recipients. The maximum number of recipients is 10.
	Bccs []string `pulumi:"bccs"`
	// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
	Body *string `pulumi:"body"`
	// Carbon copy recipients. The maximum number of recipients is 10.
	Ccs []string `pulumi:"ccs"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// The Subject of the email alert.
	Subject *string `pulumi:"subject"`
	// Recipients. The maximum number of recipients is 10.
	Tos []string `pulumi:"tos"`
}

type AlertMethodEmailState struct {
	// Blind carbon copy recipients. The maximum number of recipients is 10.
	Bccs pulumi.StringArrayInput
	// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
	Body pulumi.StringPtrInput
	// Carbon copy recipients. The maximum number of recipients is 10.
	Ccs pulumi.StringArrayInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// The Subject of the email alert.
	Subject pulumi.StringPtrInput
	// Recipients. The maximum number of recipients is 10.
	Tos pulumi.StringArrayInput
}

func (AlertMethodEmailState) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodEmailState)(nil)).Elem()
}

type alertMethodEmailArgs struct {
	// Blind carbon copy recipients. The maximum number of recipients is 10.
	Bccs []string `pulumi:"bccs"`
	// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
	Body string `pulumi:"body"`
	// Carbon copy recipients. The maximum number of recipients is 10.
	Ccs []string `pulumi:"ccs"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// The Subject of the email alert.
	Subject string `pulumi:"subject"`
	// Recipients. The maximum number of recipients is 10.
	Tos []string `pulumi:"tos"`
}

// The set of arguments for constructing a AlertMethodEmail resource.
type AlertMethodEmailArgs struct {
	// Blind carbon copy recipients. The maximum number of recipients is 10.
	Bccs pulumi.StringArrayInput
	// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
	Body pulumi.StringInput
	// Carbon copy recipients. The maximum number of recipients is 10.
	Ccs pulumi.StringArrayInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// The Subject of the email alert.
	Subject pulumi.StringInput
	// Recipients. The maximum number of recipients is 10.
	Tos pulumi.StringArrayInput
}

func (AlertMethodEmailArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*alertMethodEmailArgs)(nil)).Elem()
}

type AlertMethodEmailInput interface {
	pulumi.Input

	ToAlertMethodEmailOutput() AlertMethodEmailOutput
	ToAlertMethodEmailOutputWithContext(ctx context.Context) AlertMethodEmailOutput
}

func (*AlertMethodEmail) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodEmail)(nil)).Elem()
}

func (i *AlertMethodEmail) ToAlertMethodEmailOutput() AlertMethodEmailOutput {
	return i.ToAlertMethodEmailOutputWithContext(context.Background())
}

func (i *AlertMethodEmail) ToAlertMethodEmailOutputWithContext(ctx context.Context) AlertMethodEmailOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodEmailOutput)
}

// AlertMethodEmailArrayInput is an input type that accepts AlertMethodEmailArray and AlertMethodEmailArrayOutput values.
// You can construct a concrete instance of `AlertMethodEmailArrayInput` via:
//
//          AlertMethodEmailArray{ AlertMethodEmailArgs{...} }
type AlertMethodEmailArrayInput interface {
	pulumi.Input

	ToAlertMethodEmailArrayOutput() AlertMethodEmailArrayOutput
	ToAlertMethodEmailArrayOutputWithContext(context.Context) AlertMethodEmailArrayOutput
}

type AlertMethodEmailArray []AlertMethodEmailInput

func (AlertMethodEmailArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodEmail)(nil)).Elem()
}

func (i AlertMethodEmailArray) ToAlertMethodEmailArrayOutput() AlertMethodEmailArrayOutput {
	return i.ToAlertMethodEmailArrayOutputWithContext(context.Background())
}

func (i AlertMethodEmailArray) ToAlertMethodEmailArrayOutputWithContext(ctx context.Context) AlertMethodEmailArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodEmailArrayOutput)
}

// AlertMethodEmailMapInput is an input type that accepts AlertMethodEmailMap and AlertMethodEmailMapOutput values.
// You can construct a concrete instance of `AlertMethodEmailMapInput` via:
//
//          AlertMethodEmailMap{ "key": AlertMethodEmailArgs{...} }
type AlertMethodEmailMapInput interface {
	pulumi.Input

	ToAlertMethodEmailMapOutput() AlertMethodEmailMapOutput
	ToAlertMethodEmailMapOutputWithContext(context.Context) AlertMethodEmailMapOutput
}

type AlertMethodEmailMap map[string]AlertMethodEmailInput

func (AlertMethodEmailMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodEmail)(nil)).Elem()
}

func (i AlertMethodEmailMap) ToAlertMethodEmailMapOutput() AlertMethodEmailMapOutput {
	return i.ToAlertMethodEmailMapOutputWithContext(context.Background())
}

func (i AlertMethodEmailMap) ToAlertMethodEmailMapOutputWithContext(ctx context.Context) AlertMethodEmailMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AlertMethodEmailMapOutput)
}

type AlertMethodEmailOutput struct{ *pulumi.OutputState }

func (AlertMethodEmailOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AlertMethodEmail)(nil)).Elem()
}

func (o AlertMethodEmailOutput) ToAlertMethodEmailOutput() AlertMethodEmailOutput {
	return o
}

func (o AlertMethodEmailOutput) ToAlertMethodEmailOutputWithContext(ctx context.Context) AlertMethodEmailOutput {
	return o
}

// Blind carbon copy recipients. The maximum number of recipients is 10.
func (o AlertMethodEmailOutput) Bccs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringArrayOutput { return v.Bccs }).(pulumi.StringArrayOutput)
}

// The Body of the email alert. For the format of the body and the list of variables that you can define, refer to the [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/email-alert#yaml-configuration).
func (o AlertMethodEmailOutput) Body() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringOutput { return v.Body }).(pulumi.StringOutput)
}

// Carbon copy recipients. The maximum number of recipients is 10.
func (o AlertMethodEmailOutput) Ccs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringArrayOutput { return v.Ccs }).(pulumi.StringArrayOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o AlertMethodEmailOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o AlertMethodEmailOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodEmailOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o AlertMethodEmailOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// The Subject of the email alert.
func (o AlertMethodEmailOutput) Subject() pulumi.StringOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringOutput { return v.Subject }).(pulumi.StringOutput)
}

// Recipients. The maximum number of recipients is 10.
func (o AlertMethodEmailOutput) Tos() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AlertMethodEmail) pulumi.StringArrayOutput { return v.Tos }).(pulumi.StringArrayOutput)
}

type AlertMethodEmailArrayOutput struct{ *pulumi.OutputState }

func (AlertMethodEmailArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AlertMethodEmail)(nil)).Elem()
}

func (o AlertMethodEmailArrayOutput) ToAlertMethodEmailArrayOutput() AlertMethodEmailArrayOutput {
	return o
}

func (o AlertMethodEmailArrayOutput) ToAlertMethodEmailArrayOutputWithContext(ctx context.Context) AlertMethodEmailArrayOutput {
	return o
}

func (o AlertMethodEmailArrayOutput) Index(i pulumi.IntInput) AlertMethodEmailOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AlertMethodEmail {
		return vs[0].([]*AlertMethodEmail)[vs[1].(int)]
	}).(AlertMethodEmailOutput)
}

type AlertMethodEmailMapOutput struct{ *pulumi.OutputState }

func (AlertMethodEmailMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AlertMethodEmail)(nil)).Elem()
}

func (o AlertMethodEmailMapOutput) ToAlertMethodEmailMapOutput() AlertMethodEmailMapOutput {
	return o
}

func (o AlertMethodEmailMapOutput) ToAlertMethodEmailMapOutputWithContext(ctx context.Context) AlertMethodEmailMapOutput {
	return o
}

func (o AlertMethodEmailMapOutput) MapIndex(k pulumi.StringInput) AlertMethodEmailOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AlertMethodEmail {
		return vs[0].(map[string]*AlertMethodEmail)[vs[1].(string)]
	}).(AlertMethodEmailOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodEmailInput)(nil)).Elem(), &AlertMethodEmail{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodEmailArrayInput)(nil)).Elem(), AlertMethodEmailArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AlertMethodEmailMapInput)(nil)).Elem(), AlertMethodEmailMap{})
	pulumi.RegisterOutputType(AlertMethodEmailOutput{})
	pulumi.RegisterOutputType(AlertMethodEmailArrayOutput{})
	pulumi.RegisterOutputType(AlertMethodEmailMapOutput{})
}
