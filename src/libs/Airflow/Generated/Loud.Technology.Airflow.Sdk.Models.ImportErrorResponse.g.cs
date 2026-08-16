
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Import Error Response.
    /// </summary>
    public sealed partial class ImportErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import_error_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImportErrorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_name")]
        public string? BundleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stack_trace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StackTrace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportErrorResponse" /> class.
        /// </summary>
        /// <param name="importErrorId"></param>
        /// <param name="timestamp"></param>
        /// <param name="filename"></param>
        /// <param name="stackTrace"></param>
        /// <param name="bundleName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportErrorResponse(
            int importErrorId,
            global::System.DateTime timestamp,
            string filename,
            string stackTrace,
            string? bundleName)
        {
            this.ImportErrorId = importErrorId;
            this.Timestamp = timestamp;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.BundleName = bundleName;
            this.StackTrace = stackTrace ?? throw new global::System.ArgumentNullException(nameof(stackTrace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportErrorResponse" /> class.
        /// </summary>
        public ImportErrorResponse()
        {
        }

    }
}