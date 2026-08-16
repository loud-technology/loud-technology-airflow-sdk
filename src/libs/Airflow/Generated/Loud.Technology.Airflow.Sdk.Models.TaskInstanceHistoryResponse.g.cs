
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// TaskInstanceHistory serializer for responses.
    /// </summary>
    public sealed partial class TaskInstanceHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MapIndex { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Loud.Technology.Airflow.Sdk.TaskInstanceState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("try_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unixname")]
        public string? Unixname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PoolSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public string? Queue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority_weight")]
        public int? PriorityWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string? Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_when")]
        public global::System.DateTime? QueuedWhen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_when")]
        public global::System.DateTime? ScheduledWhen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pid")]
        public int? Pid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executor")]
        public string? Executor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executor_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutorConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_version")]
        public global::Loud.Technology.Airflow.Sdk.DagVersionResponse? DagVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceHistoryResponse" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="tryNumber"></param>
        /// <param name="maxTries"></param>
        /// <param name="taskDisplayName"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="pool"></param>
        /// <param name="poolSlots"></param>
        /// <param name="executorConfig"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="duration"></param>
        /// <param name="state"></param>
        /// <param name="hostname"></param>
        /// <param name="unixname"></param>
        /// <param name="queue"></param>
        /// <param name="priorityWeight"></param>
        /// <param name="operator"></param>
        /// <param name="operatorName"></param>
        /// <param name="queuedWhen"></param>
        /// <param name="scheduledWhen"></param>
        /// <param name="pid"></param>
        /// <param name="executor"></param>
        /// <param name="dagVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskInstanceHistoryResponse(
            string taskId,
            string dagId,
            string dagRunId,
            int mapIndex,
            int tryNumber,
            int maxTries,
            string taskDisplayName,
            string dagDisplayName,
            string pool,
            int poolSlots,
            string executorConfig,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            double? duration,
            global::Loud.Technology.Airflow.Sdk.TaskInstanceState? state,
            string? hostname,
            string? unixname,
            string? queue,
            int? priorityWeight,
            string? @operator,
            string? operatorName,
            global::System.DateTime? queuedWhen,
            global::System.DateTime? scheduledWhen,
            int? pid,
            string? executor,
            global::Loud.Technology.Airflow.Sdk.DagVersionResponse? dagVersion)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.DagRunId = dagRunId ?? throw new global::System.ArgumentNullException(nameof(dagRunId));
            this.MapIndex = mapIndex;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.State = state;
            this.TryNumber = tryNumber;
            this.MaxTries = maxTries;
            this.TaskDisplayName = taskDisplayName ?? throw new global::System.ArgumentNullException(nameof(taskDisplayName));
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
            this.Hostname = hostname;
            this.Unixname = unixname;
            this.Pool = pool ?? throw new global::System.ArgumentNullException(nameof(pool));
            this.PoolSlots = poolSlots;
            this.Queue = queue;
            this.PriorityWeight = priorityWeight;
            this.Operator = @operator;
            this.OperatorName = operatorName;
            this.QueuedWhen = queuedWhen;
            this.ScheduledWhen = scheduledWhen;
            this.Pid = pid;
            this.Executor = executor;
            this.ExecutorConfig = executorConfig ?? throw new global::System.ArgumentNullException(nameof(executorConfig));
            this.DagVersion = dagVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceHistoryResponse" /> class.
        /// </summary>
        public TaskInstanceHistoryResponse()
        {
        }

    }
}