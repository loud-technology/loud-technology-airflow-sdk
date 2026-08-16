
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Queued Event serializer for responses..
    /// </summary>
    public sealed partial class QueuedEventResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="QueuedEventResponse" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="assetId"></param>
        /// <param name="createdAt"></param>
        /// <param name="dagDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueuedEventResponse(
            string dagId,
            int assetId,
            global::System.DateTime createdAt,
            string dagDisplayName)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.AssetId = assetId;
            this.CreatedAt = createdAt;
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedEventResponse" /> class.
        /// </summary>
        public QueuedEventResponse()
        {
        }

    }
}