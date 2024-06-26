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
    /// <summary>
    /// ## Example Usage
    /// 
    /// Here's an example of RBAC resource configuration:
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Nobl9 = Piclemx.Nobl9;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var @this = new Nobl9.RoleBinding("this", new()
    ///     {
    ///         GroupRef = "test",
    ///         ProjectRef = "default",
    ///         RoleRef = "project-owner",
    ///     });
    /// 
    /// });
    /// ```
    /// ## Useful Links
    /// 
    /// [Role Based Access Control in Nobl9 | Nobl9 Documentation](https://docs.nobl9.com/Getting_Started/RBAC/)
    /// 
    /// [Role Binding YAML Configuration | Nobl9 Documentation](https://docs.nobl9.com/Getting_Started/RBAC/role-binding-yaml)
    /// </summary>
    [Nobl9ResourceType("nobl9:index/roleBinding:RoleBinding")]
    public partial class RoleBinding : global::Pulumi.CustomResource
    {
        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Group name that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Groups**) or using sloctl `get usergroups` command.
        /// </summary>
        [Output("groupRef")]
        public Output<string?> GroupRef { get; private set; } = null!;

        /// <summary>
        /// Automatically generated, unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Project name, the project in which we want the user or group to assume the specified role. When `project_ref` is empty, `role_ref` must contain an Organization Role.
        /// </summary>
        [Output("projectRef")]
        public Output<string?> ProjectRef { get; private set; } = null!;

        /// <summary>
        /// Role name; the role that you want the user or group to assume.
        /// </summary>
        [Output("roleRef")]
        public Output<string> RoleRef { get; private set; } = null!;

        /// <summary>
        /// Okta User ID that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Users**).
        /// </summary>
        [Output("user")]
        public Output<string?> User { get; private set; } = null!;


        /// <summary>
        /// Create a RoleBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RoleBinding(string name, RoleBindingArgs args, CustomResourceOptions? options = null)
            : base("nobl9:index/roleBinding:RoleBinding", name, args ?? new RoleBindingArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RoleBinding(string name, Input<string> id, RoleBindingState? state = null, CustomResourceOptions? options = null)
            : base("nobl9:index/roleBinding:RoleBinding", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/piclemx/pulumi-nobl9",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RoleBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RoleBinding Get(string name, Input<string> id, RoleBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new RoleBinding(name, id, state, options);
        }
    }

    public sealed class RoleBindingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Group name that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Groups**) or using sloctl `get usergroups` command.
        /// </summary>
        [Input("groupRef")]
        public Input<string>? GroupRef { get; set; }

        /// <summary>
        /// Automatically generated, unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Project name, the project in which we want the user or group to assume the specified role. When `project_ref` is empty, `role_ref` must contain an Organization Role.
        /// </summary>
        [Input("projectRef")]
        public Input<string>? ProjectRef { get; set; }

        /// <summary>
        /// Role name; the role that you want the user or group to assume.
        /// </summary>
        [Input("roleRef", required: true)]
        public Input<string> RoleRef { get; set; } = null!;

        /// <summary>
        /// Okta User ID that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Users**).
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public RoleBindingArgs()
        {
        }
        public static new RoleBindingArgs Empty => new RoleBindingArgs();
    }

    public sealed class RoleBindingState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// User-friendly display name of the resource.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Group name that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Groups**) or using sloctl `get usergroups` command.
        /// </summary>
        [Input("groupRef")]
        public Input<string>? GroupRef { get; set; }

        /// <summary>
        /// Automatically generated, unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Project name, the project in which we want the user or group to assume the specified role. When `project_ref` is empty, `role_ref` must contain an Organization Role.
        /// </summary>
        [Input("projectRef")]
        public Input<string>? ProjectRef { get; set; }

        /// <summary>
        /// Role name; the role that you want the user or group to assume.
        /// </summary>
        [Input("roleRef")]
        public Input<string>? RoleRef { get; set; }

        /// <summary>
        /// Okta User ID that can be retrieved from the Nobl9 UI (**Settings** &gt; **Access Controls** &gt; **Users**).
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public RoleBindingState()
        {
        }
        public static new RoleBindingState Empty => new RoleBindingState();
    }
}
