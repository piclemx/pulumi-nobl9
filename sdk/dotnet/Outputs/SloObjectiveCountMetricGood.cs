// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Piclemx.Nobl9.Outputs
{

    [OutputType]
    public sealed class SloObjectiveCountMetricGood
    {
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Prometheus/#creating-slos-with-ams-prometheus)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodAmazonPrometheus> AmazonPrometheuses;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/appdynamics#creating-slos-with-appdynamics)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodAppdynamic> Appdynamics;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/azure-monitor#creating-slos-with-azure-monitor)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodAzureMonitor> AzureMonitors;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/bigquery#creating-slos-with-bigquery)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodBigquery> Bigqueries;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_CloudWatch/#creating-slos-with-cloudwatch)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodCloudwatch> Cloudwatches;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/datadog#creating-slos-with-datadog)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodDatadog> Datadogs;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/dynatrace#creating-slos-with-dynatrace)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodDynatrace> Dynatraces;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/elasticsearch#creating-slos-with-elasticsearch)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodElasticsearch> Elasticsearches;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/google-cloud-monitoring#creating-slos-with-google-cloud-monitoring)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodGcm> Gcms;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/grafana-loki#creating-slos-with-grafana-loki)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodGrafanaLoki> GrafanaLokis;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/graphite#creating-slos-with-graphite)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodGraphite> Graphites;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/honeycomb#creating-slos-with-honeycomb)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodHoneycomb> Honeycombs;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/influxdb#creating-slos-with-influxdb)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodInfluxdb> Influxdbs;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/instana#creating-slos-with-instana)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstana> Instanas;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/lightstep#creating-slos-with-lightstep)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodLightstep> Lightsteps;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/new-relic#creating-slos-with-new-relic)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodNewrelic> Newrelics;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/opentsdb#creating-slos-with-opentsdb)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodOpentsdb> Opentsdbs;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/pingdom#creating-slos-with-pingdom)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodPingdom> Pingdoms;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/prometheus#creating-slos-with-prometheus)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodPrometheus> Prometheuses;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/Amazon_Redshift/#creating-slos-with-amazon-redshift)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodRedshift> Redshifts;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk-observability)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodSplunkObservability> SplunkObservabilities;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/splunk#creating-slos-with-splunk)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodSplunk> Splunks;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/sumo-logic#creating-slos-with-sumo-logic)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodSumologic> Sumologics;
        /// <summary>
        /// [Configuration documentation](https://docs.nobl9.com/Sources/thousandeyes#creating-slos-with-thousandeyes)
        /// </summary>
        public readonly ImmutableArray<Outputs.SloObjectiveCountMetricGoodThousandeye> Thousandeyes;

        [OutputConstructor]
        private SloObjectiveCountMetricGood(
            ImmutableArray<Outputs.SloObjectiveCountMetricGoodAmazonPrometheus> amazonPrometheuses,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodAppdynamic> appdynamics,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodAzureMonitor> azureMonitors,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodBigquery> bigqueries,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodCloudwatch> cloudwatches,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodDatadog> datadogs,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodDynatrace> dynatraces,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodElasticsearch> elasticsearches,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodGcm> gcms,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodGrafanaLoki> grafanaLokis,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodGraphite> graphites,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodHoneycomb> honeycombs,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodInfluxdb> influxdbs,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodInstana> instanas,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodLightstep> lightsteps,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodNewrelic> newrelics,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodOpentsdb> opentsdbs,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodPingdom> pingdoms,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodPrometheus> prometheuses,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodRedshift> redshifts,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodSplunkObservability> splunkObservabilities,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodSplunk> splunks,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodSumologic> sumologics,

            ImmutableArray<Outputs.SloObjectiveCountMetricGoodThousandeye> thousandeyes)
        {
            AmazonPrometheuses = amazonPrometheuses;
            Appdynamics = appdynamics;
            AzureMonitors = azureMonitors;
            Bigqueries = bigqueries;
            Cloudwatches = cloudwatches;
            Datadogs = datadogs;
            Dynatraces = dynatraces;
            Elasticsearches = elasticsearches;
            Gcms = gcms;
            GrafanaLokis = grafanaLokis;
            Graphites = graphites;
            Honeycombs = honeycombs;
            Influxdbs = influxdbs;
            Instanas = instanas;
            Lightsteps = lightsteps;
            Newrelics = newrelics;
            Opentsdbs = opentsdbs;
            Pingdoms = pingdoms;
            Prometheuses = prometheuses;
            Redshifts = redshifts;
            SplunkObservabilities = splunkObservabilities;
            Splunks = splunks;
            Sumologics = sumologics;
            Thousandeyes = thousandeyes;
        }
    }
}
