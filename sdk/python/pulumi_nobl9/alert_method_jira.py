# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['AlertMethodJiraArgs', 'AlertMethodJira']

@pulumi.input_type
class AlertMethodJiraArgs:
    def __init__(__self__, *,
                 project: pulumi.Input[str],
                 project_key: pulumi.Input[str],
                 url: pulumi.Input[str],
                 username: pulumi.Input[str],
                 apitoken: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a AlertMethodJira resource.
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project_key: The code of the Jira project.
        :param pulumi.Input[str] url: Jira instance URL. The `https://` prefix is required.
        :param pulumi.Input[str] username: Jira username for the owner of the API Token.
        :param pulumi.Input[str] apitoken: [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        """
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "project_key", project_key)
        pulumi.set(__self__, "url", url)
        pulumi.set(__self__, "username", username)
        if apitoken is not None:
            pulumi.set(__self__, "apitoken", apitoken)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)

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
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Input[str]:
        """
        The code of the Jira project.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter
    def url(self) -> pulumi.Input[str]:
        """
        Jira instance URL. The `https://` prefix is required.
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: pulumi.Input[str]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter
    def username(self) -> pulumi.Input[str]:
        """
        Jira username for the owner of the API Token.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: pulumi.Input[str]):
        pulumi.set(self, "username", value)

    @property
    @pulumi.getter
    def apitoken(self) -> Optional[pulumi.Input[str]]:
        """
        [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        """
        return pulumi.get(self, "apitoken")

    @apitoken.setter
    def apitoken(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "apitoken", value)

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


@pulumi.input_type
class _AlertMethodJiraState:
    def __init__(__self__, *,
                 apitoken: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AlertMethodJira resources.
        :param pulumi.Input[str] apitoken: [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project_key: The code of the Jira project.
        :param pulumi.Input[str] url: Jira instance URL. The `https://` prefix is required.
        :param pulumi.Input[str] username: Jira username for the owner of the API Token.
        """
        if apitoken is not None:
            pulumi.set(__self__, "apitoken", apitoken)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if display_name is not None:
            pulumi.set(__self__, "display_name", display_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project is not None:
            pulumi.set(__self__, "project", project)
        if project_key is not None:
            pulumi.set(__self__, "project_key", project_key)
        if url is not None:
            pulumi.set(__self__, "url", url)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def apitoken(self) -> Optional[pulumi.Input[str]]:
        """
        [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        """
        return pulumi.get(self, "apitoken")

    @apitoken.setter
    def apitoken(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "apitoken", value)

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
    @pulumi.getter(name="projectKey")
    def project_key(self) -> Optional[pulumi.Input[str]]:
        """
        The code of the Jira project.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter
    def url(self) -> Optional[pulumi.Input[str]]:
        """
        Jira instance URL. The `https://` prefix is required.
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        """
        Jira username for the owner of the API Token.
        """
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


class AlertMethodJira(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 apitoken: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a AlertMethodJira resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] apitoken: [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project_key: The code of the Jira project.
        :param pulumi.Input[str] url: Jira instance URL. The `https://` prefix is required.
        :param pulumi.Input[str] username: Jira username for the owner of the API Token.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AlertMethodJiraArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a AlertMethodJira resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param AlertMethodJiraArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlertMethodJiraArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 apitoken: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlertMethodJiraArgs.__new__(AlertMethodJiraArgs)

            __props__.__dict__["apitoken"] = apitoken
            __props__.__dict__["description"] = description
            __props__.__dict__["display_name"] = display_name
            __props__.__dict__["name"] = name
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            if project_key is None and not opts.urn:
                raise TypeError("Missing required property 'project_key'")
            __props__.__dict__["project_key"] = project_key
            if url is None and not opts.urn:
                raise TypeError("Missing required property 'url'")
            __props__.__dict__["url"] = url
            if username is None and not opts.urn:
                raise TypeError("Missing required property 'username'")
            __props__.__dict__["username"] = username
        super(AlertMethodJira, __self__).__init__(
            'nobl9:index/alertMethodJira:AlertMethodJira',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            apitoken: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            display_name: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project: Optional[pulumi.Input[str]] = None,
            project_key: Optional[pulumi.Input[str]] = None,
            url: Optional[pulumi.Input[str]] = None,
            username: Optional[pulumi.Input[str]] = None) -> 'AlertMethodJira':
        """
        Get an existing AlertMethodJira resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] apitoken: [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        :param pulumi.Input[str] description: Optional description of the resource. Here, you can add details about who is responsible for the integration (team/owner) or the purpose of creating it.
        :param pulumi.Input[str] display_name: User-friendly display name of the resource.
        :param pulumi.Input[str] name: Unique name of the resource, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project: Name of the Nobl9 project the resource sits in, must conform to the naming convention from [DNS RFC1123](https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names).
        :param pulumi.Input[str] project_key: The code of the Jira project.
        :param pulumi.Input[str] url: Jira instance URL. The `https://` prefix is required.
        :param pulumi.Input[str] username: Jira username for the owner of the API Token.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlertMethodJiraState.__new__(_AlertMethodJiraState)

        __props__.__dict__["apitoken"] = apitoken
        __props__.__dict__["description"] = description
        __props__.__dict__["display_name"] = display_name
        __props__.__dict__["name"] = name
        __props__.__dict__["project"] = project
        __props__.__dict__["project_key"] = project_key
        __props__.__dict__["url"] = url
        __props__.__dict__["username"] = username
        return AlertMethodJira(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def apitoken(self) -> pulumi.Output[str]:
        """
        [API Token](https://support.atlassian.com/atlassian-account/docs/manage-api-tokens-for-your-atlassian-account/) with access rights to the project.
        """
        return pulumi.get(self, "apitoken")

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
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Output[str]:
        """
        The code of the Jira project.
        """
        return pulumi.get(self, "project_key")

    @property
    @pulumi.getter
    def url(self) -> pulumi.Output[str]:
        """
        Jira instance URL. The `https://` prefix is required.
        """
        return pulumi.get(self, "url")

    @property
    @pulumi.getter
    def username(self) -> pulumi.Output[str]:
        """
        Jira username for the owner of the API Token.
        """
        return pulumi.get(self, "username")

