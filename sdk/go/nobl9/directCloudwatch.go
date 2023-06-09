// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Amazon CloudWatch is a monitoring and observability service and a repository that aggregates data from more than 70 AWS data sources. CloudWatch also allows users to publish custom metrics from their services. Creating SLOs using this data is a powerful tool to monitor large portfolios of products. Nobl9 connects with Amazon CloudWatch to collect SLI measurements and compare them to SLO targets.
//
// For more information, refer to [Amazon CloudWatch Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cloudwatch-direct)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/piclemx/pulumi-nobl9/sdk/go/nobl9"
// 	"github.com/pulumi/pulumi-nobl9/sdk/go/nobl9"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := nobl9.NewDirectCloudwatch(ctx, "test-cloudwatch", &nobl9.DirectCloudwatchArgs{
// 			AccessKeyId: pulumi.String("secret"),
// 			Description: pulumi.String("desc"),
// 			HistoricalDataRetrieval: &DirectCloudwatchHistoricalDataRetrievalArgs{
// 				DefaultDurations: DirectCloudwatchHistoricalDataRetrievalDefaultDurationArray{
// 					&DirectCloudwatchHistoricalDataRetrievalDefaultDurationArgs{
// 						Unit:  pulumi.String("Day"),
// 						Value: pulumi.Int(0),
// 					},
// 				},
// 				MaxDurations: DirectCloudwatchHistoricalDataRetrievalMaxDurationArray{
// 					&DirectCloudwatchHistoricalDataRetrievalMaxDurationArgs{
// 						Unit:  pulumi.String("Day"),
// 						Value: pulumi.Int(15),
// 					},
// 				},
// 			},
// 			Project:         pulumi.String("terraform"),
// 			SecretAccessKey: pulumi.String("secret"),
// 			SourceOfs: pulumi.StringArray{
// 				pulumi.String("Metrics"),
// 				pulumi.String("Services"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
// ## Nobl9 Official Documentation
//
// https://docs.nobl9.com/
type DirectCloudwatch struct {
	pulumi.CustomResourceState

	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringOutput `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectCloudwatchHistoricalDataRetrievalPtrOutput `pulumi:"historicalDataRetrieval"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectCloudwatchQueryDelayPtrOutput `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringOutput `pulumi:"secretAccessKey"`
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectCloudwatch registers a new resource with the given unique name, arguments, and options.
func NewDirectCloudwatch(ctx *pulumi.Context,
	name string, args *DirectCloudwatchArgs, opts ...pulumi.ResourceOption) (*DirectCloudwatch, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.SourceOfs == nil {
		return nil, errors.New("invalid value for required argument 'SourceOfs'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource DirectCloudwatch
	err := ctx.RegisterResource("nobl9:index/directCloudwatch:DirectCloudwatch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectCloudwatch gets an existing DirectCloudwatch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectCloudwatch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectCloudwatchState, opts ...pulumi.ResourceOption) (*DirectCloudwatch, error) {
	var resource DirectCloudwatch
	err := ctx.ReadResource("nobl9:index/directCloudwatch:DirectCloudwatch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectCloudwatch resources.
type directCloudwatchState struct {
	// [required] | AWS Access Key ID.
	AccessKeyId *string `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectCloudwatchHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectCloudwatchQueryDelay `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey *string `pulumi:"secretAccessKey"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectCloudwatchState struct {
	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectCloudwatchHistoricalDataRetrievalPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectCloudwatchQueryDelayPtrInput
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectCloudwatchState) ElementType() reflect.Type {
	return reflect.TypeOf((*directCloudwatchState)(nil)).Elem()
}

type directCloudwatchArgs struct {
	// [required] | AWS Access Key ID.
	AccessKeyId *string `pulumi:"accessKeyId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectCloudwatchHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectCloudwatchQueryDelay `pulumi:"queryDelay"`
	// [required] | AWS Secret Access Key.
	SecretAccessKey *string `pulumi:"secretAccessKey"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectCloudwatch resource.
type DirectCloudwatchArgs struct {
	// [required] | AWS Access Key ID.
	AccessKeyId pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectCloudwatchHistoricalDataRetrievalPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectCloudwatchQueryDelayPtrInput
	// [required] | AWS Secret Access Key.
	SecretAccessKey pulumi.StringPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
}

func (DirectCloudwatchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directCloudwatchArgs)(nil)).Elem()
}

type DirectCloudwatchInput interface {
	pulumi.Input

	ToDirectCloudwatchOutput() DirectCloudwatchOutput
	ToDirectCloudwatchOutputWithContext(ctx context.Context) DirectCloudwatchOutput
}

func (*DirectCloudwatch) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectCloudwatch)(nil)).Elem()
}

func (i *DirectCloudwatch) ToDirectCloudwatchOutput() DirectCloudwatchOutput {
	return i.ToDirectCloudwatchOutputWithContext(context.Background())
}

func (i *DirectCloudwatch) ToDirectCloudwatchOutputWithContext(ctx context.Context) DirectCloudwatchOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectCloudwatchOutput)
}

// DirectCloudwatchArrayInput is an input type that accepts DirectCloudwatchArray and DirectCloudwatchArrayOutput values.
// You can construct a concrete instance of `DirectCloudwatchArrayInput` via:
//
//          DirectCloudwatchArray{ DirectCloudwatchArgs{...} }
type DirectCloudwatchArrayInput interface {
	pulumi.Input

	ToDirectCloudwatchArrayOutput() DirectCloudwatchArrayOutput
	ToDirectCloudwatchArrayOutputWithContext(context.Context) DirectCloudwatchArrayOutput
}

type DirectCloudwatchArray []DirectCloudwatchInput

func (DirectCloudwatchArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectCloudwatch)(nil)).Elem()
}

func (i DirectCloudwatchArray) ToDirectCloudwatchArrayOutput() DirectCloudwatchArrayOutput {
	return i.ToDirectCloudwatchArrayOutputWithContext(context.Background())
}

func (i DirectCloudwatchArray) ToDirectCloudwatchArrayOutputWithContext(ctx context.Context) DirectCloudwatchArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectCloudwatchArrayOutput)
}

// DirectCloudwatchMapInput is an input type that accepts DirectCloudwatchMap and DirectCloudwatchMapOutput values.
// You can construct a concrete instance of `DirectCloudwatchMapInput` via:
//
//          DirectCloudwatchMap{ "key": DirectCloudwatchArgs{...} }
type DirectCloudwatchMapInput interface {
	pulumi.Input

	ToDirectCloudwatchMapOutput() DirectCloudwatchMapOutput
	ToDirectCloudwatchMapOutputWithContext(context.Context) DirectCloudwatchMapOutput
}

type DirectCloudwatchMap map[string]DirectCloudwatchInput

func (DirectCloudwatchMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectCloudwatch)(nil)).Elem()
}

func (i DirectCloudwatchMap) ToDirectCloudwatchMapOutput() DirectCloudwatchMapOutput {
	return i.ToDirectCloudwatchMapOutputWithContext(context.Background())
}

func (i DirectCloudwatchMap) ToDirectCloudwatchMapOutputWithContext(ctx context.Context) DirectCloudwatchMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectCloudwatchMapOutput)
}

type DirectCloudwatchOutput struct{ *pulumi.OutputState }

func (DirectCloudwatchOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectCloudwatch)(nil)).Elem()
}

func (o DirectCloudwatchOutput) ToDirectCloudwatchOutput() DirectCloudwatchOutput {
	return o
}

func (o DirectCloudwatchOutput) ToDirectCloudwatchOutputWithContext(ctx context.Context) DirectCloudwatchOutput {
	return o
}

// [required] | AWS Access Key ID.
func (o DirectCloudwatchOutput) AccessKeyId() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringOutput { return v.AccessKeyId }).(pulumi.StringOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectCloudwatchOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectCloudwatchOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// [Replay configuration documentation](https://docs.nobl9.com/replay)
func (o DirectCloudwatchOutput) HistoricalDataRetrieval() DirectCloudwatchHistoricalDataRetrievalPtrOutput {
	return o.ApplyT(func(v *DirectCloudwatch) DirectCloudwatchHistoricalDataRetrievalPtrOutput {
		return v.HistoricalDataRetrieval
	}).(DirectCloudwatchHistoricalDataRetrievalPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectCloudwatchOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectCloudwatchOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectCloudwatchOutput) QueryDelay() DirectCloudwatchQueryDelayPtrOutput {
	return o.ApplyT(func(v *DirectCloudwatch) DirectCloudwatchQueryDelayPtrOutput { return v.QueryDelay }).(DirectCloudwatchQueryDelayPtrOutput)
}

// [required] | AWS Secret Access Key.
func (o DirectCloudwatchOutput) SecretAccessKey() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringOutput { return v.SecretAccessKey }).(pulumi.StringOutput)
}

// Source of Metrics and/or Services.
func (o DirectCloudwatchOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectCloudwatchOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectCloudwatch) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectCloudwatchArrayOutput struct{ *pulumi.OutputState }

func (DirectCloudwatchArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectCloudwatch)(nil)).Elem()
}

func (o DirectCloudwatchArrayOutput) ToDirectCloudwatchArrayOutput() DirectCloudwatchArrayOutput {
	return o
}

func (o DirectCloudwatchArrayOutput) ToDirectCloudwatchArrayOutputWithContext(ctx context.Context) DirectCloudwatchArrayOutput {
	return o
}

func (o DirectCloudwatchArrayOutput) Index(i pulumi.IntInput) DirectCloudwatchOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectCloudwatch {
		return vs[0].([]*DirectCloudwatch)[vs[1].(int)]
	}).(DirectCloudwatchOutput)
}

type DirectCloudwatchMapOutput struct{ *pulumi.OutputState }

func (DirectCloudwatchMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectCloudwatch)(nil)).Elem()
}

func (o DirectCloudwatchMapOutput) ToDirectCloudwatchMapOutput() DirectCloudwatchMapOutput {
	return o
}

func (o DirectCloudwatchMapOutput) ToDirectCloudwatchMapOutputWithContext(ctx context.Context) DirectCloudwatchMapOutput {
	return o
}

func (o DirectCloudwatchMapOutput) MapIndex(k pulumi.StringInput) DirectCloudwatchOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectCloudwatch {
		return vs[0].(map[string]*DirectCloudwatch)[vs[1].(string)]
	}).(DirectCloudwatchOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectCloudwatchInput)(nil)).Elem(), &DirectCloudwatch{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectCloudwatchArrayInput)(nil)).Elem(), DirectCloudwatchArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectCloudwatchMapInput)(nil)).Elem(), DirectCloudwatchMap{})
	pulumi.RegisterOutputType(DirectCloudwatchOutput{})
	pulumi.RegisterOutputType(DirectCloudwatchArrayOutput{})
	pulumi.RegisterOutputType(DirectCloudwatchMapOutput{})
}
