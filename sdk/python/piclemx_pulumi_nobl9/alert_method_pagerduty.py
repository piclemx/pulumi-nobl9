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

__all__ = ['AlertMethodPagerdutyArgs', 'AlertMethodPagerduty']

@pulumi.input_type
class AlertMethodPagerdutyArgs:
    def __init__(__self__, *,
                 project: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 integration_key: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 send_resolution: Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']] = None):
        """
        The set of arguments for constructing a AlertMethodPagerduty resource.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] integration_key: PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['AlertMethodPagerdutySendResolutionArgs'] send_resolution: Sends a notification after the cooldown period is over.
        """
        pulumi.set(__self__, "project", project)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if integration_key is not None:
            pulumi.set(__self__, "integration_key", integration_key)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if send_resolution is not None:
            pulumi.set(__self__, "send_resolution", send_resolution)

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
    @pulumi.getter(name="integrationKey")
    def integration_key(self) -> Optional[pulumi.Input[str]]:
        """
        PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        """
        return pulumi.get(self, "integration_key")

    @integration_key.setter
    def integration_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "integration_key", value)

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
    @pulumi.getter(name="sendResolution")
    def send_resolution(self) -> Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']]:
        """
        Sends a notification after the cooldown period is over.
        """
        return pulumi.get(self, "send_resolution")

    @send_resolution.setter
    def send_resolution(self, value: Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']]):
        pulumi.set(self, "send_resolution", value)


@pulumi.input_type
class _AlertMethodPagerdutyState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 integration_key: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 send_resolution: Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']] = None):
        """
        Input properties used for looking up and filtering AlertMethodPagerduty resources.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] integration_key: PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['AlertMethodPagerdutySendResolutionArgs'] send_resolution: Sends a notification after the cooldown period is over.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if integration_key is not None:
            pulumi.set(__self__, "integration_key", integration_key)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if send_resolution is not None:
            pulumi.set(__self__, "send_resolution", send_resolution)

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
    @pulumi.getter(name="integrationKey")
    def integration_key(self) -> Optional[pulumi.Input[str]]:
        """
        PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        """
        return pulumi.get(self, "integration_key")

    @integration_key.setter
    def integration_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "integration_key", value)

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
    @pulumi.getter(name="sendResolution")
    def send_resolution(self) -> Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']]:
        """
        Sends a notification after the cooldown period is over.
        """
        return pulumi.get(self, "send_resolution")

    @send_resolution.setter
    def send_resolution(self, value: Optional[pulumi.Input['AlertMethodPagerdutySendResolutionArgs']]):
        pulumi.set(self, "send_resolution", value)


class AlertMethodPagerduty(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 integration_key: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 send_resolution: Optional[pulumi.Input[pulumi.InputType['AlertMethodPagerdutySendResolutionArgs']]] = None,
                 __props__=None):
        """
        Create a AlertMethodPagerduty resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] integration_key: PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['AlertMethodPagerdutySendResolutionArgs']] send_resolution: Sends a notification after the cooldown period is over.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AlertMethodPagerdutyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AlertMethodPagerduty resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AlertMethodPagerdutyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlertMethodPagerdutyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 integration_key: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 send_resolution: Optional[pulumi.Input[pulumi.InputType['AlertMethodPagerdutySendResolutionArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlertMethodPagerdutyArgs.__new__(AlertMethodPagerdutyArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["integration_key"] = None if integration_key is None else pulumi.Output.secret(integration_key)
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            __props__.__dict__["send_resolution"] = send_resolution
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["integrationKey"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(AlertMethodPagerduty, __self__).__init__(
            'nobl9:index/alertMethodPagerduty:AlertMethodPagerduty',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            integration_key: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            send_resolution: Optional[pulumi.Input[pulumi.InputType['AlertMethodPagerdutySendResolutionArgs']]] = None) -> 'AlertMethodPagerduty':
        """
        Get an existing AlertMethodPagerduty resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] integration_key: PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['AlertMethodPagerdutySendResolutionArgs']] send_resolution: Sends a notification after the cooldown period is over.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlertMethodPagerdutyState.__new__(_AlertMethodPagerdutyState)

        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["integration_key"] = integration_key
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["send_resolution"] = send_resolution
        return AlertMethodPagerduty(resource_name, opts=opts, __props__=__props__)

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
    @pulumi.getter(name="integrationKey")
    def integration_key(self) -> pulumi.Output[str]:
        """
        PagerDuty Integration Key. For more details, check [Services and integrations](https://support.pagerduty.com/docs/services-and-integrations).
        """
        return pulumi.get(self, "integration_key")

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
    @pulumi.getter(name="sendResolution")
    def send_resolution(self) -> pulumi.Output[Optional['outputs.AlertMethodPagerdutySendResolution']]:
        """
        Sends a notification after the cooldown period is over.
        """
        return pulumi.get(self, "send_resolution")

