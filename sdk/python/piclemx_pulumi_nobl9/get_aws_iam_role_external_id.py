# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetAwsIamRoleExternalIdResult',
    'AwaitableGetAwsIamRoleExternalIdResult',
    'get_aws_iam_role_external_id',
    'get_aws_iam_role_external_id_output',
]

@pulumi.output_type
class GetAwsIamRoleExternalIdResult:
    """
    A collection of values returned by getAwsIamRoleExternalId.
    """
    def __init__(__self__, account_id=None, external_id=None, id=None, name=None):
        if account_id and not isinstance(account_id, str):
            raise TypeError("Expected argument 'account_id' to be a str")
        pulumi.set(__self__, "account_id", account_id)
        if external_id and not isinstance(external_id, str):
            raise TypeError("Expected argument 'external_id' to be a str")
        pulumi.set(__self__, "external_id", external_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> str:
        """
        External ID
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="externalId")
    def external_id(self) -> str:
        """
        Nobl9 AWS Account ID
        """
        return pulumi.get(self, "external_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Data source name
        """
        return pulumi.get(self, "name")


class AwaitableGetAwsIamRoleExternalIdResult(GetAwsIamRoleExternalIdResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAwsIamRoleExternalIdResult(
            account_id=self.account_id,
            external_id=self.external_id,
            id=self.id,
            name=self.name)


def get_aws_iam_role_external_id(name: Optional[str] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAwsIamRoleExternalIdResult:
    """
    Returns external ID and AWS account ID that can be used to create [cross-account IAM roles in AWS](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cross-account-iam-roles-new).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nobl9 as nobl9

    this = nobl9.get_aws_iam_role_external_id(name="my-datasource-name")
    ```


    :param str name: Data source name
    """
    __args__ = dict()
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('nobl9:index/getAwsIamRoleExternalId:getAwsIamRoleExternalId', __args__, opts=opts, typ=GetAwsIamRoleExternalIdResult).value

    return AwaitableGetAwsIamRoleExternalIdResult(
        account_id=pulumi.get(__ret__, 'account_id'),
        external_id=pulumi.get(__ret__, 'external_id'),
        id=pulumi.get(__ret__, 'id'),
        name=pulumi.get(__ret__, 'name'))


@_utilities.lift_output_func(get_aws_iam_role_external_id)
def get_aws_iam_role_external_id_output(name: Optional[pulumi.Input[str]] = None,
                                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAwsIamRoleExternalIdResult]:
    """
    Returns external ID and AWS account ID that can be used to create [cross-account IAM roles in AWS](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#cross-account-iam-roles-new).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_nobl9 as nobl9

    this = nobl9.get_aws_iam_role_external_id(name="my-datasource-name")
    ```


    :param str name: Data source name
    """
    ...