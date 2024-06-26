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

__all__ = ['AlertPolicyArgs', 'AlertPolicy']

@pulumi.input_type
class AlertPolicyArgs:
    def __init__(__self__, *,
                 conditions: pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]],
                 project: pulumi.Input[str],
                 severity: pulumi.Input[str],
                 alert_methods: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]] = None,
                 cooldown: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AlertPolicy resource.
        :param pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]] conditions: Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        :param pulumi.Input[str] project: Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        :param pulumi.Input[str] severity: Alert severity. One of `Low` | `Medium` | `High`.
        :param pulumi.Input[str] cooldown: An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: The name of the previously defined alert method.
        """
        pulumi.set(__self__, "conditions", conditions)
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "severity", severity)
        if alert_methods is not None:
            pulumi.set(__self__, "alert_methods", alert_methods)
        if cooldown is not None:
            pulumi.set(__self__, "cooldown", cooldown)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]]:
        """
        Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def project(self) -> pulumi.Input[str]:
        """
        Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: pulumi.Input[str]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter
    def severity(self) -> pulumi.Input[str]:
        """
        Alert severity. One of `Low` | `Medium` | `High`.
        """
        return pulumi.get(self, "severity")

    @severity.setter
    def severity(self, value: pulumi.Input[str]):
        pulumi.set(self, "severity", value)

    @property
    @pulumi.getter(name="alertMethods")
    def alert_methods(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]]:
        return pulumi.get(self, "alert_methods")

    @alert_methods.setter
    def alert_methods(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]]):
        pulumi.set(self, "alert_methods", value)

    @property
    @pulumi.getter
    def cooldown(self) -> Optional[pulumi.Input[str]]:
        """
        An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        """
        return pulumi.get(self, "cooldown")

    @cooldown.setter
    def cooldown(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cooldown", value)

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
        The name of the previously defined alert method.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _AlertPolicyState:
    def __init__(__self__, *,
                 alert_methods: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]] = None,
                 conditions: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]]] = None,
                 cooldown: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 severity: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AlertPolicy resources.
        :param pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]] conditions: Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        :param pulumi.Input[str] cooldown: An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: The name of the previously defined alert method.
        :param pulumi.Input[str] project: Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        :param pulumi.Input[str] severity: Alert severity. One of `Low` | `Medium` | `High`.
        """
        if alert_methods is not None:
            pulumi.set(__self__, "alert_methods", alert_methods)
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if cooldown is not None:
            pulumi.set(__self__, "cooldown", cooldown)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if severity is not None:
            pulumi.set(__self__, "severity", severity)

    @property
    @pulumi.getter(name="alertMethods")
    def alert_methods(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]]:
        return pulumi.get(self, "alert_methods")

    @alert_methods.setter
    def alert_methods(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyAlertMethodArgs']]]]):
        pulumi.set(self, "alert_methods", value)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]]]:
        """
        Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AlertPolicyConditionArgs']]]]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def cooldown(self) -> Optional[pulumi.Input[str]]:
        """
        An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        """
        return pulumi.get(self, "cooldown")

    @cooldown.setter
    def cooldown(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cooldown", value)

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
        The name of the previously defined alert method.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def project(self) -> Optional[pulumi.Input[str]]:
        """
        Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        """
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter
    def severity(self) -> Optional[pulumi.Input[str]]:
        """
        Alert severity. One of `Low` | `Medium` | `High`.
        """
        return pulumi.get(self, "severity")

    @severity.setter
    def severity(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "severity", value)


class AlertPolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alert_methods: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyAlertMethodArgs']]]]] = None,
                 conditions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]]] = None,
                 cooldown: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 severity: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        An **Alert Policy** expresses a set of conditions you want to track or monitor. The conditions for an Alert Policy define what is monitored and when to activate an alert: when the performance of your service is declining, Nobl9 will send a notification to a predefined channel.

        A Nobl9 AlertPolicy accepts up to 3 conditions. All the specified conditions must be satisfied to trigger an alert.

        For more details, refer to the [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy).

        ## Example Usage

        Here's an example of Alert Policy resource configuration:

        ```python
        import pulumi
        import piclemx_pulumi_nobl9 as nobl9

        this_project = nobl9.Project("thisProject",
            display_name="My Project",
            description="An example N9 Terraform project")
        this_service = nobl9.Service("thisService",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Front Page"),
            description="Front page service")
        this_alert_policy = nobl9.AlertPolicy("thisAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Front Page Latency"),
            severity="High",
            description="Alert when page latency is > 2000 and error budget would be exhausted",
            cooldown="5m",
            conditions=[nobl9.AlertPolicyConditionArgs(
                measurement="timeToBurnBudget",
                value_string="72h",
                lasts_for="30m",
            )],
            alert_methods=[nobl9.AlertPolicyAlertMethodArgs(
                name="my-alert-method",
            )])
        this_index_alert_policy_alert_policy = nobl9.AlertPolicy("thisIndex/alertPolicyAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Slow Burn (1x12h and 2x15min)"),
            severity="Low",
            description="The budget is slowly exhausting and not recovering.",
            cooldown="5m",
            conditions=[
                nobl9.AlertPolicyConditionArgs(
                    measurement="averageBurnRate",
                    value=1,
                    alerting_window="12h",
                ),
                nobl9.AlertPolicyConditionArgs(
                    measurement="averageBurnRate",
                    value=2,
                    alerting_window="15m",
                ),
            ])
        this_nobl9_index_alert_policy_alert_policy = nobl9.AlertPolicy("thisNobl9Index/alertPolicyAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Fast Burn (20x5min)"),
            severity="High",
            description="There’s been a significant spike in burn rate over a brief period.",
            cooldown="5m",
            conditions=[nobl9.AlertPolicyConditionArgs(
                measurement="averageBurnRate",
                value=20,
                alerting_window="5m",
            )])
        ```
        ## Useful Links

        [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy)

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]] conditions: Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        :param pulumi.Input[str] cooldown: An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: The name of the previously defined alert method.
        :param pulumi.Input[str] project: Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        :param pulumi.Input[str] severity: Alert severity. One of `Low` | `Medium` | `High`.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AlertPolicyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        An **Alert Policy** expresses a set of conditions you want to track or monitor. The conditions for an Alert Policy define what is monitored and when to activate an alert: when the performance of your service is declining, Nobl9 will send a notification to a predefined channel.

        A Nobl9 AlertPolicy accepts up to 3 conditions. All the specified conditions must be satisfied to trigger an alert.

        For more details, refer to the [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy).

        ## Example Usage

        Here's an example of Alert Policy resource configuration:

        ```python
        import pulumi
        import piclemx_pulumi_nobl9 as nobl9

        this_project = nobl9.Project("thisProject",
            display_name="My Project",
            description="An example N9 Terraform project")
        this_service = nobl9.Service("thisService",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Front Page"),
            description="Front page service")
        this_alert_policy = nobl9.AlertPolicy("thisAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Front Page Latency"),
            severity="High",
            description="Alert when page latency is > 2000 and error budget would be exhausted",
            cooldown="5m",
            conditions=[nobl9.AlertPolicyConditionArgs(
                measurement="timeToBurnBudget",
                value_string="72h",
                lasts_for="30m",
            )],
            alert_methods=[nobl9.AlertPolicyAlertMethodArgs(
                name="my-alert-method",
            )])
        this_index_alert_policy_alert_policy = nobl9.AlertPolicy("thisIndex/alertPolicyAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Slow Burn (1x12h and 2x15min)"),
            severity="Low",
            description="The budget is slowly exhausting and not recovering.",
            cooldown="5m",
            conditions=[
                nobl9.AlertPolicyConditionArgs(
                    measurement="averageBurnRate",
                    value=1,
                    alerting_window="12h",
                ),
                nobl9.AlertPolicyConditionArgs(
                    measurement="averageBurnRate",
                    value=2,
                    alerting_window="15m",
                ),
            ])
        this_nobl9_index_alert_policy_alert_policy = nobl9.AlertPolicy("thisNobl9Index/alertPolicyAlertPolicy",
            project=this_project.name,
            display_name=this_project.display_name.apply(lambda display_name: f"{display_name} Fast Burn (20x5min)"),
            severity="High",
            description="There’s been a significant spike in burn rate over a brief period.",
            cooldown="5m",
            conditions=[nobl9.AlertPolicyConditionArgs(
                measurement="averageBurnRate",
                value=20,
                alerting_window="5m",
            )])
        ```
        ## Useful Links

        [Alert Policy configuration | Nobl9 Documentation](https://docs.nobl9.com/yaml-guide#alertpolicy)

        :param str resource_name: The name of the resource.
        :param AlertPolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlertPolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alert_methods: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyAlertMethodArgs']]]]] = None,
                 conditions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]]] = None,
                 cooldown: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 severity: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlertPolicyArgs.__new__(AlertPolicyArgs)

            __props__.__dict__["alert_methods"] = alert_methods
            if conditions is None and not opts.urn:
                raise TypeError("Missing required property 'conditions'")
            __props__.__dict__["conditions"] = conditions
            __props__.__dict__["cooldown"] = cooldown
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            if severity is None and not opts.urn:
                raise TypeError("Missing required property 'severity'")
            __props__.__dict__["severity"] = severity
        super(AlertPolicy, __self__).__init__(
            'nobl9:index/alertPolicy:AlertPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            alert_methods: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyAlertMethodArgs']]]]] = None,
            conditions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]]] = None,
            cooldown: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            severity: Optional[pulumi.Input[str]] = None) -> 'AlertPolicy':
        """
        Get an existing AlertPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlertPolicyConditionArgs']]]] conditions: Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        :param pulumi.Input[str] cooldown: An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: The name of the previously defined alert method.
        :param pulumi.Input[str] project: Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        :param pulumi.Input[str] severity: Alert severity. One of `Low` | `Medium` | `High`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlertPolicyState.__new__(_AlertPolicyState)

        __props__.__dict__["alert_methods"] = alert_methods
        __props__.__dict__["conditions"] = conditions
        __props__.__dict__["cooldown"] = cooldown
        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["severity"] = severity
        return AlertPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="alertMethods")
    def alert_methods(self) -> pulumi.Output[Optional[Sequence['outputs.AlertPolicyAlertMethod']]]:
        return pulumi.get(self, "alert_methods")

    @property
    @pulumi.getter
    def conditions(self) -> pulumi.Output[Sequence['outputs.AlertPolicyCondition']]:
        """
        Configuration of an [alert condition](https://docs.nobl9.com/yaml-guide/#alertpolicy).
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def cooldown(self) -> pulumi.Output[Optional[str]]:
        """
        An interval measured from the last time stamp when all alert policy conditions were satisfied before alert is marked as resolved
        """
        return pulumi.get(self, "cooldown")

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
        The name of the previously defined alert method.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        Project name the Alert Method is in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names). If not defined, Nobl9 returns a default value for this field.
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def severity(self) -> pulumi.Output[str]:
        """
        Alert severity. One of `Low` | `Medium` | `High`.
        """
        return pulumi.get(self, "severity")

