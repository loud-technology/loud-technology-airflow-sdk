
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Plugin Import Error Collection serializer.
    /// </summary>
    public sealed partial class PluginImportErrorCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PluginImportErrorResponse> ImportErrors { get; set; }

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
        /// Initializes a new instance of the <see cref="PluginImportErrorCollectionResponse" /> class.
        /// </summary>
        /// <param name="importErrors"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PluginImportErrorCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PluginImportErrorResponse> importErrors,
            int totalEntries)
        {
            this.ImportErrors = importErrors ?? throw new global::System.ArgumentNullException(nameof(importErrors));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginImportErrorCollectionResponse" /> class.
        /// </summary>
        public PluginImportErrorCollectionResponse()
        {
        }

    }
}