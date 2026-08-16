
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Request body for bulk update, and delete task instances.
    /// </summary>
    public sealed partial class BulkTaskInstanceBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_state")]
        public global::Loud.Technology.Airflow.Sdk.TaskInstanceState? NewState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_index")]
        public int? MapIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTaskInstanceBody" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="newState"></param>
        /// <param name="note"></param>
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
        /// <param name="mapIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkTaskInstanceBody(
            string taskId,
            global::Loud.Technology.Airflow.Sdk.TaskInstanceState? newState,
            string? note,
            bool? includeUpstream,
            bool? includeDownstream,
            bool? includeFuture,
            bool? includePast,
            int? mapIndex)
        {
            this.NewState = newState;
            this.Note = note;
            this.IncludeUpstream = includeUpstream;
            this.IncludeDownstream = includeDownstream;
            this.IncludeFuture = includeFuture;
            this.IncludePast = includePast;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.MapIndex = mapIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkTaskInstanceBody" /> class.
        /// </summary>
        public BulkTaskInstanceBody()
        {
        }

    }
}