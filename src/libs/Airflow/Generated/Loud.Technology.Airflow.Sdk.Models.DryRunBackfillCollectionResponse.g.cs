
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Backfill collection serializer for responses in dry-run mode.
    /// </summary>
    public sealed partial class DryRunBackfillCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DryRunBackfillResponse> Backfills { get; set; }

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
        /// Initializes a new instance of the <see cref="DryRunBackfillCollectionResponse" /> class.
        /// </summary>
        /// <param name="backfills"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DryRunBackfillCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DryRunBackfillResponse> backfills,
            int totalEntries)
        {
            this.Backfills = backfills ?? throw new global::System.ArgumentNullException(nameof(backfills));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DryRunBackfillCollectionResponse" /> class.
        /// </summary>
        public DryRunBackfillCollectionResponse()
        {
        }

    }
}