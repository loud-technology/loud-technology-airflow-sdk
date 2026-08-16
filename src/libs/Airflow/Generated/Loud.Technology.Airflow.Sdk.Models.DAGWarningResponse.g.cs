
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Warning serializer for responses.
    /// </summary>
    public sealed partial class DAGWarningResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// Enum for DAG warning types.<br/>
        /// This is the set of allowable values for the ``warning_type`` field<br/>
        /// in the DagWarning model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagWarningTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.DagWarningType WarningType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

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
        /// Initializes a new instance of the <see cref="DAGWarningResponse" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="warningType">
        /// Enum for DAG warning types.<br/>
        /// This is the set of allowable values for the ``warning_type`` field<br/>
        /// in the DagWarning model.
        /// </param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="dagDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGWarningResponse(
            string dagId,
            global::Loud.Technology.Airflow.Sdk.DagWarningType warningType,
            string message,
            global::System.DateTime timestamp,
            string dagDisplayName)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.WarningType = warningType;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp;
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGWarningResponse" /> class.
        /// </summary>
        public DAGWarningResponse()
        {
        }

    }
}