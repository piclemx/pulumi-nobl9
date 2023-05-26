// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Immutable;

namespace Pulumi.Nobl9
{
    public static class Config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "IDE1006", Justification = 
        "Double underscore prefix used to avoid conflicts with variable names.")]
        private sealed class __Value<T>
        {
            private readonly Func<T> _getter;
            private T _value = default!;
            private bool _set;

            public __Value(Func<T> getter)
            {
                _getter = getter;
            }

            public T Get() => _set ? _value : _getter();

            public void Set(T value)
            {
                _value = value;
                _set = true;
            }
        }

        private static readonly Pulumi.Config __config = new Pulumi.Config("nobl9");

        private static readonly __Value<string?> _clientId = new __Value<string?>(() => __config.Get("clientId"));
        /// <summary>
        /// the [Client ID](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect to
        /// Nobl9.
        /// </summary>
        public static string? ClientId
        {
            get => _clientId.Get();
            set => _clientId.Set(value);
        }

        private static readonly __Value<string?> _clientSecret = new __Value<string?>(() => __config.Get("clientSecret"));
        /// <summary>
        /// the [Client Secret](https://docs.nobl9.com/sloctl-user-guide/#configuration) of your Nobl9 account required to connect
        /// to Nobl9.
        /// </summary>
        public static string? ClientSecret
        {
            get => _clientSecret.Get();
            set => _clientSecret.Set(value);
        }

        private static readonly __Value<string?> _ingestUrl = new __Value<string?>(() => __config.Get("ingestUrl"));
        /// <summary>
        /// Nobl9 API URL.
        /// </summary>
        public static string? IngestUrl
        {
            get => _ingestUrl.Get();
            set => _ingestUrl.Set(value);
        }

        private static readonly __Value<string?> _oktaAuthServer = new __Value<string?>(() => __config.Get("oktaAuthServer"));
        /// <summary>
        /// Authorization service configuration.
        /// </summary>
        public static string? OktaAuthServer
        {
            get => _oktaAuthServer.Get();
            set => _oktaAuthServer.Set(value);
        }

        private static readonly __Value<string?> _oktaOrgUrl = new __Value<string?>(() => __config.Get("oktaOrgUrl"));
        /// <summary>
        /// Authorization service URL.
        /// </summary>
        public static string? OktaOrgUrl
        {
            get => _oktaOrgUrl.Get();
            set => _oktaOrgUrl.Set(value);
        }

        private static readonly __Value<string?> _organization = new __Value<string?>(() => __config.Get("organization"));
        /// <summary>
        /// Nobl9 [Organization ID](https://docs.nobl9.com/API_Documentation/api-endpoints-for-slo-annotations/#common-headers) that
        /// contains resources managed by the Nobl9 Terraform provider.
        /// </summary>
        public static string? Organization
        {
            get => _organization.Get();
            set => _organization.Set(value);
        }

        private static readonly __Value<string?> _project = new __Value<string?>(() => __config.Get("project"));
        /// <summary>
        /// Nobl9 project used when importing resources.
        /// </summary>
        public static string? Project
        {
            get => _project.Get();
            set => _project.Set(value);
        }

    }
}