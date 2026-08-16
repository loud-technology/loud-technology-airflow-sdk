
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Log serializer for responses.
    /// </summary>
    public sealed partial class TaskInstancesLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.IList<string>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuation_token")]
        public string? ContinuationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesLogResponse" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="continuationToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskInstancesLogResponse(
            global::Loud.Technology.Airflow.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.IList<string>> content,
            string? continuationToken)
        {
            this.Content = content;
            this.ContinuationToken = continuationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesLogResponse" /> class.
        /// </summary>
        public TaskInstancesLogResponse()
        {
        }

    }
}