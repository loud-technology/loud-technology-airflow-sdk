
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Event Log Response.
    /// </summary>
    public sealed partial class EventLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_log_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventLogId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime When { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        public string? DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_index")]
        public int? MapIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("try_number")]
        public int? TryNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        public global::System.DateTime? LogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        public string? DagDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_display_name")]
        public string? TaskDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventLogResponse" /> class.
        /// </summary>
        /// <param name="eventLogId"></param>
        /// <param name="when"></param>
        /// <param name="event"></param>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="runId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="tryNumber"></param>
        /// <param name="logicalDate"></param>
        /// <param name="owner"></param>
        /// <param name="extra"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="taskDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventLogResponse(
            int eventLogId,
            global::System.DateTime when,
            string @event,
            string? dagId,
            string? taskId,
            string? runId,
            int? mapIndex,
            int? tryNumber,
            global::System.DateTime? logicalDate,
            string? owner,
            string? extra,
            string? dagDisplayName,
            string? taskDisplayName)
        {
            this.EventLogId = eventLogId;
            this.When = when;
            this.DagId = dagId;
            this.TaskId = taskId;
            this.RunId = runId;
            this.MapIndex = mapIndex;
            this.TryNumber = tryNumber;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.LogicalDate = logicalDate;
            this.Owner = owner;
            this.Extra = extra;
            this.DagDisplayName = dagDisplayName;
            this.TaskDisplayName = taskDisplayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventLogResponse" /> class.
        /// </summary>
        public EventLogResponse()
        {
        }

    }
}