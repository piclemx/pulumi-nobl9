// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Google Cloud Monitoring (GCM) provides visibility into the performance, uptime, and overall health of cloud-powered applications. It collects metrics, events, and metadata from Google Cloud, hosted uptime probes, and application instrumentation. Nobl9 connects with GCM to collect SLI measurements and compare them to SLO targets.
//
// For more information, refer to [Google Cloud Monitoring Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/google-cloud-monitoring#google-cloud-monitoring-direct).
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
//			_, err := nobl9.NewDirectGcm(ctx, "test-gcm", &nobl9.DirectGcmArgs{
//				Description:       pulumi.String("desc"),
//				Project:           pulumi.String("terraform"),
//				ServiceAccountKey: pulumi.String("secret"),
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
type DirectGcm struct {
	pulumi.CustomResourceState

	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectGcmQueryDelayPtrOutput `pulumi:"queryDelay"`
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringOutput `pulumi:"serviceAccountKey"`
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectGcm registers a new resource with the given unique name, arguments, and options.
func NewDirectGcm(ctx *pulumi.Context,
	name string, args *DirectGcmArgs, opts ...pulumi.ResourceOption) (*DirectGcm, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.SourceOfs == nil {
		return nil, errors.New("invalid value for required argument 'SourceOfs'")
	}
	var resource DirectGcm
	err := ctx.RegisterResource("nobl9:index/directGcm:DirectGcm", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectGcm gets an existing DirectGcm resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectGcm(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectGcmState, opts ...pulumi.ResourceOption) (*DirectGcm, error) {
	var resource DirectGcm
	err := ctx.ReadResource("nobl9:index/directGcm:DirectGcm", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectGcm resources.
type directGcmState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectGcmQueryDelay `pulumi:"queryDelay"`
	// [required] | Service Account Key.
	ServiceAccountKey *string `pulumi:"serviceAccountKey"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectGcmState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectGcmQueryDelayPtrInput
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectGcmState) ElementType() reflect.Type {
	return reflect.TypeOf((*directGcmState)(nil)).Elem()
}

type directGcmArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectGcmQueryDelay `pulumi:"queryDelay"`
	// [required] | Service Account Key.
	ServiceAccountKey *string `pulumi:"serviceAccountKey"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectGcm resource.
type DirectGcmArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectGcmQueryDelayPtrInput
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
}

func (DirectGcmArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directGcmArgs)(nil)).Elem()
}

type DirectGcmInput interface {
	pulumi.Input

	ToDirectGcmOutput() DirectGcmOutput
	ToDirectGcmOutputWithContext(ctx context.Context) DirectGcmOutput
}

func (*DirectGcm) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectGcm)(nil)).Elem()
}

func (i *DirectGcm) ToDirectGcmOutput() DirectGcmOutput {
	return i.ToDirectGcmOutputWithContext(context.Background())
}

func (i *DirectGcm) ToDirectGcmOutputWithContext(ctx context.Context) DirectGcmOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectGcmOutput)
}

// DirectGcmArrayInput is an input type that accepts DirectGcmArray and DirectGcmArrayOutput values.
// You can construct a concrete instance of `DirectGcmArrayInput` via:
//
//	DirectGcmArray{ DirectGcmArgs{...} }
type DirectGcmArrayInput interface {
	pulumi.Input

	ToDirectGcmArrayOutput() DirectGcmArrayOutput
	ToDirectGcmArrayOutputWithContext(context.Context) DirectGcmArrayOutput
}

type DirectGcmArray []DirectGcmInput

func (DirectGcmArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectGcm)(nil)).Elem()
}

func (i DirectGcmArray) ToDirectGcmArrayOutput() DirectGcmArrayOutput {
	return i.ToDirectGcmArrayOutputWithContext(context.Background())
}

func (i DirectGcmArray) ToDirectGcmArrayOutputWithContext(ctx context.Context) DirectGcmArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectGcmArrayOutput)
}

// DirectGcmMapInput is an input type that accepts DirectGcmMap and DirectGcmMapOutput values.
// You can construct a concrete instance of `DirectGcmMapInput` via:
//
//	DirectGcmMap{ "key": DirectGcmArgs{...} }
type DirectGcmMapInput interface {
	pulumi.Input

	ToDirectGcmMapOutput() DirectGcmMapOutput
	ToDirectGcmMapOutputWithContext(context.Context) DirectGcmMapOutput
}

type DirectGcmMap map[string]DirectGcmInput

func (DirectGcmMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectGcm)(nil)).Elem()
}

func (i DirectGcmMap) ToDirectGcmMapOutput() DirectGcmMapOutput {
	return i.ToDirectGcmMapOutputWithContext(context.Background())
}

func (i DirectGcmMap) ToDirectGcmMapOutputWithContext(ctx context.Context) DirectGcmMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectGcmMapOutput)
}

type DirectGcmOutput struct{ *pulumi.OutputState }

func (DirectGcmOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectGcm)(nil)).Elem()
}

func (o DirectGcmOutput) ToDirectGcmOutput() DirectGcmOutput {
	return o
}

func (o DirectGcmOutput) ToDirectGcmOutputWithContext(ctx context.Context) DirectGcmOutput {
	return o
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectGcmOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectGcmOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectGcmOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectGcmOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectGcmOutput) QueryDelay() DirectGcmQueryDelayPtrOutput {
	return o.ApplyT(func(v *DirectGcm) DirectGcmQueryDelayPtrOutput { return v.QueryDelay }).(DirectGcmQueryDelayPtrOutput)
}

// [required] | Service Account Key.
func (o DirectGcmOutput) ServiceAccountKey() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringOutput { return v.ServiceAccountKey }).(pulumi.StringOutput)
}

// Source of Metrics and/or Services.
func (o DirectGcmOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectGcmOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectGcm) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectGcmArrayOutput struct{ *pulumi.OutputState }

func (DirectGcmArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectGcm)(nil)).Elem()
}

func (o DirectGcmArrayOutput) ToDirectGcmArrayOutput() DirectGcmArrayOutput {
	return o
}

func (o DirectGcmArrayOutput) ToDirectGcmArrayOutputWithContext(ctx context.Context) DirectGcmArrayOutput {
	return o
}

func (o DirectGcmArrayOutput) Index(i pulumi.IntInput) DirectGcmOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectGcm {
		return vs[0].([]*DirectGcm)[vs[1].(int)]
	}).(DirectGcmOutput)
}

type DirectGcmMapOutput struct{ *pulumi.OutputState }

func (DirectGcmMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectGcm)(nil)).Elem()
}

func (o DirectGcmMapOutput) ToDirectGcmMapOutput() DirectGcmMapOutput {
	return o
}

func (o DirectGcmMapOutput) ToDirectGcmMapOutputWithContext(ctx context.Context) DirectGcmMapOutput {
	return o
}

func (o DirectGcmMapOutput) MapIndex(k pulumi.StringInput) DirectGcmOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectGcm {
		return vs[0].(map[string]*DirectGcm)[vs[1].(string)]
	}).(DirectGcmOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectGcmInput)(nil)).Elem(), &DirectGcm{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectGcmArrayInput)(nil)).Elem(), DirectGcmArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectGcmMapInput)(nil)).Elem(), DirectGcmMap{})
	pulumi.RegisterOutputType(DirectGcmOutput{})
	pulumi.RegisterOutputType(DirectGcmArrayOutput{})
	pulumi.RegisterOutputType(DirectGcmMapOutput{})
}
