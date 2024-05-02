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

// AppDynamics is a performance management program for applications. It helps users to gain a comprehensive understanding of the impact of technical difficulties on business goals, allowing IT teams to prioritize their efforts in a way that improves ROI. Nobl9 connects to AppDynamics for SLI measurement collection and comparison with SLO targets.
//
// For more information, refer to [AppDynamics Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/appdynamics#appdynamics-direct)
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
//			_, err := nobl9.NewDirectAppdynamics(ctx, "test-appdynamics", &nobl9.DirectAppdynamicsArgs{
//				AccountName:          pulumi.String("account name"),
//				ClientName:           pulumi.String("client name"),
//				ClientSecret:         pulumi.String("secret"),
//				Description:          pulumi.String("desc"),
//				LogCollectionEnabled: pulumi.Bool(true),
//				Project:              pulumi.String("terraform"),
//				ReleaseChannel:       pulumi.String("stable"),
//				Url:                  pulumi.String("https://web.net"),
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
type DirectAppdynamics struct {
	pulumi.CustomResourceState

	// AppDynamics Account Name.
	AccountName pulumi.StringOutput `pulumi:"accountName"`
	// AppDynamics Client ID.
	ClientId pulumi.StringOutput `pulumi:"clientId"`
	// AppDynamics Client Name.
	ClientName pulumi.StringOutput `pulumi:"clientName"`
	// [required] | AppDynamics Client Secret.
	ClientSecret pulumi.StringOutput `pulumi:"clientSecret"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectAppdynamicsHistoricalDataRetrievalOutput `pulumi:"historicalDataRetrieval"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrOutput `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringOutput `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringOutput `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectAppdynamicsQueryDelayOutput `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringOutput `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayOutput `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status pulumi.StringOutput `pulumi:"status"`
	// Base URL to the AppDynamics Controller.
	Url pulumi.StringOutput `pulumi:"url"`
}

// NewDirectAppdynamics registers a new resource with the given unique name, arguments, and options.
func NewDirectAppdynamics(ctx *pulumi.Context,
	name string, args *DirectAppdynamicsArgs, opts ...pulumi.ResourceOption) (*DirectAppdynamics, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountName == nil {
		return nil, errors.New("invalid value for required argument 'AccountName'")
	}
	if args.ClientName == nil {
		return nil, errors.New("invalid value for required argument 'ClientName'")
	}
	if args.Project == nil {
		return nil, errors.New("invalid value for required argument 'Project'")
	}
	if args.Url == nil {
		return nil, errors.New("invalid value for required argument 'Url'")
	}
	if args.ClientSecret != nil {
		args.ClientSecret = pulumi.ToSecret(args.ClientSecret).(pulumi.StringPtrInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"clientSecret",
	})
	opts = append(opts, secrets)
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource DirectAppdynamics
	err := ctx.RegisterResource("nobl9:index/directAppdynamics:DirectAppdynamics", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDirectAppdynamics gets an existing DirectAppdynamics resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDirectAppdynamics(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DirectAppdynamicsState, opts ...pulumi.ResourceOption) (*DirectAppdynamics, error) {
	var resource DirectAppdynamics
	err := ctx.ReadResource("nobl9:index/directAppdynamics:DirectAppdynamics", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DirectAppdynamics resources.
type directAppdynamicsState struct {
	// AppDynamics Account Name.
	AccountName *string `pulumi:"accountName"`
	// AppDynamics Client ID.
	ClientId *string `pulumi:"clientId"`
	// AppDynamics Client Name.
	ClientName *string `pulumi:"clientName"`
	// [required] | AppDynamics Client Secret.
	ClientSecret *string `pulumi:"clientSecret"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectAppdynamicsHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project *string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectAppdynamicsQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
	// The status of the created direct.
	Status *string `pulumi:"status"`
	// Base URL to the AppDynamics Controller.
	Url *string `pulumi:"url"`
}

type DirectAppdynamicsState struct {
	// AppDynamics Account Name.
	AccountName pulumi.StringPtrInput
	// AppDynamics Client ID.
	ClientId pulumi.StringPtrInput
	// AppDynamics Client Name.
	ClientName pulumi.StringPtrInput
	// [required] | AppDynamics Client Secret.
	ClientSecret pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectAppdynamicsHistoricalDataRetrievalPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringPtrInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectAppdynamicsQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
	// The status of the created direct.
	Status pulumi.StringPtrInput
	// Base URL to the AppDynamics Controller.
	Url pulumi.StringPtrInput
}

func (DirectAppdynamicsState) ElementType() reflect.Type {
	return reflect.TypeOf((*directAppdynamicsState)(nil)).Elem()
}

type directAppdynamicsArgs struct {
	// AppDynamics Account Name.
	AccountName string `pulumi:"accountName"`
	// AppDynamics Client Name.
	ClientName string `pulumi:"clientName"`
	// [required] | AppDynamics Client Secret.
	ClientSecret *string `pulumi:"clientSecret"`
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description *string `pulumi:"description"`
	// User-friendly display name of the resource.
	DisplayName *string `pulumi:"displayName"`
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval *DirectAppdynamicsHistoricalDataRetrieval `pulumi:"historicalDataRetrieval"`
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled *bool `pulumi:"logCollectionEnabled"`
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name *string `pulumi:"name"`
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project string `pulumi:"project"`
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay *DirectAppdynamicsQueryDelay `pulumi:"queryDelay"`
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel *string `pulumi:"releaseChannel"`
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs []string `pulumi:"sourceOfs"`
	// Base URL to the AppDynamics Controller.
	Url string `pulumi:"url"`
}

// The set of arguments for constructing a DirectAppdynamics resource.
type DirectAppdynamicsArgs struct {
	// AppDynamics Account Name.
	AccountName pulumi.StringInput
	// AppDynamics Client Name.
	ClientName pulumi.StringInput
	// [required] | AppDynamics Client Secret.
	ClientSecret pulumi.StringPtrInput
	// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
	Description pulumi.StringPtrInput
	// User-friendly display name of the resource.
	DisplayName pulumi.StringPtrInput
	// [Replay configuration documentation](https://docs.nobl9.com/replay)
	HistoricalDataRetrieval DirectAppdynamicsHistoricalDataRetrievalPtrInput
	// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
	LogCollectionEnabled pulumi.BoolPtrInput
	// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Name pulumi.StringPtrInput
	// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
	Project pulumi.StringInput
	// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
	QueryDelay DirectAppdynamicsQueryDelayPtrInput
	// Release channel of the created datasource [stable/beta]
	ReleaseChannel pulumi.StringPtrInput
	// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
	//
	// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
	SourceOfs pulumi.StringArrayInput
	// Base URL to the AppDynamics Controller.
	Url pulumi.StringInput
}

func (DirectAppdynamicsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*directAppdynamicsArgs)(nil)).Elem()
}

type DirectAppdynamicsInput interface {
	pulumi.Input

	ToDirectAppdynamicsOutput() DirectAppdynamicsOutput
	ToDirectAppdynamicsOutputWithContext(ctx context.Context) DirectAppdynamicsOutput
}

func (*DirectAppdynamics) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectAppdynamics)(nil)).Elem()
}

func (i *DirectAppdynamics) ToDirectAppdynamicsOutput() DirectAppdynamicsOutput {
	return i.ToDirectAppdynamicsOutputWithContext(context.Background())
}

func (i *DirectAppdynamics) ToDirectAppdynamicsOutputWithContext(ctx context.Context) DirectAppdynamicsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectAppdynamicsOutput)
}

// DirectAppdynamicsArrayInput is an input type that accepts DirectAppdynamicsArray and DirectAppdynamicsArrayOutput values.
// You can construct a concrete instance of `DirectAppdynamicsArrayInput` via:
//
//	DirectAppdynamicsArray{ DirectAppdynamicsArgs{...} }
type DirectAppdynamicsArrayInput interface {
	pulumi.Input

	ToDirectAppdynamicsArrayOutput() DirectAppdynamicsArrayOutput
	ToDirectAppdynamicsArrayOutputWithContext(context.Context) DirectAppdynamicsArrayOutput
}

type DirectAppdynamicsArray []DirectAppdynamicsInput

func (DirectAppdynamicsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectAppdynamics)(nil)).Elem()
}

func (i DirectAppdynamicsArray) ToDirectAppdynamicsArrayOutput() DirectAppdynamicsArrayOutput {
	return i.ToDirectAppdynamicsArrayOutputWithContext(context.Background())
}

func (i DirectAppdynamicsArray) ToDirectAppdynamicsArrayOutputWithContext(ctx context.Context) DirectAppdynamicsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectAppdynamicsArrayOutput)
}

// DirectAppdynamicsMapInput is an input type that accepts DirectAppdynamicsMap and DirectAppdynamicsMapOutput values.
// You can construct a concrete instance of `DirectAppdynamicsMapInput` via:
//
//	DirectAppdynamicsMap{ "key": DirectAppdynamicsArgs{...} }
type DirectAppdynamicsMapInput interface {
	pulumi.Input

	ToDirectAppdynamicsMapOutput() DirectAppdynamicsMapOutput
	ToDirectAppdynamicsMapOutputWithContext(context.Context) DirectAppdynamicsMapOutput
}

type DirectAppdynamicsMap map[string]DirectAppdynamicsInput

func (DirectAppdynamicsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectAppdynamics)(nil)).Elem()
}

func (i DirectAppdynamicsMap) ToDirectAppdynamicsMapOutput() DirectAppdynamicsMapOutput {
	return i.ToDirectAppdynamicsMapOutputWithContext(context.Background())
}

func (i DirectAppdynamicsMap) ToDirectAppdynamicsMapOutputWithContext(ctx context.Context) DirectAppdynamicsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectAppdynamicsMapOutput)
}

type DirectAppdynamicsOutput struct{ *pulumi.OutputState }

func (DirectAppdynamicsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectAppdynamics)(nil)).Elem()
}

func (o DirectAppdynamicsOutput) ToDirectAppdynamicsOutput() DirectAppdynamicsOutput {
	return o
}

func (o DirectAppdynamicsOutput) ToDirectAppdynamicsOutputWithContext(ctx context.Context) DirectAppdynamicsOutput {
	return o
}

// AppDynamics Account Name.
func (o DirectAppdynamicsOutput) AccountName() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.AccountName }).(pulumi.StringOutput)
}

// AppDynamics Client ID.
func (o DirectAppdynamicsOutput) ClientId() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.ClientId }).(pulumi.StringOutput)
}

// AppDynamics Client Name.
func (o DirectAppdynamicsOutput) ClientName() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.ClientName }).(pulumi.StringOutput)
}

// [required] | AppDynamics Client Secret.
func (o DirectAppdynamicsOutput) ClientSecret() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.ClientSecret }).(pulumi.StringOutput)
}

// Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
func (o DirectAppdynamicsOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// User-friendly display name of the resource.
func (o DirectAppdynamicsOutput) DisplayName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringPtrOutput { return v.DisplayName }).(pulumi.StringPtrOutput)
}

// [Replay configuration documentation](https://docs.nobl9.com/replay)
func (o DirectAppdynamicsOutput) HistoricalDataRetrieval() DirectAppdynamicsHistoricalDataRetrievalOutput {
	return o.ApplyT(func(v *DirectAppdynamics) DirectAppdynamicsHistoricalDataRetrievalOutput {
		return v.HistoricalDataRetrieval
	}).(DirectAppdynamicsHistoricalDataRetrievalOutput)
}

// [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
func (o DirectAppdynamicsOutput) LogCollectionEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.BoolPtrOutput { return v.LogCollectionEnabled }).(pulumi.BoolPtrOutput)
}

// Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectAppdynamicsOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
func (o DirectAppdynamicsOutput) Project() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.Project }).(pulumi.StringOutput)
}

// [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
func (o DirectAppdynamicsOutput) QueryDelay() DirectAppdynamicsQueryDelayOutput {
	return o.ApplyT(func(v *DirectAppdynamics) DirectAppdynamicsQueryDelayOutput { return v.QueryDelay }).(DirectAppdynamicsQueryDelayOutput)
}

// Release channel of the created datasource [stable/beta]
func (o DirectAppdynamicsOutput) ReleaseChannel() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.ReleaseChannel }).(pulumi.StringOutput)
}

// This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
//
// Deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.
func (o DirectAppdynamicsOutput) SourceOfs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringArrayOutput { return v.SourceOfs }).(pulumi.StringArrayOutput)
}

// The status of the created direct.
func (o DirectAppdynamicsOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

// Base URL to the AppDynamics Controller.
func (o DirectAppdynamicsOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v *DirectAppdynamics) pulumi.StringOutput { return v.Url }).(pulumi.StringOutput)
}

type DirectAppdynamicsArrayOutput struct{ *pulumi.OutputState }

func (DirectAppdynamicsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DirectAppdynamics)(nil)).Elem()
}

func (o DirectAppdynamicsArrayOutput) ToDirectAppdynamicsArrayOutput() DirectAppdynamicsArrayOutput {
	return o
}

func (o DirectAppdynamicsArrayOutput) ToDirectAppdynamicsArrayOutputWithContext(ctx context.Context) DirectAppdynamicsArrayOutput {
	return o
}

func (o DirectAppdynamicsArrayOutput) Index(i pulumi.IntInput) DirectAppdynamicsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DirectAppdynamics {
		return vs[0].([]*DirectAppdynamics)[vs[1].(int)]
	}).(DirectAppdynamicsOutput)
}

type DirectAppdynamicsMapOutput struct{ *pulumi.OutputState }

func (DirectAppdynamicsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DirectAppdynamics)(nil)).Elem()
}

func (o DirectAppdynamicsMapOutput) ToDirectAppdynamicsMapOutput() DirectAppdynamicsMapOutput {
	return o
}

func (o DirectAppdynamicsMapOutput) ToDirectAppdynamicsMapOutputWithContext(ctx context.Context) DirectAppdynamicsMapOutput {
	return o
}

func (o DirectAppdynamicsMapOutput) MapIndex(k pulumi.StringInput) DirectAppdynamicsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DirectAppdynamics {
		return vs[0].(map[string]*DirectAppdynamics)[vs[1].(string)]
	}).(DirectAppdynamicsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DirectAppdynamicsInput)(nil)).Elem(), &DirectAppdynamics{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectAppdynamicsArrayInput)(nil)).Elem(), DirectAppdynamicsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DirectAppdynamicsMapInput)(nil)).Elem(), DirectAppdynamicsMap{})
	pulumi.RegisterOutputType(DirectAppdynamicsOutput{})
	pulumi.RegisterOutputType(DirectAppdynamicsArrayOutput{})
	pulumi.RegisterOutputType(DirectAppdynamicsMapOutput{})
}
