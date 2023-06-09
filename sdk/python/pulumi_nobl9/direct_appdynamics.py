# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['DirectAppdynamicsArgs', 'DirectAppdynamics']

@pulumi.input_type
class DirectAppdynamicsArgs:
    def __init__(__self__, *,
                 account_name: pulumi.Input[str],
                 client_name: pulumi.Input[str],
                 project: pulumi.Input[str],
                 source_ofs: pulumi.Input[Sequence[pulumi.Input[str]]],
                 url: pulumi.Input[str],
                 client_secret: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']] = None):
        """
        The set of arguments for constructing a DirectAppdynamics resource.
        :param pulumi.Input[str] account_name: AppDynamics Account Name.
        :param pulumi.Input[str] client_name: AppDynamics Client Name.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] url: Base URL to the AppDynamics Controller.
        :param pulumi.Input[str] client_secret: [required] | AppDynamics Client Secret.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectAppdynamicsQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        pulumi.set(__self__, "account_name", account_name)
        pulumi.set(__self__, "client_name", client_name)
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "source_ofs", source_ofs)
        pulumi.set(__self__, "url", url)
        if client_secret is not None:
            pulumi.set(__self__, "client_secret", client_secret)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if query_delay is not None:
            pulumi.set(__self__, "query_delay", query_delay)

    @property
    @pulumi.getter(name="accountName")
    def account_name(self) -> pulumi.Input[str]:
        """
        AppDynamics Account Name.
        """
        return pulumi.get(self, "account_name")

    @account_name.setter
    def account_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "account_name", value)

    @property
    @pulumi.getter(name="clientName")
    def client_name(self) -> pulumi.Input[str]:
        """
        AppDynamics Client Name.
        """
        return pulumi.get(self, "client_name")

    @client_name.setter
    def client_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "client_name", value)

    @property
    @pulumi.getter
    def project(self) -> pulumi.Input[str]:
        """
        Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: pulumi.Input[str]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        Source of Metrics and/or Services.
        """
        return pulumi.get(self, "source_ofs")

    @source_ofs.setter
    def source_ofs(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "source_ofs", value)

    @property
    @pulumi.getter
    def url(self) -> pulumi.Input[str]:
        """
        Base URL to the AppDynamics Controller.
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: pulumi.Input[str]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | AppDynamics Client Secret.
        """
        return pulumi.get(self, "client_secret")

    @client_secret.setter
    def client_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_secret", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        User-friendly display name of the resource.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="queryDelay")
    def query_delay(self) -> Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)


@pulumi.input_type
class _DirectAppdynamicsState:
    def __init__(__self__, *,
                 account_name: Optional[pulumi.Input[str]] = None,
                 client_id: Optional[pulumi.Input[str]] = None,
                 client_name: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DirectAppdynamics resources.
        :param pulumi.Input[str] account_name: AppDynamics Account Name.
        :param pulumi.Input[str] client_id: AppDynamics Client ID.
        :param pulumi.Input[str] client_name: AppDynamics Client Name.
        :param pulumi.Input[str] client_secret: [required] | AppDynamics Client Secret.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectAppdynamicsQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] status: The status of the created direct.
        :param pulumi.Input[str] url: Base URL to the AppDynamics Controller.
        """
        if account_name is not None:
            pulumi.set(__self__, "account_name", account_name)
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if client_name is not None:
            pulumi.set(__self__, "client_name", client_name)
        if client_secret is not None:
            pulumi.set(__self__, "client_secret", client_secret)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if query_delay is not None:
            pulumi.set(__self__, "query_delay", query_delay)
        if source_ofs is not None:
            pulumi.set(__self__, "source_ofs", source_ofs)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if url is not None:
            pulumi.set(__self__, "url", url)

    @property
    @pulumi.getter(name="accountName")
    def account_name(self) -> Optional[pulumi.Input[str]]:
        """
        AppDynamics Account Name.
        """
        return pulumi.get(self, "account_name")

    @account_name.setter
    def account_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "account_name", value)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[pulumi.Input[str]]:
        """
        AppDynamics Client ID.
        """
        return pulumi.get(self, "client_id")

    @client_id.setter
    def client_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_id", value)

    @property
    @pulumi.getter(name="clientName")
    def client_name(self) -> Optional[pulumi.Input[str]]:
        """
        AppDynamics Client Name.
        """
        return pulumi.get(self, "client_name")

    @client_name.setter
    def client_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_name", value)

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | AppDynamics Client Secret.
        """
        return pulumi.get(self, "client_secret")

    @client_secret.setter
    def client_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_secret", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> Optional[pulumi.Input[str]]:
        """
        User-friendly display name of the resource.
        """
        return pulumi.get(self, "display_name")

    @display_name.setter
    def display_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "display_name", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter(name="queryDelay")
    def query_delay(self) -> Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectAppdynamicsQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Source of Metrics and/or Services.
        """
        return pulumi.get(self, "source_ofs")

    @source_ofs.setter
    def source_ofs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "source_ofs", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        The status of the created direct.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def url(self) -> Optional[pulumi.Input[str]]:
        """
        Base URL to the AppDynamics Controller.
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)


class DirectAppdynamics(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 client_name: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectAppdynamicsQueryDelayArgs']]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        AppDynamics is a performance management program for applications. It helps users to gain a comprehensive understanding of the impact of technical difficulties on business goals, allowing IT teams to prioritize their efforts in a way that improves ROI. Nobl9 connects with AppDynamics to collect SLI measurements and compare them to SLO targets.

        For more information, refer to [AppDynamics Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/appdynamics#appdynamics-direct)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nobl9 as nobl9

        test_appdynamics = nobl9.DirectAppdynamics("test-appdynamics",
            account_name="account name",
            client_name="client name",
            client_secret="secret",
            description="desc",
            project="terraform",
            source_ofs=[
                "Metrics",
                "Services",
            ],
            url="https://web.net")
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: AppDynamics Account Name.
        :param pulumi.Input[str] client_name: AppDynamics Client Name.
        :param pulumi.Input[str] client_secret: [required] | AppDynamics Client Secret.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectAppdynamicsQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] url: Base URL to the AppDynamics Controller.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DirectAppdynamicsArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        AppDynamics is a performance management program for applications. It helps users to gain a comprehensive understanding of the impact of technical difficulties on business goals, allowing IT teams to prioritize their efforts in a way that improves ROI. Nobl9 connects with AppDynamics to collect SLI measurements and compare them to SLO targets.

        For more information, refer to [AppDynamics Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/appdynamics#appdynamics-direct)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nobl9 as nobl9

        test_appdynamics = nobl9.DirectAppdynamics("test-appdynamics",
            account_name="account name",
            client_name="client name",
            client_secret="secret",
            description="desc",
            project="terraform",
            source_ofs=[
                "Metrics",
                "Services",
            ],
            url="https://web.net")
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param DirectAppdynamicsArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DirectAppdynamicsArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 client_name: Optional[pulumi.Input[str]] = None,
                 client_secret: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectAppdynamicsQueryDelayArgs']]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DirectAppdynamicsArgs.__new__(DirectAppdynamicsArgs)

            if account_name is None and not opts.urn:
                raise TypeError("Missing required property 'account_name'")
            __props__.__dict__["account_name"] = account_name
            if client_name is None and not opts.urn:
                raise TypeError("Missing required property 'client_name'")
            __props__.__dict__["client_name"] = client_name
            __props__.__dict__["client_secret"] = client_secret
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            __props__.__dict__["query_delay"] = query_delay
            if source_ofs is None and not opts.urn:
                raise TypeError("Missing required property 'source_ofs'")
            __props__.__dict__["source_ofs"] = source_ofs
            if url is None and not opts.urn:
                raise TypeError("Missing required property 'url'")
            __props__.__dict__["url"] = url
            __props__.__dict__["client_id"] = None
            __props__.__dict__["status"] = None
        super(DirectAppdynamics, __self__).__init__(
            'nobl9:index/directAppdynamics:DirectAppdynamics',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            account_name: Optional[pulumi.Input[str]] = None,
            client_id: Optional[pulumi.Input[str]] = None,
            client_name: Optional[pulumi.Input[str]] = None,
            client_secret: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            query_delay: Optional[pulumi.Input[pulumi.InputType['DirectAppdynamicsQueryDelayArgs']]] = None,
            source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None,
            url: Optional[pulumi.Input[str]] = None) -> 'DirectAppdynamics':
        """
        Get an existing DirectAppdynamics resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: AppDynamics Account Name.
        :param pulumi.Input[str] client_id: AppDynamics Client ID.
        :param pulumi.Input[str] client_name: AppDynamics Client Name.
        :param pulumi.Input[str] client_secret: [required] | AppDynamics Client Secret.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectAppdynamicsQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] status: The status of the created direct.
        :param pulumi.Input[str] url: Base URL to the AppDynamics Controller.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DirectAppdynamicsState.__new__(_DirectAppdynamicsState)

        __props__.__dict__["account_name"] = account_name
        __props__.__dict__["client_id"] = client_id
        __props__.__dict__["client_name"] = client_name
        __props__.__dict__["client_secret"] = client_secret
        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["query_delay"] = query_delay
        __props__.__dict__["source_ofs"] = source_ofs
        __props__.__dict__["status"] = status
        __props__.__dict__["url"] = url
        return DirectAppdynamics(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountName")
    def account_name(self) -> pulumi.Output[str]:
        """
        AppDynamics Account Name.
        """
        return pulumi.get(self, "account_name")

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Output[str]:
        """
        AppDynamics Client ID.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="clientName")
    def client_name(self) -> pulumi.Output[str]:
        """
        AppDynamics Client Name.
        """
        return pulumi.get(self, "client_name")

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> pulumi.Output[str]:
        """
        [required] | AppDynamics Client Secret.
        """
        return pulumi.get(self, "client_secret")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[Optional[str]]:
        """
        User-friendly display name of the resource.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="queryDelay")
    def query_delay(self) -> pulumi.Output[Optional['outputs.DirectAppdynamicsQueryDelay']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> pulumi.Output[Sequence[str]]:
        """
        Source of Metrics and/or Services.
        """
        return pulumi.get(self, "source_ofs")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the created direct.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def url(self) -> pulumi.Output[str]:
        """
        Base URL to the AppDynamics Controller.
        """
        return pulumi.get(self, "url")

