
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// XCom Collection serializer for responses.
    /// </summary>
    public sealed partial class XComCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xcom_entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.XComResponse> XcomEntries { get; set; }

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
        /// Initializes a new instance of the <see cref="XComCollectionResponse" /> class.
        /// </summary>
        /// <param name="xcomEntries"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XComCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.XComResponse> xcomEntries,
            int totalEntries)
        {
            this.XcomEntries = xcomEntries ?? throw new global::System.ArgumentNullException(nameof(xcomEntries));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XComCollectionResponse" /> class.
        /// </summary>
        public XComCollectionResponse()
        {
        }

    }
}