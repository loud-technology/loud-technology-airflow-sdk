
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Run serializer for responses.
    /// </summary>
    public sealed partial class DAGRunResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        public global::System.DateTime? LogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_at")]
        public global::System.DateTime? QueuedAt { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_interval_start")]
        public global::System.DateTime? DataIntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_interval_end")]
        public global::System.DateTime? DataIntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RunAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_scheduling_decision")]
        public global::System.DateTime? LastSchedulingDecision { get; set; }

        /// <summary>
        /// Class with DagRun types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.DagRunType RunType { get; set; }

        /// <summary>
        /// All possible states that a DagRun can be in.<br/>
        /// These are "shared" with TaskInstanceState in some parts of the code,<br/>
        /// so please ensure that their values always match the ones with the<br/>
        /// same name in TaskInstanceState.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.DagRunState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_by")]
        public global::Loud.Technology.Airflow.Sdk.DagRunTriggeredByType? TriggeredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggering_user_name")]
        public string? TriggeringUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conf")]
        public object? Conf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagVersionResponse> DagVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_version")]
        public string? BundleVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunResponse" /> class.
        /// </summary>
        /// <param name="dagRunId"></param>
        /// <param name="dagId"></param>
        /// <param name="runAfter"></param>
        /// <param name="runType">
        /// Class with DagRun types.
        /// </param>
        /// <param name="state">
        /// All possible states that a DagRun can be in.<br/>
        /// These are "shared" with TaskInstanceState in some parts of the code,<br/>
        /// so please ensure that their values always match the ones with the<br/>
        /// same name in TaskInstanceState.
        /// </param>
        /// <param name="dagVersions"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="logicalDate"></param>
        /// <param name="queuedAt"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="duration"></param>
        /// <param name="dataIntervalStart"></param>
        /// <param name="dataIntervalEnd"></param>
        /// <param name="lastSchedulingDecision"></param>
        /// <param name="triggeredBy"></param>
        /// <param name="triggeringUserName"></param>
        /// <param name="conf"></param>
        /// <param name="note"></param>
        /// <param name="bundleVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGRunResponse(
            string dagRunId,
            string dagId,
            global::System.DateTime runAfter,
            global::Loud.Technology.Airflow.Sdk.DagRunType runType,
            global::Loud.Technology.Airflow.Sdk.DagRunState state,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagVersionResponse> dagVersions,
            string dagDisplayName,
            global::System.DateTime? logicalDate,
            global::System.DateTime? queuedAt,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            double? duration,
            global::System.DateTime? dataIntervalStart,
            global::System.DateTime? dataIntervalEnd,
            global::System.DateTime? lastSchedulingDecision,
            global::Loud.Technology.Airflow.Sdk.DagRunTriggeredByType? triggeredBy,
            string? triggeringUserName,
            object? conf,
            string? note,
            string? bundleVersion)
        {
            this.DagRunId = dagRunId ?? throw new global::System.ArgumentNullException(nameof(dagRunId));
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.LogicalDate = logicalDate;
            this.QueuedAt = queuedAt;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.DataIntervalStart = dataIntervalStart;
            this.DataIntervalEnd = dataIntervalEnd;
            this.RunAfter = runAfter;
            this.LastSchedulingDecision = lastSchedulingDecision;
            this.RunType = runType;
            this.State = state;
            this.TriggeredBy = triggeredBy;
            this.TriggeringUserName = triggeringUserName;
            this.Conf = conf;
            this.Note = note;
            this.DagVersions = dagVersions ?? throw new global::System.ArgumentNullException(nameof(dagVersions));
            this.BundleVersion = bundleVersion;
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunResponse" /> class.
        /// </summary>
        public DAGRunResponse()
        {
        }

    }
}