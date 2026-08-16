
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Extra Links Response.
    /// </summary>
    public sealed partial class ExtraLinkCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ExtraLinks { get; set; }

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
        /// Initializes a new instance of the <see cref="ExtraLinkCollectionResponse" /> class.
        /// </summary>
        /// <param name="extraLinks"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtraLinkCollectionResponse(
            object extraLinks,
            int totalEntries)
        {
            this.ExtraLinks = extraLinks ?? throw new global::System.ArgumentNullException(nameof(extraLinks));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraLinkCollectionResponse" /> class.
        /// </summary>
        public ExtraLinkCollectionResponse()
        {
        }

    }
}