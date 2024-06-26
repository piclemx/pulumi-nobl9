# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import errno
import os
from setuptools import setup, find_packages
from setuptools.command.install import install
from subprocess import check_call


VERSION = os.getenv("PULUMI_PYTHON_VERSION", "0.0.0")
def readme():
    try:
        with open('README.md', encoding='utf-8') as f:
            return f.read()
    except FileNotFoundError:
        return "nobl9 Pulumi Package - Development Version"


setup(name='piclemx_pulumi_nobl9',
      python_requires='>=3.7',
      version=VERSION,
      description="A Pulumi package for creating and managing Nobl9 resources",
      long_description=readme(),
      long_description_content_type='text/markdown',
      keywords='pulumi nobl9 category/monitoring',
      url='https://github.com/piclemx/pulumi-nobl9',
      project_urls={
          'Repository': 'https://github.com/piclemx/pulumi-nobl9'
      },
      license='Apache-2.0',
      packages=find_packages(),
      package_data={
          'piclemx_pulumi_nobl9': [
              'py.typed',
              'pulumi-plugin.json',
          ]
      },
      install_requires=[
          'importlib-metadata>=6.0.0,<7.0.0; python_version < "3.8"',
          'parver>=0.2.1',
          'pulumi>=3.0.0,<4.0.0',
          'semver>=2.8.1'
      ],
      zip_safe=False)
