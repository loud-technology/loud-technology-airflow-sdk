
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Task inlet reference serializer for assets.
    /// </summary>
    public sealed partial class TaskInletAssetReference
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
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInletAssetReference" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskInletAssetReference(
            string dagId,
            string taskId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInletAssetReference" /> class.
        /// </summary>
        public TaskInletAssetReference()
        {
        }

    }
}