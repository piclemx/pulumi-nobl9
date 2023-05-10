// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package nobl9

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// New Relic is a software solution that monitors performance and availability. It sets and rates application performance across the environment using a standardized Apdex (application performance index) score. Nobl9 connects with New Relic to collect SLI measurements and compare them to SLO targets.
//
// For more information, refer to [New Relic Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/new-relic#new-relic-direct).
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
//			_, err := nobl9.NewDirectNewrelic(ctx, "test-newrelic", &nobl9.DirectNewrelicArgs{
//				AccountId:   pulumi.Int(1234),
//				Description: pulumi.String("desc"),
//				HistoricalDataRetrieval: &DirectNewrelicHistoricalDataRetrievalArgs{
//					DefaultDurations: DirectNewrelicHistoricalDataRetrievalDefaultDurationArray{
//						&DirectNewrelicHistoricalDataRetrievalDefaultDurationArgs{
//							Unit:  pulumi.String("Day"),
//							Value: pulumi.Int(0),
//						},
//					},
//					MaxDurations: DirectNewrelicHistoricalDataRetrievalMaxDurationArray{
//						&DirectNewrelicHistoricalDataRetrievalMaxDurationArgs{
//							Unit:  pulumi.String("Day"),
//							Value: pulumi.Int(30),
//						},
//					},
//				},
//				InsightsQueryKey: pulumi.String("secret"),
//				Project:          pulumi.String("terraform"),
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
type DirectNewrelic struct {
	pulumi.CustomResourceState

	// ID number assigned to the New Relic user account.
	AccountId pulumi.IntOutput `pulumi:"accountId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectNewrelicHistoricalDataRetrievalPtrOutput `pulumi:"historicalDataRetrieval"`
	// [required] | New Relic Insights Query Key.
	InsightsQueryKey pulumi.StringOutput `pulumi:"insightsQueryKey"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectNewrelicQueryDelayPtrOutput `pulumi:"queryDelay"`
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectNewrelic registers a new resource with the given unique name, arguments, and options.
func NewDirectNewrelic(ctx *pulumi.Context,
	name string, args *DirectNewrelicArgs, opts ...pulumi.ResourceOption) (*DirectNewrelic, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.SourceOfs == nil {
		return nil, errors.New("invalid value for required argument 'SourceOfs'")
	}
	var resource DirectNewrelic
	err := ctx.RegisterResource("nobl9:index/directNewrelic:DirectNewrelic", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectNewrelic gets an existing DirectNewrelic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectNewrelic(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectNewrelicState, opts ...pulumi.ResourceOption) (*DirectNewrelic, error) {
	var resource DirectNewrelic
	err := ctx.ReadResource("nobl9:index/directNewrelic:DirectNewrelic", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectNewrelic resources.
type directNewrelicState struct {
	// ID number assigned to the New Relic user account.
	AccountId *int `pulumi:"accountId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectNewrelicHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// [required] | New Relic Insights Query Key.
	InsightsQueryKey *string `pulumi:"insightsQueryKey"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectNewrelicQueryDelay `pulumi:"queryDelay"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectNewrelicState struct {
	// ID number assigned to the New Relic user account.
	AccountId pulumi.IntPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectNewrelicHistoricalDataRetrievalPtrInput
	// [required] | New Relic Insights Query Key.
	InsightsQueryKey pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectNewrelicQueryDelayPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectNewrelicState) ElementType() reflect.Type {
	return reflect.TypeOf((*directNewrelicState)(nil)).Elem()
}

type directNewrelicArgs struct {
	// ID number assigned to the New Relic user account.
	AccountId int `pulumi:"accountId"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectNewrelicHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// [required] | New Relic Insights Query Key.
	InsightsQueryKey *string `pulumi:"insightsQueryKey"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectNewrelicQueryDelay `pulumi:"queryDelay"`
	// Source of Metrics and/or Services.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectNewrelic resource.
type DirectNewrelicArgs struct {
	// ID number assigned to the New Relic user account.
	AccountId pulumi.IntInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectNewrelicHistoricalDataRetrievalPtrInput
	// [required] | New Relic Insights Query Key.
	InsightsQueryKey pulumi.StringPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectNewrelicQueryDelayPtrInput
	// Source of Metrics and/or Services.
	SourceOfs pulumi.StringArrayInput
}

func (DirectNewrelicArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directNewrelicArgs)(nil)).Elem()
}

type DirectNewrelicInput interface {
	pulumi.Input

	ToDirectNewrelicOutput() DirectNewrelicOutput
	ToDirectNewrelicOutputWithContext(ctx context.Context) DirectNewrelicOutput
}

func (*DirectNewrelic) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectNewrelic)(nil)).Elem()
}

func (i *DirectNewrelic) ToDirectNewrelicOutput() DirectNewrelicOutput {
	return i.ToDirectNewrelicOutputWithContext(context.Background())
}

func (i *DirectNewrelic) ToDirectNewrelicOutputWithContext(ctx context.Context) DirectNewrelicOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectNewrelicOutput)
}

// DirectNewrelicArrayInput is an input type that accepts DirectNewrelicArray and DirectNewrelicArrayOutput values.
// You can construct a concrete instance of `DirectNewrelicArrayInput` via:
//
//	DirectNewrelicArray{ DirectNewrelicArgs{...} }
type DirectNewrelicArrayInput interface {
	pulumi.Input

	ToDirectNewrelicArrayOutput() DirectNewrelicArrayOutput
	ToDirectNewrelicArrayOutputWithContext(context.Context) DirectNewrelicArrayOutput
}

type DirectNewrelicArray []DirectNewrelicInput

func (DirectNewrelicArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectNewrelic)(nil)).Elem()
}

func (i DirectNewrelicArray) ToDirectNewrelicArrayOutput() DirectNewrelicArrayOutput {
	return i.ToDirectNewrelicArrayOutputWithContext(context.Background())
}

func (i DirectNewrelicArray) ToDirectNewrelicArrayOutputWithContext(ctx context.Context) DirectNewrelicArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectNewrelicArrayOutput)
}

// DirectNewrelicMapInput is an input type that accepts DirectNewrelicMap and DirectNewrelicMapOutput values.
// You can construct a concrete instance of `DirectNewrelicMapInput` via:
//
//	DirectNewrelicMap{ "key": DirectNewrelicArgs{...} }
type DirectNewrelicMapInput interface {
	pulumi.Input

	ToDirectNewrelicMapOutput() DirectNewrelicMapOutput
	ToDirectNewrelicMapOutputWithContext(context.Context) DirectNewrelicMapOutput
}

type DirectNewrelicMap map[string]DirectNewrelicInput

func (DirectNewrelicMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectNewrelic)(nil)).Elem()
}

func (i DirectNewrelicMap) ToDirectNewrelicMapOutput() DirectNewrelicMapOutput {
	return i.ToDirectNewrelicMapOutputWithContext(context.Background())
}

func (i DirectNewrelicMap) ToDirectNewrelicMapOutputWithContext(ctx context.Context) DirectNewrelicMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectNewrelicMapOutput)
}

type DirectNewrelicOutput struct{ *pulumi.OutputState }

func (DirectNewrelicOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectNewrelic)(nil)).Elem()
}

func (o DirectNewrelicOutput) ToDirectNewrelicOutput() DirectNewrelicOutput {
	return o
}

func (o DirectNewrelicOutput) ToDirectNewrelicOutputWithContext(ctx context.Context) DirectNewrelicOutput {
	return o
}

// ID number assigned to the New Relic user account.
func (o DirectNewrelicOutput) AccountId() pulumi.IntOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.IntOutput { return v.AccountId }).(pulumi.IntOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectNewrelicOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectNewrelicOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// [Replay configuration documentation](https://docs.nobl9.com/replay)
func (o DirectNewrelicOutput) HistoricalDataRetrieval() DirectNewrelicHistoricalDataRetrievalPtrOutput {
	return o.ApplyT(func(v *DirectNewrelic) DirectNewrelicHistoricalDataRetrievalPtrOutput {
		return v.HistoricalDataRetrieval
	}).(DirectNewrelicHistoricalDataRetrievalPtrOutput)
}

// [required] | New Relic Insights Query Key.
func (o DirectNewrelicOutput) InsightsQueryKey() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringOutput { return v.InsightsQueryKey }).(pulumi.StringOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectNewrelicOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectNewrelicOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectNewrelicOutput) QueryDelay() DirectNewrelicQueryDelayPtrOutput {
	return o.ApplyT(func(v *DirectNewrelic) DirectNewrelicQueryDelayPtrOutput { return v.QueryDelay }).(DirectNewrelicQueryDelayPtrOutput)
}

// Source of Metrics and/or Services.
func (o DirectNewrelicOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectNewrelicOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectNewrelic) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectNewrelicArrayOutput struct{ *pulumi.OutputState }

func (DirectNewrelicArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectNewrelic)(nil)).Elem()
}

func (o DirectNewrelicArrayOutput) ToDirectNewrelicArrayOutput() DirectNewrelicArrayOutput {
	return o
}

func (o DirectNewrelicArrayOutput) ToDirectNewrelicArrayOutputWithContext(ctx context.Context) DirectNewrelicArrayOutput {
	return o
}

func (o DirectNewrelicArrayOutput) Index(i pulumi.IntInput) DirectNewrelicOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectNewrelic {
		return vs[0].([]*DirectNewrelic)[vs[1].(int)]
	}).(DirectNewrelicOutput)
}

type DirectNewrelicMapOutput struct{ *pulumi.OutputState }

func (DirectNewrelicMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectNewrelic)(nil)).Elem()
}

func (o DirectNewrelicMapOutput) ToDirectNewrelicMapOutput() DirectNewrelicMapOutput {
	return o
}

func (o DirectNewrelicMapOutput) ToDirectNewrelicMapOutputWithContext(ctx context.Context) DirectNewrelicMapOutput {
	return o
}

func (o DirectNewrelicMapOutput) MapIndex(k pulumi.StringInput) DirectNewrelicOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectNewrelic {
		return vs[0].(map[string]*DirectNewrelic)[vs[1].(string)]
	}).(DirectNewrelicOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectNewrelicInput)(nil)).Elem(), &DirectNewrelic{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectNewrelicArrayInput)(nil)).Elem(), DirectNewrelicArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectNewrelicMapInput)(nil)).Elem(), DirectNewrelicMap{})
	pulumi.RegisterOutputType(DirectNewrelicOutput{})
	pulumi.RegisterOutputType(DirectNewrelicArrayOutput{})
	pulumi.RegisterOutputType(DirectNewrelicMapOutput{})
}
