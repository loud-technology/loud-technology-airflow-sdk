
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Tag serializer for responses.
    /// </summary>
    public sealed partial class DagTagResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

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
        /// Initializes a new instance of the <see cref="DagTagResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dagId"></param>
        /// <param name="dagDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagTagResponse(
            string name,
            string dagId,
            string dagDisplayName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagTagResponse" /> class.
        /// </summary>
        public DagTagResponse()
        {
        }

    }
}