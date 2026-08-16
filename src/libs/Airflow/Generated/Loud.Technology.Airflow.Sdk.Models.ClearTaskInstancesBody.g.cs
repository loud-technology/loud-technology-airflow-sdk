
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Request body for Clear Task Instances endpoint.
    /// </summary>
    public sealed partial class ClearTaskInstancesBody
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_failed")]
        public bool? OnlyFailed { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_running")]
        public bool? OnlyRunning { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_dag_runs")]
        public bool? ResetDagRuns { get; set; }

        /// <summary>
        /// A list of `task_id` or [`task_id`, `map_index`]. If only the `task_id` is provided for a mapped task, all of its map indices will be targeted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>>? TaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_id")]
        public string? DagRunId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_upstream")]
        public bool? IncludeUpstream { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_downstream")]
        public bool? IncludeDownstream { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_future")]
        public bool? IncludeFuture { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_past")]
        public bool? IncludePast { get; set; }

        /// <summary>
        /// (Experimental) Run on the latest bundle version of the dag after clearing the task instances.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_on_latest_version")]
        public bool? RunOnLatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearTaskInstancesBody" /> class.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: true
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="onlyFailed">
        /// Default Value: true
        /// </param>
        /// <param name="onlyRunning">
        /// Default Value: false
        /// </param>
        /// <param name="resetDagRuns">
        /// Default Value: true
        /// </param>
        /// <param name="taskIds">
        /// A list of `task_id` or [`task_id`, `map_index`]. If only the `task_id` is provided for a mapped task, all of its map indices will be targeted.
        /// </param>
        /// <param name="dagRunId"></param>
        /// <param name="includeUpstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeDownstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeFuture">
        /// Default Value: false
        /// </param>
        /// <param name="includePast">
        /// Default Value: false
        /// </param>
        /// <param name="runOnLatestVersion">
        /// (Experimental) Run on the latest bundle version of the dag after clearing the task instances.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClearTaskInstancesBody(
            bool? dryRun,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            bool? onlyFailed,
            bool? onlyRunning,
            bool? resetDagRuns,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>>? taskIds,
            string? dagRunId,
            bool? includeUpstream,
            bool? includeDownstream,
            bool? includeFuture,
            bool? includePast,
            bool? runOnLatestVersion)
        {
            this.DryRun = dryRun;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.OnlyFailed = onlyFailed;
            this.OnlyRunning = onlyRunning;
            this.ResetDagRuns = resetDagRuns;
            this.TaskIds = taskIds;
            this.DagRunId = dagRunId;
            this.IncludeUpstream = includeUpstream;
            this.IncludeDownstream = includeDownstream;
            this.IncludeFuture = includeFuture;
            this.IncludePast = includePast;
            this.RunOnLatestVersion = runOnLatestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearTaskInstancesBody" /> class.
        /// </summary>
        public ClearTaskInstancesBody()
        {
        }

    }
}