// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9.Inputs
{

    public sealed class SloObjectiveCountMetricBadArgs : global::Pulumi.ResourceArgs
    {
        [Input("amazonPrometheuses")]
        private InputList<Inputs.SloObjectiveCountMetricBadAmazonPrometheusArgs>? _amazonPrometheuses;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Prometheus/#creating-slos-with-ams-prometheus)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadAmazonPrometheusArgs> AmazonPrometheuses
        {
            get => _amazonPrometheuses ?? (_amazonPrometheuses = new InputList<Inputs.SloObjectiveCountMetricBadAmazonPrometheusArgs>());
            set => _amazonPrometheuses = value;
        }

        [Input("appdynamics")]
        private InputList<Inputs.SloObjectiveCountMetricBadAppdynamicArgs>? _appdynamics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/appdynamics#creating-slos-with-appdynamics)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadAppdynamicArgs> Appdynamics
        {
            get => _appdynamics ?? (_appdynamics = new InputList<Inputs.SloObjectiveCountMetricBadAppdynamicArgs>());
            set => _appdynamics = value;
        }

        [Input("azureMonitors")]
        private InputList<Inputs.SloObjectiveCountMetricBadAzureMonitorArgs>? _azureMonitors;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/azure-monitor#creating-slos-with-azure-monitor)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadAzureMonitorArgs> AzureMonitors
        {
            get => _azureMonitors ?? (_azureMonitors = new InputList<Inputs.SloObjectiveCountMetricBadAzureMonitorArgs>());
            set => _azureMonitors = value;
        }

        [Input("bigqueries")]
        private InputList<Inputs.SloObjectiveCountMetricBadBigqueryArgs>? _bigqueries;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/bigquery#creating-slos-with-bigquery)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadBigqueryArgs> Bigqueries
        {
            get => _bigqueries ?? (_bigqueries = new InputList<Inputs.SloObjectiveCountMetricBadBigqueryArgs>());
            set => _bigqueries = value;
        }

        [Input("cloudwatches")]
        private InputList<Inputs.SloObjectiveCountMetricBadCloudwatchArgs>? _cloudwatches;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#creating-slos-with-cloudwatch)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadCloudwatchArgs> Cloudwatches
        {
            get => _cloudwatches ?? (_cloudwatches = new InputList<Inputs.SloObjectiveCountMetricBadCloudwatchArgs>());
            set => _cloudwatches = value;
        }

        [Input("datadogs")]
        private InputList<Inputs.SloObjectiveCountMetricBadDatadogArgs>? _datadogs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/datadog#creating-slos-with-datadog)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadDatadogArgs> Datadogs
        {
            get => _datadogs ?? (_datadogs = new InputList<Inputs.SloObjectiveCountMetricBadDatadogArgs>());
            set => _datadogs = value;
        }

        [Input("dynatraces")]
        private InputList<Inputs.SloObjectiveCountMetricBadDynatraceArgs>? _dynatraces;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/dynatrace#creating-slos-with-dynatrace)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadDynatraceArgs> Dynatraces
        {
            get => _dynatraces ?? (_dynatraces = new InputList<Inputs.SloObjectiveCountMetricBadDynatraceArgs>());
            set => _dynatraces = value;
        }

        [Input("elasticsearches")]
        private InputList<Inputs.SloObjectiveCountMetricBadElasticsearchArgs>? _elasticsearches;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/elasticsearch#creating-slos-with-elasticsearch)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadElasticsearchArgs> Elasticsearches
        {
            get => _elasticsearches ?? (_elasticsearches = new InputList<Inputs.SloObjectiveCountMetricBadElasticsearchArgs>());
            set => _elasticsearches = value;
        }

        [Input("gcms")]
        private InputList<Inputs.SloObjectiveCountMetricBadGcmArgs>? _gcms;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/google-cloud-monitoring#creating-slos-with-google-cloud-monitoring)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadGcmArgs> Gcms
        {
            get => _gcms ?? (_gcms = new InputList<Inputs.SloObjectiveCountMetricBadGcmArgs>());
            set => _gcms = value;
        }

        [Input("grafanaLokis")]
        private InputList<Inputs.SloObjectiveCountMetricBadGrafanaLokiArgs>? _grafanaLokis;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/grafana-loki#creating-slos-with-grafana-loki)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadGrafanaLokiArgs> GrafanaLokis
        {
            get => _grafanaLokis ?? (_grafanaLokis = new InputList<Inputs.SloObjectiveCountMetricBadGrafanaLokiArgs>());
            set => _grafanaLokis = value;
        }

        [Input("graphites")]
        private InputList<Inputs.SloObjectiveCountMetricBadGraphiteArgs>? _graphites;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/graphite#creating-slos-with-graphite)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadGraphiteArgs> Graphites
        {
            get => _graphites ?? (_graphites = new InputList<Inputs.SloObjectiveCountMetricBadGraphiteArgs>());
            set => _graphites = value;
        }

        [Input("honeycombs")]
        private InputList<Inputs.SloObjectiveCountMetricBadHoneycombArgs>? _honeycombs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/honeycomb#creating-slos-with-honeycomb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadHoneycombArgs> Honeycombs
        {
            get => _honeycombs ?? (_honeycombs = new InputList<Inputs.SloObjectiveCountMetricBadHoneycombArgs>());
            set => _honeycombs = value;
        }

        [Input("influxdbs")]
        private InputList<Inputs.SloObjectiveCountMetricBadInfluxdbArgs>? _influxdbs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/influxdb#creating-slos-with-influxdb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadInfluxdbArgs> Influxdbs
        {
            get => _influxdbs ?? (_influxdbs = new InputList<Inputs.SloObjectiveCountMetricBadInfluxdbArgs>());
            set => _influxdbs = value;
        }

        [Input("instanas")]
        private InputList<Inputs.SloObjectiveCountMetricBadInstanaArgs>? _instanas;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/instana#creating-slos-with-instana)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadInstanaArgs> Instanas
        {
            get => _instanas ?? (_instanas = new InputList<Inputs.SloObjectiveCountMetricBadInstanaArgs>());
            set => _instanas = value;
        }

        [Input("lightsteps")]
        private InputList<Inputs.SloObjectiveCountMetricBadLightstepArgs>? _lightsteps;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/lightstep#creating-slos-with-lightstep)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadLightstepArgs> Lightsteps
        {
            get => _lightsteps ?? (_lightsteps = new InputList<Inputs.SloObjectiveCountMetricBadLightstepArgs>());
            set => _lightsteps = value;
        }

        [Input("newrelics")]
        private InputList<Inputs.SloObjectiveCountMetricBadNewrelicArgs>? _newrelics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/new-relic#creating-slos-with-new-relic)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadNewrelicArgs> Newrelics
        {
            get => _newrelics ?? (_newrelics = new InputList<Inputs.SloObjectiveCountMetricBadNewrelicArgs>());
            set => _newrelics = value;
        }

        [Input("opentsdbs")]
        private InputList<Inputs.SloObjectiveCountMetricBadOpentsdbArgs>? _opentsdbs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/opentsdb#creating-slos-with-opentsdb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadOpentsdbArgs> Opentsdbs
        {
            get => _opentsdbs ?? (_opentsdbs = new InputList<Inputs.SloObjectiveCountMetricBadOpentsdbArgs>());
            set => _opentsdbs = value;
        }

        [Input("pingdoms")]
        private InputList<Inputs.SloObjectiveCountMetricBadPingdomArgs>? _pingdoms;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/pingdom#creating-slos-with-pingdom)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadPingdomArgs> Pingdoms
        {
            get => _pingdoms ?? (_pingdoms = new InputList<Inputs.SloObjectiveCountMetricBadPingdomArgs>());
            set => _pingdoms = value;
        }

        [Input("prometheuses")]
        private InputList<Inputs.SloObjectiveCountMetricBadPrometheusArgs>? _prometheuses;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/prometheus#creating-slos-with-prometheus)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadPrometheusArgs> Prometheuses
        {
            get => _prometheuses ?? (_prometheuses = new InputList<Inputs.SloObjectiveCountMetricBadPrometheusArgs>());
            set => _prometheuses = value;
        }

        [Input("redshifts")]
        private InputList<Inputs.SloObjectiveCountMetricBadRedshiftArgs>? _redshifts;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Redshift/#creating-slos-with-amazon-redshift)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadRedshiftArgs> Redshifts
        {
            get => _redshifts ?? (_redshifts = new InputList<Inputs.SloObjectiveCountMetricBadRedshiftArgs>());
            set => _redshifts = value;
        }

        [Input("splunkObservabilities")]
        private InputList<Inputs.SloObjectiveCountMetricBadSplunkObservabilityArgs>? _splunkObservabilities;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk-observability)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadSplunkObservabilityArgs> SplunkObservabilities
        {
            get => _splunkObservabilities ?? (_splunkObservabilities = new InputList<Inputs.SloObjectiveCountMetricBadSplunkObservabilityArgs>());
            set => _splunkObservabilities = value;
        }

        [Input("splunks")]
        private InputList<Inputs.SloObjectiveCountMetricBadSplunkArgs>? _splunks;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadSplunkArgs> Splunks
        {
            get => _splunks ?? (_splunks = new InputList<Inputs.SloObjectiveCountMetricBadSplunkArgs>());
            set => _splunks = value;
        }

        [Input("sumologics")]
        private InputList<Inputs.SloObjectiveCountMetricBadSumologicArgs>? _sumologics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/sumo-logic#creating-slos-with-sumo-logic)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadSumologicArgs> Sumologics
        {
            get => _sumologics ?? (_sumologics = new InputList<Inputs.SloObjectiveCountMetricBadSumologicArgs>());
            set => _sumologics = value;
        }

        [Input("thousandeyes")]
        private InputList<Inputs.SloObjectiveCountMetricBadThousandeyeArgs>? _thousandeyes;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/thousandeyes#creating-slos-with-thousandeyes)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricBadThousandeyeArgs> Thousandeyes
        {
            get => _thousandeyes ?? (_thousandeyes = new InputList<Inputs.SloObjectiveCountMetricBadThousandeyeArgs>());
            set => _thousandeyes = value;
        }

        public SloObjectiveCountMetricBadArgs()
        {
        }
        public static new SloObjectiveCountMetricBadArgs Empty => new SloObjectiveCountMetricBadArgs();
    }
}