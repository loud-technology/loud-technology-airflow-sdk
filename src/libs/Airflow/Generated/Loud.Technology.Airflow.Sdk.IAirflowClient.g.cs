
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Airflow API. All endpoints located under ``/api/v2`` can be used safely, are stable and backward compatible. Endpoints located under ``/ui`` are dedicated to the UI and are subject to breaking change depending on the need of the frontend. Users should not rely on those but use the public ones instead.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IAirflowClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Loud.Technology.Airflow.Sdk.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AssetClient Asset { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackfillClient Backfill { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConfigClient Config { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConnectionClient Connection { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagClient Dag { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagParsingClient DagParsing { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagRunClient DagRun { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagSourceClient DagSource { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagStatsClient DagStats { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagVersionClient DagVersion { get; }

        /// <summary>
        /// 
        /// </summary>
        public DagWarningClient DagWarning { get; }

        /// <summary>
        /// 
        /// </summary>
        public EventLogClient EventLog { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExtraLinksClient ExtraLinks { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImportErrorClient ImportError { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobClient Job { get; }

        /// <summary>
        /// 
        /// </summary>
        public LoginClient Login { get; }

        /// <summary>
        /// 
        /// </summary>
        public MonitorClient Monitor { get; }

        /// <summary>
        /// 
        /// </summary>
        public PluginClient Plugin { get; }

        /// <summary>
        /// 
        /// </summary>
        public PoolClient Pool { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProviderClient Provider { get; }

        /// <summary>
        /// 
        /// </summary>
        public TaskClient Task { get; }

        /// <summary>
        /// 
        /// </summary>
        public TaskInstanceClient TaskInstance { get; }

        /// <summary>
        /// 
        /// </summary>
        public VariableClient Variable { get; }

        /// <summary>
        /// 
        /// </summary>
        public VersionClient Version { get; }

        /// <summary>
        /// 
        /// </summary>
        public XComClient XCom { get; }

    }
}