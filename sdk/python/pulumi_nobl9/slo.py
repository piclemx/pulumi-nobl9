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

__all__ = ['SloArgs', 'Slo']

@pulumi.input_type
class SloArgs:
    def __init__(__self__, *,
                 budgeting_method: pulumi.Input[str],
                 indicator: pulumi.Input['SloIndicatorArgs'],
                 objectives: pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]],
                 project: pulumi.Input[str],
                 service: pulumi.Input[str],
                 time_window: pulumi.Input['SloTimeWindowArgs'],
                 alert_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 attachments: Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]] = None,
                 composite: Optional[pulumi.Input['SloCompositeArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Slo resource.
        :param pulumi.Input[str] budgeting_method: Method which will be use to calculate budget
        :param pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]] objectives: [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] service: Name of the service
        :param pulumi.Input[Sequence[pulumi.Input[str]]] alert_policies: Alert Policies attached to SLO
        :param pulumi.Input['SloCompositeArgs'] composite: [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]] labels: [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        pulumi.set(__self__, "budgeting_method", budgeting_method)
        pulumi.set(__self__, "indicator", indicator)
        pulumi.set(__self__, "objectives", objectives)
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "service", service)
        pulumi.set(__self__, "time_window", time_window)
        if alert_policies is not None:
            pulumi.set(__self__, "alert_policies", alert_policies)
        if attachments is not None:
            warnings.warn("""\"attachments\" argument is deprecated use \"attachment\" instead""", DeprecationWarning)
            pulumi.log.warn("""attachments is deprecated: \"attachments\" argument is deprecated use \"attachment\" instead""")
        if attachments is not None:
            pulumi.set(__self__, "attachments", attachments)
        if composite is not None:
            pulumi.set(__self__, "composite", composite)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="budgetingMethod")
    def budgeting_method(self) -> pulumi.Input[str]:
        """
        Method which will be use to calculate budget
        """
        return pulumi.get(self, "budgeting_method")

    @budgeting_method.setter
    def budgeting_method(self, value: pulumi.Input[str]):
        pulumi.set(self, "budgeting_method", value)

    @property
    @pulumi.getter
    def indicator(self) -> pulumi.Input['SloIndicatorArgs']:
        return pulumi.get(self, "indicator")

    @indicator.setter
    def indicator(self, value: pulumi.Input['SloIndicatorArgs']):
        pulumi.set(self, "indicator", value)

    @property
    @pulumi.getter
    def objectives(self) -> pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]]:
        """
        [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        """
        return pulumi.get(self, "objectives")

    @objectives.setter
    def objectives(self, value: pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]]):
        pulumi.set(self, "objectives", value)

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
    def service(self) -> pulumi.Input[str]:
        """
        Name of the service
        """
        return pulumi.get(self, "service")

    @service.setter
    def service(self, value: pulumi.Input[str]):
        pulumi.set(self, "service", value)

    @property
    @pulumi.getter(name="timeWindow")
    def time_window(self) -> pulumi.Input['SloTimeWindowArgs']:
        return pulumi.get(self, "time_window")

    @time_window.setter
    def time_window(self, value: pulumi.Input['SloTimeWindowArgs']):
        pulumi.set(self, "time_window", value)

    @property
    @pulumi.getter(name="alertPolicies")
    def alert_policies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Alert Policies attached to SLO
        """
        return pulumi.get(self, "alert_policies")

    @alert_policies.setter
    def alert_policies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "alert_policies", value)

    @property
    @pulumi.getter
    def attachments(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]]:
        return pulumi.get(self, "attachments")

    @attachments.setter
    def attachments(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]]):
        pulumi.set(self, "attachments", value)

    @property
    @pulumi.getter
    def composite(self) -> Optional[pulumi.Input['SloCompositeArgs']]:
        """
        [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        """
        return pulumi.get(self, "composite")

    @composite.setter
    def composite(self, value: Optional[pulumi.Input['SloCompositeArgs']]):
        pulumi.set(self, "composite", value)

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
    def labels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]]:
        """
        [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]]):
        pulumi.set(self, "labels", value)

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


@pulumi.input_type
class _SloState:
    def __init__(__self__, *,
                 alert_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 attachments: Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]] = None,
                 budgeting_method: Optional[pulumi.Input[str]] = None,
                 composite: Optional[pulumi.Input['SloCompositeArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 indicator: Optional[pulumi.Input['SloIndicatorArgs']] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 objectives: Optional[pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service: Optional[pulumi.Input[str]] = None,
                 time_window: Optional[pulumi.Input['SloTimeWindowArgs']] = None):
        """
        Input properties used for looking up and filtering Slo resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] alert_policies: Alert Policies attached to SLO
        :param pulumi.Input[str] budgeting_method: Method which will be use to calculate budget
        :param pulumi.Input['SloCompositeArgs'] composite: [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]] labels: [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]] objectives: [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] service: Name of the service
        """
        if alert_policies is not None:
            pulumi.set(__self__, "alert_policies", alert_policies)
        if attachments is not None:
            warnings.warn("""\"attachments\" argument is deprecated use \"attachment\" instead""", DeprecationWarning)
            pulumi.log.warn("""attachments is deprecated: \"attachments\" argument is deprecated use \"attachment\" instead""")
        if attachments is not None:
            pulumi.set(__self__, "attachments", attachments)
        if budgeting_method is not None:
            pulumi.set(__self__, "budgeting_method", budgeting_method)
        if composite is not None:
            pulumi.set(__self__, "composite", composite)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if indicator is not None:
            pulumi.set(__self__, "indicator", indicator)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if objectives is not None:
            pulumi.set(__self__, "objectives", objectives)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if service is not None:
            pulumi.set(__self__, "service", service)
        if time_window is not None:
            pulumi.set(__self__, "time_window", time_window)

    @property
    @pulumi.getter(name="alertPolicies")
    def alert_policies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Alert Policies attached to SLO
        """
        return pulumi.get(self, "alert_policies")

    @alert_policies.setter
    def alert_policies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "alert_policies", value)

    @property
    @pulumi.getter
    def attachments(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]]:
        return pulumi.get(self, "attachments")

    @attachments.setter
    def attachments(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SloAttachmentArgs']]]]):
        pulumi.set(self, "attachments", value)

    @property
    @pulumi.getter(name="budgetingMethod")
    def budgeting_method(self) -> Optional[pulumi.Input[str]]:
        """
        Method which will be use to calculate budget
        """
        return pulumi.get(self, "budgeting_method")

    @budgeting_method.setter
    def budgeting_method(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "budgeting_method", value)

    @property
    @pulumi.getter
    def composite(self) -> Optional[pulumi.Input['SloCompositeArgs']]:
        """
        [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        """
        return pulumi.get(self, "composite")

    @composite.setter
    def composite(self, value: Optional[pulumi.Input['SloCompositeArgs']]):
        pulumi.set(self, "composite", value)

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
    def indicator(self) -> Optional[pulumi.Input['SloIndicatorArgs']]:
        return pulumi.get(self, "indicator")

    @indicator.setter
    def indicator(self, value: Optional[pulumi.Input['SloIndicatorArgs']]):
        pulumi.set(self, "indicator", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]]:
        """
        [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SloLabelArgs']]]]):
        pulumi.set(self, "labels", value)

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
    def objectives(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]]]:
        """
        [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        """
        return pulumi.get(self, "objectives")

    @objectives.setter
    def objectives(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SloObjectiveArgs']]]]):
        pulumi.set(self, "objectives", value)

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
    def service(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the service
        """
        return pulumi.get(self, "service")

    @service.setter
    def service(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service", value)

    @property
    @pulumi.getter(name="timeWindow")
    def time_window(self) -> Optional[pulumi.Input['SloTimeWindowArgs']]:
        return pulumi.get(self, "time_window")

    @time_window.setter
    def time_window(self, value: Optional[pulumi.Input['SloTimeWindowArgs']]):
        pulumi.set(self, "time_window", value)


class Slo(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alert_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 attachments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloAttachmentArgs']]]]] = None,
                 budgeting_method: Optional[pulumi.Input[str]] = None,
                 composite: Optional[pulumi.Input[pulumi.InputType['SloCompositeArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 indicator: Optional[pulumi.Input[pulumi.InputType['SloIndicatorArgs']]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloLabelArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 objectives: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloObjectiveArgs']]]]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service: Optional[pulumi.Input[str]] = None,
                 time_window: Optional[pulumi.Input[pulumi.InputType['SloTimeWindowArgs']]] = None,
                 __props__=None):
        """
        An SLO is a target value or range of values for a service that is measured by a service level indicator (SLI). SLOs allows you to define the reliability of your products and services in terms of customer expectations. You can create SLOs for user journeys, internal services, or even infrastructure.

        For more information, refer to [SLO configuration documentation](https://docs.nobl9.com/yaml-guide#slo)

        ## Nobl9 Official Documentation

        https://docs.nobl9.com/SLOs_as_code/?_highlight=slo

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] alert_policies: Alert Policies attached to SLO
        :param pulumi.Input[str] budgeting_method: Method which will be use to calculate budget
        :param pulumi.Input[pulumi.InputType['SloCompositeArgs']] composite: [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloLabelArgs']]]] labels: [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloObjectiveArgs']]]] objectives: [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] service: Name of the service
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SloArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        An SLO is a target value or range of values for a service that is measured by a service level indicator (SLI). SLOs allows you to define the reliability of your products and services in terms of customer expectations. You can create SLOs for user journeys, internal services, or even infrastructure.

        For more information, refer to [SLO configuration documentation](https://docs.nobl9.com/yaml-guide#slo)

        ## Nobl9 Official Documentation

        https://docs.nobl9.com/SLOs_as_code/?_highlight=slo

        :param str resource_name: The name of the resource.
        :param SloArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SloArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 alert_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 attachments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloAttachmentArgs']]]]] = None,
                 budgeting_method: Optional[pulumi.Input[str]] = None,
                 composite: Optional[pulumi.Input[pulumi.InputType['SloCompositeArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 indicator: Optional[pulumi.Input[pulumi.InputType['SloIndicatorArgs']]] = None,
                 labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloLabelArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 objectives: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloObjectiveArgs']]]]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 service: Optional[pulumi.Input[str]] = None,
                 time_window: Optional[pulumi.Input[pulumi.InputType['SloTimeWindowArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SloArgs.__new__(SloArgs)

            __props__.__dict__["alert_policies"] = alert_policies
            if attachments is not None and not opts.urn:
                warnings.warn("""\"attachments\" argument is deprecated use \"attachment\" instead""", DeprecationWarning)
                pulumi.log.warn("""attachments is deprecated: \"attachments\" argument is deprecated use \"attachment\" instead""")
            __props__.__dict__["attachments"] = attachments
            if budgeting_method is None and not opts.urn:
                raise TypeError("Missing required property 'budgeting_method'")
            __props__.__dict__["budgeting_method"] = budgeting_method
            __props__.__dict__["composite"] = composite
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            if indicator is None and not opts.urn:
                raise TypeError("Missing required property 'indicator'")
            __props__.__dict__["indicator"] = indicator
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            if objectives is None and not opts.urn:
                raise TypeError("Missing required property 'objectives'")
            __props__.__dict__["objectives"] = objectives
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            if service is None and not opts.urn:
                raise TypeError("Missing required property 'service'")
            __props__.__dict__["service"] = service
            if time_window is None and not opts.urn:
                raise TypeError("Missing required property 'time_window'")
            __props__.__dict__["time_window"] = time_window
        super(Slo, __self__).__init__(
            'nobl9:index/slo:Slo',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            alert_policies: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            attachments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloAttachmentArgs']]]]] = None,
            budgeting_method: Optional[pulumi.Input[str]] = None,
            composite: Optional[pulumi.Input[pulumi.InputType['SloCompositeArgs']]] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            indicator: Optional[pulumi.Input[pulumi.InputType['SloIndicatorArgs']]] = None,
            labels: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloLabelArgs']]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            objectives: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloObjectiveArgs']]]]] = None,
            project: Optional[pulumi.Input[str]] = None,
            service: Optional[pulumi.Input[str]] = None,
            time_window: Optional[pulumi.Input[pulumi.InputType['SloTimeWindowArgs']]] = None) -> 'Slo':
        """
        Get an existing Slo resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] alert_policies: Alert Policies attached to SLO
        :param pulumi.Input[str] budgeting_method: Method which will be use to calculate budget
        :param pulumi.Input[pulumi.InputType['SloCompositeArgs']] composite: [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloLabelArgs']]]] labels: [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SloObjectiveArgs']]]] objectives: [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] service: Name of the service
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SloState.__new__(_SloState)

        __props__.__dict__["alert_policies"] = alert_policies
        __props__.__dict__["attachments"] = attachments
        __props__.__dict__["budgeting_method"] = budgeting_method
        __props__.__dict__["composite"] = composite
        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["indicator"] = indicator
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["objectives"] = objectives
        __props__.__dict__["project"] = project
        __props__.__dict__["service"] = service
        __props__.__dict__["time_window"] = time_window
        return Slo(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="alertPolicies")
    def alert_policies(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Alert Policies attached to SLO
        """
        return pulumi.get(self, "alert_policies")

    @property
    @pulumi.getter
    def attachments(self) -> pulumi.Output[Optional[Sequence['outputs.SloAttachment']]]:
        return pulumi.get(self, "attachments")

    @property
    @pulumi.getter(name="budgetingMethod")
    def budgeting_method(self) -> pulumi.Output[str]:
        """
        Method which will be use to calculate budget
        """
        return pulumi.get(self, "budgeting_method")

    @property
    @pulumi.getter
    def composite(self) -> pulumi.Output[Optional['outputs.SloComposite']]:
        """
        [Composite SLO documentation](https://docs.nobl9.com/yaml-guide/#slo)
        """
        return pulumi.get(self, "composite")

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
    def indicator(self) -> pulumi.Output['outputs.SloIndicator']:
        return pulumi.get(self, "indicator")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Sequence['outputs.SloLabel']]]:
        """
        [Labels](https://docs.nobl9.com/Features/labels/) containing a single key and a list of values.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def objectives(self) -> pulumi.Output[Sequence['outputs.SloObjective']]:
        """
        [Objectives documentation](https://docs.nobl9.com/yaml-guide#objective)
        """
        return pulumi.get(self, "objectives")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        """
        Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        return pulumi.get(self, "project")

    @property
    @pulumi.getter
    def service(self) -> pulumi.Output[str]:
        """
        Name of the service
        """
        return pulumi.get(self, "service")

    @property
    @pulumi.getter(name="timeWindow")
    def time_window(self) -> pulumi.Output['outputs.SloTimeWindow']:
        return pulumi.get(self, "time_window")

