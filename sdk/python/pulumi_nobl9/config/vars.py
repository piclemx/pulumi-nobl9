# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

import types

__config__ = pulumi.Config('nobl9')


class _ExportableConfig(types.ModuleType):
    @property
    def client_id(self) -> Optional[str]:
        """
        the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
        Nobl9.
        """
        return __config__.get('clientId')

    @property
    def client_secret(self) -> Optional[str]:
        """
        the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
        to Nobl9.
        """
        return __config__.get('clientSecret')

    @property
    def ingest_url(self) -> Optional[str]:
        """
        Nobl9 API URL.
        """
        return __config__.get('ingestUrl')

    @property
    def okta_auth_server(self) -> Optional[str]:
        """
        Authorization service configuration.
        """
        return __config__.get('oktaAuthServer')

    @property
    def okta_org_url(self) -> Optional[str]:
        """
        Authorization service URL.
        """
        return __config__.get('oktaOrgUrl')

    @property
    def organization(self) -> Optional[str]:
        """
        Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
        contains resources managed by the Nobl9 Terraform provider.
        """
        return __config__.get('organization')

    @property
    def project(self) -> Optional[str]:
        """
        Nobl9 project used when importing resources.
        """
        return __config__.get('project')
