
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Task serializer for responses.
    /// </summary>
    public sealed partial class TaskResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_display_name")]
        public string? TaskDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_rule")]
        public string? TriggerRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depends_on_past")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DependsOnPast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_downstream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WaitForDownstream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retries")]
        public double? Retries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        public string? Queue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool")]
        public string? Pool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_slots")]
        public double? PoolSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_timeout")]
        public global::Loud.Technology.Airflow.Sdk.TimeDelta? ExecutionTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_delay")]
        public global::Loud.Technology.Airflow.Sdk.TimeDelta? RetryDelay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_exponential_backoff")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RetryExponentialBackoff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority_weight")]
        public double? PriorityWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_rule")]
        public string? WeightRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_color")]
        public string? UiColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_fgcolor")]
        public string? UiFgcolor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_fields")]
        public global::System.Collections.Generic.IList<string>? TemplateFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstream_task_ids")]
        public global::System.Collections.Generic.IList<string>? DownstreamTaskIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_md")]
        public string? DocMd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator_name")]
        public string? OperatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_ref")]
        public object? ClassRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mapped")]
        public bool? IsMapped { get; set; }

        /// <summary>
        /// Extract and return extra_links.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_links")]
        public global::System.Collections.Generic.IList<string> ExtraLinks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        /// <param name="dependsOnPast"></param>
        /// <param name="waitForDownstream"></param>
        /// <param name="retryExponentialBackoff"></param>
        /// <param name="taskId"></param>
        /// <param name="taskDisplayName"></param>
        /// <param name="owner"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="triggerRule"></param>
        /// <param name="retries"></param>
        /// <param name="queue"></param>
        /// <param name="pool"></param>
        /// <param name="poolSlots"></param>
        /// <param name="executionTimeout"></param>
        /// <param name="retryDelay"></param>
        /// <param name="priorityWeight"></param>
        /// <param name="weightRule"></param>
        /// <param name="uiColor"></param>
        /// <param name="uiFgcolor"></param>
        /// <param name="templateFields"></param>
        /// <param name="downstreamTaskIds"></param>
        /// <param name="docMd"></param>
        /// <param name="operatorName"></param>
        /// <param name="params"></param>
        /// <param name="classRef"></param>
        /// <param name="isMapped"></param>
        /// <param name="extraLinks">
        /// Extract and return extra_links.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskResponse(
            bool dependsOnPast,
            bool waitForDownstream,
            bool retryExponentialBackoff,
            string? taskId,
            string? taskDisplayName,
            string? owner,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            string? triggerRule,
            double? retries,
            string? queue,
            string? pool,
            double? poolSlots,
            global::Loud.Technology.Airflow.Sdk.TimeDelta? executionTimeout,
            global::Loud.Technology.Airflow.Sdk.TimeDelta? retryDelay,
            double? priorityWeight,
            string? weightRule,
            string? uiColor,
            string? uiFgcolor,
            global::System.Collections.Generic.IList<string>? templateFields,
            global::System.Collections.Generic.IList<string>? downstreamTaskIds,
            string? docMd,
            string? operatorName,
            object? @params,
            object? classRef,
            bool? isMapped,
            global::System.Collections.Generic.IList<string> extraLinks = default!)
        {
            this.TaskId = taskId;
            this.TaskDisplayName = taskDisplayName;
            this.Owner = owner;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TriggerRule = triggerRule;
            this.DependsOnPast = dependsOnPast;
            this.WaitForDownstream = waitForDownstream;
            this.Retries = retries;
            this.Queue = queue;
            this.Pool = pool;
            this.PoolSlots = poolSlots;
            this.ExecutionTimeout = executionTimeout;
            this.RetryDelay = retryDelay;
            this.RetryExponentialBackoff = retryExponentialBackoff;
            this.PriorityWeight = priorityWeight;
            this.WeightRule = weightRule;
            this.UiColor = uiColor;
            this.UiFgcolor = uiFgcolor;
            this.TemplateFields = templateFields;
            this.DownstreamTaskIds = downstreamTaskIds;
            this.DocMd = docMd;
            this.OperatorName = operatorName;
            this.Params = @params;
            this.ClassRef = classRef;
            this.IsMapped = isMapped;
            this.ExtraLinks = extraLinks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        public TaskResponse()
        {
        }

    }
}