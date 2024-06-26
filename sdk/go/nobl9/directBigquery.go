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

// Google BigQuery is a serverless data warehouse that enables scalable analysis over petabytes of data. It is a Platform as a Service that supports querying using ANSI SQL. BigQuery integration with Nobl9 enables users to turn their big data into valuable business insights. Nobl9 connects to BigQuery for SLI measurement collection and comparison with SLO targets.
//
// For more information, refer to [BigQuery Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/bigquery#bigquery-direct)
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
//			_, err := nobl9.NewDirectBigquery(ctx, "test-bigquery", &nobl9.DirectBigqueryArgs{
//				Description:          pulumi.String("desc"),
//				LogCollectionEnabled: pulumi.Bool(true),
//				Project:              pulumi.String("terraform"),
//				ServiceAccountKey:    pulumi.String("secret"),
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
type DirectBigquery struct {
	pulumi.CustomResourceState

	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrOutput `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectBigqueryQueryDelayOutput `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringOutput `pulumi:"releaseChannel"`
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringOutput `pulumi:"serviceAccountKey"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewDirectBigquery registers a new resource with the given unique name, arguments, and options.
func NewDirectBigquery(ctx *pulumi.Context,
	name string, args *DirectBigqueryArgs, opts ...pulumi.ResourceOption) (*DirectBigquery, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.ServiceAccountKey != nil {
		args.ServiceAccountKey = pulumi.ToSecret(args.ServiceAccountKey).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"serviceAccountKey",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DirectBigquery
	err := ctx.RegisterResource("nobl9:index/directBigquery:DirectBigquery", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectBigquery gets an existing DirectBigquery resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectBigquery(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectBigqueryState, opts ...pulumi.ResourceOption) (*DirectBigquery, error) {
	var resource DirectBigquery
	err := ctx.ReadResource("nobl9:index/directBigquery:DirectBigquery", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectBigquery resources.
type directBigqueryState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectBigqueryQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// [required] | Service Account Key.
	ServiceAccountKey *string `pulumi:"serviceAccountKey"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
}

type DirectBigqueryState struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectBigqueryQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
}

func (DirectBigqueryState) ElementType() reflect.Type {
	return reflect.TypeOf((*directBigqueryState)(nil)).Elem()
}

type directBigqueryArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectBigqueryQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// [required] | Service Account Key.
	ServiceAccountKey *string `pulumi:"serviceAccountKey"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
}

// The set of arguments for constructing a DirectBigquery resource.
type DirectBigqueryArgs struct {
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectBigqueryQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// [required] | Service Account Key.
	ServiceAccountKey pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
}

func (DirectBigqueryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directBigqueryArgs)(nil)).Elem()
}

type DirectBigqueryInput interface {
	pulumi.Input

	ToDirectBigqueryOutput() DirectBigqueryOutput
	ToDirectBigqueryOutputWithContext(ctx context.Context) DirectBigqueryOutput
}

func (*DirectBigquery) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectBigquery)(nil)).Elem()
}

func (i *DirectBigquery) ToDirectBigqueryOutput() DirectBigqueryOutput {
	return i.ToDirectBigqueryOutputWithContext(context.Background())
}

func (i *DirectBigquery) ToDirectBigqueryOutputWithContext(ctx context.Context) DirectBigqueryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectBigqueryOutput)
}

// DirectBigqueryArrayInput is an input type that accepts DirectBigqueryArray and DirectBigqueryArrayOutput values.
// You can construct a concrete instance of `DirectBigqueryArrayInput` via:
//
//	DirectBigqueryArray{ DirectBigqueryArgs{...} }
type DirectBigqueryArrayInput interface {
	pulumi.Input

	ToDirectBigqueryArrayOutput() DirectBigqueryArrayOutput
	ToDirectBigqueryArrayOutputWithContext(context.Context) DirectBigqueryArrayOutput
}

type DirectBigqueryArray []DirectBigqueryInput

func (DirectBigqueryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectBigquery)(nil)).Elem()
}

func (i DirectBigqueryArray) ToDirectBigqueryArrayOutput() DirectBigqueryArrayOutput {
	return i.ToDirectBigqueryArrayOutputWithContext(context.Background())
}

func (i DirectBigqueryArray) ToDirectBigqueryArrayOutputWithContext(ctx context.Context) DirectBigqueryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectBigqueryArrayOutput)
}

// DirectBigqueryMapInput is an input type that accepts DirectBigqueryMap and DirectBigqueryMapOutput values.
// You can construct a concrete instance of `DirectBigqueryMapInput` via:
//
//	DirectBigqueryMap{ "key": DirectBigqueryArgs{...} }
type DirectBigqueryMapInput interface {
	pulumi.Input

	ToDirectBigqueryMapOutput() DirectBigqueryMapOutput
	ToDirectBigqueryMapOutputWithContext(context.Context) DirectBigqueryMapOutput
}

type DirectBigqueryMap map[string]DirectBigqueryInput

func (DirectBigqueryMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectBigquery)(nil)).Elem()
}

func (i DirectBigqueryMap) ToDirectBigqueryMapOutput() DirectBigqueryMapOutput {
	return i.ToDirectBigqueryMapOutputWithContext(context.Background())
}

func (i DirectBigqueryMap) ToDirectBigqueryMapOutputWithContext(ctx context.Context) DirectBigqueryMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectBigqueryMapOutput)
}

type DirectBigqueryOutput struct{ *pulumi.OutputState }

func (DirectBigqueryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectBigquery)(nil)).Elem()
}

func (o DirectBigqueryOutput) ToDirectBigqueryOutput() DirectBigqueryOutput {
	return o
}

func (o DirectBigqueryOutput) ToDirectBigqueryOutputWithContext(ctx context.Context) DirectBigqueryOutput {
	return o
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectBigqueryOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectBigqueryOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
func (o DirectBigqueryOutput) LogCollectionEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.BoolPtrOutput { return v.LogCollectionEnabled }).(pulumi.BoolPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectBigqueryOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectBigqueryOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectBigqueryOutput) QueryDelay() DirectBigqueryQueryDelayOutput {
	return o.ApplyT(func(v *DirectBigquery) DirectBigqueryQueryDelayOutput { return v.QueryDelay }).(DirectBigqueryQueryDelayOutput)
}

// Release channel of the created datasource [stable/beta]
func (o DirectBigqueryOutput) ReleaseChannel() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringOutput { return v.ReleaseChannel }).(pulumi.StringOutput)
}

// [required] | Service Account Key.
func (o DirectBigqueryOutput) ServiceAccountKey() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringOutput { return v.ServiceAccountKey }).(pulumi.StringOutput)
}

// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
//
// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
func (o DirectBigqueryOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectBigqueryOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectBigquery) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type DirectBigqueryArrayOutput struct{ *pulumi.OutputState }

func (DirectBigqueryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectBigquery)(nil)).Elem()
}

func (o DirectBigqueryArrayOutput) ToDirectBigqueryArrayOutput() DirectBigqueryArrayOutput {
	return o
}

func (o DirectBigqueryArrayOutput) ToDirectBigqueryArrayOutputWithContext(ctx context.Context) DirectBigqueryArrayOutput {
	return o
}

func (o DirectBigqueryArrayOutput) Index(i pulumi.IntInput) DirectBigqueryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectBigquery {
		return vs[0].([]*DirectBigquery)[vs[1].(int)]
	}).(DirectBigqueryOutput)
}

type DirectBigqueryMapOutput struct{ *pulumi.OutputState }

func (DirectBigqueryMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectBigquery)(nil)).Elem()
}

func (o DirectBigqueryMapOutput) ToDirectBigqueryMapOutput() DirectBigqueryMapOutput {
	return o
}

func (o DirectBigqueryMapOutput) ToDirectBigqueryMapOutputWithContext(ctx context.Context) DirectBigqueryMapOutput {
	return o
}

func (o DirectBigqueryMapOutput) MapIndex(k pulumi.StringInput) DirectBigqueryOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectBigquery {
		return vs[0].(map[string]*DirectBigquery)[vs[1].(string)]
	}).(DirectBigqueryOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectBigqueryInput)(nil)).Elem(), &DirectBigquery{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectBigqueryArrayInput)(nil)).Elem(), DirectBigqueryArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectBigqueryMapInput)(nil)).Elem(), DirectBigqueryMap{})
	pulumi.RegisterOutputType(DirectBigqueryOutput{})
	pulumi.RegisterOutputType(DirectBigqueryArrayOutput{})
	pulumi.RegisterOutputType(DirectBigqueryMapOutput{})
}
