
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// XCom response serializer with native return type.
    /// </summary>
    public sealed partial class XComResponseNative
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        public global::System.DateTime? LogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MapIndex { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XComResponseNative" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="timestamp"></param>
        /// <param name="mapIndex"></param>
        /// <param name="taskId"></param>
        /// <param name="dagId"></param>
        /// <param name="runId"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="taskDisplayName"></param>
        /// <param name="value"></param>
        /// <param name="logicalDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XComResponseNative(
            string key,
            global::System.DateTime timestamp,
            int mapIndex,
            string taskId,
            string dagId,
            string runId,
            string dagDisplayName,
            string taskDisplayName,
            object value,
            global::System.DateTime? logicalDate)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Timestamp = timestamp;
            this.LogicalDate = logicalDate;
            this.MapIndex = mapIndex;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
            this.TaskDisplayName = taskDisplayName ?? throw new global::System.ArgumentNullException(nameof(taskDisplayName));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XComResponseNative" /> class.
        /// </summary>
        public XComResponseNative()
        {
        }

    }
}