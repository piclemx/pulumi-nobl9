// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9
{
    public static class GetAwsIamRoleExternalId
    {
        /// <summary>
        /// Returns external ID and AWS account ID that can be used to create [cross-account IAM roles in AWS](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cross-account-iam-roles-new).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nobl9 = Pulumi.Nobl9;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Nobl9.GetAwsIamRoleExternalId.Invoke(new()
        ///     {
        ///         Name = "my-datasource-name",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAwsIamRoleExternalIdResult> InvokeAsync(GetAwsIamRoleExternalIdArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAwsIamRoleExternalIdResult>("nobl9:index/getAwsIamRoleExternalId:getAwsIamRoleExternalId", args ?? new GetAwsIamRoleExternalIdArgs(), options.WithDefaults());

        /// <summary>
        /// Returns external ID and AWS account ID that can be used to create [cross-account IAM roles in AWS](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cross-account-iam-roles-new).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Nobl9 = Pulumi.Nobl9;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Nobl9.GetAwsIamRoleExternalId.Invoke(new()
        ///     {
        ///         Name = "my-datasource-name",
        ///     });
        /// 
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAwsIamRoleExternalIdResult> Invoke(GetAwsIamRoleExternalIdInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAwsIamRoleExternalIdResult>("nobl9:index/getAwsIamRoleExternalId:getAwsIamRoleExternalId", args ?? new GetAwsIamRoleExternalIdInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAwsIamRoleExternalIdArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Data source name
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetAwsIamRoleExternalIdArgs()
        {
        }
        public static new GetAwsIamRoleExternalIdArgs Empty => new GetAwsIamRoleExternalIdArgs();
    }

    public sealed class GetAwsIamRoleExternalIdInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Data source name
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetAwsIamRoleExternalIdInvokeArgs()
        {
        }
        public static new GetAwsIamRoleExternalIdInvokeArgs Empty => new GetAwsIamRoleExternalIdInvokeArgs();
    }


    [OutputType]
    public sealed class GetAwsIamRoleExternalIdResult
    {
        /// <summary>
        /// External ID
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// Nobl9 AWS Account ID
        /// </summary>
        public readonly string ExternalId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Data source name
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetAwsIamRoleExternalIdResult(
            string accountId,

            string externalId,

            string id,

            string name)
        {
            AccountId = accountId;
            ExternalId = externalId;
            Id = id;
            Name = name;
        }
    }
}
