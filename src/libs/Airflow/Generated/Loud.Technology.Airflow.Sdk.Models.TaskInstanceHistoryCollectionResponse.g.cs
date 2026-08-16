
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// TaskInstanceHistory Collection serializer for responses.
    /// </summary>
    public sealed partial class TaskInstanceHistoryCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_instances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse> TaskInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceHistoryCollectionResponse" /> class.
        /// </summary>
        /// <param name="taskInstances"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskInstanceHistoryCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse> taskInstances,
            int totalEntries)
        {
            this.TaskInstances = taskInstances ?? throw new global::System.ArgumentNullException(nameof(taskInstances));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstanceHistoryCollectionResponse" /> class.
        /// </summary>
        public TaskInstanceHistoryCollectionResponse()
        {
        }

    }
}