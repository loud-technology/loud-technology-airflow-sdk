
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Asset event serializer for responses.
    /// </summary>
    public sealed partial class AssetEventResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_task_id")]
        public string? SourceTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_dag_id")]
        public string? SourceDagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_run_id")]
        public string? SourceRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_map_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SourceMapIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_dagruns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunAssetReference> CreatedDagruns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="assetId"></param>
        /// <param name="sourceMapIndex"></param>
        /// <param name="createdDagruns"></param>
        /// <param name="timestamp"></param>
        /// <param name="uri"></param>
        /// <param name="name"></param>
        /// <param name="group"></param>
        /// <param name="extra"></param>
        /// <param name="sourceTaskId"></param>
        /// <param name="sourceDagId"></param>
        /// <param name="sourceRunId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetEventResponse(
            int id,
            int assetId,
            int sourceMapIndex,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunAssetReference> createdDagruns,
            global::System.DateTime timestamp,
            string? uri,
            string? name,
            string? group,
            object? extra,
            string? sourceTaskId,
            string? sourceDagId,
            string? sourceRunId)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.Uri = uri;
            this.Name = name;
            this.Group = group;
            this.Extra = extra;
            this.SourceTaskId = sourceTaskId;
            this.SourceDagId = sourceDagId;
            this.SourceRunId = sourceRunId;
            this.SourceMapIndex = sourceMapIndex;
            this.CreatedDagruns = createdDagruns ?? throw new global::System.ArgumentNullException(nameof(createdDagruns));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetEventResponse" /> class.
        /// </summary>
        public AssetEventResponse()
        {
        }

    }
}