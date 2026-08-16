
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Last asset event response serializer.
    /// </summary>
    public sealed partial class LastAssetEventResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastAssetEventResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LastAssetEventResponse(
            int? id,
            global::System.DateTime? timestamp)
        {
            this.Id = id;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastAssetEventResponse" /> class.
        /// </summary>
        public LastAssetEventResponse()
        {
        }

    }
}