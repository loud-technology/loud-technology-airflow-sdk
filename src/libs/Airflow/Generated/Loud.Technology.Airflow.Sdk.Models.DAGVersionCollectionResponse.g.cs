
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Version Collection serializer for responses.
    /// </summary>
    public sealed partial class DAGVersionCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagVersionResponse> DagVersions { get; set; }

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
        /// Initializes a new instance of the <see cref="DAGVersionCollectionResponse" /> class.
        /// </summary>
        /// <param name="dagVersions"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGVersionCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagVersionResponse> dagVersions,
            int totalEntries)
        {
            this.DagVersions = dagVersions ?? throw new global::System.ArgumentNullException(nameof(dagVersions));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGVersionCollectionResponse" /> class.
        /// </summary>
        public DAGVersionCollectionResponse()
        {
        }

    }
}