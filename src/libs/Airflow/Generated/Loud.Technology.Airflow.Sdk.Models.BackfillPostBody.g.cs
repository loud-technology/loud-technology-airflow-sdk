
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Object used for create backfill request.
    /// </summary>
    public sealed partial class BackfillPostBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FromDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ToDate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_backwards")]
        public bool? RunBackwards { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_conf")]
        public object? DagRunConf { get; set; }

        /// <summary>
        /// Internal enum for setting reprocess behavior in a backfill.<br/>
        /// :meta private:<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reprocess_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReprocessBehaviorJsonConverter))]
        public global::Loud.Technology.Airflow.Sdk.ReprocessBehavior? ReprocessBehavior { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_runs")]
        public int? MaxActiveRuns { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_on_latest_version")]
        public bool? RunOnLatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillPostBody" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="runBackwards">
        /// Default Value: false
        /// </param>
        /// <param name="dagRunConf">
        /// Default Value: {}
        /// </param>
        /// <param name="reprocessBehavior">
        /// Internal enum for setting reprocess behavior in a backfill.<br/>
        /// :meta private:<br/>
        /// Default Value: none
        /// </param>
        /// <param name="maxActiveRuns">
        /// Default Value: 10
        /// </param>
        /// <param name="runOnLatestVersion">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackfillPostBody(
            string dagId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            bool? runBackwards,
            object? dagRunConf,
            global::Loud.Technology.Airflow.Sdk.ReprocessBehavior? reprocessBehavior,
            int? maxActiveRuns,
            bool? runOnLatestVersion)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.RunBackwards = runBackwards;
            this.DagRunConf = dagRunConf;
            this.ReprocessBehavior = reprocessBehavior;
            this.MaxActiveRuns = maxActiveRuns;
            this.RunOnLatestVersion = runOnLatestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillPostBody" /> class.
        /// </summary>
        public BackfillPostBody()
        {
        }

    }
}