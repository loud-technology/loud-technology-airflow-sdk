
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Create asset events request.
    /// </summary>
    public sealed partial class CreateAssetEventsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetEventsBody" /> class.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="extra"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetEventsBody(
            int assetId,
            object? extra)
        {
            this.AssetId = assetId;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetEventsBody" /> class.
        /// </summary>
        public CreateAssetEventsBody()
        {
        }

    }
}