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

    public sealed class SloObjectiveCountMetricTotalGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("amazonPrometheuses")]
        private InputList<Inputs.SloObjectiveCountMetricTotalAmazonPrometheusGetArgs>? _amazonPrometheuses;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Prometheus/#creating-slos-with-ams-prometheus)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalAmazonPrometheusGetArgs> AmazonPrometheuses
        {
            get => _amazonPrometheuses ?? (_amazonPrometheuses = new InputList<Inputs.SloObjectiveCountMetricTotalAmazonPrometheusGetArgs>());
            set => _amazonPrometheuses = value;
        }

        [Input("appdynamics")]
        private InputList<Inputs.SloObjectiveCountMetricTotalAppdynamicGetArgs>? _appdynamics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/appdynamics#creating-slos-with-appdynamics)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalAppdynamicGetArgs> Appdynamics
        {
            get => _appdynamics ?? (_appdynamics = new InputList<Inputs.SloObjectiveCountMetricTotalAppdynamicGetArgs>());
            set => _appdynamics = value;
        }

        [Input("azureMonitors")]
        private InputList<Inputs.SloObjectiveCountMetricTotalAzureMonitorGetArgs>? _azureMonitors;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/azure-monitor#creating-slos-with-azure-monitor)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalAzureMonitorGetArgs> AzureMonitors
        {
            get => _azureMonitors ?? (_azureMonitors = new InputList<Inputs.SloObjectiveCountMetricTotalAzureMonitorGetArgs>());
            set => _azureMonitors = value;
        }

        [Input("bigqueries")]
        private InputList<Inputs.SloObjectiveCountMetricTotalBigqueryGetArgs>? _bigqueries;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/bigquery#creating-slos-with-bigquery)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalBigqueryGetArgs> Bigqueries
        {
            get => _bigqueries ?? (_bigqueries = new InputList<Inputs.SloObjectiveCountMetricTotalBigqueryGetArgs>());
            set => _bigqueries = value;
        }

        [Input("cloudwatches")]
        private InputList<Inputs.SloObjectiveCountMetricTotalCloudwatchGetArgs>? _cloudwatches;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#creating-slos-with-cloudwatch)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalCloudwatchGetArgs> Cloudwatches
        {
            get => _cloudwatches ?? (_cloudwatches = new InputList<Inputs.SloObjectiveCountMetricTotalCloudwatchGetArgs>());
            set => _cloudwatches = value;
        }

        [Input("datadogs")]
        private InputList<Inputs.SloObjectiveCountMetricTotalDatadogGetArgs>? _datadogs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/datadog#creating-slos-with-datadog)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalDatadogGetArgs> Datadogs
        {
            get => _datadogs ?? (_datadogs = new InputList<Inputs.SloObjectiveCountMetricTotalDatadogGetArgs>());
            set => _datadogs = value;
        }

        [Input("dynatraces")]
        private InputList<Inputs.SloObjectiveCountMetricTotalDynatraceGetArgs>? _dynatraces;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/dynatrace#creating-slos-with-dynatrace)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalDynatraceGetArgs> Dynatraces
        {
            get => _dynatraces ?? (_dynatraces = new InputList<Inputs.SloObjectiveCountMetricTotalDynatraceGetArgs>());
            set => _dynatraces = value;
        }

        [Input("elasticsearches")]
        private InputList<Inputs.SloObjectiveCountMetricTotalElasticsearchGetArgs>? _elasticsearches;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/elasticsearch#creating-slos-with-elasticsearch)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalElasticsearchGetArgs> Elasticsearches
        {
            get => _elasticsearches ?? (_elasticsearches = new InputList<Inputs.SloObjectiveCountMetricTotalElasticsearchGetArgs>());
            set => _elasticsearches = value;
        }

        [Input("gcms")]
        private InputList<Inputs.SloObjectiveCountMetricTotalGcmGetArgs>? _gcms;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/google-cloud-monitoring#creating-slos-with-google-cloud-monitoring)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalGcmGetArgs> Gcms
        {
            get => _gcms ?? (_gcms = new InputList<Inputs.SloObjectiveCountMetricTotalGcmGetArgs>());
            set => _gcms = value;
        }

        [Input("grafanaLokis")]
        private InputList<Inputs.SloObjectiveCountMetricTotalGrafanaLokiGetArgs>? _grafanaLokis;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/grafana-loki#creating-slos-with-grafana-loki)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalGrafanaLokiGetArgs> GrafanaLokis
        {
            get => _grafanaLokis ?? (_grafanaLokis = new InputList<Inputs.SloObjectiveCountMetricTotalGrafanaLokiGetArgs>());
            set => _grafanaLokis = value;
        }

        [Input("graphites")]
        private InputList<Inputs.SloObjectiveCountMetricTotalGraphiteGetArgs>? _graphites;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/graphite#creating-slos-with-graphite)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalGraphiteGetArgs> Graphites
        {
            get => _graphites ?? (_graphites = new InputList<Inputs.SloObjectiveCountMetricTotalGraphiteGetArgs>());
            set => _graphites = value;
        }

        [Input("honeycombs")]
        private InputList<Inputs.SloObjectiveCountMetricTotalHoneycombGetArgs>? _honeycombs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/honeycomb#creating-slos-with-honeycomb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalHoneycombGetArgs> Honeycombs
        {
            get => _honeycombs ?? (_honeycombs = new InputList<Inputs.SloObjectiveCountMetricTotalHoneycombGetArgs>());
            set => _honeycombs = value;
        }

        [Input("influxdbs")]
        private InputList<Inputs.SloObjectiveCountMetricTotalInfluxdbGetArgs>? _influxdbs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/influxdb#creating-slos-with-influxdb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalInfluxdbGetArgs> Influxdbs
        {
            get => _influxdbs ?? (_influxdbs = new InputList<Inputs.SloObjectiveCountMetricTotalInfluxdbGetArgs>());
            set => _influxdbs = value;
        }

        [Input("instanas")]
        private InputList<Inputs.SloObjectiveCountMetricTotalInstanaGetArgs>? _instanas;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/instana#creating-slos-with-instana)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalInstanaGetArgs> Instanas
        {
            get => _instanas ?? (_instanas = new InputList<Inputs.SloObjectiveCountMetricTotalInstanaGetArgs>());
            set => _instanas = value;
        }

        [Input("lightsteps")]
        private InputList<Inputs.SloObjectiveCountMetricTotalLightstepGetArgs>? _lightsteps;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/lightstep#creating-slos-with-lightstep)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalLightstepGetArgs> Lightsteps
        {
            get => _lightsteps ?? (_lightsteps = new InputList<Inputs.SloObjectiveCountMetricTotalLightstepGetArgs>());
            set => _lightsteps = value;
        }

        [Input("newrelics")]
        private InputList<Inputs.SloObjectiveCountMetricTotalNewrelicGetArgs>? _newrelics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/new-relic#creating-slos-with-new-relic)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalNewrelicGetArgs> Newrelics
        {
            get => _newrelics ?? (_newrelics = new InputList<Inputs.SloObjectiveCountMetricTotalNewrelicGetArgs>());
            set => _newrelics = value;
        }

        [Input("opentsdbs")]
        private InputList<Inputs.SloObjectiveCountMetricTotalOpentsdbGetArgs>? _opentsdbs;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/opentsdb#creating-slos-with-opentsdb)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalOpentsdbGetArgs> Opentsdbs
        {
            get => _opentsdbs ?? (_opentsdbs = new InputList<Inputs.SloObjectiveCountMetricTotalOpentsdbGetArgs>());
            set => _opentsdbs = value;
        }

        [Input("pingdoms")]
        private InputList<Inputs.SloObjectiveCountMetricTotalPingdomGetArgs>? _pingdoms;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/pingdom#creating-slos-with-pingdom)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalPingdomGetArgs> Pingdoms
        {
            get => _pingdoms ?? (_pingdoms = new InputList<Inputs.SloObjectiveCountMetricTotalPingdomGetArgs>());
            set => _pingdoms = value;
        }

        [Input("prometheuses")]
        private InputList<Inputs.SloObjectiveCountMetricTotalPrometheusGetArgs>? _prometheuses;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/prometheus#creating-slos-with-prometheus)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalPrometheusGetArgs> Prometheuses
        {
            get => _prometheuses ?? (_prometheuses = new InputList<Inputs.SloObjectiveCountMetricTotalPrometheusGetArgs>());
            set => _prometheuses = value;
        }

        [Input("redshifts")]
        private InputList<Inputs.SloObjectiveCountMetricTotalRedshiftGetArgs>? _redshifts;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Redshift/#creating-slos-with-amazon-redshift)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalRedshiftGetArgs> Redshifts
        {
            get => _redshifts ?? (_redshifts = new InputList<Inputs.SloObjectiveCountMetricTotalRedshiftGetArgs>());
            set => _redshifts = value;
        }

        [Input("splunkObservabilities")]
        private InputList<Inputs.SloObjectiveCountMetricTotalSplunkObservabilityGetArgs>? _splunkObservabilities;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk-observability)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalSplunkObservabilityGetArgs> SplunkObservabilities
        {
            get => _splunkObservabilities ?? (_splunkObservabilities = new InputList<Inputs.SloObjectiveCountMetricTotalSplunkObservabilityGetArgs>());
            set => _splunkObservabilities = value;
        }

        [Input("splunks")]
        private InputList<Inputs.SloObjectiveCountMetricTotalSplunkGetArgs>? _splunks;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalSplunkGetArgs> Splunks
        {
            get => _splunks ?? (_splunks = new InputList<Inputs.SloObjectiveCountMetricTotalSplunkGetArgs>());
            set => _splunks = value;
        }

        [Input("sumologics")]
        private InputList<Inputs.SloObjectiveCountMetricTotalSumologicGetArgs>? _sumologics;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/sumo-logic#creating-slos-with-sumo-logic)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalSumologicGetArgs> Sumologics
        {
            get => _sumologics ?? (_sumologics = new InputList<Inputs.SloObjectiveCountMetricTotalSumologicGetArgs>());
            set => _sumologics = value;
        }

        [Input("thousandeyes")]
        private InputList<Inputs.SloObjectiveCountMetricTotalThousandeyeGetArgs>? _thousandeyes;

        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/thousandeyes#creating-slos-with-thousandeyes)
        /// </summary>
        public InputList<Inputs.SloObjectiveCountMetricTotalThousandeyeGetArgs> Thousandeyes
        {
            get => _thousandeyes ?? (_thousandeyes = new InputList<Inputs.SloObjectiveCountMetricTotalThousandeyeGetArgs>());
            set => _thousandeyes = value;
        }

        public SloObjectiveCountMetricTotalGetArgs()
        {
        }
        public static new SloObjectiveCountMetricTotalGetArgs Empty => new SloObjectiveCountMetricTotalGetArgs();
    }
}
