
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Backfill serializer for responses in dry-run mode.
    /// </summary>
    public sealed partial class DryRunBackfillResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LogicalDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DryRunBackfillResponse" /> class.
        /// </summary>
        /// <param name="logicalDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DryRunBackfillResponse(
            global::System.DateTime logicalDate)
        {
            this.LogicalDate = logicalDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DryRunBackfillResponse" /> class.
        /// </summary>
        public DryRunBackfillResponse()
        {
        }

    }
}