
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Asset collection response.
    /// </summary>
    public sealed partial class AssetCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetResponse> Assets { get; set; }

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
        /// Initializes a new instance of the <see cref="AssetCollectionResponse" /> class.
        /// </summary>
        /// <param name="assets"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetResponse> assets,
            int totalEntries)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetCollectionResponse" /> class.
        /// </summary>
        public AssetCollectionResponse()
        {
        }

    }
}