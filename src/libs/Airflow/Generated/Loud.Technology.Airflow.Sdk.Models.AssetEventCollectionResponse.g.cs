
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Asset event collection response.
    /// </summary>
    public sealed partial class AssetEventCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetEventResponse> AssetEvents { get; set; }

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
        /// Initializes a new instance of the <see cref="AssetEventCollectionResponse" /> class.
        /// </summary>
        /// <param name="assetEvents"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetEventCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetEventResponse> assetEvents,
            int totalEntries)
        {
            this.AssetEvents = assetEvents ?? throw new global::System.ArgumentNullException(nameof(assetEvents));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetEventCollectionResponse" /> class.
        /// </summary>
        public AssetEventCollectionResponse()
        {
        }

    }
}