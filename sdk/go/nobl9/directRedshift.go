// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Amazon Redshift is a managed scalable database warehouse where Nobl9 users can store their metrics information. Nobl9 connects with Amazon Redshift to collect SLI measurements and compare them to SLO targets.
//
// For more information, refer to [Amazon Redshift Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/Amazon_Redshift/?_highlight=redshift#amazon-redshift-direct).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-nobl9/sdk/go/nobl9"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := nobl9.NewDirectRedshift(ctx, "test-redshift", &nobl9.DirectRedshiftArgs{
//				AccessKeyId:     pulumi.String("secret"),
//				Description:     pulumi.String("desc"),
//				Project:         pulumi.String("terraform"),
//				SecretAccessKey: pulumi.String("secret"),
//				SecretArn:       pulumi.String("aws:arn"),
//				SourceOfs: pulumi.StringArray{
//					pulumi.String("Metrics"),
//					pulumi.String("Services"),
//				},
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
type DirectRedshift struct {
	pulumi.CustomResourceState

	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringOutput `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectRedshiftQueryDelayPtrOutput `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringOutput `pulumi:"secretAccessKey"`
	// AWS Secret ARN.
	SecretArn pulumi.StringOutput `pulumi:"secretArn"`
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectRedshift registers a new resource with the given unique name, arguments, and options.
func NewDirectRedshift(ctx *pulumi.Context,
	name string, args *DirectRedshiftArgs, opts ...pulumi.ResourceOption) (*DirectRedshift, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.SourceOfs == nil {
		return nil, errors.New("invalid value for required argument 'SourceOfs'")
	}
	var resource DirectRedshift
	err := ctx.RegisterResource("nobl9:index/directRedshift:DirectRedshift", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectRedshift gets an existing DirectRedshift resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectRedshift(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectRedshiftState, opts ...pulumi.ResourceOption) (*DirectRedshift, error) {
	var resource DirectRedshift
	err := ctx.ReadResource("nobl9:index/directRedshift:DirectRedshift", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectRedshift resources.
type directRedshiftState struct {
	// [required] | AWS Access Key ID.
	AccessKeyId *string `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectRedshiftQueryDelay `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey *string `pulumi:"secretAccessKey"`
	// AWS Secret ARN.
	SecretArn *string `pulumi:"secretArn"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectRedshiftState struct {
	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectRedshiftQueryDelayPtrInput
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringPtrInput
	// AWS Secret ARN.
	SecretArn pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectRedshiftState) ElementType() reflect.Type {
	return reflect.TypeOf((*directRedshiftState)(nil)).Elem()
}

type directRedshiftArgs struct {
	// [required] | AWS Access Key ID.
	AccessKeyId *string `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectRedshiftQueryDelay `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey *string `pulumi:"secretAccessKey"`
	// AWS Secret ARN.
	SecretArn *string `pulumi:"secretArn"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectRedshift resource.
type DirectRedshiftArgs struct {
	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectRedshiftQueryDelayPtrInput
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringPtrInput
	// AWS Secret ARN.
	SecretArn pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
}

func (DirectRedshiftArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directRedshiftArgs)(nil)).Elem()
}

type DirectRedshiftInput interface {
	pulumi.Input

	ToDirectRedshiftOutput() DirectRedshiftOutput
	ToDirectRedshiftOutputWithContext(ctx context.Context) DirectRedshiftOutput
}

func (*DirectRedshift) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectRedshift)(nil)).Elem()
}

func (i *DirectRedshift) ToDirectRedshiftOutput() DirectRedshiftOutput {
	return i.ToDirectRedshiftOutputWithContext(context.Background())
}

func (i *DirectRedshift) ToDirectRedshiftOutputWithContext(ctx context.Context) DirectRedshiftOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectRedshiftOutput)
}

// DirectRedshiftArrayInput is an input type that accepts DirectRedshiftArray and DirectRedshiftArrayOutput values.
// You can construct a concrete instance of `DirectRedshiftArrayInput` via:
//
//	DirectRedshiftArray{ DirectRedshiftArgs{...} }
type DirectRedshiftArrayInput interface {
	pulumi.Input

	ToDirectRedshiftArrayOutput() DirectRedshiftArrayOutput
	ToDirectRedshiftArrayOutputWithContext(context.Context) DirectRedshiftArrayOutput
}

type DirectRedshiftArray []DirectRedshiftInput

func (DirectRedshiftArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectRedshift)(nil)).Elem()
}

func (i DirectRedshiftArray) ToDirectRedshiftArrayOutput() DirectRedshiftArrayOutput {
	return i.ToDirectRedshiftArrayOutputWithContext(context.Background())
}

func (i DirectRedshiftArray) ToDirectRedshiftArrayOutputWithContext(ctx context.Context) DirectRedshiftArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectRedshiftArrayOutput)
}

// DirectRedshiftMapInput is an input type that accepts DirectRedshiftMap and DirectRedshiftMapOutput values.
// You can construct a concrete instance of `DirectRedshiftMapInput` via:
//
//	DirectRedshiftMap{ "key": DirectRedshiftArgs{...} }
type DirectRedshiftMapInput interface {
	pulumi.Input

	ToDirectRedshiftMapOutput() DirectRedshiftMapOutput
	ToDirectRedshiftMapOutputWithContext(context.Context) DirectRedshiftMapOutput
}

type DirectRedshiftMap map[string]DirectRedshiftInput

func (DirectRedshiftMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectRedshift)(nil)).Elem()
}

func (i DirectRedshiftMap) ToDirectRedshiftMapOutput() DirectRedshiftMapOutput {
	return i.ToDirectRedshiftMapOutputWithContext(context.Background())
}

func (i DirectRedshiftMap) ToDirectRedshiftMapOutputWithContext(ctx context.Context) DirectRedshiftMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectRedshiftMapOutput)
}

type DirectRedshiftOutput struct{ *pulumi.OutputState }

func (DirectRedshiftOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectRedshift)(nil)).Elem()
}

func (o DirectRedshiftOutput) ToDirectRedshiftOutput() DirectRedshiftOutput {
	return o
}

func (o DirectRedshiftOutput) ToDirectRedshiftOutputWithContext(ctx context.Context) DirectRedshiftOutput {
	return o
}

// [required] | AWS Access Key ID.
func (o DirectRedshiftOutput) AccessKeyId() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.AccessKeyId }).(pulumi.StringOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectRedshiftOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectRedshiftOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectRedshiftOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectRedshiftOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectRedshiftOutput) QueryDelay() DirectRedshiftQueryDelayPtrOutput {
	return o.ApplyT(func(v *DirectRedshift) DirectRedshiftQueryDelayPtrOutput { return v.QueryDelay }).(DirectRedshiftQueryDelayPtrOutput)
}

// [required] | AWS Secret Access Key.
func (o DirectRedshiftOutput) SecretAccessKey() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.SecretAccessKey }).(pulumi.StringOutput)
}

// AWS Secret ARN.
func (o DirectRedshiftOutput) SecretArn() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.SecretArn }).(pulumi.StringOutput)
}

// Source of Metrics and/or Services.
func (o DirectRedshiftOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectRedshiftOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectRedshift) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectRedshiftArrayOutput struct{ *pulumi.OutputState }

func (DirectRedshiftArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectRedshift)(nil)).Elem()
}

func (o DirectRedshiftArrayOutput) ToDirectRedshiftArrayOutput() DirectRedshiftArrayOutput {
	return o
}

func (o DirectRedshiftArrayOutput) ToDirectRedshiftArrayOutputWithContext(ctx context.Context) DirectRedshiftArrayOutput {
	return o
}

func (o DirectRedshiftArrayOutput) Index(i pulumi.IntInput) DirectRedshiftOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectRedshift {
		return vs[0].([]*DirectRedshift)[vs[1].(int)]
	}).(DirectRedshiftOutput)
}

type DirectRedshiftMapOutput struct{ *pulumi.OutputState }

func (DirectRedshiftMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectRedshift)(nil)).Elem()
}

func (o DirectRedshiftMapOutput) ToDirectRedshiftMapOutput() DirectRedshiftMapOutput {
	return o
}

func (o DirectRedshiftMapOutput) ToDirectRedshiftMapOutputWithContext(ctx context.Context) DirectRedshiftMapOutput {
	return o
}

func (o DirectRedshiftMapOutput) MapIndex(k pulumi.StringInput) DirectRedshiftOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectRedshift {
		return vs[0].(map[string]*DirectRedshift)[vs[1].(string)]
	}).(DirectRedshiftOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectRedshiftInput)(nil)).Elem(), &DirectRedshift{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectRedshiftArrayInput)(nil)).Elem(), DirectRedshiftArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectRedshiftMapInput)(nil)).Elem(), DirectRedshiftMap{})
	pulumi.RegisterOutputType(DirectRedshiftOutput{})
	pulumi.RegisterOutputType(DirectRedshiftArrayOutput{})
	pulumi.RegisterOutputType(DirectRedshiftMapOutput{})
}
