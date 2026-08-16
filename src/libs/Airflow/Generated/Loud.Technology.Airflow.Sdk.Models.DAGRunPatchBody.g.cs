
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Run Serializer for PATCH requests.
    /// </summary>
    public sealed partial class DAGRunPatchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Loud.Technology.Airflow.Sdk.DAGRunPatchStates? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunPatchBody" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGRunPatchBody(
            global::Loud.Technology.Airflow.Sdk.DAGRunPatchStates? state,
            string? note)
        {
            this.State = state;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunPatchBody" /> class.
        /// </summary>
        public DAGRunPatchBody()
        {
        }

    }
}