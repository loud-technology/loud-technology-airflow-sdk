
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Schema for a collection of Human-in-the-loop details.
    /// </summary>
    public sealed partial class HITLDetailCollection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hitl_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLDetail> HitlDetails { get; set; }

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
        /// Initializes a new instance of the <see cref="HITLDetailCollection" /> class.
        /// </summary>
        /// <param name="hitlDetails"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HITLDetailCollection(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLDetail> hitlDetails,
            int totalEntries)
        {
            this.HitlDetails = hitlDetails ?? throw new global::System.ArgumentNullException(nameof(hitlDetails));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HITLDetailCollection" /> class.
        /// </summary>
        public HITLDetailCollection()
        {
        }

    }
}