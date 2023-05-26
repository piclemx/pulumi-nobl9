# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['AlertMethodServicenowArgs', 'AlertMethodServicenow']

@pulumi.input_type
class AlertMethodServicenowArgs:
    def __init__(__self__, *,
                 instance_name: pulumi.Input[str],
                 project: pulumi.Input[str],
                 username: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AlertMethodServicenow resource.
        :param pulumi.Input[str] instance_name: ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] username: ServiceNow username.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] password: ServiceNow password.
        """
        pulumi.set(__self__, "instance_name", instance_name)
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "username", username)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if password is not None:
            pulumi.set(__self__, "password", password)

    @property
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> pulumi.Input[str]:
        """
        ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        """
        return pulumi.get(self, "instance_name")

    @instance_name.setter
    def instance_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_name", value)

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
    @pulumi.getter
    def username(self) -> pulumi.Input[str]:
        """
        ServiceNow username.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: pulumi.Input[str]):
        pulumi.set(self, "username", value)

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
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        ServiceNow password.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)


@pulumi.input_type
class _AlertMethodServicenowState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AlertMethodServicenow resources.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] instance_name: ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] password: ServiceNow password.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] username: ServiceNow username.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if instance_name is not None:
            pulumi.set(__self__, "instance_name", instance_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if username is not None:
            pulumi.set(__self__, "username", username)

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
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> Optional[pulumi.Input[str]]:
        """
        ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        """
        return pulumi.get(self, "instance_name")

    @instance_name.setter
    def instance_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_name", value)

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
    def password(self) -> Optional[pulumi.Input[str]]:
        """
        ServiceNow password.
        """
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

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
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        """
        ServiceNow username.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


class AlertMethodServicenow(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a AlertMethodServicenow resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] instance_name: ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] password: ServiceNow password.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] username: ServiceNow username.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AlertMethodServicenowArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AlertMethodServicenow resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AlertMethodServicenowArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlertMethodServicenowArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlertMethodServicenowArgs.__new__(AlertMethodServicenowArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            if instance_name is None and not opts.urn:
                raise TypeError("Missing required property 'instance_name'")
            __props__.__dict__["instance_name"] = instance_name
            __props__.__dict__["name"] = name
            __props__.__dict__["password"] = password
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            if username is None and not opts.urn:
                raise TypeError("Missing required property 'username'")
            __props__.__dict__["username"] = username
        super(AlertMethodServicenow, __self__).__init__(
            'nobl9:index/alertMethodServicenow:AlertMethodServicenow',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            instance_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            password: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            username: Optional[pulumi.Input[str]] = None) -> 'AlertMethodServicenow':
        """
        Get an existing AlertMethodServicenow resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] instance_name: ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] password: ServiceNow password.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] username: ServiceNow username.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlertMethodServicenowState.__new__(_AlertMethodServicenowState)

        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["instance_name"] = instance_name
        __props__.__dict__["name"] = name
        __props__.__dict__["password"] = password
        __props__.__dict__["project"] = project
        __props__.__dict__["username"] = username
        return AlertMethodServicenow(resource_name, opts=opts, __props__=__props__)

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
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> pulumi.Output[str]:
        """
        ServiceNow InstanceName. For details see [Nobl9 documentation](https://docs.nobl9.com/Alerting/Alert_methods/servicenow#servicenow-credentials).
        """
        return pulumi.get(self, "instance_name")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def password(self) -> pulumi.Output[str]:
        """
        ServiceNow password.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def username(self) -> pulumi.Output[str]:
        """
        ServiceNow username.
        """
        return pulumi.get(self, "username")
