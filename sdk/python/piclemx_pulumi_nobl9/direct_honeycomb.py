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

__all__ = ['DirectHoneycombArgs', 'DirectHoneycomb']

@pulumi.input_type
class DirectHoneycombArgs:
    def __init__(__self__, *,
                 project: pulumi.Input[str],
                 api_key: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 historical_data_retrieval: Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']] = None,
                 log_collection_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']] = None,
                 release_channel: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a DirectHoneycomb resource.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] api_key: [required] | Honeycomb API Key.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs'] historical_data_retrieval: [Replay configuration documentation](https://docs.nobl9.com/replay)
        :param pulumi.Input[bool] log_collection_enabled: [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectHoneycombQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] release_channel: Release channel of the created datasource [stable/beta]
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        """
        pulumi.set(__self__, "project", project)
        if api_key is not None:
            pulumi.set(__self__, "api_key", api_key)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if historical_data_retrieval is not None:
            pulumi.set(__self__, "historical_data_retrieval", historical_data_retrieval)
        if log_collection_enabled is not None:
            pulumi.set(__self__, "log_collection_enabled", log_collection_enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if query_delay is not None:
            pulumi.set(__self__, "query_delay", query_delay)
        if release_channel is not None:
            pulumi.set(__self__, "release_channel", release_channel)
        if source_ofs is not None:
            warnings.warn("""'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""", DeprecationWarning)
            pulumi.log.warn("""source_ofs is deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""")
        if source_ofs is not None:
            pulumi.set(__self__, "source_ofs", source_ofs)

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
    @pulumi.getter(name="apiKey")
    def api_key(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | Honeycomb API Key.
        """
        return pulumi.get(self, "api_key")

    @api_key.setter
    def api_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_key", value)

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
    @pulumi.getter(name="historicalDataRetrieval")
    def historical_data_retrieval(self) -> Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']]:
        """
        [Replay configuration documentation](https://docs.nobl9.com/replay)
        """
        return pulumi.get(self, "historical_data_retrieval")

    @historical_data_retrieval.setter
    def historical_data_retrieval(self, value: Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']]):
        pulumi.set(self, "historical_data_retrieval", value)

    @property
    @pulumi.getter(name="logCollectionEnabled")
    def log_collection_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        """
        return pulumi.get(self, "log_collection_enabled")

    @log_collection_enabled.setter
    def log_collection_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "log_collection_enabled", value)

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
    def query_delay(self) -> Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)

    @property
    @pulumi.getter(name="releaseChannel")
    def release_channel(self) -> Optional[pulumi.Input[str]]:
        """
        Release channel of the created datasource [stable/beta]
        """
        return pulumi.get(self, "release_channel")

    @release_channel.setter
    def release_channel(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "release_channel", value)

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        """
        warnings.warn("""'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""", DeprecationWarning)
        pulumi.log.warn("""source_ofs is deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""")

        return pulumi.get(self, "source_ofs")

    @source_ofs.setter
    def source_ofs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "source_ofs", value)


@pulumi.input_type
class _DirectHoneycombState:
    def __init__(__self__, *,
                 api_key: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 historical_data_retrieval: Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']] = None,
                 log_collection_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']] = None,
                 release_channel: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DirectHoneycomb resources.
        :param pulumi.Input[str] api_key: [required] | Honeycomb API Key.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs'] historical_data_retrieval: [Replay configuration documentation](https://docs.nobl9.com/replay)
        :param pulumi.Input[bool] log_collection_enabled: [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input['DirectHoneycombQueryDelayArgs'] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] release_channel: Release channel of the created datasource [stable/beta]
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        :param pulumi.Input[str] status: The status of the created direct.
        """
        if api_key is not None:
            pulumi.set(__self__, "api_key", api_key)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if historical_data_retrieval is not None:
            pulumi.set(__self__, "historical_data_retrieval", historical_data_retrieval)
        if log_collection_enabled is not None:
            pulumi.set(__self__, "log_collection_enabled", log_collection_enabled)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if query_delay is not None:
            pulumi.set(__self__, "query_delay", query_delay)
        if release_channel is not None:
            pulumi.set(__self__, "release_channel", release_channel)
        if source_ofs is not None:
            warnings.warn("""'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""", DeprecationWarning)
            pulumi.log.warn("""source_ofs is deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""")
        if source_ofs is not None:
            pulumi.set(__self__, "source_ofs", source_ofs)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> Optional[pulumi.Input[str]]:
        """
        [required] | Honeycomb API Key.
        """
        return pulumi.get(self, "api_key")

    @api_key.setter
    def api_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_key", value)

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
    @pulumi.getter(name="historicalDataRetrieval")
    def historical_data_retrieval(self) -> Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']]:
        """
        [Replay configuration documentation](https://docs.nobl9.com/replay)
        """
        return pulumi.get(self, "historical_data_retrieval")

    @historical_data_retrieval.setter
    def historical_data_retrieval(self, value: Optional[pulumi.Input['DirectHoneycombHistoricalDataRetrievalArgs']]):
        pulumi.set(self, "historical_data_retrieval", value)

    @property
    @pulumi.getter(name="logCollectionEnabled")
    def log_collection_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        """
        return pulumi.get(self, "log_collection_enabled")

    @log_collection_enabled.setter
    def log_collection_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "log_collection_enabled", value)

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
    def query_delay(self) -> Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']]:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @query_delay.setter
    def query_delay(self, value: Optional[pulumi.Input['DirectHoneycombQueryDelayArgs']]):
        pulumi.set(self, "query_delay", value)

    @property
    @pulumi.getter(name="releaseChannel")
    def release_channel(self) -> Optional[pulumi.Input[str]]:
        """
        Release channel of the created datasource [stable/beta]
        """
        return pulumi.get(self, "release_channel")

    @release_channel.setter
    def release_channel(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "release_channel", value)

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        """
        warnings.warn("""'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""", DeprecationWarning)
        pulumi.log.warn("""source_ofs is deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""")

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


class DirectHoneycomb(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_key: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 historical_data_retrieval: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombHistoricalDataRetrievalArgs']]] = None,
                 log_collection_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombQueryDelayArgs']]] = None,
                 release_channel: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Honeycomb is an observability platform that integrates system metrics with high-cardinality application data for in-depth analysis and swift debugging of complex software systems. Nobl9 connects to Honeycomb for SLI measurement collection and comparison with SLO targets.

        For more information, refer to [Honeycomb Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/honeycomb#hc-direct).

        ## Example Usage

        ```python
        import pulumi
        import piclemx_pulumi_nobl9 as nobl9

        test_honeycomb = nobl9.DirectHoneycomb("test-honeycomb",
            api_key="secret",
            description="desc",
            historical_data_retrieval=nobl9.DirectHoneycombHistoricalDataRetrievalArgs(
                default_durations=[nobl9.DirectHoneycombHistoricalDataRetrievalDefaultDurationArgs(
                    unit="Day",
                    value=7,
                )],
                max_durations=[nobl9.DirectHoneycombHistoricalDataRetrievalMaxDurationArgs(
                    unit="Day",
                    value=7,
                )],
            ),
            log_collection_enabled=True,
            project="terraform",
            query_delay=nobl9.DirectHoneycombQueryDelayArgs(
                unit="Minute",
                value=6,
            ),
            release_channel="beta")
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_key: [required] | Honeycomb API Key.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[pulumi.InputType['DirectHoneycombHistoricalDataRetrievalArgs']] historical_data_retrieval: [Replay configuration documentation](https://docs.nobl9.com/replay)
        :param pulumi.Input[bool] log_collection_enabled: [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectHoneycombQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] release_channel: Release channel of the created datasource [stable/beta]
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DirectHoneycombArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Honeycomb is an observability platform that integrates system metrics with high-cardinality application data for in-depth analysis and swift debugging of complex software systems. Nobl9 connects to Honeycomb for SLI measurement collection and comparison with SLO targets.

        For more information, refer to [Honeycomb Direct | Nobl9 Documentation](https://docs.nobl9.com/Sources/honeycomb#hc-direct).

        ## Example Usage

        ```python
        import pulumi
        import piclemx_pulumi_nobl9 as nobl9

        test_honeycomb = nobl9.DirectHoneycomb("test-honeycomb",
            api_key="secret",
            description="desc",
            historical_data_retrieval=nobl9.DirectHoneycombHistoricalDataRetrievalArgs(
                default_durations=[nobl9.DirectHoneycombHistoricalDataRetrievalDefaultDurationArgs(
                    unit="Day",
                    value=7,
                )],
                max_durations=[nobl9.DirectHoneycombHistoricalDataRetrievalMaxDurationArgs(
                    unit="Day",
                    value=7,
                )],
            ),
            log_collection_enabled=True,
            project="terraform",
            query_delay=nobl9.DirectHoneycombQueryDelayArgs(
                unit="Minute",
                value=6,
            ),
            release_channel="beta")
        ```
        ## Nobl9 Official Documentation

        https://docs.nobl9.com/

        :param str resource_name: The name of the resource.
        :param DirectHoneycombArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DirectHoneycombArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 api_key: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 historical_data_retrieval: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombHistoricalDataRetrievalArgs']]] = None,
                 log_collection_enabled: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 query_delay: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombQueryDelayArgs']]] = None,
                 release_channel: Optional[pulumi.Input[str]] = None,
                 source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DirectHoneycombArgs.__new__(DirectHoneycombArgs)

            __props__.__dict__["api_key"] = None if api_key is None else pulumi.Output.secret(api_key)
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["historical_data_retrieval"] = historical_data_retrieval
            __props__.__dict__["log_collection_enabled"] = log_collection_enabled
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            __props__.__dict__["query_delay"] = query_delay
            __props__.__dict__["release_channel"] = release_channel
            __props__.__dict__["source_ofs"] = source_ofs
            __props__.__dict__["status"] = None
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["apiKey"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(DirectHoneycomb, __self__).__init__(
            'nobl9:index/directHoneycomb:DirectHoneycomb',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            api_key: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            historical_data_retrieval: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombHistoricalDataRetrievalArgs']]] = None,
            log_collection_enabled: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            query_delay: Optional[pulumi.Input[pulumi.InputType['DirectHoneycombQueryDelayArgs']]] = None,
            release_channel: Optional[pulumi.Input[str]] = None,
            source_ofs: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'DirectHoneycomb':
        """
        Get an existing DirectHoneycomb resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_key: [required] | Honeycomb API Key.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[pulumi.InputType['DirectHoneycombHistoricalDataRetrievalArgs']] historical_data_retrieval: [Replay configuration documentation](https://docs.nobl9.com/replay)
        :param pulumi.Input[bool] log_collection_enabled: [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[pulumi.InputType['DirectHoneycombQueryDelayArgs']] query_delay: [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        :param pulumi.Input[str] release_channel: Release channel of the created datasource [stable/beta]
        :param pulumi.Input[Sequence[pulumi.Input[str]]] source_ofs: This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        :param pulumi.Input[str] status: The status of the created direct.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DirectHoneycombState.__new__(_DirectHoneycombState)

        __props__.__dict__["api_key"] = api_key
        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["historical_data_retrieval"] = historical_data_retrieval
        __props__.__dict__["log_collection_enabled"] = log_collection_enabled
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["query_delay"] = query_delay
        __props__.__dict__["release_channel"] = release_channel
        __props__.__dict__["source_ofs"] = source_ofs
        __props__.__dict__["status"] = status
        return DirectHoneycomb(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> pulumi.Output[str]:
        """
        [required] | Honeycomb API Key.
        """
        return pulumi.get(self, "api_key")

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
    @pulumi.getter(name="historicalDataRetrieval")
    def historical_data_retrieval(self) -> pulumi.Output['outputs.DirectHoneycombHistoricalDataRetrieval']:
        """
        [Replay configuration documentation](https://docs.nobl9.com/replay)
        """
        return pulumi.get(self, "historical_data_retrieval")

    @property
    @pulumi.getter(name="logCollectionEnabled")
    def log_collection_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        [Logs documentation](https://docs.nobl9.com/Features/SLO_troubleshooting/event-logs)
        """
        return pulumi.get(self, "log_collection_enabled")

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
    def query_delay(self) -> pulumi.Output['outputs.DirectHoneycombQueryDelay']:
        """
        [Query delay configuration documentation](https://docs.nobl9.com/Features/query-delay). Computed if not provided.
        """
        return pulumi.get(self, "query_delay")

    @property
    @pulumi.getter(name="releaseChannel")
    def release_channel(self) -> pulumi.Output[str]:
        """
        Release channel of the created datasource [stable/beta]
        """
        return pulumi.get(self, "release_channel")

    @property
    @pulumi.getter(name="sourceOfs")
    def source_ofs(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        This value indicated whether the field was a source of metrics and/or services. 'source_of' is deprecated and not used anywhere; however, it's kept for backward compatibility.
        """
        warnings.warn("""'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""", DeprecationWarning)
        pulumi.log.warn("""source_ofs is deprecated: 'source_of' is deprecated and not used anywhere. You can safely remove it from your configuration file.""")

        return pulumi.get(self, "source_ofs")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        The status of the created direct.
        """
        return pulumi.get(self, "status")

