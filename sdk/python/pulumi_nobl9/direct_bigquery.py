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

__all__ = ['DirectBigqueryArgs', 'DirectBigquery']

@pulumi.input_type
class DirectBigqueryArgs:
    def __init__(__self__, *,
                 project: pulumi.Input[str],
                 source_ofs: pulumi.Input[Sequence[pulumi.Input[str]]],
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']] = None,
                 service_account_key: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a DirectBigquery resource.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectBigqueryQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] service_account_key: [required] | Service Account Key.
        """
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "source_ofs", source_ofs)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if query_delay is not None:
            pulumi.set(__self__, "query_delay", query_delay)
        if service_account_key is not None:
            pulumi.set(__self__, "service_account_key", service_account_key)

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
    def query_delay(self) -> Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)

    @property
    @pulumi.getter(name="serviceAccountKey")
    def service_account_key(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | Service Account Key.
        """
        return pulumi.get(self, "service_account_key")

    @service_account_key.setter
    def service_account_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service_account_key", value)


@pulumi.input_type
class _DirectBigqueryState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']] = None,
                 service_account_key: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DirectBigquery resources.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectBigqueryQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] service_account_key: [required] | Service Account Key.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] status: The status of the created direct.
        """
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
        if service_account_key is not None:
            pulumi.set(__self__, "service_account_key", service_account_key)
        if source_ofs is not None:
            pulumi.set(__self__, "source_ofs", source_ofs)
        if status is not None:
            pulumi.set(__self__, "status", status)

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
    def query_delay(self) -> Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectBigqueryQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)

    @property
    @pulumi.getter(name="serviceAccountKey")
    def service_account_key(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | Service Account Key.
        """
        return pulumi.get(self, "service_account_key")

    @service_account_key.setter
    def service_account_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service_account_key", value)

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


class DirectBigquery(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectBigqueryQueryDelayArgs']]] = None,
                 service_account_key: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Google BigQuery is a serverless data warehouse that enables scalable analysis over petabytes of data. It is a Platform as a Service that supports querying using ANSI SQL. BigQuery integration with Nobl9 enables users to turn their big data into valuable business insights. Nobl9 connects with BigQuery to collect SLI measurements and compare them to SLO targets.

        For more information, refer to [BigQuery Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/bigquery#bigquery-direct)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nobl9 as nobl9

        test_bigquery = nobl9.DirectBigquery("test-bigquery",
            description="desc",
            project="terraform",
            service_account_key="secret",
            source_ofs=[
                "Metrics",
                "Services",
            ])
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectBigqueryQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] service_account_key: [required] | Service Account Key.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DirectBigqueryArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Google BigQuery is a serverless data warehouse that enables scalable analysis over petabytes of data. It is a Platform as a Service that supports querying using ANSI SQL. BigQuery integration with Nobl9 enables users to turn their big data into valuable business insights. Nobl9 connects with BigQuery to collect SLI measurements and compare them to SLO targets.

        For more information, refer to [BigQuery Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/bigquery#bigquery-direct)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_nobl9 as nobl9

        test_bigquery = nobl9.DirectBigquery("test-bigquery",
            description="desc",
            project="terraform",
            service_account_key="secret",
            source_ofs=[
                "Metrics",
                "Services",
            ])
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param DirectBigqueryArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DirectBigqueryArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectBigqueryQueryDelayArgs']]] = None,
                 service_account_key: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DirectBigqueryArgs.__new__(DirectBigqueryArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            __props__.__dict__["query_delay"] = query_delay
            __props__.__dict__["service_account_key"] = service_account_key
            if source_ofs is None and not opts.urn:
                raise TypeError("Missing required property 'source_ofs'")
            __props__.__dict__["source_ofs"] = source_ofs
            __props__.__dict__["status"] = None
        super(DirectBigquery, __self__).__init__(
            'nobl9:index/directBigquery:DirectBigquery',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            query_delay: Optional[pulumi.Input[pulumi.InputType['DirectBigqueryQueryDelayArgs']]] = None,
            service_account_key: Optional[pulumi.Input[str]] = None,
            source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'DirectBigquery':
        """
        Get an existing DirectBigquery resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectBigqueryQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] service_account_key: [required] | Service Account Key.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: Source of Metrics and/or Services.
        :param pulumi.Input[str] status: The status of the created direct.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DirectBigqueryState.__new__(_DirectBigqueryState)

        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["query_delay"] = query_delay
        __props__.__dict__["service_account_key"] = service_account_key
        __props__.__dict__["source_ofs"] = source_ofs
        __props__.__dict__["status"] = status
        return DirectBigquery(resource_name, opts=opts, __props__=__props__)

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
    def query_delay(self) -> pulumi.Output[Optional['outputs.DirectBigqueryQueryDelay']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @property
    @pulumi.getter(name="serviceAccountKey")
    def service_account_key(self) -> pulumi.Output[str]:
        """
        [required] | Service Account Key.
        """
        return pulumi.get(self, "service_account_key")

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

